using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Addude
{   
    public partial class ProjectTree : Form
    {
        public List<String> Excludes = new List<String>();

        public ProjectTree(String ProjectPath)
        {
            InitializeComponent();
            ListDirectory(DirTree, ProjectPath);
        }

        private void ListDirectory(TreeView treeView, string path)
        {
            DirectoryInfo d = new DirectoryInfo(path);
            foreach (var dir in d.GetDirectories())
            {
                DirectoryInfo da = new DirectoryInfo(Path.Combine(path, dir.ToString()));
                treeView.Nodes.Add(CreateDirectoryNode(da));
            }

            var directoryNode = new TreeNode(d.Name);
            foreach (var file in d.GetFiles())
            {
                treeView.Nodes.Add(new TreeNode(file.Name));
            }
        }

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
            {
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            }

            foreach (var file in directoryInfo.GetFiles())
            {
                directoryNode.Nodes.Add(new TreeNode(file.Name));
            }
            return directoryNode;
        }

        List<String> CheckedNames(TreeNodeCollection theNodes)
        {
            List<String> aResult = new List<String>();

            if (theNodes != null)
            {
                foreach (TreeNode aNode in theNodes)
                {
                    if (aNode.Checked)
                    {
                        aResult.Add(aNode.FullPath);
                    }
                    aResult.AddRange(CheckedNames(aNode.Nodes));
                }
            }
            return aResult;
        }

        private void DirTree_AfterCheck(object sender, TreeViewEventArgs e)
        {
            Excludes = CheckedNames(DirTree.Nodes);
        }
    }
}