using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace SchoolManagementSystem
{
    public partial class ModifyTeacherForm : Form
    {
        private TeacherData? selectedTeacher = null;

        // Sample teacher data
        private List<TeacherData> teachers = new List<TeacherData>
        {
            new TeacherData("EMP-2024-1001", "Ahmed Khan", "Male", new DateTime(1985, 5, 15), "35201-1234567-1",
                "Master's (M.Sc)", "Mathematics", "10-15 Years", "0300-1234567", "ahmed.khan@school.edu",
                "House 45, Street 12, F-8, Islamabad", new DateTime(2015, 3, 1), 65000, "Active",
                "Rashid Khan", "0321-9876543", "Microsoft Certified Educator, STEM Training"),
            new TeacherData("EMP-2024-1002", "Fatima Ali", "Female", new DateTime(1990, 8, 22), "35202-2345678-2",
                "Master's (M.Ed)", "English", "6-10 Years", "0321-2345678", "fatima.ali@school.edu",
                "Flat 12, Block C, Gulberg, Lahore", new DateTime(2018, 8, 15), 55000, "Active",
                "Ali Hassan", "0333-1234567", "IELTS Trainer, Cambridge Certified"),
            new TeacherData("EMP-2024-1003", "Muhammad Usman", "Male", new DateTime(1988, 12, 3), "35203-3456789-3",
                "Ph.D", "Physics", "10-15 Years", "0333-3456789", "m.usman@school.edu",
                "House 78, DHA Phase 5, Karachi", new DateTime(2016, 1, 10), 75000, "Active",
                "Usman Ali", "0300-5678901", "Research Publications, Lab Management"),
            new TeacherData("EMP-2024-1004", "Ayesha Malik", "Female", new DateTime(1992, 3, 18), "35204-4567890-4",
                "Master's (M.A)", "Urdu", "3 Years", "0345-4567890", "ayesha.malik@school.edu",
                "House 23, Model Town, Multan", new DateTime(2021, 6, 1), 40000, "Probation",
                "Malik Ahmed", "0312-3456789", "Poetry, Creative Writing"),
            new TeacherData("EMP-2024-1005", "Hassan Raza", "Male", new DateTime(1980, 7, 25), "35205-5678901-5",
                "Master's (M.Sc)", "Computer Science", "15-20 Years", "0312-5678901", "hassan.raza@school.edu",
                "Apartment 5, Bahria Town, Rawalpindi", new DateTime(2010, 9, 1), 80000, "Active",
                "Raza Ali", "0345-6789012", "Web Development, Database Management, AI/ML"),
            new TeacherData("EMP-2024-1006", "Sara Ahmed", "Female", new DateTime(1995, 1, 10), "35206-6789012-6",
                "Bachelor's (B.Ed)", "Art & Drawing", "2 Years", "0300-6789012", "sara.ahmed@school.edu",
                "House 56, Satellite Town, Sargodha", new DateTime(2023, 2, 15), 35000, "Contract",
                "Ahmed Hassan", "0321-7890123", "Fine Arts, Digital Art"),
            new TeacherData("EMP-2024-1007", "Ali Abbas", "Male", new DateTime(1983, 9, 8), "35207-7890123-7",
                "Master's (M.Phil)", "Chemistry", "10-15 Years", "0321-7890123", "ali.abbas@school.edu",
                "House 89, Cantt Area, Peshawar", new DateTime(2014, 4, 1), 70000, "Active",
                "Abbas Ali", "0333-8901234", "Lab Safety Certified, Research Experience"),
            new TeacherData("EMP-2024-1008", "Zainab Fatima", "Female", new DateTime(1991, 11, 30), "35208-8901234-8",
                "Master's (M.Sc)", "Biology", "5 Years", "0333-8901234", "zainab.f@school.edu",
                "Flat 34, Clifton, Karachi", new DateTime(2019, 7, 1), 50000, "Active",
                "Fatima Bibi", "0345-9012345", "Microbiology Specialist"),
            new TeacherData("EMP-2024-1009", "Imran Sheikh", "Male", new DateTime(1978, 4, 12), "35209-9012345-9",
                "Ph.D", "History", "20+ Years", "0345-9012345", "imran.sheikh@school.edu",
                "House 12, University Town, Faisalabad", new DateTime(2005, 1, 1), 90000, "Active",
                "Sheikh Ahmed", "0300-0123456", "Published Author, Historical Research"),
            new TeacherData("EMP-2024-1010", "Mariam Bibi", "Female", new DateTime(1987, 6, 20), "35210-0123456-0",
                "Bachelor's (B.A)", "Islamiat", "6-10 Years", "0312-0123456", "mariam.b@school.edu",
                "House 67, Township, Lahore", new DateTime(2017, 8, 1), 45000, "On Leave",
                "Bibi Khatoon", "0321-1234567", "Quran Teaching, Islamic Studies")
        };

        // Dropdown options
        private readonly string[] departments = {
            "Mathematics", "English", "Science", "Physics", "Chemistry", "Biology",
            "Computer Science", "Social Studies", "History", "Geography", "Urdu",
            "Islamiat", "Art & Drawing", "Physical Education", "Music", "Economics",
            "Accounting", "Business Studies", "Psychology", "Administration"
        };

        private readonly string[] qualifications = {
            "Matriculation", "Intermediate (F.A/F.Sc)", "Bachelor's (B.A/B.Sc/B.Com)",
            "Bachelor's (B.Ed)", "Bachelor's (BS/BBA)", "Master's (M.A/M.Sc/M.Com)",
            "Master's (M.Ed)", "Master's (MS/MBA)", "M.Phil", "Ph.D", "Other"
        };

        private readonly string[] statusOptions = {
            "Active", "On Leave", "Probation", "Contract", "Resigned", "Terminated"
        };

        private readonly string[] experienceOptions = {
            "Fresher", "1 Year", "2 Years", "3 Years", "4 Years", "5 Years",
            "6-10 Years", "10-15 Years", "15-20 Years", "20+ Years"
        };

        public ModifyTeacherForm()
        {
            InitializeComponent();
            SetupForm();
            SetupEventHandlers();
            LoadTeachersToGrid();
            ShowSearchPanel();
        }

        private void SetupForm()
        {
            // Populate combo boxes
            cmbDepartment.Items.AddRange(departments);
            cmbQualification.Items.AddRange(qualifications);
            cmbStatus.Items.AddRange(statusOptions);
            cmbGender.Items.AddRange(new string[] { "Male", "Female", "Other" });
            cmbExperience.Items.AddRange(experienceOptions);

            // Setup department filter
            cmbDepartmentFilter.Items.Add("All Departments");
            cmbDepartmentFilter.Items.AddRange(departments);
            cmbDepartmentFilter.SelectedIndex = 0;
        }

        private void SetupEventHandlers()
        {
            // Search panel events
            txtSearch.TextChanged += TxtSearch_TextChanged;
            cmbDepartmentFilter.SelectedIndexChanged += CmbDepartmentFilter_SelectedIndexChanged;
            btnClearFilter.Click += BtnClearFilter_Click;
            dgvTeachers.CellDoubleClick += DgvTeachers_CellDoubleClick;
            btnSelectTeacher.Click += BtnSelectTeacher_Click;

            // Edit form events
            btnUpdate.Click += BtnUpdate_Click;
            btnCancel.Click += BtnCancel_Click;
            btnBackToSearch.Click += BtnBackToSearch_Click;

            // Real-time validation
            txtName.TextChanged += TxtName_TextChanged;
            txtContactNumber.TextChanged += TxtContactNumber_TextChanged;
            txtEmail.TextChanged += TxtEmail_TextChanged;
            txtSalary.TextChanged += TxtSalary_TextChanged;
            txtEmergencyContact.TextChanged += TxtEmergencyContact_TextChanged;
            txtCNIC.TextChanged += TxtCNIC_TextChanged;

            // Key press events
            txtContactNumber.KeyPress += NumericField_KeyPress;
            txtEmergencyContact.KeyPress += NumericField_KeyPress;
            txtSalary.KeyPress += SalaryField_KeyPress;
            txtCNIC.KeyPress += CNICField_KeyPress;

            // Hover effects
            SetupButtonHoverEffects(btnSelectTeacher, Color.FromArgb(41, 128, 185), Color.FromArgb(52, 152, 219));
            SetupButtonHoverEffects(btnClearFilter, Color.FromArgb(149, 165, 166), Color.FromArgb(189, 195, 199));
            SetupButtonHoverEffects(btnUpdate, Color.FromArgb(39, 174, 96), Color.FromArgb(46, 204, 113));
            SetupButtonHoverEffects(btnCancel, Color.FromArgb(231, 76, 60), Color.FromArgb(236, 112, 99));
            SetupButtonHoverEffects(btnBackToSearch, Color.FromArgb(52, 73, 94), Color.FromArgb(74, 90, 107));
        }

        private void SetupButtonHoverEffects(Button btn, Color normalColor, Color hoverColor)
        {
            btn.MouseEnter += (s, e) => btn.BackColor = hoverColor;
            btn.MouseLeave += (s, e) => btn.BackColor = normalColor;
        }

        private void ShowSearchPanel()
        {
            panelSearch.Visible = true;
            panelEditForm.Visible = false;
        }

        private void ShowEditForm()
        {
            panelSearch.Visible = false;
            panelEditForm.Visible = true;
        }

        private void LoadTeachersToGrid()
        {
            dgvTeachers.Rows.Clear();
            foreach (var teacher in teachers)
            {
                dgvTeachers.Rows.Add(
                    teacher.EmployeeId,
                    teacher.Name,
                    teacher.Department,
                    teacher.Qualification,
                    teacher.ContactNumber,
                    teacher.Status
                );
            }
            UpdateResultsCount();
        }

        private void FilterTeachers()
        {
            string searchText = txtSearch.Text.ToLower().Trim();
            string departmentFilter = cmbDepartmentFilter.SelectedItem?.ToString() ?? "All Departments";

            dgvTeachers.Rows.Clear();

            foreach (var teacher in teachers)
            {
                bool matchesSearch = string.IsNullOrEmpty(searchText) ||
                    teacher.Name.ToLower().Contains(searchText) ||
                    teacher.EmployeeId.ToLower().Contains(searchText) ||
                    teacher.ContactNumber.Contains(searchText);

                bool matchesDepartment = departmentFilter == "All Departments" ||
                    teacher.Department == departmentFilter;

                if (matchesSearch && matchesDepartment)
                {
                    dgvTeachers.Rows.Add(
                        teacher.EmployeeId,
                        teacher.Name,
                        teacher.Department,
                        teacher.Qualification,
                        teacher.ContactNumber,
                        teacher.Status
                    );
                }
            }
            UpdateResultsCount();
        }

        private void UpdateResultsCount()
        {
            lblResultsCount.Text = $"Found {dgvTeachers.Rows.Count} teacher(s)";
        }

        private void PopulateEditForm(TeacherData teacher)
        {
            selectedTeacher = teacher;

            // Employee ID (read-only)
            lblEmployeeIdValue.Text = teacher.EmployeeId;

            // Personal Information
            txtName.Text = teacher.Name;
            cmbGender.SelectedItem = teacher.Gender;
            dtpDateOfBirth.Value = teacher.DateOfBirth;
            txtCNIC.Text = teacher.CNIC;

            // Professional Information
            SelectComboBoxItem(cmbQualification, teacher.Qualification);
            cmbDepartment.SelectedItem = teacher.Department;
            SelectComboBoxItem(cmbExperience, teacher.Experience);
            txtSkills.Text = teacher.Skills;

            // Contact Information
            txtContactNumber.Text = teacher.ContactNumber;
            txtEmail.Text = teacher.Email;
            txtAddress.Text = teacher.Address;

            // Employment Details
            dtpJoiningDate.Value = teacher.JoiningDate;
            txtSalary.Text = teacher.Salary.ToString();
            cmbStatus.SelectedItem = teacher.Status;

            // Emergency Contact
            txtEmergencyName.Text = teacher.EmergencyName;
            txtEmergencyContact.Text = teacher.EmergencyContact;

            // Clear validation labels
            ClearValidationLabels();
        }

        private void SelectComboBoxItem(ComboBox cmb, string value)
        {
            for (int i = 0; i < cmb.Items.Count; i++)
            {
                if (cmb.Items[i]?.ToString()?.Contains(value.Split(' ')[0]) == true ||
                    cmb.Items[i]?.ToString() == value)
                {
                    cmb.SelectedIndex = i;
                    return;
                }
            }
        }

        private void ClearValidationLabels()
        {
            lblNameValidation.Text = "";
            lblContactValidation.Text = "";
            lblEmailValidation.Text = "";
            lblSalaryValidation.Text = "";
            lblEmergencyValidation.Text = "";
            lblCNICValidation.Text = "";

            // Reset backgrounds
            txtName.BackColor = Color.White;
            txtCNIC.BackColor = Color.White;
            txtContactNumber.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
            txtSalary.BackColor = Color.White;
            txtEmergencyContact.BackColor = Color.White;
        }

        #region Search Panel Event Handlers

        private void TxtSearch_TextChanged(object? sender, EventArgs e)
        {
            FilterTeachers();
        }

        private void CmbDepartmentFilter_SelectedIndexChanged(object? sender, EventArgs e)
        {
            FilterTeachers();
        }

        private void BtnClearFilter_Click(object? sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbDepartmentFilter.SelectedIndex = 0;
            LoadTeachersToGrid();
        }

        private void DgvTeachers_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectAndEditTeacher(e.RowIndex);
            }
        }

        private void BtnSelectTeacher_Click(object? sender, EventArgs e)
        {
            if (dgvTeachers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a teacher to modify.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SelectAndEditTeacher(dgvTeachers.SelectedRows[0].Index);
        }

        private void SelectAndEditTeacher(int rowIndex)
        {
            string employeeId = dgvTeachers.Rows[rowIndex].Cells["colEmployeeId"].Value?.ToString() ?? "";
            var teacher = teachers.Find(t => t.EmployeeId == employeeId);

            if (teacher != null)
            {
                PopulateEditForm(teacher);
                ShowEditForm();
            }
        }

        #endregion

        #region Real-time Validation Handlers

        private void TxtName_TextChanged(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                SetValidationState(txtName, lblNameValidation, "Name is required", false);
            }
            else if (txtName.Text.Length < 3)
            {
                SetValidationState(txtName, lblNameValidation, "Name too short", false);
            }
            else if (!Regex.IsMatch(txtName.Text, @"^[a-zA-Z\s.]+$"))
            {
                SetValidationState(txtName, lblNameValidation, "Only letters allowed", false);
            }
            else
            {
                SetValidationState(txtName, lblNameValidation, "✓", true);
            }
        }

        private void TxtContactNumber_TextChanged(object? sender, EventArgs e)
        {
            string digits = new string(txtContactNumber.Text.Where(char.IsDigit).ToArray());
            if (string.IsNullOrWhiteSpace(txtContactNumber.Text))
            {
                SetValidationState(txtContactNumber, lblContactValidation, "Contact required", false);
            }
            else if (digits.Length < 10)
            {
                SetValidationState(txtContactNumber, lblContactValidation, "Min 10 digits", false);
            }
            else if (digits.Length > 15)
            {
                SetValidationState(txtContactNumber, lblContactValidation, "Max 15 digits", false);
            }
            else
            {
                SetValidationState(txtContactNumber, lblContactValidation, "✓", true);
            }
        }

        private void TxtEmail_TextChanged(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                SetValidationState(txtEmail, lblEmailValidation, "", true);
            }
            else if (!IsValidEmail(txtEmail.Text))
            {
                SetValidationState(txtEmail, lblEmailValidation, "Invalid email", false);
            }
            else
            {
                SetValidationState(txtEmail, lblEmailValidation, "✓", true);
            }
        }

        private void TxtSalary_TextChanged(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                SetValidationState(txtSalary, lblSalaryValidation, "Salary required", false);
            }
            else if (!decimal.TryParse(txtSalary.Text, out decimal salary))
            {
                SetValidationState(txtSalary, lblSalaryValidation, "Invalid amount", false);
            }
            else if (salary < 15000)
            {
                SetValidationState(txtSalary, lblSalaryValidation, "Min Rs. 15,000", false);
            }
            else if (salary > 500000)
            {
                SetValidationState(txtSalary, lblSalaryValidation, "Max Rs. 500,000", false);
            }
            else
            {
                SetValidationState(txtSalary, lblSalaryValidation, "✓", true);
            }
        }

        private void TxtEmergencyContact_TextChanged(object? sender, EventArgs e)
        {
            string digits = new string(txtEmergencyContact.Text.Where(char.IsDigit).ToArray());
            if (string.IsNullOrWhiteSpace(txtEmergencyContact.Text))
            {
                SetValidationState(txtEmergencyContact, lblEmergencyValidation, "Required", false);
            }
            else if (digits.Length < 10)
            {
                SetValidationState(txtEmergencyContact, lblEmergencyValidation, "Min 10 digits", false);
            }
            else
            {
                SetValidationState(txtEmergencyContact, lblEmergencyValidation, "✓", true);
            }
        }

        private void TxtCNIC_TextChanged(object? sender, EventArgs e)
        {
            string cnic = txtCNIC.Text.Replace("-", "");
            if (string.IsNullOrWhiteSpace(txtCNIC.Text))
            {
                SetValidationState(txtCNIC, lblCNICValidation, "CNIC required", false);
            }
            else if (cnic.Length != 13)
            {
                SetValidationState(txtCNIC, lblCNICValidation, "13 digits required", false);
            }
            else
            {
                SetValidationState(txtCNIC, lblCNICValidation, "✓", true);
            }
        }

        private void SetValidationState(Control control, Label validationLabel, string message, bool isValid)
        {
            validationLabel.Text = message;
            validationLabel.ForeColor = isValid ? Color.FromArgb(39, 174, 96) : Color.FromArgb(231, 76, 60);

            if (control is TextBox textBox)
            {
                textBox.BackColor = isValid || string.IsNullOrEmpty(message)
                    ? Color.White
                    : Color.FromArgb(255, 245, 245);
            }
        }

        #endregion

        #region KeyPress Handlers

        private void NumericField_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void SalaryField_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CNICField_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Edit Form Event Handlers

        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            if (!ValidateAllFields())
            {
                return;
            }

            if (selectedTeacher == null)
            {
                MessageBox.Show("No teacher selected.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update teacher data
            selectedTeacher.Name = txtName.Text;
            selectedTeacher.Gender = cmbGender.SelectedItem?.ToString() ?? "";
            selectedTeacher.DateOfBirth = dtpDateOfBirth.Value;
            selectedTeacher.CNIC = txtCNIC.Text;
            selectedTeacher.Qualification = cmbQualification.SelectedItem?.ToString() ?? "";
            selectedTeacher.Department = cmbDepartment.SelectedItem?.ToString() ?? "";
            selectedTeacher.Experience = cmbExperience.SelectedItem?.ToString() ?? "";
            selectedTeacher.Skills = txtSkills.Text;
            selectedTeacher.ContactNumber = txtContactNumber.Text;
            selectedTeacher.Email = txtEmail.Text;
            selectedTeacher.Address = txtAddress.Text;
            selectedTeacher.JoiningDate = dtpJoiningDate.Value;
            selectedTeacher.Salary = decimal.Parse(txtSalary.Text);
            selectedTeacher.Status = cmbStatus.SelectedItem?.ToString() ?? "";
            selectedTeacher.EmergencyName = txtEmergencyName.Text;
            selectedTeacher.EmergencyContact = txtEmergencyContact.Text;

            // Format salary for display
            decimal salary = decimal.Parse(txtSalary.Text);
            string formattedSalary = $"Rs. {salary:N0}";

            // Show success message
            string message = $"Teacher Updated Successfully!\n\n" +
                           $"Employee ID: {selectedTeacher.EmployeeId}\n" +
                           $"Name: {selectedTeacher.Name}\n" +
                           $"Department: {selectedTeacher.Department}\n" +
                           $"Status: {selectedTeacher.Status}\n" +
                           $"Monthly Salary: {formattedSalary}";

            MessageBox.Show(message, "Update Successful",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Return to search
            LoadTeachersToGrid();
            ShowSearchPanel();
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel? All unsaved changes will be lost.",
                "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnBackToSearch_Click(object? sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Go back to search? Any unsaved changes will be lost.",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ShowSearchPanel();
            }
        }

        #endregion

        #region Validation Helper Methods

        private bool ValidateAllFields()
        {
            // Name validation
            if (string.IsNullOrWhiteSpace(txtName.Text) || txtName.Text.Length < 3)
            {
                ShowValidationError("Please enter a valid name (at least 3 characters).", txtName);
                return false;
            }

            // Gender validation
            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select gender.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGender.Focus();
                return false;
            }

            // Age validation (at least 18)
            int age = DateTime.Now.Year - dtpDateOfBirth.Value.Year;
            if (dtpDateOfBirth.Value > DateTime.Now.AddYears(-age)) age--;
            if (age < 18)
            {
                MessageBox.Show("Teacher must be at least 18 years old.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDateOfBirth.Focus();
                return false;
            }

            // CNIC validation
            string cnic = txtCNIC.Text.Replace("-", "");
            if (cnic.Length != 13)
            {
                ShowValidationError("Please enter a valid 13-digit CNIC number.", txtCNIC);
                return false;
            }

            // Qualification validation
            if (cmbQualification.SelectedIndex == -1)
            {
                MessageBox.Show("Please select qualification.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbQualification.Focus();
                return false;
            }

            // Department validation
            if (cmbDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Please select department.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDepartment.Focus();
                return false;
            }

            // Experience validation
            if (cmbExperience.SelectedIndex == -1)
            {
                MessageBox.Show("Please select experience level.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbExperience.Focus();
                return false;
            }

            // Contact number validation
            string contact = new string(txtContactNumber.Text.Where(char.IsDigit).ToArray());
            if (contact.Length < 10 || contact.Length > 15)
            {
                ShowValidationError("Please enter a valid contact number (10-15 digits).", txtContactNumber);
                return false;
            }

            // Email validation (if provided)
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !IsValidEmail(txtEmail.Text))
            {
                ShowValidationError("Please enter a valid email address.", txtEmail);
                return false;
            }

            // Address validation
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                ShowValidationError("Please enter address.", txtAddress);
                return false;
            }

            // Salary validation
            if (!decimal.TryParse(txtSalary.Text, out decimal salary) || salary < 15000 || salary > 500000)
            {
                ShowValidationError("Please enter a valid salary (Rs. 15,000 - Rs. 500,000).", txtSalary);
                return false;
            }

            // Emergency contact validation
            string emergency = new string(txtEmergencyContact.Text.Where(char.IsDigit).ToArray());
            if (emergency.Length < 10)
            {
                ShowValidationError("Please enter a valid emergency contact number.", txtEmergencyContact);
                return false;
            }

            // Status validation
            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select employment status.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStatus.Focus();
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase);
            }
            catch
            {
                return false;
            }
        }

        private void ShowValidationError(string message, Control control)
        {
            MessageBox.Show(message, "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
        }

        #endregion
    }

    /// <summary>
    /// Teacher data class for storing teacher information
    /// </summary>
    public class TeacherData
    {
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CNIC { get; set; }
        public string Qualification { get; set; }
        public string Department { get; set; }
        public string Experience { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime JoiningDate { get; set; }
        public decimal Salary { get; set; }
        public string Status { get; set; }
        public string EmergencyName { get; set; }
        public string EmergencyContact { get; set; }
        public string Skills { get; set; }

        public TeacherData(string employeeId, string name, string gender, DateTime dob, string cnic,
            string qualification, string department, string experience, string contact, string email,
            string address, DateTime joiningDate, decimal salary, string status,
            string emergencyName, string emergencyContact, string skills)
        {
            EmployeeId = employeeId;
            Name = name;
            Gender = gender;
            DateOfBirth = dob;
            CNIC = cnic;
            Qualification = qualification;
            Department = department;
            Experience = experience;
            ContactNumber = contact;
            Email = email;
            Address = address;
            JoiningDate = joiningDate;
            Salary = salary;
            Status = status;
            EmergencyName = emergencyName;
            EmergencyContact = emergencyContact;
            Skills = skills;
        }
    }
}
