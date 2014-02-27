namespace RecursiveFileTouch
{
    partial class RecursiveTouch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelFolderOpen = new System.Windows.Forms.Label();
            this.textBoxFolderOpen = new System.Windows.Forms.TextBox();
            this.labelCurrentFile = new System.Windows.Forms.Label();
            this.labelActualCurrentFile = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTipFolderPath = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(13, 13);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 0;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelFolderOpen
            // 
            this.labelFolderOpen.AutoSize = true;
            this.labelFolderOpen.Location = new System.Drawing.Point(95, 22);
            this.labelFolderOpen.Name = "labelFolderOpen";
            this.labelFolderOpen.Size = new System.Drawing.Size(77, 13);
            this.labelFolderOpen.TabIndex = 1;
            this.labelFolderOpen.Text = "Folder Open ->";
            // 
            // textBoxFolderOpen
            // 
            this.textBoxFolderOpen.Location = new System.Drawing.Point(179, 14);
            this.textBoxFolderOpen.Name = "textBoxFolderOpen";
            this.textBoxFolderOpen.Size = new System.Drawing.Size(682, 20);
            this.textBoxFolderOpen.TabIndex = 2;
            this.textBoxFolderOpen.MouseHover += new System.EventHandler(this.textBoxFolderOpen_MouseHover);
            // 
            // labelCurrentFile
            // 
            this.labelCurrentFile.AutoSize = true;
            this.labelCurrentFile.Location = new System.Drawing.Point(13, 257);
            this.labelCurrentFile.Name = "labelCurrentFile";
            this.labelCurrentFile.Size = new System.Drawing.Size(72, 13);
            this.labelCurrentFile.TabIndex = 3;
            this.labelCurrentFile.Text = "Current File ->";
            // 
            // labelActualCurrentFile
            // 
            this.labelActualCurrentFile.AutoSize = true;
            this.labelActualCurrentFile.Location = new System.Drawing.Point(92, 256);
            this.labelActualCurrentFile.Name = "labelActualCurrentFile";
            this.labelActualCurrentFile.Size = new System.Drawing.Size(0, 13);
            this.labelActualCurrentFile.TabIndex = 4;
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(13, 52);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 5;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // toolTipFolderPath
            // 
            this.toolTipFolderPath.AutoPopDelay = 5000;
            this.toolTipFolderPath.InitialDelay = 100;
            this.toolTipFolderPath.ReshowDelay = 100;
            // 
            // RecursiveTouch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 282);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.labelActualCurrentFile);
            this.Controls.Add(this.labelCurrentFile);
            this.Controls.Add(this.textBoxFolderOpen);
            this.Controls.Add(this.labelFolderOpen);
            this.Controls.Add(this.buttonBrowse);
            this.Name = "RecursiveTouch";
            this.Text = "Recursive Touch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelFolderOpen;
        private System.Windows.Forms.TextBox textBoxFolderOpen;
        private System.Windows.Forms.Label labelCurrentFile;
        private System.Windows.Forms.Label labelActualCurrentFile;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolTip toolTipFolderPath;
    }
}

