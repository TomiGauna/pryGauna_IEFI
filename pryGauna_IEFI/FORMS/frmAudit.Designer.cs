namespace pryGauna_IEFI
{
    partial class frmAudit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAudit));
            this.dgvUserInfo = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboCriterion = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cboUsers = new System.Windows.Forms.ComboBox();
            this.lblChooseUser = new System.Windows.Forms.Label();
            this.lblTotalTimeTitle = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserInfo
            // 
            this.dgvUserInfo.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvUserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserInfo.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvUserInfo.Location = new System.Drawing.Point(12, 180);
            this.dgvUserInfo.Name = "dgvUserInfo";
            this.dgvUserInfo.Size = new System.Drawing.Size(444, 288);
            this.dgvUserInfo.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearch.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSearch.Location = new System.Drawing.Point(381, 141);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 33);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "button1";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboCriterion
            // 
            this.cboCriterion.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cboCriterion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterion.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCriterion.FormattingEnabled = true;
            this.cboCriterion.Location = new System.Drawing.Point(12, 39);
            this.cboCriterion.Name = "cboCriterion";
            this.cboCriterion.Size = new System.Drawing.Size(444, 31);
            this.cboCriterion.TabIndex = 2;
            this.cboCriterion.SelectedIndexChanged += new System.EventHandler(this.cboCriterion_SelectedIndexChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSearch.Location = new System.Drawing.Point(12, 8);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(52, 28);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "label1";
            // 
            // cboUsers
            // 
            this.cboUsers.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cboUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsers.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUsers.FormattingEnabled = true;
            this.cboUsers.Location = new System.Drawing.Point(12, 104);
            this.cboUsers.Name = "cboUsers";
            this.cboUsers.Size = new System.Drawing.Size(444, 31);
            this.cboUsers.TabIndex = 4;
            // 
            // lblChooseUser
            // 
            this.lblChooseUser.AutoSize = true;
            this.lblChooseUser.BackColor = System.Drawing.Color.Transparent;
            this.lblChooseUser.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseUser.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblChooseUser.Location = new System.Drawing.Point(12, 73);
            this.lblChooseUser.Name = "lblChooseUser";
            this.lblChooseUser.Size = new System.Drawing.Size(52, 28);
            this.lblChooseUser.TabIndex = 5;
            this.lblChooseUser.Text = "label1";
            // 
            // lblTotalTimeTitle
            // 
            this.lblTotalTimeTitle.AutoSize = true;
            this.lblTotalTimeTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalTimeTitle.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTimeTitle.ForeColor = System.Drawing.SystemColors.Info;
            this.lblTotalTimeTitle.Location = new System.Drawing.Point(12, 471);
            this.lblTotalTimeTitle.Name = "lblTotalTimeTitle";
            this.lblTotalTimeTitle.Size = new System.Drawing.Size(52, 28);
            this.lblTotalTimeTitle.TabIndex = 6;
            this.lblTotalTimeTitle.Text = "label1";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalTime.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTime.ForeColor = System.Drawing.SystemColors.Info;
            this.lblTotalTime.Location = new System.Drawing.Point(112, 471);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(54, 28);
            this.lblTotalTime.TabIndex = 7;
            this.lblTotalTime.Text = "label2";
            // 
            // frmAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryGauna_IEFI.Properties.Resources.patrick_tomasso_gMes5dNykus_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(473, 508);
            this.Controls.Add(this.lblTotalTime);
            this.Controls.Add(this.lblTotalTimeTitle);
            this.Controls.Add(this.lblChooseUser);
            this.Controls.Add(this.cboUsers);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.cboCriterion);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvUserInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAudit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deskly: Audit";
            this.Load += new System.EventHandler(this.frmAudit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserInfo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboCriterion;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cboUsers;
        private System.Windows.Forms.Label lblChooseUser;
        private System.Windows.Forms.Label lblTotalTimeTitle;
        private System.Windows.Forms.Label lblTotalTime;
    }
}