namespace SchoolManagementSystem
{
    partial class SubmitMonthlyFeeForm
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
            this.components = new System.ComponentModel.Container();
            
            // Main Panels
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            
            // Filter Section
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.cmbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.lblSearchLabel = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            
            // Due Date Panel
            this.pnlDueDate = new System.Windows.Forms.Panel();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblOverdueInfo = new System.Windows.Forms.Label();
            
            // Action Buttons
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnLoadStudents = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnDeselectAll = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            
            // Data Grid
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.colSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colAdmissionNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRollNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonthlyFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLateFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScholarship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            
            // Summary Panel
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.pnlTotalStudents = new System.Windows.Forms.Panel();
            this.lblTotalStudentsLabel = new System.Windows.Forms.Label();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.pnlPaidCount = new System.Windows.Forms.Panel();
            this.lblPaidCountLabel = new System.Windows.Forms.Label();
            this.lblPaidCount = new System.Windows.Forms.Label();
            this.pnlUnpaidCount = new System.Windows.Forms.Panel();
            this.lblUnpaidCountLabel = new System.Windows.Forms.Label();
            this.lblUnpaidCount = new System.Windows.Forms.Label();
            this.pnlSelectedCount = new System.Windows.Forms.Panel();
            this.lblSelectedCountLabel = new System.Windows.Forms.Label();
            this.lblSelectedCount = new System.Windows.Forms.Label();
            
