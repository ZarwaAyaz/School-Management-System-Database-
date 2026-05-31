namespace SchoolManagementSystem
{
    partial class PayTeacherSalaryForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearchTeacher = new System.Windows.Forms.TextBox();
            this.lblGradeFilter = new System.Windows.Forms.Label();
            this.cmbGradeFilter = new System.Windows.Forms.ComboBox();
            this.lblStatusFilter = new System.Windows.Forms.Label();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.panelSummary = new System.Windows.Forms.Panel();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblTotalTeachers = new System.Windows.Forms.Label();
            this.lblPaidLabel = new System.Windows.Forms.Label();
            this.lblPaidCount = new System.Windows.Forms.Label();
            this.lblUnpaidLabel = new System.Windows.Forms.Label();
            this.lblUnpaidCount = new System.Windows.Forms.Label();
            this.lblTotalPaidLabel = new System.Windows.Forms.Label();
            this.lblTotalPaid = new System.Windows.Forms.Label();
            this.lblTotalPendingLabel = new System.Windows.Forms.Label();
            this.lblTotalPending = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.dgvSalary = new System.Windows.Forms.DataGridView();
            this.colEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelHeader.SuspendLayout();
            this.panelFilters.SuspendLayout();
            this.panelSummary.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.btnBack);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1100, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(380, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Pay Teacher Salary";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(20, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(140, 40);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // panelFilters
            // 
            this.panelFilters.BackColor = System.Drawing.Color.White;
            this.panelFilters.Controls.Add(this.lblSearch);
            this.panelFilters.Controls.Add(this.txtSearchTeacher);
            this.panelFilters.Controls.Add(this.lblGradeFilter);
            this.panelFilters.Controls.Add(this.cmbGradeFilter);
            this.panelFilters.Controls.Add(this.lblStatusFilter);
            this.panelFilters.Controls.Add(this.cmbStatusFilter);
            this.panelFilters.Controls.Add(this.btnClearFilters);
            this.panelFilters.Location = new System.Drawing.Point(20, 100);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(1060, 90);
            this.panelFilters.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSearch.Location = new System.Drawing.Point(20, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(109, 19);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search Teacher:";
            // 
            // txtSearchTeacher
            // 
            this.txtSearchTeacher.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearchTeacher.Location = new System.Drawing.Point(20, 40);
            this.txtSearchTeacher.Name = "txtSearchTeacher";
            this.txtSearchTeacher.Size = new System.Drawing.Size(250, 27);
            this.txtSearchTeacher.TabIndex = 1;
            this.txtSearchTeacher.TextChanged += new System.EventHandler(this.TxtSearchTeacher_TextChanged);
            // 
            // lblGradeFilter
            // 
            this.lblGradeFilter.AutoSize = true;
            this.lblGradeFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGradeFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblGradeFilter.Location = new System.Drawing.Point(300, 15);
            this.lblGradeFilter.Name = "lblGradeFilter";
            this.lblGradeFilter.Size = new System.Drawing.Size(88, 19);
            this.lblGradeFilter.TabIndex = 2;
            this.lblGradeFilter.Text = "Filter Grade:";
            // 
            // cmbGradeFilter
            // 
            this.cmbGradeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGradeFilter.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbGradeFilter.FormattingEnabled = true;
            this.cmbGradeFilter.Location = new System.Drawing.Point(300, 40);
            this.cmbGradeFilter.Name = "cmbGradeFilter";
            this.cmbGradeFilter.Size = new System.Drawing.Size(200, 28);
            this.cmbGradeFilter.TabIndex = 3;
            this.cmbGradeFilter.SelectedIndexChanged += new System.EventHandler(this.CmbGradeFilter_SelectedIndexChanged);
            // 
            // lblStatusFilter
            // 
            this.lblStatusFilter.AutoSize = true;
            this.lblStatusFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatusFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblStatusFilter.Location = new System.Drawing.Point(530, 15);
            this.lblStatusFilter.Name = "lblStatusFilter";
            this.lblStatusFilter.Size = new System.Drawing.Size(91, 19);
            this.lblStatusFilter.TabIndex = 4;
            this.lblStatusFilter.Text = "Filter Status:";
            // 
            // cmbStatusFilter
            // 
            this.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusFilter.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbStatusFilter.FormattingEnabled = true;
            this.cmbStatusFilter.Location = new System.Drawing.Point(530, 40);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(200, 28);
            this.cmbStatusFilter.TabIndex = 5;
            this.cmbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.CmbStatusFilter_SelectedIndexChanged);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnClearFilters.FlatAppearance.BorderSize = 0;
            this.btnClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilters.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClearFilters.ForeColor = System.Drawing.Color.White;
            this.btnClearFilters.Location = new System.Drawing.Point(760, 30);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(150, 38);
            this.btnClearFilters.TabIndex = 6;
            this.btnClearFilters.Text = "Clear Filters";
            this.btnClearFilters.UseVisualStyleBackColor = false;
            this.btnClearFilters.Click += new System.EventHandler(this.BtnClearFilters_Click);
            // 
            // panelSummary
            // 
            this.panelSummary.BackColor = System.Drawing.Color.White;
            this.panelSummary.Controls.Add(this.lblTotalLabel);
            this.panelSummary.Controls.Add(this.lblTotalTeachers);
            this.panelSummary.Controls.Add(this.lblPaidLabel);
            this.panelSummary.Controls.Add(this.lblPaidCount);
            this.panelSummary.Controls.Add(this.lblUnpaidLabel);
            this.panelSummary.Controls.Add(this.lblUnpaidCount);
            this.panelSummary.Controls.Add(this.lblTotalPaidLabel);
            this.panelSummary.Controls.Add(this.lblTotalPaid);
            this.panelSummary.Controls.Add(this.lblTotalPendingLabel);
            this.panelSummary.Controls.Add(this.lblTotalPending);
            this.panelSummary.Location = new System.Drawing.Point(20, 210);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(1060, 80);
            this.panelSummary.TabIndex = 2;
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTotalLabel.Location = new System.Drawing.Point(40, 15);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(91, 15);
            this.lblTotalLabel.TabIndex = 0;
            this.lblTotalLabel.Text = "Total Teachers";
            // 
            // lblTotalTeachers
            // 
            this.lblTotalTeachers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalTeachers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTotalTeachers.Location = new System.Drawing.Point(30, 35);
            this.lblTotalTeachers.Name = "lblTotalTeachers";
            this.lblTotalTeachers.Size = new System.Drawing.Size(110, 35);
            this.lblTotalTeachers.TabIndex = 1;
            this.lblTotalTeachers.Text = "0";
            this.lblTotalTeachers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPaidLabel
            // 
            this.lblPaidLabel.AutoSize = true;
            this.lblPaidLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPaidLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblPaidLabel.Location = new System.Drawing.Point(220, 15);
            this.lblPaidLabel.Name = "lblPaidLabel";
            this.lblPaidLabel.Size = new System.Drawing.Size(31, 15);
            this.lblPaidLabel.TabIndex = 2;
            this.lblPaidLabel.Text = "Paid";
            // 
            // lblPaidCount
            // 
            this.lblPaidCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPaidCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblPaidCount.Location = new System.Drawing.Point(190, 35);
            this.lblPaidCount.Name = "lblPaidCount";
            this.lblPaidCount.Size = new System.Drawing.Size(90, 35);
            this.lblPaidCount.TabIndex = 3;
            this.lblPaidCount.Text = "0";
            this.lblPaidCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnpaidLabel
            // 
            this.lblUnpaidLabel.AutoSize = true;
            this.lblUnpaidLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUnpaidLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblUnpaidLabel.Location = new System.Drawing.Point(370, 15);
            this.lblUnpaidLabel.Name = "lblUnpaidLabel";
            this.lblUnpaidLabel.Size = new System.Drawing.Size(47, 15);
            this.lblUnpaidLabel.TabIndex = 4;
            this.lblUnpaidLabel.Text = "Unpaid";
            // 
            // lblUnpaidCount
            // 
            this.lblUnpaidCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblUnpaidCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblUnpaidCount.Location = new System.Drawing.Point(340, 35);
            this.lblUnpaidCount.Name = "lblUnpaidCount";
            this.lblUnpaidCount.Size = new System.Drawing.Size(90, 35);
            this.lblUnpaidCount.TabIndex = 5;
            this.lblUnpaidCount.Text = "0";
            this.lblUnpaidCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPaidLabel
            // 
            this.lblTotalPaidLabel.AutoSize = true;
            this.lblTotalPaidLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalPaidLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTotalPaidLabel.Location = new System.Drawing.Point(590, 15);
            this.lblTotalPaidLabel.Name = "lblTotalPaidLabel";
            this.lblTotalPaidLabel.Size = new System.Drawing.Size(65, 15);
            this.lblTotalPaidLabel.TabIndex = 6;
            this.lblTotalPaidLabel.Text = "Total Paid";
            // 
            // lblTotalPaid
            // 
            this.lblTotalPaid.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTotalPaid.Location = new System.Drawing.Point(520, 38);
            this.lblTotalPaid.Name = "lblTotalPaid";
            this.lblTotalPaid.Size = new System.Drawing.Size(200, 30);
            this.lblTotalPaid.TabIndex = 7;
            this.lblTotalPaid.Text = "Rs. 0";
            this.lblTotalPaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPendingLabel
            // 
            this.lblTotalPendingLabel.AutoSize = true;
            this.lblTotalPendingLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalPendingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.lblTotalPendingLabel.Location = new System.Drawing.Point(850, 15);
            this.lblTotalPendingLabel.Name = "lblTotalPendingLabel";
            this.lblTotalPendingLabel.Size = new System.Drawing.Size(88, 15);
            this.lblTotalPendingLabel.TabIndex = 8;
            this.lblTotalPendingLabel.Text = "Total Pending";
            // 
            // lblTotalPending
            // 
            this.lblTotalPending.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalPending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.lblTotalPending.Location = new System.Drawing.Point(780, 38);
            this.lblTotalPending.Name = "lblTotalPending";
            this.lblTotalPending.Size = new System.Drawing.Size(230, 30);
            this.lblTotalPending.TabIndex = 9;
            this.lblTotalPending.Text = "Rs. 0";
            this.lblTotalPending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.dgvSalary);
            this.panelMain.Location = new System.Drawing.Point(20, 310);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1060, 420);
            this.panelMain.TabIndex = 3;
            // 
            // dgvSalary
            // 
            this.dgvSalary.AllowUserToAddRows = false;
            this.dgvSalary.AllowUserToDeleteRows = false;
            this.dgvSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalary.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSalary.ColumnHeadersHeight = 40;
            this.dgvSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSalary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmployeeId,
            this.colTeacherName,
            this.colGrade,
            this.colSalary,
            this.colStatus,
            this.colAction});
            this.dgvSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalary.Location = new System.Drawing.Point(0, 0);
            this.dgvSalary.Name = "dgvSalary";
            this.dgvSalary.ReadOnly = true;
            this.dgvSalary.RowHeadersVisible = false;
            this.dgvSalary.RowTemplate.Height = 35;
            this.dgvSalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalary.Size = new System.Drawing.Size(1060, 420);
            this.dgvSalary.TabIndex = 0;
            this.dgvSalary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSalary_CellContentClick);
            this.dgvSalary.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvSalary_ColumnHeaderMouseClick);
            // 
            // colEmployeeId
            // 
            this.colEmployeeId.HeaderText = "Employee ID";
            this.colEmployeeId.Name = "colEmployeeId";
            this.colEmployeeId.ReadOnly = true;
            this.colEmployeeId.FillWeight = 15F;
            // 
            // colTeacherName
            // 
            this.colTeacherName.HeaderText = "Teacher Name";
            this.colTeacherName.Name = "colTeacherName";
            this.colTeacherName.ReadOnly = true;
            this.colTeacherName.FillWeight = 30F;
            // 
            // colGrade
            // 
            this.colGrade.HeaderText = "Assigned Grade";
            this.colGrade.Name = "colGrade";
            this.colGrade.ReadOnly = true;
            this.colGrade.FillWeight = 15F;
            // 
            // colSalary
            // 
            this.colSalary.HeaderText = "Monthly Salary (Rs.)";
            this.colSalary.Name = "colSalary";
            this.colSalary.ReadOnly = true;
            this.colSalary.FillWeight = 18F;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Payment Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.FillWeight = 15F;
            // 
            // colAction
            // 
            this.colAction.HeaderText = "Action";
            this.colAction.Name = "colAction";
            this.colAction.ReadOnly = true;
            this.colAction.FillWeight = 12F;
            // 
            // PayTeacherSalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1100, 750);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PayTeacherSalaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay Teacher Salary";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            this.panelSummary.ResumeLayout(false);
            this.panelSummary.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchTeacher;
        private System.Windows.Forms.Label lblGradeFilter;
        private System.Windows.Forms.ComboBox cmbGradeFilter;
        private System.Windows.Forms.Label lblStatusFilter;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblTotalTeachers;
        private System.Windows.Forms.Label lblPaidLabel;
        private System.Windows.Forms.Label lblPaidCount;
        private System.Windows.Forms.Label lblUnpaidLabel;
        private System.Windows.Forms.Label lblUnpaidCount;
        private System.Windows.Forms.Label lblTotalPaidLabel;
        private System.Windows.Forms.Label lblTotalPaid;
        private System.Windows.Forms.Label lblTotalPendingLabel;
        private System.Windows.Forms.Label lblTotalPending;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dgvSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colAction;
    }
}
