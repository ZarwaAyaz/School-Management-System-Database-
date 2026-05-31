using System;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    /// <summary>
    /// Generate Result Card Form for School Management System
    /// Allows teachers to search and generate student result cards
    /// Frontend UI Only - No Backend Functionality
    /// </summary>
    public partial class GenerateResultCardForm : Form
    {
        public GenerateResultCardForm()
        {
            InitializeComponent();
            SetupHoverEffects();
        }

        /// <summary>
        /// Setup hover effects for buttons
        /// </summary>
        private void SetupHoverEffects()
        {
            // Search button hover
            btnSearch.MouseEnter += (s, e) => btnSearch.BackColor = Color.FromArgb(52, 152, 219);
            btnSearch.MouseLeave += (s, e) => btnSearch.BackColor = Color.FromArgb(41, 128, 185);

            // Back button hover
            btnBackToDashboard.MouseEnter += (s, e) => btnBackToDashboard.BackColor = Color.FromArgb(41, 128, 185);
            btnBackToDashboard.MouseLeave += (s, e) => btnBackToDashboard.BackColor = Color.FromArgb(52, 73, 94);

            // Generate button hover
            btnGenerateCard.MouseEnter += (s, e) => btnGenerateCard.BackColor = Color.FromArgb(46, 204, 113);
            btnGenerateCard.MouseLeave += (s, e) => btnGenerateCard.BackColor = Color.FromArgb(39, 174, 96);
        }

        /// <summary>
        /// Search button click handler
        /// Validates input and shows the result card panel
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearchName.Text.Trim();
            string searchRoll = txtSearchRoll.Text.Trim();

            // Validate - at least one field must be filled
            if (string.IsNullOrEmpty(searchName) && string.IsNullOrEmpty(searchRoll))
            {
                MessageBox.Show("Please enter at least one search field (Student Name or Roll Number).", 
                    "Search Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Simulate search - check if student found (using dummy logic)
            bool studentFound = false;

            // Check against dummy data
            if (!string.IsNullOrEmpty(searchName))
            {
                // Simple contains check for demo
                if (searchName.ToLower().Contains("ali") || 
                    searchName.ToLower().Contains("ahmed") ||
                    searchName.ToLower().Contains("fatima") ||
                    searchName.ToLower().Contains("hassan"))
                {
                    studentFound = true;
                }
            }

            if (!string.IsNullOrEmpty(searchRoll))
            {
                // Check roll numbers 1-10
                if (int.TryParse(searchRoll, out int rollNo) && rollNo >= 1 && rollNo <= 10)
                {
                    studentFound = true;
                }
            }

            if (studentFound)
            {
                // Update student info based on search
                UpdateStudentInfo(searchName, searchRoll);
                
                // Show the result card panel
                panelResultCardContainer.Visible = true;
            }
            else
            {
                // Hide result card and show message
                panelResultCardContainer.Visible = false;
                MessageBox.Show("No student found with the given search criteria.\n\nPlease try:\n• Names: Ali, Ahmed, Fatima, Hassan\n• Roll Numbers: 1-10", 
                    "Student Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Update student information based on search (dummy data)
        /// </summary>
        private void UpdateStudentInfo(string name, string roll)
        {
            // If name contains specific keywords, update accordingly
            if (!string.IsNullOrEmpty(name) && name.ToLower().Contains("fatima"))
            {
                lblStudentNameValue.Text = "Fatima Khan";
                lblFatherNameValue.Text = "Imran Khan";
                lblRollNoValue.Text = "05";
            }
            else if (!string.IsNullOrEmpty(name) && name.ToLower().Contains("hassan"))
            {
                lblStudentNameValue.Text = "Hassan Ali";
                lblFatherNameValue.Text = "Muhammad Ali";
                lblRollNoValue.Text = "03";
            }
            else if (!string.IsNullOrEmpty(roll))
            {
                // Use roll number to determine student
                switch (roll)
                {
                    case "1":
                    case "01":
                        lblStudentNameValue.Text = "Ali Ahmed";
                        lblFatherNameValue.Text = "Ahmed Khan";
                        lblRollNoValue.Text = "01";
                        break;
                    case "2":
                    case "02":
                        lblStudentNameValue.Text = "Sara Malik";
                        lblFatherNameValue.Text = "Malik Riaz";
                        lblRollNoValue.Text = "02";
                        break;
                    case "3":
                    case "03":
                        lblStudentNameValue.Text = "Hassan Ali";
                        lblFatherNameValue.Text = "Muhammad Ali";
                        lblRollNoValue.Text = "03";
                        break;
                    case "5":
                    case "05":
                        lblStudentNameValue.Text = "Fatima Khan";
                        lblFatherNameValue.Text = "Imran Khan";
                        lblRollNoValue.Text = "05";
                        break;
                    default:
                        lblStudentNameValue.Text = "Ali Ahmed";
                        lblFatherNameValue.Text = "Ahmed Khan";
                        lblRollNoValue.Text = roll.PadLeft(2, '0');
                        break;
                }
            }
            else
            {
                // Default to Ali Ahmed
                lblStudentNameValue.Text = "Ali Ahmed";
                lblFatherNameValue.Text = "Ahmed Khan";
                lblRollNoValue.Text = "01";
            }
        }

        /// <summary>
        /// Generate Result Card button click handler
        /// </summary>
        private void btnGenerateCard_Click(object sender, EventArgs e)
        {
            string studentName = lblStudentNameValue.Text;
            string rollNo = lblRollNoValue.Text;

            MessageBox.Show($"Result Card has been generated successfully!\n\n" +
                $"Student: {studentName}\n" +
                $"Roll No: {rollNo}\n" +
                $"Class: Grade 4 - Section A\n\n" +
                $"The result card is ready for printing.",
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
    }
}
