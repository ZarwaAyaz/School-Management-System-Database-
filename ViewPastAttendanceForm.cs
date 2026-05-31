using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManagementSystem
{
    public partial class ViewPastAttendanceForm : Form
    {
        private List<StudentAttendanceRecord> attendanceRecords = new List<StudentAttendanceRecord>();
        private string teacherName = "Ahmed Khan";
        private string assignedClass = "Class 5";
        private DateTime selectedDate;
        private bool isEditMode = false;

        public ViewPastAttendanceForm()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            selectedDate = DateTime.Today;
            dtpAttendanceDate.Value = selectedDate;
            dtpAttendanceDate.MaxDate = DateTime.Today;
            
            // Set teacher info
            lblTeacherInfo.Text = $"Teacher: {teacherName} | Assigned Class: {assignedClass}";
            
            LoadAttendanceData();
        }

        private void LoadAttendanceData()
        {
            // Generate sample attendance data for the selected date
            attendanceRecords = new List<StudentAttendanceRecord>
            {
                new StudentAttendanceRecord("2024-001", "Ali Hassan", "5", "A", 1, "Present"),
                new StudentAttendanceRecord("2024-002", "Fatima Zahra", "5", "A", 2, "Present"),
                new StudentAttendanceRecord("2024-003", "Muhammad Bilal", "5", "A", 3, "Absent"),
                new StudentAttendanceRecord("2024-004", "Ayesha Khan", "5", "A", 4, "Present"),
                new StudentAttendanceRecord("2024-005", "Usman Ali", "5", "A", 5, "Present"),
                new StudentAttendanceRecord("2024-006", "Zainab Malik", "5", "A", 6, "On Leave"),
                new StudentAttendanceRecord("2024-007", "Hassan Raza", "5", "A", 7, "Present"),
                new StudentAttendanceRecord("2024-008", "Maryam Ahmed", "5", "A", 8, "Present"),
                new StudentAttendanceRecord("2024-009", "Abdullah Shah", "5", "A", 9, "Present"),
                new StudentAttendanceRecord("2024-010", "Sana Iqbal", "5", "A", 10, "Absent"),
                new StudentAttendanceRecord("2024-011", "Hamza Khalid", "5", "A", 11, "Present"),
                new StudentAttendanceRecord("2024-012", "Noor Fatima", "5", "A", 12, "Present"),
                new StudentAttendanceRecord("2024-013", "Saad Ahmad", "5", "A", 13, "Present"),
                new StudentAttendanceRecord("2024-014", "Hira Nawaz", "5", "A", 14, "On Leave"),
                new StudentAttendanceRecord("2024-015", "Talha Mehmood", "5", "A", 15, "Present"),
                new StudentAttendanceRecord("2024-016", "Amina Bibi", "5", "A", 16, "Present"),
                new StudentAttendanceRecord("2024-017", "Bilal Hussain", "5", "A", 17, "Present"),
                new StudentAttendanceRecord("2024-018", "Rabia Siddiqui", "5", "A", 18, "Present"),
                new StudentAttendanceRecord("2024-019", "Farhan Ali", "5", "A", 19, "Present"),
                new StudentAttendanceRecord("2024-020", "Zara Khan", "5", "A", 20, "Present")
            };

            DisplayAttendance();
        }

        private void DisplayAttendance()
        {
            dgvAttendance.Rows.Clear();

            foreach (var record in attendanceRecords)
            {
                int rowIndex = dgvAttendance.Rows.Add(
                    record.AdmissionNo,
                    record.StudentName,
                    record.RollNo,
                    record.Status
                );

                UpdateRowColor(rowIndex, record.Status);
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

        private void UpdateStatistics()
        {
            int total = attendanceRecords.Count;
            int present = attendanceRecords.Count(r => r.Status == "Present");
            int absent = attendanceRecords.Count(r => r.Status == "Absent");
            int onLeave = attendanceRecords.Count(r => r.Status == "On Leave");

            lblTotalCount.Text = total.ToString();
            lblPresentCount.Text = present.ToString();
            lblAbsentCount.Text = absent.ToString();
            lblLeaveCount.Text = onLeave.ToString();

            // Calculate percentage
            double presentPercent = total > 0 ? (present * 100.0 / total) : 0;
            lblAttendancePercent.Text = $"{presentPercent:F1}%";
        }

        private void DtpAttendanceDate_ValueChanged(object sender, EventArgs e)
        {
            selectedDate = dtpAttendanceDate.Value;
            LoadAttendanceData();
            MessageBox.Show(
                $"Loaded attendance for {selectedDate.ToString("dd-MM-yyyy")}",
                "Date Changed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void BtnEditAttendance_Click(object sender, EventArgs e)
        {
            if (!isEditMode)
            {
                // Enter edit mode
                isEditMode = true;
                btnEditAttendance.Text = "💾 Save Changes";
                btnEditAttendance.BackColor = Color.FromArgb(39, 174, 96);
                btnCancelEdit.Visible = true;
                dgvAttendance.ReadOnly = false;
                lblEditMode.Visible = true;
            }
            else
            {
                // Save changes
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to save the attendance changes for {selectedDate.ToString("dd-MM-yyyy")}?\n\n" +
                    "This will update the attendance records permanently.",
                    "Confirm Save",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    // Save the changes
                    SaveAttendanceChanges();
                    ExitEditMode();
                    MessageBox.Show(
                        "Attendance updated successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
        }

        private void SaveAttendanceChanges()
        {
            // Update records from grid
            for (int i = 0; i < dgvAttendance.Rows.Count; i++)
            {
                string admissionNo = dgvAttendance.Rows[i].Cells[0].Value?.ToString() ?? "";
                string newStatus = dgvAttendance.Rows[i].Cells[3].Value?.ToString() ?? "Present";

                var record = attendanceRecords.FirstOrDefault(r => r.AdmissionNo == admissionNo);
                if (record != null)
                {
                    record.Status = newStatus;
                    UpdateRowColor(i, newStatus);
                }
            }

            UpdateStatistics();
        }

        private void BtnCancelEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel? All unsaved changes will be lost.",
                "Cancel Edit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                LoadAttendanceData(); // Reload original data
                ExitEditMode();
            }
        }

        private void ExitEditMode()
        {
            isEditMode = false;
            btnEditAttendance.Text = "✏️ Edit Attendance";
            btnEditAttendance.BackColor = Color.FromArgb(41, 128, 185);
            btnCancelEdit.Visible = false;
            dgvAttendance.ReadOnly = true;
            lblEditMode.Visible = false;
        }

        private void DgvAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!isEditMode || e.RowIndex < 0 || e.ColumnIndex != 3) return;

            string admissionNo = dgvAttendance.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? "";
            string currentStatus = dgvAttendance.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? "Present";
            
            ShowStatusMenu(e.RowIndex, admissionNo, currentStatus);
        }

        private void ShowStatusMenu(int rowIndex, string admissionNo, string currentStatus)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Font = new Font("Segoe UI", 10F);

            ToolStripMenuItem presentItem = new ToolStripMenuItem("✓ Present");
            presentItem.BackColor = Color.FromArgb(232, 245, 233);
            presentItem.ForeColor = Color.FromArgb(27, 94, 32);
            presentItem.Click += (s, e) => UpdateStatus(rowIndex, admissionNo, "Present");

            ToolStripMenuItem absentItem = new ToolStripMenuItem("✗ Absent");
            absentItem.BackColor = Color.FromArgb(255, 235, 238);
            absentItem.ForeColor = Color.FromArgb(183, 28, 28);
            absentItem.Click += (s, e) => UpdateStatus(rowIndex, admissionNo, "Absent");

            ToolStripMenuItem leaveItem = new ToolStripMenuItem("◉ On Leave");
            leaveItem.BackColor = Color.FromArgb(255, 243, 224);
            leaveItem.ForeColor = Color.FromArgb(230, 81, 0);
            leaveItem.Click += (s, e) => UpdateStatus(rowIndex, admissionNo, "On Leave");

            menu.Items.Add(presentItem);
            menu.Items.Add(absentItem);
            menu.Items.Add(leaveItem);

            menu.Show(dgvAttendance, dgvAttendance.PointToClient(Cursor.Position));
        }

        private void UpdateStatus(int rowIndex, string admissionNo, string newStatus)
        {
            dgvAttendance.Rows[rowIndex].Cells[3].Value = newStatus;
            UpdateRowColor(rowIndex, newStatus);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                MessageBox.Show(
                    "Please save or cancel your changes before going back.",
                    "Unsaved Changes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            this.Close();
            TeacherDashboard dashboard = new TeacherDashboard();
            dashboard.Show();
        }
    }

    public class StudentAttendanceRecord
    {
        public string AdmissionNo { get; set; }
        public string StudentName { get; set; }
        public string ClassName { get; set; }
        public string Section { get; set; }
        public int RollNo { get; set; }
        public string Status { get; set; }

        public StudentAttendanceRecord(string admissionNo, string studentName, string className, 
            string section, int rollNo, string status)
        {
            AdmissionNo = admissionNo;
            StudentName = studentName;
            ClassName = className;
            Section = section;
            RollNo = rollNo;
            Status = status;
        }
    }
}
