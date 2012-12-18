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
            this.label1 = new System.Windows.Forms.Label();
            this.WorkConditionText = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.baseAdressControl1 = new exam_late_2012.BaseAdressControl();
            this.baseConstactControl1 = new exam_late_2012.BaseConstactControl();
            this.basePersonControl1 = new exam_late_2012.BasePersonControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.OKButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 405);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 30);
            this.panel1.TabIndex = 1;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(402, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Annullér";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(483, 3);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arbejdstilstand";
            // 
            // WorkConditionText
            // 
            this.WorkConditionText.Location = new System.Drawing.Point(373, 142);
            this.WorkConditionText.Name = "WorkConditionText";
            this.WorkConditionText.Size = new System.Drawing.Size(121, 20);
            this.WorkConditionText.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(341, 263);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(111, 160);
            this.listBox1.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(373, 168);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kursus";
            // 
            // baseAdressControl1
            // 
            this.baseAdressControl1.Location = new System.Drawing.Point(12, 119);
            this.baseAdressControl1.Name = "baseAdressControl1";
            this.baseAdressControl1.Size = new System.Drawing.Size(212, 154);
            this.baseAdressControl1.TabIndex = 14;
            // 
            // baseConstactControl1
            // 
            this.baseConstactControl1.Location = new System.Drawing.Point(230, 12);
            this.baseConstactControl1.Name = "baseConstactControl1";
            this.baseConstactControl1.Size = new System.Drawing.Size(264, 101);
            this.baseConstactControl1.TabIndex = 15;
            // 
            // basePersonControl1
            // 
            this.basePersonControl1.Location = new System.Drawing.Point(12, 12);
            this.basePersonControl1.Name = "basePersonControl1";
            this.basePersonControl1.Size = new System.Drawing.Size(212, 101);
            this.basePersonControl1.TabIndex = 16;
            // 
            // AddParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 435);
            this.Controls.Add(this.basePersonControl1);
            this.Controls.Add(this.baseConstactControl1);
            this.Controls.Add(this.baseAdressControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.WorkConditionText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "AddParticipant";
            this.Text = "Deltager";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WorkConditionText;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private BaseAdressControl baseAdressControl1;
        private BaseConstactControl baseConstactControl1;
        private BasePersonControl basePersonControl1;
    }
}