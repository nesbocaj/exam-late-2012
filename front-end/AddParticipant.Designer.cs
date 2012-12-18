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
            this.WorkConditionText = new System.Windows.Forms.TextBox();
            this.ChosenList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.basePersonControl1 = new exam_late_2012.BasePersonControl();
            this.baseConstactControl1 = new exam_late_2012.BaseConstactControl();
            this.baseAdressControl1 = new exam_late_2012.BaseAdressControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WorkConditionBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AvailableList = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.WorkConditionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.OKButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 30);
            this.panel1.TabIndex = 1;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(338, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Annullér";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(419, 3);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // WorkConditionText
            // 
            this.WorkConditionText.Location = new System.Drawing.Point(106, 19);
            this.WorkConditionText.Name = "WorkConditionText";
            this.WorkConditionText.Size = new System.Drawing.Size(100, 20);
            this.WorkConditionText.TabIndex = 3;
            // 
            // ChosenList
            // 
            this.ChosenList.FormattingEnabled = true;
            this.ChosenList.Location = new System.Drawing.Point(158, 43);
            this.ChosenList.Name = "ChosenList";
            this.ChosenList.Size = new System.Drawing.Size(100, 160);
            this.ChosenList.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mulige Kurser";
            // 
            // basePersonControl1
            // 
            this.basePersonControl1.Location = new System.Drawing.Point(12, 12);
            this.basePersonControl1.Name = "basePersonControl1";
            this.basePersonControl1.Size = new System.Drawing.Size(212, 101);
            this.basePersonControl1.TabIndex = 16;
            // 
            // baseConstactControl1
            // 
            this.baseConstactControl1.Location = new System.Drawing.Point(230, 12);
            this.baseConstactControl1.Name = "baseConstactControl1";
            this.baseConstactControl1.Size = new System.Drawing.Size(264, 101);
            this.baseConstactControl1.TabIndex = 15;
            // 
            // baseAdressControl1
            // 
            this.baseAdressControl1.Location = new System.Drawing.Point(12, 174);
            this.baseAdressControl1.Name = "baseAdressControl1";
            this.baseAdressControl1.Size = new System.Drawing.Size(212, 154);
            this.baseAdressControl1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RemoveButton);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.AvailableList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ChosenList);
            this.groupBox1.Location = new System.Drawing.Point(230, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 209);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kursus Valg";
            // 
            // WorkConditionBox
            // 
            this.WorkConditionBox.Controls.Add(this.WorkConditionText);
            this.WorkConditionBox.Location = new System.Drawing.Point(12, 119);
            this.WorkConditionBox.Name = "WorkConditionBox";
            this.WorkConditionBox.Size = new System.Drawing.Size(212, 49);
            this.WorkConditionBox.TabIndex = 18;
            this.WorkConditionBox.TabStop = false;
            this.WorkConditionBox.Text = "Arbejdstilstand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Valgte Kurser";
            // 
            // AvailableList
            // 
            this.AvailableList.FormattingEnabled = true;
            this.AvailableList.Location = new System.Drawing.Point(6, 43);
            this.AvailableList.Name = "AvailableList";
            this.AvailableList.Size = new System.Drawing.Size(100, 160);
            this.AvailableList.TabIndex = 15;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(118, 70);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(27, 27);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "=>";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(118, 103);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(27, 27);
            this.RemoveButton.TabIndex = 17;
            this.RemoveButton.Text = "<=";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // AddParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 371);
            this.Controls.Add(this.WorkConditionBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.basePersonControl1);
            this.Controls.Add(this.baseConstactControl1);
            this.Controls.Add(this.baseAdressControl1);
            this.Controls.Add(this.panel1);
            this.Name = "AddParticipant";
            this.Text = "Deltager";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.WorkConditionBox.ResumeLayout(false);
            this.WorkConditionBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox WorkConditionText;
        private System.Windows.Forms.ListBox ChosenList;
        private System.Windows.Forms.Label label2;
        private BaseAdressControl baseAdressControl1;
        private BaseConstactControl baseConstactControl1;
        private BasePersonControl basePersonControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox AvailableList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox WorkConditionBox;
        private System.Windows.Forms.Button RemoveButton;
    }
}