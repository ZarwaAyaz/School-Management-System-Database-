using System;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    /// <summary>
    /// Attendance Form for School Management System
    /// Frontend UI Only - No Backend Functionality
    /// </summary>
    public partial class AttendanceForm : Form
    {
        public AttendanceForm()
        {
            InitializeComponent();
            LoadSampleStudents();
        }

        /// <summary>
        /// Load sample student data into the DataGridView
        /// </summary>
        private void LoadSampleStudents()
        {
            // Sample student data (hardcoded for UI demo)
            var students = new[]
            {
                new { RollNo = "01", Name = "Ali Ahmed" },
                new { RollNo = "02", Name = "Fatima Khan" },
                new { RollNo = "03", Name = "Hassan Raza" },
                new { RollNo = "04", Name = "Maryam Noor" },
                new { RollNo = "05", Name = "Usman Tariq" },
                new { RollNo = "06", Name = "Zainab Shafi" },
                new { RollNo = "07", Name = "Bilal Asif" },
                new { RollNo = "08", Name = "Ayesha Malik" }
            };

            // Add each student to the DataGridView
            foreach (var student in students)
            {
                // Add row with Roll No, Name, and default Present checked
                int rowIndex = dgvAttendance.Rows.Add(student.RollNo, student.Name, true, false, false);
            }
        }

        /// <summary>
        /// Handle cell click to ensure only one attendance option is selected
        /// (Radio button behavior using checkboxes)
        /// </summary>
        private void dgvAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if it's a valid row and one of the attendance columns
            if (e.RowIndex >= 0 && e.ColumnIndex >= 2 && e.ColumnIndex <= 4)
            {
                // Get the current row
                DataGridViewRow row = dgvAttendance.Rows[e.RowIndex];

                // Commit the edit first
                dgvAttendance.CommitEdit(DataGridViewDataErrorContexts.Commit);

                // Get current cell value
                bool currentValue = Convert.ToBoolean(row.Cells[e.ColumnIndex].Value);

                // If the checkbox is being checked, uncheck others in the same row
                if (currentValue)
                {
                    // Uncheck all attendance columns
                    row.Cells["colPresent"].Value = false;
                    row.Cells["colAbsent"].Value = false;
                    row.Cells["colLeave"].Value = false;

                    // Check only the clicked one
                    row.Cells[e.ColumnIndex].Value = true;
                }
                else
                {
                    // If unchecking, default to Present
                    row.Cells["colPresent"].Value = true;
                }

                dgvAttendance.RefreshEdit();
            }
        }

        /// <summary>
        /// Save Attendance Button Click Handler
        /// </summary>
        private void btnSaveAttendance_Click(object sender, EventArgs e)
        {
            // Count attendance statistics
            int presentCount = 0;
            int absentCount = 0;
            int leaveCount = 0;

            foreach (DataGridViewRow row in dgvAttendance.Rows)
            {
                if (Convert.ToBoolean(row.Cells["colPresent"].Value))
                    presentCount++;
                else if (Convert.ToBoolean(row.Cells["colAbsent"].Value))
                    absentCount++;
                else if (Convert.ToBoolean(row.Cells["colLeave"].Value))
                    leaveCount++;
            }

            // Display summary (UI Demo only)
            string message = $"Attendance Summary\n\n" +
                            $"Date: {dtpAttendanceDate.Value.ToLongDateString()}\n" +
                            $"Class: Grade 4 – Section A\n\n" +
                            $"Present: {presentCount} students\n" +
                            $"Absent: {absentCount} students\n" +
                            $"Leave: {leaveCount} students\n\n" +
                            $"Total: {dgvAttendance.Rows.Count} students\n\n" +
                            $"(UI Demo - No data saved to database)";

            MessageBox.Show(
                message,
                "Attendance Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        /// <summary>
        /// Back Button Click Handler
        /// </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
