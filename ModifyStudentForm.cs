using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManagementSystem
{
    public partial class ModifyStudentForm : Form
    {
        // Sample student data (in real app, this would come from database)
        private List<StudentRecord> allStudents = new List<StudentRecord>();
        private StudentRecord? selectedStudent = null;

        public ModifyStudentForm()
        {
            InitializeComponent();
            LoadSampleStudentData();
            SetupEventHandlers();
            ShowSearchPanel();
        }

        private void LoadSampleStudentData()
        {
            // Sample data for demonstration
            allStudents = new List<StudentRecord>
            {
                new StudentRecord("ADM-2025-1001", "Ahmed Khan", "Muhammad Khan", new DateTime(2015, 3, 15), "Male", "House #123, Street 5, Islamabad", "0300-1234567", "0321-7654321", "ABC Primary School", new DateTime(2025, 1, 10), "Class 5", "A"),
                new StudentRecord("ADM-2025-1002", "Fatima Ali", "Ali Hassan", new DateTime(2016, 7, 22), "Female", "Flat #45, Block B, Lahore", "0333-2345678", "0345-8765432", "", new DateTime(2025, 1, 12), "Class 4", "B"),
                new StudentRecord("ADM-2025-1003", "Zain Abbas", "Abbas Malik", new DateTime(2014, 11, 8), "Male", "Village Road, Multan", "0311-3456789", "0322-9876543", "XYZ School", new DateTime(2025, 2, 5), "Class 6", "A"),
                new StudentRecord("ADM-2025-1004", "Ayesha Bibi", "Riaz Ahmed", new DateTime(2017, 5, 30), "Female", "Main Market, Karachi", "0344-4567890", "0333-1234567", "", new DateTime(2025, 1, 20), "Class 3", "C"),
                new StudentRecord("ADM-2025-1005", "Hassan Raza", "Raza Khan", new DateTime(2013, 9, 12), "Male", "University Road, Peshawar", "0355-5678901", "0344-2345678", "Model School", new DateTime(2025, 3, 1), "Class 7", "B"),
                new StudentRecord("ADM-2025-1006", "Maryam Nawaz", "Nawaz Sharif", new DateTime(2018, 1, 25), "Female", "Garden Town, Faisalabad", "0366-6789012", "0355-3456789", "", new DateTime(2025, 2, 15), "Class 2", "A"),
                new StudentRecord("ADM-2025-1007", "Usman Ali", "Ali Raza", new DateTime(2015, 6, 18), "Male", "Civil Lines, Rawalpindi", "0377-7890123", "0366-4567890", "Green Valley School", new DateTime(2025, 1, 25), "Class 5", "D"),
                new StudentRecord("ADM-2025-1008", "Sara Khan", "Imran Khan", new DateTime(2016, 12, 3), "Female", "Model Town, Sialkot", "0388-8901234", "0377-5678901", "", new DateTime(2025, 2, 28), "Class 4", "C"),
                new StudentRecord("ADM-2024-0998", "Bilal Ahmed", "Ahmed Shah", new DateTime(2012, 4, 20), "Male", "Satellite Town, Gujranwala", "0399-9012345", "0388-6789012", "City School", new DateTime(2024, 8, 15), "Class 8", "A"),
                new StudentRecord("ADM-2024-0999", "Hina Tariq", "Tariq Mehmood", new DateTime(2011, 8, 14), "Female", "Cantt Area, Quetta", "0300-0123456", "0399-7890123", "Army Public School", new DateTime(2024, 9, 1), "Class 9", "B")
            };
        }

        private void SetupEventHandlers()
        {
            // Search Panel
            txtSearch.TextChanged += TxtSearch_TextChanged;
            cmbFilterClass.SelectedIndexChanged += FilterChanged;
            btnClearFilter.Click += BtnClearFilter_Click;
            btnSelectStudent.Click += BtnSelectStudent_Click;
            btnCancelSearch.Click += BtnCancelSearch_Click;
            dgvStudents.SelectionChanged += DgvStudents_SelectionChanged;
            dgvStudents.CellDoubleClick += DgvStudents_CellDoubleClick;

            // Edit Form Panel
            btnSaveChanges.Click += BtnSaveChanges_Click;
            btnCancelEdit.Click += BtnCancelEdit_Click;
            btnBackToSearch.Click += BtnBackToSearch_Click;

            // Hover effects
            SetupButtonHoverEffects(btnSelectStudent, Color.FromArgb(41, 128, 185), Color.FromArgb(52, 152, 219));
            SetupButtonHoverEffects(btnClearFilter, Color.FromArgb(149, 165, 166), Color.FromArgb(189, 195, 199));
            SetupButtonHoverEffects(btnCancelSearch, Color.FromArgb(149, 165, 166), Color.FromArgb(189, 195, 199));
            SetupButtonHoverEffects(btnSaveChanges, Color.FromArgb(39, 174, 96), Color.FromArgb(46, 204, 113));
            SetupButtonHoverEffects(btnCancelEdit, Color.FromArgb(231, 76, 60), Color.FromArgb(236, 112, 99));
            SetupButtonHoverEffects(btnBackToSearch, Color.FromArgb(41, 128, 185), Color.FromArgb(52, 152, 219));
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
            LoadStudentsToGrid(allStudents);
            txtSearch.Focus();
        }

        private void ShowEditForm()
        {
            panelSearch.Visible = false;
            panelEditForm.Visible = true;
        }

        private void LoadStudentsToGrid(List<StudentRecord> students)
        {
            dgvStudents.Rows.Clear();
            foreach (var student in students)
            {
                dgvStudents.Rows.Add(
                    student.AdmissionNumber,
                    student.StudentName,
                    student.FatherName,
                    student.Class,
                    student.Section,
                    student.ContactNumber
                );
            }

            lblResultCount.Text = $"Showing {students.Count} student(s)";
        }

        private void TxtSearch_TextChanged(object? sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void FilterChanged(object? sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            string searchText = txtSearch.Text.ToLower().Trim();
            string selectedClass = cmbFilterClass.SelectedIndex > 0 ? cmbFilterClass.SelectedItem?.ToString() ?? "" : "";

            var filteredStudents = allStudents.Where(s =>
            {
                bool matchesSearch = string.IsNullOrEmpty(searchText) ||
                    s.StudentName.ToLower().Contains(searchText) ||
                    s.AdmissionNumber.ToLower().Contains(searchText) ||
                    s.FatherName.ToLower().Contains(searchText);

                bool matchesClass = string.IsNullOrEmpty(selectedClass) ||
                    s.Class == selectedClass;

                return matchesSearch && matchesClass;
            }).ToList();

            LoadStudentsToGrid(filteredStudents);
        }

        private void BtnClearFilter_Click(object? sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbFilterClass.SelectedIndex = 0;
            LoadStudentsToGrid(allStudents);
        }

        private void DgvStudents_SelectionChanged(object? sender, EventArgs e)
        {
            btnSelectStudent.Enabled = dgvStudents.SelectedRows.Count > 0;
        }

        private void DgvStudents_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectAndEditStudent();
            }
        }

        private void BtnSelectStudent_Click(object? sender, EventArgs e)
        {
            SelectAndEditStudent();
        }

        private void SelectAndEditStudent()
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to modify.", "Selection Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string admissionNumber = dgvStudents.SelectedRows[0].Cells["colAdmissionNo"].Value?.ToString() ?? "";
            selectedStudent = allStudents.FirstOrDefault(s => s.AdmissionNumber == admissionNumber);

            if (selectedStudent != null)
            {
                PopulateEditForm(selectedStudent);
                ShowEditForm();
            }
        }

        private void PopulateEditForm(StudentRecord student)
        {
            // Admission Number (Read-only)
            lblAdmissionNumberValue.Text = student.AdmissionNumber;

            // Editable fields
            txtStudentName.Text = student.StudentName;
            txtFatherName.Text = student.FatherName;
            dtpDateOfBirth.Value = student.DateOfBirth;
            cmbGender.SelectedItem = student.Gender;
            txtAddress.Text = student.Address;
            txtContactNumber.Text = student.ContactNumber;
            txtEmergencyContact.Text = student.EmergencyContact;
            txtPreviousSchool.Text = student.PreviousSchool;
            dtpAdmissionDate.Value = student.AdmissionDate;
            cmbClass.SelectedItem = student.Class;
            cmbSection.SelectedItem = student.Section;
        }

        private void BtnCancelSearch_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBackToSearch_Click(object? sender, EventArgs e)
        {
            selectedStudent = null;
            ShowSearchPanel();
        }

        private void BtnSaveChanges_Click(object? sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }

            if (selectedStudent == null)
            {
                MessageBox.Show("No student selected.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update student record
            selectedStudent.StudentName = txtStudentName.Text.Trim();
            selectedStudent.FatherName = txtFatherName.Text.Trim();
            selectedStudent.DateOfBirth = dtpDateOfBirth.Value;
            selectedStudent.Gender = cmbGender.SelectedItem?.ToString() ?? "Male";
            selectedStudent.Address = txtAddress.Text.Trim();
            selectedStudent.ContactNumber = txtContactNumber.Text.Trim();
            selectedStudent.EmergencyContact = txtEmergencyContact.Text.Trim();
            selectedStudent.PreviousSchool = txtPreviousSchool.Text.Trim();
            selectedStudent.AdmissionDate = dtpAdmissionDate.Value;
            selectedStudent.Class = cmbClass.SelectedItem?.ToString() ?? "";
            selectedStudent.Section = cmbSection.SelectedItem?.ToString() ?? "";

            // Show success message
            MessageBox.Show($"Student record updated successfully!\n\n" +
                          $"Admission Number: {selectedStudent.AdmissionNumber}\n" +
                          $"Student Name: {selectedStudent.StudentName}\n" +
                          $"Class: {selectedStudent.Class} - Section {selectedStudent.Section}",
                "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Go back to search
            ShowSearchPanel();
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

            if (!IsValidPhoneNumber(txtContactNumber.Text))
            {
                ShowValidationError("Please enter a valid contact number.", txtContactNumber);
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
                ShowValidationError("Please enter a valid emergency contact number.", txtEmergencyContact);
                return false;
            }

            // Class
            if (cmbClass.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a class.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbClass.Focus();
                return false;
            }

            // Section
            if (cmbSection.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a section.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSection.Focus();
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

        private void BtnCancelEdit_Click(object? sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel? All unsaved changes will be lost.",
                "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ShowSearchPanel();
            }
        }
    }

    /// <summary>
    /// Student record data class
    /// </summary>
    public class StudentRecord
    {
        public string AdmissionNumber { get; set; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string EmergencyContact { get; set; }
        public string PreviousSchool { get; set; }
        public DateTime AdmissionDate { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }

        public StudentRecord(string admissionNumber, string studentName, string fatherName,
            DateTime dateOfBirth, string gender, string address, string contactNumber,
            string emergencyContact, string previousSchool, DateTime admissionDate,
            string className, string section)
        {
            AdmissionNumber = admissionNumber;
            StudentName = studentName;
            FatherName = fatherName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Address = address;
            ContactNumber = contactNumber;
            EmergencyContact = emergencyContact;
            PreviousSchool = previousSchool;
            AdmissionDate = admissionDate;
            Class = className;
            Section = section;
        }
    }
}
