namespace SchoolManagementSystem
{
    partial class AddStudentForm
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
            this.panelClassSelection = new Panel();
            this.lblSelectClassTitle = new Label();
            this.lblSelectClassSubtitle = new Label();
            this.panelClassDropdown = new Panel();
            this.lblClassLabel = new Label();
            this.cmbClassSelection = new ComboBox();
            this.btnSelectClass = new Button();
            this.btnCancelSelection = new Button();

            this.panelAdmissionForm = new Panel();
            this.panelFormHeader = new Panel();
            this.lblFormTitle = new Label();
            this.panelAdmissionNumber = new Panel();
            this.lblAdmissionNumberLabel = new Label();
            this.lblAdmissionNumberValue = new Label();
            
            this.panelFormContent = new Panel();
            
            // Student Details Section
            this.panelStudentDetails = new Panel();
            this.lblStudentDetailsHeader = new Label();
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

            // Fee & Scholarship Section
            this.panelFeeSection = new Panel();
            this.lblFeeHeader = new Label();
            this.panelScholarship = new Panel();
            this.lblScholarshipHeader = new Label();
            this.chkKinshipScholarship = new CheckBox();
            this.chkParentTeacher = new CheckBox();
            this.lblScholarshipStatus = new Label();
            this.panelFeeDetails = new Panel();
            this.lblMonthlyFeeLabel = new Label();
            this.lblMonthlyFeeValue = new Label();
            this.lblAdmissionFeeLabel = new Label();
            this.lblAdmissionFeeValue = new Label();
            this.lblExamFeeLabel = new Label();
            this.lblExamFeeValue = new Label();
            this.lblAnnualChargesLabel = new Label();
            this.lblAnnualChargesValue = new Label();
            this.lblDiscountLabel = new Label();
            this.lblDiscountValue = new Label();
            this.lblDiscountedMonthlyLabel = new Label();
            this.lblDiscountedMonthlyValue = new Label();
            this.panelTotalPayment = new Panel();
            this.lblTotalFirstPaymentLabel = new Label();
            this.lblTotalFirstPaymentValue = new Label();
            
            // Buttons
            this.panelFormButtons = new Panel();
            this.btnBackToClassSelection = new Button();
            this.btnSubmitAdmission = new Button();
            this.btnCancelAdmission = new Button();

            // Suspend Layout
            this.panelClassSelection.SuspendLayout();
            this.panelClassDropdown.SuspendLayout();
            this.panelAdmissionForm.SuspendLayout();
            this.panelFormHeader.SuspendLayout();
            this.panelAdmissionNumber.SuspendLayout();
            this.panelFormContent.SuspendLayout();
            this.panelStudentDetails.SuspendLayout();
            this.panelFeeSection.SuspendLayout();
            this.panelScholarship.SuspendLayout();
            this.panelFeeDetails.SuspendLayout();
            this.panelTotalPayment.SuspendLayout();
            this.panelFormButtons.SuspendLayout();
            this.SuspendLayout();

            // =============================================
            // PANEL CLASS SELECTION
            // =============================================
            this.panelClassSelection.BackColor = Color.FromArgb(236, 240, 241);
            this.panelClassSelection.Controls.Add(this.lblSelectClassTitle);
            this.panelClassSelection.Controls.Add(this.lblSelectClassSubtitle);
            this.panelClassSelection.Controls.Add(this.panelClassDropdown);
            this.panelClassSelection.Controls.Add(this.btnSelectClass);
            this.panelClassSelection.Controls.Add(this.btnCancelSelection);
            this.panelClassSelection.Dock = DockStyle.Fill;
            this.panelClassSelection.Location = new Point(0, 0);
            this.panelClassSelection.Name = "panelClassSelection";
            this.panelClassSelection.Size = new Size(1100, 750);

            // lblSelectClassTitle
            this.lblSelectClassTitle.AutoSize = true;
            this.lblSelectClassTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            this.lblSelectClassTitle.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblSelectClassTitle.Location = new Point(400, 150);
            this.lblSelectClassTitle.Name = "lblSelectClassTitle";
            this.lblSelectClassTitle.Size = new Size(300, 45);
            this.lblSelectClassTitle.Text = "Student Admission";

            // lblSelectClassSubtitle
            this.lblSelectClassSubtitle.AutoSize = true;
            this.lblSelectClassSubtitle.Font = new Font("Segoe UI", 12F);
            this.lblSelectClassSubtitle.ForeColor = Color.FromArgb(127, 140, 141);
            this.lblSelectClassSubtitle.Location = new Point(395, 205);
            this.lblSelectClassSubtitle.Name = "lblSelectClassSubtitle";
            this.lblSelectClassSubtitle.Size = new Size(310, 21);
            this.lblSelectClassSubtitle.Text = "Please select the class for new admission";

