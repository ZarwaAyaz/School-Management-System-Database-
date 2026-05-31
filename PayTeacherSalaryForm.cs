using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class PayTeacherSalaryForm : Form
    {
        private List<TeacherSalaryRecord> allTeachers = new List<TeacherSalaryRecord>();
        private List<TeacherSalaryRecord> filteredTeachers = new List<TeacherSalaryRecord>();

        public PayTeacherSalaryForm()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            LoadTeacherData();
            PopulateFilters();
            DisplayTeachers();
            UpdateSummary();
        }

        private void LoadTeacherData()
        {
            // Sample teacher data with salary based on grade
            allTeachers = new List<TeacherSalaryRecord>
            {
                new TeacherSalaryRecord { EmployeeId = "T001", TeacherName = "Ahmed Khan", AssignedGrade = "Class 5", MonthlySalary = 18000, PaymentStatus = "Unpaid" },
                new TeacherSalaryRecord { EmployeeId = "T002", TeacherName = "Fatima Ali", AssignedGrade = "Class 8", MonthlySalary = 20000, PaymentStatus = "Paid" },
                new TeacherSalaryRecord { EmployeeId = "T003", TeacherName = "Hassan Raza", AssignedGrade = "Class 3", MonthlySalary = 16000, PaymentStatus = "Unpaid" },
                new TeacherSalaryRecord { EmployeeId = "T004", TeacherName = "Ayesha Malik", AssignedGrade = "Class 10", MonthlySalary = 22000, PaymentStatus = "Paid" },
                new TeacherSalaryRecord { EmployeeId = "T005", TeacherName = "Bilal Ahmed", AssignedGrade = "Class 1", MonthlySalary = 15000, PaymentStatus = "Unpaid" },
                new TeacherSalaryRecord { EmployeeId = "T006", TeacherName = "Sana Tariq", AssignedGrade = "Class 6", MonthlySalary = 19000, PaymentStatus = "Unpaid" },
                new TeacherSalaryRecord { EmployeeId = "T007", TeacherName = "Usman Zaheer", AssignedGrade = "Class 9", MonthlySalary = 21000, PaymentStatus = "Paid" },
                new TeacherSalaryRecord { EmployeeId = "T008", TeacherName = "Zainab Hussain", AssignedGrade = "Class 4", MonthlySalary = 17000, PaymentStatus = "Unpaid" },
                new TeacherSalaryRecord { EmployeeId = "T009", TeacherName = "Imran Siddiqui", AssignedGrade = "Class 7", MonthlySalary = 19500, PaymentStatus = "Paid" },
                new TeacherSalaryRecord { EmployeeId = "T010", TeacherName = "Maria Khan", AssignedGrade = "Class 2", MonthlySalary = 15500, PaymentStatus = "Unpaid" }
            };

            filteredTeachers = new List<TeacherSalaryRecord>(allTeachers);
        }

        private void PopulateFilters()
        {
            // Populate Grade filter
            cmbGradeFilter.Items.Add("All Grades");
            var grades = allTeachers.Select(t => t.AssignedGrade).Distinct().OrderBy(g => g);
            foreach (var grade in grades)
            {
                cmbGradeFilter.Items.Add(grade);
            }
            cmbGradeFilter.SelectedIndex = 0;

            // Populate Payment Status filter
            cmbStatusFilter.Items.AddRange(new string[] { "All Status", "Paid", "Unpaid" });
            cmbStatusFilter.SelectedIndex = 0;
        }

        private void DisplayTeachers()
        {
            dgvSalary.Rows.Clear();

            foreach (var teacher in filteredTeachers)
            {
                int rowIndex = dgvSalary.Rows.Add(
                    teacher.EmployeeId,
                    teacher.TeacherName,
                    teacher.AssignedGrade,
                    teacher.MonthlySalary.ToString("N0"),
                    teacher.PaymentStatus,
                    teacher.PaymentStatus == "Unpaid" ? "Pay Now" : ""
                );

                DataGridViewRow row = dgvSalary.Rows[rowIndex];
                
                // Color coding for payment status
                if (teacher.PaymentStatus == "Paid")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(232, 245, 233);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(27, 94, 32);
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 238);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(183, 28, 28);
                }
            }
        }

        private void ApplyFilters()
        {
            filteredTeachers = new List<TeacherSalaryRecord>(allTeachers);

            // Filter by teacher name
            string searchText = txtSearchTeacher.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(searchText))
            {
                filteredTeachers = filteredTeachers
                    .Where(t => t.TeacherName.ToLower().Contains(searchText) || 
                               t.EmployeeId.ToLower().Contains(searchText))
                    .ToList();
            }

            // Filter by grade
            if (cmbGradeFilter.SelectedIndex > 0 && cmbGradeFilter.SelectedItem != null)
            {
                string selectedGrade = cmbGradeFilter.SelectedItem.ToString()!;
                filteredTeachers = filteredTeachers.Where(t => t.AssignedGrade == selectedGrade).ToList();
            }

            // Filter by payment status
            if (cmbStatusFilter.SelectedIndex > 0 && cmbStatusFilter.SelectedItem != null)
            {
                string selectedStatus = cmbStatusFilter.SelectedItem.ToString()!;
                filteredTeachers = filteredTeachers.Where(t => t.PaymentStatus == selectedStatus).ToList();
            }

            DisplayTeachers();
            UpdateSummary();
        }

        private void UpdateSummary()
        {
            int totalTeachers = filteredTeachers.Count;
            int paidCount = filteredTeachers.Count(t => t.PaymentStatus == "Paid");
            int unpaidCount = filteredTeachers.Count(t => t.PaymentStatus == "Unpaid");
            decimal totalPaid = filteredTeachers.Where(t => t.PaymentStatus == "Paid").Sum(t => t.MonthlySalary);
            decimal totalPending = filteredTeachers.Where(t => t.PaymentStatus == "Unpaid").Sum(t => t.MonthlySalary);

            lblTotalTeachers.Text = totalTeachers.ToString();
            lblPaidCount.Text = paidCount.ToString();
            lblUnpaidCount.Text = unpaidCount.ToString();
            lblTotalPaid.Text = $"Rs. {totalPaid:N0}";
            lblTotalPending.Text = $"Rs. {totalPending:N0}";
        }

        private void TxtSearchTeacher_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void CmbGradeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void CmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void DgvSalary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvSalary.Columns["colAction"] != null && e.ColumnIndex == dgvSalary.Columns["colAction"]!.Index)
            {
                string? employeeId = dgvSalary.Rows[e.RowIndex].Cells["colEmployeeId"].Value?.ToString();
                string? teacherName = dgvSalary.Rows[e.RowIndex].Cells["colTeacherName"].Value?.ToString();
                string? salary = dgvSalary.Rows[e.RowIndex].Cells["colSalary"].Value?.ToString();
                string? status = dgvSalary.Rows[e.RowIndex].Cells["colStatus"].Value?.ToString();

                if (status == "Unpaid" && employeeId != null && teacherName != null && salary != null)
                {
                    ProcessPayment(employeeId, teacherName, salary, e.RowIndex);
                }
            }
        }

        private void ProcessPayment(string employeeId, string teacherName, string salary, int rowIndex)
        {
            DialogResult result = MessageBox.Show(
                $"Confirm Salary Payment\n\n" +
                $"Employee ID: {employeeId}\n" +
                $"Teacher Name: {teacherName}\n" +
                $"Salary Amount: Rs. {salary}\n\n" +
                $"Do you want to process this payment?",
                "Confirm Payment",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Update payment status
                var teacher = allTeachers.FirstOrDefault(t => t.EmployeeId == employeeId);
                if (teacher != null)
                {
                    teacher.PaymentStatus = "Paid";
                    
                    MessageBox.Show(
                        $"✓ Payment Successful!\n\n" +
                        $"Teacher: {teacherName}\n" +
                        $"Amount: Rs. {salary}\n" +
                        $"Status: Paid",
                        "Payment Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    ApplyFilters();
                }
            }
        }

        private void BtnClearFilters_Click(object sender, EventArgs e)
        {
            txtSearchTeacher.Clear();
            cmbGradeFilter.SelectedIndex = 0;
            cmbStatusFilter.SelectedIndex = 0;
            ApplyFilters();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvSalary_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = dgvSalary.Columns[e.ColumnIndex].Name;

            switch (columnName)
            {
                case "colTeacherName":
                    filteredTeachers = filteredTeachers.OrderBy(t => t.TeacherName).ToList();
                    break;
                case "colGrade":
                    filteredTeachers = filteredTeachers.OrderBy(t => t.AssignedGrade).ToList();
                    break;
                case "colSalary":
                    filteredTeachers = filteredTeachers.OrderBy(t => t.MonthlySalary).ToList();
                    break;
                case "colStatus":
                    filteredTeachers = filteredTeachers.OrderBy(t => t.PaymentStatus).ToList();
                    break;
            }

            DisplayTeachers();
        }
    }

    public class TeacherSalaryRecord
    {
        public string EmployeeId { get; set; } = string.Empty;
        public string TeacherName { get; set; } = string.Empty;
        public string AssignedGrade { get; set; } = string.Empty;
        public decimal MonthlySalary { get; set; }
        public string PaymentStatus { get; set; } = string.Empty;
    }
}
