namespace SchoolManagementSystem
{
    partial class RemoveStudentForm
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
            // Initialize all components
            // Search Panel
            this.panelSearch = new Panel();
            this.panelSearchHeader = new Panel();
            this.lblSearchTitle = new Label();
            this.lblSearchSubtitle = new Label();
            this.panelSearchFilters = new Panel();
            this.lblSearchLabel = new Label();
            this.txtSearch = new TextBox();
            this.lblFilterClass = new Label();
            this.cmbFilterClass = new ComboBox();
            this.btnClearFilter = new Button();
            this.panelGridContainer = new Panel();
            this.dgvStudents = new DataGridView();
            this.colAdmissionNo = new DataGridViewTextBoxColumn();
            this.colStudentName = new DataGridViewTextBoxColumn();
            this.colFatherName = new DataGridViewTextBoxColumn();
            this.colClass = new DataGridViewTextBoxColumn();
            this.colSection = new DataGridViewTextBoxColumn();
            this.colContact = new DataGridViewTextBoxColumn();
            this.lblResultCount = new Label();
            this.panelSearchButtons = new Panel();
            this.btnSelectStudent = new Button();
            this.btnCancelSearch = new Button();

            // Confirmation Panel
            this.panelConfirmation = new Panel();
            this.panelConfirmHeader = new Panel();
            this.lblConfirmTitle = new Label();
            this.lblConfirmSubtitle = new Label();
            this.panelWarningBanner = new Panel();
            this.lblWarningIcon = new Label();
            this.lblWarningText = new Label();
            this.panelStudentCard = new Panel();
            this.lblCardTitle = new Label();
            this.panelCardContent = new Panel();
            this.lblNameLabel = new Label();
            this.lblConfirmStudentName = new Label();
            this.lblAdmissionLabel = new Label();
            this.lblConfirmAdmissionNo = new Label();
            this.lblClassLabel = new Label();
            this.lblConfirmClass = new Label();
            this.lblFatherLabel = new Label();
            this.lblConfirmFatherName = new Label();
            this.lblContactLabel = new Label();
            this.lblConfirmContact = new Label();
            this.lblAdmissionDateLabel = new Label();
            this.lblConfirmAdmissionDate = new Label();
            this.panelConfirmButtons = new Panel();
            this.btnCancelRemove = new Button();
            this.btnConfirmRemove = new Button();
            this.lblConfirmNote = new Label();

            // Suspend Layout
            this.panelSearch.SuspendLayout();
            this.panelSearchHeader.SuspendLayout();
            this.panelSearchFilters.SuspendLayout();
            this.panelGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.panelSearchButtons.SuspendLayout();
            this.panelConfirmation.SuspendLayout();
            this.panelConfirmHeader.SuspendLayout();
            this.panelWarningBanner.SuspendLayout();
            this.panelStudentCard.SuspendLayout();
            this.panelCardContent.SuspendLayout();
            this.panelConfirmButtons.SuspendLayout();
            this.SuspendLayout();

            // =============================================
            // PANEL SEARCH
            // =============================================
            this.panelSearch.BackColor = Color.FromArgb(236, 240, 241);
            this.panelSearch.Controls.Add(this.panelSearchHeader);
            this.panelSearch.Controls.Add(this.panelSearchFilters);
            this.panelSearch.Controls.Add(this.panelGridContainer);
            this.panelSearch.Controls.Add(this.panelSearchButtons);
            this.panelSearch.Dock = DockStyle.Fill;
            this.panelSearch.Location = new Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new Size(850, 600);

            // =============================================
            // SEARCH HEADER
            // =============================================
            this.panelSearchHeader.BackColor = Color.FromArgb(231, 76, 60);
            this.panelSearchHeader.Controls.Add(this.lblSearchTitle);
            this.panelSearchHeader.Controls.Add(this.lblSearchSubtitle);
            this.panelSearchHeader.Dock = DockStyle.Top;
            this.panelSearchHeader.Location = new Point(0, 0);
            this.panelSearchHeader.Name = "panelSearchHeader";
            this.panelSearchHeader.Size = new Size(850, 80);

