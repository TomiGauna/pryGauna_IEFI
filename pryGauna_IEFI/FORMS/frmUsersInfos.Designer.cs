namespace pryGauna_IEFI
{
    partial class frmUsersInfos
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
            this.tpaSystemInfo = new System.Windows.Forms.TabPage();
            this.tpaPersonalInfo = new System.Windows.Forms.TabPage();
            this.dgvPersonalInfo = new System.Windows.Forms.DataGridView();
            this.dgvSystemInfo = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tpaSystemInfo.SuspendLayout();
            this.tpaPersonalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonalInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpaSystemInfo);
            this.tabControl1.Controls.Add(this.tpaPersonalInfo);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(624, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tpaSystemInfo
            // 
            this.tpaSystemInfo.Controls.Add(this.dgvSystemInfo);
            this.tpaSystemInfo.Location = new System.Drawing.Point(4, 22);
            this.tpaSystemInfo.Name = "tpaSystemInfo";
            this.tpaSystemInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpaSystemInfo.Size = new System.Drawing.Size(616, 400);
            this.tpaSystemInfo.TabIndex = 0;
            this.tpaSystemInfo.Text = "tabPage1";
            this.tpaSystemInfo.UseVisualStyleBackColor = true;
            // 
            // tpaPersonalInfo
            // 
            this.tpaPersonalInfo.Controls.Add(this.dgvPersonalInfo);
            this.tpaPersonalInfo.Location = new System.Drawing.Point(4, 22);
            this.tpaPersonalInfo.Name = "tpaPersonalInfo";
            this.tpaPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpaPersonalInfo.Size = new System.Drawing.Size(616, 400);
            this.tpaPersonalInfo.TabIndex = 1;
            this.tpaPersonalInfo.Text = "tabPage2";
            this.tpaPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // dgvPersonalInfo
            // 
            this.dgvPersonalInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonalInfo.Location = new System.Drawing.Point(7, 7);
            this.dgvPersonalInfo.Name = "dgvPersonalInfo";
            this.dgvPersonalInfo.Size = new System.Drawing.Size(603, 387);
            this.dgvPersonalInfo.TabIndex = 0;
            // 
            // dgvSystemInfo
            // 
            this.dgvSystemInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSystemInfo.Location = new System.Drawing.Point(7, 7);
            this.dgvSystemInfo.Name = "dgvSystemInfo";
            this.dgvSystemInfo.Size = new System.Drawing.Size(603, 387);
            this.dgvSystemInfo.TabIndex = 0;
            // 
            // frmUsersInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmUsersInfos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USERS INFORMATION";
            this.Load += new System.EventHandler(this.frmUsersInfos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpaSystemInfo.ResumeLayout(false);
            this.tpaPersonalInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonalInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpaSystemInfo;
        private System.Windows.Forms.TabPage tpaPersonalInfo;
        private System.Windows.Forms.DataGridView dgvPersonalInfo;
        private System.Windows.Forms.DataGridView dgvSystemInfo;
    }
}