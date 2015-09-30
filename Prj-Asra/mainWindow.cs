using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

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
                    DirectoryInfo dir = new DirectoryInfo(libDir);
                    foreach (FileInfo flInfo in dir.GetFiles("*.xml"))
                    {
                        String name = flInfo.Name;
                        cmBox.Items.Add(name);
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
            //txtName.Text = cmBox.SelectedValue.ToString();
            //Specifes where the .exe file is and reads the Library folder 
            string fileName = null;
            try
            {
                fileName = cmBox.SelectedValue.ToString();
            }
            catch (Exception)
            {
                fileName = null;
            }

            //Reading txt file to output the read name of the txtName box       =============> Start adding the xml communication here
            if (!cmBox.SelectedIndex.Equals(0))
            {
                try
                {
                    //Reads selected text file in dropdown list
                    using (StreamReader sr = new StreamReader(libDir + @"\" + fileName))
                    {
                        sr.BaseStream.Seek(6, SeekOrigin.Begin);
                        string chkName = sr.ReadLine();
                        txtName.Text = "" + chkName;
                        txtName.Enabled = false;
                        sr.DiscardBufferedData();
                        sr.Close();
                    }
                }
                catch (Exception)
                {
                }
                //Reading txt file to output the read information the listbox
                try
                {
                    //Reads selected text file in dropdown list
                    using (StreamReader sr = new StreamReader(libDir + @"\" + fileName))
                    {
                        string read = sr.ReadToEnd();
                        lBox.Items.Clear();
                        lBox.Items.Add(read);
                        sr.DiscardBufferedData();
                        sr.Close();
                    }
                }
                catch (Exception)
                {
                }
            }
            //Complete box
            if (!cmBox.SelectedIndex.Equals(0))
            {
                try
                {
                    btnCmDel.Enabled = true;
                }
                catch (Exception)
                {
                }
            }
            else
            {
                try
                {
                    btnCmDel.Enabled = false;
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