            // panelClassDropdown
            this.panelClassDropdown.BackColor = Color.White;
            this.panelClassDropdown.Controls.Add(this.lblClassLabel);
            this.panelClassDropdown.Controls.Add(this.cmbClassSelection);
            this.panelClassDropdown.Location = new Point(350, 270);
            this.panelClassDropdown.Name = "panelClassDropdown";
            this.panelClassDropdown.Padding = new Padding(30);
            this.panelClassDropdown.Size = new Size(400, 150);

            // lblClassLabel
            this.lblClassLabel.AutoSize = true;
            this.lblClassLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblClassLabel.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblClassLabel.Location = new Point(30, 30);
            this.lblClassLabel.Name = "lblClassLabel";
            this.lblClassLabel.Size = new Size(120, 20);
            this.lblClassLabel.Text = "Select Class *";

            // cmbClassSelection
            this.cmbClassSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbClassSelection.Font = new Font("Segoe UI", 12F);
            this.cmbClassSelection.Location = new Point(30, 60);
            this.cmbClassSelection.Name = "cmbClassSelection";
            this.cmbClassSelection.Size = new Size(340, 29);
            this.cmbClassSelection.Items.AddRange(new object[] {
                "Nursery", "Prep", "Class 1", "Class 2", "Class 3", "Class 4",
                "Class 5", "Class 6", "Class 7", "Class 8", "Class 9", "Class 10"
            });

            // btnSelectClass
            this.btnSelectClass.BackColor = Color.FromArgb(39, 174, 96);
            this.btnSelectClass.Cursor = Cursors.Hand;
            this.btnSelectClass.FlatAppearance.BorderSize = 0;
            this.btnSelectClass.FlatStyle = FlatStyle.Flat;
            this.btnSelectClass.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnSelectClass.ForeColor = Color.White;
            this.btnSelectClass.Location = new Point(350, 450);
            this.btnSelectClass.Name = "btnSelectClass";
            this.btnSelectClass.Size = new Size(190, 50);
            this.btnSelectClass.Text = "Continue →";

            // btnCancelSelection
            this.btnCancelSelection.BackColor = Color.FromArgb(149, 165, 166);
            this.btnCancelSelection.Cursor = Cursors.Hand;
            this.btnCancelSelection.FlatAppearance.BorderSize = 0;
            this.btnCancelSelection.FlatStyle = FlatStyle.Flat;
            this.btnCancelSelection.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnCancelSelection.ForeColor = Color.White;
            this.btnCancelSelection.Location = new Point(560, 450);
            this.btnCancelSelection.Name = "btnCancelSelection";
            this.btnCancelSelection.Size = new Size(190, 50);
            this.btnCancelSelection.Text = "Cancel";

            // =============================================
            // PANEL ADMISSION FORM
            // =============================================
            this.panelAdmissionForm.BackColor = Color.FromArgb(236, 240, 241);
            this.panelAdmissionForm.Controls.Add(this.panelFormHeader);
            this.panelAdmissionForm.Controls.Add(this.panelFormContent);
            this.panelAdmissionForm.Controls.Add(this.panelFormButtons);
            this.panelAdmissionForm.Dock = DockStyle.Fill;
            this.panelAdmissionForm.Location = new Point(0, 0);
            this.panelAdmissionForm.Name = "panelAdmissionForm";
            this.panelAdmissionForm.Size = new Size(1100, 750);
            this.panelAdmissionForm.Visible = false;

            // =============================================
            // FORM HEADER
            // =============================================
            this.panelFormHeader.BackColor = Color.FromArgb(41, 128, 185);
            this.panelFormHeader.Controls.Add(this.lblFormTitle);
            this.panelFormHeader.Controls.Add(this.panelAdmissionNumber);
            this.panelFormHeader.Dock = DockStyle.Top;
            this.panelFormHeader.Location = new Point(0, 0);
            this.panelFormHeader.Name = "panelFormHeader";
            this.panelFormHeader.Size = new Size(1100, 80);

            // lblFormTitle
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblFormTitle.ForeColor = Color.White;
            this.lblFormTitle.Location = new Point(25, 22);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new Size(280, 32);
            this.lblFormTitle.Text = "New Student Admission";

            // panelAdmissionNumber
            this.panelAdmissionNumber.BackColor = Color.FromArgb(52, 152, 219);
            this.panelAdmissionNumber.Controls.Add(this.lblAdmissionNumberLabel);
            this.panelAdmissionNumber.Controls.Add(this.lblAdmissionNumberValue);
            this.panelAdmissionNumber.Location = new Point(820, 12);
            this.panelAdmissionNumber.Name = "panelAdmissionNumber";
            this.panelAdmissionNumber.Size = new Size(250, 55);

