using System;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    /// <summary>
    /// Modify Marks Form for School Management System
    /// Allows teachers to modify existing student marks
    /// Frontend UI Only - No Backend Functionality
    /// </summary>
    public partial class ModifyMarksForm : Form
    {
        public ModifyMarksForm()
        {
            InitializeComponent();
            SetupHoverEffects();
            LoadDummySubjects();
            LoadDummyTerms();
        }

        /// <summary>
        /// Setup hover effects for buttons
        /// </summary>
        private void SetupHoverEffects()
        {
            // Load Marks button hover
            btnLoadMarks.MouseEnter += (s, e) => btnLoadMarks.BackColor = Color.FromArgb(52, 152, 219);
            btnLoadMarks.MouseLeave += (s, e) => btnLoadMarks.BackColor = Color.FromArgb(41, 128, 185);

            // Update Marks button hover
            btnUpdateMarks.MouseEnter += (s, e) => btnUpdateMarks.BackColor = Color.FromArgb(46, 204, 113);
            btnUpdateMarks.MouseLeave += (s, e) => btnUpdateMarks.BackColor = Color.FromArgb(39, 174, 96);

            // Back button hover
            btnBackToDashboard.MouseEnter += (s, e) => btnBackToDashboard.BackColor = Color.FromArgb(41, 128, 185);
            btnBackToDashboard.MouseLeave += (s, e) => btnBackToDashboard.BackColor = Color.FromArgb(52, 73, 94);
        }

        /// <summary>
        /// Load dummy subjects into the dropdown
        /// </summary>
        private void LoadDummySubjects()
        {
            cmbSubject.Items.Clear();
            cmbSubject.Items.Add("-- Select Subject --");
            cmbSubject.Items.Add("English");
            cmbSubject.Items.Add("Mathematics");
            cmbSubject.Items.Add("Science");
            cmbSubject.Items.Add("Urdu");
            cmbSubject.Items.Add("Islamiat");
            cmbSubject.Items.Add("Computer");
            cmbSubject.SelectedIndex = 0;
        }

        /// <summary>
        /// Load dummy terms into the dropdown
        /// </summary>
        private void LoadDummyTerms()
        {
            cmbTerm.Items.Clear();
            cmbTerm.Items.Add("-- Select Term --");
            cmbTerm.Items.Add("1st Term");
            cmbTerm.Items.Add("2nd Term");
            cmbTerm.Items.Add("Final Term");
            cmbTerm.SelectedIndex = 0;
        }

        /// <summary>
        /// Load Marks button click handler
        /// </summary>
        private void btnLoadMarks_Click(object sender, EventArgs e)
        {
            // Validate selections
            if (cmbSubject.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a subject.", "Selection Required", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSubject.Focus();
                return;
            }

            if (cmbTerm.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a term.", "Selection Required", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTerm.Focus();
                return;
            }

            // Load dummy student data into the grid
            LoadDummyStudentMarks();

            // Show the marks panel
            panelMarksGrid.Visible = true;
            btnUpdateMarks.Visible = true;

            // Update subtitle
            lblSubtitle.Text = $"Editing marks for {cmbSubject.SelectedItem} - {cmbTerm.SelectedItem}";
        }

        /// <summary>
        /// Load dummy student marks data
        /// </summary>
        private void LoadDummyStudentMarks()
        {
            dgvMarks.Rows.Clear();

            // Get total marks based on term
            int totalMarks = cmbTerm.SelectedItem?.ToString() == "Final Term" ? 100 : 50;

            // Dummy student data with existing marks
            var students = new[]
            {
                new { RollNo = "01", Name = "Ali Ahmed", Marks = totalMarks == 100 ? 88 : 42 },
                new { RollNo = "02", Name = "Sara Malik", Marks = totalMarks == 100 ? 92 : 45 },
                new { RollNo = "03", Name = "Hassan Ali", Marks = totalMarks == 100 ? 85 : 40 },
                new { RollNo = "04", Name = "Ayesha Khan", Marks = totalMarks == 100 ? 78 : 38 },
                new { RollNo = "05", Name = "Fatima Khan", Marks = totalMarks == 100 ? 90 : 44 },
                new { RollNo = "06", Name = "Usman Tariq", Marks = totalMarks == 100 ? 82 : 41 },
                new { RollNo = "07", Name = "Zainab Bibi", Marks = totalMarks == 100 ? 95 : 48 },
                new { RollNo = "08", Name = "Bilal Ahmad", Marks = totalMarks == 100 ? 70 : 35 },
                new { RollNo = "09", Name = "Maryam Noor", Marks = totalMarks == 100 ? 88 : 43 },
                new { RollNo = "10", Name = "Abdullah Raza", Marks = totalMarks == 100 ? 75 : 37 }
            };

            foreach (var student in students)
            {
                dgvMarks.Rows.Add(student.RollNo, student.Name, totalMarks.ToString(), student.Marks.ToString());
            }
        }

        /// <summary>
        /// Update Marks button click handler
        /// </summary>
        private void btnUpdateMarks_Click(object sender, EventArgs e)
        {
            // Validate all marks
            bool isValid = true;
            string errorMessage = "";

            foreach (DataGridViewRow row in dgvMarks.Rows)
            {
                if (row.IsNewRow) continue;

                string rollNo = row.Cells["colRollNo"].Value?.ToString() ?? "";
                string studentName = row.Cells["colStudentName"].Value?.ToString() ?? "";
                string totalMarksStr = row.Cells["colTotalMarks"].Value?.ToString() ?? "0";
                string obtainedMarksStr = row.Cells["colObtainedMarks"].Value?.ToString() ?? "";

                // Check if obtained marks is empty
                if (string.IsNullOrWhiteSpace(obtainedMarksStr))
                {
                    errorMessage = $"Please enter obtained marks for {studentName} (Roll No: {rollNo}).";
                    isValid = false;
                    break;
                }

                // Check if obtained marks is a valid number
                if (!int.TryParse(obtainedMarksStr, out int obtainedMarks))
                {
                    errorMessage = $"Invalid marks entered for {studentName} (Roll No: {rollNo}). Please enter a valid number.";
                    isValid = false;
                    break;
                }

                // Check if obtained marks is negative
                if (obtainedMarks < 0)
                {
                    errorMessage = $"Marks cannot be negative for {studentName} (Roll No: {rollNo}).";
                    isValid = false;
                    break;
                }

                int totalMarks = int.Parse(totalMarksStr);

                // Check if obtained marks exceed total marks
                if (obtainedMarks > totalMarks)
                {
                    errorMessage = $"Obtained marks ({obtainedMarks}) cannot exceed total marks ({totalMarks}) for {studentName} (Roll No: {rollNo}).";
                    isValid = false;
                    break;
                }
            }

            if (!isValid)
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Show success message
            MessageBox.Show($"Marks updated successfully!\n\nSubject: {cmbSubject.SelectedItem}\nTerm: {cmbTerm.SelectedItem}\nStudents Updated: {dgvMarks.Rows.Count}",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Back to Dashboard button click handler
        /// </summary>
        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            // Open Teacher Dashboard
            TeacherDashboard dashboard = new TeacherDashboard();
            dashboard.Show();

            // Close this form
            this.Close();
        }

        /// <summary>
        /// Handle cell validation for the DataGridView
        /// </summary>
        private void dgvMarks_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Only validate the Obtained Marks column
            if (dgvMarks.Columns[e.ColumnIndex].Name == "colObtainedMarks")
            {
                string value = e.FormattedValue?.ToString() ?? "";
                
                if (!string.IsNullOrWhiteSpace(value))
                {
                    if (!int.TryParse(value, out int marks) || marks < 0)
                    {
                        dgvMarks.Rows[e.RowIndex].ErrorText = "Please enter a valid positive number.";
                        e.Cancel = true;
                    }
                    else
                    {
                        string totalMarksStr = dgvMarks.Rows[e.RowIndex].Cells["colTotalMarks"].Value?.ToString() ?? "0";
                        int totalMarks = int.Parse(totalMarksStr);

                        if (marks > totalMarks)
                        {
                            dgvMarks.Rows[e.RowIndex].ErrorText = $"Marks cannot exceed {totalMarks}.";
                            e.Cancel = true;
                        }
                        else
                        {
                            dgvMarks.Rows[e.RowIndex].ErrorText = "";
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Clear error text when cell validation ends
        /// </summary>
        private void dgvMarks_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvMarks.Rows[e.RowIndex].ErrorText = "";
        }
    }
}
