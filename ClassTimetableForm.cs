using System;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    /// <summary>
    /// Class Timetable Form for School Management System
    /// Displays the weekly timetable for the teacher's assigned class
    /// Frontend UI Only - No Backend Functionality
    /// </summary>
    public partial class ClassTimetableForm : Form
    {
        public ClassTimetableForm()
        {
            InitializeComponent();
            SetupHoverEffects();
        }

        /// <summary>
        /// Setup hover effects for the back button
        /// </summary>
        private void SetupHoverEffects()
        {
            // Back button hover effect
            btnBackToDashboard.MouseEnter += (s, e) => 
            {
                btnBackToDashboard.BackColor = Color.FromArgb(41, 128, 185);
            };
            btnBackToDashboard.MouseLeave += (s, e) => 
            {
                btnBackToDashboard.BackColor = Color.FromArgb(52, 73, 94);
            };
        }

        /// <summary>
        /// Back to Dashboard button click handler
        /// Closes this form and reopens the Teacher Dashboard
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
