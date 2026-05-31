using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManagementSystem
{
    public partial class MarkTeacherAttendanceForm : Form
    {
        private List<TeacherAttendanceRecord> teachers = new List<TeacherAttendanceRecord>();
        private DateTime selectedDate;

        public MarkTeacherAttendanceForm()
        {
            InitializeComponent();
            SetupForm();
            GenerateTeacherList();
            LoadTeachersToGrid();
        }

        private void SetupForm()
        {
            selectedDate = DateTime.Today;
            dtpAttendanceDate.Value = selectedDate;
            dtpAttendanceDate.MaxDate = DateTime.Today;
        }

        private void GenerateTeacherList()
        {
            teachers = new List<TeacherAttendanceRecord>
            {
                new TeacherAttendanceRecord("EMP-2024-1001", "Ahmed Khan", "Nursery", "Present"),
                new TeacherAttendanceRecord("EMP-2024-1002", "Fatima Ali", "Prep", "Present"),
                new TeacherAttendanceRecord("EMP-2024-1003", "Muhammad Usman", "Class 1", "Present"),
                new TeacherAttendanceRecord("EMP-2024-1004", "Ayesha Malik", "Class 2", "Present"),
                new TeacherAttendanceRecord("EMP-2024-1005", "Hassan Raza", "Class 3", "Present"),
                new TeacherAttendanceRecord("EMP-2024-1006", "Sara Ahmed", "Class 4", "Present"),
                new TeacherAttendanceRecord("EMP-2024-1007", "Ali Abbas", "Class 5", "Present"),
                new TeacherAttendanceRecord("EMP-2024-1008", "Zainab Fatima", "Class 6", "Present"),
                new TeacherAttendanceRecord("EMP-2024-1009", "Imran Sheikh", "Class 7", "Present"),
                new TeacherAttendanceRecord("EMP-2024-1010", "Mariam Bibi", "Class 8", "Present"),
                new TeacherAttendanceRecord("EMP-2024-1011", "Khalid Mahmood", "Class 9", "Present"),
                new TeacherAttendanceRecord("EMP-2024-1012", "Nadia Hussain", "Class 10", "Present"),
                new TeacherAttendanceRecord("EMP-2024-1013", "Tariq Aziz", "Not Assigned", "Present"),
                new TeacherAttendanceRecord("EMP-2024-1014", "Sana Iqbal", "Not Assigned", "Present")
            };
        }

        private void LoadTeachersToGrid()
        {
            dgvAttendance.Rows.Clear();

            foreach (var teacher in teachers)
            {
                int rowIndex = dgvAttendance.Rows.Add(
                    teacher.EmployeeId,
                    teacher.TeacherName,
                    teacher.AssignedClass,
                    teacher.Status
                );

                // Color code the row based on status
                UpdateRowColor(rowIndex, teacher.Status);
            }

            UpdateStatistics();
        }

        private void UpdateRowColor(int rowIndex, string status)
        {
            DataGridViewRow row = dgvAttendance.Rows[rowIndex];
            
            switch (status)
            {
                case "Present":
                    row.DefaultCellStyle.BackColor = Color.FromArgb(232, 245, 233);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(27, 94, 32);
                    break;
                case "Absent":
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 238);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(183, 28, 28);
                    break;
                case "On Leave":
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 243, 224);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(230, 81, 0);
                    break;
            }
        }

        private void DgvAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Check if status column (column 3) was clicked
            if (e.ColumnIndex == 3)
            {
                string? employeeId = dgvAttendance.Rows[e.RowIndex].Cells[0].Value?.ToString();
                string? currentStatus = dgvAttendance.Rows[e.RowIndex].Cells[3].Value?.ToString();
                
                if (employeeId != null && currentStatus != null)
                {
                    // Show context menu to change status
                    ShowStatusMenu(e.RowIndex, employeeId, currentStatus);
                }
            }
        }

        private void ShowStatusMenu(int rowIndex, string employeeId, string currentStatus)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Font = new Font("Segoe UI", 10F);

            ToolStripMenuItem presentItem = new ToolStripMenuItem("✓ Present");
            presentItem.BackColor = Color.FromArgb(232, 245, 233);
            presentItem.ForeColor = Color.FromArgb(27, 94, 32);
            presentItem.Click += (s, e) => UpdateAttendanceStatus(rowIndex, employeeId, "Present");

            ToolStripMenuItem absentItem = new ToolStripMenuItem("✗ Absent");
            absentItem.BackColor = Color.FromArgb(255, 235, 238);
            absentItem.ForeColor = Color.FromArgb(183, 28, 28);
            absentItem.Click += (s, e) => UpdateAttendanceStatus(rowIndex, employeeId, "Absent");

            ToolStripMenuItem leaveItem = new ToolStripMenuItem("◉ On Leave");
            leaveItem.BackColor = Color.FromArgb(255, 243, 224);
            leaveItem.ForeColor = Color.FromArgb(230, 81, 0);
            leaveItem.Click += (s, e) => UpdateAttendanceStatus(rowIndex, employeeId, "On Leave");

            menu.Items.Add(presentItem);
            menu.Items.Add(absentItem);
            menu.Items.Add(leaveItem);

            menu.Show(dgvAttendance, dgvAttendance.PointToClient(Cursor.Position));
        }

        private void UpdateAttendanceStatus(int rowIndex, string employeeId, string newStatus)
        {
            var teacher = teachers.FirstOrDefault(t => t.EmployeeId == employeeId);
            if (teacher != null)
            {
                teacher.Status = newStatus;
                dgvAttendance.Rows[rowIndex].Cells[3].Value = newStatus;
                UpdateRowColor(rowIndex, newStatus);
                UpdateStatistics();
            }
        }

        private void UpdateStatistics()
        {
            int present = teachers.Count(t => t.Status == "Present");
            int absent = teachers.Count(t => t.Status == "Absent");
            int onLeave = teachers.Count(t => t.Status == "On Leave");

            lblPresentCount.Text = present.ToString();
            lblAbsentCount.Text = absent.ToString();
            lblLeaveCount.Text = onLeave.ToString();

            // Highlight affected classes
            var affectedClasses = teachers
                .Where(t => (t.Status == "Absent" || t.Status == "On Leave") && t.AssignedClass != "Not Assigned")
                .Select(t => t.AssignedClass)
                .ToList();

            if (affectedClasses.Any())
            {
                lblAffectedClasses.Text = "Affected Classes: " + string.Join(", ", affectedClasses);
                lblAffectedClasses.ForeColor = Color.FromArgb(231, 76, 60);
                lblAffectedClasses.Visible = true;
            }
            else
            {
                lblAffectedClasses.Visible = false;
            }
        }

        private void BtnMarkAllPresent_Click(object sender, EventArgs e)
        {
            foreach (var teacher in teachers)
            {
                teacher.Status = "Present";
            }
            LoadTeachersToGrid();
            MessageBox.Show("All teachers marked as Present.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DtpAttendanceDate_ValueChanged(object sender, EventArgs e)
        {
            selectedDate = dtpAttendanceDate.Value;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int present = teachers.Count(t => t.Status == "Present");
            int absent = teachers.Count(t => t.Status == "Absent");
            int onLeave = teachers.Count(t => t.Status == "On Leave");

            MessageBox.Show(
                $"Teacher attendance saved successfully!\n\n" +
                $"Date: {selectedDate.ToString("dd-MM-yyyy")}\n" +
                $"Present: {present}\n" +
                $"Absent: {absent}\n" +
                $"On Leave: {onLeave}",
                "Attendance Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
        }
    }

    public class TeacherAttendanceRecord
    {
        public string EmployeeId { get; set; }
        public string TeacherName { get; set; }
        public string AssignedClass { get; set; }
        public string Status { get; set; }

        public TeacherAttendanceRecord(string employeeId, string teacherName, string assignedClass, string status)
        {
            EmployeeId = employeeId;
            TeacherName = teacherName;
            AssignedClass = assignedClass;
            Status = status;
        }
    }
}
