using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SchoolManagementSystem
{
    public partial class AddTeacherForm : Form
    {
        private static int employeeCounter = 1001; // Starting employee number
        private string generatedEmployeeId = "";

        // Departments/Subjects available
        private readonly string[] departments = {
            "Mathematics", "English", "Science", "Physics", "Chemistry", "Biology",
            "Computer Science", "Social Studies", "History", "Geography", "Urdu",
            "Islamiat", "Art & Drawing", "Physical Education", "Music", "Economics",
            "Accounting", "Business Studies", "Psychology", "Administration"
        };

        // Qualifications
        private readonly string[] qualifications = {
            "Matriculation", "Intermediate (F.A/F.Sc)", "Bachelor's (B.A/B.Sc/B.Com)",
            "Bachelor's (B.Ed)", "Bachelor's (BS/BBA)", "Master's (M.A/M.Sc/M.Com)",
            "Master's (M.Ed)", "Master's (MS/MBA)", "M.Phil", "Ph.D", "Other"
        };

        // Status options
        private readonly string[] statusOptions = {
            "Active", "On Leave", "Probation", "Contract", "Resigned", "Terminated"
        };

        public AddTeacherForm()
        {
            InitializeComponent();
            SetupForm();
            SetupEventHandlers();
            GenerateEmployeeId();
        }

        private void SetupForm()
        {
            // Populate combo boxes
            cmbDepartment.Items.AddRange(departments);
            cmbQualification.Items.AddRange(qualifications);
            cmbStatus.Items.AddRange(statusOptions);
            cmbGender.Items.AddRange(new string[] { "Male", "Female", "Other" });
            cmbExperience.Items.AddRange(new string[] { 
                "Fresher", "1 Year", "2 Years", "3 Years", "4 Years", "5 Years",
                "6-10 Years", "10-15 Years", "15-20 Years", "20+ Years" 
            });

            // Set default values
            dtpDateOfBirth.Value = DateTime.Now.AddYears(-25);
            dtpJoiningDate.Value = DateTime.Now;
            cmbStatus.SelectedIndex = 0; // Active by default

            // Set salary default
            txtSalary.Text = "25000";
        }

        private void SetupEventHandlers()
        {
            // Button events
            btnSubmit.Click += BtnSubmit_Click;
            btnCancel.Click += BtnCancel_Click;
            btnReset.Click += BtnReset_Click;

            // Real-time validation events
            txtName.TextChanged += TxtName_TextChanged;
            txtContactNumber.TextChanged += TxtContactNumber_TextChanged;
            txtEmail.TextChanged += TxtEmail_TextChanged;
            txtSalary.TextChanged += TxtSalary_TextChanged;
            txtEmergencyContact.TextChanged += TxtEmergencyContact_TextChanged;
            txtCNIC.TextChanged += TxtCNIC_TextChanged;

            // Key press events for numeric fields
            txtContactNumber.KeyPress += NumericField_KeyPress;
            txtEmergencyContact.KeyPress += NumericField_KeyPress;
            txtSalary.KeyPress += SalaryField_KeyPress;
            txtCNIC.KeyPress += CNICField_KeyPress;

            // Hover effects
            SetupButtonHoverEffects(btnSubmit, Color.FromArgb(39, 174, 96), Color.FromArgb(46, 204, 113));
            SetupButtonHoverEffects(btnCancel, Color.FromArgb(231, 76, 60), Color.FromArgb(236, 112, 99));
            SetupButtonHoverEffects(btnReset, Color.FromArgb(52, 73, 94), Color.FromArgb(74, 90, 107));
        }

        private void SetupButtonHoverEffects(Button btn, Color normalColor, Color hoverColor)
        {
            btn.MouseEnter += (s, e) => btn.BackColor = hoverColor;
            btn.MouseLeave += (s, e) => btn.BackColor = normalColor;
        }

        private void GenerateEmployeeId()
        {
            generatedEmployeeId = $"EMP-{DateTime.Now.Year}-{employeeCounter:D4}";
            lblEmployeeIdValue.Text = generatedEmployeeId;
        }

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
                SetValidationState(txtEmail, lblEmailValidation, "", true); // Email is optional
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
            
            // Subtle border indication using tag or background
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

            // Auto-format CNIC (xxxxx-xxxxxxx-x)
            if (char.IsDigit(e.KeyChar))
            {
                string text = txtCNIC.Text.Replace("-", "");
                if (text.Length == 5 || text.Length == 12)
                {
                    txtCNIC.Text += "-";
                    txtCNIC.SelectionStart = txtCNIC.Text.Length;
                }
            }
        }

        #endregion

        #region Button Handlers

        private void BtnSubmit_Click(object? sender, EventArgs e)
        {
            if (!ValidateAllFields())
            {
                return;
            }

            // Increment counter for next employee
            employeeCounter++;

            // Format salary for display
            decimal salary = decimal.Parse(txtSalary.Text);
            string formattedSalary = $"Rs. {salary:N0}";

            // Show success message with details
            string message = $"Teacher Added Successfully!\n\n" +
                           $"Employee ID: {generatedEmployeeId}\n" +
                           $"Name: {txtName.Text}\n" +
                           $"Department: {cmbDepartment.SelectedItem}\n" +
                           $"Qualification: {cmbQualification.SelectedItem}\n" +
                           $"Date of Joining: {dtpJoiningDate.Value:dd-MMM-yyyy}\n" +
                           $"Monthly Salary: {formattedSalary}\n" +
                           $"Status: {cmbStatus.SelectedItem}";

            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Ask to add another
            DialogResult result = MessageBox.Show("Do you want to add another teacher?",
                "Add Another", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ResetForm();
                GenerateEmployeeId();
            }
            else
            {
                this.Close();
            }
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel? All entered data will be lost.",
                "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnReset_Click(object? sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to reset all fields?",
                "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ResetForm();
            }
        }

        #endregion

        #region Validation & Helper Methods

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

            // Date of Birth - at least 18 years old
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
                MessageBox.Show("Please select department/subject.", "Validation Error",
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

        private void ResetForm()
        {
            // Clear all text fields
            txtName.Clear();
            txtCNIC.Clear();
            txtContactNumber.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtSalary.Text = "25000";
            txtEmergencyContact.Clear();
            txtEmergencyName.Clear();
            txtSkills.Clear();

            // Reset combo boxes
            cmbGender.SelectedIndex = -1;
            cmbQualification.SelectedIndex = -1;
            cmbDepartment.SelectedIndex = -1;
            cmbExperience.SelectedIndex = -1;
            cmbStatus.SelectedIndex = 0;

            // Reset date pickers
            dtpDateOfBirth.Value = DateTime.Now.AddYears(-25);
            dtpJoiningDate.Value = DateTime.Now;

            // Clear validation labels
            lblNameValidation.Text = "";
            lblContactValidation.Text = "";
            lblEmailValidation.Text = "";
            lblSalaryValidation.Text = "";
            lblEmergencyValidation.Text = "";
            lblCNICValidation.Text = "";

            // Reset textbox backgrounds
            txtName.BackColor = Color.White;
            txtCNIC.BackColor = Color.White;
            txtContactNumber.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
            txtSalary.BackColor = Color.White;
            txtEmergencyContact.BackColor = Color.White;

            txtName.Focus();
        }

        #endregion
    }
}
