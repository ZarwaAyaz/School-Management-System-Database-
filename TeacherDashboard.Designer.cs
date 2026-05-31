namespace SchoolManagementSystem
{
    partial class TeacherDashboard
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
            this.panelHeader = new Panel();
            this.lblAcademicSession = new Label();
            this.btnNotifications = new Button();
            this.lblTeacherName = new Label();
            this.picProfile = new PictureBox();
            this.btnLogout = new Button();
            this.panelSidebar = new Panel();
            this.lblMenuTitle = new Label();
            this.btnAttendance = new Button();
            this.panelAttendanceSubmenu = new Panel();
            this.btnMarkAttendance = new Button();
            this.btnViewPastAttendance = new Button();
            this.btnAddMarks = new Button();
            this.panelMarksSubmenu = new Panel();
            this.btnEnterMarks = new Button();
            this.btnModifyMarks = new Button();
            this.btnViewResult = new Button();
            this.panelResultSubmenu = new Panel();
            this.btnSearchByName = new Button();
            this.btnSearchByRoll = new Button();
            this.btnTimetable = new Button();
            this.panelMainContent = new Panel();
            this.panelWelcomeBanner = new Panel();
            this.lblGreeting = new Label();
            this.lblWelcomeMessage = new Label();
            this.panelStatsRow = new Panel();
            this.panelCardStudents = new Panel();
            this.lblCardStudentsIcon = new Label();
            this.lblCardStudentsValue = new Label();
            this.lblCardStudentsTitle = new Label();
            this.panelCardAttendance = new Panel();
            this.lblCardAttendanceIcon = new Label();
            this.lblCardAttendanceValue = new Label();
            this.lblCardAttendanceTitle = new Label();
            this.panelCardMarks = new Panel();
            this.lblCardMarksIcon = new Label();
            this.lblCardMarksValue = new Label();
            this.lblCardMarksTitle = new Label();
            this.panelCardPromotions = new Panel();
            this.lblCardPromotionsIcon = new Label();
            this.lblCardPromotionsValue = new Label();
            this.lblCardPromotionsTitle = new Label();
            this.panelRecentActivity = new Panel();
            this.lblRecentActivityTitle = new Label();
            this.lstRecentActivity = new ListBox();
            this.btnGenerateResultCards = new Button();
            this.panelAnnouncements = new Panel();
            this.lblAnnouncementsTitle = new Label();
            this.txtAnnouncements = new TextBox();
            this.panelFooter = new Panel();
            this.lblCurrentDate = new Label();
            this.lblSchoolName = new Label();
            this.lblVersion = new Label();

            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.panelSidebar.SuspendLayout();
            this.panelAttendanceSubmenu.SuspendLayout();
            this.panelMarksSubmenu.SuspendLayout();
            this.panelResultSubmenu.SuspendLayout();
            this.panelMainContent.SuspendLayout();
            this.panelWelcomeBanner.SuspendLayout();
            this.panelStatsRow.SuspendLayout();
            this.panelCardStudents.SuspendLayout();
            this.panelCardAttendance.SuspendLayout();
            this.panelCardMarks.SuspendLayout();
            this.panelCardPromotions.SuspendLayout();
            this.panelRecentActivity.SuspendLayout();
            this.panelAnnouncements.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.BackColor = Color.FromArgb(41, 128, 185);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Location = new Point(0, 0);
            this.panelHeader.Size = new Size(1200, 60);
            this.panelHeader.Controls.Add(this.lblAcademicSession);
            this.panelHeader.Controls.Add(this.btnNotifications);
            this.panelHeader.Controls.Add(this.picProfile);
            this.panelHeader.Controls.Add(this.lblTeacherName);
            this.panelHeader.Controls.Add(this.btnLogout);

            // lblAcademicSession
            this.lblAcademicSession.AutoSize = true;
            this.lblAcademicSession.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblAcademicSession.ForeColor = Color.White;
            this.lblAcademicSession.Location = new Point(20, 18);
            this.lblAcademicSession.Text = "Academic Session: 2025-2026, 2nd Term";

            // btnNotifications
            this.btnNotifications.BackColor = Color.FromArgb(52, 152, 219);
            this.btnNotifications.FlatStyle = FlatStyle.Flat;
            this.btnNotifications.FlatAppearance.BorderSize = 0;
            this.btnNotifications.Font = new Font("Segoe UI", 12F);
            this.btnNotifications.ForeColor = Color.White;
            this.btnNotifications.Location = new Point(850, 12);
            this.btnNotifications.Size = new Size(45, 38);
            this.btnNotifications.Text = "🔔";
            this.btnNotifications.Cursor = Cursors.Hand;
            this.btnNotifications.Click += new EventHandler(this.btnNotifications_Click);

            // picProfile
            this.picProfile.BackColor = Color.White;
            this.picProfile.Location = new Point(910, 10);
            this.picProfile.Size = new Size(40, 40);
            this.picProfile.SizeMode = PictureBoxSizeMode.Zoom;

            // lblTeacherName
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblTeacherName.ForeColor = Color.White;
            this.lblTeacherName.Location = new Point(960, 18);
            this.lblTeacherName.Text = "Mr. Ahmad Khan";

            // btnLogout
            this.btnLogout.BackColor = Color.FromArgb(231, 76, 60);
            this.btnLogout.FlatStyle = FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnLogout.ForeColor = Color.White;
            this.btnLogout.Location = new Point(1100, 12);
            this.btnLogout.Size = new Size(85, 38);
            this.btnLogout.Text = "Logout";
            this.btnLogout.Cursor = Cursors.Hand;
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);

            // panelSidebar
            this.panelSidebar.BackColor = Color.FromArgb(44, 62, 80);
            this.panelSidebar.Location = new Point(0, 60);
            this.panelSidebar.Size = new Size(240, 610);
            this.panelSidebar.Controls.Add(this.lblMenuTitle);
            this.panelSidebar.Controls.Add(this.btnAttendance);
            this.panelSidebar.Controls.Add(this.panelAttendanceSubmenu);
            this.panelSidebar.Controls.Add(this.btnAddMarks);
            this.panelSidebar.Controls.Add(this.panelMarksSubmenu);
            this.panelSidebar.Controls.Add(this.btnViewResult);
            this.panelSidebar.Controls.Add(this.panelResultSubmenu);
            this.panelSidebar.Controls.Add(this.btnTimetable);

            // lblMenuTitle
            this.lblMenuTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblMenuTitle.ForeColor = Color.FromArgb(149, 165, 166);
            this.lblMenuTitle.Location = new Point(20, 20);
            this.lblMenuTitle.Size = new Size(200, 25);
            this.lblMenuTitle.Text = "MAIN MENU";

            // btnAttendance
            this.btnAttendance.BackColor = Color.FromArgb(44, 62, 80);
            this.btnAttendance.FlatStyle = FlatStyle.Flat;
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 73, 94);
            this.btnAttendance.Font = new Font("Segoe UI", 11F);
            this.btnAttendance.ForeColor = Color.White;
            this.btnAttendance.Location = new Point(0, 55);
            this.btnAttendance.Size = new Size(240, 45);
            this.btnAttendance.Text = "  Attendance                       ▼";
            this.btnAttendance.TextAlign = ContentAlignment.MiddleLeft;
            this.btnAttendance.Padding = new Padding(20, 0, 0, 0);
            this.btnAttendance.Cursor = Cursors.Hand;
            this.btnAttendance.Click += new EventHandler(this.btnAttendance_Click);

            // panelAttendanceSubmenu
            this.panelAttendanceSubmenu.BackColor = Color.FromArgb(52, 73, 94);
            this.panelAttendanceSubmenu.Location = new Point(0, 100);
            this.panelAttendanceSubmenu.Size = new Size(240, 80);
            this.panelAttendanceSubmenu.Visible = false;
            this.panelAttendanceSubmenu.Controls.Add(this.btnMarkAttendance);
            this.panelAttendanceSubmenu.Controls.Add(this.btnViewPastAttendance);

            // btnMarkAttendance
            this.btnMarkAttendance.BackColor = Color.FromArgb(52, 73, 94);
            this.btnMarkAttendance.FlatStyle = FlatStyle.Flat;
            this.btnMarkAttendance.FlatAppearance.BorderSize = 0;
            this.btnMarkAttendance.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            this.btnMarkAttendance.Font = new Font("Segoe UI", 10F);
            this.btnMarkAttendance.ForeColor = Color.FromArgb(189, 195, 199);
            this.btnMarkAttendance.Location = new Point(0, 0);
            this.btnMarkAttendance.Size = new Size(240, 40);
            this.btnMarkAttendance.Text = "     Mark Attendance";
            this.btnMarkAttendance.TextAlign = ContentAlignment.MiddleLeft;
            this.btnMarkAttendance.Padding = new Padding(30, 0, 0, 0);
            this.btnMarkAttendance.Cursor = Cursors.Hand;
            this.btnMarkAttendance.Click += new EventHandler(this.btnMarkAttendance_Click);

            // btnViewPastAttendance
            this.btnViewPastAttendance.BackColor = Color.FromArgb(52, 73, 94);
            this.btnViewPastAttendance.FlatStyle = FlatStyle.Flat;
            this.btnViewPastAttendance.FlatAppearance.BorderSize = 0;
            this.btnViewPastAttendance.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            this.btnViewPastAttendance.Font = new Font("Segoe UI", 10F);
            this.btnViewPastAttendance.ForeColor = Color.FromArgb(189, 195, 199);
            this.btnViewPastAttendance.Location = new Point(0, 40);
            this.btnViewPastAttendance.Size = new Size(240, 40);
            this.btnViewPastAttendance.Text = "     View Past Attendance";
            this.btnViewPastAttendance.TextAlign = ContentAlignment.MiddleLeft;
            this.btnViewPastAttendance.Padding = new Padding(30, 0, 0, 0);
            this.btnViewPastAttendance.Cursor = Cursors.Hand;
            this.btnViewPastAttendance.Click += new EventHandler(this.btnViewPastAttendance_Click);

            // btnAddMarks
            this.btnAddMarks.BackColor = Color.FromArgb(44, 62, 80);
            this.btnAddMarks.FlatStyle = FlatStyle.Flat;
            this.btnAddMarks.FlatAppearance.BorderSize = 0;
            this.btnAddMarks.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 73, 94);
            this.btnAddMarks.Font = new Font("Segoe UI", 11F);
            this.btnAddMarks.ForeColor = Color.White;
            this.btnAddMarks.Location = new Point(0, 180);
            this.btnAddMarks.Size = new Size(240, 45);
            this.btnAddMarks.Text = "  Add Marks                         ▼";
            this.btnAddMarks.TextAlign = ContentAlignment.MiddleLeft;
            this.btnAddMarks.Padding = new Padding(20, 0, 0, 0);
            this.btnAddMarks.Cursor = Cursors.Hand;
            this.btnAddMarks.Click += new EventHandler(this.btnAddMarks_Click);

            // panelMarksSubmenu
            this.panelMarksSubmenu.BackColor = Color.FromArgb(52, 73, 94);
            this.panelMarksSubmenu.Location = new Point(0, 225);
            this.panelMarksSubmenu.Size = new Size(240, 80);
            this.panelMarksSubmenu.Visible = false;
            this.panelMarksSubmenu.Controls.Add(this.btnEnterMarks);
            this.panelMarksSubmenu.Controls.Add(this.btnModifyMarks);

            // btnEnterMarks
            this.btnEnterMarks.BackColor = Color.FromArgb(52, 73, 94);
            this.btnEnterMarks.FlatStyle = FlatStyle.Flat;
            this.btnEnterMarks.FlatAppearance.BorderSize = 0;
            this.btnEnterMarks.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            this.btnEnterMarks.Font = new Font("Segoe UI", 10F);
            this.btnEnterMarks.ForeColor = Color.FromArgb(189, 195, 199);
            this.btnEnterMarks.Location = new Point(0, 0);
            this.btnEnterMarks.Size = new Size(240, 40);
            this.btnEnterMarks.Text = "     Enter Marks";
            this.btnEnterMarks.TextAlign = ContentAlignment.MiddleLeft;
            this.btnEnterMarks.Padding = new Padding(30, 0, 0, 0);
            this.btnEnterMarks.Cursor = Cursors.Hand;
            this.btnEnterMarks.Click += new EventHandler(this.btnEnterMarks_Click);

            // btnModifyMarks
            this.btnModifyMarks.BackColor = Color.FromArgb(52, 73, 94);
            this.btnModifyMarks.FlatStyle = FlatStyle.Flat;
            this.btnModifyMarks.FlatAppearance.BorderSize = 0;
            this.btnModifyMarks.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            this.btnModifyMarks.Font = new Font("Segoe UI", 10F);
            this.btnModifyMarks.ForeColor = Color.FromArgb(189, 195, 199);
            this.btnModifyMarks.Location = new Point(0, 40);
            this.btnModifyMarks.Size = new Size(240, 40);
            this.btnModifyMarks.Text = "     Modify Marks";
            this.btnModifyMarks.TextAlign = ContentAlignment.MiddleLeft;
            this.btnModifyMarks.Padding = new Padding(30, 0, 0, 0);
            this.btnModifyMarks.Cursor = Cursors.Hand;
            this.btnModifyMarks.Click += new EventHandler(this.btnModifyMarks_Click);

            // btnViewResult
            this.btnViewResult.BackColor = Color.FromArgb(44, 62, 80);
            this.btnViewResult.FlatStyle = FlatStyle.Flat;
            this.btnViewResult.FlatAppearance.BorderSize = 0;
            this.btnViewResult.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 73, 94);
            this.btnViewResult.Font = new Font("Segoe UI", 11F);
            this.btnViewResult.ForeColor = Color.White;
            this.btnViewResult.Location = new Point(0, 305);
            this.btnViewResult.Size = new Size(240, 45);
            this.btnViewResult.Text = "  View Result                       ▼";
            this.btnViewResult.TextAlign = ContentAlignment.MiddleLeft;
            this.btnViewResult.Padding = new Padding(20, 0, 0, 0);
            this.btnViewResult.Cursor = Cursors.Hand;
            this.btnViewResult.Click += new EventHandler(this.btnViewResult_Click);

            // panelResultSubmenu
            this.panelResultSubmenu.BackColor = Color.FromArgb(52, 73, 94);
            this.panelResultSubmenu.Location = new Point(0, 350);
            this.panelResultSubmenu.Size = new Size(240, 80);
            this.panelResultSubmenu.Visible = false;
            this.panelResultSubmenu.Controls.Add(this.btnSearchByName);
            this.panelResultSubmenu.Controls.Add(this.btnSearchByRoll);

            // btnSearchByName
            this.btnSearchByName.BackColor = Color.FromArgb(52, 73, 94);
            this.btnSearchByName.FlatStyle = FlatStyle.Flat;
            this.btnSearchByName.FlatAppearance.BorderSize = 0;
            this.btnSearchByName.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            this.btnSearchByName.Font = new Font("Segoe UI", 10F);
            this.btnSearchByName.ForeColor = Color.FromArgb(189, 195, 199);
            this.btnSearchByName.Location = new Point(0, 0);
            this.btnSearchByName.Size = new Size(240, 40);
            this.btnSearchByName.Text = "     Search by Name";
            this.btnSearchByName.TextAlign = ContentAlignment.MiddleLeft;
            this.btnSearchByName.Padding = new Padding(30, 0, 0, 0);
            this.btnSearchByName.Cursor = Cursors.Hand;
            this.btnSearchByName.Click += new EventHandler(this.btnSearchByName_Click);

            // btnSearchByRoll
            this.btnSearchByRoll.BackColor = Color.FromArgb(52, 73, 94);
            this.btnSearchByRoll.FlatStyle = FlatStyle.Flat;
            this.btnSearchByRoll.FlatAppearance.BorderSize = 0;
            this.btnSearchByRoll.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            this.btnSearchByRoll.Font = new Font("Segoe UI", 10F);
            this.btnSearchByRoll.ForeColor = Color.FromArgb(189, 195, 199);
            this.btnSearchByRoll.Location = new Point(0, 40);
            this.btnSearchByRoll.Size = new Size(240, 40);
            this.btnSearchByRoll.Text = "     Search by Roll No";
            this.btnSearchByRoll.TextAlign = ContentAlignment.MiddleLeft;
            this.btnSearchByRoll.Padding = new Padding(30, 0, 0, 0);
            this.btnSearchByRoll.Cursor = Cursors.Hand;
            this.btnSearchByRoll.Click += new EventHandler(this.btnSearchByRoll_Click);

            // btnTimetable
            this.btnTimetable.BackColor = Color.FromArgb(44, 62, 80);
            this.btnTimetable.FlatStyle = FlatStyle.Flat;
            this.btnTimetable.FlatAppearance.BorderSize = 0;
            this.btnTimetable.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 73, 94);
            this.btnTimetable.Font = new Font("Segoe UI", 11F);
            this.btnTimetable.ForeColor = Color.White;
            this.btnTimetable.Location = new Point(0, 430);
            this.btnTimetable.Size = new Size(240, 45);
            this.btnTimetable.Text = "  Class Timetable";
            this.btnTimetable.TextAlign = ContentAlignment.MiddleLeft;
            this.btnTimetable.Padding = new Padding(20, 0, 0, 0);
            this.btnTimetable.Cursor = Cursors.Hand;
            this.btnTimetable.Click += new EventHandler(this.btnTimetable_Click);

            // panelMainContent
            this.panelMainContent.BackColor = Color.FromArgb(236, 240, 241);
            this.panelMainContent.Location = new Point(240, 60);
            this.panelMainContent.Size = new Size(960, 570);
            this.panelMainContent.Controls.Add(this.panelWelcomeBanner);
            this.panelMainContent.Controls.Add(this.panelStatsRow);
            this.panelMainContent.Controls.Add(this.panelRecentActivity);
            this.panelMainContent.Controls.Add(this.panelAnnouncements);

            // panelWelcomeBanner
            this.panelWelcomeBanner.BackColor = Color.FromArgb(41, 128, 185);
            this.panelWelcomeBanner.Location = new Point(20, 15);
            this.panelWelcomeBanner.Size = new Size(920, 80);
            this.panelWelcomeBanner.Controls.Add(this.lblGreeting);
            this.panelWelcomeBanner.Controls.Add(this.lblWelcomeMessage);

            // lblGreeting
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblGreeting.ForeColor = Color.White;
            this.lblGreeting.Location = new Point(20, 12);
            this.lblGreeting.Text = "Good Morning, Mr. Ahmad Khan!";

            // lblWelcomeMessage
            this.lblWelcomeMessage.AutoSize = true;
            this.lblWelcomeMessage.Font = new Font("Segoe UI", 10F);
            this.lblWelcomeMessage.ForeColor = Color.FromArgb(214, 234, 248);
            this.lblWelcomeMessage.Location = new Point(23, 52);
            this.lblWelcomeMessage.Text = "Welcome to Teacher Dashboard. Have a productive day!";

            // panelStatsRow
            this.panelStatsRow.BackColor = Color.Transparent;
            this.panelStatsRow.Location = new Point(20, 110);
            this.panelStatsRow.Size = new Size(920, 120);
            this.panelStatsRow.Controls.Add(this.panelCardStudents);
            this.panelStatsRow.Controls.Add(this.panelCardAttendance);
            this.panelStatsRow.Controls.Add(this.panelCardMarks);
            this.panelStatsRow.Controls.Add(this.panelCardPromotions);

            // panelCardStudents
            this.panelCardStudents.BackColor = Color.FromArgb(52, 152, 219);
            this.panelCardStudents.Location = new Point(0, 0);
            this.panelCardStudents.Size = new Size(215, 110);
            this.panelCardStudents.Controls.Add(this.lblCardStudentsIcon);
            this.panelCardStudents.Controls.Add(this.lblCardStudentsValue);
            this.panelCardStudents.Controls.Add(this.lblCardStudentsTitle);

            // lblCardStudentsIcon
            this.lblCardStudentsIcon.Font = new Font("Segoe UI", 28F);
            this.lblCardStudentsIcon.ForeColor = Color.White;
            this.lblCardStudentsIcon.Location = new Point(15, 15);
            this.lblCardStudentsIcon.Size = new Size(60, 50);
            this.lblCardStudentsIcon.Text = "👨‍🎓";

            // lblCardStudentsValue
            this.lblCardStudentsValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            this.lblCardStudentsValue.ForeColor = Color.White;
            this.lblCardStudentsValue.Location = new Point(85, 20);
            this.lblCardStudentsValue.Size = new Size(120, 40);
            this.lblCardStudentsValue.Text = "30";
            this.lblCardStudentsValue.TextAlign = ContentAlignment.MiddleRight;

            // lblCardStudentsTitle
            this.lblCardStudentsTitle.Font = new Font("Segoe UI", 10F);
            this.lblCardStudentsTitle.ForeColor = Color.FromArgb(214, 234, 248);
            this.lblCardStudentsTitle.Location = new Point(15, 75);
            this.lblCardStudentsTitle.Size = new Size(185, 25);
            this.lblCardStudentsTitle.Text = "Total Students in Class";

            // panelCardAttendance
            this.panelCardAttendance.BackColor = Color.FromArgb(46, 204, 113);
            this.panelCardAttendance.Location = new Point(235, 0);
            this.panelCardAttendance.Size = new Size(215, 110);
            this.panelCardAttendance.Controls.Add(this.lblCardAttendanceIcon);
            this.panelCardAttendance.Controls.Add(this.lblCardAttendanceValue);
            this.panelCardAttendance.Controls.Add(this.lblCardAttendanceTitle);

            // lblCardAttendanceIcon
            this.lblCardAttendanceIcon.Font = new Font("Segoe UI", 28F);
            this.lblCardAttendanceIcon.ForeColor = Color.White;
            this.lblCardAttendanceIcon.Location = new Point(15, 15);
            this.lblCardAttendanceIcon.Size = new Size(60, 50);
            this.lblCardAttendanceIcon.Text = "✓";

            // lblCardAttendanceValue
            this.lblCardAttendanceValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            this.lblCardAttendanceValue.ForeColor = Color.White;
            this.lblCardAttendanceValue.Location = new Point(75, 20);
            this.lblCardAttendanceValue.Size = new Size(130, 40);
            this.lblCardAttendanceValue.Text = "28/30";
            this.lblCardAttendanceValue.TextAlign = ContentAlignment.MiddleRight;

            // lblCardAttendanceTitle
            this.lblCardAttendanceTitle.Font = new Font("Segoe UI", 10F);
            this.lblCardAttendanceTitle.ForeColor = Color.FromArgb(213, 245, 227);
            this.lblCardAttendanceTitle.Location = new Point(15, 75);
            this.lblCardAttendanceTitle.Size = new Size(185, 25);
            this.lblCardAttendanceTitle.Text = "Attendance Today";

            // panelCardMarks
            this.panelCardMarks.BackColor = Color.FromArgb(230, 126, 34);
            this.panelCardMarks.Location = new Point(470, 0);
            this.panelCardMarks.Size = new Size(215, 110);
            this.panelCardMarks.Controls.Add(this.lblCardMarksIcon);
            this.panelCardMarks.Controls.Add(this.lblCardMarksValue);
            this.panelCardMarks.Controls.Add(this.lblCardMarksTitle);

            // lblCardMarksIcon
            this.lblCardMarksIcon.Font = new Font("Segoe UI", 28F);
            this.lblCardMarksIcon.ForeColor = Color.White;
            this.lblCardMarksIcon.Location = new Point(15, 15);
            this.lblCardMarksIcon.Size = new Size(60, 50);
            this.lblCardMarksIcon.Text = "📝";

            // lblCardMarksValue
            this.lblCardMarksValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            this.lblCardMarksValue.ForeColor = Color.White;
            this.lblCardMarksValue.Location = new Point(85, 20);
            this.lblCardMarksValue.Size = new Size(120, 40);
            this.lblCardMarksValue.Text = "5";
            this.lblCardMarksValue.TextAlign = ContentAlignment.MiddleRight;

            // lblCardMarksTitle
            this.lblCardMarksTitle.Font = new Font("Segoe UI", 10F);
            this.lblCardMarksTitle.ForeColor = Color.FromArgb(250, 229, 211);
            this.lblCardMarksTitle.Location = new Point(15, 75);
            this.lblCardMarksTitle.Size = new Size(185, 25);
            this.lblCardMarksTitle.Text = "Pending Marks to Enter";

            // panelCardPromotions
            this.panelCardPromotions.BackColor = Color.FromArgb(155, 89, 182);
            this.panelCardPromotions.Location = new Point(705, 0);
            this.panelCardPromotions.Size = new Size(215, 110);
            this.panelCardPromotions.Controls.Add(this.lblCardPromotionsIcon);
            this.panelCardPromotions.Controls.Add(this.lblCardPromotionsValue);
            this.panelCardPromotions.Controls.Add(this.lblCardPromotionsTitle);

            // lblCardPromotionsIcon
            this.lblCardPromotionsIcon.Font = new Font("Segoe UI", 28F);
            this.lblCardPromotionsIcon.ForeColor = Color.White;
            this.lblCardPromotionsIcon.Location = new Point(15, 15);
            this.lblCardPromotionsIcon.Size = new Size(60, 50);
            this.lblCardPromotionsIcon.Text = "🎓";

            // lblCardPromotionsValue
            this.lblCardPromotionsValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            this.lblCardPromotionsValue.ForeColor = Color.White;
            this.lblCardPromotionsValue.Location = new Point(85, 20);
            this.lblCardPromotionsValue.Size = new Size(120, 40);
            this.lblCardPromotionsValue.Text = "27";
            this.lblCardPromotionsValue.TextAlign = ContentAlignment.MiddleRight;

            // lblCardPromotionsTitle
            this.lblCardPromotionsTitle.Font = new Font("Segoe UI", 10F);
            this.lblCardPromotionsTitle.ForeColor = Color.FromArgb(232, 218, 239);
            this.lblCardPromotionsTitle.Location = new Point(15, 75);
            this.lblCardPromotionsTitle.Size = new Size(185, 25);
            this.lblCardPromotionsTitle.Text = "Eligible for Promotion";

            // panelRecentActivity
            this.panelRecentActivity.BackColor = Color.White;
            this.panelRecentActivity.Location = new Point(20, 245);
            this.panelRecentActivity.Size = new Size(450, 310);
            this.panelRecentActivity.Controls.Add(this.lblRecentActivityTitle);
            this.panelRecentActivity.Controls.Add(this.lstRecentActivity);
            this.panelRecentActivity.Controls.Add(this.btnGenerateResultCards);

            // lblRecentActivityTitle
            this.lblRecentActivityTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblRecentActivityTitle.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblRecentActivityTitle.Location = new Point(15, 15);
            this.lblRecentActivityTitle.Size = new Size(300, 25);
            this.lblRecentActivityTitle.Text = "Recent Activity / Quick Links";

            // lstRecentActivity
            this.lstRecentActivity.Font = new Font("Segoe UI", 10F);
            this.lstRecentActivity.ForeColor = Color.FromArgb(44, 62, 80);
            this.lstRecentActivity.Location = new Point(15, 50);
            this.lstRecentActivity.Size = new Size(420, 195);
            this.lstRecentActivity.BorderStyle = BorderStyle.FixedSingle;
            this.lstRecentActivity.Items.AddRange(new object[] {
                "Marked attendance for Grade 4-A (Today, 8:30 AM)",
                "Added Math marks for Monthly Test (Yesterday)",
                "Viewed result for Ali Ahmed (Roll 01)",
                "Marked attendance for Grade 4-A (Yesterday)",
                "Added Science marks for Monthly Test (Dec 4)",
                "Added English marks for Monthly Test (Dec 3)",
                "Marked attendance for Grade 4-A (Dec 3)"
            });

            // btnGenerateResultCards
            this.btnGenerateResultCards.BackColor = Color.FromArgb(41, 128, 185);
            this.btnGenerateResultCards.FlatStyle = FlatStyle.Flat;
            this.btnGenerateResultCards.FlatAppearance.BorderSize = 0;
            this.btnGenerateResultCards.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnGenerateResultCards.ForeColor = Color.White;
            this.btnGenerateResultCards.Location = new Point(15, 258);
            this.btnGenerateResultCards.Size = new Size(220, 38);
            this.btnGenerateResultCards.Text = "Generate Result Cards";
            this.btnGenerateResultCards.Cursor = Cursors.Hand;
            this.btnGenerateResultCards.Click += new EventHandler(this.btnGenerateResultCards_Click);

            // panelAnnouncements
            this.panelAnnouncements.BackColor = Color.White;
            this.panelAnnouncements.Location = new Point(490, 245);
            this.panelAnnouncements.Size = new Size(450, 310);
            this.panelAnnouncements.Controls.Add(this.lblAnnouncementsTitle);
            this.panelAnnouncements.Controls.Add(this.txtAnnouncements);

            // lblAnnouncementsTitle
            this.lblAnnouncementsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblAnnouncementsTitle.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblAnnouncementsTitle.Location = new Point(15, 15);
            this.lblAnnouncementsTitle.Size = new Size(350, 25);
            this.lblAnnouncementsTitle.Text = "Announcements from Admin/Principal";

            // txtAnnouncements
            this.txtAnnouncements.Font = new Font("Segoe UI", 10F);
            this.txtAnnouncements.ForeColor = Color.FromArgb(44, 62, 80);
            this.txtAnnouncements.Location = new Point(15, 50);
            this.txtAnnouncements.Size = new Size(420, 245);
            this.txtAnnouncements.Multiline = true;
            this.txtAnnouncements.ReadOnly = true;
            this.txtAnnouncements.ScrollBars = ScrollBars.Vertical;
            this.txtAnnouncements.BackColor = Color.FromArgb(250, 250, 250);
            this.txtAnnouncements.BorderStyle = BorderStyle.FixedSingle;
            this.txtAnnouncements.Text = "Important Notice (Dec 6, 2025)\r\nAll teachers must submit 2nd Term marks by Dec 15, 2025.\r\n\r\nStaff Meeting (Dec 5, 2025)\r\nStaff meeting scheduled for Dec 10 at 2:00 PM in the conference room.\r\n\r\nWinter Break (Dec 4, 2025)\r\nWinter vacation from Dec 20, 2025 to Jan 5, 2026.\r\n\r\nPTM Schedule (Dec 1, 2025)\r\nParent-Teacher Meeting on Dec 18, 2025 from 9 AM to 1 PM.";

            // panelFooter
            this.panelFooter.BackColor = Color.FromArgb(44, 62, 80);
            this.panelFooter.Location = new Point(0, 630);
            this.panelFooter.Size = new Size(1200, 40);
            this.panelFooter.Controls.Add(this.lblCurrentDate);
            this.panelFooter.Controls.Add(this.lblSchoolName);
            this.panelFooter.Controls.Add(this.lblVersion);

            // lblCurrentDate
            this.lblCurrentDate.Font = new Font("Segoe UI", 9F);
            this.lblCurrentDate.ForeColor = Color.FromArgb(189, 195, 199);
            this.lblCurrentDate.Location = new Point(20, 10);
            this.lblCurrentDate.Size = new Size(200, 20);
            this.lblCurrentDate.Text = "December 7, 2025";

            // lblSchoolName
            this.lblSchoolName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblSchoolName.ForeColor = Color.White;
            this.lblSchoolName.Location = new Point(450, 10);
            this.lblSchoolName.Size = new Size(300, 20);
            this.lblSchoolName.Text = "ABC School Management System";
            this.lblSchoolName.TextAlign = ContentAlignment.MiddleCenter;

            // lblVersion
            this.lblVersion.Font = new Font("Segoe UI", 9F);
            this.lblVersion.ForeColor = Color.FromArgb(189, 195, 199);
            this.lblVersion.Location = new Point(1020, 10);
            this.lblVersion.Size = new Size(160, 20);
            this.lblVersion.Text = "v1.0 Semester Project";
            this.lblVersion.TextAlign = ContentAlignment.MiddleRight;

            // TeacherDashboard
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new Size(1200, 670);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelFooter);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TeacherDashboard";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "School Management System - Teacher Dashboard";

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.panelSidebar.ResumeLayout(false);
            this.panelAttendanceSubmenu.ResumeLayout(false);
            this.panelMarksSubmenu.ResumeLayout(false);
            this.panelResultSubmenu.ResumeLayout(false);
            this.panelMainContent.ResumeLayout(false);
            this.panelWelcomeBanner.ResumeLayout(false);
            this.panelWelcomeBanner.PerformLayout();
            this.panelStatsRow.ResumeLayout(false);
            this.panelCardStudents.ResumeLayout(false);
            this.panelCardAttendance.ResumeLayout(false);
            this.panelCardMarks.ResumeLayout(false);
            this.panelCardPromotions.ResumeLayout(false);
            this.panelRecentActivity.ResumeLayout(false);
            this.panelAnnouncements.ResumeLayout(false);
            this.panelAnnouncements.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblAcademicSession;
        private Button btnNotifications;
        private PictureBox picProfile;
        private Label lblTeacherName;
        private Button btnLogout;
        private Panel panelSidebar;
        private Label lblMenuTitle;
        private Button btnAttendance;
        private Panel panelAttendanceSubmenu;
        private Button btnMarkAttendance;
        private Button btnViewPastAttendance;
        private Button btnAddMarks;
        private Panel panelMarksSubmenu;
        private Button btnEnterMarks;
        private Button btnModifyMarks;
        private Button btnViewResult;
        private Panel panelResultSubmenu;
        private Button btnSearchByName;
        private Button btnSearchByRoll;
        private Button btnTimetable;
        private Panel panelMainContent;
        private Panel panelWelcomeBanner;
        private Label lblGreeting;
        private Label lblWelcomeMessage;
        private Panel panelStatsRow;
        private Panel panelCardStudents;
        private Label lblCardStudentsIcon;
        private Label lblCardStudentsValue;
        private Label lblCardStudentsTitle;
        private Panel panelCardAttendance;
        private Label lblCardAttendanceIcon;
        private Label lblCardAttendanceValue;
        private Label lblCardAttendanceTitle;
        private Panel panelCardMarks;
        private Label lblCardMarksIcon;
        private Label lblCardMarksValue;
        private Label lblCardMarksTitle;
        private Panel panelCardPromotions;
        private Label lblCardPromotionsIcon;
        private Label lblCardPromotionsValue;
        private Label lblCardPromotionsTitle;
        private Panel panelRecentActivity;
        private Label lblRecentActivityTitle;
        private ListBox lstRecentActivity;
        private Button btnGenerateResultCards;
        private Panel panelAnnouncements;
        private Label lblAnnouncementsTitle;
        private TextBox txtAnnouncements;
        private Panel panelFooter;
        private Label lblCurrentDate;
        private Label lblSchoolName;
        private Label lblVersion;
    }
}
