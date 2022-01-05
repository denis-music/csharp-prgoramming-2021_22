using System.Collections.Generic;

namespace DLWMS.WinForms
{
    partial class frmGlavna
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaStudenataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.igreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.krajProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(572, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentiToolStripMenuItem,
            this.igreToolStripMenuItem,
            this.toolStripSeparator1,
            this.krajProgramaToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // studentiToolStripMenuItem
            // 
            this.studentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviStudentToolStripMenuItem,
            this.pretragaStudenataToolStripMenuItem});
            this.studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
            this.studentiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.studentiToolStripMenuItem.Text = "Studenti";
            // 
            // noviStudentToolStripMenuItem
            // 
            this.noviStudentToolStripMenuItem.Name = "noviStudentToolStripMenuItem";
            this.noviStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noviStudentToolStripMenuItem.Text = "Novi student";
            this.noviStudentToolStripMenuItem.Click += new System.EventHandler(this.noviStudentToolStripMenuItem_Click);
            // 
            // pretragaStudenataToolStripMenuItem
            // 
            this.pretragaStudenataToolStripMenuItem.Name = "pretragaStudenataToolStripMenuItem";
            this.pretragaStudenataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pretragaStudenataToolStripMenuItem.Text = "Pretraga studenata";
            this.pretragaStudenataToolStripMenuItem.Click += new System.EventHandler(this.pretragaStudenataToolStripMenuItem_Click);
            // 
            // igreToolStripMenuItem
            // 
            this.igreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xOToolStripMenuItem});
            this.igreToolStripMenuItem.Name = "igreToolStripMenuItem";
            this.igreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.igreToolStripMenuItem.Text = "Igre";
            // 
            // xOToolStripMenuItem
            // 
            this.xOToolStripMenuItem.Name = "xOToolStripMenuItem";
            this.xOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xOToolStripMenuItem.Text = "XO";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // krajProgramaToolStripMenuItem
            // 
            this.krajProgramaToolStripMenuItem.Name = "krajProgramaToolStripMenuItem";
            this.krajProgramaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.krajProgramaToolStripMenuItem.Text = "Kraj programa";
            this.krajProgramaToolStripMenuItem.Click += new System.EventHandler(this.krajProgramaToolStripMenuItem_Click);
            // 
            // frmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 385);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGlavna";
            this.Text = "DLWMS :: v.4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaStudenataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem igreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xOToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem krajProgramaToolStripMenuItem;
    }

    partial class Student
    {
        public int Indeks { get; set; }
        public List<int> Ocjene { get; set; } = new List<int>();
    }
}

