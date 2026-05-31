namespace SchoolManagementSystem
{
    partial class ViewPaidStudentsForm
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
            
            // Statistics Panel
            this.pnlStatistics = new System.Windows.Forms.Panel();
            this.pnlTotalPayments = new System.Windows.Forms.Panel();
            this.lblTotalPaymentsLabel = new System.Windows.Forms.Label();
            this.lblTotalPayments = new System.Windows.Forms.Label();
            this.pnlMonthlyPayments = new System.Windows.Forms.Panel();
            this.lblMonthlyPaymentsLabel = new System.Windows.Forms.Label();
            this.lblMonthlyPayments = new System.Windows.Forms.Label();
            this.pnlAnnualPayments = new System.Windows.Forms.Panel();
            this.lblAnnualPaymentsLabel = new System.Windows.Forms.Label();
            this.lblAnnualPayments = new System.Windows.Forms.Label();
            this.pnlTotalCollected = new System.Windows.Forms.Panel();
            this.lblTotalCollectedLabel = new System.Windows.Forms.Label();
            this.lblTotalCollected = new System.Windows.Forms.Label();
            
            // Filter Section
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.lblFeeType = new System.Windows.Forms.Label();
            this.cmbFeeType = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.lblSearchLabel = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblRollNumber = new System.Windows.Forms.Label();
            this.txtRollNumber = new System.Windows.Forms.TextBox();
            
            // Action Buttons
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            
            // Data Grid
            this.dgvPaidStudents = new System.Windows.Forms.DataGridView();
            this.colReceiptNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdmissionNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRollNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeeMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBaseFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLateFine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScholarship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            
            // Summary Panel
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.pnlFilteredCount = new System.Windows.Forms.Panel();
            this.lblFilteredCountLabel = new System.Windows.Forms.Label();
            this.lblFilteredCount = new System.Windows.Forms.Label();
            this.pnlFilteredTotal = new System.Windows.Forms.Panel();
            this.lblFilteredTotalLabel = new System.Windows.Forms.Label();
            this.lblFilteredTotal = new System.Windows.Forms.Label();
            
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaidStudents)).BeginInit();
            this.SuspendLayout();
            
            // =============================================
            // HEADER PANEL
            // =============================================
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1300, 80);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.pnlStatistics);
            
            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 37);
            this.lblTitle.Text = "✅ Paid Fee Records";
            
            // lblSubtitle
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(200, 255, 200);
            this.lblSubtitle.Location = new System.Drawing.Point(24, 52);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(350, 19);
            this.lblSubtitle.Text = "View all students who have paid their monthly or annual fees";
            
            // =============================================
            // STATISTICS PANEL (inside header)
            // =============================================
            this.pnlStatistics.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.pnlStatistics.Location = new System.Drawing.Point(750, 10);
            this.pnlStatistics.Name = "pnlStatistics";
            this.pnlStatistics.Size = new System.Drawing.Size(530, 60);
            this.pnlStatistics.Controls.Add(this.pnlTotalPayments);
            this.pnlStatistics.Controls.Add(this.pnlMonthlyPayments);
            this.pnlStatistics.Controls.Add(this.pnlAnnualPayments);
            this.pnlStatistics.Controls.Add(this.pnlTotalCollected);
            
            // pnlTotalPayments
            this.pnlTotalPayments.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.pnlTotalPayments.Location = new System.Drawing.Point(5, 5);
            this.pnlTotalPayments.Size = new System.Drawing.Size(120, 50);
            this.pnlTotalPayments.Controls.Add(this.lblTotalPaymentsLabel);
            this.pnlTotalPayments.Controls.Add(this.lblTotalPayments);
            
            this.lblTotalPaymentsLabel.AutoSize = true;
            this.lblTotalPaymentsLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTotalPaymentsLabel.ForeColor = System.Drawing.Color.FromArgb(200, 255, 200);
            this.lblTotalPaymentsLabel.Location = new System.Drawing.Point(8, 5);
            this.lblTotalPaymentsLabel.Text = "Total Payments";
            
            this.lblTotalPayments.AutoSize = true;
            this.lblTotalPayments.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalPayments.ForeColor = System.Drawing.Color.White;
            this.lblTotalPayments.Location = new System.Drawing.Point(8, 24);
            this.lblTotalPayments.Text = "0";
            
            // pnlMonthlyPayments
            this.pnlMonthlyPayments.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.pnlMonthlyPayments.Location = new System.Drawing.Point(130, 5);
            this.pnlMonthlyPayments.Size = new System.Drawing.Size(100, 50);
            this.pnlMonthlyPayments.Controls.Add(this.lblMonthlyPaymentsLabel);
            this.pnlMonthlyPayments.Controls.Add(this.lblMonthlyPayments);
            
            this.lblMonthlyPaymentsLabel.AutoSize = true;
            this.lblMonthlyPaymentsLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMonthlyPaymentsLabel.ForeColor = System.Drawing.Color.FromArgb(200, 255, 200);
            this.lblMonthlyPaymentsLabel.Location = new System.Drawing.Point(8, 5);
            this.lblMonthlyPaymentsLabel.Text = "Monthly";
            
            this.lblMonthlyPayments.AutoSize = true;
            this.lblMonthlyPayments.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblMonthlyPayments.ForeColor = System.Drawing.Color.White;
            this.lblMonthlyPayments.Location = new System.Drawing.Point(8, 24);
            this.lblMonthlyPayments.Text = "0";
            
            // pnlAnnualPayments
            this.pnlAnnualPayments.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.pnlAnnualPayments.Location = new System.Drawing.Point(235, 5);
            this.pnlAnnualPayments.Size = new System.Drawing.Size(100, 50);
            this.pnlAnnualPayments.Controls.Add(this.lblAnnualPaymentsLabel);
            this.pnlAnnualPayments.Controls.Add(this.lblAnnualPayments);
            
            this.lblAnnualPaymentsLabel.AutoSize = true;
            this.lblAnnualPaymentsLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAnnualPaymentsLabel.ForeColor = System.Drawing.Color.FromArgb(200, 255, 200);
            this.lblAnnualPaymentsLabel.Location = new System.Drawing.Point(8, 5);
            this.lblAnnualPaymentsLabel.Text = "Annual";
            
            this.lblAnnualPayments.AutoSize = true;
            this.lblAnnualPayments.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAnnualPayments.ForeColor = System.Drawing.Color.White;
            this.lblAnnualPayments.Location = new System.Drawing.Point(8, 24);
            this.lblAnnualPayments.Text = "0";
            
            // pnlTotalCollected
            this.pnlTotalCollected.BackColor = System.Drawing.Color.White;
            this.pnlTotalCollected.Location = new System.Drawing.Point(340, 5);
            this.pnlTotalCollected.Size = new System.Drawing.Size(180, 50);
            this.pnlTotalCollected.Controls.Add(this.lblTotalCollectedLabel);
            this.pnlTotalCollected.Controls.Add(this.lblTotalCollected);
            
            this.lblTotalCollectedLabel.AutoSize = true;
            this.lblTotalCollectedLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTotalCollectedLabel.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lblTotalCollectedLabel.Location = new System.Drawing.Point(8, 5);
            this.lblTotalCollectedLabel.Text = "Total Collected";
            
            this.lblTotalCollected.AutoSize = true;
            this.lblTotalCollected.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalCollected.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblTotalCollected.Location = new System.Drawing.Point(8, 24);
            this.lblTotalCollected.Text = "Rs. 0";
            
            // =============================================
            // FILTER PANEL
            // =============================================
            this.pnlFilters.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.pnlFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilters.Location = new System.Drawing.Point(20, 95);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(1260, 65);
            this.pnlFilters.Controls.Add(this.lblClass);
            this.pnlFilters.Controls.Add(this.cmbClass);
            this.pnlFilters.Controls.Add(this.lblSection);
            this.pnlFilters.Controls.Add(this.cmbSection);
            this.pnlFilters.Controls.Add(this.lblFeeType);
            this.pnlFilters.Controls.Add(this.cmbFeeType);
            this.pnlFilters.Controls.Add(this.lblMonth);
            this.pnlFilters.Controls.Add(this.cmbMonth);
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
            this.cmbClass.Size = new System.Drawing.Size(120, 25);
            
            // lblSection
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblSection.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblSection.Location = new System.Drawing.Point(150, 8);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(52, 15);
            this.lblSection.Text = "Section:";
            
            // cmbSection
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSection.Location = new System.Drawing.Point(150, 26);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(80, 25);
            
            // lblFeeType
            this.lblFeeType.AutoSize = true;
            this.lblFeeType.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblFeeType.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblFeeType.Location = new System.Drawing.Point(245, 8);
            this.lblFeeType.Name = "lblFeeType";
            this.lblFeeType.Size = new System.Drawing.Size(57, 15);
            this.lblFeeType.Text = "Fee Type:";
            
            // cmbFeeType
            this.cmbFeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFeeType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFeeType.Location = new System.Drawing.Point(245, 26);
            this.cmbFeeType.Name = "cmbFeeType";
            this.cmbFeeType.Size = new System.Drawing.Size(100, 25);
            
            // lblMonth
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblMonth.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblMonth.Location = new System.Drawing.Point(360, 8);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(48, 15);
            this.lblMonth.Text = "Month:";
            
            // cmbMonth
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMonth.Location = new System.Drawing.Point(360, 26);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(110, 25);
            
            // lblSort
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblSort.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblSort.Location = new System.Drawing.Point(485, 8);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(51, 15);
            this.lblSort.Text = "Sort By:";
            
            // cmbSort
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSort.Location = new System.Drawing.Point(485, 26);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(160, 25);
            
            // lblSearchLabel
            this.lblSearchLabel.AutoSize = true;
            this.lblSearchLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearchLabel.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblSearchLabel.Location = new System.Drawing.Point(660, 8);
            this.lblSearchLabel.Name = "lblSearchLabel";
            this.lblSearchLabel.Size = new System.Drawing.Size(140, 15);
            this.lblSearchLabel.Text = "Search Name/Receipt#:";
            
            // txtSearch
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(660, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(180, 25);
            this.txtSearch.PlaceholderText = "Search...";
            
            // lblRollNumber
            this.lblRollNumber.AutoSize = true;
            this.lblRollNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblRollNumber.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblRollNumber.Location = new System.Drawing.Point(855, 8);
            this.lblRollNumber.Name = "lblRollNumber";
            this.lblRollNumber.Size = new System.Drawing.Size(48, 15);
            this.lblRollNumber.Text = "Roll No:";
            
            // txtRollNumber
            this.txtRollNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRollNumber.Location = new System.Drawing.Point(855, 26);
            this.txtRollNumber.Name = "txtRollNumber";
            this.txtRollNumber.Size = new System.Drawing.Size(70, 25);
            this.txtRollNumber.PlaceholderText = "Roll #";
            
            // =============================================
            // BUTTON PANEL
            // =============================================
            this.pnlButtons.Location = new System.Drawing.Point(20, 170);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1260, 45);
            this.pnlButtons.Controls.Add(this.btnRefresh);
            this.pnlButtons.Controls.Add(this.btnExport);
            this.pnlButtons.Controls.Add(this.btnPrintReceipt);
            
            // btnRefresh
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(0, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 38);
            this.btnRefresh.Text = "🔄 Refresh";
            
            // btnExport
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(135, 5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(130, 38);
            this.btnExport.Text = "📊 Export Data";
            
            // btnPrintReceipt
            this.btnPrintReceipt.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnPrintReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintReceipt.FlatAppearance.BorderSize = 0;
            this.btnPrintReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReceipt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrintReceipt.ForeColor = System.Drawing.Color.White;
            this.btnPrintReceipt.Location = new System.Drawing.Point(280, 5);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(140, 38);
            this.btnPrintReceipt.Text = "🖨️ Print Receipt";
            this.btnPrintReceipt.Enabled = false;
            
            // =============================================
            // DATA GRID VIEW
            // =============================================
            this.dgvPaidStudents.AllowUserToAddRows = false;
            this.dgvPaidStudents.AllowUserToDeleteRows = false;
            this.dgvPaidStudents.AllowUserToResizeRows = false;
            this.dgvPaidStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaidStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgvPaidStudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPaidStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPaidStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPaidStudents.ColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
            {
                BackColor = System.Drawing.Color.FromArgb(39, 174, 96),
                ForeColor = System.Drawing.Color.White,
                Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold),
                SelectionBackColor = System.Drawing.Color.FromArgb(39, 174, 96),
                SelectionForeColor = System.Drawing.Color.White,
                Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter,
                Padding = new System.Windows.Forms.Padding(5)
            };
            this.dgvPaidStudents.ColumnHeadersHeight = 42;
            this.dgvPaidStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPaidStudents.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
            {
                BackColor = System.Drawing.Color.White,
                ForeColor = System.Drawing.Color.FromArgb(44, 62, 80),
                Font = new System.Drawing.Font("Segoe UI", 9F),
                SelectionBackColor = System.Drawing.Color.FromArgb(46, 204, 113),
                SelectionForeColor = System.Drawing.Color.White,
                Padding = new System.Windows.Forms.Padding(3)
            };
            this.dgvPaidStudents.EnableHeadersVisualStyles = false;
            this.dgvPaidStudents.GridColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.dgvPaidStudents.Location = new System.Drawing.Point(20, 225);
            this.dgvPaidStudents.Name = "dgvPaidStudents";
            this.dgvPaidStudents.ReadOnly = true;
            this.dgvPaidStudents.RowHeadersVisible = false;
            this.dgvPaidStudents.RowHeadersWidth = 51;
            this.dgvPaidStudents.RowTemplate.Height = 36;
            this.dgvPaidStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaidStudents.Size = new System.Drawing.Size(1260, 380);
            this.dgvPaidStudents.TabIndex = 1;
            this.dgvPaidStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colReceiptNo,
                this.colAdmissionNo,
                this.colStudentName,
                this.colClassName,
                this.colSection,
                this.colRollNo,
                this.colFeeType,
                this.colFeeMonth,
                this.colBaseFee,
                this.colLateFine,
                this.colTotalPaid,
                this.colPaymentDate,
                this.colScholarship,
                this.colPaymentMethod
            });
            
            // colReceiptNo
            this.colReceiptNo.HeaderText = "Receipt #";
            this.colReceiptNo.Name = "colReceiptNo";
            this.colReceiptNo.FillWeight = 70;
            
            // colAdmissionNo
            this.colAdmissionNo.HeaderText = "Adm #";
            this.colAdmissionNo.Name = "colAdmissionNo";
            this.colAdmissionNo.FillWeight = 80;
            
            // colStudentName
            this.colStudentName.HeaderText = "Student Name";
            this.colStudentName.Name = "colStudentName";
            this.colStudentName.FillWeight = 110;
            
            // colClassName
            this.colClassName.HeaderText = "Class";
            this.colClassName.Name = "colClassName";
            this.colClassName.FillWeight = 55;
            
            // colSection
            this.colSection.HeaderText = "Sec";
            this.colSection.Name = "colSection";
            this.colSection.FillWeight = 35;
            
            // colRollNo
            this.colRollNo.HeaderText = "Roll";
            this.colRollNo.Name = "colRollNo";
            this.colRollNo.FillWeight = 35;
            
            // colFeeType
            this.colFeeType.HeaderText = "Type";
            this.colFeeType.Name = "colFeeType";
            this.colFeeType.FillWeight = 55;
            
            // colFeeMonth
            this.colFeeMonth.HeaderText = "Period";
            this.colFeeMonth.Name = "colFeeMonth";
            this.colFeeMonth.FillWeight = 70;
            
            // colBaseFee
            this.colBaseFee.HeaderText = "Base Fee";
            this.colBaseFee.Name = "colBaseFee";
            this.colBaseFee.FillWeight = 65;
            
            // colLateFine
            this.colLateFine.HeaderText = "Late Fine";
            this.colLateFine.Name = "colLateFine";
            this.colLateFine.FillWeight = 55;
            
            // colTotalPaid
            this.colTotalPaid.HeaderText = "Total Paid";
            this.colTotalPaid.Name = "colTotalPaid";
            this.colTotalPaid.FillWeight = 70;
            
            // colPaymentDate
            this.colPaymentDate.HeaderText = "Date";
            this.colPaymentDate.Name = "colPaymentDate";
            this.colPaymentDate.FillWeight = 75;
            
            // colScholarship
            this.colScholarship.HeaderText = "Discount";
            this.colScholarship.Name = "colScholarship";
            this.colScholarship.FillWeight = 50;
            
            // colPaymentMethod
            this.colPaymentMethod.HeaderText = "Method";
            this.colPaymentMethod.Name = "colPaymentMethod";
            this.colPaymentMethod.FillWeight = 70;
            
            // =============================================
            // SUMMARY PANEL
            // =============================================
            this.pnlSummary.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummary.Location = new System.Drawing.Point(20, 615);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(1260, 60);
            this.pnlSummary.Controls.Add(this.pnlFilteredCount);
            this.pnlSummary.Controls.Add(this.pnlFilteredTotal);
            
            // pnlFilteredCount
            this.pnlFilteredCount.BackColor = System.Drawing.Color.White;
            this.pnlFilteredCount.Location = new System.Drawing.Point(15, 8);
            this.pnlFilteredCount.Size = new System.Drawing.Size(180, 44);
            this.pnlFilteredCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilteredCount.Controls.Add(this.lblFilteredCountLabel);
            this.pnlFilteredCount.Controls.Add(this.lblFilteredCount);
            
            this.lblFilteredCountLabel.AutoSize = true;
            this.lblFilteredCountLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilteredCountLabel.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lblFilteredCountLabel.Location = new System.Drawing.Point(10, 5);
            this.lblFilteredCountLabel.Text = "Filtered Records";
            
            this.lblFilteredCount.AutoSize = true;
            this.lblFilteredCount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblFilteredCount.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.lblFilteredCount.Location = new System.Drawing.Point(10, 22);
            this.lblFilteredCount.Text = "0";
            
            // pnlFilteredTotal
            this.pnlFilteredTotal.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.pnlFilteredTotal.Location = new System.Drawing.Point(210, 8);
            this.pnlFilteredTotal.Size = new System.Drawing.Size(220, 44);
            this.pnlFilteredTotal.Controls.Add(this.lblFilteredTotalLabel);
            this.pnlFilteredTotal.Controls.Add(this.lblFilteredTotal);
            
            this.lblFilteredTotalLabel.AutoSize = true;
            this.lblFilteredTotalLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilteredTotalLabel.ForeColor = System.Drawing.Color.FromArgb(200, 255, 200);
            this.lblFilteredTotalLabel.Location = new System.Drawing.Point(10, 5);
            this.lblFilteredTotalLabel.Text = "Filtered Total Amount";
            
            this.lblFilteredTotal.AutoSize = true;
            this.lblFilteredTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblFilteredTotal.ForeColor = System.Drawing.Color.White;
            this.lblFilteredTotal.Location = new System.Drawing.Point(10, 22);
            this.lblFilteredTotal.Text = "Rs. 0";
            
            // =============================================
            // FORM SETTINGS
            // =============================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 690);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.dgvPaidStudents);
            this.Controls.Add(this.pnlSummary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ViewPaidStudentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paid Fee Records - School Management System";
            
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaidStudents)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        // Header Panel
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        
        // Statistics Panel
        private System.Windows.Forms.Panel pnlStatistics;
        private System.Windows.Forms.Panel pnlTotalPayments;
        private System.Windows.Forms.Label lblTotalPaymentsLabel;
        private System.Windows.Forms.Label lblTotalPayments;
        private System.Windows.Forms.Panel pnlMonthlyPayments;
        private System.Windows.Forms.Label lblMonthlyPaymentsLabel;
        private System.Windows.Forms.Label lblMonthlyPayments;
        private System.Windows.Forms.Panel pnlAnnualPayments;
        private System.Windows.Forms.Label lblAnnualPaymentsLabel;
        private System.Windows.Forms.Label lblAnnualPayments;
        private System.Windows.Forms.Panel pnlTotalCollected;
        private System.Windows.Forms.Label lblTotalCollectedLabel;
        private System.Windows.Forms.Label lblTotalCollected;
        
        // Filter Panel
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Label lblFeeType;
        private System.Windows.Forms.ComboBox cmbFeeType;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Label lblSearchLabel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblRollNumber;
        private System.Windows.Forms.TextBox txtRollNumber;
        
        // Button Panel
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrintReceipt;
        
        // Data Grid
        private System.Windows.Forms.DataGridView dgvPaidStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceiptNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdmissionNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRollNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeeMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBaseFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLateFine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScholarship;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentMethod;
        
        // Summary Panel
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Panel pnlFilteredCount;
        private System.Windows.Forms.Label lblFilteredCountLabel;
        private System.Windows.Forms.Label lblFilteredCount;
        private System.Windows.Forms.Panel pnlFilteredTotal;
        private System.Windows.Forms.Label lblFilteredTotalLabel;
        private System.Windows.Forms.Label lblFilteredTotal;
    }
}
