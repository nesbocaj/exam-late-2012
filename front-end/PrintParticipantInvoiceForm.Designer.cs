namespace exam_late_2012
{
    partial class PrintParticipantInvoiceForm
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
            this.ParticipantNameText = new System.Windows.Forms.TextBox();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.PostalText = new System.Windows.Forms.TextBox();
            this.CityText = new System.Windows.Forms.TextBox();
            this.PhoneText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ParticipantNumberText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.CourseColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParticipantNameText
            // 
            this.ParticipantNameText.Location = new System.Drawing.Point(82, 45);
            this.ParticipantNameText.Name = "ParticipantNameText";
            this.ParticipantNameText.ReadOnly = true;
            this.ParticipantNameText.Size = new System.Drawing.Size(100, 20);
            this.ParticipantNameText.TabIndex = 3;
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(82, 71);
            this.AddressText.Name = "AddressText";
            this.AddressText.ReadOnly = true;
            this.AddressText.Size = new System.Drawing.Size(100, 20);
            this.AddressText.TabIndex = 4;
            // 
            // PostalText
            // 
            this.PostalText.Location = new System.Drawing.Point(82, 97);
            this.PostalText.Name = "PostalText";
            this.PostalText.ReadOnly = true;
            this.PostalText.Size = new System.Drawing.Size(100, 20);
            this.PostalText.TabIndex = 5;
            // 
            // CityText
            // 
            this.CityText.Location = new System.Drawing.Point(82, 123);
            this.CityText.Name = "CityText";
            this.CityText.ReadOnly = true;
            this.CityText.Size = new System.Drawing.Size(100, 20);
            this.CityText.TabIndex = 6;
            // 
            // PhoneText
            // 
            this.PhoneText.Location = new System.Drawing.Point(82, 149);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.ReadOnly = true;
            this.PhoneText.Size = new System.Drawing.Size(100, 20);
            this.PhoneText.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Navn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Adresse:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Postnummber:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "By:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Telefon:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ParticipantNumberText);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ParticipantNameText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AddressText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PostalText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CityText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PhoneText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 179);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personlige Detaljer";
            // 
            // ParticipantNumberText
            // 
            this.ParticipantNumberText.Location = new System.Drawing.Point(82, 19);
            this.ParticipantNumberText.Name = "ParticipantNumberText";
            this.ParticipantNumberText.ReadOnly = true;
            this.ParticipantNumberText.Size = new System.Drawing.Size(100, 20);
            this.ParticipantNumberText.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Kursistnr:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(215, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 240);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kursusliste";
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
            this.CourseColumn.Text = "Kursus";
            this.CourseColumn.Width = 84;
            // 
            // PriceColumn
            // 
            this.PriceColumn.Text = "Pris";
            // 
            // TotalText
            // 
            this.TotalText.Location = new System.Drawing.Point(286, 258);
            this.TotalText.Name = "TotalText";
            this.TotalText.ReadOnly = true;
            this.TotalText.Size = new System.Drawing.Size(57, 20);
            this.TotalText.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total:";
            // 
            // PrintParticipantInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 323);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalText);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PrintParticipantInvoiceForm";
            this.Text = "Faktura";
            this.Load += new System.EventHandler(this.PrintParticipantInvoiceForm_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.TotalText, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ParticipantNameText;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.TextBox PostalText;
        private System.Windows.Forms.TextBox CityText;
        private System.Windows.Forms.TextBox PhoneText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TotalText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader CourseColumn;
        private System.Windows.Forms.ColumnHeader PriceColumn;
        private System.Windows.Forms.TextBox ParticipantNumberText;
        private System.Windows.Forms.Label label7;
    }
}