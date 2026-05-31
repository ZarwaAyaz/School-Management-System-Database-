namespace SchoolManagementSystem
{
    partial class ViewUnpaidStudentsForm
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
            
            // Panels
            this.pnlHeader = new Panel();
            this.pnlFilters = new Panel();
            this.pnlGrid = new Panel();
            this.pnlStatistics = new Panel();
            
            // Header Controls
            this.lblTitle = new Label();
            this.lblSubtitle = new Label();
            this.btnBack = new Button();
            
            // Filter Controls
            this.lblClass = new Label();
            this.cmbClass = new ComboBox();
            this.lblSection = new Label();
            this.cmbSection = new ComboBox();
            this.lblFeeType = new Label();
            this.cmbFeeType = new ComboBox();
            this.lblSearch = new Label();
            this.txtSearch = new TextBox();
            this.btnSearch = new Button();
            this.btnClear = new Button();
            
            // DataGridView
            this.dgvUnpaid = new DataGridView();
            
            // Statistics Labels
            this.lblTotalUnpaidLabel = new Label();
            this.lblTotalUnpaid = new Label();
            this.lblMonthlyLabel = new Label();
            this.lblMonthlyCount = new Label();
            this.lblAnnualLabel = new Label();
            this.lblAnnualCount = new Label();
            this.lblTotalAmountLabel = new Label();
            this.lblTotalAmount = new Label();
            
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnpaid)).BeginInit();
            this.SuspendLayout();
            
            // ==================== HEADER PANEL ====================
            this.pnlHeader.BackColor = Color.FromArgb(192, 57, 43);
            this.pnlHeader.Dock = DockStyle.Top;
            this.pnlHeader.Height = 80;
            
            // Title Label
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Location = new Point(25, 15);
            this.lblTitle.Text = "📋 Unpaid Students";
            
            // Subtitle
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = Color.FromArgb(255, 200, 200);
            this.lblSubtitle.Location = new Point(28, 52);
            this.lblSubtitle.Text = "Current month fee and annual charges due";
            
            // Back Button
            this.btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnBack.BackColor = Color.FromArgb(231, 76, 60);
            this.btnBack.FlatStyle = FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnBack.ForeColor = Color.White;
            this.btnBack.Size = new Size(180, 45);
            this.btnBack.Location = new Point(this.ClientSize.Width - 205, 18);
            this.btnBack.Text = "← Back to Dashboard";
            this.btnBack.Cursor = Cursors.Hand;
            this.btnBack.Click += new EventHandler(this.btnBack_Click);
            
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.btnBack);
            
            // ==================== FILTERS PANEL ====================
            this.pnlFilters.BackColor = Color.White;
            this.pnlFilters.Dock = DockStyle.Top;
            this.pnlFilters.Height = 70;
            this.pnlFilters.Padding = new Padding(20, 15, 20, 15);
            
            int filterY = 20;
            int spacing = 180;
            
            // Class
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblClass.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblClass.Location = new Point(25, filterY + 3);
            this.lblClass.Text = "Class:";
            
            this.cmbClass.Font = new Font("Segoe UI", 10F);
            this.cmbClass.Location = new Point(80, filterY);
            this.cmbClass.Size = new Size(130, 28);
            this.cmbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            
            // Section
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblSection.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblSection.Location = new Point(25 + spacing + 40, filterY + 3);
            this.lblSection.Text = "Section:";
            
            this.cmbSection.Font = new Font("Segoe UI", 10F);
            this.cmbSection.Location = new Point(105 + spacing + 40, filterY);
            this.cmbSection.Size = new Size(90, 28);
            this.cmbSection.DropDownStyle = ComboBoxStyle.DropDownList;
            
            // Fee Type
            this.lblFeeType.AutoSize = true;
            this.lblFeeType.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblFeeType.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblFeeType.Location = new Point(25 + spacing * 2 + 50, filterY + 3);
            this.lblFeeType.Text = "Fee Type:";
            
            this.cmbFeeType.Font = new Font("Segoe UI", 10F);
            this.cmbFeeType.Location = new Point(115 + spacing * 2 + 50, filterY);
            this.cmbFeeType.Size = new Size(130, 28);
            this.cmbFeeType.DropDownStyle = ComboBoxStyle.DropDownList;
            
            // Search
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblSearch.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblSearch.Location = new Point(25 + spacing * 3 + 80, filterY + 3);
            this.lblSearch.Text = "Search:";
            
            this.txtSearch.Font = new Font("Segoe UI", 10F);
            this.txtSearch.Location = new Point(95 + spacing * 3 + 80, filterY);
            this.txtSearch.Size = new Size(180, 28);
            this.txtSearch.PlaceholderText = "Name or Admission No";
            
            // Search Button
            this.btnSearch.BackColor = Color.FromArgb(192, 57, 43);
            this.btnSearch.FlatStyle = FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnSearch.ForeColor = Color.White;
            this.btnSearch.Location = new Point(290 + spacing * 3 + 80, filterY - 2);
            this.btnSearch.Size = new Size(100, 32);
            this.btnSearch.Text = "🔍 Search";
            this.btnSearch.Cursor = Cursors.Hand;
            this.btnSearch.Click += new EventHandler(this.btnSearch_Click);
            
            // Clear Button
            this.btnClear.BackColor = Color.FromArgb(149, 165, 166);
            this.btnClear.FlatStyle = FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnClear.ForeColor = Color.White;
            this.btnClear.Location = new Point(400 + spacing * 3 + 80, filterY - 2);
            this.btnClear.Size = new Size(90, 32);
            this.btnClear.Text = "✖ Clear";
            this.btnClear.Cursor = Cursors.Hand;
            this.btnClear.Click += new EventHandler(this.btnClear_Click);
            
            this.pnlFilters.Controls.Add(this.lblClass);
            this.pnlFilters.Controls.Add(this.cmbClass);
            this.pnlFilters.Controls.Add(this.lblSection);
            this.pnlFilters.Controls.Add(this.cmbSection);
            this.pnlFilters.Controls.Add(this.lblFeeType);
            this.pnlFilters.Controls.Add(this.cmbFeeType);
            this.pnlFilters.Controls.Add(this.lblSearch);
            this.pnlFilters.Controls.Add(this.txtSearch);
            this.pnlFilters.Controls.Add(this.btnSearch);
            this.pnlFilters.Controls.Add(this.btnClear);
            
            // ==================== STATISTICS PANEL ====================
            this.pnlStatistics.BackColor = Color.FromArgb(44, 62, 80);
            this.pnlStatistics.Dock = DockStyle.Bottom;
            this.pnlStatistics.Height = 80;
            
            int statY = 15;
            int statSpacing = 250;
            
            // Total Unpaid
            this.lblTotalUnpaidLabel.AutoSize = true;
            this.lblTotalUnpaidLabel.Font = new Font("Segoe UI", 10F);
            this.lblTotalUnpaidLabel.ForeColor = Color.FromArgb(189, 195, 199);
            this.lblTotalUnpaidLabel.Location = new Point(40, statY);
            this.lblTotalUnpaidLabel.Text = "Total Unpaid:";
            
            this.lblTotalUnpaid.AutoSize = true;
            this.lblTotalUnpaid.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTotalUnpaid.ForeColor = Color.FromArgb(231, 76, 60);
            this.lblTotalUnpaid.Location = new Point(40, statY + 22);
            this.lblTotalUnpaid.Text = "0";
            
            // Monthly Count
            this.lblMonthlyLabel.AutoSize = true;
            this.lblMonthlyLabel.Font = new Font("Segoe UI", 10F);
            this.lblMonthlyLabel.ForeColor = Color.FromArgb(189, 195, 199);
            this.lblMonthlyLabel.Location = new Point(40 + statSpacing, statY);
            this.lblMonthlyLabel.Text = "Monthly Fee Due:";
            
            this.lblMonthlyCount.AutoSize = true;
            this.lblMonthlyCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblMonthlyCount.ForeColor = Color.FromArgb(52, 152, 219);
            this.lblMonthlyCount.Location = new Point(40 + statSpacing, statY + 22);
            this.lblMonthlyCount.Text = "0";
            
            // Annual Count
            this.lblAnnualLabel.AutoSize = true;
            this.lblAnnualLabel.Font = new Font("Segoe UI", 10F);
            this.lblAnnualLabel.ForeColor = Color.FromArgb(189, 195, 199);
            this.lblAnnualLabel.Location = new Point(40 + statSpacing * 2, statY);
            this.lblAnnualLabel.Text = "Annual Charges Due:";
            
            this.lblAnnualCount.AutoSize = true;
            this.lblAnnualCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblAnnualCount.ForeColor = Color.FromArgb(230, 126, 34);
            this.lblAnnualCount.Location = new Point(40 + statSpacing * 2, statY + 22);
            this.lblAnnualCount.Text = "0";
            
            // Total Amount
            this.lblTotalAmountLabel.AutoSize = true;
            this.lblTotalAmountLabel.Font = new Font("Segoe UI", 10F);
            this.lblTotalAmountLabel.ForeColor = Color.FromArgb(189, 195, 199);
            this.lblTotalAmountLabel.Location = new Point(40 + statSpacing * 3, statY);
            this.lblTotalAmountLabel.Text = "Total Amount Due:";
            
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTotalAmount.ForeColor = Color.FromArgb(46, 204, 113);
            this.lblTotalAmount.Location = new Point(40 + statSpacing * 3, statY + 22);
            this.lblTotalAmount.Text = "Rs. 0";
            
            this.pnlStatistics.Controls.Add(this.lblTotalUnpaidLabel);
            this.pnlStatistics.Controls.Add(this.lblTotalUnpaid);
            this.pnlStatistics.Controls.Add(this.lblMonthlyLabel);
            this.pnlStatistics.Controls.Add(this.lblMonthlyCount);
            this.pnlStatistics.Controls.Add(this.lblAnnualLabel);
            this.pnlStatistics.Controls.Add(this.lblAnnualCount);
            this.pnlStatistics.Controls.Add(this.lblTotalAmountLabel);
            this.pnlStatistics.Controls.Add(this.lblTotalAmount);
            
            // ==================== DATA GRID PANEL ====================
            this.pnlGrid.Dock = DockStyle.Fill;
            this.pnlGrid.Padding = new Padding(20, 10, 20, 10);
            this.pnlGrid.BackColor = Color.FromArgb(236, 240, 241);
            
            // DataGridView
            this.dgvUnpaid.Dock = DockStyle.Fill;
            this.dgvUnpaid.BackgroundColor = Color.White;
            this.dgvUnpaid.BorderStyle = BorderStyle.None;
            this.dgvUnpaid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUnpaid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgvUnpaid.ColumnHeadersHeight = 45;
            this.dgvUnpaid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUnpaid.EnableHeadersVisualStyles = false;
            this.dgvUnpaid.GridColor = Color.FromArgb(230, 230, 230);
            this.dgvUnpaid.RowHeadersVisible = false;
            this.dgvUnpaid.RowTemplate.Height = 40;
            this.dgvUnpaid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnpaid.MultiSelect = false;
            this.dgvUnpaid.AllowUserToAddRows = false;
            this.dgvUnpaid.AllowUserToDeleteRows = false;
            this.dgvUnpaid.ReadOnly = true;
            this.dgvUnpaid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            // Column Header Style
            this.dgvUnpaid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(192, 57, 43);
            this.dgvUnpaid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvUnpaid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.dgvUnpaid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            // Default Cell Style
            this.dgvUnpaid.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            this.dgvUnpaid.DefaultCellStyle.Padding = new Padding(5);
            this.dgvUnpaid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(192, 57, 43);
            this.dgvUnpaid.DefaultCellStyle.SelectionForeColor = Color.White;
            
            // Add Columns - Simplified
            this.dgvUnpaid.Columns.Add("AdmissionNo", "Admission No");
            this.dgvUnpaid.Columns.Add("StudentName", "Student Name");
            this.dgvUnpaid.Columns.Add("Class", "Class");
            this.dgvUnpaid.Columns.Add("Section", "Section");
            this.dgvUnpaid.Columns.Add("RollNo", "Roll No");
            this.dgvUnpaid.Columns.Add("FeeType", "Fee Type");
            this.dgvUnpaid.Columns.Add("Period", "Period");
            this.dgvUnpaid.Columns.Add("AmountDue", "Amount Due");
            
            // Set column widths
            this.dgvUnpaid.Columns["AdmissionNo"].FillWeight = 100;
            this.dgvUnpaid.Columns["StudentName"].FillWeight = 150;
            this.dgvUnpaid.Columns["Class"].FillWeight = 80;
            this.dgvUnpaid.Columns["Section"].FillWeight = 70;
            this.dgvUnpaid.Columns["RollNo"].FillWeight = 70;
            this.dgvUnpaid.Columns["FeeType"].FillWeight = 110;
            this.dgvUnpaid.Columns["Period"].FillWeight = 120;
            this.dgvUnpaid.Columns["AmountDue"].FillWeight = 100;
            
            // Center align columns
            this.dgvUnpaid.Columns["Class"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvUnpaid.Columns["Section"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvUnpaid.Columns["RollNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvUnpaid.Columns["AmountDue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            
            this.pnlGrid.Controls.Add(this.dgvUnpaid);
            
            // ==================== FORM SETUP ====================
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1400, 800);
            
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlStatistics);
            
            this.Name = "ViewUnpaidStudentsForm";
            this.Text = "View Unpaid Students - Fee Management";
            
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnpaid)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        // Panels
        private Panel pnlHeader;
        private Panel pnlFilters;
        private Panel pnlGrid;
        private Panel pnlStatistics;
        
        // Header Controls
        private Label lblTitle;
        private Label lblSubtitle;
        private Button btnBack;
        
        // Filter Controls
        private Label lblClass;
        private ComboBox cmbClass;
        private Label lblSection;
        private ComboBox cmbSection;
        private Label lblFeeType;
        private ComboBox cmbFeeType;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnClear;
        
        // DataGridView
        private DataGridView dgvUnpaid;
        
        // Statistics
        private Label lblTotalUnpaidLabel;
        private Label lblTotalUnpaid;
        private Label lblMonthlyLabel;
        private Label lblMonthlyCount;
        private Label lblAnnualLabel;
        private Label lblAnnualCount;
        private Label lblTotalAmountLabel;
        private Label lblTotalAmount;
    }
}
