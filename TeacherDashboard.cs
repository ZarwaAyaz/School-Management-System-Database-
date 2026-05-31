using System;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    /// <summary>
    /// Teacher Dashboard Form for School Management System
    /// Frontend UI Only - No Backend Functionality
    /// </summary>
    public partial class TeacherDashboard : Form
    {
        // Track submenu visibility states
        private bool attendanceSubmenuVisible = false;
        private bool marksSubmenuVisible = false;
        private bool resultSubmenuVisible = false;

        public TeacherDashboard()
        {
            InitializeComponent();
            SetupDynamicGreeting();
            UpdateCurrentDate();
        }

        /// <summary>
        /// Setup dynamic greeting based on time of day
        /// </summary>
        private void SetupDynamicGreeting()
        {
            int hour = DateTime.Now.Hour;
            string greeting;
            
            if (hour >= 5 && hour < 12)
                greeting = "Good Morning";
            else if (hour >= 12 && hour < 17)
                greeting = "Good Afternoon";
            else
                greeting = "Good Evening";

            lblGreeting.Text = $"{greeting}, Mr. Ahmad Khan!";
        }

        /// <summary>
        /// Update footer date to current date
        /// </summary>
        private void UpdateCurrentDate()
        {
            lblCurrentDate.Text = DateTime.Now.ToString("MMMM d, yyyy");
        }

        /// <summary>
        /// Collapse all submenus
        /// </summary>
        private void CollapseAllSubmenus()
        {
            panelAttendanceSubmenu.Visible = false;
            panelMarksSubmenu.Visible = false;
            panelResultSubmenu.Visible = false;
            attendanceSubmenuVisible = false;
            marksSubmenuVisible = false;
            resultSubmenuVisible = false;
            RepositionMenuItems();
        }

        /// <summary>
        /// Reposition menu items based on visible submenus
        /// </summary>
        private void RepositionMenuItems()
        {
            int yPosition = 55;
            
            // Attendance button
            btnAttendance.Location = new Point(0, yPosition);
            yPosition += 45;
            
            // Attendance submenu
            if (attendanceSubmenuVisible)
            {
                panelAttendanceSubmenu.Location = new Point(0, yPosition);
                yPosition += 80;
            }
            
            // Add Marks button
            btnAddMarks.Location = new Point(0, yPosition);
            yPosition += 45;
            
            // Marks submenu
            if (marksSubmenuVisible)
            {
                panelMarksSubmenu.Location = new Point(0, yPosition);
                yPosition += 80;
            }
            
            // View Result button
            btnViewResult.Location = new Point(0, yPosition);
            yPosition += 45;
            
            // Result submenu
            if (resultSubmenuVisible)
            {
                panelResultSubmenu.Location = new Point(0, yPosition);
                yPosition += 80;
            }
            
            // Timetable button
            btnTimetable.Location = new Point(0, yPosition);
        }

        /// <summary>
        /// Attendance Button Click - Toggle submenu
        /// </summary>
        private void btnAttendance_Click(object sender, EventArgs e)
        {
            attendanceSubmenuVisible = !attendanceSubmenuVisible;
            panelAttendanceSubmenu.Visible = attendanceSubmenuVisible;
            
            // Update button text arrow
            btnAttendance.Text = attendanceSubmenuVisible 
                ? "  Attendance                       ▲" 
                : "  Attendance                       ▼";
            
            RepositionMenuItems();
        }

        /// <summary>
        /// Mark Attendance submenu click
        /// </summary>
        private void btnMarkAttendance_Click(object sender, EventArgs e)
        {
            AttendanceForm attendanceForm = new AttendanceForm();
            attendanceForm.ShowDialog();
        }

        /// <summary>
        /// View Past Attendance submenu click
        /// </summary>
        private void btnViewPastAttendance_Click(object sender, EventArgs e)
        {
            ViewPastAttendanceForm form = new ViewPastAttendanceForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Add Marks Button Click - Toggle submenu
        /// </summary>
        private void btnAddMarks_Click(object sender, EventArgs e)
        {
            marksSubmenuVisible = !marksSubmenuVisible;
            panelMarksSubmenu.Visible = marksSubmenuVisible;
            
            // Update button text arrow
            btnAddMarks.Text = marksSubmenuVisible 
                ? "  Add Marks                         ▲" 
                : "  Add Marks                         ▼";
            
            RepositionMenuItems();
        }

        /// <summary>
        /// Enter Marks submenu click
        /// </summary>
        private void btnEnterMarks_Click(object sender, EventArgs e)
        {
            AddMarksForm addMarksForm = new AddMarksForm();
            addMarksForm.ShowDialog();
        }

        /// <summary>
        /// Modify Marks submenu click
        /// </summary>
        private void btnModifyMarks_Click(object sender, EventArgs e)
        {
            // Open Modify Marks Form
            ModifyMarksForm modifyMarksForm = new ModifyMarksForm();
            modifyMarksForm.Show();

            // Hide the dashboard
            this.Hide();
        }

        /// <summary>
        /// View Result Button Click - Toggle submenu
        /// </summary>
        private void btnViewResult_Click(object sender, EventArgs e)
        {
            resultSubmenuVisible = !resultSubmenuVisible;
            panelResultSubmenu.Visible = resultSubmenuVisible;
            
            // Update button text arrow
            btnViewResult.Text = resultSubmenuVisible 
                ? "  View Result                       ▲" 
                : "  View Result                       ▼";
            
            RepositionMenuItems();
        }

        /// <summary>
        /// Search by Name submenu click
        /// </summary>
        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            ViewResultForm viewResultForm = new ViewResultForm();
            viewResultForm.ShowDialog();
        }

        /// <summary>
        /// Search by Roll submenu click
        /// </summary>
        private void btnSearchByRoll_Click(object sender, EventArgs e)
        {
            ViewResultForm viewResultForm = new ViewResultForm();
            viewResultForm.ShowDialog();
        }

        /// <summary>
        /// Class Timetable button click
        /// Opens the ClassTimetableForm
        /// </summary>
        private void btnTimetable_Click(object sender, EventArgs e)
        {
            // Open Class Timetable Form
            ClassTimetableForm timetableForm = new ClassTimetableForm();
            timetableForm.Show();
            
            // Hide the dashboard
            this.Hide();
        }

        /// <summary>
        /// Notifications button click
        /// </summary>
        private void btnNotifications_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notifications\n\n" +
                "1. Submit 2nd Term marks by Dec 15\n" +
                "2. Staff meeting on Dec 10 at 2:00 PM\n" +
                "3. PTM scheduled for Dec 18", 
                "Notifications (3 new)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Logout button click
        /// </summary>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", 
                "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        /// <summary>
        /// Generate Result Cards button click
        /// Opens the GenerateResultCardForm
        /// </summary>
        private void btnGenerateResultCards_Click(object sender, EventArgs e)
        {
            // Open Generate Result Card Form
            GenerateResultCardForm resultCardForm = new GenerateResultCardForm();
            resultCardForm.Show();

            // Hide the dashboard
            this.Hide();
        }
    }
}
