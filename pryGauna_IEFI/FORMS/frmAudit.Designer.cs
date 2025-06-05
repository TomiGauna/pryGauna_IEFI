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
            this.dgvUserInfo = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboCriterion = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cboUsers = new System.Windows.Forms.ComboBox();
            this.lblChooseUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserInfo
            // 
            this.dgvUserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserInfo.Location = new System.Drawing.Point(12, 150);
            this.dgvUserInfo.Name = "dgvUserInfo";
            this.dgvUserInfo.Size = new System.Drawing.Size(776, 288);
            this.dgvUserInfo.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(258, 121);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "button1";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboCriterion
            // 
            this.cboCriterion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterion.FormattingEnabled = true;
            this.cboCriterion.Location = new System.Drawing.Point(12, 38);
            this.cboCriterion.Name = "cboCriterion";
            this.cboCriterion.Size = new System.Drawing.Size(321, 21);
            this.cboCriterion.TabIndex = 2;
            this.cboCriterion.SelectedIndexChanged += new System.EventHandler(this.cboCriterion_SelectedIndexChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(13, 22);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(35, 13);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "label1";
            // 
            // cboUsers
            // 
            this.cboUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsers.FormattingEnabled = true;
            this.cboUsers.Location = new System.Drawing.Point(12, 84);
            this.cboUsers.Name = "cboUsers";
            this.cboUsers.Size = new System.Drawing.Size(321, 21);
            this.cboUsers.TabIndex = 4;
            // 
            // lblChooseUser
            // 
            this.lblChooseUser.AutoSize = true;
            this.lblChooseUser.Location = new System.Drawing.Point(12, 66);
            this.lblChooseUser.Name = "lblChooseUser";
            this.lblChooseUser.Size = new System.Drawing.Size(35, 13);
            this.lblChooseUser.TabIndex = 5;
            this.lblChooseUser.Text = "label1";
            // 
            // frmAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.lblChooseUser);
            this.Controls.Add(this.cboUsers);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.cboCriterion);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvUserInfo);
            this.Name = "frmAudit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audit";
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
    }
}