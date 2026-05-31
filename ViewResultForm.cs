using System;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    /// <summary>
    /// View Result Form for School Management System
    /// Frontend UI Only - No Backend Functionality
    /// </summary>
    public partial class ViewResultForm : Form
    {
        // Current student info (dummy data)
        private string currentStudentName = "";
        private string currentRollNo = "";
        private int selectedTerm = 0;

        public ViewResultForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Search Button Click Handler
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string studentName = txtStudentName.Text.Trim();
            string rollNo = txtRollNumber.Text.Trim();

            // Validation: At least one field must be filled
            if (string.IsNullOrEmpty(studentName) && string.IsNullOrEmpty(rollNo))
            {
                MessageBox.Show(
                    "Please enter either Student Name or Roll Number to search.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Simulate finding a student (dummy data)
            if (!string.IsNullOrEmpty(rollNo))
            {
                currentRollNo = rollNo;
                currentStudentName = GetStudentNameByRoll(rollNo);
            }
            else
            {
                currentStudentName = studentName;
                currentRollNo = "01"; // Dummy roll number
            }

            // Update student info display
            lblStudentNameDisplay.Text = currentStudentName;
            lblRollNoDisplay.Text = $"Roll No: {currentRollNo}";
            lblClassDisplay.Text = "Class: Grade 4 – Section A";

            // Show student info and term selection
            panelStudentInfo.Visible = true;
            panelTermSelection.Visible = true;

            // Reset results
            dgvResults.Visible = false;
            lblNoData.Visible = false;
            panelSummary.Visible = false;
            ResetTermButtons();

            MessageBox.Show(
                $"Student Found!\n\nName: {currentStudentName}\nRoll No: {currentRollNo}\n\nPlease select a term to view results.",
                "Student Found",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        /// <summary>
        /// Get student name by roll number (dummy data)
        /// </summary>
        private string GetStudentNameByRoll(string rollNo)
        {
            switch (rollNo)
            {
                case "01": return "Ali Ahmed";
                case "02": return "Fatima Khan";
                case "03": return "Hassan Raza";
                case "04": return "Maryam Noor";
                case "05": return "Usman Tariq";
                case "06": return "Zainab Shafi";
                case "07": return "Bilal Asif";
                case "08": return "Ayesha Malik";
                default: return "Unknown Student";
            }
        }

        /// <summary>
        /// Reset term button colors
        /// </summary>
        private void ResetTermButtons()
        {
            btn1stTerm.BackColor = Color.FromArgb(52, 73, 94);
            btn2ndTerm.BackColor = Color.FromArgb(52, 73, 94);
            btn3rdTerm.BackColor = Color.FromArgb(52, 73, 94);
        }

        /// <summary>
        /// 1st Term Button Click Handler
        /// </summary>
        private void btn1stTerm_Click(object sender, EventArgs e)
        {
            selectedTerm = 1;
            ResetTermButtons();
            btn1stTerm.BackColor = Color.FromArgb(41, 128, 185);
            LoadTermResults(1);
        }

        /// <summary>
        /// 2nd Term Button Click Handler
        /// </summary>
        private void btn2ndTerm_Click(object sender, EventArgs e)
        {
            selectedTerm = 2;
            ResetTermButtons();
            btn2ndTerm.BackColor = Color.FromArgb(41, 128, 185);
            LoadTermResults(2);
        }

        /// <summary>
        /// 3rd Term Button Click Handler
        /// </summary>
        private void btn3rdTerm_Click(object sender, EventArgs e)
        {
            selectedTerm = 3;
            ResetTermButtons();
            btn3rdTerm.BackColor = Color.FromArgb(41, 128, 185);
            LoadTermResults(3);
        }

        /// <summary>
        /// Load results for selected term
        /// </summary>
        private void LoadTermResults(int term)
        {
            dgvResults.Rows.Clear();

            // For demo: 3rd term has no data
            if (term == 3)
            {
                dgvResults.Visible = false;
                panelSummary.Visible = false;
                lblNoData.Visible = true;
                return;
            }

            // Show results grid and summary
            dgvResults.Visible = true;
            panelSummary.Visible = true;
            lblNoData.Visible = false;

            // Dummy subject data based on term
            var subjects = GetSubjectData(term);
            int totalMarks = 0;
            int obtainedMarks = 0;

            foreach (var subject in subjects)
            {
                int rowIndex = dgvResults.Rows.Add(
                    subject.Name,
                    subject.TotalMarks.ToString(),
                    subject.ObtainedMarks.ToString(),
                    subject.Grade
                );

                // Color code the grade
                DataGridViewRow row = dgvResults.Rows[rowIndex];
                if (subject.Grade == "A" || subject.Grade == "A+")
                    row.Cells["colGrade"].Style.ForeColor = Color.FromArgb(39, 174, 96);
                else if (subject.Grade == "B" || subject.Grade == "B+")
                    row.Cells["colGrade"].Style.ForeColor = Color.FromArgb(41, 128, 185);
                else if (subject.Grade == "C")
                    row.Cells["colGrade"].Style.ForeColor = Color.FromArgb(243, 156, 18);
                else if (subject.Grade == "F")
                    row.Cells["colGrade"].Style.ForeColor = Color.FromArgb(231, 76, 60);

                totalMarks += subject.TotalMarks;
                obtainedMarks += subject.ObtainedMarks;
            }

            // Calculate and display summary
            double percentage = (double)obtainedMarks / totalMarks * 100;
            lblOverallPercentageValue.Text = $"{percentage:F1}%";

            // Set position based on term
            if (term == 1)
            {
                lblClassPositionValue.Text = "1st";
                lblClassPositionValue.ForeColor = Color.FromArgb(39, 174, 96);
            }
            else
            {
                lblClassPositionValue.Text = "3rd";
                lblClassPositionValue.ForeColor = Color.FromArgb(41, 128, 185);
            }

            // Attendance
            lblAttendanceValue.Text = term == 1 ? "92%" : "88%";

            // Final status
            if (percentage >= 40)
            {
                lblFinalStatusValue.Text = "PASS";
                lblFinalStatusValue.ForeColor = Color.FromArgb(39, 174, 96);
            }
            else
            {
                lblFinalStatusValue.Text = "FAIL";
                lblFinalStatusValue.ForeColor = Color.FromArgb(231, 76, 60);
            }
        }

        /// <summary>
        /// Get dummy subject data for a term
        /// </summary>
        private SubjectResult[] GetSubjectData(int term)
        {
            if (term == 1)
            {
                return new SubjectResult[]
                {
                    new SubjectResult("Mathematics", 100, 88, "A"),
                    new SubjectResult("English", 100, 82, "A"),
                    new SubjectResult("Science", 100, 90, "A+"),
                    new SubjectResult("Urdu", 100, 78, "B+"),
                    new SubjectResult("Islamiat", 100, 85, "A"),
                    new SubjectResult("Social Studies", 100, 80, "A"),
                    new SubjectResult("Computer", 100, 92, "A+")
                };
            }
            else // term == 2
            {
                return new SubjectResult[]
                {
                    new SubjectResult("Mathematics", 100, 75, "B+"),
                    new SubjectResult("English", 100, 80, "A"),
                    new SubjectResult("Science", 100, 85, "A"),
                    new SubjectResult("Urdu", 100, 72, "B"),
                    new SubjectResult("Islamiat", 100, 88, "A"),
                    new SubjectResult("Social Studies", 100, 70, "B"),
                    new SubjectResult("Computer", 100, 90, "A+")
                };
            }
        }

        /// <summary>
        /// Back Button Click Handler
        /// </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Helper class for subject results
        /// </summary>
        private class SubjectResult
        {
            public string Name { get; }
            public int TotalMarks { get; }
            public int ObtainedMarks { get; }
            public string Grade { get; }

            public SubjectResult(string name, int total, int obtained, string grade)
            {
                Name = name;
                TotalMarks = total;
                ObtainedMarks = obtained;
                Grade = grade;
            }
        }
    }
}
