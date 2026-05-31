using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SchoolManagementSystem
{
    public partial class AddStudentForm : Form
    {
        private string selectedClass = "";
        private string generatedAdmissionNumber = "";
        private static int admissionCounter = 1001; // Starting admission number
        private readonly string[] sections = { "A", "B", "C", "D" };
        private Random random = new Random();

        // Fee structure based on class
        private readonly Dictionary<string, FeeStructure> classFees = new Dictionary<string, FeeStructure>
        {
            { "Nursery", new FeeStructure(2000, 500, 1000, 15000) },
            { "Prep", new FeeStructure(2200, 500, 1000, 15000) },
            { "Class 1", new FeeStructure(2500, 600, 1200, 18000) },
            { "Class 2", new FeeStructure(2500, 600, 1200, 18000) },
            { "Class 3", new FeeStructure(2800, 700, 1500, 20000) },
            { "Class 4", new FeeStructure(2800, 700, 1500, 20000) },
            { "Class 5", new FeeStructure(3000, 800, 1500, 22000) },
            { "Class 6", new FeeStructure(3200, 800, 1800, 25000) },
            { "Class 7", new FeeStructure(3200, 800, 1800, 25000) },
            { "Class 8", new FeeStructure(3500, 900, 2000, 28000) },
            { "Class 9", new FeeStructure(4000, 1000, 2500, 30000) },
            { "Class 10", new FeeStructure(4000, 1000, 2500, 30000) }
        };

        private const decimal SCHOLARSHIP_PERCENTAGE = 0.20m; // 20% scholarship

        public AddStudentForm()
        {
            InitializeComponent();
            SetupEventHandlers();
            ShowClassSelection();
        }

        private void SetupEventHandlers()
        {
            // Class Selection Panel
            btnSelectClass.Click += BtnSelectClass_Click;
            btnCancelSelection.Click += BtnCancelSelection_Click;

            // Admission Form Panel
            btnSubmitAdmission.Click += BtnSubmitAdmission_Click;
            btnCancelAdmission.Click += BtnCancelAdmission_Click;
            btnBackToClassSelection.Click += BtnBackToClassSelection_Click;

            // Scholarship checkboxes
            chkKinshipScholarship.CheckedChanged += Scholarship_CheckedChanged;
            chkParentTeacher.CheckedChanged += Scholarship_CheckedChanged;

            // Hover effects for buttons
            SetupButtonHoverEffects(btnSelectClass, Color.FromArgb(39, 174, 96), Color.FromArgb(46, 204, 113));
            SetupButtonHoverEffects(btnCancelSelection, Color.FromArgb(149, 165, 166), Color.FromArgb(189, 195, 199));
            SetupButtonHoverEffects(btnSubmitAdmission, Color.FromArgb(39, 174, 96), Color.FromArgb(46, 204, 113));
            SetupButtonHoverEffects(btnCancelAdmission, Color.FromArgb(231, 76, 60), Color.FromArgb(236, 112, 99));
            SetupButtonHoverEffects(btnBackToClassSelection, Color.FromArgb(41, 128, 185), Color.FromArgb(52, 152, 219));
        }

        private void SetupButtonHoverEffects(Button btn, Color normalColor, Color hoverColor)
        {
            btn.MouseEnter += (s, e) => btn.BackColor = hoverColor;
            btn.MouseLeave += (s, e) => btn.BackColor = normalColor;
        }

        private void ShowClassSelection()
        {
            panelClassSelection.Visible = true;
            panelAdmissionForm.Visible = false;
            cmbClassSelection.SelectedIndex = -1;
        }

        private void ShowAdmissionForm()
        {
            panelClassSelection.Visible = false;
            panelAdmissionForm.Visible = true;

            // Generate admission number
            generatedAdmissionNumber = $"ADM-{DateTime.Now.Year}-{admissionCounter:D4}";
            lblAdmissionNumberValue.Text = generatedAdmissionNumber;

            // Set admission date to today
            dtpAdmissionDate.Value = DateTime.Now;

            // Set pre-selected class
            cmbClass.Text = selectedClass;
            cmbClass.Enabled = false; // Class is pre-selected

            // Set default date of birth (10 years ago as typical school age)
            dtpDateOfBirth.Value = DateTime.Now.AddYears(-10);

            // Clear all fields
            ClearFormFields();

            // Calculate and display fees
            CalculateAndDisplayFees();
        }

        private void ClearFormFields()
        {
            txtStudentName.Clear();
            txtFatherName.Clear();
            txtAddress.Clear();
            txtContactNumber.Clear();
            txtPreviousSchool.Clear();
            txtEmergencyContact.Clear();
            cmbGender.SelectedIndex = -1;
            dtpDateOfBirth.Value = DateTime.Now.AddYears(-10);
            dtpAdmissionDate.Value = DateTime.Now;
            chkKinshipScholarship.Checked = false;
            chkParentTeacher.Checked = false;
        }

        private void Scholarship_CheckedChanged(object? sender, EventArgs e)
        {
            CalculateAndDisplayFees();
        }

        private void CalculateAndDisplayFees()
        {
            if (!classFees.ContainsKey(selectedClass))
                return;

            var fee = classFees[selectedClass];
            bool hasScholarship = chkKinshipScholarship.Checked || chkParentTeacher.Checked;

            // Calculate fees
            decimal monthlyFee = fee.MonthlyFee;
            decimal admissionFee = fee.AdmissionFee;
            decimal examFee = fee.ExamFee;
            decimal annualCharges = fee.AnnualCharges;

            decimal scholarshipDiscount = 0;
            decimal discountedMonthlyFee = monthlyFee;

            if (hasScholarship)
            {
                scholarshipDiscount = monthlyFee * SCHOLARSHIP_PERCENTAGE;
                discountedMonthlyFee = monthlyFee - scholarshipDiscount;
            }

            // Calculate total first payment (Admission + First Month + Annual)
            decimal totalFirstPayment = admissionFee + discountedMonthlyFee + annualCharges;

            // Update fee labels
            lblMonthlyFeeValue.Text = $"Rs. {monthlyFee:N0}";
            lblAdmissionFeeValue.Text = $"Rs. {admissionFee:N0}";
            lblExamFeeValue.Text = $"Rs. {examFee:N0} (per term)";
            lblAnnualChargesValue.Text = $"Rs. {annualCharges:N0}";

            if (hasScholarship)
            {
                string scholarshipType = chkKinshipScholarship.Checked ? "Kinship" : "Parent is Teacher";
                lblScholarshipStatus.Text = $"✓ {scholarshipType} Scholarship Applied (20% off monthly fee)";
                lblScholarshipStatus.ForeColor = Color.FromArgb(39, 174, 96);
                lblDiscountValue.Text = $"- Rs. {scholarshipDiscount:N0}";
                lblDiscountValue.ForeColor = Color.FromArgb(39, 174, 96);
                lblDiscountLabel.Visible = true;
                lblDiscountValue.Visible = true;
                lblDiscountedMonthlyValue.Text = $"Rs. {discountedMonthlyFee:N0}";
                lblDiscountedMonthlyLabel.Visible = true;
                lblDiscountedMonthlyValue.Visible = true;
            }
            else
            {
                lblScholarshipStatus.Text = "No scholarship applied";
                lblScholarshipStatus.ForeColor = Color.FromArgb(127, 140, 141);
                lblDiscountLabel.Visible = false;
                lblDiscountValue.Visible = false;
                lblDiscountedMonthlyLabel.Visible = false;
                lblDiscountedMonthlyValue.Visible = false;
            }

            lblTotalFirstPaymentValue.Text = $"Rs. {totalFirstPayment:N0}";
        }

        private void BtnSelectClass_Click(object? sender, EventArgs e)
        {
            if (cmbClassSelection.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a class to continue.", "Selection Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selectedClass = cmbClassSelection.SelectedItem?.ToString() ?? "";
            ShowAdmissionForm();
        }

        private void BtnCancelSelection_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBackToClassSelection_Click(object? sender, EventArgs e)
        {
            ShowClassSelection();
        }

        private void BtnSubmitAdmission_Click(object? sender, EventArgs e)
        {
            // Validate required fields
            if (!ValidateForm())
            {
                return;
            }

            // Randomly assign section
            string assignedSection = sections[random.Next(sections.Length)];

            // Increment admission counter for next admission
            admissionCounter++;

            // Calculate fee details for message
            var fee = classFees[selectedClass];
            bool hasScholarship = chkKinshipScholarship.Checked || chkParentTeacher.Checked;
            string scholarshipInfo = hasScholarship 
                ? $"\nScholarship: {(chkKinshipScholarship.Checked ? "Kinship" : "Parent is Teacher")} (20% discount)"
                : "";
            decimal monthlyFee = hasScholarship ? fee.MonthlyFee * (1 - SCHOLARSHIP_PERCENTAGE) : fee.MonthlyFee;
            decimal totalFirstPayment = fee.AdmissionFee + monthlyFee + fee.AnnualCharges;

            // Show success message with details
            string message = $"Student Admitted Successfully!\n\n" +
                           $"Admission Number: {generatedAdmissionNumber}\n" +
                           $"Student Name: {txtStudentName.Text}\n" +
                           $"Class: {selectedClass}\n" +
                           $"Section: {assignedSection}\n" +
                           $"Admission Date: {dtpAdmissionDate.Value:dd-MMM-yyyy}" +
                           scholarshipInfo +
                           $"\n\nFirst Payment Due: Rs. {totalFirstPayment:N0}";

            MessageBox.Show(message, "Admission Successful",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Ask if they want to add another student
            DialogResult result = MessageBox.Show("Do you want to add another student?",
                "Add Another", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ShowClassSelection();
            }
            else
            {
                this.Close();
            }
        }

        private bool ValidateForm()
        {
            // Student Name
            if (string.IsNullOrWhiteSpace(txtStudentName.Text))
            {
                ShowValidationError("Please enter student name.", txtStudentName);
                return false;
            }

            // Father/Guardian Name
            if (string.IsNullOrWhiteSpace(txtFatherName.Text))
            {
                ShowValidationError("Please enter father/guardian name.", txtFatherName);
                return false;
            }

            // Gender
            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select gender.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGender.Focus();
                return false;
            }

            // Date of Birth - check if student is at least 3 years old
            int age = DateTime.Now.Year - dtpDateOfBirth.Value.Year;
            if (dtpDateOfBirth.Value > DateTime.Now.AddYears(-age)) age--;
            if (age < 3)
            {
                MessageBox.Show("Student must be at least 3 years old.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDateOfBirth.Focus();
                return false;
            }

            // Address
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                ShowValidationError("Please enter address.", txtAddress);
                return false;
            }

            // Contact Number
            if (string.IsNullOrWhiteSpace(txtContactNumber.Text))
            {
                ShowValidationError("Please enter contact number.", txtContactNumber);
                return false;
            }

            // Validate contact number format (basic check for digits)
            if (!IsValidPhoneNumber(txtContactNumber.Text))
            {
                ShowValidationError("Please enter a valid contact number (10-15 digits).", txtContactNumber);
                return false;
            }

            // Emergency Contact
            if (string.IsNullOrWhiteSpace(txtEmergencyContact.Text))
            {
                ShowValidationError("Please enter emergency contact number.", txtEmergencyContact);
                return false;
            }

            if (!IsValidPhoneNumber(txtEmergencyContact.Text))
            {
                ShowValidationError("Please enter a valid emergency contact number (10-15 digits).", txtEmergencyContact);
                return false;
            }

            return true;
        }

        private bool IsValidPhoneNumber(string phone)
        {
            string digitsOnly = new string(phone.Where(char.IsDigit).ToArray());
            return digitsOnly.Length >= 10 && digitsOnly.Length <= 15;
        }

        private void ShowValidationError(string message, Control control)
        {
            MessageBox.Show(message, "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
        }

        private void BtnCancelAdmission_Click(object? sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel? All entered data will be lost.",
                "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Restrict contact number fields to digits only
        private void ContactNumber_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }

    /// <summary>
    /// Fee structure class for storing class-wise fees
    /// </summary>
    public class FeeStructure
    {
        public decimal MonthlyFee { get; set; }
        public decimal AdmissionFee { get; set; }
        public decimal ExamFee { get; set; }
        public decimal AnnualCharges { get; set; }

        public FeeStructure(decimal monthlyFee, decimal admissionFee, decimal examFee, decimal annualCharges)
        {
            MonthlyFee = monthlyFee;
            AdmissionFee = admissionFee;
            ExamFee = examFee;
            AnnualCharges = annualCharges;
        }
    }
}
