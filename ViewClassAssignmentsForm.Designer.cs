namespace SchoolManagementSystem
{
    partial class ViewClassAssignmentsForm
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
            // Main containers
            panelMain = new Panel();
            panelHeader = new Panel();
            panelStats = new Panel();
            panelFilters = new Panel();

            // Header controls
            lblTitle = new Label();
            lblSubtitle = new Label();

            // Statistics cards
            panelStatCard1 = new Panel();
            lblStatIcon1 = new Label();
            lblStatLabel1 = new Label();
            lblTotalClasses = new Label();

            panelStatCard2 = new Panel();
            lblStatIcon2 = new Label();
            lblStatLabel2 = new Label();
            lblTotalTeachers = new Label();

            panelStatCard3 = new Panel();
            lblStatIcon3 = new Label();
            lblStatLabel3 = new Label();
            lblTotalStudents = new Label();

            panelStatCard4 = new Panel();
            lblStatIcon4 = new Label();
            lblStatLabel4 = new Label();
            lblAvgStudents = new Label();

            // Filter controls
            lblSearchIcon = new Label();
            txtSearch = new TextBox();
            lblClassFilter = new Label();
            cmbClassFilter = new ComboBox();
            lblSectionFilter = new Label();
            cmbSectionFilter = new ComboBox();
            lblSortBy = new Label();
            cmbSortBy = new ComboBox();
            btnClearFilter = new Button();
            btnRefresh = new Button();
            btnExport = new Button();

            // DataGridView
            dgvAssignments = new DataGridView();
            colEmployeeId = new DataGridViewTextBoxColumn();
            colTeacherName = new DataGridViewTextBoxColumn();
            colClassName = new DataGridViewTextBoxColumn();
            colSection = new DataGridViewTextBoxColumn();
            colClassSection = new DataGridViewTextBoxColumn();
            colStudents = new DataGridViewTextBoxColumn();
            colSpecialization = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();

            // Footer
            lblResultsCount = new Label();
            lblHint = new Label();

            // Suspend layouts
            panelMain.SuspendLayout();
            panelHeader.SuspendLayout();
            panelStats.SuspendLayout();
            panelFilters.SuspendLayout();
            panelStatCard1.SuspendLayout();
            panelStatCard2.SuspendLayout();
            panelStatCard3.SuspendLayout();
            panelStatCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssignments).BeginInit();
            this.SuspendLayout();

            // ========================================
            // Form Settings
            // ========================================
            this.ClientSize = new Size(1100, 720);
            this.Text = "View Class Assignments";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.FromArgb(236, 240, 241);

            // ========================================
            // Main Panel
            // ========================================
            panelMain.Dock = DockStyle.Fill;
            panelMain.BackColor = Color.FromArgb(236, 240, 241);

            // ========================================
            // Header Panel
            // ========================================
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Height = 90;
            panelHeader.BackColor = Color.FromArgb(41, 128, 185);
            panelHeader.Padding = new Padding(25, 15, 25, 15);

            lblTitle.Text = "📋 View Class Assignments";
            lblTitle.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(25, 15);
            lblTitle.AutoSize = true;

            lblSubtitle.Text = "Overview of teachers assigned to each class/grade";
            lblSubtitle.Font = new Font("Segoe UI", 10);
            lblSubtitle.ForeColor = Color.FromArgb(214, 234, 248);
            lblSubtitle.Location = new Point(27, 55);
            lblSubtitle.AutoSize = true;

            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblSubtitle);

            // ========================================
            // Statistics Panel
            // ========================================
            panelStats.Location = new Point(25, 105);
            panelStats.Size = new Size(1050, 80);
            panelStats.BackColor = Color.Transparent;

            // Stat Card 1 - Total Classes
            panelStatCard1.Size = new Size(240, 70);
            panelStatCard1.Location = new Point(0, 0);
            panelStatCard1.BackColor = Color.White;

            lblStatIcon1.Text = "🏫";
            lblStatIcon1.Font = new Font("Segoe UI", 24);
            lblStatIcon1.Location = new Point(15, 12);
            lblStatIcon1.AutoSize = true;

            lblStatLabel1.Text = "Total Classes";
            lblStatLabel1.Font = new Font("Segoe UI", 9);
            lblStatLabel1.ForeColor = Color.FromArgb(127, 140, 141);
            lblStatLabel1.Location = new Point(70, 12);
            lblStatLabel1.AutoSize = true;

            lblTotalClasses.Text = "24";
            lblTotalClasses.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblTotalClasses.ForeColor = Color.FromArgb(41, 128, 185);
            lblTotalClasses.Location = new Point(70, 32);
            lblTotalClasses.AutoSize = true;

            panelStatCard1.Controls.Add(lblStatIcon1);
            panelStatCard1.Controls.Add(lblStatLabel1);
            panelStatCard1.Controls.Add(lblTotalClasses);

            // Stat Card 2 - Total Teachers
            panelStatCard2.Size = new Size(240, 70);
            panelStatCard2.Location = new Point(260, 0);
            panelStatCard2.BackColor = Color.White;

            lblStatIcon2.Text = "👨‍🏫";
            lblStatIcon2.Font = new Font("Segoe UI", 24);
            lblStatIcon2.Location = new Point(15, 12);
            lblStatIcon2.AutoSize = true;

            lblStatLabel2.Text = "Teachers Assigned";
            lblStatLabel2.Font = new Font("Segoe UI", 9);
            lblStatLabel2.ForeColor = Color.FromArgb(127, 140, 141);
            lblStatLabel2.Location = new Point(70, 12);
            lblStatLabel2.AutoSize = true;

            lblTotalTeachers.Text = "24";
            lblTotalTeachers.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblTotalTeachers.ForeColor = Color.FromArgb(39, 174, 96);
            lblTotalTeachers.Location = new Point(70, 32);
            lblTotalTeachers.AutoSize = true;

            panelStatCard2.Controls.Add(lblStatIcon2);
            panelStatCard2.Controls.Add(lblStatLabel2);
            panelStatCard2.Controls.Add(lblTotalTeachers);

            // Stat Card 3 - Total Students
            panelStatCard3.Size = new Size(240, 70);
            panelStatCard3.Location = new Point(520, 0);
            panelStatCard3.BackColor = Color.White;

            lblStatIcon3.Text = "👨‍🎓";
            lblStatIcon3.Font = new Font("Segoe UI", 24);
            lblStatIcon3.Location = new Point(15, 12);
            lblStatIcon3.AutoSize = true;

            lblStatLabel3.Text = "Total Students";
            lblStatLabel3.Font = new Font("Segoe UI", 9);
            lblStatLabel3.ForeColor = Color.FromArgb(127, 140, 141);
            lblStatLabel3.Location = new Point(70, 12);
            lblStatLabel3.AutoSize = true;

            lblTotalStudents.Text = "0";
            lblTotalStudents.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblTotalStudents.ForeColor = Color.FromArgb(155, 89, 182);
            lblTotalStudents.Location = new Point(70, 32);
            lblTotalStudents.AutoSize = true;

            panelStatCard3.Controls.Add(lblStatIcon3);
            panelStatCard3.Controls.Add(lblStatLabel3);
            panelStatCard3.Controls.Add(lblTotalStudents);

            // Stat Card 4 - Average Students
            panelStatCard4.Size = new Size(250, 70);
            panelStatCard4.Location = new Point(780, 0);
            panelStatCard4.BackColor = Color.White;

            lblStatIcon4.Text = "📊";
            lblStatIcon4.Font = new Font("Segoe UI", 24);
            lblStatIcon4.Location = new Point(15, 12);
            lblStatIcon4.AutoSize = true;

            lblStatLabel4.Text = "Avg Students/Class";
            lblStatLabel4.Font = new Font("Segoe UI", 9);
            lblStatLabel4.ForeColor = Color.FromArgb(127, 140, 141);
            lblStatLabel4.Location = new Point(70, 12);
            lblStatLabel4.AutoSize = true;

            lblAvgStudents.Text = "0";
            lblAvgStudents.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblAvgStudents.ForeColor = Color.FromArgb(230, 126, 34);
            lblAvgStudents.Location = new Point(70, 32);
            lblAvgStudents.AutoSize = true;

            panelStatCard4.Controls.Add(lblStatIcon4);
            panelStatCard4.Controls.Add(lblStatLabel4);
            panelStatCard4.Controls.Add(lblAvgStudents);

            panelStats.Controls.Add(panelStatCard1);
            panelStats.Controls.Add(panelStatCard2);
            panelStats.Controls.Add(panelStatCard3);
            panelStats.Controls.Add(panelStatCard4);

            // ========================================
            // Filters Panel
            // ========================================
            panelFilters.Location = new Point(25, 195);
            panelFilters.Size = new Size(1050, 55);
            panelFilters.BackColor = Color.White;

            lblSearchIcon.Text = "🔍";
            lblSearchIcon.Font = new Font("Segoe UI", 12);
            lblSearchIcon.Location = new Point(12, 14);
            lblSearchIcon.AutoSize = true;

            txtSearch.Size = new Size(180, 28);
            txtSearch.Location = new Point(40, 12);
            txtSearch.Font = new Font("Segoe UI", 10);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.PlaceholderText = "Search teacher...";

            lblClassFilter.Text = "Class:";
            lblClassFilter.Font = new Font("Segoe UI", 9);
            lblClassFilter.ForeColor = Color.FromArgb(52, 73, 94);
            lblClassFilter.Location = new Point(235, 16);
            lblClassFilter.AutoSize = true;

            cmbClassFilter.Size = new Size(120, 28);
            cmbClassFilter.Location = new Point(275, 12);
            cmbClassFilter.Font = new Font("Segoe UI", 9);
            cmbClassFilter.DropDownStyle = ComboBoxStyle.DropDownList;

            lblSectionFilter.Text = "Section:";
            lblSectionFilter.Font = new Font("Segoe UI", 9);
            lblSectionFilter.ForeColor = Color.FromArgb(52, 73, 94);
            lblSectionFilter.Location = new Point(410, 16);
            lblSectionFilter.AutoSize = true;

            cmbSectionFilter.Size = new Size(80, 28);
            cmbSectionFilter.Location = new Point(465, 12);
            cmbSectionFilter.Font = new Font("Segoe UI", 9);
            cmbSectionFilter.DropDownStyle = ComboBoxStyle.DropDownList;

            lblSortBy.Text = "Sort:";
            lblSortBy.Font = new Font("Segoe UI", 9);
            lblSortBy.ForeColor = Color.FromArgb(52, 73, 94);
            lblSortBy.Location = new Point(560, 16);
            lblSortBy.AutoSize = true;

            cmbSortBy.Size = new Size(170, 28);
            cmbSortBy.Location = new Point(595, 12);
            cmbSortBy.Font = new Font("Segoe UI", 9);
            cmbSortBy.DropDownStyle = ComboBoxStyle.DropDownList;

            btnClearFilter.Text = "Clear";
            btnClearFilter.Size = new Size(70, 32);
            btnClearFilter.Location = new Point(780, 11);
            btnClearFilter.BackColor = Color.FromArgb(149, 165, 166);
            btnClearFilter.ForeColor = Color.White;
            btnClearFilter.FlatStyle = FlatStyle.Flat;
            btnClearFilter.FlatAppearance.BorderSize = 0;
            btnClearFilter.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnClearFilter.Cursor = Cursors.Hand;

            btnRefresh.Text = "🔄 Refresh";
            btnRefresh.Size = new Size(90, 32);
            btnRefresh.Location = new Point(860, 11);
            btnRefresh.BackColor = Color.FromArgb(41, 128, 185);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnRefresh.Cursor = Cursors.Hand;

            btnExport.Text = "📥 Export";
            btnExport.Size = new Size(90, 32);
            btnExport.Location = new Point(958, 11);
            btnExport.BackColor = Color.FromArgb(39, 174, 96);
            btnExport.ForeColor = Color.White;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnExport.Cursor = Cursors.Hand;

            panelFilters.Controls.Add(lblSearchIcon);
            panelFilters.Controls.Add(txtSearch);
            panelFilters.Controls.Add(lblClassFilter);
            panelFilters.Controls.Add(cmbClassFilter);
            panelFilters.Controls.Add(lblSectionFilter);
            panelFilters.Controls.Add(cmbSectionFilter);
            panelFilters.Controls.Add(lblSortBy);
            panelFilters.Controls.Add(cmbSortBy);
            panelFilters.Controls.Add(btnClearFilter);
            panelFilters.Controls.Add(btnRefresh);
            panelFilters.Controls.Add(btnExport);

            // ========================================
            // DataGridView
            // ========================================
            dgvAssignments.Location = new Point(25, 260);
            dgvAssignments.Size = new Size(1050, 400);
            dgvAssignments.BackgroundColor = Color.White;
            dgvAssignments.BorderStyle = BorderStyle.None;
            dgvAssignments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAssignments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAssignments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssignments.MultiSelect = false;
            dgvAssignments.ReadOnly = true;
            dgvAssignments.AllowUserToAddRows = false;
            dgvAssignments.AllowUserToDeleteRows = false;
            dgvAssignments.AllowUserToResizeRows = false;
            dgvAssignments.RowHeadersVisible = false;
            dgvAssignments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAssignments.RowTemplate.Height = 42;

            // Header style
            dgvAssignments.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            dgvAssignments.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAssignments.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvAssignments.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 5, 10, 5);
            dgvAssignments.ColumnHeadersHeight = 45;
            dgvAssignments.EnableHeadersVisualStyles = false;

            // Cell style
            dgvAssignments.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvAssignments.DefaultCellStyle.Padding = new Padding(10, 5, 10, 5);
            dgvAssignments.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgvAssignments.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvAssignments.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);

            // Columns
            colEmployeeId.Name = "colEmployeeId";
            colEmployeeId.HeaderText = "Employee ID";
            colEmployeeId.FillWeight = 14;

            colTeacherName.Name = "colTeacherName";
            colTeacherName.HeaderText = "Teacher Name";
            colTeacherName.FillWeight = 18;

            colClassName.Name = "colClassName";
            colClassName.HeaderText = "Class";
            colClassName.Visible = false;

            colSection.Name = "colSection";
            colSection.HeaderText = "Section";
            colSection.Visible = false;

            colClassSection.Name = "colClassSection";
            colClassSection.HeaderText = "Class / Section";
            colClassSection.FillWeight = 14;

            colStudents.Name = "colStudents";
            colStudents.HeaderText = "Students";
            colStudents.FillWeight = 10;

            colSpecialization.Name = "colSpecialization";
            colSpecialization.HeaderText = "Specialization";
            colSpecialization.FillWeight = 16;

            colStatus.Name = "colStatus";
            colStatus.HeaderText = "Status";
            colStatus.FillWeight = 10;

            dgvAssignments.Columns.AddRange(new DataGridViewColumn[] {
                colEmployeeId, colTeacherName, colClassName, colSection,
                colClassSection, colStudents, colSpecialization, colStatus
            });

            // ========================================
            // Footer
            // ========================================
            lblResultsCount.Text = "Showing 0 of 0 assignments";
            lblResultsCount.Font = new Font("Segoe UI", 10);
            lblResultsCount.ForeColor = Color.FromArgb(127, 140, 141);
            lblResultsCount.Location = new Point(25, 670);
            lblResultsCount.AutoSize = true;

            lblHint.Text = "💡 Double-click a row to view assignment details";
            lblHint.Font = new Font("Segoe UI", 9);
            lblHint.ForeColor = Color.FromArgb(127, 140, 141);
            lblHint.Location = new Point(850, 672);
            lblHint.AutoSize = true;

            // ========================================
            // Add controls to main panel
            // ========================================
            panelMain.Controls.Add(panelHeader);
            panelMain.Controls.Add(panelStats);
            panelMain.Controls.Add(panelFilters);
            panelMain.Controls.Add(dgvAssignments);
            panelMain.Controls.Add(lblResultsCount);
            panelMain.Controls.Add(lblHint);

            this.Controls.Add(panelMain);

            // Resume layouts
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelStats.ResumeLayout(false);
            panelFilters.ResumeLayout(false);
            panelFilters.PerformLayout();
            panelStatCard1.ResumeLayout(false);
            panelStatCard1.PerformLayout();
            panelStatCard2.ResumeLayout(false);
            panelStatCard2.PerformLayout();
            panelStatCard3.ResumeLayout(false);
            panelStatCard3.PerformLayout();
            panelStatCard4.ResumeLayout(false);
            panelStatCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssignments).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        // Main containers
        private Panel panelMain;
        private Panel panelHeader;
        private Panel panelStats;
        private Panel panelFilters;

        // Header controls
        private Label lblTitle;
        private Label lblSubtitle;

        // Statistics cards
        private Panel panelStatCard1;
        private Label lblStatIcon1;
        private Label lblStatLabel1;
        private Label lblTotalClasses;

        private Panel panelStatCard2;
        private Label lblStatIcon2;
        private Label lblStatLabel2;
        private Label lblTotalTeachers;

        private Panel panelStatCard3;
        private Label lblStatIcon3;
        private Label lblStatLabel3;
        private Label lblTotalStudents;

        private Panel panelStatCard4;
        private Label lblStatIcon4;
        private Label lblStatLabel4;
        private Label lblAvgStudents;

        // Filter controls
        private Label lblSearchIcon;
        private TextBox txtSearch;
        private Label lblClassFilter;
        private ComboBox cmbClassFilter;
        private Label lblSectionFilter;
        private ComboBox cmbSectionFilter;
        private Label lblSortBy;
        private ComboBox cmbSortBy;
        private Button btnClearFilter;
        private Button btnRefresh;
        private Button btnExport;

        // DataGridView
        private DataGridView dgvAssignments;
        private DataGridViewTextBoxColumn colEmployeeId;
        private DataGridViewTextBoxColumn colTeacherName;
        private DataGridViewTextBoxColumn colClassName;
        private DataGridViewTextBoxColumn colSection;
        private DataGridViewTextBoxColumn colClassSection;
        private DataGridViewTextBoxColumn colStudents;
        private DataGridViewTextBoxColumn colSpecialization;
        private DataGridViewTextBoxColumn colStatus;

        // Footer
        private Label lblResultsCount;
        private Label lblHint;
    }
}
