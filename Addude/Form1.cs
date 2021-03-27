using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.IO.Compression;
using System.Diagnostics;

namespace Addude
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            filext.SelectedIndex = 0;

            // LOAD CONFIGS
            string pd = Properties.Settings.Default.projectdir;
            string od = Properties.Settings.Default.outputdir;
            //string bw = Properties.Settings.Default.browserexe;
            string ex = Properties.Settings.Default.exclude;
            string fn = Properties.Settings.Default.outfilename;
            int    xt = Properties.Settings.Default.filext;

            projectdirval.Text = pd;
            outdirval.Text = od;
            //browserval.Text = bw;
            excludeval.Text = ex;
            filenameval.Text = fn;
            filext.SelectedIndex = xt;
        }

        private void infobtn_Click(object sender, EventArgs e)
        {
            Info INFW;
            INFW = new Info();
            INFW.ShowDialog();
        }

        private void filestree_Click(object sender, EventArgs e)
        {
            if (projectdirval.Text != "")
            {
                ProjectTree TREW;
                TREW = new ProjectTree(projectdirval.Text);
                DialogResult res = TREW.ShowDialog();

                if (res == DialogResult.OK)
                {
                    excludeval.Clear();
                    foreach (var item in TREW.Excludes)
                    {
                        excludeval.AppendText(item + ",");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a project folder.");
            }
        }

        private void saveparams_Click(object sender, EventArgs e)
        {
            string pd = projectdirval.Text;
            string od = outdirval.Text;
            //string bw = browserval.Text;
            string ex = excludeval.Text;
            string fn = filenameval.Text;
            int xt = filext.SelectedIndex;


            Properties.Settings.Default.projectdir = pd;
            Properties.Settings.Default.outputdir = od;
            //Properties.Settings.Default.browserexe = bw;
            Properties.Settings.Default.exclude = ex;
            Properties.Settings.Default.outfilename = fn;
            Properties.Settings.Default.filext = xt;

            Properties.Settings.Default.Save();
            MessageBox.Show("Parameters saved!");
        }


        private void projectdirset_Click(object sender, EventArgs e)
        {
            DialogResult result = BrowserProjectDir.ShowDialog();
            if (result == DialogResult.OK)
            {
                projectdirval.Text = BrowserProjectDir.SelectedPath.ToString();
            }
        }

        private void outdirset_Click(object sender, EventArgs e)
        {
            DialogResult result = BrowserOutputDir.ShowDialog();
            if (result == DialogResult.OK)
            {
                outdirval.Text = BrowserOutputDir.SelectedPath.ToString();
            }
        }
        /*
        private void browserset_Click(object sender, EventArgs e)
        {
            DialogResult result = SelectBrowserBin.ShowDialog();
            if (result == DialogResult.OK)
            {
                browserval.Text = SelectBrowserBin.FileName.ToString();
            }
        }
        */

        private void gobtn_Click(object sender, EventArgs e)
        {
            // CHECK PROJECT DIRECTORY
            if (String.IsNullOrEmpty(projectdirval.Text))
            {
                MessageBox.Show("Please select the project directory.");
            }
            else
            {
                // CHECK OUTPUT DIRECTORY
                if (String.IsNullOrEmpty(outdirval.Text))
                {
                    MessageBox.Show("Please select the output directory.");
                }
                else
                {

                    // CHECK VALID OR EMPTY FILE NAME
                    if (String.IsNullOrEmpty(filenameval.Text))
                    {
                        MessageBox.Show("Please fill the file name field.");
                    }
                    else
                    {
                        string filename = filenameval.Text;
                        if (filename.IndexOfAny(System.IO.Path.GetInvalidFileNameChars()) != -1)
                        {
                            MessageBox.Show("The filename is invalid");
                        }
                        else
                        {
                            // VALIDATE EMPTY FILENAME
                            // MERGE OUTPUT DIRECTORY, FILENAME AND EXTENSION

                            // OUTPUT DIRECORY
                            string OutputPath = outdirval.Text;

                            // FILE NAME
                            string FileName = filenameval.Text;

                            // FILE EXTENSION
                            string ext = filext.Text;

                            // FINAL FILEPATH
                            string FinalPath = Path.Combine(OutputPath, FileName + ext);
    
                            // GET FILES AND FOLDERS FROM PROJECT DIRECTORY
                            string ProjectPath = projectdirval.Text;

                            string[] Files = Directory.GetFiles(ProjectPath);
                            string[] Folders = Directory.GetDirectories(ProjectPath);

                            // GET EXCLUDES
                            string Excludes = excludeval.Text;
                            string[] Exclds =
                                Excludes.Split(new char[] {','},
                                    StringSplitOptions.RemoveEmptyEntries);

                            // MERGE FILES AND FOLDERS LISTS
                            var AllItems = Files.Concat(Folders).ToList();

                            string directory = Directory.GetCurrentDirectory();
                            Compress(AllItems, Exclds, FinalPath);

                        } // CLOSE CHECK FILE NAME
                    } // CLOSE CHECK VALID OR EMPTY FILE NAME
                } // CLOSE CHECK OUTPUT DIRECTORY
            } // CLOSE CHECK PROJECT DIRECTORY
        }

        private void Compress(List<string> AllItems, String[] Excludes, String FinalPath)
        {
            List<String> Exclds = new List<String>();
            foreach (var item in Excludes)
            {
                Exclds.Add(String.Format("-x\"{0}\"", item));
            }

            var exargs = String.Join(" ", Exclds.ToArray());
            Console.WriteLine(exargs);

            string directory = Directory.GetCurrentDirectory();
            string RarExe = Path.Combine(directory, "Rar.exe");
            Directory.SetCurrentDirectory(projectdirval.Text);

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = RarExe;
            startInfo.Arguments = String.Format("a -r {0} {1}", exargs, FinalPath);
            Console.WriteLine( String.Format("a -r {0} {1}", exargs, FinalPath));
            //startInfo.RedirectStandardOutput = true;
            //startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            Process processTemp = new Process();
            processTemp.StartInfo = startInfo;
            processTemp.EnableRaisingEvents = true;
            try
            {
                processTemp.Start();
                MessageBox.Show("All is well :)");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            Directory.SetCurrentDirectory(directory);
        }

        private void cleanexcludes_Click(object sender, EventArgs e)
        {
            excludeval.Clear();
        }

        private void helpbtn_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Addude.chm");
        }
    }
}
