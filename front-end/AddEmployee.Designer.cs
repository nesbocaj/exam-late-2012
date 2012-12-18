namespace exam_late_2012
{
    partial class AddEmployee
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
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.baseAdressControl1 = new exam_late_2012.BaseAdressControl();
            this.basePersonControl1 = new exam_late_2012.BasePersonControl();
            this.baseConstactControl1 = new exam_late_2012.BaseConstactControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.OKButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 30);
            this.panel1.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(358, 3);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(277, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Annullér";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // baseAdressControl1
            // 
            this.baseAdressControl1.Location = new System.Drawing.Point(12, 124);
            this.baseAdressControl1.Name = "baseAdressControl1";
            this.baseAdressControl1.Size = new System.Drawing.Size(212, 155);
            this.baseAdressControl1.TabIndex = 2;
            // 
            // basePersonControl1
            // 
            this.basePersonControl1.Location = new System.Drawing.Point(12, 8);
            this.basePersonControl1.Name = "basePersonControl1";
            this.basePersonControl1.Size = new System.Drawing.Size(212, 110);
            this.basePersonControl1.TabIndex = 1;
            // 
            // baseConstactControl1
            // 
            this.baseConstactControl1.Location = new System.Drawing.Point(230, 8);
            this.baseConstactControl1.Name = "baseConstactControl1";
            this.baseConstactControl1.Size = new System.Drawing.Size(203, 108);
            this.baseConstactControl1.TabIndex = 3;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 320);
            this.Controls.Add(this.baseConstactControl1);
            this.Controls.Add(this.baseAdressControl1);
            this.Controls.Add(this.basePersonControl1);
            this.Controls.Add(this.panel1);
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private BasePersonControl basePersonControl1;
        private BaseAdressControl baseAdressControl1;
        private BaseConstactControl baseConstactControl1;
    }
}