            // lblSearchTitle
            this.lblSearchTitle.AutoSize = true;
            this.lblSearchTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblSearchTitle.ForeColor = Color.White;
            this.lblSearchTitle.Location = new Point(30, 15);
            this.lblSearchTitle.Name = "lblSearchTitle";
            this.lblSearchTitle.Size = new Size(200, 32);
            this.lblSearchTitle.Text = "🗑️ Remove Student";

            // lblSearchSubtitle
            this.lblSearchSubtitle.AutoSize = true;
            this.lblSearchSubtitle.Font = new Font("Segoe UI", 10F);
            this.lblSearchSubtitle.ForeColor = Color.FromArgb(250, 219, 216);
            this.lblSearchSubtitle.Location = new Point(32, 50);
            this.lblSearchSubtitle.Name = "lblSearchSubtitle";
            this.lblSearchSubtitle.Size = new Size(320, 19);
            this.lblSearchSubtitle.Text = "Search and select a student to remove from the system";

            // =============================================
            // SEARCH FILTERS
            // =============================================
            this.panelSearchFilters.BackColor = Color.White;
            this.panelSearchFilters.Controls.Add(this.lblSearchLabel);
            this.panelSearchFilters.Controls.Add(this.txtSearch);
            this.panelSearchFilters.Controls.Add(this.lblFilterClass);
            this.panelSearchFilters.Controls.Add(this.cmbFilterClass);
            this.panelSearchFilters.Controls.Add(this.btnClearFilter);
            this.panelSearchFilters.Location = new Point(20, 100);
            this.panelSearchFilters.Name = "panelSearchFilters";
            this.panelSearchFilters.Size = new Size(810, 70);

            // lblSearchLabel
            this.lblSearchLabel.AutoSize = true;
            this.lblSearchLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblSearchLabel.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblSearchLabel.Location = new Point(20, 25);
            this.lblSearchLabel.Name = "lblSearchLabel";
            this.lblSearchLabel.Size = new Size(60, 19);
            this.lblSearchLabel.Text = "Search:";

