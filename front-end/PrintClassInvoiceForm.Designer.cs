namespace exam_late_2012
{
    partial class PrintClassInvoiceForm
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
            this.TotalText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.CourseColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClassNumberText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ClassNameText = new System.Windows.Forms.TextBox();
            this.CourseText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TotalText
            // 
            this.TotalText.Location = new System.Drawing.Point(286, 258);
            this.TotalText.Name = "TotalText";
            this.TotalText.ReadOnly = true;
            this.TotalText.Size = new System.Drawing.Size(57, 20);
            this.TotalText.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(215, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 240);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Holdliste";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CourseColumn,
            this.PriceColumn});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 215);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // CourseColumn
            // 
            this.CourseColumn.Text = "Kursist";
            this.CourseColumn.Width = 84;
            // 
            // PriceColumn
            // 
            this.PriceColumn.Text = "Pris";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClassNumberText);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ClassNameText);
            this.groupBox1.Controls.Add(this.CourseText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 104);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hold Oplysninger";
            // 
            // ClassNumberText
            // 
            this.ClassNumberText.Location = new System.Drawing.Point(82, 19);
            this.ClassNumberText.Name = "ClassNumberText";
            this.ClassNumberText.ReadOnly = true;
            this.ClassNumberText.Size = new System.Drawing.Size(100, 20);
            this.ClassNumberText.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Holdnr:";
            // 
            // ClassNameText
            // 
            this.ClassNameText.Location = new System.Drawing.Point(82, 45);
            this.ClassNameText.Name = "ClassNameText";
            this.ClassNameText.ReadOnly = true;
            this.ClassNameText.Size = new System.Drawing.Size(100, 20);
            this.ClassNameText.TabIndex = 3;
            // 
            // CourseText
            // 
            this.CourseText.Location = new System.Drawing.Point(82, 71);
            this.CourseText.Name = "CourseText";
            this.CourseText.ReadOnly = true;
            this.CourseText.Size = new System.Drawing.Size(100, 20);
            this.CourseText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kursus:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Holdnavn:";
            // 
            // PrintClassInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 323);
            this.Controls.Add(this.TotalText);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PrintClassInvoiceForm";
            this.Text = "PrintClassInvoiceForm";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.TotalText, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TotalText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader CourseColumn;
        private System.Windows.Forms.ColumnHeader PriceColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ClassNumberText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ClassNameText;
        private System.Windows.Forms.TextBox CourseText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}