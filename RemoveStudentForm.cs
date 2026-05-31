using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManagementSystem
{
    public partial class RemoveStudentForm : Form
    {
        // Sample student data (in real app, this would come from database)
        private List<StudentRecord> allStudents = new List<StudentRecord>();
        private StudentRecord? selectedStudent = null;

        public RemoveStudentForm()
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

            // Confirmation Panel
            btnConfirmRemove.Click += BtnConfirmRemove_Click;
            btnCancelRemove.Click += BtnCancelRemove_Click;

            // Hover effects
            SetupButtonHoverEffects(btnSelectStudent, Color.FromArgb(231, 76, 60), Color.FromArgb(236, 112, 99));
            SetupButtonHoverEffects(btnClearFilter, Color.FromArgb(149, 165, 166), Color.FromArgb(189, 195, 199));
            SetupButtonHoverEffects(btnCancelSearch, Color.FromArgb(149, 165, 166), Color.FromArgb(189, 195, 199));
            SetupButtonHoverEffects(btnConfirmRemove, Color.FromArgb(231, 76, 60), Color.FromArgb(192, 57, 43));
            SetupButtonHoverEffects(btnCancelRemove, Color.FromArgb(149, 165, 166), Color.FromArgb(189, 195, 199));
        }

        private void SetupButtonHoverEffects(Button btn, Color normalColor, Color hoverColor)
        {
            btn.MouseEnter += (s, e) => btn.BackColor = hoverColor;
            btn.MouseLeave += (s, e) => btn.BackColor = normalColor;
        }

        private void ShowSearchPanel()
        {
            panelSearch.Visible = true;
            panelConfirmation.Visible = false;
            LoadStudentsToGrid(allStudents);
            txtSearch.Focus();
        }

        private void ShowConfirmationPanel()
        {
            panelSearch.Visible = false;
            panelConfirmation.Visible = true;
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
                SelectStudentForRemoval();
            }
        }

        private void BtnSelectStudent_Click(object? sender, EventArgs e)
        {
            SelectStudentForRemoval();
        }

        private void SelectStudentForRemoval()
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to remove.", "Selection Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string admissionNumber = dgvStudents.SelectedRows[0].Cells["colAdmissionNo"].Value?.ToString() ?? "";
            selectedStudent = allStudents.FirstOrDefault(s => s.AdmissionNumber == admissionNumber);

            if (selectedStudent != null)
            {
                PopulateConfirmationPanel(selectedStudent);
                ShowConfirmationPanel();
            }
        }

        private void PopulateConfirmationPanel(StudentRecord student)
        {
            lblConfirmStudentName.Text = student.StudentName;
            lblConfirmAdmissionNo.Text = student.AdmissionNumber;
            lblConfirmClass.Text = $"{student.Class} - Section {student.Section}";
            lblConfirmFatherName.Text = student.FatherName;
            lblConfirmContact.Text = student.ContactNumber;
            lblConfirmAdmissionDate.Text = student.AdmissionDate.ToString("dd-MMM-yyyy");
        }

        private void BtnCancelSearch_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancelRemove_Click(object? sender, EventArgs e)
        {
            selectedStudent = null;
            ShowSearchPanel();
        }

        private void BtnConfirmRemove_Click(object? sender, EventArgs e)
        {
            if (selectedStudent == null)
            {
                MessageBox.Show("No student selected.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Final confirmation with typing requirement
            string studentName = selectedStudent.StudentName;
            string admissionNo = selectedStudent.AdmissionNumber;

            // Show final warning dialog
            DialogResult finalConfirm = MessageBox.Show(
                $"⚠️ FINAL WARNING ⚠️\n\n" +
                $"You are about to PERMANENTLY remove:\n\n" +
                $"Student: {studentName}\n" +
                $"Admission No: {admissionNo}\n\n" +
                $"This action CANNOT be undone!\n\n" +
                $"Are you absolutely sure you want to proceed?",
                "Confirm Permanent Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2); // Default to "No"

            if (finalConfirm == DialogResult.Yes)
            {
                // Remove student from list
                allStudents.Remove(selectedStudent);

                // Show success message
                MessageBox.Show(
                    $"Student Removed Successfully\n\n" +
                    $"Student: {studentName}\n" +
                    $"Admission No: {admissionNo}\n\n" +
                    $"The student record has been permanently deleted.",
                    "Removal Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                selectedStudent = null;
                ShowSearchPanel();
            }
        }
    }
}
