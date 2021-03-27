namespace Addude
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.excludeval = new System.Windows.Forms.TextBox();
            this.filenameval = new System.Windows.Forms.TextBox();
            this.outdirval = new System.Windows.Forms.TextBox();
            this.outdirset = new System.Windows.Forms.Button();
            this.gobtn = new System.Windows.Forms.Button();
            this.BrowserOutputDir = new System.Windows.Forms.FolderBrowserDialog();
            this.projectdirval = new System.Windows.Forms.TextBox();
            this.projectdirset = new System.Windows.Forms.Button();
            this.SelectBrowserBin = new System.Windows.Forms.OpenFileDialog();
            this.BrowserProjectDir = new System.Windows.Forms.FolderBrowserDialog();
            this.filext = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveparams = new System.Windows.Forms.ToolStripButton();
            this.infobtn = new System.Windows.Forms.ToolStripButton();
            this.helpbtn = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cleanexcludes = new System.Windows.Forms.Button();
            this.filestree = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // excludeval
            // 
            this.excludeval.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.excludeval.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excludeval.ForeColor = System.Drawing.SystemColors.WindowText;
            this.excludeval.Location = new System.Drawing.Point(138, 70);
            this.excludeval.Name = "excludeval";
            this.excludeval.ReadOnly = true;
            this.excludeval.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.excludeval.Size = new System.Drawing.Size(315, 23);
            this.excludeval.TabIndex = 9;
            // 
            // filenameval
            // 
            this.filenameval.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.filenameval.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filenameval.ForeColor = System.Drawing.SystemColors.WindowText;
            this.filenameval.Location = new System.Drawing.Point(138, 99);
            this.filenameval.Name = "filenameval";
            this.filenameval.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.filenameval.Size = new System.Drawing.Size(315, 23);
            this.filenameval.TabIndex = 13;
            // 
            // outdirval
            // 
            this.outdirval.Cursor = System.Windows.Forms.Cursors.Default;
            this.outdirval.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outdirval.ForeColor = System.Drawing.SystemColors.WindowText;
            this.outdirval.Location = new System.Drawing.Point(138, 41);
            this.outdirval.Name = "outdirval";
            this.outdirval.ReadOnly = true;
            this.outdirval.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.outdirval.Size = new System.Drawing.Size(352, 23);
            this.outdirval.TabIndex = 6;
            // 
            // outdirset
            // 
            this.outdirset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outdirset.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outdirset.Location = new System.Drawing.Point(496, 41);
            this.outdirset.Name = "outdirset";
            this.outdirset.Size = new System.Drawing.Size(31, 23);
            this.outdirset.TabIndex = 7;
            this.outdirset.Text = "...";
            this.outdirset.UseVisualStyleBackColor = true;
            this.outdirset.Click += new System.EventHandler(this.outdirset_Click);
            // 
            // gobtn
            // 
            this.gobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gobtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gobtn.Location = new System.Drawing.Point(226, 168);
            this.gobtn.Name = "gobtn";
            this.gobtn.Size = new System.Drawing.Size(89, 25);
            this.gobtn.TabIndex = 15;
            this.gobtn.Text = "Pack";
            this.gobtn.UseVisualStyleBackColor = true;
            this.gobtn.Click += new System.EventHandler(this.gobtn_Click);
            // 
            // projectdirval
            // 
            this.projectdirval.Cursor = System.Windows.Forms.Cursors.Default;
            this.projectdirval.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectdirval.ForeColor = System.Drawing.SystemColors.WindowText;
            this.projectdirval.Location = new System.Drawing.Point(138, 12);
            this.projectdirval.Name = "projectdirval";
            this.projectdirval.ReadOnly = true;
            this.projectdirval.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.projectdirval.Size = new System.Drawing.Size(352, 23);
            this.projectdirval.TabIndex = 3;
            // 
            // projectdirset
            // 
            this.projectdirset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.projectdirset.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectdirset.Location = new System.Drawing.Point(496, 12);
            this.projectdirset.Name = "projectdirset";
            this.projectdirset.Size = new System.Drawing.Size(31, 23);
            this.projectdirset.TabIndex = 4;
            this.projectdirset.Text = "...";
            this.projectdirset.UseVisualStyleBackColor = true;
            this.projectdirset.Click += new System.EventHandler(this.projectdirset_Click);
            // 
            // SelectBrowserBin
            // 
            this.SelectBrowserBin.Filter = "Exe Files (.exe)|*.exe";
            this.SelectBrowserBin.Title = "Browser executable";
            // 
            // BrowserProjectDir
            // 
            this.BrowserProjectDir.ShowNewFolderButton = false;
            // 
            // filext
            // 
            this.filext.AutoCompleteCustomSource.AddRange(new string[] {
            "xpi",
            "zip",
            "rar"});
            this.filext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filext.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filext.FormattingEnabled = true;
            this.filext.Items.AddRange(new object[] {
            ".crx",
            ".rar",
            ".xpi",
            ".zip"});
            this.filext.Location = new System.Drawing.Point(459, 99);
            this.filext.Name = "filext";
            this.filext.Size = new System.Drawing.Size(68, 22);
            this.filext.Sorted = true;
            this.filext.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Project folder";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(5, 2, 2, 2);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveparams,
            this.infobtn,
            this.helpbtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip1.Size = new System.Drawing.Size(541, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            // 
            // saveparams
            // 
            this.saveparams.Image = global::Addude.Properties.Resources.cassete;
            this.saveparams.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveparams.Name = "saveparams";
            this.saveparams.Size = new System.Drawing.Size(113, 22);
            this.saveparams.Text = "Save parameters";
            this.saveparams.Click += new System.EventHandler(this.saveparams_Click);
            // 
            // infobtn
            // 
            this.infobtn.Image = global::Addude.Properties.Resources.information;
            this.infobtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.infobtn.Name = "infobtn";
            this.infobtn.Size = new System.Drawing.Size(90, 22);
            this.infobtn.Text = "Information";
            this.infobtn.Click += new System.EventHandler(this.infobtn_Click);
            // 
            // helpbtn
            // 
            this.helpbtn.Image = global::Addude.Properties.Resources.question;
            this.helpbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpbtn.Name = "helpbtn";
            this.helpbtn.Size = new System.Drawing.Size(52, 22);
            this.helpbtn.Text = "Help";
            this.helpbtn.Click += new System.EventHandler(this.helpbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.excludeval);
            this.panel1.Controls.Add(this.filext);
            this.panel1.Controls.Add(this.filenameval);
            this.panel1.Controls.Add(this.cleanexcludes);
            this.panel1.Controls.Add(this.filestree);
            this.panel1.Controls.Add(this.projectdirset);
            this.panel1.Controls.Add(this.outdirval);
            this.panel1.Controls.Add(this.projectdirval);
            this.panel1.Controls.Add(this.outdirset);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 134);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Output file name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Exclude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output folder";
            // 
            // cleanexcludes
            // 
            this.cleanexcludes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cleanexcludes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleanexcludes.Image = global::Addude.Properties.Resources.eraser;
            this.cleanexcludes.Location = new System.Drawing.Point(459, 70);
            this.cleanexcludes.Name = "cleanexcludes";
            this.cleanexcludes.Size = new System.Drawing.Size(31, 23);
            this.cleanexcludes.TabIndex = 10;
            this.Info.SetToolTip(this.cleanexcludes, "Clears the exclusion field");
            this.cleanexcludes.UseVisualStyleBackColor = true;
            this.cleanexcludes.Click += new System.EventHandler(this.cleanexcludes_Click);
            // 
            // filestree
            // 
            this.filestree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filestree.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filestree.Image = ((System.Drawing.Image)(resources.GetObject("filestree.Image")));
            this.filestree.Location = new System.Drawing.Point(496, 70);
            this.filestree.Name = "filestree";
            this.filestree.Size = new System.Drawing.Size(31, 23);
            this.filestree.TabIndex = 11;
            this.Info.SetToolTip(this.filestree, "Displays the project file tree and allows you to select the elements you want to " +
                    "exclude in the final archive.");
            this.filestree.UseVisualStyleBackColor = true;
            this.filestree.Click += new System.EventHandler(this.filestree_Click);
            // 
            // Info
            // 
            this.Info.AutoPopDelay = 5000;
            this.Info.InitialDelay = 500;
            this.Info.IsBalloon = true;
            this.Info.ReshowDelay = 100;
            this.Info.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Info.ToolTipTitle = "Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 199);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gobtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Addude v1.0.0.0";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox excludeval;
        private System.Windows.Forms.TextBox filenameval;
        private System.Windows.Forms.TextBox outdirval;
        private System.Windows.Forms.Button outdirset;
        private System.Windows.Forms.Button gobtn;
        private System.Windows.Forms.FolderBrowserDialog BrowserOutputDir;
        private System.Windows.Forms.TextBox projectdirval;
        private System.Windows.Forms.Button projectdirset;
        private System.Windows.Forms.OpenFileDialog SelectBrowserBin;
        private System.Windows.Forms.FolderBrowserDialog BrowserProjectDir;
        private System.Windows.Forms.ComboBox filext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton infobtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton saveparams;
        private System.Windows.Forms.Button filestree;
        private System.Windows.Forms.Button cleanexcludes;
        private System.Windows.Forms.ToolTip Info;
        private System.Windows.Forms.ToolStripButton helpbtn;
    }
}

