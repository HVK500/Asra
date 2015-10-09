using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Prj_Asra
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        // Global vars initialization
        string libDir = Directory.GetCurrentDirectory() + @"\Library";
        string asDir;

        private void mainWindow_Load(object sender, System.EventArgs e)
        {
            // == Self-Versioning-System == //

            // Manually enter the Major & Minor numbers in "AssemblyInfo.cs", Only handles Build & Revision numbers
            decimal ver;
            decimal verCalc;

            // Build [Length-4] 
            ver = Assembly.GetExecutingAssembly().GetName().Version.Build;
            verCalc = ver / 100;
            decimal b =  Math.Round(verCalc);

            // Revision [Length-5]
            ver = Assembly.GetExecutingAssembly().GetName().Version.Revision;
            verCalc = ver / 1000;
            decimal r = Math.Round(verCalc);

            // Auto output of the new build number - Title & Win Text
            string fullVersion = "1.0." + b + "r" + r;// (Assembly.GetExecutingAssembly().GetName().Version).ToString().Remove(4, 10) Removed -> caused problems (OutOfRange exception)
            lblVersion.Text = "v" + fullVersion;
            //Text = "ASRA - v" + fullVersion;

            // == Self-Versioning-System == //

            // Creates the library directory if there isn't one
            if (!(Directory.Exists(libDir)))
            {
                try
                {
                    Directory.CreateDirectory("Library");
                }
                catch (Exception f)
                {
                    MessageBox.Show("The following error occured while trying to create your Library folder: " + f);
                }
                
                lBox.Items.Add("Created your Library folder...");
                cmBox.Enabled = false;
            }
            // Loads the xml files if there is a library directory
            else
            {
                //Load and read all xml files - output in dropdown menu
                //Checking wherther the folder is empty, else loading found xml files
                int xmlCount = Directory.GetFiles(libDir, "*.xml", SearchOption.TopDirectoryOnly).Length;
                lBox.Items.Add("Found your library - Loading all Anime/Series...");
                lBox.Items.Add("Found " + xmlCount + " entries in your library...");

                if (xmlCount == 0)
                {
                    cmBox.Enabled = false;
                    btnCmDel.Enabled = false;
                }
                else if (xmlCount > 0)
                {
                    // Get the xml file name and output to the combobox
                    DirectoryInfo dir = new DirectoryInfo(libDir);
                    FileInfo[] xmlArray = dir.GetFiles("*.xml", SearchOption.TopDirectoryOnly);
                    foreach (FileInfo f in xmlArray)
                    {
                        cmBox.Items.Add(Path.GetFileNameWithoutExtension(f.Name));
                    }
                }
            }

        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            // Closes form
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Resets all the fields
            lBox.Items.Clear();
            txtName.Text = "";
            numEpisode.Value = 1;
            numSeason.Value = 1;
            txtName.Enabled = true;
            chbComplete.Checked = false;
            cmBox.SelectedIndex = -1;
            btnBrowseTo.Enabled = false;
        }

        private void chbComplete_CheckedChanged(object sender, EventArgs e)
        {
            // Validation
            if (chbComplete.Checked == true)
            {
                txtName.Enabled = false;
                numEpisode.Enabled = false;
                numSeason.Enabled = false;
            }
            else if (chbComplete.Checked == false)
            {
                if (cmBox.Items.Contains(txtName.Text) == false)
                {
                    txtName.Enabled = true;
                }
                numEpisode.Enabled = true;
                numSeason.Enabled = true;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //Enabling the chbComplete & cmbox only if theres an name to the Anime/Series
            if (String.IsNullOrWhiteSpace(txtName.Text) == true)
            {
                chbComplete.Enabled = false;
                numEpisode.Enabled = false;
                numSeason.Enabled = false;
                btnClear.Enabled = false;
                btnSave.Enabled = false;
            }
            else
            {
                chbComplete.Enabled = true;
                numEpisode.Enabled = true;
                numSeason.Enabled = true;
                btnClear.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        private void btnLboxClear_Click(object sender, EventArgs e)
        {
            // Clears the listbox
            lBox.Items.Clear();
        }

        private void cmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Specifes where the .exe file is and reads the Library folder 
            string fileName = cmBox.Text;

            // Reading txt file to output the read name of the txtName box
            if (cmBox.SelectedIndex != -1 && cmBox.Text != txtName.Text)
            {
                try
                {
                    // *== XML-Reader ==*
                    // Load XML and read the data
                    XmlDocument xmlDoc = new XmlDocument();
                    FileStream fs = new FileStream((libDir + @"\" + fileName + ".xml"), FileMode.Open, FileAccess.Read);
                    xmlDoc.Load(fs);

                    // Output the result of the xml read to controls and to the listbox
                    string curName = xmlDoc.GetElementsByTagName("libData")[0].ChildNodes.Item(0).InnerText.Trim();
                    txtName.Text = curName;
                    txtName.Enabled = false;

                    // Checks whether the "Complete" option is true or false - output accordingly
                    if (xmlDoc.GetElementsByTagName("libData")[0].ChildNodes.Item(1).InnerText.Trim().ToString() == "false")
                    {
                        // Read & parse the data
                        chbComplete.Checked = false;
                        decimal nextEpi = Decimal.Parse(xmlDoc.GetElementsByTagName("libData")[0].ChildNodes.Item(2).InnerText.Trim());
                        decimal currSeas = Decimal.Parse(xmlDoc.GetElementsByTagName("libData")[0].ChildNodes.Item(3).InnerText.Trim());
                        string asLoc = xmlDoc.GetElementsByTagName("libData")[0].ChildNodes.Item(4).InnerText.Trim();

                        // Output the xml data to the listbox
                        lBox.Items.Clear();
                        lBox.Items.Add("Name: " + curName);
                        lBox.Items.Add("To watch next: " + nextEpi);
                        lBox.Items.Add("Season: " + currSeas);
                        lBox.Items.Add("Located in: " + '"' + asLoc + '"');

                        // Sets the numeric reels to the numbers on the xml file
                        numEpisode.Value = nextEpi;
                        numSeason.Value = currSeas;

                        // Sets the A/S Directory so that you can navigate to the folder
                        asDir = asLoc;
                        btnBrowseTo.Enabled = true;
                    }
                    else if (xmlDoc.GetElementsByTagName("libData")[0].ChildNodes.Item(1).InnerText.Trim().ToString() == "true")
                    {
                        // Outputs that the A/S is completed in the listbox
                        chbComplete.Checked = true;
                        lBox.Items.Clear();
                        lBox.Items.Add(curName + " is Complete!");
                        btnBrowseTo.Enabled = true;
                    }
                    fs.Close();

                }
                catch (Exception f)
                {
                    MessageBox.Show("The following error occured while trying to read a file from your Library: " + f);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // For (Step 5.) The asDir needs to be set
            // Means its a fresh entry, meaning it needs to ask for the location (creating an new entry)
            if (txtName.Enabled == true)
            {
                // Cleans the given name of redundent symbols
                string cleanName = cleanseString(txtName.Text);

                // Check wherther the entered name exsists already in the library directory (Because it is a brand new entry)
                if (cmBox.Items.Contains(cleanName) == false)
                {
                    if (browserDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Sets the global var to the selected path to input in to the xml document
                        asDir = browserDialog.SelectedPath;

                        // Write the data to xml file and saves it
                        xmlWrite(cleanName);

                        // Add the new entry to the combobox
                        cmBox.Enabled = true;
                        cmBox.Items.Add(cleanName);
                        btnCmDel.Enabled = true;

                        // Clear the fields and combobox to -1
                        btnClear_Click(sender, e);

                        // Clear & Print succes message to listbox
                        lBox.Items.Clear();
                        lBox.Items.Add("Entry - " + '"' + cleanName + '"' + " - Saved Successfully to your library.");

                    }
                    else
                    {
                        MessageBox.Show("The library entry was not saved, please specify a location for the entry.", "Could not save library entry!", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("The entry you are trying to save already exists in your library.", "Library entry already exists", MessageBoxButtons.OK);
                }
                
            }
            // Means it doesn't need the location again (editing a previous entry)
            else if (txtName.Enabled == false)
            {
                string cleanName = cleanseString(txtName.Text);

                if (chbComplete.Checked == true && cmBox.Items.Contains(cleanName) == false)
                {
                    if (browserDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Sets the global var to the selected path to input in to the xml document
                        asDir = browserDialog.SelectedPath;

                        // Write the data to xml file and saves it
                        xmlWrite(cleanName);

                        // Add the new entry to the combobox
                        cmBox.Enabled = true;
                        cmBox.Items.Add(cleanName);
                        btnCmDel.Enabled = true;

                        // Clear the fields and combobox to -1
                        btnClear_Click(sender, e);

                        // Clear & Print succes message to listbox
                        lBox.Items.Clear();
                        lBox.Items.Add("Entry - " + '"' + cleanName + '"' + " - Saved Successfully to your library.");
                    }
                    else
                    {
                        MessageBox.Show("The library entry was not saved, please specify a location for the entry.", "Could not save library entry!", MessageBoxButtons.OK);
                    }
                }
                else if (cmBox.Items.Contains(cleanName) == true)
                {
                    // Write the data to xml file and saves it
                    xmlWrite(cleanName);

                    // Clear the fields and combobox
                    btnClear_Click(sender, e);

                    // Clear & Print succes message to listbox
                    lBox.Items.Clear();
                    lBox.Items.Add("Entry - " + '"' + cleanName + '"' + " - Updated Successfully in your library.");
                }
            }
        }

        private void btnCmDel_Click(object sender, EventArgs e)
        {
            string fileName = cmBox.Text;
            DialogResult delYesNo = MessageBox.Show("Delete " + '"' + fileName + '"' + " from your library?", "Delete - " + fileName + "?", MessageBoxButtons.YesNo);
            if (delYesNo == DialogResult.Yes)
            {
                try
                {
                    // Deletes the selected library item and checks whether there are any items left
                    File.Delete(libDir + @"\" + fileName + ".xml");
                    cmBox.Items.Remove(fileName);
                    btnClear_Click(sender, e);
                    cmBox.SelectedIndex = -1;

                    if (cmBox.Items.Count == 0)
                    {
                        btnCmDel.Enabled = false;
                        cmBox.Enabled = false;
                    }

                    // Clear & Print succes message to listbox
                    lBox.Items.Clear();
                    lBox.Items.Add("Entry - " + '"' + cmBox.SelectedValue + '"' + " - Deleted Successfully from your library.");
                }
                catch (Exception f)
                {
                    MessageBox.Show("The following error is blocking you from deleting " + '"' + cmBox.SelectedValue + '"' + " from your library: " + f);
                }
            }
        }

        private void btnBrowseTo_Click(object sender, EventArgs e)
        {
            try
            {
                // Opens the directory specified in the xml
                Process.Start(asDir);
            }
            // Handles the "Cannot find the drive specified" exception
            catch (Win32Exception)
            {
                if (MessageBox.Show("Cannot find the drive specified, Please connect drive and then click Retry.", "ASRA cannot find the drive specified", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    btnBrowseTo_Click(sender, e);
                }
            }
            
        }

        public string cleanseString(string str)
        {
            // Handles the cleaning of a string
            StringBuilder cs = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '-' || c == ' ' || c == '!')
                {
                    cs.Append(c);
                }
            }
            return cs.ToString();
        }

        public void xmlWrite(string str)
        {
            try
            {
                // *=== XML Writer ==*
                XmlSerializer writer = new XmlSerializer(typeof(libData));
                // --Entering the information in with the xml writer
                libData newData = new libData();

                // 1. Sets the name
                newData.name = str;
                // 2. Sets whether completes is true or false
                newData.complete = chbComplete.Checked;
                // 3. Sets the episode number - note: decimal datatype!
                newData.episode = numEpisode.Value;
                // 4. Sets the season number - note: decimal datatype!
                newData.season = numSeason.Value;
                // 5.  & Sets the location of the A/S
                newData.location = asDir;

                // Save the data to the xml container in the library directory
                StreamWriter libFile = new StreamWriter(libDir + @"\" + str + ".xml");
                writer.Serialize(libFile, newData);
                libFile.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("The library entry was not saved, due to the following error: " + e);
            }
            
        }
    }
}