            // txtSearch
            this.txtSearch.BorderStyle = BorderStyle.FixedSingle;
            this.txtSearch.Font = new Font("Segoe UI", 11F);
            this.txtSearch.Location = new Point(90, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search by name, admission number...";
            this.txtSearch.Size = new Size(300, 27);

            // lblFilterClass
            this.lblFilterClass.AutoSize = true;
            this.lblFilterClass.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblFilterClass.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblFilterClass.Location = new Point(420, 25);
            this.lblFilterClass.Name = "lblFilterClass";
            this.lblFilterClass.Size = new Size(90, 19);
            this.lblFilterClass.Text = "Filter Class:";

            // cmbFilterClass
            this.cmbFilterClass.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbFilterClass.Font = new Font("Segoe UI", 11F);
            this.cmbFilterClass.Location = new Point(515, 21);
            this.cmbFilterClass.Name = "cmbFilterClass";
            this.cmbFilterClass.Size = new Size(150, 28);
            this.cmbFilterClass.Items.AddRange(new object[] {
                "All Classes", "Nursery", "Prep", "Class 1", "Class 2", "Class 3", "Class 4",
                "Class 5", "Class 6", "Class 7", "Class 8", "Class 9", "Class 10"
            });
            this.cmbFilterClass.SelectedIndex = 0;

            // btnClearFilter
            this.btnClearFilter.BackColor = Color.FromArgb(149, 165, 166);
            this.btnClearFilter.Cursor = Cursors.Hand;
            this.btnClearFilter.FlatAppearance.BorderSize = 0;
            this.btnClearFilter.FlatStyle = FlatStyle.Flat;
            this.btnClearFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnClearFilter.ForeColor = Color.White;
            this.btnClearFilter.Location = new Point(690, 20);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new Size(100, 32);
            this.btnClearFilter.Text = "Clear";

            // =============================================
            // GRID CONTAINER
            // =============================================
            this.panelGridContainer.BackColor = Color.White;
            this.panelGridContainer.Controls.Add(this.dgvStudents);
            this.panelGridContainer.Controls.Add(this.lblResultCount);
            this.panelGridContainer.Location = new Point(20, 180);
            this.panelGridContainer.Name = "panelGridContainer";
            this.panelGridContainer.Size = new Size(810, 340);

            // lblResultCount
            this.lblResultCount.AutoSize = true;
            this.lblResultCount.Font = new Font("Segoe UI", 9F);
            this.lblResultCount.ForeColor = Color.FromArgb(127, 140, 141);
            this.lblResultCount.Location = new Point(15, 10);
            this.lblResultCount.Name = "lblResultCount";
            this.lblResultCount.Size = new Size(120, 15);
            this.lblResultCount.Text = "Showing 0 student(s)";

            // dgvStudents
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AllowUserToResizeRows = false;
            this.dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.BackgroundColor = Color.White;
            this.dgvStudents.BorderStyle = BorderStyle.None;
            this.dgvStudents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStudents.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgvStudents.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(231, 76, 60);
            this.dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvStudents.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.dgvStudents.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(231, 76, 60);
            this.dgvStudents.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvStudents.ColumnHeadersHeight = 40;
            this.dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStudents.Columns.AddRange(new DataGridViewColumn[] {
                this.colAdmissionNo,
                this.colStudentName,
                this.colFatherName,
                this.colClass,
                this.colSection,
                this.colContact
            });
            this.dgvStudents.DefaultCellStyle.BackColor = Color.White;
            this.dgvStudents.DefaultCellStyle.ForeColor = Color.FromArgb(44, 62, 80);
            this.dgvStudents.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            this.dgvStudents.DefaultCellStyle.SelectionBackColor = Color.FromArgb(250, 219, 216);
            this.dgvStudents.DefaultCellStyle.SelectionForeColor = Color.FromArgb(44, 62, 80);
            this.dgvStudents.DefaultCellStyle.Padding = new Padding(5);
            this.dgvStudents.EnableHeadersVisualStyles = false;
            this.dgvStudents.GridColor = Color.FromArgb(236, 240, 241);
            this.dgvStudents.Location = new Point(15, 35);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.RowTemplate.Height = 38;
            this.dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new Size(780, 290);

            // Column definitions
            this.colAdmissionNo.HeaderText = "Admission No.";
            this.colAdmissionNo.Name = "colAdmissionNo";
            this.colAdmissionNo.FillWeight = 100;

            this.colStudentName.HeaderText = "Student Name";
            this.colStudentName.Name = "colStudentName";
            this.colStudentName.FillWeight = 120;

            this.colFatherName.HeaderText = "Father Name";
            this.colFatherName.Name = "colFatherName";
            this.colFatherName.FillWeight = 120;

            this.colClass.HeaderText = "Class";
            this.colClass.Name = "colClass";
            this.colClass.FillWeight = 70;

            this.colSection.HeaderText = "Section";
            this.colSection.Name = "colSection";
            this.colSection.FillWeight = 60;

            this.colContact.HeaderText = "Contact";
            this.colContact.Name = "colContact";
            this.colContact.FillWeight = 100;

            // =============================================
            // SEARCH BUTTONS
            // =============================================
            this.panelSearchButtons.BackColor = Color.FromArgb(236, 240, 241);
            this.panelSearchButtons.Controls.Add(this.btnSelectStudent);
            this.panelSearchButtons.Controls.Add(this.btnCancelSearch);
            this.panelSearchButtons.Dock = DockStyle.Bottom;
            this.panelSearchButtons.Location = new Point(0, 530);
            this.panelSearchButtons.Name = "panelSearchButtons";
            this.panelSearchButtons.Size = new Size(850, 70);

            // btnSelectStudent
            this.btnSelectStudent.BackColor = Color.FromArgb(231, 76, 60);
            this.btnSelectStudent.Cursor = Cursors.Hand;
            this.btnSelectStudent.Enabled = false;
            this.btnSelectStudent.FlatAppearance.BorderSize = 0;
            this.btnSelectStudent.FlatStyle = FlatStyle.Flat;
            this.btnSelectStudent.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnSelectStudent.ForeColor = Color.White;
            this.btnSelectStudent.Location = new Point(500, 15);
            this.btnSelectStudent.Name = "btnSelectStudent";
            this.btnSelectStudent.Size = new Size(200, 45);
            this.btnSelectStudent.Text = "🗑️ Remove Selected";

            // btnCancelSearch
            this.btnCancelSearch.BackColor = Color.FromArgb(149, 165, 166);
            this.btnCancelSearch.Cursor = Cursors.Hand;
            this.btnCancelSearch.FlatAppearance.BorderSize = 0;
            this.btnCancelSearch.FlatStyle = FlatStyle.Flat;
            this.btnCancelSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnCancelSearch.ForeColor = Color.White;
            this.btnCancelSearch.Location = new Point(710, 15);
            this.btnCancelSearch.Name = "btnCancelSearch";
            this.btnCancelSearch.Size = new Size(120, 45);
            this.btnCancelSearch.Text = "Cancel";

            // =============================================
            // PANEL CONFIRMATION
            // =============================================
            this.panelConfirmation.BackColor = Color.FromArgb(236, 240, 241);
            this.panelConfirmation.Controls.Add(this.panelConfirmHeader);
            this.panelConfirmation.Controls.Add(this.panelWarningBanner);
            this.panelConfirmation.Controls.Add(this.panelStudentCard);
            this.panelConfirmation.Controls.Add(this.panelConfirmButtons);
            this.panelConfirmation.Controls.Add(this.lblConfirmNote);
            this.panelConfirmation.Dock = DockStyle.Fill;
            this.panelConfirmation.Location = new Point(0, 0);
            this.panelConfirmation.Name = "panelConfirmation";
            this.panelConfirmation.Size = new Size(850, 600);
            this.panelConfirmation.Visible = false;

            // =============================================
            // CONFIRMATION HEADER
            // =============================================
            this.panelConfirmHeader.BackColor = Color.FromArgb(231, 76, 60);
            this.panelConfirmHeader.Controls.Add(this.lblConfirmTitle);
            this.panelConfirmHeader.Controls.Add(this.lblConfirmSubtitle);
            this.panelConfirmHeader.Dock = DockStyle.Top;
            this.panelConfirmHeader.Location = new Point(0, 0);
            this.panelConfirmHeader.Name = "panelConfirmHeader";
            this.panelConfirmHeader.Size = new Size(850, 80);

            // lblConfirmTitle
            this.lblConfirmTitle.AutoSize = true;
            this.lblConfirmTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblConfirmTitle.ForeColor = Color.White;
            this.lblConfirmTitle.Location = new Point(30, 15);
            this.lblConfirmTitle.Name = "lblConfirmTitle";
            this.lblConfirmTitle.Size = new Size(250, 32);
            this.lblConfirmTitle.Text = "⚠️ Confirm Removal";

            // lblConfirmSubtitle
            this.lblConfirmSubtitle.AutoSize = true;
            this.lblConfirmSubtitle.Font = new Font("Segoe UI", 10F);
            this.lblConfirmSubtitle.ForeColor = Color.FromArgb(250, 219, 216);
            this.lblConfirmSubtitle.Location = new Point(32, 50);
            this.lblConfirmSubtitle.Name = "lblConfirmSubtitle";
            this.lblConfirmSubtitle.Size = new Size(350, 19);
            this.lblConfirmSubtitle.Text = "Please review the student details before removing";

            // =============================================
            // WARNING BANNER
            // =============================================
            this.panelWarningBanner.BackColor = Color.FromArgb(253, 237, 236);
            this.panelWarningBanner.Controls.Add(this.lblWarningIcon);
            this.panelWarningBanner.Controls.Add(this.lblWarningText);
            this.panelWarningBanner.Location = new Point(100, 110);
            this.panelWarningBanner.Name = "panelWarningBanner";
            this.panelWarningBanner.Size = new Size(650, 60);

            // lblWarningIcon
            this.lblWarningIcon.AutoSize = true;
            this.lblWarningIcon.Font = new Font("Segoe UI", 24F);
            this.lblWarningIcon.ForeColor = Color.FromArgb(231, 76, 60);
            this.lblWarningIcon.Location = new Point(20, 10);
            this.lblWarningIcon.Name = "lblWarningIcon";
            this.lblWarningIcon.Size = new Size(50, 45);
            this.lblWarningIcon.Text = "⚠️";

            // lblWarningText
            this.lblWarningText.AutoSize = true;
            this.lblWarningText.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblWarningText.ForeColor = Color.FromArgb(192, 57, 43);
            this.lblWarningText.Location = new Point(80, 18);
            this.lblWarningText.Name = "lblWarningText";
            this.lblWarningText.Size = new Size(520, 20);
            this.lblWarningText.Text = "This action is PERMANENT and cannot be undone. Please verify carefully!";

            // =============================================
            // STUDENT CARD
            // =============================================
            this.panelStudentCard.BackColor = Color.White;
            this.panelStudentCard.Controls.Add(this.lblCardTitle);
            this.panelStudentCard.Controls.Add(this.panelCardContent);
            this.panelStudentCard.Location = new Point(100, 190);
            this.panelStudentCard.Name = "panelStudentCard";
            this.panelStudentCard.Size = new Size(650, 280);

            // lblCardTitle
            this.lblCardTitle.BackColor = Color.FromArgb(44, 62, 80);
            this.lblCardTitle.Dock = DockStyle.Top;
            this.lblCardTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblCardTitle.ForeColor = Color.White;
            this.lblCardTitle.Location = new Point(0, 0);
            this.lblCardTitle.Name = "lblCardTitle";
            this.lblCardTitle.Padding = new Padding(20, 0, 0, 0);
            this.lblCardTitle.Size = new Size(650, 45);
            this.lblCardTitle.Text = "📋 Student Details to be Removed";
            this.lblCardTitle.TextAlign = ContentAlignment.MiddleLeft;

            // panelCardContent
            this.panelCardContent.BackColor = Color.White;
            this.panelCardContent.Controls.Add(this.lblNameLabel);
            this.panelCardContent.Controls.Add(this.lblConfirmStudentName);
            this.panelCardContent.Controls.Add(this.lblAdmissionLabel);
            this.panelCardContent.Controls.Add(this.lblConfirmAdmissionNo);
            this.panelCardContent.Controls.Add(this.lblClassLabel);
            this.panelCardContent.Controls.Add(this.lblConfirmClass);
            this.panelCardContent.Controls.Add(this.lblFatherLabel);
            this.panelCardContent.Controls.Add(this.lblConfirmFatherName);
            this.panelCardContent.Controls.Add(this.lblContactLabel);
            this.panelCardContent.Controls.Add(this.lblConfirmContact);
            this.panelCardContent.Controls.Add(this.lblAdmissionDateLabel);
            this.panelCardContent.Controls.Add(this.lblConfirmAdmissionDate);
            this.panelCardContent.Location = new Point(0, 45);
            this.panelCardContent.Name = "panelCardContent";
            this.panelCardContent.Size = new Size(650, 235);

            int detailY = 20;
            int detailRowHeight = 35;
            int labelX = 30;
            int valueX = 200;

            // Student Name
            this.lblNameLabel.AutoSize = true;
            this.lblNameLabel.Font = new Font("Segoe UI", 11F);
            this.lblNameLabel.ForeColor = Color.FromArgb(127, 140, 141);
            this.lblNameLabel.Location = new Point(labelX, detailY);
            this.lblNameLabel.Name = "lblNameLabel";
            this.lblNameLabel.Text = "Student Name:";

            this.lblConfirmStudentName.AutoSize = true;
            this.lblConfirmStudentName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblConfirmStudentName.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblConfirmStudentName.Location = new Point(valueX, detailY);
            this.lblConfirmStudentName.Name = "lblConfirmStudentName";
            this.lblConfirmStudentName.Text = "-";

            detailY += detailRowHeight;

            // Admission Number
            this.lblAdmissionLabel.AutoSize = true;
            this.lblAdmissionLabel.Font = new Font("Segoe UI", 11F);
            this.lblAdmissionLabel.ForeColor = Color.FromArgb(127, 140, 141);
            this.lblAdmissionLabel.Location = new Point(labelX, detailY);
            this.lblAdmissionLabel.Name = "lblAdmissionLabel";
            this.lblAdmissionLabel.Text = "Admission No:";

            this.lblConfirmAdmissionNo.AutoSize = true;
            this.lblConfirmAdmissionNo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblConfirmAdmissionNo.ForeColor = Color.FromArgb(231, 76, 60);
            this.lblConfirmAdmissionNo.Location = new Point(valueX, detailY);
            this.lblConfirmAdmissionNo.Name = "lblConfirmAdmissionNo";
            this.lblConfirmAdmissionNo.Text = "-";

            detailY += detailRowHeight;

            // Class & Section
            this.lblClassLabel.AutoSize = true;
            this.lblClassLabel.Font = new Font("Segoe UI", 11F);
            this.lblClassLabel.ForeColor = Color.FromArgb(127, 140, 141);
            this.lblClassLabel.Location = new Point(labelX, detailY);
            this.lblClassLabel.Name = "lblClassLabel";
            this.lblClassLabel.Text = "Class & Section:";

            this.lblConfirmClass.AutoSize = true;
            this.lblConfirmClass.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblConfirmClass.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblConfirmClass.Location = new Point(valueX, detailY);
            this.lblConfirmClass.Name = "lblConfirmClass";
            this.lblConfirmClass.Text = "-";

            detailY += detailRowHeight;

            // Father Name
            this.lblFatherLabel.AutoSize = true;
            this.lblFatherLabel.Font = new Font("Segoe UI", 11F);
            this.lblFatherLabel.ForeColor = Color.FromArgb(127, 140, 141);
            this.lblFatherLabel.Location = new Point(labelX, detailY);
            this.lblFatherLabel.Name = "lblFatherLabel";
            this.lblFatherLabel.Text = "Father Name:";

            this.lblConfirmFatherName.AutoSize = true;
            this.lblConfirmFatherName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblConfirmFatherName.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblConfirmFatherName.Location = new Point(valueX, detailY);
            this.lblConfirmFatherName.Name = "lblConfirmFatherName";
            this.lblConfirmFatherName.Text = "-";

            detailY += detailRowHeight;

            // Contact
            this.lblContactLabel.AutoSize = true;
            this.lblContactLabel.Font = new Font("Segoe UI", 11F);
            this.lblContactLabel.ForeColor = Color.FromArgb(127, 140, 141);
            this.lblContactLabel.Location = new Point(labelX, detailY);
            this.lblContactLabel.Name = "lblContactLabel";
            this.lblContactLabel.Text = "Contact:";

            this.lblConfirmContact.AutoSize = true;
            this.lblConfirmContact.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblConfirmContact.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblConfirmContact.Location = new Point(valueX, detailY);
            this.lblConfirmContact.Name = "lblConfirmContact";
            this.lblConfirmContact.Text = "-";

            detailY += detailRowHeight;

            // Admission Date
            this.lblAdmissionDateLabel.AutoSize = true;
            this.lblAdmissionDateLabel.Font = new Font("Segoe UI", 11F);
            this.lblAdmissionDateLabel.ForeColor = Color.FromArgb(127, 140, 141);
            this.lblAdmissionDateLabel.Location = new Point(labelX, detailY);
            this.lblAdmissionDateLabel.Name = "lblAdmissionDateLabel";
            this.lblAdmissionDateLabel.Text = "Admission Date:";

            this.lblConfirmAdmissionDate.AutoSize = true;
            this.lblConfirmAdmissionDate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblConfirmAdmissionDate.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblConfirmAdmissionDate.Location = new Point(valueX, detailY);
            this.lblConfirmAdmissionDate.Name = "lblConfirmAdmissionDate";
            this.lblConfirmAdmissionDate.Text = "-";

            // =============================================
            // CONFIRM NOTE
            // =============================================
            this.lblConfirmNote.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            this.lblConfirmNote.ForeColor = Color.FromArgb(127, 140, 141);
            this.lblConfirmNote.Location = new Point(100, 480);
            this.lblConfirmNote.Name = "lblConfirmNote";
            this.lblConfirmNote.Size = new Size(650, 20);
            this.lblConfirmNote.Text = "💡 Tip: Click 'Go Back' if you selected the wrong student.";
            this.lblConfirmNote.TextAlign = ContentAlignment.MiddleCenter;

            // =============================================
            // CONFIRM BUTTONS
            // =============================================
            this.panelConfirmButtons.BackColor = Color.FromArgb(236, 240, 241);
            this.panelConfirmButtons.Controls.Add(this.btnCancelRemove);
            this.panelConfirmButtons.Controls.Add(this.btnConfirmRemove);
            this.panelConfirmButtons.Dock = DockStyle.Bottom;
            this.panelConfirmButtons.Location = new Point(0, 530);
            this.panelConfirmButtons.Name = "panelConfirmButtons";
            this.panelConfirmButtons.Size = new Size(850, 70);

            // btnCancelRemove
            this.btnCancelRemove.BackColor = Color.FromArgb(149, 165, 166);
            this.btnCancelRemove.Cursor = Cursors.Hand;
            this.btnCancelRemove.FlatAppearance.BorderSize = 0;
            this.btnCancelRemove.FlatStyle = FlatStyle.Flat;
            this.btnCancelRemove.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnCancelRemove.ForeColor = Color.White;
            this.btnCancelRemove.Location = new Point(400, 15);
            this.btnCancelRemove.Name = "btnCancelRemove";
            this.btnCancelRemove.Size = new Size(180, 45);
            this.btnCancelRemove.Text = "← Go Back";

            // btnConfirmRemove
            this.btnConfirmRemove.BackColor = Color.FromArgb(231, 76, 60);
            this.btnConfirmRemove.Cursor = Cursors.Hand;
            this.btnConfirmRemove.FlatAppearance.BorderSize = 0;
            this.btnConfirmRemove.FlatStyle = FlatStyle.Flat;
            this.btnConfirmRemove.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnConfirmRemove.ForeColor = Color.White;
            this.btnConfirmRemove.Location = new Point(600, 15);
            this.btnConfirmRemove.Name = "btnConfirmRemove";
            this.btnConfirmRemove.Size = new Size(220, 45);
            this.btnConfirmRemove.Text = "🗑️ Remove Permanently";

            // =============================================
            // FORM SETTINGS
            // =============================================
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new Size(850, 600);
            this.Controls.Add(this.panelConfirmation);
            this.Controls.Add(this.panelSearch);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RemoveStudentForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Remove Student - School Management System";

            // Resume Layout
            this.panelSearch.ResumeLayout(false);
            this.panelSearchHeader.ResumeLayout(false);
            this.panelSearchHeader.PerformLayout();
            this.panelSearchFilters.ResumeLayout(false);
            this.panelSearchFilters.PerformLayout();
            this.panelGridContainer.ResumeLayout(false);
            this.panelGridContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.panelSearchButtons.ResumeLayout(false);
            this.panelConfirmation.ResumeLayout(false);
            this.panelConfirmHeader.ResumeLayout(false);
            this.panelConfirmHeader.PerformLayout();
            this.panelWarningBanner.ResumeLayout(false);
            this.panelWarningBanner.PerformLayout();
            this.panelStudentCard.ResumeLayout(false);
            this.panelCardContent.ResumeLayout(false);
            this.panelCardContent.PerformLayout();
            this.panelConfirmButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // Search Panel
        private Panel panelSearch;
        private Panel panelSearchHeader;
        private Label lblSearchTitle;
        private Label lblSearchSubtitle;
        private Panel panelSearchFilters;
        private Label lblSearchLabel;
        private TextBox txtSearch;
        private Label lblFilterClass;
        private ComboBox cmbFilterClass;
        private Button btnClearFilter;
        private Panel panelGridContainer;
        private DataGridView dgvStudents;
        private DataGridViewTextBoxColumn colAdmissionNo;
        private DataGridViewTextBoxColumn colStudentName;
        private DataGridViewTextBoxColumn colFatherName;
        private DataGridViewTextBoxColumn colClass;
        private DataGridViewTextBoxColumn colSection;
        private DataGridViewTextBoxColumn colContact;
        private Label lblResultCount;
        private Panel panelSearchButtons;
        private Button btnSelectStudent;
        private Button btnCancelSearch;

        // Confirmation Panel
        private Panel panelConfirmation;
        private Panel panelConfirmHeader;
        private Label lblConfirmTitle;
        private Label lblConfirmSubtitle;
        private Panel panelWarningBanner;
        private Label lblWarningIcon;
        private Label lblWarningText;
        private Panel panelStudentCard;
        private Label lblCardTitle;
        private Panel panelCardContent;
        private Label lblNameLabel;
        private Label lblConfirmStudentName;
        private Label lblAdmissionLabel;
        private Label lblConfirmAdmissionNo;
        private Label lblClassLabel;
        private Label lblConfirmClass;
        private Label lblFatherLabel;
        private Label lblConfirmFatherName;
        private Label lblContactLabel;
        private Label lblConfirmContact;
        private Label lblAdmissionDateLabel;
        private Label lblConfirmAdmissionDate;
        private Panel panelConfirmButtons;
        private Button btnCancelRemove;
        private Button btnConfirmRemove;
        private Label lblConfirmNote;
    }
}