            // lblAdmissionNumberLabel
            this.lblAdmissionNumberLabel.AutoSize = true;
            this.lblAdmissionNumberLabel.Font = new Font("Segoe UI", 8F);
            this.lblAdmissionNumberLabel.ForeColor = Color.FromArgb(214, 234, 248);
            this.lblAdmissionNumberLabel.Location = new Point(12, 6);
            this.lblAdmissionNumberLabel.Name = "lblAdmissionNumberLabel";
            this.lblAdmissionNumberLabel.Size = new Size(110, 13);
            this.lblAdmissionNumberLabel.Text = "ADMISSION NUMBER";

            // lblAdmissionNumberValue
            this.lblAdmissionNumberValue.AutoSize = true;
            this.lblAdmissionNumberValue.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            this.lblAdmissionNumberValue.ForeColor = Color.White;
            this.lblAdmissionNumberValue.Location = new Point(12, 24);
            this.lblAdmissionNumberValue.Name = "lblAdmissionNumberValue";
            this.lblAdmissionNumberValue.Size = new Size(160, 25);
            this.lblAdmissionNumberValue.Text = "ADM-2025-1001";

            // =============================================
            // FORM CONTENT (Two Columns)
            // =============================================
            this.panelFormContent.AutoScroll = true;
            this.panelFormContent.BackColor = Color.FromArgb(236, 240, 241);
            this.panelFormContent.Controls.Add(this.panelStudentDetails);
            this.panelFormContent.Controls.Add(this.panelFeeSection);
            this.panelFormContent.Location = new Point(0, 80);
            this.panelFormContent.Name = "panelFormContent";
            this.panelFormContent.Size = new Size(1100, 590);

            // =============================================
            // STUDENT DETAILS SECTION (Left Column)
            // =============================================
            this.panelStudentDetails.BackColor = Color.White;
            this.panelStudentDetails.Controls.Add(this.lblStudentDetailsHeader);
            this.panelStudentDetails.Controls.Add(this.lblStudentName);
            this.panelStudentDetails.Controls.Add(this.txtStudentName);
            this.panelStudentDetails.Controls.Add(this.lblFatherName);
            this.panelStudentDetails.Controls.Add(this.txtFatherName);
            this.panelStudentDetails.Controls.Add(this.lblDateOfBirth);
            this.panelStudentDetails.Controls.Add(this.dtpDateOfBirth);
            this.panelStudentDetails.Controls.Add(this.lblGender);
            this.panelStudentDetails.Controls.Add(this.cmbGender);
            this.panelStudentDetails.Controls.Add(this.lblAddress);
            this.panelStudentDetails.Controls.Add(this.txtAddress);
            this.panelStudentDetails.Controls.Add(this.lblContactNumber);
            this.panelStudentDetails.Controls.Add(this.txtContactNumber);
            this.panelStudentDetails.Controls.Add(this.lblEmergencyContact);
            this.panelStudentDetails.Controls.Add(this.txtEmergencyContact);
            this.panelStudentDetails.Controls.Add(this.lblPreviousSchool);
            this.panelStudentDetails.Controls.Add(this.txtPreviousSchool);
            this.panelStudentDetails.Controls.Add(this.lblAdmissionDate);
            this.panelStudentDetails.Controls.Add(this.dtpAdmissionDate);
            this.panelStudentDetails.Controls.Add(this.lblClass);
            this.panelStudentDetails.Controls.Add(this.cmbClass);
            this.panelStudentDetails.Location = new Point(15, 10);
            this.panelStudentDetails.Name = "panelStudentDetails";
            this.panelStudentDetails.Size = new Size(700, 565);

            // lblStudentDetailsHeader
            this.lblStudentDetailsHeader.BackColor = Color.FromArgb(52, 73, 94);
            this.lblStudentDetailsHeader.Dock = DockStyle.Top;
            this.lblStudentDetailsHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblStudentDetailsHeader.ForeColor = Color.White;
            this.lblStudentDetailsHeader.Location = new Point(0, 0);
            this.lblStudentDetailsHeader.Name = "lblStudentDetailsHeader";
            this.lblStudentDetailsHeader.Padding = new Padding(15, 0, 0, 0);
            this.lblStudentDetailsHeader.Size = new Size(700, 40);
            this.lblStudentDetailsHeader.Text = "📋 Student Details";
            this.lblStudentDetailsHeader.TextAlign = ContentAlignment.MiddleLeft;

            // Layout for student details
            int labelY = 55;
            int inputY = 78;
            int rowHeight = 65;
            int col1X = 20;
            int col2X = 360;
            int inputWidth = 310;
            int inputHeight = 32;

            // Row 1: Student Name & Father Name
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblStudentName.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblStudentName.Location = new Point(col1X, labelY);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Text = "Student Name *";

