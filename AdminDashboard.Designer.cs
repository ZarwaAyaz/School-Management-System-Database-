namespace SchoolManagementSystem
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // Sidebar
            this.panelSidebar = new Panel();
            this.panelSidebarHeader = new Panel();
            this.lblAdminTitle = new Label();
            this.lblAdminSubtitle = new Label();

            // Sidebar Menu Buttons
            this.btnStudentManagement = new Button();
            this.btnTeacherManagement = new Button();
            this.btnAcademicManagement = new Button();
            this.btnFeeManagement = new Button();
            this.btnSalaryManagement = new Button();
            this.btnSystemConfig = new Button();
            this.btnLogout = new Button();

            // Student Submenu
            this.panelStudentSubmenu = new Panel();
            this.btnAddStudent = new Button();
            this.btnModifyStudent = new Button();
            this.btnRemoveStudent = new Button();

            // Teacher Submenu
            this.panelTeacherSubmenu = new Panel();
            this.btnAddTeacher = new Button();
            this.btnModifyTeacher = new Button();
            this.btnRemoveTeacher = new Button();

            // Academic Submenu
            this.panelAcademicSubmenu = new Panel();
            this.btnViewClassAssignment = new Button();
            this.btnUpdateClassAssignment = new Button();

            // Fee Submenu
            this.panelFeeSubmenu = new Panel();
            this.btnSubmitMonthlyFee = new Button();
            this.btnSubmitAnnualCharges = new Button();
            this.btnViewPaidStudents = new Button();
            this.btnViewUnpaidStudents = new Button();

            // Salary Submenu
            this.panelSalarySubmenu = new Panel();
            this.btnMarkTeacherAttendance = new Button();
            this.btnPayTeacherSalary = new Button();

            // Main Content Area
            this.panelMainContent = new Panel();
            this.panelTopBar = new Panel();
            this.lblGreeting = new Label();
            this.lblDateTime = new Label();

            // Logo Section
            this.panelLogoSection = new Panel();
            this.lblSchoolLogo = new Label();
            this.lblSchoolName = new Label();
            this.lblSchoolMotto = new Label();

            // Dashboard Cards
            this.panelCardsContainer = new Panel();
            this.panelCard1 = new Panel();
            this.lblCard1Icon = new Label();
            this.lblCard1Value = new Label();
            this.lblCard1Title = new Label();

            this.panelCard2 = new Panel();
            this.lblCard2Icon = new Label();
            this.lblCard2Value = new Label();
            this.lblCard2Title = new Label();

            this.panelCard3 = new Panel();
            this.lblCard3Icon = new Label();
            this.lblCard3Value = new Label();
            this.lblCard3Title = new Label();

            this.panelCard4 = new Panel();
            this.lblCard4Icon = new Label();
            this.lblCard4Value = new Label();
            this.lblCard4Title = new Label();

            // Bottom Section
            this.panelBottomSection = new Panel();
            this.panelNotifications = new Panel();
            this.lblNotificationsTitle = new Label();
            this.lblNotice1 = new Label();
            this.lblNotice2 = new Label();
            this.lblNotice3 = new Label();
            this.lblNotice4 = new Label();

            this.panelUpcomingTasks = new Panel();
            this.lblTasksTitle = new Label();
            this.lblTask1 = new Label();
            this.lblTask2 = new Label();
            this.lblTask3 = new Label();
            this.lblTask4 = new Label();

            // Suspend Layout
            this.panelSidebar.SuspendLayout();
            this.panelSidebarHeader.SuspendLayout();
            this.panelStudentSubmenu.SuspendLayout();
            this.panelTeacherSubmenu.SuspendLayout();
            this.panelAcademicSubmenu.SuspendLayout();
            this.panelFeeSubmenu.SuspendLayout();
            this.panelSalarySubmenu.SuspendLayout();
            this.panelMainContent.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            this.panelLogoSection.SuspendLayout();
            this.panelCardsContainer.SuspendLayout();
            this.panelCard1.SuspendLayout();
            this.panelCard2.SuspendLayout();
            this.panelCard3.SuspendLayout();
            this.panelCard4.SuspendLayout();
            this.panelBottomSection.SuspendLayout();
            this.panelNotifications.SuspendLayout();
            this.panelUpcomingTasks.SuspendLayout();
            this.SuspendLayout();

            // ========================================
            // panelSidebar
            // ========================================
            this.panelSidebar.BackColor = Color.FromArgb(44, 62, 80);
            this.panelSidebar.Dock = DockStyle.Left;
            this.panelSidebar.Location = new Point(0, 0);
            this.panelSidebar.Size = new Size(280, 700);
            this.panelSidebar.Controls.Add(this.panelSidebarHeader);
            this.panelSidebar.Controls.Add(this.btnStudentManagement);
            this.panelSidebar.Controls.Add(this.panelStudentSubmenu);
            this.panelSidebar.Controls.Add(this.btnTeacherManagement);
            this.panelSidebar.Controls.Add(this.panelTeacherSubmenu);
            this.panelSidebar.Controls.Add(this.btnAcademicManagement);
            this.panelSidebar.Controls.Add(this.panelAcademicSubmenu);
            this.panelSidebar.Controls.Add(this.btnFeeManagement);
            this.panelSidebar.Controls.Add(this.panelFeeSubmenu);
            this.panelSidebar.Controls.Add(this.btnSalaryManagement);
            this.panelSidebar.Controls.Add(this.panelSalarySubmenu);
            this.panelSidebar.Controls.Add(this.btnSystemConfig);
            this.panelSidebar.Controls.Add(this.btnLogout);

            // ========================================
            // panelSidebarHeader
            // ========================================
            this.panelSidebarHeader.BackColor = Color.FromArgb(52, 73, 94);
            this.panelSidebarHeader.Dock = DockStyle.Top;
            this.panelSidebarHeader.Size = new Size(280, 120);
            this.panelSidebarHeader.Controls.Add(this.lblAdminTitle);
            this.panelSidebarHeader.Controls.Add(this.lblAdminSubtitle);

            this.lblAdminTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblAdminTitle.ForeColor = Color.White;
            this.lblAdminTitle.Location = new Point(0, 35);
            this.lblAdminTitle.Size = new Size(280, 35);
            this.lblAdminTitle.Text = "🏫 Admin Panel";
            this.lblAdminTitle.TextAlign = ContentAlignment.MiddleCenter;

            this.lblAdminSubtitle.Font = new Font("Segoe UI", 9F);
            this.lblAdminSubtitle.ForeColor = Color.FromArgb(189, 195, 199);
            this.lblAdminSubtitle.Location = new Point(0, 70);
            this.lblAdminSubtitle.Size = new Size(280, 20);
            this.lblAdminSubtitle.Text = "School Management System";
            this.lblAdminSubtitle.TextAlign = ContentAlignment.MiddleCenter;

            // ========================================
            // Sidebar Menu Buttons
            // ========================================
            // Student Management
            this.btnStudentManagement.BackColor = Color.FromArgb(44, 62, 80);
            this.btnStudentManagement.FlatStyle = FlatStyle.Flat;
            this.btnStudentManagement.FlatAppearance.BorderSize = 0;
            this.btnStudentManagement.Font = new Font("Segoe UI", 10F);
            this.btnStudentManagement.ForeColor = Color.White;
            this.btnStudentManagement.Location = new Point(0, 120);
            this.btnStudentManagement.Size = new Size(280, 45);
            this.btnStudentManagement.Text = "  👨‍🎓 Student Management        ▼";
            this.btnStudentManagement.TextAlign = ContentAlignment.MiddleLeft;
            this.btnStudentManagement.Padding = new Padding(15, 0, 0, 0);
            this.btnStudentManagement.Cursor = Cursors.Hand;
            this.btnStudentManagement.Click += new EventHandler(this.btnStudentManagement_Click);

            // ========================================
            // Student Submenu Panel
            // ========================================
            this.panelStudentSubmenu.BackColor = Color.FromArgb(52, 73, 94);
            this.panelStudentSubmenu.Location = new Point(0, 165);
            this.panelStudentSubmenu.Size = new Size(280, 120);
            this.panelStudentSubmenu.Visible = false;
            this.panelStudentSubmenu.Controls.Add(this.btnAddStudent);
            this.panelStudentSubmenu.Controls.Add(this.btnModifyStudent);
            this.panelStudentSubmenu.Controls.Add(this.btnRemoveStudent);

            this.btnAddStudent.BackColor = Color.FromArgb(52, 73, 94);
            this.btnAddStudent.FlatStyle = FlatStyle.Flat;
            this.btnAddStudent.FlatAppearance.BorderSize = 0;
            this.btnAddStudent.Font = new Font("Segoe UI", 9F);
            this.btnAddStudent.ForeColor = Color.FromArgb(189, 195, 199);
            this.btnAddStudent.Location = new Point(0, 0);
            this.btnAddStudent.Size = new Size(280, 40);
            this.btnAddStudent.Text = "      • Add Student";
            this.btnAddStudent.TextAlign = ContentAlignment.MiddleLeft;
            this.btnAddStudent.Cursor = Cursors.Hand;
            this.btnAddStudent.Click += new EventHandler(this.btnAddStudent_Click);

            this.btnModifyStudent.BackColor = Color.FromArgb(52, 73, 94);
            this.btnModifyStudent.FlatStyle = FlatStyle.Flat;
            this.btnModifyStudent.FlatAppearance.BorderSize = 0;
            this.btnModifyStudent.Font = new Font("Segoe UI", 9F);
            this.btnModifyStudent.ForeColor = Color.FromArgb(189, 195, 199);
            this.btnModifyStudent.Location = new Point(0, 40);
            this.btnModifyStudent.Size = new Size(280, 40);
            this.btnModifyStudent.Text = "      • Modify Student";
            this.btnModifyStudent.TextAlign = ContentAlignment.MiddleLeft;
            this.btnModifyStudent.Cursor = Cursors.Hand;
            this.btnModifyStudent.Click += new EventHandler(this.btnModifyStudent_Click);

            this.btnRemoveStudent.BackColor = Color.FromArgb(52, 73, 94);
            this.btnRemoveStudent.FlatStyle = FlatStyle.Flat;
            this.btnRemoveStudent.FlatAppearance.BorderSize = 0;
            this.btnRemoveStudent.Font = new Font("Segoe UI", 9F);
            this.btnRemoveStudent.ForeColor = Color.FromArgb(189, 195, 199);
            this.btnRemoveStudent.Location = new Point(0, 80);
            this.btnRemoveStudent.Size = new Size(280, 40);
            this.btnRemoveStudent.Text = "      • Remove Student";
            this.btnRemoveStudent.TextAlign = ContentAlignment.MiddleLeft;
            this.btnRemoveStudent.Cursor = Cursors.Hand;
            this.btnRemoveStudent.Click += new EventHandler(this.btnRemoveStudent_Click);

            // Teacher Management
            this.btnTeacherManagement.BackColor = Color.FromArgb(44, 62, 80);
            this.btnTeacherManagement.FlatStyle = FlatStyle.Flat;
            this.btnTeacherManagement.FlatAppearance.BorderSize = 0;
            this.btnTeacherManagement.Font = new Font("Segoe UI", 10F);
            this.btnTeacherManagement.ForeColor = Color.White;
            this.btnTeacherManagement.Location = new Point(0, 165);
            this.btnTeacherManagement.Size = new Size(280, 45);
            this.btnTeacherManagement.Text = "  👨‍🏫 Teacher Management        ▼";
            this.btnTeacherManagement.TextAlign = ContentAlignment.MiddleLeft;
            this.btnTeacherManagement.Padding = new Padding(15, 0, 0, 0);
            this.btnTeacherManagement.Cursor = Cursors.Hand;
            this.btnTeacherManagement.Click += new EventHandler(this.btnTeacherManagement_Click);

            // ========================================
            // Teacher Submenu Panel
            // ========================================
            this.panelTeacherSubmenu.BackColor = Color.FromArgb(52, 73, 94);
            this.panelTeacherSubmenu.Location = new Point(0, 210);
            this.panelTeacherSubmenu.Size = new Size(280, 120);
            this.panelTeacherSubmenu.Visible = false;
            this.panelTeacherSubmenu.Controls.Add(this.btnAddTeacher);
            this.panelTeacherSubmenu.Controls.Add(this.btnModifyTeacher);
            this.panelTeacherSubmenu.Controls.Add(this.btnRemoveTeacher);

            this.btnAddTeacher.BackColor = Color.FromArgb(52, 73, 94);
            this.btnAddTeacher.FlatStyle = FlatStyle.Flat;
            this.btnAddTeacher.FlatAppearance.BorderSize = 0;
            this.btnAddTeacher.Font = new Font("Segoe UI", 9F);
            this.btnAddTeacher.ForeColor = Color.FromArgb(189, 195, 199);
            this.btnAddTeacher.Location = new Point(0, 0);
            this.btnAddTeacher.Size = new Size(280, 40);
            this.btnAddTeacher.Text = "      • Add Teacher";
            this.btnAddTeacher.TextAlign = ContentAlignment.MiddleLeft;
            this.btnAddTeacher.Cursor = Cursors.Hand;
            this.btnAddTeacher.Click += new EventHandler(this.btnAddTeacher_Click);

            this.btnModifyTeacher.BackColor = Color.FromArgb(52, 73, 94);
            this.btnModifyTeacher.FlatStyle = FlatStyle.Flat;
            this.btnModifyTeacher.FlatAppearance.BorderSize = 0;
            this.btnModifyTeacher.Font = new Font("Segoe UI", 9F);
            this.btnModifyTeacher.ForeColor = Color.FromArgb(189, 195, 199);
            this.btnModifyTeacher.Location = new Point(0, 40);
            this.btnModifyTeacher.Size = new Size(280, 40);
            this.btnModifyTeacher.Text = "      • Modify Teacher";
            this.btnModifyTeacher.TextAlign = ContentAlignment.MiddleLeft;
            this.btnModifyTeacher.Cursor = Cursors.Hand;
            this.btnModifyTeacher.Click += new EventHandler(this.btnModifyTeacher_Click);

            this.btnRemoveTeacher.BackColor = Color.FromArgb(52, 73, 94);
            this.btnRemoveTeacher.FlatStyle = FlatStyle.Flat;
            this.btnRemoveTeacher.FlatAppearance.BorderSize = 0;
            this.btnRemoveTeacher.Font = new Font("Segoe UI", 9F);
            this.btnRemoveTeacher.ForeColor = Color.FromArgb(189, 195, 199);
            this.btnRemoveTeacher.Location = new Point(0, 80);
            this.btnRemoveTeacher.Size = new Size(280, 40);
            this.btnRemoveTeacher.Text = "      • Remove Teacher";
            this.btnRemoveTeacher.TextAlign = ContentAlignment.MiddleLeft;
            this.btnRemoveTeacher.Cursor = Cursors.Hand;
            this.btnRemoveTeacher.Click += new EventHandler(this.btnRemoveTeacher_Click);

            // Academic Management
            this.btnAcademicManagement.BackColor = Color.FromArgb(44, 62, 80);
            this.btnAcademicManagement.FlatStyle = FlatStyle.Flat;
            this.btnAcademicManagement.FlatAppearance.BorderSize = 0;
            this.btnAcademicManagement.Font = new Font("Segoe UI", 10F);
            this.btnAcademicManagement.ForeColor = Color.White;
            this.btnAcademicManagement.Location = new Point(0, 210);
            this.btnAcademicManagement.Size = new Size(280, 45);
            this.btnAcademicManagement.Text = "  📚 Academic Management        ▼";
            this.btnAcademicManagement.TextAlign = ContentAlignment.MiddleLeft;
            this.btnAcademicManagement.Padding = new Padding(15, 0, 0, 0);
            this.btnAcademicManagement.Cursor = Cursors.Hand;
            this.btnAcademicManagement.Click += new EventHandler(this.btnAcademicManagement_Click);

            // ========================================
            // Academic Submenu Panel
            // ========================================
            this.panelAcademicSubmenu.BackColor = Color.FromArgb(52, 73, 94);
            this.panelAcademicSubmenu.Location = new Point(0, 255);
            this.panelAcademicSubmenu.Size = new Size(280, 80);
            this.panelAcademicSubmenu.Visible = false;
            this.panelAcademicSubmenu.Controls.Add(this.btnViewClassAssignment);
            this.panelAcademicSubmenu.Controls.Add(this.btnUpdateClassAssignment);

            this.btnViewClassAssignment.BackColor = Color.FromArgb(52, 73, 94);
            this.btnViewClassAssignment.FlatStyle = FlatStyle.Flat;
            this.btnViewClassAssignment.FlatAppearance.BorderSize = 0;
            this.btnViewClassAssignment.Font = new Font("Segoe UI", 9F);
            this.btnViewClassAssignment.ForeColor = Color.FromArgb(189, 195, 199);
            this.btnViewClassAssignment.Location = new Point(0, 0);
            this.btnViewClassAssignment.Size = new Size(280, 40);
            this.btnViewClassAssignment.Text = "      • View Class Assignments";
            this.btnViewClassAssignment.TextAlign = ContentAlignment.MiddleLeft;
            this.btnViewClassAssignment.Cursor = Cursors.Hand;
            this.btnViewClassAssignment.Click += new EventHandler(this.btnViewClassAssignment_Click);

            this.btnUpdateClassAssignment.BackColor = Color.FromArgb(52, 73, 94);
            this.btnUpdateClassAssignment.FlatStyle = FlatStyle.Flat;
            this.btnUpdateClassAssignment.FlatAppearance.BorderSize = 0;
            this.btnUpdateClassAssignment.Font = new Font("Segoe UI", 9F);
            this.btnUpdateClassAssignment.ForeColor = Color.FromArgb(189, 195, 199);
            this.btnUpdateClassAssignment.Location = new Point(0, 40);
            this.btnUpdateClassAssignment.Size = new Size(280, 40);
            this.btnUpdateClassAssignment.Text = "      • Update Class Assignment";
            this.btnUpdateClassAssignment.TextAlign = ContentAlignment.MiddleLeft;
            this.btnUpdateClassAssignment.Cursor = Cursors.Hand;
            this.btnUpdateClassAssignment.Click += new EventHandler(this.btnUpdateClassAssignment_Click);

            // Fee Management
            this.btnFeeManagement.BackColor = Color.FromArgb(44, 62, 80);
            this.btnFeeManagement.FlatStyle = FlatStyle.Flat;
            this.btnFeeManagement.FlatAppearance.BorderSize = 0;
            this.btnFeeManagement.Font = new Font("Segoe UI", 10F);
            this.btnFeeManagement.ForeColor = Color.White;
            this.btnFeeManagement.Location = new Point(0, 255);
            this.btnFeeManagement.Size = new Size(280, 45);
            this.btnFeeManagement.Text = "  💰 Fee Management              ▼";
            this.btnFeeManagement.TextAlign = ContentAlignment.MiddleLeft;
            this.btnFeeManagement.Padding = new Padding(15, 0, 0, 0);
            this.btnFeeManagement.Cursor = Cursors.Hand;
            this.btnFeeManagement.Click += new EventHandler(this.btnFeeManagement_Click);

            // ========================================
            // Fee Submenu Panel
            // ========================================
            this.panelFeeSubmenu.BackColor = Color.FromArgb(52, 73, 94);
            this.panelFeeSubmenu.Location = new Point(0, 300);
            this.panelFeeSubmenu.Size = new Size(280, 160);
            this.panelFeeSubmenu.Visible = false;
            this.panelFeeSubmenu.Controls.Add(this.btnSubmitMonthlyFee);
            this.panelFeeSubmenu.Controls.Add(this.btnSubmitAnnualCharges);
            this.panelFeeSubmenu.Controls.Add(this.btnViewPaidStudents);
            this.panelFeeSubmenu.Controls.Add(this.btnViewUnpaidStudents);

            this.btnSubmitMonthlyFee.BackColor = Color.FromArgb(52, 73, 94);
            this.btnSubmitMonthlyFee.FlatStyle = FlatStyle.Flat;
            this.btnSubmitMonthlyFee.FlatAppearance.BorderSize = 0;
            this.btnSubmitMonthlyFee.Font = new Font("Segoe UI", 9F);
            this.btnSubmitMonthlyFee.ForeColor = Color.FromArgb(189, 195, 199);
            this.btnSubmitMonthlyFee.Location = new Point(0, 0);
            this.btnSubmitMonthlyFee.Size = new Size(280, 40);
            this.btnSubmitMonthlyFee.Text = "      • Submit Monthly Fee";
            this.btnSubmitMonthlyFee.TextAlign = ContentAlignment.MiddleLeft;
            this.btnSubmitMonthlyFee.Cursor = Cursors.Hand;
            this.btnSubmitMonthlyFee.Click += new EventHandler(this.btnSubmitMonthlyFee_Click);

            this.btnSubmitAnnualCharges.BackColor = Color.FromArgb(52, 73, 94);
            this.btnSubmitAnnualCharges.FlatStyle = FlatStyle.Flat;
            this.btnSubmitAnnualCharges.FlatAppearance.BorderSize = 0;
            this.btnSubmitAnnualCharges.Font = new Font("Segoe UI", 9F);
            this.btnSubmitAnnualCharges.ForeColor = Color.FromArgb(189, 195, 199);
            this.btnSubmitAnnualCharges.Location = new Point(0, 40);
            this.btnSubmitAnnualCharges.Size = new Size(280, 40);
            this.btnSubmitAnnualCharges.Text = "      • Submit Annual Charges";
            this.btnSubmitAnnualCharges.TextAlign = ContentAlignment.MiddleLeft;
            this.btnSubmitAnnualCharges.Cursor = Cursors.Hand;
            this.btnSubmitAnnualCharges.Click += new EventHandler(this.btnSubmitAnnualCharges_Click);

            this.btnViewPaidStudents.BackColor = Color.FromArgb(52, 73, 94);
            this.btnViewPaidStudents.FlatStyle = FlatStyle.Flat;
            this.btnViewPaidStudents.FlatAppearance.BorderSize = 0;
            this.btnViewPaidStudents.Font = new Font("Segoe UI", 9F);
            this.btnViewPaidStudents.ForeColor = Color.FromArgb(189, 195, 199);
            this.btnViewPaidStudents.Location = new Point(0, 80);
            this.btnViewPaidStudents.Size = new Size(280, 40);
            this.btnViewPaidStudents.Text = "      • View Paid Students";
            this.btnViewPaidStudents.TextAlign = ContentAlignment.MiddleLeft;
            this.btnViewPaidStudents.Cursor = Cursors.Hand;
            this.btnViewPaidStudents.Click += new EventHandler(this.btnViewPaidStudents_Click);

            this.btnViewUnpaidStudents.BackColor = Color.FromArgb(52, 73, 94);
            this.btnViewUnpaidStudents.FlatStyle = FlatStyle.Flat;
            this.btnViewUnpaidStudents.FlatAppearance.BorderSize = 0;
            this.btnViewUnpaidStudents.Font = new Font("Segoe UI", 9F);
            this.btnViewUnpaidStudents.ForeColor = Color.FromArgb(189, 195, 199);
            this.btnViewUnpaidStudents.Location = new Point(0, 120);
            this.btnViewUnpaidStudents.Size = new Size(280, 40);
            this.btnViewUnpaidStudents.Text = "      • View Unpaid Students";
            this.btnViewUnpaidStudents.TextAlign = ContentAlignment.MiddleLeft;
            this.btnViewUnpaidStudents.Cursor = Cursors.Hand;
            this.btnViewUnpaidStudents.Click += new EventHandler(this.btnViewUnpaidStudents_Click);

            // Salary Management
            this.btnSalaryManagement.BackColor = Color.FromArgb(44, 62, 80);
            this.btnSalaryManagement.FlatStyle = FlatStyle.Flat;
            this.btnSalaryManagement.FlatAppearance.BorderSize = 0;
            this.btnSalaryManagement.Font = new Font("Segoe UI", 10F);
            this.btnSalaryManagement.ForeColor = Color.White;
            this.btnSalaryManagement.Location = new Point(0, 300);
            this.btnSalaryManagement.Size = new Size(280, 45);
            this.btnSalaryManagement.Text = "  👔 Teacher Attendance & Salary ▼";
            this.btnSalaryManagement.TextAlign = ContentAlignment.MiddleLeft;
            this.btnSalaryManagement.Padding = new Padding(15, 0, 0, 0);
            this.btnSalaryManagement.Cursor = Cursors.Hand;
            this.btnSalaryManagement.Click += new EventHandler(this.btnSalaryManagement_Click);

            // ========================================
            // Salary Submenu Panel
            // ========================================
            this.panelSalarySubmenu.BackColor = Color.FromArgb(52, 73, 94);
            this.panelSalarySubmenu.Location = new Point(0, 345);
            this.panelSalarySubmenu.Size = new Size(280, 80);
            this.panelSalarySubmenu.Visible = false;
            this.panelSalarySubmenu.Controls.Add(this.btnMarkTeacherAttendance);
            this.panelSalarySubmenu.Controls.Add(this.btnPayTeacherSalary);

            this.btnMarkTeacherAttendance.BackColor = Color.FromArgb(52, 73, 94);
            this.btnMarkTeacherAttendance.FlatStyle = FlatStyle.Flat;
            this.btnMarkTeacherAttendance.FlatAppearance.BorderSize = 0;
            this.btnMarkTeacherAttendance.Font = new Font("Segoe UI", 9F);
            this.btnMarkTeacherAttendance.ForeColor = Color.FromArgb(189, 195, 199);
            this.btnMarkTeacherAttendance.Location = new Point(0, 0);
            this.btnMarkTeacherAttendance.Size = new Size(280, 40);
            this.btnMarkTeacherAttendance.Text = "      • Mark Teacher Attendance";
            this.btnMarkTeacherAttendance.TextAlign = ContentAlignment.MiddleLeft;
            this.btnMarkTeacherAttendance.Cursor = Cursors.Hand;
            this.btnMarkTeacherAttendance.Click += new EventHandler(this.btnMarkTeacherAttendance_Click);

            this.btnPayTeacherSalary.BackColor = Color.FromArgb(52, 73, 94);
            this.btnPayTeacherSalary.FlatStyle = FlatStyle.Flat;
            this.btnPayTeacherSalary.FlatAppearance.BorderSize = 0;
            this.btnPayTeacherSalary.Font = new Font("Segoe UI", 9F);
            this.btnPayTeacherSalary.ForeColor = Color.FromArgb(189, 195, 199);
            this.btnPayTeacherSalary.Location = new Point(0, 40);
            this.btnPayTeacherSalary.Size = new Size(280, 40);
            this.btnPayTeacherSalary.Text = "      • Pay Teacher Salary";
            this.btnPayTeacherSalary.TextAlign = ContentAlignment.MiddleLeft;
            this.btnPayTeacherSalary.Cursor = Cursors.Hand;
            this.btnPayTeacherSalary.Click += new EventHandler(this.btnPayTeacherSalary_Click);

            // System Configuration
            this.btnSystemConfig.BackColor = Color.FromArgb(44, 62, 80);
            this.btnSystemConfig.FlatStyle = FlatStyle.Flat;
            this.btnSystemConfig.FlatAppearance.BorderSize = 0;
            this.btnSystemConfig.Font = new Font("Segoe UI", 10F);
            this.btnSystemConfig.ForeColor = Color.White;
            this.btnSystemConfig.Location = new Point(0, 345);
            this.btnSystemConfig.Size = new Size(280, 45);
            this.btnSystemConfig.Text = "  ⚙️ System Configuration";
            this.btnSystemConfig.TextAlign = ContentAlignment.MiddleLeft;
            this.btnSystemConfig.Padding = new Padding(15, 0, 0, 0);
            this.btnSystemConfig.Cursor = Cursors.Hand;
            this.btnSystemConfig.Click += new EventHandler(this.btnSystemConfig_Click);

            // Logout Button
            this.btnLogout.BackColor = Color.FromArgb(231, 76, 60);
            this.btnLogout.FlatStyle = FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnLogout.ForeColor = Color.White;
            this.btnLogout.Dock = DockStyle.Bottom;
            this.btnLogout.Size = new Size(280, 50);
            this.btnLogout.Text = "🚪 Logout";
            this.btnLogout.Cursor = Cursors.Hand;
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);

            // ========================================
            // panelMainContent
            // ========================================
            this.panelMainContent.BackColor = Color.FromArgb(236, 240, 241);
            this.panelMainContent.Dock = DockStyle.Fill;
            this.panelMainContent.Location = new Point(280, 0);
            this.panelMainContent.Size = new Size(820, 700);
            this.panelMainContent.Controls.Add(this.panelTopBar);
            this.panelMainContent.Controls.Add(this.panelLogoSection);
            this.panelMainContent.Controls.Add(this.panelCardsContainer);
            this.panelMainContent.Controls.Add(this.panelBottomSection);

            // ========================================
            // panelTopBar
            // ========================================
            this.panelTopBar.BackColor = Color.White;
            this.panelTopBar.Dock = DockStyle.Top;
            this.panelTopBar.Size = new Size(820, 60);
            this.panelTopBar.Controls.Add(this.lblGreeting);
            this.panelTopBar.Controls.Add(this.lblDateTime);

            this.lblGreeting.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblGreeting.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblGreeting.Location = new Point(20, 15);
            this.lblGreeting.Size = new Size(400, 30);
            this.lblGreeting.Text = "Good Morning, Administrator!";

            this.lblDateTime.Font = new Font("Segoe UI", 10F);
            this.lblDateTime.ForeColor = Color.FromArgb(127, 140, 141);
            this.lblDateTime.Location = new Point(500, 20);
            this.lblDateTime.Size = new Size(300, 20);
            this.lblDateTime.Text = "Saturday, December 7, 2025 | 10:30 AM";
            this.lblDateTime.TextAlign = ContentAlignment.MiddleRight;

            // ========================================
            // panelLogoSection
            // ========================================
            this.panelLogoSection.BackColor = Color.White;
            this.panelLogoSection.Location = new Point(20, 75);
            this.panelLogoSection.Size = new Size(780, 120);
            this.panelLogoSection.Controls.Add(this.lblSchoolLogo);
            this.panelLogoSection.Controls.Add(this.lblSchoolName);
            this.panelLogoSection.Controls.Add(this.lblSchoolMotto);

            this.lblSchoolLogo.Font = new Font("Segoe UI", 48F);
            this.lblSchoolLogo.ForeColor = Color.FromArgb(41, 128, 185);
            this.lblSchoolLogo.Location = new Point(0, 10);
            this.lblSchoolLogo.Size = new Size(780, 60);
            this.lblSchoolLogo.Text = "🏫";
            this.lblSchoolLogo.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSchoolName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblSchoolName.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblSchoolName.Location = new Point(0, 65);
            this.lblSchoolName.Size = new Size(780, 30);
            this.lblSchoolName.Text = "GREENWOOD INTERNATIONAL SCHOOL";
            this.lblSchoolName.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSchoolMotto.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            this.lblSchoolMotto.ForeColor = Color.FromArgb(127, 140, 141);
            this.lblSchoolMotto.Location = new Point(0, 92);
            this.lblSchoolMotto.Size = new Size(780, 20);
            this.lblSchoolMotto.Text = "\"Excellence in Education, Character in Action\"";
            this.lblSchoolMotto.TextAlign = ContentAlignment.MiddleCenter;

            // ========================================
            // panelCardsContainer
            // ========================================
            this.panelCardsContainer.BackColor = Color.Transparent;
            this.panelCardsContainer.Location = new Point(20, 205);
            this.panelCardsContainer.Size = new Size(780, 120);
            this.panelCardsContainer.Controls.Add(this.panelCard1);
            this.panelCardsContainer.Controls.Add(this.panelCard2);
            this.panelCardsContainer.Controls.Add(this.panelCard3);
            this.panelCardsContainer.Controls.Add(this.panelCard4);

            // Card 1 - Active Students
            this.panelCard1.BackColor = Color.FromArgb(46, 204, 113);
            this.panelCard1.Location = new Point(0, 0);
            this.panelCard1.Size = new Size(185, 110);
            this.panelCard1.Controls.Add(this.lblCard1Icon);
            this.panelCard1.Controls.Add(this.lblCard1Value);
            this.panelCard1.Controls.Add(this.lblCard1Title);

            this.lblCard1Icon.Font = new Font("Segoe UI", 24F);
            this.lblCard1Icon.ForeColor = Color.White;
            this.lblCard1Icon.Location = new Point(10, 10);
            this.lblCard1Icon.Size = new Size(50, 40);
            this.lblCard1Icon.Text = "👨‍🎓";

            this.lblCard1Value.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            this.lblCard1Value.ForeColor = Color.White;
            this.lblCard1Value.Location = new Point(10, 45);
            this.lblCard1Value.Size = new Size(165, 40);
            this.lblCard1Value.Text = "342";

            this.lblCard1Title.Font = new Font("Segoe UI", 9F);
            this.lblCard1Title.ForeColor = Color.FromArgb(212, 239, 223);
            this.lblCard1Title.Location = new Point(10, 85);
            this.lblCard1Title.Size = new Size(165, 20);
            this.lblCard1Title.Text = "Students Present Today";

            // Card 2 - Total Teachers
            this.panelCard2.BackColor = Color.FromArgb(52, 152, 219);
            this.panelCard2.Location = new Point(200, 0);
            this.panelCard2.Size = new Size(185, 110);
            this.panelCard2.Controls.Add(this.lblCard2Icon);
            this.panelCard2.Controls.Add(this.lblCard2Value);
            this.panelCard2.Controls.Add(this.lblCard2Title);

            this.lblCard2Icon.Font = new Font("Segoe UI", 24F);
            this.lblCard2Icon.ForeColor = Color.White;
            this.lblCard2Icon.Location = new Point(10, 10);
            this.lblCard2Icon.Size = new Size(50, 40);
            this.lblCard2Icon.Text = "👨‍🏫";

            this.lblCard2Value.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            this.lblCard2Value.ForeColor = Color.White;
            this.lblCard2Value.Location = new Point(10, 45);
            this.lblCard2Value.Size = new Size(165, 40);
            this.lblCard2Value.Text = "28";

            this.lblCard2Title.Font = new Font("Segoe UI", 9F);
            this.lblCard2Title.ForeColor = Color.FromArgb(214, 234, 248);
            this.lblCard2Title.Location = new Point(10, 85);
            this.lblCard2Title.Size = new Size(165, 20);
            this.lblCard2Title.Text = "Total Teachers";

            // Card 3 - Pending Salary
            this.panelCard3.BackColor = Color.FromArgb(243, 156, 18);
            this.panelCard3.Location = new Point(400, 0);
            this.panelCard3.Size = new Size(185, 110);
            this.panelCard3.Controls.Add(this.lblCard3Icon);
            this.panelCard3.Controls.Add(this.lblCard3Value);
            this.panelCard3.Controls.Add(this.lblCard3Title);

            this.lblCard3Icon.Font = new Font("Segoe UI", 24F);
            this.lblCard3Icon.ForeColor = Color.White;
            this.lblCard3Icon.Location = new Point(10, 10);
            this.lblCard3Icon.Size = new Size(50, 40);
            this.lblCard3Icon.Text = "💵";

            this.lblCard3Value.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            this.lblCard3Value.ForeColor = Color.White;
            this.lblCard3Value.Location = new Point(10, 45);
            this.lblCard3Value.Size = new Size(165, 40);
            this.lblCard3Value.Text = "5";

            this.lblCard3Title.Font = new Font("Segoe UI", 9F);
            this.lblCard3Title.ForeColor = Color.FromArgb(252, 243, 207);
            this.lblCard3Title.Location = new Point(10, 85);
            this.lblCard3Title.Size = new Size(165, 20);
            this.lblCard3Title.Text = "Pending Salary Payments";

            // Card 4 - Unpaid Fees
            this.panelCard4.BackColor = Color.FromArgb(231, 76, 60);
            this.panelCard4.Location = new Point(600, 0);
            this.panelCard4.Size = new Size(180, 110);
            this.panelCard4.Controls.Add(this.lblCard4Icon);
            this.panelCard4.Controls.Add(this.lblCard4Value);
            this.panelCard4.Controls.Add(this.lblCard4Title);

            this.lblCard4Icon.Font = new Font("Segoe UI", 24F);
            this.lblCard4Icon.ForeColor = Color.White;
            this.lblCard4Icon.Location = new Point(10, 10);
            this.lblCard4Icon.Size = new Size(50, 40);
            this.lblCard4Icon.Text = "⚠️";

            this.lblCard4Value.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            this.lblCard4Value.ForeColor = Color.White;
            this.lblCard4Value.Location = new Point(10, 45);
            this.lblCard4Value.Size = new Size(160, 40);
            this.lblCard4Value.Text = "47";

            this.lblCard4Title.Font = new Font("Segoe UI", 9F);
            this.lblCard4Title.ForeColor = Color.FromArgb(250, 219, 216);
            this.lblCard4Title.Location = new Point(10, 85);
            this.lblCard4Title.Size = new Size(160, 20);
            this.lblCard4Title.Text = "Unpaid Fee Count";

            // ========================================
            // panelBottomSection
            // ========================================
            this.panelBottomSection.BackColor = Color.Transparent;
            this.panelBottomSection.Location = new Point(20, 340);
            this.panelBottomSection.Size = new Size(780, 340);
            this.panelBottomSection.Controls.Add(this.panelNotifications);
            this.panelBottomSection.Controls.Add(this.panelUpcomingTasks);

            // Notifications Panel
            this.panelNotifications.BackColor = Color.White;
            this.panelNotifications.Location = new Point(0, 0);
            this.panelNotifications.Size = new Size(380, 330);
            this.panelNotifications.BorderStyle = BorderStyle.FixedSingle;
            this.panelNotifications.Controls.Add(this.lblNotificationsTitle);
            this.panelNotifications.Controls.Add(this.lblNotice1);
            this.panelNotifications.Controls.Add(this.lblNotice2);
            this.panelNotifications.Controls.Add(this.lblNotice3);
            this.panelNotifications.Controls.Add(this.lblNotice4);

            this.lblNotificationsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblNotificationsTitle.ForeColor = Color.FromArgb(41, 128, 185);
            this.lblNotificationsTitle.Location = new Point(15, 15);
            this.lblNotificationsTitle.Size = new Size(350, 25);
            this.lblNotificationsTitle.Text = "🔔 Notification Center";

            this.lblNotice1.Font = new Font("Segoe UI", 9F);
            this.lblNotice1.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblNotice1.Location = new Point(15, 55);
            this.lblNotice1.Size = new Size(350, 55);
            this.lblNotice1.Text = "📌 Annual Sports Day scheduled for December 20, 2025. All classes will participate in various events.";

            this.lblNotice2.Font = new Font("Segoe UI", 9F);
            this.lblNotice2.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblNotice2.Location = new Point(15, 115);
            this.lblNotice2.Size = new Size(350, 55);
            this.lblNotice2.Text = "📌 Parent-Teacher Meeting on December 18, 2025. All parents are requested to attend.";

            this.lblNotice3.Font = new Font("Segoe UI", 9F);
            this.lblNotice3.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblNotice3.Location = new Point(15, 175);
            this.lblNotice3.Size = new Size(350, 55);
            this.lblNotice3.Text = "📌 Winter vacation from December 25, 2025 to January 5, 2026. School reopens on January 6.";

            this.lblNotice4.Font = new Font("Segoe UI", 9F);
            this.lblNotice4.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblNotice4.Location = new Point(15, 235);
            this.lblNotice4.Size = new Size(350, 55);
            this.lblNotice4.Text = "📌 Fee submission deadline for December is December 15. Late fee charges will apply after the due date.";

            // Upcoming Tasks Panel
            this.panelUpcomingTasks.BackColor = Color.White;
            this.panelUpcomingTasks.Location = new Point(400, 0);
            this.panelUpcomingTasks.Size = new Size(380, 330);
            this.panelUpcomingTasks.BorderStyle = BorderStyle.FixedSingle;
            this.panelUpcomingTasks.Controls.Add(this.lblTasksTitle);
            this.panelUpcomingTasks.Controls.Add(this.lblTask1);
            this.panelUpcomingTasks.Controls.Add(this.lblTask2);
            this.panelUpcomingTasks.Controls.Add(this.lblTask3);
            this.panelUpcomingTasks.Controls.Add(this.lblTask4);

            this.lblTasksTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblTasksTitle.ForeColor = Color.FromArgb(39, 174, 96);
            this.lblTasksTitle.Location = new Point(15, 15);
            this.lblTasksTitle.Size = new Size(350, 25);
            this.lblTasksTitle.Text = "📋 Upcoming Tasks";

            this.lblTask1.Font = new Font("Segoe UI", 9F);
            this.lblTask1.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblTask1.Location = new Point(15, 55);
            this.lblTask1.Size = new Size(350, 50);
            this.lblTask1.Text = "⏰ Dec 10 - Process teacher salaries for November\n     Status: Pending (5 teachers remaining)";

            this.lblTask2.Font = new Font("Segoe UI", 9F);
            this.lblTask2.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblTask2.Location = new Point(15, 115);
            this.lblTask2.Size = new Size(350, 50);
            this.lblTask2.Text = "⏰ Dec 12 - Review 2nd term examination results\n     Status: In Progress";

            this.lblTask3.Font = new Font("Segoe UI", 9F);
            this.lblTask3.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblTask3.Location = new Point(15, 175);
            this.lblTask3.Size = new Size(350, 50);
            this.lblTask3.Text = "⏰ Dec 15 - Fee collection deadline reminder\n     Status: Send SMS to 47 parents";

            this.lblTask4.Font = new Font("Segoe UI", 9F);
            this.lblTask4.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblTask4.Location = new Point(15, 235);
            this.lblTask4.Size = new Size(350, 50);
            this.lblTask4.Text = "⏰ Dec 18 - Prepare PTM arrangements\n     Status: Not Started";

            // ========================================
            // AdminDashboard
            // ========================================
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new Size(1100, 700);
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminDashboard";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard - School Management System";

            // Resume Layout
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebarHeader.ResumeLayout(false);
            this.panelStudentSubmenu.ResumeLayout(false);
            this.panelTeacherSubmenu.ResumeLayout(false);
            this.panelAcademicSubmenu.ResumeLayout(false);
            this.panelFeeSubmenu.ResumeLayout(false);
            this.panelSalarySubmenu.ResumeLayout(false);
            this.panelMainContent.ResumeLayout(false);
            this.panelTopBar.ResumeLayout(false);
            this.panelLogoSection.ResumeLayout(false);
            this.panelCardsContainer.ResumeLayout(false);
            this.panelCard1.ResumeLayout(false);
            this.panelCard2.ResumeLayout(false);
            this.panelCard3.ResumeLayout(false);
            this.panelCard4.ResumeLayout(false);
            this.panelBottomSection.ResumeLayout(false);
            this.panelNotifications.ResumeLayout(false);
            this.panelUpcomingTasks.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // Sidebar
        private Panel panelSidebar;
        private Panel panelSidebarHeader;
        private Label lblAdminTitle;
        private Label lblAdminSubtitle;

        // Sidebar Menu Buttons
        private Button btnStudentManagement;
        private Button btnTeacherManagement;
        private Button btnAcademicManagement;
        private Button btnFeeManagement;
        private Button btnSalaryManagement;
        private Button btnSystemConfig;
        private Button btnLogout;

        // Student Submenu
        private Panel panelStudentSubmenu;
        private Button btnAddStudent;
        private Button btnModifyStudent;
        private Button btnRemoveStudent;

        // Teacher Submenu
        private Panel panelTeacherSubmenu;
        private Button btnAddTeacher;
        private Button btnModifyTeacher;
        private Button btnRemoveTeacher;

        // Academic Submenu
        private Panel panelAcademicSubmenu;
        private Button btnViewClassAssignment;
        private Button btnUpdateClassAssignment;

        // Fee Submenu
        private Panel panelFeeSubmenu;
        private Button btnSubmitMonthlyFee;
        private Button btnSubmitAnnualCharges;
        private Button btnViewPaidStudents;
        private Button btnViewUnpaidStudents;

        // Salary Submenu
        private Panel panelSalarySubmenu;
        private Button btnMarkTeacherAttendance;
        private Button btnPayTeacherSalary;

        // Main Content
        private Panel panelMainContent;
        private Panel panelTopBar;
        private Label lblGreeting;
        private Label lblDateTime;

        // Logo Section
        private Panel panelLogoSection;
        private Label lblSchoolLogo;
        private Label lblSchoolName;
        private Label lblSchoolMotto;

        // Dashboard Cards
        private Panel panelCardsContainer;
        private Panel panelCard1;
        private Label lblCard1Icon;
        private Label lblCard1Value;
        private Label lblCard1Title;

        private Panel panelCard2;
        private Label lblCard2Icon;
        private Label lblCard2Value;
        private Label lblCard2Title;

        private Panel panelCard3;
        private Label lblCard3Icon;
        private Label lblCard3Value;
        private Label lblCard3Title;

        private Panel panelCard4;
        private Label lblCard4Icon;
        private Label lblCard4Value;
        private Label lblCard4Title;

        // Bottom Section
        private Panel panelBottomSection;
        private Panel panelNotifications;
        private Label lblNotificationsTitle;
        private Label lblNotice1;
        private Label lblNotice2;
        private Label lblNotice3;
        private Label lblNotice4;

        private Panel panelUpcomingTasks;
        private Label lblTasksTitle;
        private Label lblTask1;
        private Label lblTask2;
        private Label lblTask3;
        private Label lblTask4;
    }
}
