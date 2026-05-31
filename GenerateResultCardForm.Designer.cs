namespace SchoolManagementSystem
{
    partial class GenerateResultCardForm
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
            // Header
            this.panelHeader = new Panel();
            this.lblTitle = new Label();
            this.lblSubtitle = new Label();

            // Search Panel
            this.panelSearch = new Panel();
            this.lblSearchName = new Label();
            this.txtSearchName = new TextBox();
            this.lblSearchRoll = new Label();
            this.txtSearchRoll = new TextBox();
            this.btnSearch = new Button();

            // Result Card Container
            this.panelResultCardContainer = new Panel();

            // Student Info Section
            this.panelStudentInfo = new Panel();
            this.lblStudentInfoTitle = new Label();
            this.lblStudentNameLabel = new Label();
            this.lblStudentNameValue = new Label();
            this.lblFatherNameLabel = new Label();
            this.lblFatherNameValue = new Label();
            this.lblRollNoLabel = new Label();
            this.lblRollNoValue = new Label();
            this.lblClassLabel = new Label();
            this.lblClassValue = new Label();
            this.lblSessionLabel = new Label();
            this.lblSessionValue = new Label();

            // Marks Table Section
            this.panelMarksTable = new Panel();
            this.lblMarksTableTitle = new Label();

            // Table Header
            this.panelTableHeader = new Panel();
            this.lblColSubject = new Label();
            this.lblColTerm1 = new Label();
            this.lblColTerm2 = new Label();
            this.lblColFinal = new Label();
            this.lblColTotal = new Label();
            this.lblColGrade = new Label();

            // Subject Rows
            this.panelRow1 = new Panel();
            this.lblSubject1 = new Label();
            this.lblSubject1Term1 = new Label();
            this.lblSubject1Term2 = new Label();
            this.lblSubject1Final = new Label();
            this.lblSubject1Total = new Label();
            this.lblSubject1Grade = new Label();

            this.panelRow2 = new Panel();
            this.lblSubject2 = new Label();
            this.lblSubject2Term1 = new Label();
            this.lblSubject2Term2 = new Label();
            this.lblSubject2Final = new Label();
            this.lblSubject2Total = new Label();
            this.lblSubject2Grade = new Label();

            this.panelRow3 = new Panel();
            this.lblSubject3 = new Label();
            this.lblSubject3Term1 = new Label();
            this.lblSubject3Term2 = new Label();
            this.lblSubject3Final = new Label();
            this.lblSubject3Total = new Label();
            this.lblSubject3Grade = new Label();

            this.panelRow4 = new Panel();
            this.lblSubject4 = new Label();
            this.lblSubject4Term1 = new Label();
            this.lblSubject4Term2 = new Label();
            this.lblSubject4Final = new Label();
            this.lblSubject4Total = new Label();
            this.lblSubject4Grade = new Label();

            this.panelRow5 = new Panel();
            this.lblSubject5 = new Label();
            this.lblSubject5Term1 = new Label();
            this.lblSubject5Term2 = new Label();
            this.lblSubject5Final = new Label();
            this.lblSubject5Total = new Label();
            this.lblSubject5Grade = new Label();

            this.panelRow6 = new Panel();
            this.lblSubject6 = new Label();
            this.lblSubject6Term1 = new Label();
            this.lblSubject6Term2 = new Label();
            this.lblSubject6Final = new Label();
            this.lblSubject6Total = new Label();
            this.lblSubject6Grade = new Label();

            // Summary Section
            this.panelSummary = new Panel();
            this.lblSummaryTitle = new Label();
            this.lblTotalMarksLabel = new Label();
            this.lblTotalMarksValue = new Label();
            this.lblPercentageLabel = new Label();
            this.lblPercentageValue = new Label();
            this.lblOverallGradeLabel = new Label();
            this.lblOverallGradeValue = new Label();
            this.lblAttendanceLabel = new Label();
            this.lblAttendanceValue = new Label();
            this.lblStatusLabel = new Label();
            this.lblStatusValue = new Label();

            // Footer
            this.panelFooter = new Panel();
            this.btnBackToDashboard = new Button();
            this.btnGenerateCard = new Button();

            // Suspend Layout
            this.panelHeader.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelResultCardContainer.SuspendLayout();
            this.panelStudentInfo.SuspendLayout();
            this.panelMarksTable.SuspendLayout();
            this.panelTableHeader.SuspendLayout();
            this.panelRow1.SuspendLayout();
            this.panelRow2.SuspendLayout();
            this.panelRow3.SuspendLayout();
            this.panelRow4.SuspendLayout();
            this.panelRow5.SuspendLayout();
            this.panelRow6.SuspendLayout();
            this.panelSummary.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();

            // ========================================
            // panelHeader
            // ========================================
            this.panelHeader.BackColor = Color.FromArgb(41, 128, 185);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Location = new Point(0, 0);
            this.panelHeader.Size = new Size(1000, 80);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblSubtitle);

            this.lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Location = new Point(0, 15);
            this.lblTitle.Size = new Size(1000, 35);
            this.lblTitle.Text = "Generate Result Card - Grade 4 - Section A";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSubtitle.Font = new Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = Color.FromArgb(214, 234, 248);
            this.lblSubtitle.Location = new Point(0, 50);
            this.lblSubtitle.Size = new Size(1000, 20);
            this.lblSubtitle.Text = "Search a student to generate the result card";
            this.lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;

            // ========================================
            // panelSearch
            // ========================================
            this.panelSearch.BackColor = Color.White;
            this.panelSearch.Location = new Point(30, 95);
            this.panelSearch.Size = new Size(940, 60);
            this.panelSearch.BorderStyle = BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.lblSearchName);
            this.panelSearch.Controls.Add(this.txtSearchName);
            this.panelSearch.Controls.Add(this.lblSearchRoll);
            this.panelSearch.Controls.Add(this.txtSearchRoll);
            this.panelSearch.Controls.Add(this.btnSearch);

            this.lblSearchName.Font = new Font("Segoe UI", 10F);
            this.lblSearchName.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblSearchName.Location = new Point(20, 18);
            this.lblSearchName.Size = new Size(100, 25);
            this.lblSearchName.Text = "Student Name:";

            this.txtSearchName.Font = new Font("Segoe UI", 10F);
            this.txtSearchName.Location = new Point(125, 15);
            this.txtSearchName.Size = new Size(250, 30);
            this.txtSearchName.BorderStyle = BorderStyle.FixedSingle;

            this.lblSearchRoll.Font = new Font("Segoe UI", 10F);
            this.lblSearchRoll.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblSearchRoll.Location = new Point(420, 18);
            this.lblSearchRoll.Size = new Size(80, 25);
            this.lblSearchRoll.Text = "Roll No:";

            this.txtSearchRoll.Font = new Font("Segoe UI", 10F);
            this.txtSearchRoll.Location = new Point(505, 15);
            this.txtSearchRoll.Size = new Size(150, 30);
            this.txtSearchRoll.BorderStyle = BorderStyle.FixedSingle;

            this.btnSearch.BackColor = Color.FromArgb(41, 128, 185);
            this.btnSearch.FlatStyle = FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnSearch.ForeColor = Color.White;
            this.btnSearch.Location = new Point(800, 12);
            this.btnSearch.Size = new Size(120, 36);
            this.btnSearch.Text = "🔍 Search";
            this.btnSearch.Cursor = Cursors.Hand;
            this.btnSearch.Click += new EventHandler(this.btnSearch_Click);

            // ========================================
            // panelResultCardContainer
            // ========================================
            this.panelResultCardContainer.BackColor = Color.FromArgb(236, 240, 241);
            this.panelResultCardContainer.Location = new Point(30, 165);
            this.panelResultCardContainer.Size = new Size(940, 420);
            this.panelResultCardContainer.Visible = false;
            this.panelResultCardContainer.Controls.Add(this.panelStudentInfo);
            this.panelResultCardContainer.Controls.Add(this.panelMarksTable);
            this.panelResultCardContainer.Controls.Add(this.panelSummary);

            // ========================================
            // panelStudentInfo
            // ========================================
            this.panelStudentInfo.BackColor = Color.White;
            this.panelStudentInfo.Location = new Point(10, 10);
            this.panelStudentInfo.Size = new Size(920, 90);
            this.panelStudentInfo.BorderStyle = BorderStyle.FixedSingle;
            this.panelStudentInfo.Controls.Add(this.lblStudentInfoTitle);
            this.panelStudentInfo.Controls.Add(this.lblStudentNameLabel);
            this.panelStudentInfo.Controls.Add(this.lblStudentNameValue);
            this.panelStudentInfo.Controls.Add(this.lblFatherNameLabel);
            this.panelStudentInfo.Controls.Add(this.lblFatherNameValue);
            this.panelStudentInfo.Controls.Add(this.lblRollNoLabel);
            this.panelStudentInfo.Controls.Add(this.lblRollNoValue);
            this.panelStudentInfo.Controls.Add(this.lblClassLabel);
            this.panelStudentInfo.Controls.Add(this.lblClassValue);
            this.panelStudentInfo.Controls.Add(this.lblSessionLabel);
            this.panelStudentInfo.Controls.Add(this.lblSessionValue);

            this.lblStudentInfoTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblStudentInfoTitle.ForeColor = Color.FromArgb(41, 128, 185);
            this.lblStudentInfoTitle.Location = new Point(10, 8);
            this.lblStudentInfoTitle.Size = new Size(200, 25);
            this.lblStudentInfoTitle.Text = "📋 Student Information";

            // Row 1
            this.lblStudentNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblStudentNameLabel.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblStudentNameLabel.Location = new Point(15, 40);
            this.lblStudentNameLabel.Size = new Size(100, 20);
            this.lblStudentNameLabel.Text = "Student Name:";

            this.lblStudentNameValue.Font = new Font("Segoe UI", 9F);
            this.lblStudentNameValue.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblStudentNameValue.Location = new Point(115, 40);
            this.lblStudentNameValue.Size = new Size(150, 20);
            this.lblStudentNameValue.Text = "Ali Ahmed";

            this.lblFatherNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblFatherNameLabel.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblFatherNameLabel.Location = new Point(280, 40);
            this.lblFatherNameLabel.Size = new Size(90, 20);
            this.lblFatherNameLabel.Text = "Father Name:";

            this.lblFatherNameValue.Font = new Font("Segoe UI", 9F);
            this.lblFatherNameValue.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblFatherNameValue.Location = new Point(375, 40);
            this.lblFatherNameValue.Size = new Size(150, 20);
            this.lblFatherNameValue.Text = "Ahmed Khan";

            this.lblRollNoLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblRollNoLabel.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblRollNoLabel.Location = new Point(550, 40);
            this.lblRollNoLabel.Size = new Size(55, 20);
            this.lblRollNoLabel.Text = "Roll No:";

            this.lblRollNoValue.Font = new Font("Segoe UI", 9F);
            this.lblRollNoValue.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblRollNoValue.Location = new Point(610, 40);
            this.lblRollNoValue.Size = new Size(50, 20);
            this.lblRollNoValue.Text = "01";

            // Row 2
            this.lblClassLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblClassLabel.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblClassLabel.Location = new Point(15, 65);
            this.lblClassLabel.Size = new Size(100, 20);
            this.lblClassLabel.Text = "Class / Section:";

            this.lblClassValue.Font = new Font("Segoe UI", 9F);
            this.lblClassValue.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblClassValue.Location = new Point(115, 65);
            this.lblClassValue.Size = new Size(150, 20);
            this.lblClassValue.Text = "Grade 4 - Section A";

            this.lblSessionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblSessionLabel.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblSessionLabel.Location = new Point(280, 65);
            this.lblSessionLabel.Size = new Size(110, 20);
            this.lblSessionLabel.Text = "Academic Session:";

            this.lblSessionValue.Font = new Font("Segoe UI", 9F);
            this.lblSessionValue.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblSessionValue.Location = new Point(395, 65);
            this.lblSessionValue.Size = new Size(150, 20);
            this.lblSessionValue.Text = "2025-2026";

            // ========================================
            // panelMarksTable
            // ========================================
            this.panelMarksTable.BackColor = Color.White;
            this.panelMarksTable.Location = new Point(10, 110);
            this.panelMarksTable.Size = new Size(620, 295);
            this.panelMarksTable.BorderStyle = BorderStyle.FixedSingle;
            this.panelMarksTable.Controls.Add(this.lblMarksTableTitle);
            this.panelMarksTable.Controls.Add(this.panelTableHeader);
            this.panelMarksTable.Controls.Add(this.panelRow1);
            this.panelMarksTable.Controls.Add(this.panelRow2);
            this.panelMarksTable.Controls.Add(this.panelRow3);
            this.panelMarksTable.Controls.Add(this.panelRow4);
            this.panelMarksTable.Controls.Add(this.panelRow5);
            this.panelMarksTable.Controls.Add(this.panelRow6);

            this.lblMarksTableTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblMarksTableTitle.ForeColor = Color.FromArgb(41, 128, 185);
            this.lblMarksTableTitle.Location = new Point(10, 8);
            this.lblMarksTableTitle.Size = new Size(200, 25);
            this.lblMarksTableTitle.Text = "📊 Marks Detail";

            // Table Header
            this.panelTableHeader.BackColor = Color.FromArgb(52, 73, 94);
            this.panelTableHeader.Location = new Point(10, 38);
            this.panelTableHeader.Size = new Size(598, 32);
            this.panelTableHeader.Controls.Add(this.lblColSubject);
            this.panelTableHeader.Controls.Add(this.lblColTerm1);
            this.panelTableHeader.Controls.Add(this.lblColTerm2);
            this.panelTableHeader.Controls.Add(this.lblColFinal);
            this.panelTableHeader.Controls.Add(this.lblColTotal);
            this.panelTableHeader.Controls.Add(this.lblColGrade);

            this.lblColSubject.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblColSubject.ForeColor = Color.White;
            this.lblColSubject.Location = new Point(10, 6);
            this.lblColSubject.Size = new Size(120, 20);
            this.lblColSubject.Text = "Subject";

            this.lblColTerm1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblColTerm1.ForeColor = Color.White;
            this.lblColTerm1.Location = new Point(140, 6);
            this.lblColTerm1.Size = new Size(80, 20);
            this.lblColTerm1.Text = "1st Term";
            this.lblColTerm1.TextAlign = ContentAlignment.MiddleCenter;

            this.lblColTerm2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblColTerm2.ForeColor = Color.White;
            this.lblColTerm2.Location = new Point(230, 6);
            this.lblColTerm2.Size = new Size(80, 20);
            this.lblColTerm2.Text = "2nd Term";
            this.lblColTerm2.TextAlign = ContentAlignment.MiddleCenter;

            this.lblColFinal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblColFinal.ForeColor = Color.White;
            this.lblColFinal.Location = new Point(320, 6);
            this.lblColFinal.Size = new Size(80, 20);
            this.lblColFinal.Text = "Final";
            this.lblColFinal.TextAlign = ContentAlignment.MiddleCenter;

            this.lblColTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblColTotal.ForeColor = Color.White;
            this.lblColTotal.Location = new Point(410, 6);
            this.lblColTotal.Size = new Size(80, 20);
            this.lblColTotal.Text = "Total (150)";
            this.lblColTotal.TextAlign = ContentAlignment.MiddleCenter;

            this.lblColGrade.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblColGrade.ForeColor = Color.White;
            this.lblColGrade.Location = new Point(500, 6);
            this.lblColGrade.Size = new Size(80, 20);
            this.lblColGrade.Text = "Grade";
            this.lblColGrade.TextAlign = ContentAlignment.MiddleCenter;

            // Row 1 - English
            this.panelRow1.BackColor = Color.FromArgb(250, 250, 250);
            this.panelRow1.Location = new Point(10, 70);
            this.panelRow1.Size = new Size(598, 35);
            this.panelRow1.Controls.Add(this.lblSubject1);
            this.panelRow1.Controls.Add(this.lblSubject1Term1);
            this.panelRow1.Controls.Add(this.lblSubject1Term2);
            this.panelRow1.Controls.Add(this.lblSubject1Final);
            this.panelRow1.Controls.Add(this.lblSubject1Total);
            this.panelRow1.Controls.Add(this.lblSubject1Grade);

            this.lblSubject1.Font = new Font("Segoe UI", 9F);
            this.lblSubject1.Location = new Point(10, 8);
            this.lblSubject1.Size = new Size(120, 20);
            this.lblSubject1.Text = "English";

            this.lblSubject1Term1.Font = new Font("Segoe UI", 9F);
            this.lblSubject1Term1.Location = new Point(140, 8);
            this.lblSubject1Term1.Size = new Size(80, 20);
            this.lblSubject1Term1.Text = "42/50";
            this.lblSubject1Term1.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSubject1Term2.Font = new Font("Segoe UI", 9F);
            this.lblSubject1Term2.Location = new Point(230, 8);
            this.lblSubject1Term2.Size = new Size(80, 20);
            this.lblSubject1Term2.Text = "45/50";
            this.lblSubject1Term2.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSubject1Final.Font = new Font("Segoe UI", 9F);
            this.lblSubject1Final.Location = new Point(320, 8);
            this.lblSubject1Final.Size = new Size(80, 20);
            this.lblSubject1Final.Text = "88/100";
            this.lblSubject1Final.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSubject1Total.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblSubject1Total.Location = new Point(410, 8);
            this.lblSubject1Total.Size = new Size(80, 20);
            this.lblSubject1Total.Text = "110/150";
            this.lblSubject1Total.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSubject1Grade.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblSubject1Grade.ForeColor = Color.FromArgb(39, 174, 96);
            this.lblSubject1Grade.Location = new Point(500, 8);
            this.lblSubject1Grade.Size = new Size(80, 20);
            this.lblSubject1Grade.Text = "A";
            this.lblSubject1Grade.TextAlign = ContentAlignment.MiddleCenter;

            // Row 2 - Mathematics
            this.panelRow2.BackColor = Color.White;
            this.panelRow2.Location = new Point(10, 105);
            this.panelRow2.Size = new Size(598, 35);
            this.panelRow2.Controls.Add(this.lblSubject2);
            this.panelRow2.Controls.Add(this.lblSubject2Term1);
            this.panelRow2.Controls.Add(this.lblSubject2Term2);
            this.panelRow2.Controls.Add(this.lblSubject2Final);
            this.panelRow2.Controls.Add(this.lblSubject2Total);
            this.panelRow2.Controls.Add(this.lblSubject2Grade);

            this.lblSubject2.Font = new Font("Segoe UI", 9F);
            this.lblSubject2.Location = new Point(10, 8);
            this.lblSubject2.Size = new Size(120, 20);
            this.lblSubject2.Text = "Mathematics";

            this.lblSubject2Term1.Font = new Font("Segoe UI", 9F);
            this.lblSubject2Term1.Location = new Point(140, 8);
            this.lblSubject2Term1.Size = new Size(80, 20);
            this.lblSubject2Term1.Text = "48/50";
            this.lblSubject2Term1.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSubject2Term2.Font = new Font("Segoe UI", 9F);
            this.lblSubject2Term2.Location = new Point(230, 8);
            this.lblSubject2Term2.Size = new Size(80, 20);
            this.lblSubject2Term2.Text = "46/50";
            this.lblSubject2Term2.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSubject2Final.Font = new Font("Segoe UI", 9F);
            this.lblSubject2Final.Location = new Point(320, 8);
            this.lblSubject2Final.Size = new Size(80, 20);
            this.lblSubject2Final.Text = "92/100";
            this.lblSubject2Final.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSubject2Total.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblSubject2Total.Location = new Point(410, 8);
            this.lblSubject2Total.Size = new Size(80, 20);
            this.lblSubject2Total.Text = "116/150";
            this.lblSubject2Total.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSubject2Grade.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblSubject2Grade.ForeColor = Color.FromArgb(39, 174, 96);
            this.lblSubject2Grade.Location = new Point(500, 8);
            this.lblSubject2Grade.Size = new Size(80, 20);
            this.lblSubject2Grade.Text = "A+";
            this.lblSubject2Grade.TextAlign = ContentAlignment.MiddleCenter;

            // Row 3 - Science
            this.panelRow3.BackColor = Color.FromArgb(250, 250, 250);
            this.panelRow3.Location = new Point(10, 140);
            this.panelRow3.Size = new Size(598, 35);
            this.panelRow3.Controls.Add(this.lblSubject3);
            this.panelRow3.Controls.Add(this.lblSubject3Term1);
            this.panelRow3.Controls.Add(this.lblSubject3Term2);
            this.panelRow3.Controls.Add(this.lblSubject3Final);
            this.panelRow3.Controls.Add(this.lblSubject3Total);
            this.panelRow3.Controls.Add(this.lblSubject3Grade);

            this.lblSubject3.Font = new Font("Segoe UI", 9F);
            this.lblSubject3.Location = new Point(10, 8);
            this.lblSubject3.Size = new Size(120, 20);
            this.lblSubject3.Text = "Science";

            this.lblSubject3Term1.Font = new Font("Segoe UI", 9F);
            this.lblSubject3Term1.Location = new Point(140, 8);
            this.lblSubject3Term1.Size = new Size(80, 20);
            this.lblSubject3Term1.Text = "40/50";
            this.lblSubject3Term1.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSubject3Term2.Font = new Font("Segoe UI", 9F);
            this.lblSubject3Term2.Location = new Point(230, 8);
            this.lblSubject3Term2.Size = new Size(80, 20);
            this.lblSubject3Term2.Text = "43/50";
            this.lblSubject3Term2.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSubject3Final.Font = new Font("Segoe UI", 9F);
            this.lblSubject3Final.Location = new Point(320, 8);
            this.lblSubject3Final.Size = new Size(80, 20);
            this.lblSubject3Final.Text = "85/100";
            this.lblSubject3Final.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSubject3Total.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblSubject3Total.Location = new Point(410, 8);
            this.lblSubject3Total.Size = new Size(80, 20);
            this.lblSubject3Total.Text = "106/150";
            this.lblSubject3Total.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSubject3Grade.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblSubject3Grade.ForeColor = Color.FromArgb(39, 174, 96);
            this.lblSubject3Grade.Location = new Point(500, 8);
            this.lblSubject3Grade.Size = new Size(80, 20);
            this.lblSubject3Grade.Text = "A";
            this.lblSubject3Grade.TextAlign = ContentAlignment.MiddleCenter;

            // Row 4 - Urdu
            this.panelRow4.BackColor = Color.White;
            this.panelRow4.Location = new Point(10, 175);
            this.panelRow4.Size = new Size(598, 35);
            this.panelRow4.Controls.Add(this.lblSubject4);
            this.panelRow4.Controls.Add(this.lblSubject4Term1);
            this.panelRow4.Controls.Add(this.lblSubject4Term2);
            this.panelRow4.Controls.Add(this.lblSubject4Final);
            this.panelRow4.Controls.Add(this.lblSubject4Total);
            this.panelRow4.Controls.Add(this.lblSubject4Grade);

            this.lblSubject4.Font = new Font("Segoe UI", 9F);
            this.lblSubject4.Location = new Point(10, 8);
            this.lblSubject4.Size = new Size(120, 20);
            this.lblSubject4.Text = "Urdu";

            this.lblSubject4Term1.Font = new Font("Segoe UI", 9F);
            this.lblSubject4Term1.Location = new Point(140, 8);
            this.lblSubject4Term1.Size = new Size(80, 20);
            this.lblSubject4Term1.Text = "38/50";
            this.lblSubject4Term1.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSubject4Term2.Font = new Font("Segoe UI", 9F);
            this.lblSubject4Term2.Location = new Point(230, 8);
            this.lblSubject4Term2.Size = new Size(80, 20);
            this.lblSubject4Term2.Text = "41/50";
            this.lblSubject4Term2.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSubject4Final.Font = new Font("Segoe UI", 9F);
            this.lblSubject4Final.Location = new Point(320, 8);
            this.lblSubject4Final.Size = new Size(80, 20);
            this.lblSubject4Final.Text = "80/100";
            this.lblSubject4Final.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSubject4Total.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblSubject4Total.Location = new Point(410, 8);
            this.lblSubject4Total.Size = new Size(80, 20);
            this.lblSubject4Total.Text = "100/150";
            this.lblSubject4Total.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSubject4Grade.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblSubject4Grade.ForeColor = Color.FromArgb(41, 128, 185);
            this.lblSubject4Grade.Location = new Point(500, 8);
            this.lblSubject4Grade.Size = new Size(80, 20);
            this.lblSubject4Grade.Text = "B+";
            this.lblSubject4Grade.TextAlign = ContentAlignment.MiddleCenter;

            // Row 5 - Islamiat
            this.panelRow5.BackColor = Color.FromArgb(250, 250, 250);
            this.panelRow5.Location = new Point(10, 210);
            this.panelRow5.Size = new Size(598, 35);
            this.panelRow5.Controls.Add(this.lblSubject5);
            this.panelRow5.Controls.Add(this.lblSubject5Term1);
            this.panelRow5.Controls.Add(this.lblSubject5Term2);
            this.panelRow5.Controls.Add(this.lblSubject5Final);
            this.panelRow5.Controls.Add(this.lblSubject5Total);
            this.panelRow5.Controls.Add(this.lblSubject5Grade);

            this.lblSubject5.Font = new Font("Segoe UI", 9F);
            this.lblSubject5.Location = new Point(10, 8);
            this.lblSubject5.Size = new Size(120, 20);
            this.lblSubject5.Text = "Islamiat";

            this.lblSubject5Term1.Font = new Font("Segoe UI", 9F);
            this.lblSubject5Term1.Location = new Point(140, 8);
            this.lblSubject5Term1.Size = new Size(80, 20);
            this.lblSubject5Term1.Text = "44/50";
            this.lblSubject5Term1.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSubject5Term2.Font = new Font("Segoe UI", 9F);
            this.lblSubject5Term2.Location = new Point(230, 8);
            this.lblSubject5Term2.Size = new Size(80, 20);
            this.lblSubject5Term2.Text = "47/50";
            this.lblSubject5Term2.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSubject5Final.Font = new Font("Segoe UI", 9F);
            this.lblSubject5Final.Location = new Point(320, 8);
            this.lblSubject5Final.Size = new Size(80, 20);
            this.lblSubject5Final.Text = "90/100";
            this.lblSubject5Final.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSubject5Total.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblSubject5Total.Location = new Point(410, 8);
            this.lblSubject5Total.Size = new Size(80, 20);
            this.lblSubject5Total.Text = "113/150";
            this.lblSubject5Total.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSubject5Grade.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblSubject5Grade.ForeColor = Color.FromArgb(39, 174, 96);
            this.lblSubject5Grade.Location = new Point(500, 8);
            this.lblSubject5Grade.Size = new Size(80, 20);
            this.lblSubject5Grade.Text = "A+";
            this.lblSubject5Grade.TextAlign = ContentAlignment.MiddleCenter;

            // Row 6 - Computer
            this.panelRow6.BackColor = Color.White;
            this.panelRow6.Location = new Point(10, 245);
            this.panelRow6.Size = new Size(598, 35);
            this.panelRow6.Controls.Add(this.lblSubject6);
            this.panelRow6.Controls.Add(this.lblSubject6Term1);
            this.panelRow6.Controls.Add(this.lblSubject6Term2);
            this.panelRow6.Controls.Add(this.lblSubject6Final);
            this.panelRow6.Controls.Add(this.lblSubject6Total);
            this.panelRow6.Controls.Add(this.lblSubject6Grade);

            this.lblSubject6.Font = new Font("Segoe UI", 9F);
            this.lblSubject6.Location = new Point(10, 8);
            this.lblSubject6.Size = new Size(120, 20);
            this.lblSubject6.Text = "Computer";

            this.lblSubject6Term1.Font = new Font("Segoe UI", 9F);
            this.lblSubject6Term1.Location = new Point(140, 8);
            this.lblSubject6Term1.Size = new Size(80, 20);
            this.lblSubject6Term1.Text = "46/50";
            this.lblSubject6Term1.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSubject6Term2.Font = new Font("Segoe UI", 9F);
            this.lblSubject6Term2.Location = new Point(230, 8);
            this.lblSubject6Term2.Size = new Size(80, 20);
            this.lblSubject6Term2.Text = "48/50";
            this.lblSubject6Term2.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSubject6Final.Font = new Font("Segoe UI", 9F);
            this.lblSubject6Final.Location = new Point(320, 8);
            this.lblSubject6Final.Size = new Size(80, 20);
            this.lblSubject6Final.Text = "95/100";
            this.lblSubject6Final.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSubject6Total.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblSubject6Total.Location = new Point(410, 8);
            this.lblSubject6Total.Size = new Size(80, 20);
            this.lblSubject6Total.Text = "119/150";
            this.lblSubject6Total.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSubject6Grade.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblSubject6Grade.ForeColor = Color.FromArgb(39, 174, 96);
            this.lblSubject6Grade.Location = new Point(500, 8);
            this.lblSubject6Grade.Size = new Size(80, 20);
            this.lblSubject6Grade.Text = "A+";
            this.lblSubject6Grade.TextAlign = ContentAlignment.MiddleCenter;

            // ========================================
            // panelSummary
            // ========================================
            this.panelSummary.BackColor = Color.White;
            this.panelSummary.Location = new Point(640, 110);
            this.panelSummary.Size = new Size(290, 295);
            this.panelSummary.BorderStyle = BorderStyle.FixedSingle;
            this.panelSummary.Controls.Add(this.lblSummaryTitle);
            this.panelSummary.Controls.Add(this.lblTotalMarksLabel);
            this.panelSummary.Controls.Add(this.lblTotalMarksValue);
            this.panelSummary.Controls.Add(this.lblPercentageLabel);
            this.panelSummary.Controls.Add(this.lblPercentageValue);
            this.panelSummary.Controls.Add(this.lblOverallGradeLabel);
            this.panelSummary.Controls.Add(this.lblOverallGradeValue);
            this.panelSummary.Controls.Add(this.lblAttendanceLabel);
            this.panelSummary.Controls.Add(this.lblAttendanceValue);
            this.panelSummary.Controls.Add(this.lblStatusLabel);
            this.panelSummary.Controls.Add(this.lblStatusValue);

            this.lblSummaryTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblSummaryTitle.ForeColor = Color.FromArgb(41, 128, 185);
            this.lblSummaryTitle.Location = new Point(10, 8);
            this.lblSummaryTitle.Size = new Size(200, 25);
            this.lblSummaryTitle.Text = "📈 Result Summary";

            this.lblTotalMarksLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblTotalMarksLabel.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblTotalMarksLabel.Location = new Point(15, 50);
            this.lblTotalMarksLabel.Size = new Size(130, 22);
            this.lblTotalMarksLabel.Text = "Total Marks:";

            this.lblTotalMarksValue.Font = new Font("Segoe UI", 10F);
            this.lblTotalMarksValue.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblTotalMarksValue.Location = new Point(150, 50);
            this.lblTotalMarksValue.Size = new Size(120, 22);
            this.lblTotalMarksValue.Text = "664 / 900";

            this.lblPercentageLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblPercentageLabel.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblPercentageLabel.Location = new Point(15, 85);
            this.lblPercentageLabel.Size = new Size(130, 22);
            this.lblPercentageLabel.Text = "Percentage:";

            this.lblPercentageValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblPercentageValue.ForeColor = Color.FromArgb(39, 174, 96);
            this.lblPercentageValue.Location = new Point(150, 82);
            this.lblPercentageValue.Size = new Size(120, 28);
            this.lblPercentageValue.Text = "73.78%";

            this.lblOverallGradeLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblOverallGradeLabel.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblOverallGradeLabel.Location = new Point(15, 125);
            this.lblOverallGradeLabel.Size = new Size(130, 22);
            this.lblOverallGradeLabel.Text = "Overall Grade:";

            this.lblOverallGradeValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblOverallGradeValue.ForeColor = Color.FromArgb(39, 174, 96);
            this.lblOverallGradeValue.Location = new Point(150, 118);
            this.lblOverallGradeValue.Size = new Size(120, 35);
            this.lblOverallGradeValue.Text = "A";

            this.lblAttendanceLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblAttendanceLabel.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblAttendanceLabel.Location = new Point(15, 170);
            this.lblAttendanceLabel.Size = new Size(130, 22);
            this.lblAttendanceLabel.Text = "Attendance:";

            this.lblAttendanceValue.Font = new Font("Segoe UI", 10F);
            this.lblAttendanceValue.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblAttendanceValue.Location = new Point(150, 170);
            this.lblAttendanceValue.Size = new Size(120, 22);
            this.lblAttendanceValue.Text = "92% (184/200)";

            this.lblStatusLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblStatusLabel.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblStatusLabel.Location = new Point(15, 210);
            this.lblStatusLabel.Size = new Size(130, 22);
            this.lblStatusLabel.Text = "Status:";

            this.lblStatusValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblStatusValue.ForeColor = Color.FromArgb(39, 174, 96);
            this.lblStatusValue.BackColor = Color.FromArgb(212, 239, 223);
            this.lblStatusValue.Location = new Point(15, 240);
            this.lblStatusValue.Size = new Size(260, 40);
            this.lblStatusValue.Text = "✓ PASSED";
            this.lblStatusValue.TextAlign = ContentAlignment.MiddleCenter;

            // ========================================
            // panelFooter
            // ========================================
            this.panelFooter.BackColor = Color.FromArgb(236, 240, 241);
            this.panelFooter.Location = new Point(0, 595);
            this.panelFooter.Size = new Size(1000, 55);
            this.panelFooter.Controls.Add(this.btnBackToDashboard);
            this.panelFooter.Controls.Add(this.btnGenerateCard);

            this.btnBackToDashboard.BackColor = Color.FromArgb(52, 73, 94);
            this.btnBackToDashboard.FlatStyle = FlatStyle.Flat;
            this.btnBackToDashboard.FlatAppearance.BorderSize = 0;
            this.btnBackToDashboard.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnBackToDashboard.ForeColor = Color.White;
            this.btnBackToDashboard.Location = new Point(30, 10);
            this.btnBackToDashboard.Size = new Size(180, 38);
            this.btnBackToDashboard.Text = "← Back to Dashboard";
            this.btnBackToDashboard.Cursor = Cursors.Hand;
            this.btnBackToDashboard.Click += new EventHandler(this.btnBackToDashboard_Click);

            this.btnGenerateCard.BackColor = Color.FromArgb(39, 174, 96);
            this.btnGenerateCard.FlatStyle = FlatStyle.Flat;
            this.btnGenerateCard.FlatAppearance.BorderSize = 0;
            this.btnGenerateCard.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnGenerateCard.ForeColor = Color.White;
            this.btnGenerateCard.Location = new Point(770, 10);
            this.btnGenerateCard.Size = new Size(200, 38);
            this.btnGenerateCard.Text = "🖨️ Generate Result Card";
            this.btnGenerateCard.Cursor = Cursors.Hand;
            this.btnGenerateCard.Click += new EventHandler(this.btnGenerateCard_Click);

            // ========================================
            // GenerateResultCardForm
            // ========================================
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new Size(1000, 650);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelResultCardContainer);
            this.Controls.Add(this.panelFooter);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GenerateResultCardForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Generate Result Card - School Management System";

            // Resume Layout
            this.panelHeader.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelResultCardContainer.ResumeLayout(false);
            this.panelStudentInfo.ResumeLayout(false);
            this.panelMarksTable.ResumeLayout(false);
            this.panelTableHeader.ResumeLayout(false);
            this.panelRow1.ResumeLayout(false);
            this.panelRow2.ResumeLayout(false);
            this.panelRow3.ResumeLayout(false);
            this.panelRow4.ResumeLayout(false);
            this.panelRow5.ResumeLayout(false);
            this.panelRow6.ResumeLayout(false);
            this.panelSummary.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // Header
        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;

        // Search Panel
        private Panel panelSearch;
        private Label lblSearchName;
        private TextBox txtSearchName;
        private Label lblSearchRoll;
        private TextBox txtSearchRoll;
        private Button btnSearch;

        // Result Card Container
        private Panel panelResultCardContainer;

        // Student Info
        private Panel panelStudentInfo;
        private Label lblStudentInfoTitle;
        private Label lblStudentNameLabel;
        private Label lblStudentNameValue;
        private Label lblFatherNameLabel;
        private Label lblFatherNameValue;
        private Label lblRollNoLabel;
        private Label lblRollNoValue;
        private Label lblClassLabel;
        private Label lblClassValue;
        private Label lblSessionLabel;
        private Label lblSessionValue;

        // Marks Table
        private Panel panelMarksTable;
        private Label lblMarksTableTitle;
        private Panel panelTableHeader;
        private Label lblColSubject;
        private Label lblColTerm1;
        private Label lblColTerm2;
        private Label lblColFinal;
        private Label lblColTotal;
        private Label lblColGrade;

        // Row 1
        private Panel panelRow1;
        private Label lblSubject1;
        private Label lblSubject1Term1;
        private Label lblSubject1Term2;
        private Label lblSubject1Final;
        private Label lblSubject1Total;
        private Label lblSubject1Grade;

        // Row 2
        private Panel panelRow2;
        private Label lblSubject2;
        private Label lblSubject2Term1;
        private Label lblSubject2Term2;
        private Label lblSubject2Final;
        private Label lblSubject2Total;
        private Label lblSubject2Grade;

        // Row 3
        private Panel panelRow3;
        private Label lblSubject3;
        private Label lblSubject3Term1;
        private Label lblSubject3Term2;
        private Label lblSubject3Final;
        private Label lblSubject3Total;
        private Label lblSubject3Grade;

        // Row 4
        private Panel panelRow4;
        private Label lblSubject4;
        private Label lblSubject4Term1;
        private Label lblSubject4Term2;
        private Label lblSubject4Final;
        private Label lblSubject4Total;
        private Label lblSubject4Grade;

        // Row 5
        private Panel panelRow5;
        private Label lblSubject5;
        private Label lblSubject5Term1;
        private Label lblSubject5Term2;
        private Label lblSubject5Final;
        private Label lblSubject5Total;
        private Label lblSubject5Grade;

        // Row 6
        private Panel panelRow6;
        private Label lblSubject6;
        private Label lblSubject6Term1;
        private Label lblSubject6Term2;
        private Label lblSubject6Final;
        private Label lblSubject6Total;
        private Label lblSubject6Grade;

        // Summary
        private Panel panelSummary;
        private Label lblSummaryTitle;
        private Label lblTotalMarksLabel;
        private Label lblTotalMarksValue;
        private Label lblPercentageLabel;
        private Label lblPercentageValue;
        private Label lblOverallGradeLabel;
        private Label lblOverallGradeValue;
        private Label lblAttendanceLabel;
        private Label lblAttendanceValue;
        private Label lblStatusLabel;
        private Label lblStatusValue;

        // Footer
        private Panel panelFooter;
        private Button btnBackToDashboard;
        private Button btnGenerateCard;
    }
}