            this.txtStudentName.BorderStyle = BorderStyle.FixedSingle;
            this.txtStudentName.Font = new Font("Segoe UI", 10F);
            this.txtStudentName.Location = new Point(col1X, inputY);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new Size(inputWidth, inputHeight);

            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblFatherName.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblFatherName.Location = new Point(col2X, labelY);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Text = "Father/Guardian Name *";

            this.txtFatherName.BorderStyle = BorderStyle.FixedSingle;
            this.txtFatherName.Font = new Font("Segoe UI", 10F);
            this.txtFatherName.Location = new Point(col2X, inputY);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new Size(inputWidth, inputHeight);

            // Row 2: Date of Birth & Gender
            labelY += rowHeight;
            inputY += rowHeight;

            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblDateOfBirth.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblDateOfBirth.Location = new Point(col1X, labelY);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Text = "Date of Birth *";

            this.dtpDateOfBirth.Font = new Font("Segoe UI", 10F);
            this.dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new Point(col1X, inputY);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new Size(inputWidth, inputHeight);

            this.lblGender.AutoSize = true;
            this.lblGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblGender.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblGender.Location = new Point(col2X, labelY);
            this.lblGender.Name = "lblGender";
            this.lblGender.Text = "Gender *";

            this.cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new Font("Segoe UI", 10F);
            this.cmbGender.Location = new Point(col2X, inputY);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new Size(inputWidth, inputHeight);
            this.cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });

            // Row 3: Address (Full Width)
            labelY += rowHeight;
            inputY += rowHeight;

            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblAddress.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblAddress.Location = new Point(col1X, labelY);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Text = "Address *";

            this.txtAddress.BorderStyle = BorderStyle.FixedSingle;
            this.txtAddress.Font = new Font("Segoe UI", 10F);
            this.txtAddress.Location = new Point(col1X, inputY);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new Size(650, 45);

            // Row 4: Contact Number & Emergency Contact
            labelY += rowHeight + 15;
            inputY += rowHeight + 15;

            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblContactNumber.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblContactNumber.Location = new Point(col1X, labelY);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Text = "Contact Number *";

            this.txtContactNumber.BorderStyle = BorderStyle.FixedSingle;
            this.txtContactNumber.Font = new Font("Segoe UI", 10F);
            this.txtContactNumber.Location = new Point(col1X, inputY);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new Size(inputWidth, inputHeight);

            this.lblEmergencyContact.AutoSize = true;
            this.lblEmergencyContact.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblEmergencyContact.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblEmergencyContact.Location = new Point(col2X, labelY);
            this.lblEmergencyContact.Name = "lblEmergencyContact";
            this.lblEmergencyContact.Text = "Emergency Contact *";

            this.txtEmergencyContact.BorderStyle = BorderStyle.FixedSingle;
            this.txtEmergencyContact.Font = new Font("Segoe UI", 10F);
            this.txtEmergencyContact.Location = new Point(col2X, inputY);
            this.txtEmergencyContact.Name = "txtEmergencyContact";
            this.txtEmergencyContact.Size = new Size(inputWidth, inputHeight);

            // Row 5: Previous School
            labelY += rowHeight;
            inputY += rowHeight;

            this.lblPreviousSchool.AutoSize = true;
            this.lblPreviousSchool.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblPreviousSchool.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblPreviousSchool.Location = new Point(col1X, labelY);
            this.lblPreviousSchool.Name = "lblPreviousSchool";
            this.lblPreviousSchool.Text = "Previous School (Optional)";

            this.txtPreviousSchool.BorderStyle = BorderStyle.FixedSingle;
            this.txtPreviousSchool.Font = new Font("Segoe UI", 10F);
            this.txtPreviousSchool.Location = new Point(col1X, inputY);
            this.txtPreviousSchool.Name = "txtPreviousSchool";
            this.txtPreviousSchool.Size = new Size(650, inputHeight);

            // Row 6: Admission Date & Class
            labelY += rowHeight;
            inputY += rowHeight;

            this.lblAdmissionDate.AutoSize = true;
            this.lblAdmissionDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblAdmissionDate.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblAdmissionDate.Location = new Point(col1X, labelY);
            this.lblAdmissionDate.Name = "lblAdmissionDate";
            this.lblAdmissionDate.Text = "Admission Date *";

            this.dtpAdmissionDate.Font = new Font("Segoe UI", 10F);
            this.dtpAdmissionDate.Format = DateTimePickerFormat.Short;
            this.dtpAdmissionDate.Location = new Point(col1X, inputY);
            this.dtpAdmissionDate.Name = "dtpAdmissionDate";
            this.dtpAdmissionDate.Size = new Size(inputWidth, inputHeight);

            this.lblClass.AutoSize = true;
            this.lblClass.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblClass.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblClass.Location = new Point(col2X, labelY);
            this.lblClass.Name = "lblClass";
            this.lblClass.Text = "Class (Pre-selected)";

            this.cmbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbClass.Font = new Font("Segoe UI", 10F);
            this.cmbClass.Location = new Point(col2X, inputY);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new Size(inputWidth, inputHeight);
            this.cmbClass.Enabled = false;
            this.cmbClass.Items.AddRange(new object[] {
                "Nursery", "Prep", "Class 1", "Class 2", "Class 3", "Class 4",
                "Class 5", "Class 6", "Class 7", "Class 8", "Class 9", "Class 10"
            });

            // =============================================
            // FEE SECTION (Right Column)
            // =============================================
            this.panelFeeSection.BackColor = Color.White;
            this.panelFeeSection.Controls.Add(this.lblFeeHeader);
            this.panelFeeSection.Controls.Add(this.panelScholarship);
            this.panelFeeSection.Controls.Add(this.panelFeeDetails);
            this.panelFeeSection.Controls.Add(this.panelTotalPayment);
            this.panelFeeSection.Location = new Point(730, 10);
            this.panelFeeSection.Name = "panelFeeSection";
            this.panelFeeSection.Size = new Size(350, 565);

            // lblFeeHeader
            this.lblFeeHeader.BackColor = Color.FromArgb(39, 174, 96);
            this.lblFeeHeader.Dock = DockStyle.Top;
            this.lblFeeHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblFeeHeader.ForeColor = Color.White;
            this.lblFeeHeader.Location = new Point(0, 0);
            this.lblFeeHeader.Name = "lblFeeHeader";
            this.lblFeeHeader.Padding = new Padding(15, 0, 0, 0);
            this.lblFeeHeader.Size = new Size(350, 40);
            this.lblFeeHeader.Text = "💰 Fee & Scholarship";
            this.lblFeeHeader.TextAlign = ContentAlignment.MiddleLeft;

            // =============================================
            // SCHOLARSHIP PANEL
            // =============================================
            this.panelScholarship.BackColor = Color.FromArgb(250, 250, 250);
            this.panelScholarship.Controls.Add(this.lblScholarshipHeader);
            this.panelScholarship.Controls.Add(this.chkKinshipScholarship);
            this.panelScholarship.Controls.Add(this.chkParentTeacher);
            this.panelScholarship.Controls.Add(this.lblScholarshipStatus);
            this.panelScholarship.Location = new Point(15, 55);
            this.panelScholarship.Name = "panelScholarship";
            this.panelScholarship.Size = new Size(320, 150);

            // lblScholarshipHeader
            this.lblScholarshipHeader.AutoSize = true;
            this.lblScholarshipHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblScholarshipHeader.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblScholarshipHeader.Location = new Point(10, 10);
            this.lblScholarshipHeader.Name = "lblScholarshipHeader";
            this.lblScholarshipHeader.Text = "🎓 Scholarship Options (20% Discount)";

            // chkKinshipScholarship
            this.chkKinshipScholarship.AutoSize = true;
            this.chkKinshipScholarship.Font = new Font("Segoe UI", 10F);
            this.chkKinshipScholarship.ForeColor = Color.FromArgb(44, 62, 80);
            this.chkKinshipScholarship.Location = new Point(15, 45);
            this.chkKinshipScholarship.Name = "chkKinshipScholarship";
            this.chkKinshipScholarship.Size = new Size(200, 23);
            this.chkKinshipScholarship.Text = "Kinship (Sibling already enrolled)";

            // chkParentTeacher
            this.chkParentTeacher.AutoSize = true;
            this.chkParentTeacher.Font = new Font("Segoe UI", 10F);
            this.chkParentTeacher.ForeColor = Color.FromArgb(44, 62, 80);
            this.chkParentTeacher.Location = new Point(15, 75);
            this.chkParentTeacher.Name = "chkParentTeacher";
            this.chkParentTeacher.Size = new Size(220, 23);
            this.chkParentTeacher.Text = "Parent is Teacher at this school";

            // lblScholarshipStatus
            this.lblScholarshipStatus.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            this.lblScholarshipStatus.ForeColor = Color.FromArgb(127, 140, 141);
            this.lblScholarshipStatus.Location = new Point(12, 110);
            this.lblScholarshipStatus.Name = "lblScholarshipStatus";
            this.lblScholarshipStatus.Size = new Size(300, 35);
            this.lblScholarshipStatus.Text = "No scholarship applied";

            // =============================================
            // FEE DETAILS PANEL
            // =============================================
            this.panelFeeDetails.BackColor = Color.FromArgb(250, 250, 250);
            this.panelFeeDetails.Controls.Add(this.lblMonthlyFeeLabel);
            this.panelFeeDetails.Controls.Add(this.lblMonthlyFeeValue);
            this.panelFeeDetails.Controls.Add(this.lblDiscountLabel);
            this.panelFeeDetails.Controls.Add(this.lblDiscountValue);
            this.panelFeeDetails.Controls.Add(this.lblDiscountedMonthlyLabel);
            this.panelFeeDetails.Controls.Add(this.lblDiscountedMonthlyValue);
            this.panelFeeDetails.Controls.Add(this.lblAdmissionFeeLabel);
            this.panelFeeDetails.Controls.Add(this.lblAdmissionFeeValue);
            this.panelFeeDetails.Controls.Add(this.lblExamFeeLabel);
            this.panelFeeDetails.Controls.Add(this.lblExamFeeValue);
            this.panelFeeDetails.Controls.Add(this.lblAnnualChargesLabel);
            this.panelFeeDetails.Controls.Add(this.lblAnnualChargesValue);
            this.panelFeeDetails.Location = new Point(15, 215);
            this.panelFeeDetails.Name = "panelFeeDetails";
            this.panelFeeDetails.Size = new Size(320, 240);

            int feeY = 15;
            int feeRowHeight = 35;

            // Monthly Fee
            this.lblMonthlyFeeLabel.AutoSize = true;
            this.lblMonthlyFeeLabel.Font = new Font("Segoe UI", 10F);
            this.lblMonthlyFeeLabel.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblMonthlyFeeLabel.Location = new Point(10, feeY);
            this.lblMonthlyFeeLabel.Name = "lblMonthlyFeeLabel";
            this.lblMonthlyFeeLabel.Text = "Monthly Fee:";

            this.lblMonthlyFeeValue.AutoSize = true;
            this.lblMonthlyFeeValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblMonthlyFeeValue.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblMonthlyFeeValue.Location = new Point(200, feeY);
            this.lblMonthlyFeeValue.Name = "lblMonthlyFeeValue";
            this.lblMonthlyFeeValue.Text = "Rs. 0";

            feeY += feeRowHeight;

            // Discount (hidden by default)
            this.lblDiscountLabel.AutoSize = true;
            this.lblDiscountLabel.Font = new Font("Segoe UI", 10F);
            this.lblDiscountLabel.ForeColor = Color.FromArgb(39, 174, 96);
            this.lblDiscountLabel.Location = new Point(10, feeY);
            this.lblDiscountLabel.Name = "lblDiscountLabel";
            this.lblDiscountLabel.Text = "Scholarship Discount:";
            this.lblDiscountLabel.Visible = false;

            this.lblDiscountValue.AutoSize = true;
            this.lblDiscountValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblDiscountValue.ForeColor = Color.FromArgb(39, 174, 96);
            this.lblDiscountValue.Location = new Point(200, feeY);
            this.lblDiscountValue.Name = "lblDiscountValue";
            this.lblDiscountValue.Text = "- Rs. 0";
            this.lblDiscountValue.Visible = false;

            feeY += feeRowHeight;

            // Discounted Monthly (hidden by default)
            this.lblDiscountedMonthlyLabel.AutoSize = true;
            this.lblDiscountedMonthlyLabel.Font = new Font("Segoe UI", 10F);
            this.lblDiscountedMonthlyLabel.ForeColor = Color.FromArgb(39, 174, 96);
            this.lblDiscountedMonthlyLabel.Location = new Point(10, feeY);
            this.lblDiscountedMonthlyLabel.Name = "lblDiscountedMonthlyLabel";
            this.lblDiscountedMonthlyLabel.Text = "After Discount:";
            this.lblDiscountedMonthlyLabel.Visible = false;

            this.lblDiscountedMonthlyValue.AutoSize = true;
            this.lblDiscountedMonthlyValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblDiscountedMonthlyValue.ForeColor = Color.FromArgb(39, 174, 96);
            this.lblDiscountedMonthlyValue.Location = new Point(200, feeY);
            this.lblDiscountedMonthlyValue.Name = "lblDiscountedMonthlyValue";
            this.lblDiscountedMonthlyValue.Text = "Rs. 0";
            this.lblDiscountedMonthlyValue.Visible = false;

            feeY += feeRowHeight + 10;

            // Admission Fee
            this.lblAdmissionFeeLabel.AutoSize = true;
            this.lblAdmissionFeeLabel.Font = new Font("Segoe UI", 10F);
            this.lblAdmissionFeeLabel.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblAdmissionFeeLabel.Location = new Point(10, feeY);
            this.lblAdmissionFeeLabel.Name = "lblAdmissionFeeLabel";
            this.lblAdmissionFeeLabel.Text = "Admission Fee:";

            this.lblAdmissionFeeValue.AutoSize = true;
            this.lblAdmissionFeeValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblAdmissionFeeValue.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblAdmissionFeeValue.Location = new Point(200, feeY);
            this.lblAdmissionFeeValue.Name = "lblAdmissionFeeValue";
            this.lblAdmissionFeeValue.Text = "Rs. 0";

            feeY += feeRowHeight;

            // Exam Fee
            this.lblExamFeeLabel.AutoSize = true;
            this.lblExamFeeLabel.Font = new Font("Segoe UI", 10F);
            this.lblExamFeeLabel.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblExamFeeLabel.Location = new Point(10, feeY);
            this.lblExamFeeLabel.Name = "lblExamFeeLabel";
            this.lblExamFeeLabel.Text = "Exam Fee:";

            this.lblExamFeeValue.AutoSize = true;
            this.lblExamFeeValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblExamFeeValue.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblExamFeeValue.Location = new Point(200, feeY);
            this.lblExamFeeValue.Name = "lblExamFeeValue";
            this.lblExamFeeValue.Text = "Rs. 0";

            feeY += feeRowHeight;

            // Annual Charges
            this.lblAnnualChargesLabel.AutoSize = true;
            this.lblAnnualChargesLabel.Font = new Font("Segoe UI", 10F);
            this.lblAnnualChargesLabel.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblAnnualChargesLabel.Location = new Point(10, feeY);
            this.lblAnnualChargesLabel.Name = "lblAnnualChargesLabel";
            this.lblAnnualChargesLabel.Text = "Annual Charges:";

            this.lblAnnualChargesValue.AutoSize = true;
            this.lblAnnualChargesValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblAnnualChargesValue.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblAnnualChargesValue.Location = new Point(200, feeY);
            this.lblAnnualChargesValue.Name = "lblAnnualChargesValue";
            this.lblAnnualChargesValue.Text = "Rs. 0";

            // =============================================
            // TOTAL PAYMENT PANEL
            // =============================================
            this.panelTotalPayment.BackColor = Color.FromArgb(41, 128, 185);
            this.panelTotalPayment.Controls.Add(this.lblTotalFirstPaymentLabel);
            this.panelTotalPayment.Controls.Add(this.lblTotalFirstPaymentValue);
            this.panelTotalPayment.Location = new Point(15, 470);
            this.panelTotalPayment.Name = "panelTotalPayment";
            this.panelTotalPayment.Size = new Size(320, 80);

            // lblTotalFirstPaymentLabel
            this.lblTotalFirstPaymentLabel.AutoSize = true;
            this.lblTotalFirstPaymentLabel.Font = new Font("Segoe UI", 10F);
            this.lblTotalFirstPaymentLabel.ForeColor = Color.FromArgb(214, 234, 248);
            this.lblTotalFirstPaymentLabel.Location = new Point(15, 12);
            this.lblTotalFirstPaymentLabel.Name = "lblTotalFirstPaymentLabel";
            this.lblTotalFirstPaymentLabel.Text = "TOTAL FIRST PAYMENT";

            // lblTotalFirstPaymentValue
            this.lblTotalFirstPaymentValue.AutoSize = true;
            this.lblTotalFirstPaymentValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTotalFirstPaymentValue.ForeColor = Color.White;
            this.lblTotalFirstPaymentValue.Location = new Point(12, 35);
            this.lblTotalFirstPaymentValue.Name = "lblTotalFirstPaymentValue";
            this.lblTotalFirstPaymentValue.Text = "Rs. 0";

            // =============================================
            // FORM BUTTONS
            // =============================================
            this.panelFormButtons.BackColor = Color.FromArgb(236, 240, 241);
            this.panelFormButtons.Controls.Add(this.btnBackToClassSelection);
            this.panelFormButtons.Controls.Add(this.btnSubmitAdmission);
            this.panelFormButtons.Controls.Add(this.btnCancelAdmission);
            this.panelFormButtons.Dock = DockStyle.Bottom;
            this.panelFormButtons.Location = new Point(0, 680);
            this.panelFormButtons.Name = "panelFormButtons";
            this.panelFormButtons.Size = new Size(1100, 70);

            // btnBackToClassSelection
            this.btnBackToClassSelection.BackColor = Color.FromArgb(41, 128, 185);
            this.btnBackToClassSelection.Cursor = Cursors.Hand;
            this.btnBackToClassSelection.FlatAppearance.BorderSize = 0;
            this.btnBackToClassSelection.FlatStyle = FlatStyle.Flat;
            this.btnBackToClassSelection.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnBackToClassSelection.ForeColor = Color.White;
            this.btnBackToClassSelection.Location = new Point(30, 15);
            this.btnBackToClassSelection.Name = "btnBackToClassSelection";
            this.btnBackToClassSelection.Size = new Size(150, 45);
            this.btnBackToClassSelection.Text = "← Back";

            // btnSubmitAdmission
            this.btnSubmitAdmission.BackColor = Color.FromArgb(39, 174, 96);
            this.btnSubmitAdmission.Cursor = Cursors.Hand;
            this.btnSubmitAdmission.FlatAppearance.BorderSize = 0;
            this.btnSubmitAdmission.FlatStyle = FlatStyle.Flat;
            this.btnSubmitAdmission.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnSubmitAdmission.ForeColor = Color.White;
            this.btnSubmitAdmission.Location = new Point(720, 15);
            this.btnSubmitAdmission.Name = "btnSubmitAdmission";
            this.btnSubmitAdmission.Size = new Size(200, 45);
            this.btnSubmitAdmission.Text = "✓ Submit Admission";

            // btnCancelAdmission
            this.btnCancelAdmission.BackColor = Color.FromArgb(231, 76, 60);
            this.btnCancelAdmission.Cursor = Cursors.Hand;
            this.btnCancelAdmission.FlatAppearance.BorderSize = 0;
            this.btnCancelAdmission.FlatStyle = FlatStyle.Flat;
            this.btnCancelAdmission.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnCancelAdmission.ForeColor = Color.White;
            this.btnCancelAdmission.Location = new Point(930, 15);
            this.btnCancelAdmission.Name = "btnCancelAdmission";
            this.btnCancelAdmission.Size = new Size(150, 45);
            this.btnCancelAdmission.Text = "Cancel";

            // =============================================
            // FORM SETTINGS
            // =============================================
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new Size(1100, 750);
            this.Controls.Add(this.panelAdmissionForm);
            this.Controls.Add(this.panelClassSelection);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddStudentForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Add New Student - School Management System";

            // Resume Layout
            this.panelClassSelection.ResumeLayout(false);
            this.panelClassSelection.PerformLayout();
            this.panelClassDropdown.ResumeLayout(false);
            this.panelClassDropdown.PerformLayout();
            this.panelAdmissionForm.ResumeLayout(false);
            this.panelFormHeader.ResumeLayout(false);
            this.panelFormHeader.PerformLayout();
            this.panelAdmissionNumber.ResumeLayout(false);
            this.panelAdmissionNumber.PerformLayout();
            this.panelFormContent.ResumeLayout(false);
            this.panelStudentDetails.ResumeLayout(false);
            this.panelStudentDetails.PerformLayout();
            this.panelFeeSection.ResumeLayout(false);
            this.panelScholarship.ResumeLayout(false);
            this.panelScholarship.PerformLayout();
            this.panelFeeDetails.ResumeLayout(false);
            this.panelFeeDetails.PerformLayout();
            this.panelTotalPayment.ResumeLayout(false);
            this.panelTotalPayment.PerformLayout();
            this.panelFormButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // Class Selection Panel
        private Panel panelClassSelection;
        private Label lblSelectClassTitle;
        private Label lblSelectClassSubtitle;
        private Panel panelClassDropdown;
        private Label lblClassLabel;
        private ComboBox cmbClassSelection;
        private Button btnSelectClass;
        private Button btnCancelSelection;

        // Admission Form Panel
        private Panel panelAdmissionForm;
        private Panel panelFormHeader;
        private Label lblFormTitle;
        private Panel panelAdmissionNumber;
        private Label lblAdmissionNumberLabel;
        private Label lblAdmissionNumberValue;

        // Form Content
        private Panel panelFormContent;

        // Student Details Section
        private Panel panelStudentDetails;
        private Label lblStudentDetailsHeader;
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

        // Fee & Scholarship Section
        private Panel panelFeeSection;
        private Label lblFeeHeader;
        private Panel panelScholarship;
        private Label lblScholarshipHeader;
        private CheckBox chkKinshipScholarship;
        private CheckBox chkParentTeacher;
        private Label lblScholarshipStatus;
        private Panel panelFeeDetails;
        private Label lblMonthlyFeeLabel;
        private Label lblMonthlyFeeValue;
        private Label lblAdmissionFeeLabel;
        private Label lblAdmissionFeeValue;
        private Label lblExamFeeLabel;
        private Label lblExamFeeValue;
        private Label lblAnnualChargesLabel;
        private Label lblAnnualChargesValue;
        private Label lblDiscountLabel;
        private Label lblDiscountValue;
        private Label lblDiscountedMonthlyLabel;
        private Label lblDiscountedMonthlyValue;
        private Panel panelTotalPayment;
        private Label lblTotalFirstPaymentLabel;
        private Label lblTotalFirstPaymentValue;

        // Form Buttons
        private Panel panelFormButtons;
        private Button btnBackToClassSelection;
        private Button btnSubmitAdmission;
        private Button btnCancelAdmission;
    }
}
