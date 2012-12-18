namespace exam_late_2012
{
    partial class AddParticipant
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.WorkConditionBox = new System.Windows.Forms.GroupBox();
            this.WorkConditionText = new System.Windows.Forms.TextBox();
            this.baseConstactControl1 = new exam_late_2012.BaseConstactControl();
            this.basePersonControl1 = new exam_late_2012.BasePersonControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ChosenList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AvailableList = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.baseAdressControl1 = new exam_late_2012.BaseAdressControl();
            this.panel1.SuspendLayout();
            this.WorkConditionBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.OKButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 30);
            this.panel1.TabIndex = 1;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(386, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Annullér";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(467, 3);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // WorkConditionBox
            // 
            this.WorkConditionBox.Controls.Add(this.WorkConditionText);
            this.WorkConditionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkConditionBox.Location = new System.Drawing.Point(3, 109);
            this.WorkConditionBox.Name = "WorkConditionBox";
            this.WorkConditionBox.Size = new System.Drawing.Size(271, 49);
            this.WorkConditionBox.TabIndex = 18;
            this.WorkConditionBox.TabStop = false;
            this.WorkConditionBox.Text = "Arbejdstilstand";
            // 
            // WorkConditionText
            // 
            this.WorkConditionText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkConditionText.Location = new System.Drawing.Point(165, 19);
            this.WorkConditionText.Name = "WorkConditionText";
            this.WorkConditionText.Size = new System.Drawing.Size(100, 20);
            this.WorkConditionText.TabIndex = 3;
            // 
            // baseConstactControl1
            // 
            this.baseConstactControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseConstactControl1.Location = new System.Drawing.Point(280, 3);
            this.baseConstactControl1.Name = "baseConstactControl1";
            this.baseConstactControl1.Size = new System.Drawing.Size(271, 100);
            this.baseConstactControl1.TabIndex = 15;
            // 
            // basePersonControl1
            // 
            this.basePersonControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basePersonControl1.Location = new System.Drawing.Point(3, 3);
            this.basePersonControl1.Name = "basePersonControl1";
            this.basePersonControl1.Size = new System.Drawing.Size(271, 100);
            this.basePersonControl1.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.basePersonControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.WorkConditionBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.baseAdressControl1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.baseConstactControl1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.74586F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.25414F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(554, 326);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // ChosenList
            // 
            this.ChosenList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChosenList.FormattingEnabled = true;
            this.ChosenList.Location = new System.Drawing.Point(162, 32);
            this.ChosenList.Name = "ChosenList";
            this.ChosenList.Size = new System.Drawing.Size(100, 160);
            this.ChosenList.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mulige Kurser";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Valgte Kurser";
            // 
            // AvailableList
            // 
            this.AvailableList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AvailableList.FormattingEnabled = true;
            this.AvailableList.Location = new System.Drawing.Point(10, 32);
            this.AvailableList.Name = "AvailableList";
            this.AvailableList.Size = new System.Drawing.Size(100, 160);
            this.AvailableList.TabIndex = 15;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.AddButton.Location = new System.Drawing.Point(122, 59);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(27, 27);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "g";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.RemoveButton.Location = new System.Drawing.Point(122, 92);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(27, 27);
            this.RemoveButton.TabIndex = 17;
            this.RemoveButton.Text = "f";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RemoveButton);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.AvailableList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ChosenList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(280, 109);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(271, 214);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kursus Valg";
            // 
            // baseAdressControl1
            // 
            this.baseAdressControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseAdressControl1.Location = new System.Drawing.Point(3, 164);
            this.baseAdressControl1.Name = "baseAdressControl1";
            this.baseAdressControl1.Size = new System.Drawing.Size(271, 159);
            this.baseAdressControl1.TabIndex = 14;
            // 
            // AddParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 356);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "AddParticipant";
            this.Text = "Deltager";
            this.panel1.ResumeLayout(false);
            this.WorkConditionBox.ResumeLayout(false);
            this.WorkConditionBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.GroupBox WorkConditionBox;
        private System.Windows.Forms.TextBox WorkConditionText;
        private BaseConstactControl baseConstactControl1;
        private BasePersonControl basePersonControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox AvailableList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ChosenList;
        private BaseAdressControl baseAdressControl1;
    }
}