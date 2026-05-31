namespace SchoolManagementSystem
{
    partial class SubmitAnnualFeeForm
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
            
            // Academic Year Panel
            this.pnlAcademicYear = new System.Windows.Forms.Panel();
            this.lblAcademicYear = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblOverdueInfo = new System.Windows.Forms.Label();
            
            // Filter Section
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.cmbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.lblSearchLabel = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblRollNumber = new System.Windows.Forms.Label();
            this.txtRollNumber = new System.Windows.Forms.TextBox();
            
            // Action Buttons
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnLoadStudents = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnDeselectAll = new System.Windows.Forms.Button();
            this.btnViewBreakdown = new System.Windows.Forms.Button();
            
            // Data Grid
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.colSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colAdmissionNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRollNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnnualFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmountPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmountDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScholarship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            
            // Summary Panel - Student Counts
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.pnlTotalStudents = new System.Windows.Forms.Panel();
            this.lblTotalStudentsLabel = new System.Windows.Forms.Label();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.pnlPaidCount = new System.Windows.Forms.Panel();
            this.lblPaidCountLabel = new System.Windows.Forms.Label();
            this.lblPaidCount = new System.Windows.Forms.Label();
            this.pnlPartialCount = new System.Windows.Forms.Panel();
            this.lblPartialCountLabel = new System.Windows.Forms.Label();
            this.lblPartialCount = new System.Windows.Forms.Label();
            this.pnlUnpaidCount = new System.Windows.Forms.Panel();
            this.lblUnpaidCountLabel = new System.Windows.Forms.Label();
            this.lblUnpaidCount = new System.Windows.Forms.Label();
            this.pnlSelectedCount = new System.Windows.Forms.Panel();
            this.lblSelectedCountLabel = new System.Windows.Forms.Label();
            this.lblSelectedCount = new System.Windows.Forms.Label();
            
            // Amount Summary Panel
            this.pnlAmountSummary = new System.Windows.Forms.Panel();
            this.pnlTotalAmountDue = new System.Windows.Forms.Panel();
            this.lblTotalAmountDueLabel = new System.Windows.Forms.Label();
            this.lblTotalAmountDue = new System.Windows.Forms.Label();
            this.pnlSelectedAmount = new System.Windows.Forms.Panel();
            this.lblSelectedAmountLabel = new System.Windows.Forms.Label();
            this.lblSelectedAmount = new System.Windows.Forms.Label();
            
            // Submit Button
            this.btnSubmitSelected = new System.Windows.Forms.Button();
            
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            
            // =============================================
            // HEADER PANEL
            // =============================================
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1250, 80);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.pnlAcademicYear);
            
            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 37);
            this.lblTitle.Text = "📋 Submit Annual Fee";
            
            // lblSubtitle
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.lblSubtitle.Location = new System.Drawing.Point(24, 52);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(380, 19);
            this.lblSubtitle.Text = "Process annual fee payments including admission, lab, sports & more";
            
            // =============================================
            // ACADEMIC YEAR PANEL
            // =============================================
            this.pnlAcademicYear.BackColor = System.Drawing.Color.FromArgb(142, 68, 173);
            this.pnlAcademicYear.Location = new System.Drawing.Point(950, 10);
            this.pnlAcademicYear.Name = "pnlAcademicYear";
            this.pnlAcademicYear.Size = new System.Drawing.Size(280, 60);
            this.pnlAcademicYear.Controls.Add(this.lblAcademicYear);
            this.pnlAcademicYear.Controls.Add(this.lblDueDate);
            this.pnlAcademicYear.Controls.Add(this.lblOverdueInfo);
            
            // lblAcademicYear
            this.lblAcademicYear.AutoSize = true;
            this.lblAcademicYear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAcademicYear.ForeColor = System.Drawing.Color.White;
            this.lblAcademicYear.Location = new System.Drawing.Point(12, 8);
            this.lblAcademicYear.Name = "lblAcademicYear";
            this.lblAcademicYear.Size = new System.Drawing.Size(180, 20);
            this.lblAcademicYear.Text = "📅 Academic Year: 2025-2026";
            
            // lblDueDate
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDueDate.ForeColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.lblDueDate.Location = new System.Drawing.Point(12, 28);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(130, 15);
            this.lblDueDate.Text = "Due Date: 15 Apr 2025";
            
            // lblOverdueInfo
            this.lblOverdueInfo.AutoSize = true;
            this.lblOverdueInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOverdueInfo.ForeColor = System.Drawing.Color.FromArgb(255, 200, 200);
            this.lblOverdueInfo.Location = new System.Drawing.Point(12, 44);
            this.lblOverdueInfo.Name = "lblOverdueInfo";
            this.lblOverdueInfo.Size = new System.Drawing.Size(150, 15);
            this.lblOverdueInfo.Text = "⚠ 30 days past due date";
            
            // =============================================
            // FILTER PANEL
            // =============================================
            this.pnlFilters.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.pnlFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilters.Location = new System.Drawing.Point(20, 95);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(1210, 65);
            this.pnlFilters.Controls.Add(this.lblClass);
            this.pnlFilters.Controls.Add(this.cmbClass);
            this.pnlFilters.Controls.Add(this.lblSection);
            this.pnlFilters.Controls.Add(this.cmbSection);
            this.pnlFilters.Controls.Add(this.lblPaymentStatus);
            this.pnlFilters.Controls.Add(this.cmbPaymentStatus);
            this.pnlFilters.Controls.Add(this.lblSort);
            this.pnlFilters.Controls.Add(this.cmbSort);
            this.pnlFilters.Controls.Add(this.lblSearchLabel);
            this.pnlFilters.Controls.Add(this.txtSearch);
            this.pnlFilters.Controls.Add(this.lblRollNumber);
            this.pnlFilters.Controls.Add(this.txtRollNumber);
            
            // lblClass
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblClass.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblClass.Location = new System.Drawing.Point(15, 8);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(40, 15);
            this.lblClass.Text = "Class:";
            
            // cmbClass
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbClass.Location = new System.Drawing.Point(15, 26);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(130, 25);
            
            // lblSection
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblSection.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblSection.Location = new System.Drawing.Point(160, 8);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(52, 15);
            this.lblSection.Text = "Section:";
            
            // cmbSection
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSection.Location = new System.Drawing.Point(160, 26);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(90, 25);
            
            // lblPaymentStatus
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPaymentStatus.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblPaymentStatus.Location = new System.Drawing.Point(270, 8);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(48, 15);
            this.lblPaymentStatus.Text = "Status:";
            
            // cmbPaymentStatus
            this.cmbPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPaymentStatus.Location = new System.Drawing.Point(270, 26);
            this.cmbPaymentStatus.Name = "cmbPaymentStatus";
            this.cmbPaymentStatus.Size = new System.Drawing.Size(130, 25);
            
            // lblSort
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblSort.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblSort.Location = new System.Drawing.Point(420, 8);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(51, 15);
            this.lblSort.Text = "Sort By:";
            
            // cmbSort
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSort.Location = new System.Drawing.Point(420, 26);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(160, 25);
            
            // lblSearchLabel
            this.lblSearchLabel.AutoSize = true;
            this.lblSearchLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearchLabel.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblSearchLabel.Location = new System.Drawing.Point(600, 8);
            this.lblSearchLabel.Name = "lblSearchLabel";
            this.lblSearchLabel.Size = new System.Drawing.Size(105, 15);
            this.lblSearchLabel.Text = "Search Name/ID:";
            
            // txtSearch
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(600, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(180, 25);
            this.txtSearch.PlaceholderText = "Search...";
            
            // lblRollNumber
            this.lblRollNumber.AutoSize = true;
            this.lblRollNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblRollNumber.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblRollNumber.Location = new System.Drawing.Point(800, 8);
            this.lblRollNumber.Name = "lblRollNumber";
            this.lblRollNumber.Size = new System.Drawing.Size(48, 15);
            this.lblRollNumber.Text = "Roll No:";
            
            // txtRollNumber
            this.txtRollNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRollNumber.Location = new System.Drawing.Point(800, 26);
            this.txtRollNumber.Name = "txtRollNumber";
            this.txtRollNumber.Size = new System.Drawing.Size(80, 25);
            this.txtRollNumber.PlaceholderText = "Roll #";
            
            // =============================================
            // BUTTON PANEL
            // =============================================
            this.pnlButtons.Location = new System.Drawing.Point(20, 170);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1210, 45);
            this.pnlButtons.Controls.Add(this.btnLoadStudents);
            this.pnlButtons.Controls.Add(this.btnSelectAll);
            this.pnlButtons.Controls.Add(this.btnDeselectAll);
            this.pnlButtons.Controls.Add(this.btnViewBreakdown);
            
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
            this.btnSelectAll.Size = new System.Drawing.Size(130, 38);
            this.btnSelectAll.Text = "✓ Select All";
            
            // btnDeselectAll
            this.btnDeselectAll.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnDeselectAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeselectAll.FlatAppearance.BorderSize = 0;
            this.btnDeselectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeselectAll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeselectAll.ForeColor = System.Drawing.Color.White;
            this.btnDeselectAll.Location = new System.Drawing.Point(310, 5);
            this.btnDeselectAll.Name = "btnDeselectAll";
            this.btnDeselectAll.Size = new System.Drawing.Size(130, 38);
            this.btnDeselectAll.Text = "✗ Deselect All";
            
            // btnViewBreakdown
            this.btnViewBreakdown.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.btnViewBreakdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewBreakdown.FlatAppearance.BorderSize = 0;
            this.btnViewBreakdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBreakdown.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnViewBreakdown.ForeColor = System.Drawing.Color.White;
            this.btnViewBreakdown.Location = new System.Drawing.Point(455, 5);
            this.btnViewBreakdown.Name = "btnViewBreakdown";
            this.btnViewBreakdown.Size = new System.Drawing.Size(150, 38);
            this.btnViewBreakdown.Text = "📊 Fee Breakdown";
            
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
                BackColor = System.Drawing.Color.FromArgb(155, 89, 182),
                ForeColor = System.Drawing.Color.White,
                Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold),
                SelectionBackColor = System.Drawing.Color.FromArgb(155, 89, 182),
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
                SelectionBackColor = System.Drawing.Color.FromArgb(175, 122, 197),
                SelectionForeColor = System.Drawing.Color.White,
                Padding = new System.Windows.Forms.Padding(3)
            };
            this.dgvStudents.EnableHeadersVisualStyles = false;
            this.dgvStudents.GridColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.dgvStudents.Location = new System.Drawing.Point(20, 225);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 38;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(1210, 360);
            this.dgvStudents.TabIndex = 1;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colSelect,
                this.colAdmissionNo,
                this.colStudentName,
                this.colClassName,
                this.colSection,
                this.colRollNo,
                this.colAnnualFee,
                this.colAmountPaid,
                this.colAmountDue,
                this.colStatus,
                this.colScholarship
            });
            
            // colSelect
            this.colSelect.HeaderText = "Select";
            this.colSelect.Name = "colSelect";
            this.colSelect.FillWeight = 40;
            
            // colAdmissionNo
            this.colAdmissionNo.HeaderText = "Admission #";
            this.colAdmissionNo.Name = "colAdmissionNo";
            this.colAdmissionNo.ReadOnly = true;
            this.colAdmissionNo.FillWeight = 90;
            
            // colStudentName
            this.colStudentName.HeaderText = "Student Name";
            this.colStudentName.Name = "colStudentName";
            this.colStudentName.ReadOnly = true;
            this.colStudentName.FillWeight = 130;
            
            // colClassName
            this.colClassName.HeaderText = "Class";
            this.colClassName.Name = "colClassName";
            this.colClassName.ReadOnly = true;
            this.colClassName.FillWeight = 60;
            
            // colSection
            this.colSection.HeaderText = "Sec";
            this.colSection.Name = "colSection";
            this.colSection.ReadOnly = true;
            this.colSection.FillWeight = 40;
            
            // colRollNo
            this.colRollNo.HeaderText = "Roll";
            this.colRollNo.Name = "colRollNo";
            this.colRollNo.ReadOnly = true;
            this.colRollNo.FillWeight = 40;
            
            // colAnnualFee
            this.colAnnualFee.HeaderText = "Annual Fee";
            this.colAnnualFee.Name = "colAnnualFee";
            this.colAnnualFee.ReadOnly = true;
            this.colAnnualFee.FillWeight = 80;
            
            // colAmountPaid
            this.colAmountPaid.HeaderText = "Paid";
            this.colAmountPaid.Name = "colAmountPaid";
            this.colAmountPaid.ReadOnly = true;
            this.colAmountPaid.FillWeight = 70;
            
            // colAmountDue
            this.colAmountDue.HeaderText = "Amount Due";
            this.colAmountDue.Name = "colAmountDue";
            this.colAmountDue.ReadOnly = true;
            this.colAmountDue.FillWeight = 85;
            
            // colStatus
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.FillWeight = 80;
            
            // colScholarship
            this.colScholarship.HeaderText = "Scholarship";
            this.colScholarship.Name = "colScholarship";
            this.colScholarship.ReadOnly = true;
            this.colScholarship.FillWeight = 65;
            
            // =============================================
            // SUMMARY PANEL - Student Counts
            // =============================================
            this.pnlSummary.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummary.Location = new System.Drawing.Point(20, 595);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(680, 70);
            this.pnlSummary.Controls.Add(this.pnlTotalStudents);
            this.pnlSummary.Controls.Add(this.pnlPaidCount);
            this.pnlSummary.Controls.Add(this.pnlPartialCount);
            this.pnlSummary.Controls.Add(this.pnlUnpaidCount);
            this.pnlSummary.Controls.Add(this.pnlSelectedCount);
            
            // pnlTotalStudents
            this.pnlTotalStudents.BackColor = System.Drawing.Color.White;
            this.pnlTotalStudents.Location = new System.Drawing.Point(10, 10);
            this.pnlTotalStudents.Size = new System.Drawing.Size(110, 50);
            this.pnlTotalStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalStudents.Controls.Add(this.lblTotalStudentsLabel);
            this.pnlTotalStudents.Controls.Add(this.lblTotalStudents);
            
            this.lblTotalStudentsLabel.AutoSize = true;
            this.lblTotalStudentsLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTotalStudentsLabel.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lblTotalStudentsLabel.Location = new System.Drawing.Point(8, 5);
            this.lblTotalStudentsLabel.Text = "Total";
            
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalStudents.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.lblTotalStudents.Location = new System.Drawing.Point(8, 22);
            this.lblTotalStudents.Text = "0";
            
            // pnlPaidCount
            this.pnlPaidCount.BackColor = System.Drawing.Color.White;
            this.pnlPaidCount.Location = new System.Drawing.Point(130, 10);
            this.pnlPaidCount.Size = new System.Drawing.Size(110, 50);
            this.pnlPaidCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPaidCount.Controls.Add(this.lblPaidCountLabel);
            this.pnlPaidCount.Controls.Add(this.lblPaidCount);
            
            this.lblPaidCountLabel.AutoSize = true;
            this.lblPaidCountLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPaidCountLabel.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lblPaidCountLabel.Location = new System.Drawing.Point(8, 5);
            this.lblPaidCountLabel.Text = "Fully Paid";
            
            this.lblPaidCount.AutoSize = true;
            this.lblPaidCount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblPaidCount.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblPaidCount.Location = new System.Drawing.Point(8, 22);
            this.lblPaidCount.Text = "0";
            
            // pnlPartialCount
            this.pnlPartialCount.BackColor = System.Drawing.Color.White;
            this.pnlPartialCount.Location = new System.Drawing.Point(250, 10);
            this.pnlPartialCount.Size = new System.Drawing.Size(110, 50);
            this.pnlPartialCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPartialCount.Controls.Add(this.lblPartialCountLabel);
            this.pnlPartialCount.Controls.Add(this.lblPartialCount);
            
            this.lblPartialCountLabel.AutoSize = true;
            this.lblPartialCountLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPartialCountLabel.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lblPartialCountLabel.Location = new System.Drawing.Point(8, 5);
            this.lblPartialCountLabel.Text = "Partial";
            
            this.lblPartialCount.AutoSize = true;
            this.lblPartialCount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblPartialCount.ForeColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.lblPartialCount.Location = new System.Drawing.Point(8, 22);
            this.lblPartialCount.Text = "0";
            
            // pnlUnpaidCount
            this.pnlUnpaidCount.BackColor = System.Drawing.Color.White;
            this.pnlUnpaidCount.Location = new System.Drawing.Point(370, 10);
            this.pnlUnpaidCount.Size = new System.Drawing.Size(110, 50);
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
            this.lblUnpaidCount.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.lblUnpaidCount.Location = new System.Drawing.Point(8, 22);
            this.lblUnpaidCount.Text = "0";
            
            // pnlSelectedCount
            this.pnlSelectedCount.BackColor = System.Drawing.Color.White;
            this.pnlSelectedCount.Location = new System.Drawing.Point(490, 10);
            this.pnlSelectedCount.Size = new System.Drawing.Size(180, 50);
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
            // AMOUNT SUMMARY PANEL
            // =============================================
            this.pnlAmountSummary.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.pnlAmountSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAmountSummary.Location = new System.Drawing.Point(720, 595);
            this.pnlAmountSummary.Name = "pnlAmountSummary";
            this.pnlAmountSummary.Size = new System.Drawing.Size(330, 70);
            this.pnlAmountSummary.Controls.Add(this.pnlTotalAmountDue);
            this.pnlAmountSummary.Controls.Add(this.pnlSelectedAmount);
            
            // pnlTotalAmountDue
            this.pnlTotalAmountDue.BackColor = System.Drawing.Color.White;
            this.pnlTotalAmountDue.Location = new System.Drawing.Point(10, 10);
            this.pnlTotalAmountDue.Size = new System.Drawing.Size(150, 50);
            this.pnlTotalAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalAmountDue.Controls.Add(this.lblTotalAmountDueLabel);
            this.pnlTotalAmountDue.Controls.Add(this.lblTotalAmountDue);
            
            this.lblTotalAmountDueLabel.AutoSize = true;
            this.lblTotalAmountDueLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTotalAmountDueLabel.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lblTotalAmountDueLabel.Location = new System.Drawing.Point(8, 5);
            this.lblTotalAmountDueLabel.Text = "Total Amount Due";
            
            this.lblTotalAmountDue.AutoSize = true;
            this.lblTotalAmountDue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmountDue.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.lblTotalAmountDue.Location = new System.Drawing.Point(8, 24);
            this.lblTotalAmountDue.Text = "Rs. 0";
            
            // pnlSelectedAmount
            this.pnlSelectedAmount.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.pnlSelectedAmount.Location = new System.Drawing.Point(170, 10);
            this.pnlSelectedAmount.Size = new System.Drawing.Size(150, 50);
            this.pnlSelectedAmount.Controls.Add(this.lblSelectedAmountLabel);
            this.pnlSelectedAmount.Controls.Add(this.lblSelectedAmount);
            
            this.lblSelectedAmountLabel.AutoSize = true;
            this.lblSelectedAmountLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSelectedAmountLabel.ForeColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.lblSelectedAmountLabel.Location = new System.Drawing.Point(8, 5);
            this.lblSelectedAmountLabel.Text = "Selected Amount";
            
            this.lblSelectedAmount.AutoSize = true;
            this.lblSelectedAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSelectedAmount.ForeColor = System.Drawing.Color.White;
            this.lblSelectedAmount.Location = new System.Drawing.Point(8, 24);
            this.lblSelectedAmount.Text = "Rs. 0";
            
            // =============================================
            // SUBMIT BUTTON
            // =============================================
            this.btnSubmitSelected.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnSubmitSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitSelected.FlatAppearance.BorderSize = 0;
            this.btnSubmitSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitSelected.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmitSelected.ForeColor = System.Drawing.Color.White;
            this.btnSubmitSelected.Location = new System.Drawing.Point(1070, 595);
            this.btnSubmitSelected.Name = "btnSubmitSelected";
            this.btnSubmitSelected.Size = new System.Drawing.Size(160, 70);
            this.btnSubmitSelected.Text = "💳 Submit Annual Fee";
            this.btnSubmitSelected.Enabled = false;
            
            // =============================================
            // FORM SETTINGS
            // =============================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1250, 680);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlAmountSummary);
            this.Controls.Add(this.btnSubmitSelected);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SubmitAnnualFeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Submit Annual Fee - School Management System";
            
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        // Header Panel
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        
        // Academic Year Panel
        private System.Windows.Forms.Panel pnlAcademicYear;
        private System.Windows.Forms.Label lblAcademicYear;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblOverdueInfo;
        
        // Filter Panel
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.ComboBox cmbPaymentStatus;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Label lblSearchLabel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblRollNumber;
        private System.Windows.Forms.TextBox txtRollNumber;
        
        // Button Panel
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnLoadStudents;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnDeselectAll;
        private System.Windows.Forms.Button btnViewBreakdown;
        
        // Data Grid
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdmissionNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRollNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnnualFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmountPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmountDue;
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
        private System.Windows.Forms.Panel pnlPartialCount;
        private System.Windows.Forms.Label lblPartialCountLabel;
        private System.Windows.Forms.Label lblPartialCount;
        private System.Windows.Forms.Panel pnlUnpaidCount;
        private System.Windows.Forms.Label lblUnpaidCountLabel;
        private System.Windows.Forms.Label lblUnpaidCount;
        private System.Windows.Forms.Panel pnlSelectedCount;
        private System.Windows.Forms.Label lblSelectedCountLabel;
        private System.Windows.Forms.Label lblSelectedCount;
        
        // Amount Summary Panel
        private System.Windows.Forms.Panel pnlAmountSummary;
        private System.Windows.Forms.Panel pnlTotalAmountDue;
        private System.Windows.Forms.Label lblTotalAmountDueLabel;
        private System.Windows.Forms.Label lblTotalAmountDue;
        private System.Windows.Forms.Panel pnlSelectedAmount;
        private System.Windows.Forms.Label lblSelectedAmountLabel;
        private System.Windows.Forms.Label lblSelectedAmount;
        
        // Submit Button
        private System.Windows.Forms.Button btnSubmitSelected;
    }
}
