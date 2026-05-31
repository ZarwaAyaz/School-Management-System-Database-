namespace SchoolManagementSystem
{
    partial class AddTeacherForm
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
            // Main Panel with gradient-like effect
            panelMain = new Panel();
            panelHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            
            // Employee ID section
            panelEmployeeId = new Panel();
            lblEmployeeIdLabel = new Label();
            lblEmployeeIdValue = new Label();

            // Scrollable content panel
            panelContent = new FlowLayoutPanel();

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

            // Buttons Panel
            panelButtons = new Panel();
            btnSubmit = new Button();
            btnReset = new Button();
            btnCancel = new Button();

            panelMain.SuspendLayout();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            panelPersonalInfo.SuspendLayout();
            panelProfessionalInfo.SuspendLayout();
            panelContactInfo.SuspendLayout();
            panelEmploymentInfo.SuspendLayout();
            panelEmergencyInfo.SuspendLayout();
            panelButtons.SuspendLayout();
            this.SuspendLayout();

            // ========================================
            // Form Settings
            // ========================================
            this.ClientSize = new Size(950, 720);
            this.Text = "Add New Teacher";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.FromArgb(236, 240, 241);

            // ========================================
            // Main Panel
            // ========================================
            panelMain.Dock = DockStyle.Fill;
            panelMain.BackColor = Color.FromArgb(236, 240, 241);
            panelMain.Padding = new Padding(20);

            // ========================================
            // Header Panel
            // ========================================
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Height = 100;
            panelHeader.BackColor = Color.FromArgb(41, 128, 185);
            panelHeader.Padding = new Padding(25, 15, 25, 15);

            // Title Label
            lblTitle.Text = "👨‍🏫 Add New Teacher";
            lblTitle.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(25, 18);
            lblTitle.AutoSize = true;

            // Subtitle Label
            lblSubtitle.Text = "Enter the teacher's information below. Fields marked with * are required.";
            lblSubtitle.Font = new Font("Segoe UI", 10);
            lblSubtitle.ForeColor = Color.FromArgb(236, 240, 241);
            lblSubtitle.Location = new Point(27, 60);
            lblSubtitle.AutoSize = true;

            // Employee ID Panel
            panelEmployeeId.Size = new Size(200, 50);
            panelEmployeeId.Location = new Point(720, 25);
            panelEmployeeId.BackColor = Color.FromArgb(52, 152, 219);
            panelEmployeeId.BorderStyle = BorderStyle.None;

            lblEmployeeIdLabel.Text = "Employee ID";
            lblEmployeeIdLabel.Font = new Font("Segoe UI", 9);
            lblEmployeeIdLabel.ForeColor = Color.FromArgb(214, 234, 248);
            lblEmployeeIdLabel.Location = new Point(10, 5);
            lblEmployeeIdLabel.AutoSize = true;

            lblEmployeeIdValue.Text = "EMP-2025-0001";
            lblEmployeeIdValue.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblEmployeeIdValue.ForeColor = Color.White;
            lblEmployeeIdValue.Location = new Point(10, 22);
            lblEmployeeIdValue.AutoSize = true;

            panelEmployeeId.Controls.Add(lblEmployeeIdLabel);
            panelEmployeeId.Controls.Add(lblEmployeeIdValue);

            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(panelEmployeeId);

            // ========================================
            // Content Panel (Scrollable)
            // ========================================
            panelContent.Location = new Point(20, 120);
            panelContent.Size = new Size(910, 520);
            panelContent.AutoScroll = true;
            panelContent.FlowDirection = FlowDirection.LeftToRight;
            panelContent.WrapContents = true;
            panelContent.BackColor = Color.FromArgb(236, 240, 241);

            // ========================================
            // Section 1: Personal Information
            // ========================================
            panelPersonalInfo.Size = new Size(440, 230);
            panelPersonalInfo.Margin = new Padding(5);
            panelPersonalInfo.BackColor = Color.White;
            panelPersonalInfo.Padding = new Padding(15);

            lblPersonalInfoHeader.Text = "📋 Personal Information";
            lblPersonalInfoHeader.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblPersonalInfoHeader.ForeColor = Color.FromArgb(44, 62, 80);
            lblPersonalInfoHeader.Location = new Point(15, 10);
            lblPersonalInfoHeader.AutoSize = true;

            // Name
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

            // Gender
            lblGender.Text = "Gender *";
            lblGender.Font = new Font("Segoe UI", 9);
            lblGender.ForeColor = Color.FromArgb(52, 73, 94);
            lblGender.Location = new Point(300, 45);
            lblGender.AutoSize = true;

            cmbGender.Size = new Size(120, 28);
            cmbGender.Location = new Point(300, 65);
            cmbGender.Font = new Font("Segoe UI", 10);
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FlatStyle = FlatStyle.Flat;

            // Date of Birth
            lblDateOfBirth.Text = "Date of Birth *";
            lblDateOfBirth.Font = new Font("Segoe UI", 9);
            lblDateOfBirth.ForeColor = Color.FromArgb(52, 73, 94);
            lblDateOfBirth.Location = new Point(15, 105);
            lblDateOfBirth.AutoSize = true;

            dtpDateOfBirth.Size = new Size(180, 28);
            dtpDateOfBirth.Location = new Point(15, 125);
            dtpDateOfBirth.Font = new Font("Segoe UI", 10);
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;

            // CNIC
            lblCNIC.Text = "CNIC Number *";
            lblCNIC.Font = new Font("Segoe UI", 9);
            lblCNIC.ForeColor = Color.FromArgb(52, 73, 94);
            lblCNIC.Location = new Point(210, 105);
            lblCNIC.AutoSize = true;

            txtCNIC.Size = new Size(170, 28);
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
            panelProfessionalInfo.Size = new Size(440, 230);
            panelProfessionalInfo.Margin = new Padding(5);
            panelProfessionalInfo.BackColor = Color.White;
            panelProfessionalInfo.Padding = new Padding(15);

            lblProfessionalInfoHeader.Text = "🎓 Professional Information";
            lblProfessionalInfoHeader.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblProfessionalInfoHeader.ForeColor = Color.FromArgb(44, 62, 80);
            lblProfessionalInfoHeader.Location = new Point(15, 10);
            lblProfessionalInfoHeader.AutoSize = true;

            // Qualification
            lblQualification.Text = "Qualification *";
            lblQualification.Font = new Font("Segoe UI", 9);
            lblQualification.ForeColor = Color.FromArgb(52, 73, 94);
            lblQualification.Location = new Point(15, 45);
            lblQualification.AutoSize = true;

            cmbQualification.Size = new Size(200, 28);
            cmbQualification.Location = new Point(15, 65);
            cmbQualification.Font = new Font("Segoe UI", 10);
            cmbQualification.DropDownStyle = ComboBoxStyle.DropDownList;

            // Department
            lblDepartment.Text = "Department/Subject *";
            lblDepartment.Font = new Font("Segoe UI", 9);
            lblDepartment.ForeColor = Color.FromArgb(52, 73, 94);
            lblDepartment.Location = new Point(230, 45);
            lblDepartment.AutoSize = true;

            cmbDepartment.Size = new Size(190, 28);
            cmbDepartment.Location = new Point(230, 65);
            cmbDepartment.Font = new Font("Segoe UI", 10);
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;

            // Experience
            lblExperience.Text = "Experience *";
            lblExperience.Font = new Font("Segoe UI", 9);
            lblExperience.ForeColor = Color.FromArgb(52, 73, 94);
            lblExperience.Location = new Point(15, 105);
            lblExperience.AutoSize = true;

            cmbExperience.Size = new Size(150, 28);
            cmbExperience.Location = new Point(15, 125);
            cmbExperience.Font = new Font("Segoe UI", 10);
            cmbExperience.DropDownStyle = ComboBoxStyle.DropDownList;

            // Skills/Certifications
            lblSkills.Text = "Special Skills/Certifications";
            lblSkills.Font = new Font("Segoe UI", 9);
            lblSkills.ForeColor = Color.FromArgb(52, 73, 94);
            lblSkills.Location = new Point(180, 105);
            lblSkills.AutoSize = true;

            txtSkills.Size = new Size(240, 60);
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
            panelContactInfo.Size = new Size(440, 200);
            panelContactInfo.Margin = new Padding(5);
            panelContactInfo.BackColor = Color.White;
            panelContactInfo.Padding = new Padding(15);

            lblContactInfoHeader.Text = "📞 Contact Information";
            lblContactInfoHeader.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblContactInfoHeader.ForeColor = Color.FromArgb(44, 62, 80);
            lblContactInfoHeader.Location = new Point(15, 10);
            lblContactInfoHeader.AutoSize = true;

            // Contact Number
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

            // Email
            lblEmail.Text = "Email Address";
            lblEmail.Font = new Font("Segoe UI", 9);
            lblEmail.ForeColor = Color.FromArgb(52, 73, 94);
            lblEmail.Location = new Point(230, 45);
            lblEmail.AutoSize = true;

            txtEmail.Size = new Size(190, 28);
            txtEmail.Location = new Point(230, 65);
            txtEmail.Font = new Font("Segoe UI", 10);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;

            lblEmailValidation.Text = "";
            lblEmailValidation.Font = new Font("Segoe UI", 8);
            lblEmailValidation.Location = new Point(230, 95);
            lblEmailValidation.AutoSize = true;

            // Address
            lblAddress.Text = "Address *";
            lblAddress.Font = new Font("Segoe UI", 9);
            lblAddress.ForeColor = Color.FromArgb(52, 73, 94);
            lblAddress.Location = new Point(15, 105);
            lblAddress.AutoSize = true;

            txtAddress.Size = new Size(405, 60);
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
            panelEmploymentInfo.Size = new Size(440, 200);
            panelEmploymentInfo.Margin = new Padding(5);
            panelEmploymentInfo.BackColor = Color.White;
            panelEmploymentInfo.Padding = new Padding(15);

            lblEmploymentInfoHeader.Text = "💼 Employment Details";
            lblEmploymentInfoHeader.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblEmploymentInfoHeader.ForeColor = Color.FromArgb(44, 62, 80);
            lblEmploymentInfoHeader.Location = new Point(15, 10);
            lblEmploymentInfoHeader.AutoSize = true;

            // Date of Joining
            lblJoiningDate.Text = "Date of Joining *";
            lblJoiningDate.Font = new Font("Segoe UI", 9);
            lblJoiningDate.ForeColor = Color.FromArgb(52, 73, 94);
            lblJoiningDate.Location = new Point(15, 45);
            lblJoiningDate.AutoSize = true;

            dtpJoiningDate.Size = new Size(180, 28);
            dtpJoiningDate.Location = new Point(15, 65);
            dtpJoiningDate.Font = new Font("Segoe UI", 10);
            dtpJoiningDate.Format = DateTimePickerFormat.Short;

            // Salary
            lblSalary.Text = "Monthly Salary (Rs.) *";
            lblSalary.Font = new Font("Segoe UI", 9);
            lblSalary.ForeColor = Color.FromArgb(52, 73, 94);
            lblSalary.Location = new Point(210, 45);
            lblSalary.AutoSize = true;

            txtSalary.Size = new Size(150, 28);
            txtSalary.Location = new Point(210, 65);
            txtSalary.Font = new Font("Segoe UI", 10);
            txtSalary.BorderStyle = BorderStyle.FixedSingle;
            txtSalary.TextAlign = HorizontalAlignment.Right;

            lblSalaryValidation.Text = "";
            lblSalaryValidation.Font = new Font("Segoe UI", 8);
            lblSalaryValidation.Location = new Point(365, 70);
            lblSalaryValidation.AutoSize = true;

            // Status
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
            panelEmergencyInfo.Size = new Size(890, 120);
            panelEmergencyInfo.Margin = new Padding(5);
            panelEmergencyInfo.BackColor = Color.White;
            panelEmergencyInfo.Padding = new Padding(15);

            lblEmergencyInfoHeader.Text = "🚨 Emergency Contact";
            lblEmergencyInfoHeader.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblEmergencyInfoHeader.ForeColor = Color.FromArgb(44, 62, 80);
            lblEmergencyInfoHeader.Location = new Point(15, 10);
            lblEmergencyInfoHeader.AutoSize = true;

            // Emergency Contact Name
            lblEmergencyName.Text = "Contact Person Name *";
            lblEmergencyName.Font = new Font("Segoe UI", 9);
            lblEmergencyName.ForeColor = Color.FromArgb(52, 73, 94);
            lblEmergencyName.Location = new Point(15, 45);
            lblEmergencyName.AutoSize = true;

            txtEmergencyName.Size = new Size(250, 28);
            txtEmergencyName.Location = new Point(15, 65);
            txtEmergencyName.Font = new Font("Segoe UI", 10);
            txtEmergencyName.BorderStyle = BorderStyle.FixedSingle;

            // Emergency Contact Number
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
            panelContent.Controls.Add(panelPersonalInfo);
            panelContent.Controls.Add(panelProfessionalInfo);
            panelContent.Controls.Add(panelContactInfo);
            panelContent.Controls.Add(panelEmploymentInfo);
            panelContent.Controls.Add(panelEmergencyInfo);

            // ========================================
            // Buttons Panel
            // ========================================
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Height = 70;
            panelButtons.BackColor = Color.FromArgb(236, 240, 241);
            panelButtons.Padding = new Padding(20, 15, 20, 15);

            // Submit Button
            btnSubmit.Text = "✓  Add Teacher";
            btnSubmit.Size = new Size(160, 42);
            btnSubmit.Location = new Point(550, 14);
            btnSubmit.BackColor = Color.FromArgb(39, 174, 96);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnSubmit.Cursor = Cursors.Hand;

            // Reset Button
            btnReset.Text = "↺  Reset";
            btnReset.Size = new Size(120, 42);
            btnReset.Location = new Point(720, 14);
            btnReset.BackColor = Color.FromArgb(52, 73, 94);
            btnReset.ForeColor = Color.White;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnReset.Cursor = Cursors.Hand;

            // Cancel Button
            btnCancel.Text = "✕  Cancel";
            btnCancel.Size = new Size(120, 42);
            btnCancel.Location = new Point(850, 14);
            btnCancel.BackColor = Color.FromArgb(231, 76, 60);
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnCancel.Cursor = Cursors.Hand;

            panelButtons.Controls.Add(btnSubmit);
            panelButtons.Controls.Add(btnReset);
            panelButtons.Controls.Add(btnCancel);

            // ========================================
            // Add all to main panel and form
            // ========================================
            panelMain.Controls.Add(panelHeader);
            panelMain.Controls.Add(panelContent);
            panelMain.Controls.Add(panelButtons);
            this.Controls.Add(panelMain);

            panelMain.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
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
            panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // Main containers
        private Panel panelMain;
        private Panel panelHeader;
        private FlowLayoutPanel panelContent;
        private Panel panelButtons;

        // Header controls
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel panelEmployeeId;
        private Label lblEmployeeIdLabel;
        private Label lblEmployeeIdValue;

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

        // Buttons
        private Button btnSubmit;
        private Button btnReset;
        private Button btnCancel;
    }
}
