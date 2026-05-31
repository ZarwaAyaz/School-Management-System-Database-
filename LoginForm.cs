using System;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    /// <summary>
    /// Login Form for School Management System
    /// Connected to Database
    /// </summary>
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            // Test database connection on form load
            TestDatabaseConnection();
        }

        /// <summary>
        /// Test database connection
        /// </summary>
        private void TestDatabaseConnection()
        {
            try
            {
                if (DatabaseHelper.TestConnection())
                {
                    // Connection successful - silently continue
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Database connection failed:\n{ex.Message}\n\nPlease ensure SQL Server is running.",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        /// <summary>
        /// Login Button Click Handler
        /// Authenticates user against database
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Get selected login type
            string loginType = GetSelectedLoginType();

            // Get input values
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Basic validation
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show(
                    "Please enter your username.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show(
                    "Please enter your password.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtPassword.Focus();
                return;
            }

            // Validate login against database
            int userId, referenceId;
            bool isValid = DatabaseHelper.ValidateLogin(username, password, loginType, out userId, out referenceId);

            if (isValid)
            {
                // Get user's full name
                string fullName = DatabaseHelper.GetUserFullName(referenceId, loginType);

                // Navigate based on login type
                if (loginType == "Teacher")
                {
                    // Open Teacher Dashboard
                    this.Hide();
                    TeacherDashboard teacherDashboard = new TeacherDashboard();
                    teacherDashboard.FormClosed += (s, args) => this.Close();
                    teacherDashboard.Show();
                }
                else if (loginType == "Administrator")
                {
                    // Open Admin Dashboard
                    this.Hide();
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.FormClosed += (s, args) => this.Close();
                    adminDashboard.Show();
                }
                else if (loginType == "Principal")
                {
                    // Principal dashboard not yet implemented
                    MessageBox.Show(
                        $"Welcome {fullName}!\n\nPrincipal Dashboard will be available soon.",
                        "Login Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            else
            {
                // Invalid credentials
                MessageBox.Show(
                    "Invalid username or password.\n\nPlease try again.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        /// <summary>
        /// Clear Button Click Handler
        /// Clears both username and password fields
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        /// <summary>
        /// Gets the currently selected login type from radio buttons
        /// </summary>
        /// <returns>Selected login type as string</returns>
        private string GetSelectedLoginType()
        {
            if (rbAdmin.Checked)
                return "Administrator";
            else if (rbPrincipal.Checked)
                return "Principal";
            else if (rbTeacher.Checked)
                return "Teacher";
            else
                return "Unknown";
        }
    }
}
