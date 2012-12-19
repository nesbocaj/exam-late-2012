namespace exam_late_2012
{
    partial class AddEmployeeForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.basePersonControl1 = new exam_late_2012.BasePersonControl();
            this.baseAdressControl1 = new exam_late_2012.BaseAdressControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RankCBox = new System.Windows.Forms.ComboBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.InitialsBox = new System.Windows.Forms.TextBox();
            this.baseConstactControl1 = new exam_late_2012.BaseConstactControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.QualificationText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.QualificationCheck = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.basePersonControl1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.baseAdressControl1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.baseConstactControl1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.62264F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.37736F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(445, 368);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // basePersonControl1
            // 
            this.basePersonControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basePersonControl1.Location = new System.Drawing.Point(3, 3);
            this.basePersonControl1.Name = "basePersonControl1";
            this.basePersonControl1.Size = new System.Drawing.Size(216, 96);
            this.basePersonControl1.TabIndex = 0;
            // 
            // baseAdressControl1
            // 
            this.baseAdressControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseAdressControl1.Location = new System.Drawing.Point(3, 105);
            this.baseAdressControl1.Name = "baseAdressControl1";
            this.baseAdressControl1.Size = new System.Drawing.Size(216, 149);
            this.baseAdressControl1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RankCBox);
            this.groupBox1.Controls.Add(this.PasswordBox);
            this.groupBox1.Controls.Add(this.InitialsBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(225, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 96);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medarbejder Information:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adgangskode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Initialer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rang:";
            // 
            // RankCBox
            // 
            this.RankCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RankCBox.FormattingEnabled = true;
            this.RankCBox.Location = new System.Drawing.Point(111, 19);
            this.RankCBox.Name = "RankCBox";
            this.RankCBox.Size = new System.Drawing.Size(100, 21);
            this.RankCBox.TabIndex = 3;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordBox.Location = new System.Drawing.Point(111, 72);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordBox.TabIndex = 2;
            // 
            // InitialsBox
            // 
            this.InitialsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InitialsBox.Location = new System.Drawing.Point(111, 46);
            this.InitialsBox.Name = "InitialsBox";
            this.InitialsBox.Size = new System.Drawing.Size(100, 20);
            this.InitialsBox.TabIndex = 0;
            // 
            // baseConstactControl1
            // 
            this.baseConstactControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseConstactControl1.Location = new System.Drawing.Point(3, 260);
            this.baseConstactControl1.Name = "baseConstactControl1";
            this.baseConstactControl1.Size = new System.Drawing.Size(216, 105);
            this.baseConstactControl1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.QualificationText);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.QualificationCheck);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(225, 105);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel2.SetRowSpan(this.groupBox2, 2);
            this.groupBox2.Size = new System.Drawing.Size(217, 260);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Underviser Kvalifikationer:";
            // 
            // QualificationText
            // 
            this.QualificationText.Location = new System.Drawing.Point(10, 22);
            this.QualificationText.Name = "QualificationText";
            this.QualificationText.Size = new System.Drawing.Size(171, 20);
            this.QualificationText.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button1.Location = new System.Drawing.Point(187, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 14;
            this.button1.Text = "i";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // QualificationCheck
            // 
            this.QualificationCheck.FormattingEnabled = true;
            this.QualificationCheck.Location = new System.Drawing.Point(10, 48);
            this.QualificationCheck.Name = "QualificationCheck";
            this.QualificationCheck.ScrollAlwaysVisible = true;
            this.QualificationCheck.Size = new System.Drawing.Size(201, 199);
            this.QualificationCheck.TabIndex = 13;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 397);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "AddEmployee";
            this.Text = "Opret Medarbejder";
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private BasePersonControl basePersonControl1;
        private BaseAdressControl baseAdressControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RankCBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox InitialsBox;
        private BaseConstactControl baseConstactControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox QualificationText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox QualificationCheck;

    }
}