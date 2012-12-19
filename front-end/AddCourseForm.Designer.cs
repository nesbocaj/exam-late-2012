namespace exam_late_2012
{
    partial class AddCourseForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CourseList = new System.Windows.Forms.ListBox();
            this.CourseBox = new System.Windows.Forms.GroupBox();
            this.CourseNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoryText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DifficultyCombo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UnmarkAllButton = new System.Windows.Forms.Button();
            this.MarkAllButton = new System.Windows.Forms.Button();
            this.CourseReqCheck = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.CourseBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.12329F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.87671F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.CourseBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.72446F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.27554F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(384, 324);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CourseList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(260, 3);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel2.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(121, 318);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eksisterende Kurser";
            // 
            // CourseList
            // 
            this.CourseList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CourseList.FormattingEnabled = true;
            this.CourseList.HorizontalScrollbar = true;
            this.CourseList.Location = new System.Drawing.Point(3, 16);
            this.CourseList.Name = "CourseList";
            this.CourseList.Size = new System.Drawing.Size(115, 299);
            this.CourseList.TabIndex = 9;
            // 
            // CourseBox
            // 
            this.CourseBox.Controls.Add(this.CourseNameText);
            this.CourseBox.Controls.Add(this.label1);
            this.CourseBox.Controls.Add(this.label2);
            this.CourseBox.Controls.Add(this.CategoryText);
            this.CourseBox.Controls.Add(this.label3);
            this.CourseBox.Controls.Add(this.PriceText);
            this.CourseBox.Controls.Add(this.label4);
            this.CourseBox.Controls.Add(this.DifficultyCombo);
            this.CourseBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CourseBox.Location = new System.Drawing.Point(3, 3);
            this.CourseBox.Name = "CourseBox";
            this.CourseBox.Size = new System.Drawing.Size(251, 132);
            this.CourseBox.TabIndex = 13;
            this.CourseBox.TabStop = false;
            this.CourseBox.Text = "Kursus Detaljer";
            // 
            // CourseNameText
            // 
            this.CourseNameText.Location = new System.Drawing.Point(122, 19);
            this.CourseNameText.Name = "CourseNameText";
            this.CourseNameText.Size = new System.Drawing.Size(100, 20);
            this.CourseNameText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kursusnavn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori:";
            // 
            // CategoryText
            // 
            this.CategoryText.Location = new System.Drawing.Point(122, 45);
            this.CategoryText.Name = "CategoryText";
            this.CategoryText.Size = new System.Drawing.Size(100, 20);
            this.CategoryText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pris:";
            // 
            // PriceText
            // 
            this.PriceText.Location = new System.Drawing.Point(122, 71);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(100, 20);
            this.PriceText.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sværhedsgrad:";
            // 
            // DifficultyCombo
            // 
            this.DifficultyCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DifficultyCombo.FormattingEnabled = true;
            this.DifficultyCombo.Location = new System.Drawing.Point(122, 97);
            this.DifficultyCombo.Name = "DifficultyCombo";
            this.DifficultyCombo.Size = new System.Drawing.Size(100, 21);
            this.DifficultyCombo.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UnmarkAllButton);
            this.groupBox2.Controls.Add(this.MarkAllButton);
            this.groupBox2.Controls.Add(this.CourseReqCheck);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 180);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kravspecification";
            // 
            // UnmarkAllButton
            // 
            this.UnmarkAllButton.Location = new System.Drawing.Point(22, 71);
            this.UnmarkAllButton.Name = "UnmarkAllButton";
            this.UnmarkAllButton.Size = new System.Drawing.Size(75, 23);
            this.UnmarkAllButton.TabIndex = 2;
            this.UnmarkAllButton.Text = "Afmarkér";
            this.UnmarkAllButton.UseVisualStyleBackColor = true;
            // 
            // MarkAllButton
            // 
            this.MarkAllButton.Location = new System.Drawing.Point(22, 42);
            this.MarkAllButton.Name = "MarkAllButton";
            this.MarkAllButton.Size = new System.Drawing.Size(75, 23);
            this.MarkAllButton.TabIndex = 1;
            this.MarkAllButton.Text = "Markér Alle";
            this.MarkAllButton.UseVisualStyleBackColor = true;
            // 
            // CourseReqCheck
            // 
            this.CourseReqCheck.FormattingEnabled = true;
            this.CourseReqCheck.Location = new System.Drawing.Point(122, 19);
            this.CourseReqCheck.Name = "CourseReqCheck";
            this.CourseReqCheck.Size = new System.Drawing.Size(123, 154);
            this.CourseReqCheck.TabIndex = 0;
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 353);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "AddCourse";
            this.Text = "Opret Kursus";
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.CourseBox.ResumeLayout(false);
            this.CourseBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox CourseList;
        private System.Windows.Forms.GroupBox CourseBox;
        private System.Windows.Forms.TextBox CourseNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CategoryText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DifficultyCombo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button UnmarkAllButton;
        private System.Windows.Forms.Button MarkAllButton;
        private System.Windows.Forms.CheckedListBox CourseReqCheck;

    }
}