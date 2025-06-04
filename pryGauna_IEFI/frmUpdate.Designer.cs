namespace pryGauna_IEFI
{
    partial class frmUpdate
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.cboUsername = new System.Windows.Forms.ComboBox();
            this.lblNewData = new System.Windows.Forms.Label();
            this.txtNewData = new System.Windows.Forms.TextBox();
            this.lblNewCountry = new System.Windows.Forms.Label();
            this.cboNewCountry = new System.Windows.Forms.ComboBox();
            this.lblField = new System.Windows.Forms.Label();
            this.cboField = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(180, 285);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "button1";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(73, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "label1";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(30, 61);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(35, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "label2";
            // 
            // cboUsername
            // 
            this.cboUsername.FormattingEnabled = true;
            this.cboUsername.Location = new System.Drawing.Point(30, 77);
            this.cboUsername.Name = "cboUsername";
            this.cboUsername.Size = new System.Drawing.Size(225, 21);
            this.cboUsername.TabIndex = 3;
            // 
            // lblNewData
            // 
            this.lblNewData.AutoSize = true;
            this.lblNewData.Location = new System.Drawing.Point(30, 175);
            this.lblNewData.Name = "lblNewData";
            this.lblNewData.Size = new System.Drawing.Size(35, 13);
            this.lblNewData.TabIndex = 4;
            this.lblNewData.Text = "label3";
            // 
            // txtNewData
            // 
            this.txtNewData.Location = new System.Drawing.Point(30, 191);
            this.txtNewData.Name = "txtNewData";
            this.txtNewData.Size = new System.Drawing.Size(225, 20);
            this.txtNewData.TabIndex = 5;
            // 
            // lblNewCountry
            // 
            this.lblNewCountry.AutoSize = true;
            this.lblNewCountry.Location = new System.Drawing.Point(30, 223);
            this.lblNewCountry.Name = "lblNewCountry";
            this.lblNewCountry.Size = new System.Drawing.Size(35, 13);
            this.lblNewCountry.TabIndex = 6;
            this.lblNewCountry.Text = "label4";
            // 
            // cboNewCountry
            // 
            this.cboNewCountry.FormattingEnabled = true;
            this.cboNewCountry.Location = new System.Drawing.Point(30, 240);
            this.cboNewCountry.Name = "cboNewCountry";
            this.cboNewCountry.Size = new System.Drawing.Size(225, 21);
            this.cboNewCountry.TabIndex = 7;
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Location = new System.Drawing.Point(30, 116);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(35, 13);
            this.lblField.TabIndex = 8;
            this.lblField.Text = "label5";
            // 
            // cboField
            // 
            this.cboField.FormattingEnabled = true;
            this.cboField.Location = new System.Drawing.Point(30, 133);
            this.cboField.Name = "cboField";
            this.cboField.Size = new System.Drawing.Size(225, 21);
            this.cboField.TabIndex = 9;
            this.cboField.SelectedIndexChanged += new System.EventHandler(this.cboField_SelectedIndexChanged);
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 334);
            this.Controls.Add(this.cboField);
            this.Controls.Add(this.lblField);
            this.Controls.Add(this.cboNewCountry);
            this.Controls.Add(this.lblNewCountry);
            this.Controls.Add(this.txtNewData);
            this.Controls.Add(this.lblNewData);
            this.Controls.Add(this.cboUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnUpdate);
            this.Name = "frmUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update User";
            this.Load += new System.EventHandler(this.frmUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ComboBox cboUsername;
        private System.Windows.Forms.Label lblNewData;
        private System.Windows.Forms.TextBox txtNewData;
        private System.Windows.Forms.Label lblNewCountry;
        private System.Windows.Forms.ComboBox cboNewCountry;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.ComboBox cboField;
    }
}