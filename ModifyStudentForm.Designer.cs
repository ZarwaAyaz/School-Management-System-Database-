namespace SchoolManagementSystem
{
    partial class ModifyStudentForm
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

            // Edit Form Panel
            this.panelEditForm = new Panel();
            this.panelEditHeader = new Panel();
            this.lblEditTitle = new Label();
            this.panelAdmissionNumber = new Panel();
            this.lblAdmissionNumberLabel = new Label();
            this.lblAdmissionNumberValue = new Label();
            this.panelEditContent = new Panel();

            // Form Fields
            this.lblStudentName = new Label();
            this.txtStudentName = new TextBox();
            this.lblFatherName = new Label();
            this.txtFatherName = new TextBox();
            this.lblDateOfBirth = new Label();
            this.dtpDateOfBirth = new DateTimePicker();
            this.lblGender = new Label();
            this.cmbGender = new ComboBox();
            this.lblAddress = new Label();
            this.txtAddress = new TextBox();
            this.lblContactNumber = new Label();
            this.txtContactNumber = new TextBox();
            this.lblEmergencyContact = new Label();
            this.txtEmergencyContact = new TextBox();
            this.lblPreviousSchool = new Label();
            this.txtPreviousSchool = new TextBox();
            this.lblAdmissionDate = new Label();
            this.dtpAdmissionDate = new DateTimePicker();
            this.lblClass = new Label();
            this.cmbClass = new ComboBox();
            this.lblSection = new Label();
            this.cmbSection = new ComboBox();

            // Buttons
            this.panelEditButtons = new Panel();
            this.btnBackToSearch = new Button();
            this.btnSaveChanges = new Button();
            this.btnCancelEdit = new Button();

            // Suspend Layout
            this.panelSearch.SuspendLayout();
            this.panelSearchHeader.SuspendLayout();
            this.panelSearchFilters.SuspendLayout();
            this.panelGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.panelSearchButtons.SuspendLayout();
            this.panelEditForm.SuspendLayout();
            this.panelEditHeader.SuspendLayout();
            this.panelAdmissionNumber.SuspendLayout();
            this.panelEditContent.SuspendLayout();
            this.panelEditButtons.SuspendLayout();
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
            this.panelSearch.Size = new Size(950, 700);

            // =============================================
            // SEARCH HEADER
            // =============================================
            this.panelSearchHeader.BackColor = Color.FromArgb(41, 128, 185);
            this.panelSearchHeader.Controls.Add(this.lblSearchTitle);
            this.panelSearchHeader.Controls.Add(this.lblSearchSubtitle);
            this.panelSearchHeader.Dock = DockStyle.Top;
            this.panelSearchHeader.Location = new Point(0, 0);
            this.panelSearchHeader.Name = "panelSearchHeader";
            this.panelSearchHeader.Size = new Size(950, 80);

            // lblSearchTitle
            this.lblSearchTitle.AutoSize = true;
            this.lblSearchTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblSearchTitle.ForeColor = Color.White;
            this.lblSearchTitle.Location = new Point(30, 15);
            this.lblSearchTitle.Name = "lblSearchTitle";
            this.lblSearchTitle.Size = new Size(200, 32);
            this.lblSearchTitle.Text = "Modify Student";

            // lblSearchSubtitle
            this.lblSearchSubtitle.AutoSize = true;
            this.lblSearchSubtitle.Font = new Font("Segoe UI", 10F);
            this.lblSearchSubtitle.ForeColor = Color.FromArgb(214, 234, 248);
            this.lblSearchSubtitle.Location = new Point(32, 50);
            this.lblSearchSubtitle.Name = "lblSearchSubtitle";
            this.lblSearchSubtitle.Size = new Size(280, 19);
            this.lblSearchSubtitle.Text = "Search and select a student to modify their details";

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
            this.panelSearchFilters.Size = new Size(910, 70);

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
            this.txtSearch.PlaceholderText = "Search by name, admission number, or father name...";
            this.txtSearch.Size = new Size(350, 27);

            // lblFilterClass
            this.lblFilterClass.AutoSize = true;
            this.lblFilterClass.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblFilterClass.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblFilterClass.Location = new Point(470, 25);
            this.lblFilterClass.Name = "lblFilterClass";
            this.lblFilterClass.Size = new Size(90, 19);
            this.lblFilterClass.Text = "Filter Class:";

            // cmbFilterClass
            this.cmbFilterClass.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbFilterClass.Font = new Font("Segoe UI", 11F);
            this.cmbFilterClass.Location = new Point(565, 21);
            this.cmbFilterClass.Name = "cmbFilterClass";
            this.cmbFilterClass.Size = new Size(180, 28);
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
            this.btnClearFilter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnClearFilter.ForeColor = Color.White;
            this.btnClearFilter.Location = new Point(770, 18);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new Size(120, 35);
            this.btnClearFilter.Text = "Clear Filters";

            // =============================================
            // GRID CONTAINER
            // =============================================
            this.panelGridContainer.BackColor = Color.White;
            this.panelGridContainer.Controls.Add(this.dgvStudents);
            this.panelGridContainer.Controls.Add(this.lblResultCount);
            this.panelGridContainer.Location = new Point(20, 180);
            this.panelGridContainer.Name = "panelGridContainer";
            this.panelGridContainer.Size = new Size(910, 430);

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
            this.dgvStudents.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            this.dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvStudents.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.dgvStudents.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185);
            this.dgvStudents.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvStudents.ColumnHeadersHeight = 45;
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
            this.dgvStudents.DefaultCellStyle.SelectionBackColor = Color.FromArgb(214, 234, 248);
            this.dgvStudents.DefaultCellStyle.SelectionForeColor = Color.FromArgb(44, 62, 80);
            this.dgvStudents.DefaultCellStyle.Padding = new Padding(5);
            this.dgvStudents.EnableHeadersVisualStyles = false;
            this.dgvStudents.GridColor = Color.FromArgb(236, 240, 241);
            this.dgvStudents.Location = new Point(15, 35);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.RowTemplate.Height = 40;
            this.dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new Size(880, 380);

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
            this.panelSearchButtons.Location = new Point(0, 630);
            this.panelSearchButtons.Name = "panelSearchButtons";
            this.panelSearchButtons.Size = new Size(950, 70);

            // btnSelectStudent
            this.btnSelectStudent.BackColor = Color.FromArgb(41, 128, 185);
            this.btnSelectStudent.Cursor = Cursors.Hand;
            this.btnSelectStudent.Enabled = false;
            this.btnSelectStudent.FlatAppearance.BorderSize = 0;
            this.btnSelectStudent.FlatStyle = FlatStyle.Flat;
            this.btnSelectStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnSelectStudent.ForeColor = Color.White;
            this.btnSelectStudent.Location = new Point(580, 15);
            this.btnSelectStudent.Name = "btnSelectStudent";
            this.btnSelectStudent.Size = new Size(200, 45);
            this.btnSelectStudent.Text = "Select & Edit →";

            // btnCancelSearch
            this.btnCancelSearch.BackColor = Color.FromArgb(149, 165, 166);
            this.btnCancelSearch.Cursor = Cursors.Hand;
            this.btnCancelSearch.FlatAppearance.BorderSize = 0;
            this.btnCancelSearch.FlatStyle = FlatStyle.Flat;
            this.btnCancelSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnCancelSearch.ForeColor = Color.White;
            this.btnCancelSearch.Location = new Point(800, 15);
            this.btnCancelSearch.Name = "btnCancelSearch";
            this.btnCancelSearch.Size = new Size(130, 45);
            this.btnCancelSearch.Text = "Cancel";

            // =============================================
            // PANEL EDIT FORM
            // =============================================
            this.panelEditForm.BackColor = Color.FromArgb(236, 240, 241);
            this.panelEditForm.Controls.Add(this.panelEditHeader);
            this.panelEditForm.Controls.Add(this.panelEditContent);
            this.panelEditForm.Controls.Add(this.panelEditButtons);
            this.panelEditForm.Dock = DockStyle.Fill;
            this.panelEditForm.Location = new Point(0, 0);
            this.panelEditForm.Name = "panelEditForm";
            this.panelEditForm.Size = new Size(950, 700);
            this.panelEditForm.Visible = false;

            // =============================================
            // EDIT HEADER
            // =============================================
            this.panelEditHeader.BackColor = Color.FromArgb(41, 128, 185);
            this.panelEditHeader.Controls.Add(this.lblEditTitle);
            this.panelEditHeader.Controls.Add(this.panelAdmissionNumber);
            this.panelEditHeader.Dock = DockStyle.Top;
            this.panelEditHeader.Location = new Point(0, 0);
            this.panelEditHeader.Name = "panelEditHeader";
            this.panelEditHeader.Size = new Size(950, 100);

            // lblEditTitle
            this.lblEditTitle.AutoSize = true;
            this.lblEditTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblEditTitle.ForeColor = Color.White;
            this.lblEditTitle.Location = new Point(30, 30);
            this.lblEditTitle.Name = "lblEditTitle";
            this.lblEditTitle.Size = new Size(280, 37);
            this.lblEditTitle.Text = "Edit Student Details";

            // panelAdmissionNumber
            this.panelAdmissionNumber.BackColor = Color.FromArgb(52, 152, 219);
            this.panelAdmissionNumber.Controls.Add(this.lblAdmissionNumberLabel);
            this.panelAdmissionNumber.Controls.Add(this.lblAdmissionNumberValue);
            this.panelAdmissionNumber.Location = new Point(670, 20);
            this.panelAdmissionNumber.Name = "panelAdmissionNumber";
            this.panelAdmissionNumber.Size = new Size(250, 60);

            // lblAdmissionNumberLabel
            this.lblAdmissionNumberLabel.AutoSize = true;
            this.lblAdmissionNumberLabel.Font = new Font("Segoe UI", 9F);
            this.lblAdmissionNumberLabel.ForeColor = Color.FromArgb(214, 234, 248);
            this.lblAdmissionNumberLabel.Location = new Point(15, 8);
            this.lblAdmissionNumberLabel.Name = "lblAdmissionNumberLabel";
            this.lblAdmissionNumberLabel.Size = new Size(140, 15);
            this.lblAdmissionNumberLabel.Text = "ADMISSION NO. (Read-only)";

            // lblAdmissionNumberValue
            this.lblAdmissionNumberValue.AutoSize = true;
            this.lblAdmissionNumberValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblAdmissionNumberValue.ForeColor = Color.White;
            this.lblAdmissionNumberValue.Location = new Point(15, 28);
            this.lblAdmissionNumberValue.Name = "lblAdmissionNumberValue";
            this.lblAdmissionNumberValue.Size = new Size(180, 25);
            this.lblAdmissionNumberValue.Text = "ADM-2025-1001";

            // =============================================
            // EDIT CONTENT
            // =============================================
            this.panelEditContent.AutoScroll = true;
            this.panelEditContent.BackColor = Color.White;
            this.panelEditContent.Controls.Add(this.lblStudentName);
            this.panelEditContent.Controls.Add(this.txtStudentName);
            this.panelEditContent.Controls.Add(this.lblFatherName);
            this.panelEditContent.Controls.Add(this.txtFatherName);
            this.panelEditContent.Controls.Add(this.lblDateOfBirth);
            this.panelEditContent.Controls.Add(this.dtpDateOfBirth);
            this.panelEditContent.Controls.Add(this.lblGender);
            this.panelEditContent.Controls.Add(this.cmbGender);
            this.panelEditContent.Controls.Add(this.lblAddress);
            this.panelEditContent.Controls.Add(this.txtAddress);
            this.panelEditContent.Controls.Add(this.lblContactNumber);
            this.panelEditContent.Controls.Add(this.txtContactNumber);
            this.panelEditContent.Controls.Add(this.lblEmergencyContact);
            this.panelEditContent.Controls.Add(this.txtEmergencyContact);
            this.panelEditContent.Controls.Add(this.lblPreviousSchool);
            this.panelEditContent.Controls.Add(this.txtPreviousSchool);
            this.panelEditContent.Controls.Add(this.lblAdmissionDate);
            this.panelEditContent.Controls.Add(this.dtpAdmissionDate);
            this.panelEditContent.Controls.Add(this.lblClass);
            this.panelEditContent.Controls.Add(this.cmbClass);
            this.panelEditContent.Controls.Add(this.lblSection);
            this.panelEditContent.Controls.Add(this.cmbSection);
            this.panelEditContent.Location = new Point(30, 120);
            this.panelEditContent.Name = "panelEditContent";
            this.panelEditContent.Padding = new Padding(30);
            this.panelEditContent.Size = new Size(890, 490);

            // Layout constants
            int labelY = 15;
            int inputY = 40;
            int rowHeight = 75;
            int col1X = 25;
            int col2X = 455;
            int inputWidth = 400;
            int inputHeight = 35;

            // ---- ROW 1: Student Name & Father Name ----
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblStudentName.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblStudentName.Location = new Point(col1X, labelY);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Text = "Student Name *";

            this.txtStudentName.BorderStyle = BorderStyle.FixedSingle;
            this.txtStudentName.Font = new Font("Segoe UI", 11F);
            this.txtStudentName.Location = new Point(col1X, inputY);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new Size(inputWidth, inputHeight);

            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblFatherName.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblFatherName.Location = new Point(col2X, labelY);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Text = "Father/Guardian Name *";

            this.txtFatherName.BorderStyle = BorderStyle.FixedSingle;
            this.txtFatherName.Font = new Font("Segoe UI", 11F);
            this.txtFatherName.Location = new Point(col2X, inputY);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new Size(inputWidth, inputHeight);

            // ---- ROW 2: Date of Birth & Gender ----
            labelY += rowHeight;
            inputY += rowHeight;

            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblDateOfBirth.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblDateOfBirth.Location = new Point(col1X, labelY);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Text = "Date of Birth *";

            this.dtpDateOfBirth.Font = new Font("Segoe UI", 11F);
            this.dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new Point(col1X, inputY);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new Size(inputWidth, inputHeight);

            this.lblGender.AutoSize = true;
            this.lblGender.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblGender.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblGender.Location = new Point(col2X, labelY);
            this.lblGender.Name = "lblGender";
            this.lblGender.Text = "Gender *";

            this.cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new Font("Segoe UI", 11F);
            this.cmbGender.Location = new Point(col2X, inputY);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new Size(inputWidth, inputHeight);
            this.cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });

            // ---- ROW 3: Address (Full Width) ----
            labelY += rowHeight;
            inputY += rowHeight;

            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblAddress.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblAddress.Location = new Point(col1X, labelY);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Text = "Address *";

            this.txtAddress.BorderStyle = BorderStyle.FixedSingle;
            this.txtAddress.Font = new Font("Segoe UI", 11F);
            this.txtAddress.Location = new Point(col1X, inputY);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new Size(830, 45);

            // ---- ROW 4: Contact Number & Emergency Contact ----
            labelY += rowHeight + 15;
            inputY += rowHeight + 15;

            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblContactNumber.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblContactNumber.Location = new Point(col1X, labelY);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Text = "Contact Number *";

            this.txtContactNumber.BorderStyle = BorderStyle.FixedSingle;
            this.txtContactNumber.Font = new Font("Segoe UI", 11F);
            this.txtContactNumber.Location = new Point(col1X, inputY);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new Size(inputWidth, inputHeight);

            this.lblEmergencyContact.AutoSize = true;
            this.lblEmergencyContact.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblEmergencyContact.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblEmergencyContact.Location = new Point(col2X, labelY);
            this.lblEmergencyContact.Name = "lblEmergencyContact";
            this.lblEmergencyContact.Text = "Emergency Contact *";

            this.txtEmergencyContact.BorderStyle = BorderStyle.FixedSingle;
            this.txtEmergencyContact.Font = new Font("Segoe UI", 11F);
            this.txtEmergencyContact.Location = new Point(col2X, inputY);
            this.txtEmergencyContact.Name = "txtEmergencyContact";
            this.txtEmergencyContact.Size = new Size(inputWidth, inputHeight);

            // ---- ROW 5: Previous School (Optional) ----
            labelY += rowHeight;
            inputY += rowHeight;

            this.lblPreviousSchool.AutoSize = true;
            this.lblPreviousSchool.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblPreviousSchool.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblPreviousSchool.Location = new Point(col1X, labelY);
            this.lblPreviousSchool.Name = "lblPreviousSchool";
            this.lblPreviousSchool.Text = "Previous School (Optional)";

            this.txtPreviousSchool.BorderStyle = BorderStyle.FixedSingle;
            this.txtPreviousSchool.Font = new Font("Segoe UI", 11F);
            this.txtPreviousSchool.Location = new Point(col1X, inputY);
            this.txtPreviousSchool.Name = "txtPreviousSchool";
            this.txtPreviousSchool.Size = new Size(830, inputHeight);

            // ---- ROW 6: Admission Date, Class & Section ----
            labelY += rowHeight;
            inputY += rowHeight;

            this.lblAdmissionDate.AutoSize = true;
            this.lblAdmissionDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblAdmissionDate.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblAdmissionDate.Location = new Point(col1X, labelY);
            this.lblAdmissionDate.Name = "lblAdmissionDate";
            this.lblAdmissionDate.Text = "Admission Date *";

            this.dtpAdmissionDate.Font = new Font("Segoe UI", 11F);
            this.dtpAdmissionDate.Format = DateTimePickerFormat.Short;
            this.dtpAdmissionDate.Location = new Point(col1X, inputY);
            this.dtpAdmissionDate.Name = "dtpAdmissionDate";
            this.dtpAdmissionDate.Size = new Size(250, inputHeight);

            this.lblClass.AutoSize = true;
            this.lblClass.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblClass.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblClass.Location = new Point(300, labelY);
            this.lblClass.Name = "lblClass";
            this.lblClass.Text = "Class *";

            this.cmbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbClass.Font = new Font("Segoe UI", 11F);
            this.cmbClass.Location = new Point(300, inputY);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new Size(250, inputHeight);
            this.cmbClass.Items.AddRange(new object[] {
                "Nursery", "Prep", "Class 1", "Class 2", "Class 3", "Class 4",
                "Class 5", "Class 6", "Class 7", "Class 8", "Class 9", "Class 10"
            });

            this.lblSection.AutoSize = true;
            this.lblSection.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblSection.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblSection.Location = new Point(580, labelY);
            this.lblSection.Name = "lblSection";
            this.lblSection.Text = "Section *";

            this.cmbSection.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbSection.Font = new Font("Segoe UI", 11F);
            this.cmbSection.Location = new Point(580, inputY);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new Size(275, inputHeight);
            this.cmbSection.Items.AddRange(new object[] { "A", "B", "C", "D" });

            // =============================================
            // EDIT BUTTONS
            // =============================================
            this.panelEditButtons.BackColor = Color.FromArgb(236, 240, 241);
            this.panelEditButtons.Controls.Add(this.btnBackToSearch);
            this.panelEditButtons.Controls.Add(this.btnSaveChanges);
            this.panelEditButtons.Controls.Add(this.btnCancelEdit);
            this.panelEditButtons.Dock = DockStyle.Bottom;
            this.panelEditButtons.Location = new Point(0, 630);
            this.panelEditButtons.Name = "panelEditButtons";
            this.panelEditButtons.Size = new Size(950, 70);

            // btnBackToSearch
            this.btnBackToSearch.BackColor = Color.FromArgb(41, 128, 185);
            this.btnBackToSearch.Cursor = Cursors.Hand;
            this.btnBackToSearch.FlatAppearance.BorderSize = 0;
            this.btnBackToSearch.FlatStyle = FlatStyle.Flat;
            this.btnBackToSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnBackToSearch.ForeColor = Color.White;
            this.btnBackToSearch.Location = new Point(30, 15);
            this.btnBackToSearch.Name = "btnBackToSearch";
            this.btnBackToSearch.Size = new Size(150, 45);
            this.btnBackToSearch.Text = "← Back";

            // btnSaveChanges
            this.btnSaveChanges.BackColor = Color.FromArgb(39, 174, 96);
            this.btnSaveChanges.Cursor = Cursors.Hand;
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatStyle = FlatStyle.Flat;
            this.btnSaveChanges.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnSaveChanges.ForeColor = Color.White;
            this.btnSaveChanges.Location = new Point(570, 15);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new Size(200, 45);
            this.btnSaveChanges.Text = "✓ Save Changes";

            // btnCancelEdit
            this.btnCancelEdit.BackColor = Color.FromArgb(231, 76, 60);
            this.btnCancelEdit.Cursor = Cursors.Hand;
            this.btnCancelEdit.FlatAppearance.BorderSize = 0;
            this.btnCancelEdit.FlatStyle = FlatStyle.Flat;
            this.btnCancelEdit.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnCancelEdit.ForeColor = Color.White;
            this.btnCancelEdit.Location = new Point(790, 15);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new Size(130, 45);
            this.btnCancelEdit.Text = "Cancel";

            // =============================================
            // FORM SETTINGS
            // =============================================
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new Size(950, 700);
            this.Controls.Add(this.panelEditForm);
            this.Controls.Add(this.panelSearch);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ModifyStudentForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Modify Student - School Management System";

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
            this.panelEditForm.ResumeLayout(false);
            this.panelEditHeader.ResumeLayout(false);
            this.panelEditHeader.PerformLayout();
            this.panelAdmissionNumber.ResumeLayout(false);
            this.panelAdmissionNumber.PerformLayout();
            this.panelEditContent.ResumeLayout(false);
            this.panelEditContent.PerformLayout();
            this.panelEditButtons.ResumeLayout(false);
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

        // Edit Form Panel
        private Panel panelEditForm;
        private Panel panelEditHeader;
        private Label lblEditTitle;
        private Panel panelAdmissionNumber;
        private Label lblAdmissionNumberLabel;
        private Label lblAdmissionNumberValue;
        private Panel panelEditContent;

        // Form Fields
        private Label lblStudentName;
        private TextBox txtStudentName;
        private Label lblFatherName;
        private TextBox txtFatherName;
        private Label lblDateOfBirth;
        private DateTimePicker dtpDateOfBirth;
        private Label lblGender;
        private ComboBox cmbGender;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblContactNumber;
        private TextBox txtContactNumber;
        private Label lblEmergencyContact;
        private TextBox txtEmergencyContact;
        private Label lblPreviousSchool;
        private TextBox txtPreviousSchool;
        private Label lblAdmissionDate;
        private DateTimePicker dtpAdmissionDate;
        private Label lblClass;
        private ComboBox cmbClass;
        private Label lblSection;
        private ComboBox cmbSection;

        // Buttons
        private Panel panelEditButtons;
        private Button btnBackToSearch;
        private Button btnSaveChanges;
        private Button btnCancelEdit;
    }
}
