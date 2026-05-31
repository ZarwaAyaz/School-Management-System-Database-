using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SchoolManagementSystem
{
    public partial class RemoveTeacherForm : Form
    {
        // Sample teacher data for demonstration
        private List<TeacherInfo> teachers = new List<TeacherInfo>
        {
            new TeacherInfo("EMP-2024-1001", "Ahmed Khan", "Mathematics", "Master's (M.Sc)", "0300-1234567", "Active", new DateTime(2015, 3, 1), 65000),
            new TeacherInfo("EMP-2024-1002", "Fatima Ali", "English", "Master's (M.Ed)", "0321-2345678", "Active", new DateTime(2018, 8, 15), 55000),
            new TeacherInfo("EMP-2024-1003", "Muhammad Usman", "Physics", "Ph.D", "0333-3456789", "Active", new DateTime(2016, 1, 10), 75000),
            new TeacherInfo("EMP-2024-1004", "Ayesha Malik", "Urdu", "Master's (M.A)", "0345-4567890", "Probation", new DateTime(2021, 6, 1), 40000),
            new TeacherInfo("EMP-2024-1005", "Hassan Raza", "Computer Science", "Master's (M.Sc)", "0312-5678901", "Active", new DateTime(2010, 9, 1), 80000),
            new TeacherInfo("EMP-2024-1006", "Sara Ahmed", "Art & Drawing", "Bachelor's (B.Ed)", "0300-6789012", "Contract", new DateTime(2023, 2, 15), 35000),
            new TeacherInfo("EMP-2024-1007", "Ali Abbas", "Chemistry", "Master's (M.Phil)", "0321-7890123", "Active", new DateTime(2014, 4, 1), 70000),
            new TeacherInfo("EMP-2024-1008", "Zainab Fatima", "Biology", "Master's (M.Sc)", "0333-8901234", "Active", new DateTime(2019, 7, 1), 50000),
            new TeacherInfo("EMP-2024-1009", "Imran Sheikh", "History", "Ph.D", "0345-9012345", "Active", new DateTime(2005, 1, 1), 90000),
            new TeacherInfo("EMP-2024-1010", "Mariam Bibi", "Islamiat", "Bachelor's (B.A)", "0312-0123456", "On Leave", new DateTime(2017, 8, 1), 45000)
        };

        // Department options for filter
        private readonly string[] departments = {
            "Mathematics", "English", "Science", "Physics", "Chemistry", "Biology",
            "Computer Science", "Social Studies", "History", "Geography", "Urdu",
            "Islamiat", "Art & Drawing", "Physical Education", "Music", "Economics",
            "Accounting", "Business Studies", "Psychology", "Administration"
        };

        public RemoveTeacherForm()
        {
            InitializeComponent();
            SetupForm();
            SetupEventHandlers();
            LoadTeachersToGrid();
        }

        private void SetupForm()
        {
            // Setup department filter
            cmbDepartmentFilter.Items.Add("All Departments");
            cmbDepartmentFilter.Items.AddRange(departments);
            cmbDepartmentFilter.SelectedIndex = 0;
        }

        private void SetupEventHandlers()
        {
            // Search and filter events
            txtSearch.TextChanged += TxtSearch_TextChanged;
            cmbDepartmentFilter.SelectedIndexChanged += CmbDepartmentFilter_SelectedIndexChanged;
            btnClearFilter.Click += BtnClearFilter_Click;

            // DataGridView events
            dgvTeachers.CellDoubleClick += DgvTeachers_CellDoubleClick;
            btnRemoveSelected.Click += BtnRemoveSelected_Click;

            // Hover effects
            SetupButtonHoverEffects(btnRemoveSelected, Color.FromArgb(192, 57, 43), Color.FromArgb(231, 76, 60));
            SetupButtonHoverEffects(btnClearFilter, Color.FromArgb(149, 165, 166), Color.FromArgb(189, 195, 199));
        }

        private void SetupButtonHoverEffects(Button btn, Color normalColor, Color hoverColor)
        {
            btn.MouseEnter += (s, e) => btn.BackColor = hoverColor;
            btn.MouseLeave += (s, e) => btn.BackColor = normalColor;
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

        #region Event Handlers

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
                ShowRemoveConfirmation(e.RowIndex);
            }
        }

        private void BtnRemoveSelected_Click(object? sender, EventArgs e)
        {
            if (dgvTeachers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a teacher to remove.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ShowRemoveConfirmation(dgvTeachers.SelectedRows[0].Index);
        }

        #endregion

        private void ShowRemoveConfirmation(int rowIndex)
        {
            string employeeId = dgvTeachers.Rows[rowIndex].Cells["colEmployeeId"].Value?.ToString() ?? "";
            var teacher = teachers.Find(t => t.EmployeeId == employeeId);

            if (teacher == null)
            {
                MessageBox.Show("Teacher not found.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate years of service
            int yearsOfService = DateTime.Now.Year - teacher.JoiningDate.Year;
            if (DateTime.Now < teacher.JoiningDate.AddYears(yearsOfService)) yearsOfService--;

            // Create custom confirmation dialog
            using (Form confirmDialog = new Form())
            {
                confirmDialog.Text = "Confirm Teacher Removal";
                confirmDialog.Size = new Size(500, 420);
                confirmDialog.StartPosition = FormStartPosition.CenterParent;
                confirmDialog.FormBorderStyle = FormBorderStyle.FixedDialog;
                confirmDialog.MaximizeBox = false;
                confirmDialog.MinimizeBox = false;
                confirmDialog.BackColor = Color.White;

                // Warning Header Panel
                Panel headerPanel = new Panel
                {
                    Dock = DockStyle.Top,
                    Height = 70,
                    BackColor = Color.FromArgb(192, 57, 43)
                };

                Label lblWarningIcon = new Label
                {
                    Text = "⚠",
                    Font = new Font("Segoe UI", 28),
                    ForeColor = Color.White,
                    Location = new Point(20, 12),
                    AutoSize = true
                };

                Label lblWarningTitle = new Label
                {
                    Text = "Remove Teacher",
                    Font = new Font("Segoe UI", 16, FontStyle.Bold),
                    ForeColor = Color.White,
                    Location = new Point(70, 10),
                    AutoSize = true
                };

                Label lblWarningSubtitle = new Label
                {
                    Text = "This action cannot be undone",
                    Font = new Font("Segoe UI", 10),
                    ForeColor = Color.FromArgb(255, 200, 200),
                    Location = new Point(72, 40),
                    AutoSize = true
                };

                headerPanel.Controls.Add(lblWarningIcon);
                headerPanel.Controls.Add(lblWarningTitle);
                headerPanel.Controls.Add(lblWarningSubtitle);

                // Teacher Details Panel
                Panel detailsPanel = new Panel
                {
                    Location = new Point(20, 90),
                    Size = new Size(445, 200),
                    BackColor = Color.FromArgb(250, 250, 250),
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label lblDetailsTitle = new Label
                {
                    Text = "Teacher Details",
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    ForeColor = Color.FromArgb(44, 62, 80),
                    Location = new Point(15, 10),
                    AutoSize = true
                };

                // Detail rows
                int yPos = 40;
                int rowHeight = 28;

                AddDetailRow(detailsPanel, "Employee ID:", teacher.EmployeeId, yPos);
                yPos += rowHeight;
                AddDetailRow(detailsPanel, "Name:", teacher.Name, yPos);
                yPos += rowHeight;
                AddDetailRow(detailsPanel, "Department:", teacher.Department, yPos);
                yPos += rowHeight;
                AddDetailRow(detailsPanel, "Qualification:", teacher.Qualification, yPos);
                yPos += rowHeight;
                AddDetailRow(detailsPanel, "Years of Service:", $"{yearsOfService} year(s)", yPos);
                yPos += rowHeight;
                AddDetailRow(detailsPanel, "Status:", teacher.Status, yPos);

                detailsPanel.Controls.Add(lblDetailsTitle);

                // Warning Message
                Label lblWarningMessage = new Label
                {
                    Text = "⚠ WARNING: Removing this teacher will permanently delete all associated\n" +
                           "    records including class assignments, attendance history, and schedules.",
                    Font = new Font("Segoe UI", 9),
                    ForeColor = Color.FromArgb(192, 57, 43),
                    Location = new Point(20, 305),
                    Size = new Size(445, 40),
                    AutoSize = false
                };

                // Buttons Panel
                Panel buttonPanel = new Panel
                {
                    Location = new Point(20, 350),
                    Size = new Size(445, 50),
                    BackColor = Color.Transparent
                };

                Button btnConfirm = new Button
                {
                    Text = "🗑️ Remove Teacher",
                    Size = new Size(150, 40),
                    Location = new Point(145, 5),
                    BackColor = Color.FromArgb(192, 57, 43),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Cursor = Cursors.Hand
                };
                btnConfirm.FlatAppearance.BorderSize = 0;
                btnConfirm.Click += (s, e) =>
                {
                    confirmDialog.DialogResult = DialogResult.Yes;
                    confirmDialog.Close();
                };

                // Hover effect for confirm button
                btnConfirm.MouseEnter += (s, e) => btnConfirm.BackColor = Color.FromArgb(231, 76, 60);
                btnConfirm.MouseLeave += (s, e) => btnConfirm.BackColor = Color.FromArgb(192, 57, 43);

                Button btnCancel = new Button
                {
                    Text = "Cancel",
                    Size = new Size(100, 40),
                    Location = new Point(305, 5),
                    BackColor = Color.FromArgb(149, 165, 166),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Cursor = Cursors.Hand
                };
                btnCancel.FlatAppearance.BorderSize = 0;
                btnCancel.Click += (s, e) =>
                {
                    confirmDialog.DialogResult = DialogResult.No;
                    confirmDialog.Close();
                };

                // Hover effect for cancel button
                btnCancel.MouseEnter += (s, e) => btnCancel.BackColor = Color.FromArgb(189, 195, 199);
                btnCancel.MouseLeave += (s, e) => btnCancel.BackColor = Color.FromArgb(149, 165, 166);

                buttonPanel.Controls.Add(btnConfirm);
                buttonPanel.Controls.Add(btnCancel);

                // Add all to dialog
                confirmDialog.Controls.Add(headerPanel);
                confirmDialog.Controls.Add(detailsPanel);
                confirmDialog.Controls.Add(lblWarningMessage);
                confirmDialog.Controls.Add(buttonPanel);

                // Show dialog
                DialogResult result = confirmDialog.ShowDialog(this);

                if (result == DialogResult.Yes)
                {
                    RemoveTeacher(teacher);
                }
            }
        }

        private void AddDetailRow(Panel panel, string label, string value, int yPos)
        {
            Label lblLabel = new Label
            {
                Text = label,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.FromArgb(127, 140, 141),
                Location = new Point(15, yPos),
                Size = new Size(120, 20)
            };

            Label lblValue = new Label
            {
                Text = value,
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location = new Point(140, yPos),
                AutoSize = true
            };

            panel.Controls.Add(lblLabel);
            panel.Controls.Add(lblValue);
        }

        private void RemoveTeacher(TeacherInfo teacher)
        {
            // Remove from list
            teachers.Remove(teacher);

            // Refresh grid
            FilterTeachers();

            // Show success message
            MessageBox.Show(
                $"Teacher '{teacher.Name}' (ID: {teacher.EmployeeId}) has been successfully removed from the system.",
                "Teacher Removed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

    /// <summary>
    /// Teacher information class for remove form
    /// </summary>
    public class TeacherInfo
    {
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Qualification { get; set; }
        public string ContactNumber { get; set; }
        public string Status { get; set; }
        public DateTime JoiningDate { get; set; }
        public decimal Salary { get; set; }

        public TeacherInfo(string employeeId, string name, string department, string qualification,
            string contactNumber, string status, DateTime joiningDate, decimal salary)
        {
            EmployeeId = employeeId;
            Name = name;
            Department = department;
            Qualification = qualification;
            ContactNumber = contactNumber;
            Status = status;
            JoiningDate = joiningDate;
            Salary = salary;
        }
    }
}
