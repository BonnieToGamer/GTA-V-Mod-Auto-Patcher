using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace GTAVAutoPatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string projectName;
        private string directory;

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"C:\";
            dialog.RestoreDirectory = true;
            dialog.Title = "Browse CSProj Files";
            dialog.DefaultExt = "csproj";
            dialog.Filter = "csproj files(*.csproj) | *.csproj";
            dialog.FilterIndex = 2;
            dialog.CheckPathExists = true;
            dialog.CheckFileExists = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.txtBoxCSharp.Text = dialog.FileName;
                projectName = dialog.SafeFileName;
                projectName = projectName.Replace(".csproj", "");
                directory = this.txtBoxCSharp.Text;
                directory = directory.Replace(projectName + ".csproj", "");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.SelectedPath.EndsWith("Grand Theft Auto V"))
                    this.txtBoxGTAV.Text = dialog.SelectedPath;
                else
                    MessageBox.Show("You have to enter the GTA V path");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txtBoxGTAV.Text == string.Empty || this.txtBoxCSharp.Text == string.Empty)
            {
                MessageBox.Show("You have to put in the two requied folders");
            }

            else
            {
                string batchFile = "set mypath=%cd%\n";
                batchFile += "del ScriptHookVDotNet2.dll, ScriptHookVDotNet2.xml\n";
                batchFile += "copy \"%mypath%/*.dll\" \"" + this.txtBoxGTAV.Text + "\"\n";
                batchFile += "copy \"%mypath%/*.pdb\" \"" + this.txtBoxGTAV.Text + "\"\n";
                batchFile += "del \" % mypath %/*.dll\", \" % mypath %/*.pdb\"\n";

                StreamWriter sw = new StreamWriter(directory + @"\bin\debug\move.bat");

                sw.WriteLine(batchFile);

                sw.Flush();

                Application.DoEvents();

                if (this.txtBoxCSharp.Text == string.Empty || !this.txtBoxCSharp.Text.EndsWith(".csproj"))
                {
                    MessageBox.Show("You have to enter a path to a project");
                    return;
                }

                XmlDocument doc = new XmlDocument();
                doc.Load(this.txtBoxCSharp.Text);

                XmlNode root = doc.DocumentElement;
                XmlNode propGroup = doc.CreateElement("PropertyGroup");
                XmlNode node = doc.CreateElement("PostBuildEvent");
                XmlNode makePropGroup = root.AppendChild(propGroup);
                XmlNode buildPropertyGroup = makePropGroup.AppendChild(node);

                buildPropertyGroup.InnerText = "call \"$(SolutionDir)\\" + projectName + "\\bin\\Debug\\move.bat\"";

                string docString = doc.OuterXml.ToString();
                docString = docString.Replace("xmlns=\"\"", "");
                doc.LoadXml(docString);


                doc.Save(this.txtBoxCSharp.Text);

                MessageBox.Show("Completed");
                Application.Exit();
            }
        }
    }
}
