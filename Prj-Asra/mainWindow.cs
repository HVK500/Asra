using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace Prj_Asra
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        // Global vars
        // Create a folder where the application was executed
        string libDir = Directory.GetCurrentDirectory() + @"\Library";

        private void mainWindow_Load(object sender, System.EventArgs e)
        {
            // Auto output of the new build number - Title & Win Text
            lblVersion.Text = "v" + (Assembly.GetExecutingAssembly().GetName().Version).ToString();
            Text = "ASRA - v" + (Assembly.GetExecutingAssembly().GetName().Version).ToString();

            //System.IO.Directory.GetCurrentDirectory()
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
            else
            {
                //Load and read all txt files - output in dropdown menu
                //Checking wherther the folder is empty, else loading found xml files
                int xmlCount = Directory.GetFiles(libDir, "*.xml", SearchOption.TopDirectoryOnly).Length;
                lBox.Items.Add("Found your Library - Loading all Anime/Series...");
                lBox.Items.Add("Found " + xmlCount + " files in your Library...");

                if (xmlCount == 0)
                {
                    cmBox.Enabled = false;
                }
                else if (xmlCount > 0)
                {
                    char[] end = {'.', 'x', 'm', 'l'};
                    DirectoryInfo dir = new DirectoryInfo(libDir);
                    foreach (FileInfo flInfo in dir.GetFiles("*.xml"))
                    {
                        String name = flInfo.Name;
                        cmBox.Items.Add(name.TrimEnd(end));
                    }
                }
            }

        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtEpisode.Text = "";
            txtSeason.Text = "";
            txtName.Enabled = true;
            chbComplete.Checked = false;
            cmBox.SelectedIndex = -1;
        }

        private void chbComplete_CheckedChanged(object sender, EventArgs e)
        {
            if (chbComplete.Checked == true)
            {
                txtName.Enabled = false;
                txtEpisode.Enabled = false;
                txtSeason.Enabled = false;
            }
            else if (chbComplete.Checked == false)
            {
                txtEpisode.Enabled = true;
                txtSeason.Enabled = true;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //Enabling the chbComplete & cmbox only if theres an name to the Anime/Series
            if (String.IsNullOrWhiteSpace(txtName.Text) == true)
            {
                chbComplete.Enabled = false;
            }
            else
            {
                chbComplete.Enabled = true;
            }
        }

        private void btnLboxClear_Click(object sender, EventArgs e)
        {
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
                    string curName = xmlDoc.GetElementsByTagName("asra")[0].ChildNodes.Item(0).InnerText.Trim();
                    txtName.Text = curName;
                    txtName.Enabled = false;

                    if (xmlDoc.GetElementsByTagName("asra")[0].ChildNodes.Item(1).InnerText.Trim().ToString() == "false")
                    {
                        chbComplete.Checked = false;
                        lBox.Items.Clear();
                        lBox.Items.Add("Name: " + curName);
                        lBox.Items.Add("To watch next: " + xmlDoc.GetElementsByTagName("asra")[0].ChildNodes.Item(2).InnerText.Trim());
                        lBox.Items.Add("Season: " + xmlDoc.GetElementsByTagName("asra")[0].ChildNodes.Item(3).InnerText.Trim());
                    }
                    else if (xmlDoc.GetElementsByTagName("asra")[0].ChildNodes.Item(1).InnerText.Trim().ToString() == "true")
                    {
                        chbComplete.Checked = true;
                        lBox.Items.Clear();
                        lBox.Items.Add(curName + " is Complete!");
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
            // Implement XML Writer and save to library
        }

        private void btnCmDel_Click(object sender, EventArgs e)
        {
            string fileName = cmBox.Text;
            DialogResult delYesNo = MessageBox.Show("Delete this from your library?", "Delete - " + fileName, MessageBoxButtons.YesNo);
            if (delYesNo == DialogResult.Yes)
            {
                File.Delete(libDir + @"\" + fileName + ".xml");
            }
        }
    }
}
