namespace LaHuyHoang
{
    partial class MainForm
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
            this.sTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cOUSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sCOREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rESULTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTUDENTToolStripMenuItem,
            this.cOUSEToolStripMenuItem,
            this.sCOREToolStripMenuItem,
            this.rESULTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sTUDENTToolStripMenuItem
            // 
            this.sTUDENTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.studentListToolStripMenuItem,
            this.staticsToolStripMenuItem,
            this.editRemoveToolStripMenuItem,
            this.printToolStripMenuItem,
            this.printToolStripMenuItem1});
            this.sTUDENTToolStripMenuItem.Name = "sTUDENTToolStripMenuItem";
            this.sTUDENTToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.sTUDENTToolStripMenuItem.Text = "STUDENT";
            this.sTUDENTToolStripMenuItem.Click += new System.EventHandler(this.sTUDENTToolStripMenuItem_Click);
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.addNewStudentToolStripMenuItem.Text = "Add New Student";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // studentListToolStripMenuItem
            // 
            this.studentListToolStripMenuItem.BackColor = System.Drawing.Color.SlateBlue;
            this.studentListToolStripMenuItem.Name = "studentListToolStripMenuItem";
            this.studentListToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.studentListToolStripMenuItem.Text = "Student List";
            this.studentListToolStripMenuItem.Click += new System.EventHandler(this.studentListToolStripMenuItem_Click);
            // 
            // staticsToolStripMenuItem
            // 
            this.staticsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.staticsToolStripMenuItem.Name = "staticsToolStripMenuItem";
            this.staticsToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.staticsToolStripMenuItem.Text = "Statics";
            // 
            // editRemoveToolStripMenuItem
            // 
            this.editRemoveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.editRemoveToolStripMenuItem.Name = "editRemoveToolStripMenuItem";
            this.editRemoveToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.editRemoveToolStripMenuItem.Text = "Edit / Remove";
            this.editRemoveToolStripMenuItem.Click += new System.EventHandler(this.editRemoveToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.printToolStripMenuItem.Text = "Manage Student Form";
            // 
            // printToolStripMenuItem1
            // 
            this.printToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.printToolStripMenuItem1.Name = "printToolStripMenuItem1";
            this.printToolStripMenuItem1.Size = new System.Drawing.Size(239, 26);
            this.printToolStripMenuItem1.Text = "Print";
            // 
            // cOUSEToolStripMenuItem
            // 
            this.cOUSEToolStripMenuItem.Name = "cOUSEToolStripMenuItem";
            this.cOUSEToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.cOUSEToolStripMenuItem.Text = "COURSE";
            this.cOUSEToolStripMenuItem.Click += new System.EventHandler(this.cOUSEToolStripMenuItem_Click);
            // 
            // sCOREToolStripMenuItem
            // 
            this.sCOREToolStripMenuItem.Name = "sCOREToolStripMenuItem";
            this.sCOREToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.sCOREToolStripMenuItem.Text = "SCORE";
            // 
            // rESULTToolStripMenuItem
            // 
            this.rESULTToolStripMenuItem.Name = "rESULTToolStripMenuItem";
            this.rESULTToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.rESULTToolStripMenuItem.Text = "RESULT";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 351);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOUSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sCOREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rESULTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem1;
    }
}