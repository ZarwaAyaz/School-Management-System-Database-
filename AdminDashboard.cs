using System;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    /// <summary>
    /// Admin Dashboard Form for School Management System
    /// Main admin homepage with sidebar navigation
    /// Frontend UI Only - No Backend Functionality
    /// </summary>
    public partial class AdminDashboard : Form
    {
        // Track submenu visibility states
        private bool studentSubmenuVisible = false;
        private bool teacherSubmenuVisible = false;
        private bool academicSubmenuVisible = false;
        private bool feeSubmenuVisible = false;
        private bool salarySubmenuVisible = false;

        public AdminDashboard()
        {
            InitializeComponent();
            SetupHoverEffects();
            SetupDynamicGreeting();
            UpdateDateTime();
            
            // Timer for updating time
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += (s, e) => UpdateDateTime();
            timer.Start();
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

            lblGreeting.Text = $"{greeting}, Administrator!";
        }

        /// <summary>
        /// Update date and time display
        /// </summary>
        private void UpdateDateTime()
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy | hh:mm tt");
        }

        /// <summary>
        /// Setup hover effects for all buttons
        /// </summary>
        private void SetupHoverEffects()
        {
            // Sidebar buttons hover effects
            SetupSidebarButtonHover(btnStudentManagement);
            SetupSidebarButtonHover(btnTeacherManagement);
            SetupSidebarButtonHover(btnAcademicManagement);
            SetupSidebarButtonHover(btnFeeManagement);
            SetupSidebarButtonHover(btnSalaryManagement);
            SetupSidebarButtonHover(btnSystemConfig);
            
            // Student Submenu buttons
            SetupSubmenuButtonHover(btnAddStudent);
            SetupSubmenuButtonHover(btnModifyStudent);
            SetupSubmenuButtonHover(btnRemoveStudent);

            // Teacher Submenu buttons
            SetupSubmenuButtonHover(btnAddTeacher);
            SetupSubmenuButtonHover(btnModifyTeacher);
            SetupSubmenuButtonHover(btnRemoveTeacher);

            // Academic Submenu buttons
            SetupSubmenuButtonHover(btnViewClassAssignment);
            SetupSubmenuButtonHover(btnUpdateClassAssignment);

            // Fee Submenu buttons
            SetupSubmenuButtonHover(btnSubmitMonthlyFee);
            SetupSubmenuButtonHover(btnSubmitAnnualCharges);
            SetupSubmenuButtonHover(btnViewPaidStudents);
            SetupSubmenuButtonHover(btnViewUnpaidStudents);

            // Salary Submenu buttons
            SetupSubmenuButtonHover(btnMarkTeacherAttendance);
            SetupSubmenuButtonHover(btnPayTeacherSalary);

            // Logout button special hover
            btnLogout.MouseEnter += (s, e) => btnLogout.BackColor = Color.FromArgb(192, 57, 43);
            btnLogout.MouseLeave += (s, e) => btnLogout.BackColor = Color.FromArgb(231, 76, 60);
        }

        private void SetupSidebarButtonHover(Button btn)
        {
            btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(52, 73, 94);
            btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(44, 62, 80);
        }

        private void SetupSubmenuButtonHover(Button btn)
        {
            btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(60, 80, 100);
            btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(52, 73, 94);
        }

        /// <summary>
        /// Reposition menu items based on visible submenus
        /// </summary>
        private void RepositionMenuItems()
        {
            int yPosition = 120; // Starting after header

            // Student Management
            btnStudentManagement.Location = new Point(0, yPosition);
            yPosition += 45;

            // Student submenu
            if (studentSubmenuVisible)
            {
                panelStudentSubmenu.Location = new Point(0, yPosition);
                panelStudentSubmenu.Visible = true;
                yPosition += panelStudentSubmenu.Height;
            }
            else
            {
                panelStudentSubmenu.Visible = false;
            }

            // Teacher Management
            btnTeacherManagement.Location = new Point(0, yPosition);
            yPosition += 45;

            // Teacher submenu
            if (teacherSubmenuVisible)
            {
                panelTeacherSubmenu.Location = new Point(0, yPosition);
                panelTeacherSubmenu.Visible = true;
                yPosition += panelTeacherSubmenu.Height;
            }
            else
            {
                panelTeacherSubmenu.Visible = false;
            }

            // Academic Management
            btnAcademicManagement.Location = new Point(0, yPosition);
            yPosition += 45;

            // Academic submenu
            if (academicSubmenuVisible)
            {
                panelAcademicSubmenu.Location = new Point(0, yPosition);
                panelAcademicSubmenu.Visible = true;
                yPosition += panelAcademicSubmenu.Height;
            }
            else
            {
                panelAcademicSubmenu.Visible = false;
            }

            // Fee Management
            btnFeeManagement.Location = new Point(0, yPosition);
            yPosition += 45;

            // Fee submenu
            if (feeSubmenuVisible)
            {
                panelFeeSubmenu.Location = new Point(0, yPosition);
                panelFeeSubmenu.Visible = true;
                yPosition += panelFeeSubmenu.Height;
            }
            else
            {
                panelFeeSubmenu.Visible = false;
            }

            // Salary Management
            btnSalaryManagement.Location = new Point(0, yPosition);
            yPosition += 45;

            // Salary submenu
            if (salarySubmenuVisible)
            {
                panelSalarySubmenu.Location = new Point(0, yPosition);
                panelSalarySubmenu.Visible = true;
                yPosition += panelSalarySubmenu.Height;
            }
            else
            {
                panelSalarySubmenu.Visible = false;
            }

            // System Configuration
            btnSystemConfig.Location = new Point(0, yPosition);
        }

        // ==================== SIDEBAR BUTTON CLICKS ====================

        private void btnStudentManagement_Click(object sender, EventArgs e)
        {
            studentSubmenuVisible = !studentSubmenuVisible;
            btnStudentManagement.Text = studentSubmenuVisible
                ? "  👨‍🎓 Student Management        ▲"
                : "  👨‍🎓 Student Management        ▼";
            RepositionMenuItems();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.ShowDialog();
        }

        private void btnModifyStudent_Click(object sender, EventArgs e)
        {
            ModifyStudentForm modifyStudentForm = new ModifyStudentForm();
            modifyStudentForm.ShowDialog();
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            RemoveStudentForm removeStudentForm = new RemoveStudentForm();
            removeStudentForm.ShowDialog();
        }

        private void btnTeacherManagement_Click(object sender, EventArgs e)
        {
            teacherSubmenuVisible = !teacherSubmenuVisible;
            btnTeacherManagement.Text = teacherSubmenuVisible
                ? "  👨‍🏫 Teacher Management        ▲"
                : "  👨‍🏫 Teacher Management        ▼";
            RepositionMenuItems();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            AddTeacherForm addTeacherForm = new AddTeacherForm();
            addTeacherForm.ShowDialog();
        }

        private void btnModifyTeacher_Click(object sender, EventArgs e)
        {
            ModifyTeacherForm modifyTeacherForm = new ModifyTeacherForm();
            modifyTeacherForm.ShowDialog();
        }

        private void btnRemoveTeacher_Click(object sender, EventArgs e)
        {
            RemoveTeacherForm removeTeacherForm = new RemoveTeacherForm();
            removeTeacherForm.ShowDialog();
        }

        private void btnAcademicManagement_Click(object sender, EventArgs e)
        {
            academicSubmenuVisible = !academicSubmenuVisible;
            btnAcademicManagement.Text = academicSubmenuVisible
                ? "  📚 Academic Management        ▲"
                : "  📚 Academic Management        ▼";
            RepositionMenuItems();
        }

        private void btnViewClassAssignment_Click(object sender, EventArgs e)
        {
            ViewClassAssignmentsForm viewClassAssignmentsForm = new ViewClassAssignmentsForm();
            viewClassAssignmentsForm.ShowDialog();
        }

        private void btnUpdateClassAssignment_Click(object sender, EventArgs e)
        {
            UpdateClassAssignmentForm updateForm = new UpdateClassAssignmentForm();
            updateForm.Show();
            this.Hide();
        }

        private void btnFeeManagement_Click(object sender, EventArgs e)
        {
            feeSubmenuVisible = !feeSubmenuVisible;
            btnFeeManagement.Text = feeSubmenuVisible
                ? "  💰 Fee Management              ▲"
                : "  💰 Fee Management              ▼";
            RepositionMenuItems();
        }

        private void btnSubmitMonthlyFee_Click(object sender, EventArgs e)
        {
            SubmitMonthlyFeeForm submitMonthlyFeeForm = new SubmitMonthlyFeeForm();
            submitMonthlyFeeForm.Show();
            this.Hide();
        }

        private void btnSubmitAnnualCharges_Click(object sender, EventArgs e)
        {
            SubmitAnnualFeeForm submitAnnualFeeForm = new SubmitAnnualFeeForm();
            submitAnnualFeeForm.Show();
            this.Hide();
        }

        private void btnViewPaidStudents_Click(object sender, EventArgs e)
        {
            new ViewPaidStudentsForm().Show();
            this.Hide();
        }

        private void btnViewUnpaidStudents_Click(object sender, EventArgs e)
        {
            new ViewUnpaidStudentsForm().Show();
            this.Hide();
        }

        private void btnSalaryManagement_Click(object sender, EventArgs e)
        {
            salarySubmenuVisible = !salarySubmenuVisible;
            btnSalaryManagement.Text = salarySubmenuVisible
                ? "  👔 Teacher Attendance & Salary ▲"
                : "  👔 Teacher Attendance & Salary ▼";
            RepositionMenuItems();
        }

        private void btnMarkTeacherAttendance_Click(object sender, EventArgs e)
        {
            MarkTeacherAttendanceForm attendanceForm = new MarkTeacherAttendanceForm();
            attendanceForm.Show();
            this.Hide();
        }

        private void btnPayTeacherSalary_Click(object sender, EventArgs e)
        {
            PayTeacherSalaryForm form = new PayTeacherSalaryForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnSystemConfig_Click(object sender, EventArgs e)
        {
            MessageBox.Show("System Configuration\n\nFeatures:\n• School Settings\n• Academic Year Setup\n• Fee Structure\n• User Management",
                "System Configuration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // TODO: new SystemConfigForm().Show(); this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }
    }
}
