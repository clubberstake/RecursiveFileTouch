using System;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using RecursiveFileTouch.FileManagment;

namespace RecursiveFileTouch
{
    public partial class RecursiveTouch : Form
    {
        public RecursiveTouch()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            this.textBoxFolderOpen.Text = folderBrowserDialog.SelectedPath;
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(this.textBoxFolderOpen.Text);
            RecursiveTree recursiveTree = new RecursiveTree();
            Action<String> updateMusicFile = s => TouchFile(s);
            CallbackParams callbackParams = new CallbackParams()
            {
                RootDirectory = dirInfo,
                DelegateMethod = updateMusicFile
            };
            ThreadPool.QueueUserWorkItem(new WaitCallback(recursiveTree.WalkDirectoryTreeCallback), (Object)callbackParams);
            
        }

        private void TouchFile(String file)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<String>(TouchFile), file);
            }

            try
            {
                this.labelActualCurrentFile.Text = file;
                FileInfo fileObject = new FileInfo(file);
                fileObject.Attributes &= ~FileAttributes.ReadOnly;
                File.SetLastWriteTimeUtc(file, DateTime.UtcNow);
            }
            catch (Exception ex)
            {
                // Do nothing
            }
        }

        private void textBoxFolderOpen_MouseHover(object sender, EventArgs e)
        {
            this.toolTipFolderPath.Show("You can copy and paste a path into this box as well.", this.textBoxFolderOpen);
        }
        
    }
}
