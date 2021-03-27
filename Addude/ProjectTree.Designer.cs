namespace Addude
{
    partial class ProjectTree
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
            this.DirTree = new System.Windows.Forms.TreeView();
            this.aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DirTree
            // 
            this.DirTree.CheckBoxes = true;
            this.DirTree.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirTree.Location = new System.Drawing.Point(12, 30);
            this.DirTree.Name = "DirTree";
            this.DirTree.Size = new System.Drawing.Size(269, 214);
            this.DirTree.TabIndex = 0;
            this.DirTree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.DirTree_AfterCheck);
            // 
            // aceptar
            // 
            this.aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.aceptar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptar.Location = new System.Drawing.Point(187, 250);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(94, 28);
            this.aceptar.TabIndex = 1;
            this.aceptar.Text = "Accept";
            this.aceptar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select the items you want to exclude";
            // 
            // ProjectTree
            // 
            this.AcceptButton = this.aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 288);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.DirTree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ProjectTree";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView DirTree;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Label label1;
    }
}