namespace exam_late_2012
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.EmployeeTab = new System.Windows.Forms.TabPage();
            this.EmployeeControl = new exam_late_2012.BaseTabControl();
            this.PrticipantTab = new System.Windows.Forms.TabPage();
            this.ParticipantControl = new exam_late_2012.BaseTabControl();
            this.CourseTab = new System.Windows.Forms.TabPage();
            this.CourseControl = new exam_late_2012.BaseTabControl();
            this.ClassTab = new System.Windows.Forms.TabPage();
            this.ClassControl = new exam_late_2012.BaseTabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deltagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kursusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medarbejderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lærerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontorassistentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fakturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.åbnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redigerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hjælpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hjælpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.EmployeeTab.SuspendLayout();
            this.PrticipantTab.SuspendLayout();
            this.CourseTab.SuspendLayout();
            this.ClassTab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.EmployeeTab);
            this.tabControl1.Controls.Add(this.PrticipantTab);
            this.tabControl1.Controls.Add(this.CourseTab);
            this.tabControl1.Controls.Add(this.ClassTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(887, 494);
            this.tabControl1.TabIndex = 0;
            // 
            // EmployeeTab
            // 
            this.EmployeeTab.Controls.Add(this.EmployeeControl);
            this.EmployeeTab.Location = new System.Drawing.Point(4, 22);
            this.EmployeeTab.Name = "EmployeeTab";
            this.EmployeeTab.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeTab.Size = new System.Drawing.Size(879, 468);
            this.EmployeeTab.TabIndex = 0;
            this.EmployeeTab.Text = "Medarbejdere";
            this.EmployeeTab.UseVisualStyleBackColor = true;
            // 
            // EmployeeControl
            // 
            this.EmployeeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeControl.Location = new System.Drawing.Point(3, 3);
            this.EmployeeControl.Name = "EmployeeControl";
            this.EmployeeControl.Size = new System.Drawing.Size(873, 462);
            this.EmployeeControl.TabIndex = 0;
            // 
            // PrticipantTab
            // 
            this.PrticipantTab.Controls.Add(this.ParticipantControl);
            this.PrticipantTab.Location = new System.Drawing.Point(4, 22);
            this.PrticipantTab.Name = "PrticipantTab";
            this.PrticipantTab.Padding = new System.Windows.Forms.Padding(3);
            this.PrticipantTab.Size = new System.Drawing.Size(879, 468);
            this.PrticipantTab.TabIndex = 1;
            this.PrticipantTab.Text = "Deltagere";
            this.PrticipantTab.UseVisualStyleBackColor = true;
            // 
            // ParticipantControl
            // 
            this.ParticipantControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParticipantControl.Location = new System.Drawing.Point(3, 3);
            this.ParticipantControl.Name = "ParticipantControl";
            this.ParticipantControl.Size = new System.Drawing.Size(873, 462);
            this.ParticipantControl.TabIndex = 0;
            // 
            // CourseTab
            // 
            this.CourseTab.Controls.Add(this.CourseControl);
            this.CourseTab.Location = new System.Drawing.Point(4, 22);
            this.CourseTab.Name = "CourseTab";
            this.CourseTab.Padding = new System.Windows.Forms.Padding(3);
            this.CourseTab.Size = new System.Drawing.Size(879, 468);
            this.CourseTab.TabIndex = 2;
            this.CourseTab.Text = "Kurser";
            this.CourseTab.UseVisualStyleBackColor = true;
            // 
            // CourseControl
            // 
            this.CourseControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CourseControl.Location = new System.Drawing.Point(3, 3);
            this.CourseControl.Name = "CourseControl";
            this.CourseControl.Size = new System.Drawing.Size(873, 462);
            this.CourseControl.TabIndex = 0;
            // 
            // ClassTab
            // 
            this.ClassTab.Controls.Add(this.ClassControl);
            this.ClassTab.Location = new System.Drawing.Point(4, 22);
            this.ClassTab.Name = "ClassTab";
            this.ClassTab.Padding = new System.Windows.Forms.Padding(3);
            this.ClassTab.Size = new System.Drawing.Size(879, 468);
            this.ClassTab.TabIndex = 3;
            this.ClassTab.Text = "Hold";
            this.ClassTab.UseVisualStyleBackColor = true;
            // 
            // ClassControl
            // 
            this.ClassControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassControl.Location = new System.Drawing.Point(3, 3);
            this.ClassControl.Name = "ClassControl";
            this.ClassControl.Size = new System.Drawing.Size(873, 462);
            this.ClassControl.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filerToolStripMenuItem,
            this.redigerToolStripMenuItem,
            this.hjælpToolStripMenuItem,
            this.hjælpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filerToolStripMenuItem
            // 
            this.filerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyToolStripMenuItem,
            this.åbnToolStripMenuItem});
            this.filerToolStripMenuItem.Name = "filerToolStripMenuItem";
            this.filerToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.filerToolStripMenuItem.Text = "Filer";
            // 
            // nyToolStripMenuItem
            // 
            this.nyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deltagerToolStripMenuItem,
            this.kursusToolStripMenuItem,
            this.klasseToolStripMenuItem,
            this.medarbejderToolStripMenuItem,
            this.fakturaToolStripMenuItem});
            this.nyToolStripMenuItem.Name = "nyToolStripMenuItem";
            this.nyToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.nyToolStripMenuItem.Text = "Ny";
            // 
            // deltagerToolStripMenuItem
            // 
            this.deltagerToolStripMenuItem.Name = "deltagerToolStripMenuItem";
            this.deltagerToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.deltagerToolStripMenuItem.Text = "Deltager";
            // 
            // kursusToolStripMenuItem
            // 
            this.kursusToolStripMenuItem.Name = "kursusToolStripMenuItem";
            this.kursusToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.kursusToolStripMenuItem.Text = "Kursus";
            // 
            // klasseToolStripMenuItem
            // 
            this.klasseToolStripMenuItem.Name = "klasseToolStripMenuItem";
            this.klasseToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.klasseToolStripMenuItem.Text = "Klasse";
            // 
            // medarbejderToolStripMenuItem
            // 
            this.medarbejderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lærerToolStripMenuItem,
            this.kontorassistentToolStripMenuItem});
            this.medarbejderToolStripMenuItem.Name = "medarbejderToolStripMenuItem";
            this.medarbejderToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.medarbejderToolStripMenuItem.Text = "Medarbejder";
            // 
            // lærerToolStripMenuItem
            // 
            this.lærerToolStripMenuItem.Name = "lærerToolStripMenuItem";
            this.lærerToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.lærerToolStripMenuItem.Text = "Lærer";
            // 
            // kontorassistentToolStripMenuItem
            // 
            this.kontorassistentToolStripMenuItem.Name = "kontorassistentToolStripMenuItem";
            this.kontorassistentToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.kontorassistentToolStripMenuItem.Text = "Kontorassistent";
            // 
            // fakturaToolStripMenuItem
            // 
            this.fakturaToolStripMenuItem.Name = "fakturaToolStripMenuItem";
            this.fakturaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.fakturaToolStripMenuItem.Text = "Faktura";
            // 
            // åbnToolStripMenuItem
            // 
            this.åbnToolStripMenuItem.Name = "åbnToolStripMenuItem";
            this.åbnToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.åbnToolStripMenuItem.Text = "Afslut";
            // 
            // redigerToolStripMenuItem
            // 
            this.redigerToolStripMenuItem.Name = "redigerToolStripMenuItem";
            this.redigerToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.redigerToolStripMenuItem.Text = "Rediger";
            // 
            // hjælpToolStripMenuItem
            // 
            this.hjælpToolStripMenuItem.Name = "hjælpToolStripMenuItem";
            this.hjælpToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.hjælpToolStripMenuItem.Text = "Vis";
            // 
            // hjælpToolStripMenuItem1
            // 
            this.hjælpToolStripMenuItem1.Name = "hjælpToolStripMenuItem1";
            this.hjælpToolStripMenuItem1.Size = new System.Drawing.Size(51, 20);
            this.hjælpToolStripMenuItem1.Text = "Hjælp";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 518);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.tabControl1.ResumeLayout(false);
            this.EmployeeTab.ResumeLayout(false);
            this.PrticipantTab.ResumeLayout(false);
            this.CourseTab.ResumeLayout(false);
            this.ClassTab.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage EmployeeTab;
        private System.Windows.Forms.TabPage PrticipantTab;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deltagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kursusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medarbejderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lærerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontorassistentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fakturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem åbnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redigerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hjælpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hjælpToolStripMenuItem1;
        private BaseTabControl EmployeeControl;
        private BaseTabControl ParticipantControl;
        private System.Windows.Forms.TabPage CourseTab;
        private BaseTabControl CourseControl;
        private System.Windows.Forms.TabPage ClassTab;
        private BaseTabControl ClassControl;
    }
}