            // Fee Summary Panel
            this.pnlFeeSummary = new System.Windows.Forms.Panel();
            this.pnlTotalFees = new System.Windows.Forms.Panel();
            this.lblTotalFeesLabel = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.pnlTotalLateFees = new System.Windows.Forms.Panel();
            this.lblTotalLateFeesLabel = new System.Windows.Forms.Label();
            this.lblTotalLateFees = new System.Windows.Forms.Label();
            this.pnlGrandTotal = new System.Windows.Forms.Panel();
            this.lblGrandTotalLabel = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            
            // Submit Button
            this.btnSubmitSelected = new System.Windows.Forms.Button();
            
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            
            // =============================================
            // HEADER PANEL
            // =============================================
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 80);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            
            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 37);
            this.lblTitle.Text = "💰 Submit Monthly Fee";
            
            // lblSubtitle
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.lblSubtitle.Location = new System.Drawing.Point(24, 52);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(400, 19);
            this.lblSubtitle.Text = "Process fee payments with automatic late fine calculation (Rs. 50/day after 10th)";
            
            // =============================================
            // FILTER PANEL
            // =============================================
            this.pnlFilters.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.pnlFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilters.Location = new System.Drawing.Point(20, 95);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(1160, 90);
            this.pnlFilters.Controls.Add(this.lblClass);
            this.pnlFilters.Controls.Add(this.cmbClass);
            this.pnlFilters.Controls.Add(this.lblSection);
            this.pnlFilters.Controls.Add(this.cmbSection);
            this.pnlFilters.Controls.Add(this.lblMonth);
            this.pnlFilters.Controls.Add(this.cmbMonth);
            this.pnlFilters.Controls.Add(this.lblYear);
            this.pnlFilters.Controls.Add(this.cmbYear);
            this.pnlFilters.Controls.Add(this.lblPaymentStatus);
            this.pnlFilters.Controls.Add(this.cmbPaymentStatus);
            this.pnlFilters.Controls.Add(this.lblSearchLabel);
            this.pnlFilters.Controls.Add(this.txtSearch);
            
            // Row 1 - Class, Section, Month, Year
            // lblClass
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblClass.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblClass.Location = new System.Drawing.Point(15, 12);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(40, 15);
            this.lblClass.Text = "Class:";
            
            // cmbClass
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbClass.Location = new System.Drawing.Point(15, 30);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(140, 25);
            
            // lblSection
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblSection.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblSection.Location = new System.Drawing.Point(170, 12);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(52, 15);
            this.lblSection.Text = "Section:";
            
            // cmbSection
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSection.Location = new System.Drawing.Point(170, 30);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(100, 25);
            
            // lblMonth
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblMonth.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblMonth.Location = new System.Drawing.Point(290, 12);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(48, 15);
            this.lblMonth.Text = "Month:";
            
            // cmbMonth
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMonth.Location = new System.Drawing.Point(290, 30);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(120, 25);
            
            // lblYear
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblYear.Location = new System.Drawing.Point(425, 12);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(34, 15);
            this.lblYear.Text = "Year:";
            
            // cmbYear
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbYear.Location = new System.Drawing.Point(425, 30);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(90, 25);
            
            // lblPaymentStatus
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPaymentStatus.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblPaymentStatus.Location = new System.Drawing.Point(535, 12);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(100, 15);
            this.lblPaymentStatus.Text = "Payment Status:";
            
            // cmbPaymentStatus
            this.cmbPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPaymentStatus.Location = new System.Drawing.Point(535, 30);
            this.cmbPaymentStatus.Name = "cmbPaymentStatus";
            this.cmbPaymentStatus.Size = new System.Drawing.Size(130, 25);
            
            // lblSearchLabel
            this.lblSearchLabel.AutoSize = true;
            this.lblSearchLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearchLabel.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblSearchLabel.Location = new System.Drawing.Point(685, 12);
            this.lblSearchLabel.Name = "lblSearchLabel";
            this.lblSearchLabel.Size = new System.Drawing.Size(125, 15);
            this.lblSearchLabel.Text = "Search Name/Adm#:";
            
            // txtSearch
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(685, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(180, 25);
            this.txtSearch.PlaceholderText = "Search...";
            
            // =============================================
            // DUE DATE PANEL
            // =============================================
            this.pnlDueDate.BackColor = System.Drawing.Color.FromArgb(255, 243, 205);
            this.pnlDueDate.Location = new System.Drawing.Point(890, 100);
            this.pnlDueDate.Name = "pnlDueDate";
            this.pnlDueDate.Size = new System.Drawing.Size(290, 80);
            this.pnlDueDate.Controls.Add(this.lblDueDate);
            this.pnlDueDate.Controls.Add(this.lblOverdueInfo);
            
            // lblDueDate
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDueDate.ForeColor = System.Drawing.Color.FromArgb(133, 100, 4);
            this.lblDueDate.Location = new System.Drawing.Point(15, 15);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(170, 21);
            this.lblDueDate.Text = "📅 Due Date: 10 Jan 2025";
            
            // lblOverdueInfo
            this.lblOverdueInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOverdueInfo.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.lblOverdueInfo.Location = new System.Drawing.Point(15, 42);
            this.lblOverdueInfo.Name = "lblOverdueInfo";
            this.lblOverdueInfo.Size = new System.Drawing.Size(260, 35);
            this.lblOverdueInfo.Text = "⚠ 5 days overdue (Late fee: Rs. 250)";
            
            // =============================================
            // BUTTON PANEL
            // =============================================
            this.pnlButtons.Location = new System.Drawing.Point(20, 195);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1160, 45);
            this.pnlButtons.Controls.Add(this.btnLoadStudents);
            this.pnlButtons.Controls.Add(this.btnSelectAll);
            this.pnlButtons.Controls.Add(this.btnDeselectAll);
            this.pnlButtons.Controls.Add(this.btnRefresh);
            
            // btnLoadStudents
            this.btnLoadStudents.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnLoadStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadStudents.FlatAppearance.BorderSize = 0;
            this.btnLoadStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadStudents.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoadStudents.ForeColor = System.Drawing.Color.White;
            this.btnLoadStudents.Location = new System.Drawing.Point(0, 5);
            this.btnLoadStudents.Name = "btnLoadStudents";
            this.btnLoadStudents.Size = new System.Drawing.Size(150, 38);
            this.btnLoadStudents.Text = "📋 Load Students";
            
            // btnSelectAll
            this.btnSelectAll.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnSelectAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectAll.FlatAppearance.BorderSize = 0;
            this.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectAll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSelectAll.ForeColor = System.Drawing.Color.White;
            this.btnSelectAll.Location = new System.Drawing.Point(165, 5);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(120, 38);
            this.btnSelectAll.Text = "✓ Select All";
            
            // btnDeselectAll
            this.btnDeselectAll.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnDeselectAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeselectAll.FlatAppearance.BorderSize = 0;
            this.btnDeselectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeselectAll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeselectAll.ForeColor = System.Drawing.Color.White;
            this.btnDeselectAll.Location = new System.Drawing.Point(300, 5);
            this.btnDeselectAll.Name = "btnDeselectAll";
            this.btnDeselectAll.Size = new System.Drawing.Size(130, 38);
            this.btnDeselectAll.Text = "✗ Deselect All";
            
            // btnRefresh
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(445, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 38);
            this.btnRefresh.Text = "🔄 Refresh";
            
            // =============================================
            // DATA GRID VIEW
            // =============================================
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AllowUserToResizeRows = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStudents.ColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
            {
                BackColor = System.Drawing.Color.FromArgb(41, 128, 185),
                ForeColor = System.Drawing.Color.White,
                Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold),
                SelectionBackColor = System.Drawing.Color.FromArgb(41, 128, 185),
                SelectionForeColor = System.Drawing.Color.White,
                Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter,
                Padding = new System.Windows.Forms.Padding(5)
            };
            this.dgvStudents.ColumnHeadersHeight = 42;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStudents.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
            {
                BackColor = System.Drawing.Color.White,
                ForeColor = System.Drawing.Color.FromArgb(44, 62, 80),
                Font = new System.Drawing.Font("Segoe UI", 9F),
                SelectionBackColor = System.Drawing.Color.FromArgb(52, 152, 219),
                SelectionForeColor = System.Drawing.Color.White,
                Padding = new System.Windows.Forms.Padding(3)
            };
            this.dgvStudents.EnableHeadersVisualStyles = false;
            this.dgvStudents.GridColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.dgvStudents.Location = new System.Drawing.Point(20, 250);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 38;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(1160, 350);
            this.dgvStudents.TabIndex = 1;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colSelect,
                this.colAdmissionNo,
                this.colStudentName,
                this.colClassName,
                this.colSection,
                this.colRollNo,
                this.colMonthlyFee,
                this.colLateFee,
                this.colTotalDue,
                this.colStatus,
                this.colScholarship
            });
            
            // colSelect
            this.colSelect.HeaderText = "Select";
            this.colSelect.Name = "colSelect";
            this.colSelect.FillWeight = 45;
            
            // colAdmissionNo
            this.colAdmissionNo.HeaderText = "Admission #";
            this.colAdmissionNo.Name = "colAdmissionNo";
            this.colAdmissionNo.ReadOnly = true;
            this.colAdmissionNo.FillWeight = 100;
            
            // colStudentName
            this.colStudentName.HeaderText = "Student Name";
            this.colStudentName.Name = "colStudentName";
            this.colStudentName.ReadOnly = true;
            this.colStudentName.FillWeight = 130;
            
            // colClassName
            this.colClassName.HeaderText = "Class";
            this.colClassName.Name = "colClassName";
            this.colClassName.ReadOnly = true;
            this.colClassName.FillWeight = 70;
            
            // colSection
            this.colSection.HeaderText = "Section";
            this.colSection.Name = "colSection";
            this.colSection.ReadOnly = true;
            this.colSection.FillWeight = 55;
            
            // colRollNo
            this.colRollNo.HeaderText = "Roll #";
            this.colRollNo.Name = "colRollNo";
            this.colRollNo.ReadOnly = true;
            this.colRollNo.FillWeight = 50;
            
            // colMonthlyFee
            this.colMonthlyFee.HeaderText = "Monthly Fee";
            this.colMonthlyFee.Name = "colMonthlyFee";
            this.colMonthlyFee.ReadOnly = true;
            this.colMonthlyFee.FillWeight = 85;
            
            // colLateFee
            this.colLateFee.HeaderText = "Late Fee";
            this.colLateFee.Name = "colLateFee";
            this.colLateFee.ReadOnly = true;
            this.colLateFee.FillWeight = 70;
            
            // colTotalDue
            this.colTotalDue.HeaderText = "Total Due";
            this.colTotalDue.Name = "colTotalDue";
            this.colTotalDue.ReadOnly = true;
            this.colTotalDue.FillWeight = 80;
            
            // colStatus
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.FillWeight = 65;
            
            // colScholarship
            this.colScholarship.HeaderText = "Scholarship";
            this.colScholarship.Name = "colScholarship";
            this.colScholarship.ReadOnly = true;
            this.colScholarship.FillWeight = 70;
            
            // =============================================
            // SUMMARY PANEL - Student Counts
            // =============================================
            this.pnlSummary.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummary.Location = new System.Drawing.Point(20, 610);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(550, 70);
            this.pnlSummary.Controls.Add(this.pnlTotalStudents);
            this.pnlSummary.Controls.Add(this.pnlPaidCount);
            this.pnlSummary.Controls.Add(this.pnlUnpaidCount);
            this.pnlSummary.Controls.Add(this.pnlSelectedCount);
            
            // pnlTotalStudents
            this.pnlTotalStudents.BackColor = System.Drawing.Color.White;
            this.pnlTotalStudents.Location = new System.Drawing.Point(10, 10);
            this.pnlTotalStudents.Size = new System.Drawing.Size(120, 50);
            this.pnlTotalStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalStudents.Controls.Add(this.lblTotalStudentsLabel);
            this.pnlTotalStudents.Controls.Add(this.lblTotalStudents);
            
            this.lblTotalStudentsLabel.AutoSize = true;
            this.lblTotalStudentsLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTotalStudentsLabel.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lblTotalStudentsLabel.Location = new System.Drawing.Point(8, 5);
            this.lblTotalStudentsLabel.Text = "Total Students";
            
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalStudents.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.lblTotalStudents.Location = new System.Drawing.Point(8, 22);
            this.lblTotalStudents.Text = "0";
            
            // pnlPaidCount
            this.pnlPaidCount.BackColor = System.Drawing.Color.White;
            this.pnlPaidCount.Location = new System.Drawing.Point(140, 10);
            this.pnlPaidCount.Size = new System.Drawing.Size(120, 50);
            this.pnlPaidCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPaidCount.Controls.Add(this.lblPaidCountLabel);
            this.pnlPaidCount.Controls.Add(this.lblPaidCount);
            
            this.lblPaidCountLabel.AutoSize = true;
            this.lblPaidCountLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPaidCountLabel.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lblPaidCountLabel.Location = new System.Drawing.Point(8, 5);
            this.lblPaidCountLabel.Text = "Paid";
            
            this.lblPaidCount.AutoSize = true;
            this.lblPaidCount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblPaidCount.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblPaidCount.Location = new System.Drawing.Point(8, 22);
            this.lblPaidCount.Text = "0";
            
            // pnlUnpaidCount
            this.pnlUnpaidCount.BackColor = System.Drawing.Color.White;
            this.pnlUnpaidCount.Location = new System.Drawing.Point(270, 10);
            this.pnlUnpaidCount.Size = new System.Drawing.Size(120, 50);
            this.pnlUnpaidCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUnpaidCount.Controls.Add(this.lblUnpaidCountLabel);
            this.pnlUnpaidCount.Controls.Add(this.lblUnpaidCount);
            
            this.lblUnpaidCountLabel.AutoSize = true;
            this.lblUnpaidCountLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblUnpaidCountLabel.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lblUnpaidCountLabel.Location = new System.Drawing.Point(8, 5);
            this.lblUnpaidCountLabel.Text = "Unpaid";
            
            this.lblUnpaidCount.AutoSize = true;
            this.lblUnpaidCount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblUnpaidCount.ForeColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.lblUnpaidCount.Location = new System.Drawing.Point(8, 22);
            this.lblUnpaidCount.Text = "0";
            
            // pnlSelectedCount
            this.pnlSelectedCount.BackColor = System.Drawing.Color.White;
            this.pnlSelectedCount.Location = new System.Drawing.Point(400, 10);
            this.pnlSelectedCount.Size = new System.Drawing.Size(140, 50);
            this.pnlSelectedCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelectedCount.Controls.Add(this.lblSelectedCountLabel);
            this.pnlSelectedCount.Controls.Add(this.lblSelectedCount);
            
            this.lblSelectedCountLabel.AutoSize = true;
            this.lblSelectedCountLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSelectedCountLabel.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lblSelectedCountLabel.Location = new System.Drawing.Point(8, 5);
            this.lblSelectedCountLabel.Text = "Selected";
            
            this.lblSelectedCount.AutoSize = true;
            this.lblSelectedCount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblSelectedCount.ForeColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.lblSelectedCount.Location = new System.Drawing.Point(8, 22);
            this.lblSelectedCount.Text = "0";
            
            // =============================================
            // FEE SUMMARY PANEL
            // =============================================
            this.pnlFeeSummary.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.pnlFeeSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFeeSummary.Location = new System.Drawing.Point(590, 610);
            this.pnlFeeSummary.Name = "pnlFeeSummary";
            this.pnlFeeSummary.Size = new System.Drawing.Size(410, 70);
            this.pnlFeeSummary.Controls.Add(this.pnlTotalFees);
            this.pnlFeeSummary.Controls.Add(this.pnlTotalLateFees);
            this.pnlFeeSummary.Controls.Add(this.pnlGrandTotal);
            
            // pnlTotalFees
            this.pnlTotalFees.BackColor = System.Drawing.Color.White;
            this.pnlTotalFees.Location = new System.Drawing.Point(10, 10);
            this.pnlTotalFees.Size = new System.Drawing.Size(120, 50);
            this.pnlTotalFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalFees.Controls.Add(this.lblTotalFeesLabel);
            this.pnlTotalFees.Controls.Add(this.lblTotalFees);
            
            this.lblTotalFeesLabel.AutoSize = true;
            this.lblTotalFeesLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTotalFeesLabel.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lblTotalFeesLabel.Location = new System.Drawing.Point(8, 5);
            this.lblTotalFeesLabel.Text = "Total Fees";
            
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalFees.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblTotalFees.Location = new System.Drawing.Point(8, 24);
            this.lblTotalFees.Text = "Rs. 0";
            
            // pnlTotalLateFees
            this.pnlTotalLateFees.BackColor = System.Drawing.Color.White;
            this.pnlTotalLateFees.Location = new System.Drawing.Point(140, 10);
            this.pnlTotalLateFees.Size = new System.Drawing.Size(120, 50);
            this.pnlTotalLateFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalLateFees.Controls.Add(this.lblTotalLateFeesLabel);
            this.pnlTotalLateFees.Controls.Add(this.lblTotalLateFees);
            
            this.lblTotalLateFeesLabel.AutoSize = true;
            this.lblTotalLateFeesLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTotalLateFeesLabel.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lblTotalLateFeesLabel.Location = new System.Drawing.Point(8, 5);
            this.lblTotalLateFeesLabel.Text = "Late Fees";
            
            this.lblTotalLateFees.AutoSize = true;
            this.lblTotalLateFees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalLateFees.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.lblTotalLateFees.Location = new System.Drawing.Point(8, 24);
            this.lblTotalLateFees.Text = "Rs. 0";
            
            // pnlGrandTotal
            this.pnlGrandTotal.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.pnlGrandTotal.Location = new System.Drawing.Point(270, 10);
            this.pnlGrandTotal.Size = new System.Drawing.Size(130, 50);
            this.pnlGrandTotal.Controls.Add(this.lblGrandTotalLabel);
            this.pnlGrandTotal.Controls.Add(this.lblGrandTotal);
            
            this.lblGrandTotalLabel.AutoSize = true;
            this.lblGrandTotalLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblGrandTotalLabel.ForeColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.lblGrandTotalLabel.Location = new System.Drawing.Point(8, 5);
            this.lblGrandTotalLabel.Text = "Grand Total";
            
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGrandTotal.ForeColor = System.Drawing.Color.White;
            this.lblGrandTotal.Location = new System.Drawing.Point(8, 24);
            this.lblGrandTotal.Text = "Rs. 0";
            
            // =============================================
            // SUBMIT BUTTON
            // =============================================
            this.btnSubmitSelected.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnSubmitSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitSelected.FlatAppearance.BorderSize = 0;
            this.btnSubmitSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitSelected.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmitSelected.ForeColor = System.Drawing.Color.White;
            this.btnSubmitSelected.Location = new System.Drawing.Point(1020, 610);
            this.btnSubmitSelected.Name = "btnSubmitSelected";
            this.btnSubmitSelected.Size = new System.Drawing.Size(160, 70);
            this.btnSubmitSelected.Text = "💳 Submit Fee";
            this.btnSubmitSelected.Enabled = false;
            
            // =============================================
            // FORM SETTINGS
            // =============================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.pnlDueDate);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlFeeSummary);
            this.Controls.Add(this.btnSubmitSelected);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SubmitMonthlyFeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Submit Monthly Fee - School Management System";
            
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        // Header Panel
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        
        // Filter Panel
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.ComboBox cmbPaymentStatus;
        private System.Windows.Forms.Label lblSearchLabel;
        private System.Windows.Forms.TextBox txtSearch;
        
        // Due Date Panel
        private System.Windows.Forms.Panel pnlDueDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblOverdueInfo;
        
        // Button Panel
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnLoadStudents;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnDeselectAll;
        private System.Windows.Forms.Button btnRefresh;
        
        // Data Grid
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdmissionNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRollNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonthlyFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLateFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScholarship;
        
        // Summary Panel - Student Counts
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Panel pnlTotalStudents;
        private System.Windows.Forms.Label lblTotalStudentsLabel;
        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.Panel pnlPaidCount;
        private System.Windows.Forms.Label lblPaidCountLabel;
        private System.Windows.Forms.Label lblPaidCount;
        private System.Windows.Forms.Panel pnlUnpaidCount;
        private System.Windows.Forms.Label lblUnpaidCountLabel;
        private System.Windows.Forms.Label lblUnpaidCount;
        private System.Windows.Forms.Panel pnlSelectedCount;
        private System.Windows.Forms.Label lblSelectedCountLabel;
        private System.Windows.Forms.Label lblSelectedCount;
        
        // Fee Summary Panel
        private System.Windows.Forms.Panel pnlFeeSummary;
        private System.Windows.Forms.Panel pnlTotalFees;
        private System.Windows.Forms.Label lblTotalFeesLabel;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Panel pnlTotalLateFees;
        private System.Windows.Forms.Label lblTotalLateFeesLabel;
        private System.Windows.Forms.Label lblTotalLateFees;
        private System.Windows.Forms.Panel pnlGrandTotal;
        private System.Windows.Forms.Label lblGrandTotalLabel;
        private System.Windows.Forms.Label lblGrandTotal;
        
        // Submit Button
        private System.Windows.Forms.Button btnSubmitSelected;
    }
}
