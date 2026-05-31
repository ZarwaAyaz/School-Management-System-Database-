using System;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    /// <summary>
    /// Add Marks Form for School Management System
    /// Frontend UI Only - No Backend Functionality
    /// </summary>
    public partial class AddMarksForm : Form
    {
        // Total marks based on exam type
        private int currentTotalMarks = 25;

        public AddMarksForm()
        {
            InitializeComponent();
            LoadSampleStudents();
        }

        /// <summary>
        /// Get total marks based on exam type
        /// </summary>
        private int GetTotalMarks()
        {
            switch (cmbExamType.SelectedIndex)
            {
                case 0: // Monthly Test
                    return 25;
                case 1: // Midterm
                    return 50;
                case 2: // Final Term
                    return 100;
                case 3: // Assignment
                    return 20;
                default:
                    return 25;
            }
        }

        /// <summary>
        /// Load sample student data into the DataGridView
        /// </summary>
        private void LoadSampleStudents()
        {
            dgvMarks.Rows.Clear();
            currentTotalMarks = GetTotalMarks();

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
                new { RollNo = "08", Name = "Ayesha Malik" },
                new { RollNo = "09", Name = "Ahmed Ali" },
                new { RollNo = "10", Name = "Sara Bibi" }
            };

            // Add each student to the DataGridView
            foreach (var student in students)
            {
                int rowIndex = dgvMarks.Rows.Add(
                    student.RollNo,
                    student.Name,
                    currentTotalMarks.ToString(),
                    "",      // Obtained marks - empty
                    "0%",    // Percentage
                    "-"      // Status
                );
            }
        }

        /// <summary>
        /// Handle exam type change to update total marks
        /// </summary>
        private void cmbExamType_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTotalMarks = GetTotalMarks();
            
            // Update total marks column for all rows
            foreach (DataGridViewRow row in dgvMarks.Rows)
            {
                row.Cells["colTotalMarks"].Value = currentTotalMarks.ToString();
                
                // Recalculate percentage and status if obtained marks exist
                if (row.Cells["colObtainedMarks"].Value != null && 
                    !string.IsNullOrEmpty(row.Cells["colObtainedMarks"].Value.ToString()))
                {
                    CalculatePercentageAndStatus(row.Index);
                }
            }
        }

        /// <summary>
        /// Load Students Button Click Handler
        /// </summary>
        private void btnLoadStudents_Click(object sender, EventArgs e)
        {
            LoadSampleStudents();
            
            MessageBox.Show(
                $"Students loaded for:\n\n" +
                $"Class: {cmbClass.SelectedItem}\n" +
                $"Section: {cmbSection.SelectedItem}\n" +
                $"Subject: {cmbSubject.SelectedItem}\n" +
                $"Exam Type: {cmbExamType.SelectedItem}\n" +
                $"Total Marks: {currentTotalMarks}",
                "Students Loaded",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        /// <summary>
        /// Allow only numeric input in Obtained Marks column
        /// </summary>
        private void dgvMarks_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvMarks.CurrentCell.ColumnIndex == dgvMarks.Columns["colObtainedMarks"].Index)
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.KeyPress -= TextBox_KeyPress;
                    textBox.KeyPress += TextBox_KeyPress;
                }
            }
        }

        /// <summary>
        /// Restrict input to numbers only
        /// </summary>
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (backspace, etc.)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Calculate percentage and status after editing obtained marks
        /// </summary>
        private void dgvMarks_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvMarks.Columns["colObtainedMarks"].Index)
            {
                CalculatePercentageAndStatus(e.RowIndex);
            }
        }

        /// <summary>
        /// Calculate percentage and determine pass/fail status
        /// </summary>
        private void CalculatePercentageAndStatus(int rowIndex)
        {
            DataGridViewRow row = dgvMarks.Rows[rowIndex];
            
            string obtainedStr = row.Cells["colObtainedMarks"].Value?.ToString() ?? "";
            
            if (int.TryParse(obtainedStr, out int obtained))
            {
                // Validate obtained marks
                if (obtained > currentTotalMarks)
                {
                    MessageBox.Show(
                        $"Obtained marks cannot exceed total marks ({currentTotalMarks})!",
                        "Invalid Input",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    row.Cells["colObtainedMarks"].Value = "";
                    row.Cells["colPercentage"].Value = "0%";
                    row.Cells["colStatus"].Value = "-";
                    return;
                }

                if (obtained < 0)
                {
                    MessageBox.Show(
                        "Obtained marks cannot be negative!",
                        "Invalid Input",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    row.Cells["colObtainedMarks"].Value = "";
                    row.Cells["colPercentage"].Value = "0%";
                    row.Cells["colStatus"].Value = "-";
                    return;
                }

                // Calculate percentage
                double percentage = (double)obtained / currentTotalMarks * 100;
                row.Cells["colPercentage"].Value = $"{percentage:F1}%";

                // Determine pass/fail status (40% passing)
                if (percentage >= 40)
                {
                    row.Cells["colStatus"].Value = "Pass";
                    row.Cells["colStatus"].Style.ForeColor = Color.FromArgb(39, 174, 96);
                    row.Cells["colStatus"].Style.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                }
                else
                {
                    row.Cells["colStatus"].Value = "Fail";
                    row.Cells["colStatus"].Style.ForeColor = Color.FromArgb(231, 76, 60);
                    row.Cells["colStatus"].Style.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                }
            }
            else
            {
                row.Cells["colPercentage"].Value = "0%";
                row.Cells["colStatus"].Value = "-";
            }
        }

        /// <summary>
        /// Save Marks Button Click Handler
        /// </summary>
        private void btnSaveMarks_Click(object sender, EventArgs e)
        {
            // Count statistics
            int totalStudents = dgvMarks.Rows.Count;
            int marksEntered = 0;
            int passCount = 0;
            int failCount = 0;

            foreach (DataGridViewRow row in dgvMarks.Rows)
            {
                string obtained = row.Cells["colObtainedMarks"].Value?.ToString() ?? "";
                string status = row.Cells["colStatus"].Value?.ToString() ?? "";

                if (!string.IsNullOrEmpty(obtained))
                {
                    marksEntered++;
                    if (status == "Pass") passCount++;
                    else if (status == "Fail") failCount++;
                }
            }

            // Display summary
            string message = $"Marks Summary\n\n" +
                            $"Class: {cmbClass.SelectedItem}\n" +
                            $"Section: {cmbSection.SelectedItem}\n" +
                            $"Subject: {cmbSubject.SelectedItem}\n" +
                            $"Exam Type: {cmbExamType.SelectedItem}\n\n" +
                            $"Total Students: {totalStudents}\n" +
                            $"Marks Entered: {marksEntered}\n" +
                            $"Passed: {passCount}\n" +
                            $"Failed: {failCount}\n\n" +
                            $"(UI Demo - No data saved to database)";

            MessageBox.Show(
                message,
                "Marks Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        /// <summary>
        /// Clear All Button Click Handler
        /// </summary>
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to clear all entered marks?",
                "Confirm Clear",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvMarks.Rows)
                {
                    row.Cells["colObtainedMarks"].Value = "";
                    row.Cells["colPercentage"].Value = "0%";
                    row.Cells["colStatus"].Value = "-";
                    row.Cells["colStatus"].Style.ForeColor = Color.Black;
                }
            }
        }

        /// <summary>
        /// Go Back Button Click Handler
        /// </summary>
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Back Button (Header) Click Handler
        /// </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
