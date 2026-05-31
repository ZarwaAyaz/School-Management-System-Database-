namespace SchoolManagementSystem
{
    partial class ModifyTeacherForm
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
            // ========================================
            // Search Panel Controls
            // ========================================
            panelSearch = new Panel();
            panelSearchHeader = new Panel();
            lblSearchTitle = new Label();
            lblSearchSubtitle = new Label();

            // Search controls
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

            lblResultsCount = new Label();
            btnSelectTeacher = new Button();

            // ========================================
            // Edit Panel Controls
            // ========================================
            panelEditForm = new Panel();
            panelEditHeader = new Panel();
            lblEditTitle = new Label();
            lblEditSubtitle = new Label();
            panelEmployeeId = new Panel();
            lblEmployeeIdLabel = new Label();
            lblEmployeeIdValue = new Label();

            // Scrollable content
            panelEditContent = new FlowLayoutPanel();

            // Section 1: Personal Information
            panelPersonalInfo = new Panel();
            lblPersonalInfoHeader = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblNameValidation = new Label();
            lblGender = new Label();
            cmbGender = new ComboBox();
            lblDateOfBirth = new Label();
            dtpDateOfBirth = new DateTimePicker();
            lblCNIC = new Label();
            txtCNIC = new TextBox();
            lblCNICValidation = new Label();

            // Section 2: Professional Information
            panelProfessionalInfo = new Panel();
            lblProfessionalInfoHeader = new Label();
            lblQualification = new Label();
            cmbQualification = new ComboBox();
            lblDepartment = new Label();
            cmbDepartment = new ComboBox();
            lblExperience = new Label();
            cmbExperience = new ComboBox();
            lblSkills = new Label();
            txtSkills = new TextBox();

            // Section 3: Contact Information
            panelContactInfo = new Panel();
            lblContactInfoHeader = new Label();
            lblContactNumber = new Label();
            txtContactNumber = new TextBox();
            lblContactValidation = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblEmailValidation = new Label();
            lblAddress = new Label();
            txtAddress = new TextBox();

            // Section 4: Employment Details
            panelEmploymentInfo = new Panel();
            lblEmploymentInfoHeader = new Label();
            lblJoiningDate = new Label();
            dtpJoiningDate = new DateTimePicker();
            lblSalary = new Label();
            txtSalary = new TextBox();
            lblSalaryValidation = new Label();
            lblStatus = new Label();
            cmbStatus = new ComboBox();

            // Section 5: Emergency Contact
            panelEmergencyInfo = new Panel();
            lblEmergencyInfoHeader = new Label();
            lblEmergencyName = new Label();
            txtEmergencyName = new TextBox();
            lblEmergencyContact = new Label();
            txtEmergencyContact = new TextBox();
            lblEmergencyValidation = new Label();

            // Edit buttons
            panelEditButtons = new Panel();
            btnBackToSearch = new Button();
            btnUpdate = new Button();
            btnCancel = new Button();

            // Suspend layouts
            panelSearch.SuspendLayout();
            panelSearchHeader.SuspendLayout();
            panelSearchControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).BeginInit();
            panelEditForm.SuspendLayout();
            panelEditHeader.SuspendLayout();
            panelEditContent.SuspendLayout();
            panelPersonalInfo.SuspendLayout();
            panelProfessionalInfo.SuspendLayout();
            panelContactInfo.SuspendLayout();
            panelEmploymentInfo.SuspendLayout();
            panelEmergencyInfo.SuspendLayout();
            panelEditButtons.SuspendLayout();
            this.SuspendLayout();

            // ========================================
            // Form Settings
            // ========================================
            this.ClientSize = new Size(1000, 700);
            this.Text = "Modify Teacher";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.FromArgb(236, 240, 241);

            // ========================================
            // SEARCH PANEL
            // ========================================
            panelSearch.Dock = DockStyle.Fill;
            panelSearch.BackColor = Color.FromArgb(236, 240, 241);

            // Search Header
            panelSearchHeader.Dock = DockStyle.Top;
            panelSearchHeader.Height = 100;
            panelSearchHeader.BackColor = Color.FromArgb(41, 128, 185);
            panelSearchHeader.Padding = new Padding(25, 15, 25, 15);

            lblSearchTitle.Text = "✏️ Modify Teacher";
            lblSearchTitle.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lblSearchTitle.ForeColor = Color.White;
            lblSearchTitle.Location = new Point(25, 18);
            lblSearchTitle.AutoSize = true;

            lblSearchSubtitle.Text = "Search and select a teacher to modify their information";
            lblSearchSubtitle.Font = new Font("Segoe UI", 10);
            lblSearchSubtitle.ForeColor = Color.FromArgb(236, 240, 241);
            lblSearchSubtitle.Location = new Point(27, 60);
            lblSearchSubtitle.AutoSize = true;

            panelSearchHeader.Controls.Add(lblSearchTitle);
            panelSearchHeader.Controls.Add(lblSearchSubtitle);

            // Search Controls Panel
            panelSearchControls.Location = new Point(25, 115);
            panelSearchControls.Size = new Size(950, 60);
            panelSearchControls.BackColor = Color.White;

            lblSearchIcon.Text = "🔍";
            lblSearchIcon.Font = new Font("Segoe UI", 14);
            lblSearchIcon.Location = new Point(15, 15);
            lblSearchIcon.AutoSize = true;

            txtSearch.Size = new Size(300, 30);
            txtSearch.Location = new Point(50, 15);
            txtSearch.Font = new Font("Segoe UI", 11);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.PlaceholderText = "Search by name, ID or contact...";

            lblDepartmentFilter.Text = "Department:";
            lblDepartmentFilter.Font = new Font("Segoe UI", 10);
            lblDepartmentFilter.ForeColor = Color.FromArgb(52, 73, 94);
            lblDepartmentFilter.Location = new Point(380, 18);
            lblDepartmentFilter.AutoSize = true;

            cmbDepartmentFilter.Size = new Size(200, 30);
            cmbDepartmentFilter.Location = new Point(465, 14);
            cmbDepartmentFilter.Font = new Font("Segoe UI", 10);
            cmbDepartmentFilter.DropDownStyle = ComboBoxStyle.DropDownList;

            btnClearFilter.Text = "Clear";
            btnClearFilter.Size = new Size(80, 32);
            btnClearFilter.Location = new Point(680, 13);
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

            // DataGridView
            dgvTeachers.Location = new Point(25, 190);
            dgvTeachers.Size = new Size(950, 420);
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

            dgvTeachers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            dgvTeachers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTeachers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvTeachers.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 5, 10, 5);
            dgvTeachers.ColumnHeadersHeight = 45;
            dgvTeachers.EnableHeadersVisualStyles = false;

            dgvTeachers.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvTeachers.DefaultCellStyle.Padding = new Padding(10, 5, 10, 5);
            dgvTeachers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgvTeachers.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvTeachers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);

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

            // Results count and select button
            lblResultsCount.Text = "Found 0 teacher(s)";
            lblResultsCount.Font = new Font("Segoe UI", 10);
            lblResultsCount.ForeColor = Color.FromArgb(127, 140, 141);
            lblResultsCount.Location = new Point(25, 620);
            lblResultsCount.AutoSize = true;

            btnSelectTeacher.Text = "📝 Select & Modify";
            btnSelectTeacher.Size = new Size(160, 42);
            btnSelectTeacher.Location = new Point(815, 615);
            btnSelectTeacher.BackColor = Color.FromArgb(41, 128, 185);
            btnSelectTeacher.ForeColor = Color.White;
            btnSelectTeacher.FlatStyle = FlatStyle.Flat;
            btnSelectTeacher.FlatAppearance.BorderSize = 0;
            btnSelectTeacher.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnSelectTeacher.Cursor = Cursors.Hand;

            // Add to search panel
            panelSearch.Controls.Add(panelSearchHeader);
            panelSearch.Controls.Add(panelSearchControls);
            panelSearch.Controls.Add(dgvTeachers);
            panelSearch.Controls.Add(lblResultsCount);
            panelSearch.Controls.Add(btnSelectTeacher);

            // ========================================
            // EDIT PANEL
            // ========================================
            panelEditForm.Dock = DockStyle.Fill;
            panelEditForm.BackColor = Color.FromArgb(236, 240, 241);
            panelEditForm.Visible = false;

            // Edit Header
            panelEditHeader.Dock = DockStyle.Top;
            panelEditHeader.Height = 100;
            panelEditHeader.BackColor = Color.FromArgb(39, 174, 96);
            panelEditHeader.Padding = new Padding(25, 15, 25, 15);

            lblEditTitle.Text = "✏️ Edit Teacher Details";
            lblEditTitle.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lblEditTitle.ForeColor = Color.White;
            lblEditTitle.Location = new Point(25, 18);
            lblEditTitle.AutoSize = true;

            lblEditSubtitle.Text = "Update the teacher's information below. Fields marked with * are required.";
            lblEditSubtitle.Font = new Font("Segoe UI", 10);
            lblEditSubtitle.ForeColor = Color.FromArgb(236, 240, 241);
            lblEditSubtitle.Location = new Point(27, 60);
            lblEditSubtitle.AutoSize = true;

            // Employee ID Badge
            panelEmployeeId.Size = new Size(200, 50);
            panelEmployeeId.Location = new Point(770, 25);
            panelEmployeeId.BackColor = Color.FromArgb(46, 204, 113);

            lblEmployeeIdLabel.Text = "Employee ID";
            lblEmployeeIdLabel.Font = new Font("Segoe UI", 9);
            lblEmployeeIdLabel.ForeColor = Color.FromArgb(214, 234, 248);
            lblEmployeeIdLabel.Location = new Point(10, 5);
            lblEmployeeIdLabel.AutoSize = true;

            lblEmployeeIdValue.Text = "EMP-2024-0001";
            lblEmployeeIdValue.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblEmployeeIdValue.ForeColor = Color.White;
            lblEmployeeIdValue.Location = new Point(10, 22);
            lblEmployeeIdValue.AutoSize = true;

            panelEmployeeId.Controls.Add(lblEmployeeIdLabel);
            panelEmployeeId.Controls.Add(lblEmployeeIdValue);

            panelEditHeader.Controls.Add(lblEditTitle);
            panelEditHeader.Controls.Add(lblEditSubtitle);
            panelEditHeader.Controls.Add(panelEmployeeId);

            // Edit Content Panel (Scrollable)
            panelEditContent.Location = new Point(20, 115);
            panelEditContent.Size = new Size(960, 510);
            panelEditContent.AutoScroll = true;
            panelEditContent.FlowDirection = FlowDirection.LeftToRight;
            panelEditContent.WrapContents = true;
            panelEditContent.BackColor = Color.FromArgb(236, 240, 241);

            // ========================================
            // Section 1: Personal Information
            // ========================================
            panelPersonalInfo.Size = new Size(465, 220);
            panelPersonalInfo.Margin = new Padding(5);
            panelPersonalInfo.BackColor = Color.White;
            panelPersonalInfo.Padding = new Padding(15);

            lblPersonalInfoHeader.Text = "📋 Personal Information";
            lblPersonalInfoHeader.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblPersonalInfoHeader.ForeColor = Color.FromArgb(44, 62, 80);
            lblPersonalInfoHeader.Location = new Point(15, 10);
            lblPersonalInfoHeader.AutoSize = true;

            lblName.Text = "Full Name *";
            lblName.Font = new Font("Segoe UI", 9);
            lblName.ForeColor = Color.FromArgb(52, 73, 94);
            lblName.Location = new Point(15, 45);
            lblName.AutoSize = true;

            txtName.Size = new Size(250, 28);
            txtName.Location = new Point(15, 65);
            txtName.Font = new Font("Segoe UI", 10);
            txtName.BorderStyle = BorderStyle.FixedSingle;

            lblNameValidation.Text = "";
            lblNameValidation.Font = new Font("Segoe UI", 8);
            lblNameValidation.Location = new Point(270, 70);
            lblNameValidation.AutoSize = true;

            lblGender.Text = "Gender *";
            lblGender.Font = new Font("Segoe UI", 9);
            lblGender.ForeColor = Color.FromArgb(52, 73, 94);
            lblGender.Location = new Point(320, 45);
            lblGender.AutoSize = true;

            cmbGender.Size = new Size(120, 28);
            cmbGender.Location = new Point(320, 65);
            cmbGender.Font = new Font("Segoe UI", 10);
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;

            lblDateOfBirth.Text = "Date of Birth *";
            lblDateOfBirth.Font = new Font("Segoe UI", 9);
            lblDateOfBirth.ForeColor = Color.FromArgb(52, 73, 94);
            lblDateOfBirth.Location = new Point(15, 105);
            lblDateOfBirth.AutoSize = true;

            dtpDateOfBirth.Size = new Size(180, 28);
            dtpDateOfBirth.Location = new Point(15, 125);
            dtpDateOfBirth.Font = new Font("Segoe UI", 10);
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;

            lblCNIC.Text = "CNIC Number *";
            lblCNIC.Font = new Font("Segoe UI", 9);
            lblCNIC.ForeColor = Color.FromArgb(52, 73, 94);
            lblCNIC.Location = new Point(210, 105);
            lblCNIC.AutoSize = true;

            txtCNIC.Size = new Size(180, 28);
            txtCNIC.Location = new Point(210, 125);
            txtCNIC.Font = new Font("Segoe UI", 10);
            txtCNIC.BorderStyle = BorderStyle.FixedSingle;
            txtCNIC.MaxLength = 15;

            lblCNICValidation.Text = "";
            lblCNICValidation.Font = new Font("Segoe UI", 8);
            lblCNICValidation.Location = new Point(15, 160);
            lblCNICValidation.AutoSize = true;

            panelPersonalInfo.Controls.Add(lblPersonalInfoHeader);
            panelPersonalInfo.Controls.Add(lblName);
            panelPersonalInfo.Controls.Add(txtName);
            panelPersonalInfo.Controls.Add(lblNameValidation);
            panelPersonalInfo.Controls.Add(lblGender);
            panelPersonalInfo.Controls.Add(cmbGender);
            panelPersonalInfo.Controls.Add(lblDateOfBirth);
            panelPersonalInfo.Controls.Add(dtpDateOfBirth);
            panelPersonalInfo.Controls.Add(lblCNIC);
            panelPersonalInfo.Controls.Add(txtCNIC);
            panelPersonalInfo.Controls.Add(lblCNICValidation);

            // ========================================
            // Section 2: Professional Information
            // ========================================
            panelProfessionalInfo.Size = new Size(465, 220);
            panelProfessionalInfo.Margin = new Padding(5);
            panelProfessionalInfo.BackColor = Color.White;
            panelProfessionalInfo.Padding = new Padding(15);

            lblProfessionalInfoHeader.Text = "🎓 Professional Information";
            lblProfessionalInfoHeader.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblProfessionalInfoHeader.ForeColor = Color.FromArgb(44, 62, 80);
            lblProfessionalInfoHeader.Location = new Point(15, 10);
            lblProfessionalInfoHeader.AutoSize = true;

            lblQualification.Text = "Qualification *";
            lblQualification.Font = new Font("Segoe UI", 9);
            lblQualification.ForeColor = Color.FromArgb(52, 73, 94);
            lblQualification.Location = new Point(15, 45);
            lblQualification.AutoSize = true;

            cmbQualification.Size = new Size(200, 28);
            cmbQualification.Location = new Point(15, 65);
            cmbQualification.Font = new Font("Segoe UI", 10);
            cmbQualification.DropDownStyle = ComboBoxStyle.DropDownList;

            lblDepartment.Text = "Department/Subject *";
            lblDepartment.Font = new Font("Segoe UI", 9);
            lblDepartment.ForeColor = Color.FromArgb(52, 73, 94);
            lblDepartment.Location = new Point(240, 45);
            lblDepartment.AutoSize = true;

            cmbDepartment.Size = new Size(200, 28);
            cmbDepartment.Location = new Point(240, 65);
            cmbDepartment.Font = new Font("Segoe UI", 10);
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;

            lblExperience.Text = "Experience *";
            lblExperience.Font = new Font("Segoe UI", 9);
            lblExperience.ForeColor = Color.FromArgb(52, 73, 94);
            lblExperience.Location = new Point(15, 105);
            lblExperience.AutoSize = true;

            cmbExperience.Size = new Size(150, 28);
            cmbExperience.Location = new Point(15, 125);
            cmbExperience.Font = new Font("Segoe UI", 10);
            cmbExperience.DropDownStyle = ComboBoxStyle.DropDownList;

            lblSkills.Text = "Special Skills/Certifications";
            lblSkills.Font = new Font("Segoe UI", 9);
            lblSkills.ForeColor = Color.FromArgb(52, 73, 94);
            lblSkills.Location = new Point(180, 105);
            lblSkills.AutoSize = true;

            txtSkills.Size = new Size(260, 60);
            txtSkills.Location = new Point(180, 125);
            txtSkills.Font = new Font("Segoe UI", 9);
            txtSkills.BorderStyle = BorderStyle.FixedSingle;
            txtSkills.Multiline = true;

            panelProfessionalInfo.Controls.Add(lblProfessionalInfoHeader);
            panelProfessionalInfo.Controls.Add(lblQualification);
            panelProfessionalInfo.Controls.Add(cmbQualification);
            panelProfessionalInfo.Controls.Add(lblDepartment);
            panelProfessionalInfo.Controls.Add(cmbDepartment);
            panelProfessionalInfo.Controls.Add(lblExperience);
            panelProfessionalInfo.Controls.Add(cmbExperience);
            panelProfessionalInfo.Controls.Add(lblSkills);
            panelProfessionalInfo.Controls.Add(txtSkills);

            // ========================================
            // Section 3: Contact Information
            // ========================================
            panelContactInfo.Size = new Size(465, 200);
            panelContactInfo.Margin = new Padding(5);
            panelContactInfo.BackColor = Color.White;
            panelContactInfo.Padding = new Padding(15);

            lblContactInfoHeader.Text = "📞 Contact Information";
            lblContactInfoHeader.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblContactInfoHeader.ForeColor = Color.FromArgb(44, 62, 80);
            lblContactInfoHeader.Location = new Point(15, 10);
            lblContactInfoHeader.AutoSize = true;

            lblContactNumber.Text = "Contact Number *";
            lblContactNumber.Font = new Font("Segoe UI", 9);
            lblContactNumber.ForeColor = Color.FromArgb(52, 73, 94);
            lblContactNumber.Location = new Point(15, 45);
            lblContactNumber.AutoSize = true;

            txtContactNumber.Size = new Size(180, 28);
            txtContactNumber.Location = new Point(15, 65);
            txtContactNumber.Font = new Font("Segoe UI", 10);
            txtContactNumber.BorderStyle = BorderStyle.FixedSingle;
            txtContactNumber.MaxLength = 15;

            lblContactValidation.Text = "";
            lblContactValidation.Font = new Font("Segoe UI", 8);
            lblContactValidation.Location = new Point(200, 70);
            lblContactValidation.AutoSize = true;

            lblEmail.Text = "Email Address";
            lblEmail.Font = new Font("Segoe UI", 9);
            lblEmail.ForeColor = Color.FromArgb(52, 73, 94);
            lblEmail.Location = new Point(240, 45);
            lblEmail.AutoSize = true;

            txtEmail.Size = new Size(200, 28);
            txtEmail.Location = new Point(240, 65);
            txtEmail.Font = new Font("Segoe UI", 10);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;

            lblEmailValidation.Text = "";
            lblEmailValidation.Font = new Font("Segoe UI", 8);
            lblEmailValidation.Location = new Point(240, 95);
            lblEmailValidation.AutoSize = true;

            lblAddress.Text = "Address *";
            lblAddress.Font = new Font("Segoe UI", 9);
            lblAddress.ForeColor = Color.FromArgb(52, 73, 94);
            lblAddress.Location = new Point(15, 105);
            lblAddress.AutoSize = true;

            txtAddress.Size = new Size(425, 60);
            txtAddress.Location = new Point(15, 125);
            txtAddress.Font = new Font("Segoe UI", 9);
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Multiline = true;

            panelContactInfo.Controls.Add(lblContactInfoHeader);
            panelContactInfo.Controls.Add(lblContactNumber);
            panelContactInfo.Controls.Add(txtContactNumber);
            panelContactInfo.Controls.Add(lblContactValidation);
            panelContactInfo.Controls.Add(lblEmail);
            panelContactInfo.Controls.Add(txtEmail);
            panelContactInfo.Controls.Add(lblEmailValidation);
            panelContactInfo.Controls.Add(lblAddress);
            panelContactInfo.Controls.Add(txtAddress);

            // ========================================
            // Section 4: Employment Details
            // ========================================
            panelEmploymentInfo.Size = new Size(465, 200);
            panelEmploymentInfo.Margin = new Padding(5);
            panelEmploymentInfo.BackColor = Color.White;
            panelEmploymentInfo.Padding = new Padding(15);

            lblEmploymentInfoHeader.Text = "💼 Employment Details";
            lblEmploymentInfoHeader.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblEmploymentInfoHeader.ForeColor = Color.FromArgb(44, 62, 80);
            lblEmploymentInfoHeader.Location = new Point(15, 10);
            lblEmploymentInfoHeader.AutoSize = true;

            lblJoiningDate.Text = "Date of Joining *";
            lblJoiningDate.Font = new Font("Segoe UI", 9);
            lblJoiningDate.ForeColor = Color.FromArgb(52, 73, 94);
            lblJoiningDate.Location = new Point(15, 45);
            lblJoiningDate.AutoSize = true;

            dtpJoiningDate.Size = new Size(180, 28);
            dtpJoiningDate.Location = new Point(15, 65);
            dtpJoiningDate.Font = new Font("Segoe UI", 10);
            dtpJoiningDate.Format = DateTimePickerFormat.Short;

            lblSalary.Text = "Monthly Salary (Rs.) *";
            lblSalary.Font = new Font("Segoe UI", 9);
            lblSalary.ForeColor = Color.FromArgb(52, 73, 94);
            lblSalary.Location = new Point(220, 45);
            lblSalary.AutoSize = true;

            txtSalary.Size = new Size(150, 28);
            txtSalary.Location = new Point(220, 65);
            txtSalary.Font = new Font("Segoe UI", 10);
            txtSalary.BorderStyle = BorderStyle.FixedSingle;
            txtSalary.TextAlign = HorizontalAlignment.Right;

            lblSalaryValidation.Text = "";
            lblSalaryValidation.Font = new Font("Segoe UI", 8);
            lblSalaryValidation.Location = new Point(375, 70);
            lblSalaryValidation.AutoSize = true;

            lblStatus.Text = "Employment Status *";
            lblStatus.Font = new Font("Segoe UI", 9);
            lblStatus.ForeColor = Color.FromArgb(52, 73, 94);
            lblStatus.Location = new Point(15, 105);
            lblStatus.AutoSize = true;

            cmbStatus.Size = new Size(180, 28);
            cmbStatus.Location = new Point(15, 125);
            cmbStatus.Font = new Font("Segoe UI", 10);
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            panelEmploymentInfo.Controls.Add(lblEmploymentInfoHeader);
            panelEmploymentInfo.Controls.Add(lblJoiningDate);
            panelEmploymentInfo.Controls.Add(dtpJoiningDate);
            panelEmploymentInfo.Controls.Add(lblSalary);
            panelEmploymentInfo.Controls.Add(txtSalary);
            panelEmploymentInfo.Controls.Add(lblSalaryValidation);
            panelEmploymentInfo.Controls.Add(lblStatus);
            panelEmploymentInfo.Controls.Add(cmbStatus);

            // ========================================
            // Section 5: Emergency Contact
            // ========================================
            panelEmergencyInfo.Size = new Size(940, 110);
            panelEmergencyInfo.Margin = new Padding(5);
            panelEmergencyInfo.BackColor = Color.White;
            panelEmergencyInfo.Padding = new Padding(15);

            lblEmergencyInfoHeader.Text = "🚨 Emergency Contact";
            lblEmergencyInfoHeader.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblEmergencyInfoHeader.ForeColor = Color.FromArgb(44, 62, 80);
            lblEmergencyInfoHeader.Location = new Point(15, 10);
            lblEmergencyInfoHeader.AutoSize = true;

            lblEmergencyName.Text = "Contact Person Name *";
            lblEmergencyName.Font = new Font("Segoe UI", 9);
            lblEmergencyName.ForeColor = Color.FromArgb(52, 73, 94);
            lblEmergencyName.Location = new Point(15, 45);
            lblEmergencyName.AutoSize = true;

            txtEmergencyName.Size = new Size(250, 28);
            txtEmergencyName.Location = new Point(15, 65);
            txtEmergencyName.Font = new Font("Segoe UI", 10);
            txtEmergencyName.BorderStyle = BorderStyle.FixedSingle;

            lblEmergencyContact.Text = "Emergency Contact Number *";
            lblEmergencyContact.Font = new Font("Segoe UI", 9);
            lblEmergencyContact.ForeColor = Color.FromArgb(52, 73, 94);
            lblEmergencyContact.Location = new Point(290, 45);
            lblEmergencyContact.AutoSize = true;

            txtEmergencyContact.Size = new Size(180, 28);
            txtEmergencyContact.Location = new Point(290, 65);
            txtEmergencyContact.Font = new Font("Segoe UI", 10);
            txtEmergencyContact.BorderStyle = BorderStyle.FixedSingle;
            txtEmergencyContact.MaxLength = 15;

            lblEmergencyValidation.Text = "";
            lblEmergencyValidation.Font = new Font("Segoe UI", 8);
            lblEmergencyValidation.Location = new Point(475, 70);
            lblEmergencyValidation.AutoSize = true;

            panelEmergencyInfo.Controls.Add(lblEmergencyInfoHeader);
            panelEmergencyInfo.Controls.Add(lblEmergencyName);
            panelEmergencyInfo.Controls.Add(txtEmergencyName);
            panelEmergencyInfo.Controls.Add(lblEmergencyContact);
            panelEmergencyInfo.Controls.Add(txtEmergencyContact);
            panelEmergencyInfo.Controls.Add(lblEmergencyValidation);

            // Add sections to content panel
            panelEditContent.Controls.Add(panelPersonalInfo);
            panelEditContent.Controls.Add(panelProfessionalInfo);
            panelEditContent.Controls.Add(panelContactInfo);
            panelEditContent.Controls.Add(panelEmploymentInfo);
            panelEditContent.Controls.Add(panelEmergencyInfo);

            // ========================================
            // Edit Buttons Panel
            // ========================================
            panelEditButtons.Dock = DockStyle.Bottom;
            panelEditButtons.Height = 70;
            panelEditButtons.BackColor = Color.FromArgb(236, 240, 241);
            panelEditButtons.Padding = new Padding(20, 15, 20, 15);

            btnBackToSearch.Text = "← Back to Search";
            btnBackToSearch.Size = new Size(150, 42);
            btnBackToSearch.Location = new Point(20, 14);
            btnBackToSearch.BackColor = Color.FromArgb(52, 73, 94);
            btnBackToSearch.ForeColor = Color.White;
            btnBackToSearch.FlatStyle = FlatStyle.Flat;
            btnBackToSearch.FlatAppearance.BorderSize = 0;
            btnBackToSearch.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnBackToSearch.Cursor = Cursors.Hand;

            btnUpdate.Text = "✓ Update Teacher";
            btnUpdate.Size = new Size(160, 42);
            btnUpdate.Location = new Point(700, 14);
            btnUpdate.BackColor = Color.FromArgb(39, 174, 96);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnUpdate.Cursor = Cursors.Hand;

            btnCancel.Text = "✕ Cancel";
            btnCancel.Size = new Size(120, 42);
            btnCancel.Location = new Point(870, 14);
            btnCancel.BackColor = Color.FromArgb(231, 76, 60);
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnCancel.Cursor = Cursors.Hand;

            panelEditButtons.Controls.Add(btnBackToSearch);
            panelEditButtons.Controls.Add(btnUpdate);
            panelEditButtons.Controls.Add(btnCancel);

            // Add to edit panel
            panelEditForm.Controls.Add(panelEditHeader);
            panelEditForm.Controls.Add(panelEditContent);
            panelEditForm.Controls.Add(panelEditButtons);

            // ========================================
            // Add panels to form
            // ========================================
            this.Controls.Add(panelSearch);
            this.Controls.Add(panelEditForm);

            // Resume layouts
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelSearchHeader.ResumeLayout(false);
            panelSearchHeader.PerformLayout();
            panelSearchControls.ResumeLayout(false);
            panelSearchControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).EndInit();
            panelEditForm.ResumeLayout(false);
            panelEditHeader.ResumeLayout(false);
            panelEditHeader.PerformLayout();
            panelEditContent.ResumeLayout(false);
            panelPersonalInfo.ResumeLayout(false);
            panelPersonalInfo.PerformLayout();
            panelProfessionalInfo.ResumeLayout(false);
            panelProfessionalInfo.PerformLayout();
            panelContactInfo.ResumeLayout(false);
            panelContactInfo.PerformLayout();
            panelEmploymentInfo.ResumeLayout(false);
            panelEmploymentInfo.PerformLayout();
            panelEmergencyInfo.ResumeLayout(false);
            panelEmergencyInfo.PerformLayout();
            panelEditButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // Search Panel
        private Panel panelSearch;
        private Panel panelSearchHeader;
        private Label lblSearchTitle;
        private Label lblSearchSubtitle;
        private Panel panelSearchControls;
        private Label lblSearchIcon;
        private TextBox txtSearch;
        private Label lblDepartmentFilter;
        private ComboBox cmbDepartmentFilter;
        private Button btnClearFilter;
        private DataGridView dgvTeachers;
        private DataGridViewTextBoxColumn colEmployeeId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colDepartment;
        private DataGridViewTextBoxColumn colQualification;
        private DataGridViewTextBoxColumn colContact;
        private DataGridViewTextBoxColumn colStatus;
        private Label lblResultsCount;
        private Button btnSelectTeacher;

        // Edit Panel
        private Panel panelEditForm;
        private Panel panelEditHeader;
        private Label lblEditTitle;
        private Label lblEditSubtitle;
        private Panel panelEmployeeId;
        private Label lblEmployeeIdLabel;
        private Label lblEmployeeIdValue;
        private FlowLayoutPanel panelEditContent;
        private Panel panelEditButtons;

        // Section panels
        private Panel panelPersonalInfo;
        private Panel panelProfessionalInfo;
        private Panel panelContactInfo;
        private Panel panelEmploymentInfo;
        private Panel panelEmergencyInfo;

        // Section headers
        private Label lblPersonalInfoHeader;
        private Label lblProfessionalInfoHeader;
        private Label lblContactInfoHeader;
        private Label lblEmploymentInfoHeader;
        private Label lblEmergencyInfoHeader;

        // Personal Information
        private Label lblName;
        private TextBox txtName;
        private Label lblNameValidation;
        private Label lblGender;
        private ComboBox cmbGender;
        private Label lblDateOfBirth;
        private DateTimePicker dtpDateOfBirth;
        private Label lblCNIC;
        private TextBox txtCNIC;
        private Label lblCNICValidation;

        // Professional Information
        private Label lblQualification;
        private ComboBox cmbQualification;
        private Label lblDepartment;
        private ComboBox cmbDepartment;
        private Label lblExperience;
        private ComboBox cmbExperience;
        private Label lblSkills;
        private TextBox txtSkills;

        // Contact Information
        private Label lblContactNumber;
        private TextBox txtContactNumber;
        private Label lblContactValidation;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblEmailValidation;
        private Label lblAddress;
        private TextBox txtAddress;

        // Employment Details
        private Label lblJoiningDate;
        private DateTimePicker dtpJoiningDate;
        private Label lblSalary;
        private TextBox txtSalary;
        private Label lblSalaryValidation;
        private Label lblStatus;
        private ComboBox cmbStatus;

        // Emergency Contact
        private Label lblEmergencyName;
        private TextBox txtEmergencyName;
        private Label lblEmergencyContact;
        private TextBox txtEmergencyContact;
        private Label lblEmergencyValidation;

        // Edit Buttons
        private Button btnBackToSearch;
        private Button btnUpdate;
        private Button btnCancel;
    }
}
