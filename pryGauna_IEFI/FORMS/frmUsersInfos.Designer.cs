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
            this.dgvSystemInfo = new System.Windows.Forms.DataGridView();
            this.tpaPersonalInfo = new System.Windows.Forms.TabPage();
            this.dgvPersonalInfo = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tpaSystemInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemInfo)).BeginInit();
            this.tpaPersonalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonalInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpaSystemInfo);
            this.tabControl1.Controls.Add(this.tpaPersonalInfo);
            this.tabControl1.Location = new System.Drawing.Point(14, 19);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(728, 688);
            this.tabControl1.TabIndex = 0;
            // 
            // tpaSystemInfo
            // 
            this.tpaSystemInfo.Controls.Add(this.dgvSystemInfo);
            this.tpaSystemInfo.Location = new System.Drawing.Point(4, 30);
            this.tpaSystemInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpaSystemInfo.Name = "tpaSystemInfo";
            this.tpaSystemInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpaSystemInfo.Size = new System.Drawing.Size(720, 654);
            this.tpaSystemInfo.TabIndex = 0;
            this.tpaSystemInfo.Text = "tabPage1";
            this.tpaSystemInfo.UseVisualStyleBackColor = true;
            // 
            // dgvSystemInfo
            // 
            this.dgvSystemInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSystemInfo.Location = new System.Drawing.Point(8, 11);
            this.dgvSystemInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSystemInfo.Name = "dgvSystemInfo";
            this.dgvSystemInfo.Size = new System.Drawing.Size(704, 625);
            this.dgvSystemInfo.TabIndex = 0;
            // 
            // tpaPersonalInfo
            // 
            this.tpaPersonalInfo.Controls.Add(this.dgvPersonalInfo);
            this.tpaPersonalInfo.Location = new System.Drawing.Point(4, 22);
            this.tpaPersonalInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpaPersonalInfo.Name = "tpaPersonalInfo";
            this.tpaPersonalInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpaPersonalInfo.Size = new System.Drawing.Size(720, 662);
            this.tpaPersonalInfo.TabIndex = 1;
            this.tpaPersonalInfo.Text = "tabPage2";
            this.tpaPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // dgvPersonalInfo
            // 
            this.dgvPersonalInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonalInfo.Location = new System.Drawing.Point(8, 11);
            this.dgvPersonalInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPersonalInfo.Name = "dgvPersonalInfo";
            this.dgvPersonalInfo.Size = new System.Drawing.Size(704, 625);
            this.dgvPersonalInfo.TabIndex = 0;
            // 
            // frmUsersInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::pryGauna_IEFI.Properties.Resources.patrick_tomasso_gMes5dNykus_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 727);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUsersInfos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deskly: Users Information";
            this.Load += new System.EventHandler(this.frmUsersInfos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpaSystemInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemInfo)).EndInit();
            this.tpaPersonalInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonalInfo)).EndInit();
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