namespace SchoolManagementSystem
{
    partial class RemoveTeacherForm
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
            // Main Panel
            panelMain = new Panel();

            // Header Panel
            panelHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblWarningBadge = new Label();

            // Search Controls Panel
            panelSearchControls = new Panel();
            lblSearchIcon = new Label();
            txtSearch = new TextBox();
            lblDepartmentFilter = new Label();
            cmbDepartmentFilter = new ComboBox();
            btnClearFilter = new Button();

            // DataGridView
            dgvTeachers = new DataGridView();
            colEmployeeId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colDepartment = new DataGridViewTextBoxColumn();
            colQualification = new DataGridViewTextBoxColumn();
            colContact = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();

            // Footer
            lblResultsCount = new Label();
            btnRemoveSelected = new Button();

            // Warning panel
            panelWarning = new Panel();
            lblWarningText = new Label();

            // Suspend layouts
            panelMain.SuspendLayout();
            panelHeader.SuspendLayout();
            panelSearchControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).BeginInit();
            panelWarning.SuspendLayout();
            this.SuspendLayout();

            // ========================================
            // Form Settings
            // ========================================
            this.ClientSize = new Size(950, 680);
            this.Text = "Remove Teacher";
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
            // Header Panel (Red Warning Theme)
            // ========================================
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Height = 100;
            panelHeader.BackColor = Color.FromArgb(192, 57, 43);
            panelHeader.Padding = new Padding(25, 15, 25, 15);

            lblTitle.Text = "🗑️ Remove Teacher";
            lblTitle.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(25, 18);
            lblTitle.AutoSize = true;

            lblSubtitle.Text = "Search and select a teacher to remove from the system";
            lblSubtitle.Font = new Font("Segoe UI", 10);
            lblSubtitle.ForeColor = Color.FromArgb(255, 200, 200);
            lblSubtitle.Location = new Point(27, 60);
            lblSubtitle.AutoSize = true;

            // Warning Badge
            lblWarningBadge.Text = "⚠ CAUTION";
            lblWarningBadge.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblWarningBadge.ForeColor = Color.FromArgb(192, 57, 43);
            lblWarningBadge.BackColor = Color.FromArgb(255, 220, 220);
            lblWarningBadge.Padding = new Padding(10, 5, 10, 5);
            lblWarningBadge.Location = new Point(800, 35);
            lblWarningBadge.AutoSize = true;

            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblWarningBadge);

            // ========================================
            // Search Controls Panel
            // ========================================
            panelSearchControls.Location = new Point(25, 115);
            panelSearchControls.Size = new Size(900, 60);
            panelSearchControls.BackColor = Color.White;

            lblSearchIcon.Text = "🔍";
            lblSearchIcon.Font = new Font("Segoe UI", 14);
            lblSearchIcon.Location = new Point(15, 15);
            lblSearchIcon.AutoSize = true;

            txtSearch.Size = new Size(280, 30);
            txtSearch.Location = new Point(50, 15);
            txtSearch.Font = new Font("Segoe UI", 11);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.PlaceholderText = "Search by name, ID or contact...";

            lblDepartmentFilter.Text = "Department:";
            lblDepartmentFilter.Font = new Font("Segoe UI", 10);
            lblDepartmentFilter.ForeColor = Color.FromArgb(52, 73, 94);
            lblDepartmentFilter.Location = new Point(360, 18);
            lblDepartmentFilter.AutoSize = true;

            cmbDepartmentFilter.Size = new Size(200, 30);
            cmbDepartmentFilter.Location = new Point(450, 14);
            cmbDepartmentFilter.Font = new Font("Segoe UI", 10);
            cmbDepartmentFilter.DropDownStyle = ComboBoxStyle.DropDownList;

            btnClearFilter.Text = "Clear";
            btnClearFilter.Size = new Size(80, 32);
            btnClearFilter.Location = new Point(670, 13);
            btnClearFilter.BackColor = Color.FromArgb(149, 165, 166);
            btnClearFilter.ForeColor = Color.White;
            btnClearFilter.FlatStyle = FlatStyle.Flat;
            btnClearFilter.FlatAppearance.BorderSize = 0;
            btnClearFilter.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnClearFilter.Cursor = Cursors.Hand;

            panelSearchControls.Controls.Add(lblSearchIcon);
            panelSearchControls.Controls.Add(txtSearch);
            panelSearchControls.Controls.Add(lblDepartmentFilter);
            panelSearchControls.Controls.Add(cmbDepartmentFilter);
            panelSearchControls.Controls.Add(btnClearFilter);

            // ========================================
            // Warning Panel
            // ========================================
            panelWarning.Location = new Point(25, 185);
            panelWarning.Size = new Size(900, 40);
            panelWarning.BackColor = Color.FromArgb(255, 243, 224);
            panelWarning.BorderStyle = BorderStyle.FixedSingle;

            lblWarningText.Text = "⚠ Warning: Removing a teacher will permanently delete all associated records. Double-click or select a teacher and click 'Remove Selected' to proceed.";
            lblWarningText.Font = new Font("Segoe UI", 9);
            lblWarningText.ForeColor = Color.FromArgb(230, 126, 34);
            lblWarningText.Location = new Point(15, 10);
            lblWarningText.AutoSize = true;

            panelWarning.Controls.Add(lblWarningText);

            // ========================================
            // DataGridView
            // ========================================
            dgvTeachers.Location = new Point(25, 235);
            dgvTeachers.Size = new Size(900, 360);
            dgvTeachers.BackgroundColor = Color.White;
            dgvTeachers.BorderStyle = BorderStyle.None;
            dgvTeachers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTeachers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTeachers.MultiSelect = false;
            dgvTeachers.ReadOnly = true;
            dgvTeachers.AllowUserToAddRows = false;
            dgvTeachers.AllowUserToDeleteRows = false;
            dgvTeachers.AllowUserToResizeRows = false;
            dgvTeachers.RowHeadersVisible = false;
            dgvTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTeachers.RowTemplate.Height = 45;

            // Header style (Red theme)
            dgvTeachers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(192, 57, 43);
            dgvTeachers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTeachers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvTeachers.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 5, 10, 5);
            dgvTeachers.ColumnHeadersHeight = 45;
            dgvTeachers.EnableHeadersVisualStyles = false;

            // Cell style
            dgvTeachers.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvTeachers.DefaultCellStyle.Padding = new Padding(10, 5, 10, 5);
            dgvTeachers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(231, 76, 60);
            dgvTeachers.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvTeachers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 248, 248);

            // Columns
            colEmployeeId.Name = "colEmployeeId";
            colEmployeeId.HeaderText = "Employee ID";
            colEmployeeId.FillWeight = 15;

            colName.Name = "colName";
            colName.HeaderText = "Teacher Name";
            colName.FillWeight = 22;

            colDepartment.Name = "colDepartment";
            colDepartment.HeaderText = "Department";
            colDepartment.FillWeight = 18;

            colQualification.Name = "colQualification";
            colQualification.HeaderText = "Qualification";
            colQualification.FillWeight = 18;

            colContact.Name = "colContact";
            colContact.HeaderText = "Contact";
            colContact.FillWeight = 15;

            colStatus.Name = "colStatus";
            colStatus.HeaderText = "Status";
            colStatus.FillWeight = 12;

            dgvTeachers.Columns.AddRange(new DataGridViewColumn[] {
                colEmployeeId, colName, colDepartment, colQualification, colContact, colStatus
            });

            // ========================================
            // Footer
            // ========================================
            lblResultsCount.Text = "Found 0 teacher(s)";
            lblResultsCount.Font = new Font("Segoe UI", 10);
            lblResultsCount.ForeColor = Color.FromArgb(127, 140, 141);
            lblResultsCount.Location = new Point(25, 610);
            lblResultsCount.AutoSize = true;

            btnRemoveSelected.Text = "🗑️ Remove Selected";
            btnRemoveSelected.Size = new Size(170, 42);
            btnRemoveSelected.Location = new Point(755, 602);
            btnRemoveSelected.BackColor = Color.FromArgb(192, 57, 43);
            btnRemoveSelected.ForeColor = Color.White;
            btnRemoveSelected.FlatStyle = FlatStyle.Flat;
            btnRemoveSelected.FlatAppearance.BorderSize = 0;
            btnRemoveSelected.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnRemoveSelected.Cursor = Cursors.Hand;

            // ========================================
            // Add controls to main panel
            // ========================================
            panelMain.Controls.Add(panelHeader);
            panelMain.Controls.Add(panelSearchControls);
            panelMain.Controls.Add(panelWarning);
            panelMain.Controls.Add(dgvTeachers);
            panelMain.Controls.Add(lblResultsCount);
            panelMain.Controls.Add(btnRemoveSelected);

            this.Controls.Add(panelMain);

            // Resume layouts
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelSearchControls.ResumeLayout(false);
            panelSearchControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).EndInit();
            panelWarning.ResumeLayout(false);
            panelWarning.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        // Main containers
        private Panel panelMain;
        private Panel panelHeader;
        private Panel panelSearchControls;
        private Panel panelWarning;

        // Header controls
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblWarningBadge;

        // Search controls
        private Label lblSearchIcon;
        private TextBox txtSearch;
        private Label lblDepartmentFilter;
        private ComboBox cmbDepartmentFilter;
        private Button btnClearFilter;

        // Warning panel
        private Label lblWarningText;

        // DataGridView
        private DataGridView dgvTeachers;
        private DataGridViewTextBoxColumn colEmployeeId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colDepartment;
        private DataGridViewTextBoxColumn colQualification;
        private DataGridViewTextBoxColumn colContact;
        private DataGridViewTextBoxColumn colStatus;

        // Footer
        private Label lblResultsCount;
        private Button btnRemoveSelected;
    }
}
