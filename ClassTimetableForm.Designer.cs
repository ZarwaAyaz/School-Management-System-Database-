namespace SchoolManagementSystem
{
    partial class ClassTimetableForm
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
            // Header Controls
            this.panelHeader = new Panel();
            this.lblTitle = new Label();
            this.lblSubtitle = new Label();
            this.lblSchoolIcon = new Label();

            // Main Content
            this.panelMain = new Panel();
            this.panelTimetable = new Panel();
            
            // Table Header Row
            this.panelTableHeader = new Panel();
            this.lblHeaderPeriod = new Label();
            this.lblHeaderTime = new Label();
            this.lblHeaderSubject = new Label();

            // Period Rows
            this.panelPeriod1 = new Panel();
            this.lblPeriod1 = new Label();
            this.lblTime1 = new Label();
            this.lblSubject1 = new Label();

            this.panelPeriod2 = new Panel();
            this.lblPeriod2 = new Label();
            this.lblTime2 = new Label();
            this.lblSubject2 = new Label();

            this.panelPeriod3 = new Panel();
            this.lblPeriod3 = new Label();
            this.lblTime3 = new Label();
            this.lblSubject3 = new Label();

            this.panelBreak = new Panel();
            this.lblBreak = new Label();
            this.lblBreakTime = new Label();
            this.lblBreakNote = new Label();

            this.panelPeriod4 = new Panel();
            this.lblPeriod4 = new Label();
            this.lblTime4 = new Label();
            this.lblSubject4 = new Label();

            this.panelPeriod5 = new Panel();
            this.lblPeriod5 = new Label();
            this.lblTime5 = new Label();
            this.lblSubject5 = new Label();

            this.panelPeriod6 = new Panel();
            this.lblPeriod6 = new Label();
            this.lblTime6 = new Label();
            this.lblSubject6 = new Label();

            // Footer
            this.panelFooter = new Panel();
            this.btnBackToDashboard = new Button();
            this.lblFooterNote = new Label();

            // Suspend Layout
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelTimetable.SuspendLayout();
            this.panelTableHeader.SuspendLayout();
            this.panelPeriod1.SuspendLayout();
            this.panelPeriod2.SuspendLayout();
            this.panelPeriod3.SuspendLayout();
            this.panelBreak.SuspendLayout();
            this.panelPeriod4.SuspendLayout();
            this.panelPeriod5.SuspendLayout();
            this.panelPeriod6.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();

            // ========================================
            // panelHeader
            // ========================================
            this.panelHeader.BackColor = Color.FromArgb(41, 128, 185);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Location = new Point(0, 0);
            this.panelHeader.Size = new Size(900, 100);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Controls.Add(this.lblSchoolIcon);

            // ========================================
            // lblTitle
            // ========================================
            this.lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Location = new Point(0, 20);
            this.lblTitle.Size = new Size(900, 45);
            this.lblTitle.Text = "Class Timetable - Grade 4 - Section A";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // ========================================
            // lblSubtitle
            // ========================================
            this.lblSubtitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            this.lblSubtitle.ForeColor = Color.FromArgb(214, 234, 248);
            this.lblSubtitle.Location = new Point(0, 65);
            this.lblSubtitle.Size = new Size(900, 25);
            this.lblSubtitle.Text = "Monday - Friday";
            this.lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;

            // ========================================
            // lblSchoolIcon
            // ========================================
            this.lblSchoolIcon.Font = new Font("Segoe UI", 28F);
            this.lblSchoolIcon.ForeColor = Color.White;
            this.lblSchoolIcon.Location = new Point(820, 25);
            this.lblSchoolIcon.Size = new Size(60, 50);
            this.lblSchoolIcon.Text = "🏫";

            // ========================================
            // panelMain
            // ========================================
            this.panelMain.BackColor = Color.FromArgb(236, 240, 241);
            this.panelMain.Location = new Point(0, 100);
            this.panelMain.Size = new Size(900, 440);
            this.panelMain.Controls.Add(this.panelTimetable);

            // ========================================
            // panelTimetable
            // ========================================
            this.panelTimetable.BackColor = Color.White;
            this.panelTimetable.Location = new Point(100, 30);
            this.panelTimetable.Size = new Size(700, 380);
            this.panelTimetable.BorderStyle = BorderStyle.FixedSingle;
            this.panelTimetable.Controls.Add(this.panelTableHeader);
            this.panelTimetable.Controls.Add(this.panelPeriod1);
            this.panelTimetable.Controls.Add(this.panelPeriod2);
            this.panelTimetable.Controls.Add(this.panelPeriod3);
            this.panelTimetable.Controls.Add(this.panelBreak);
            this.panelTimetable.Controls.Add(this.panelPeriod4);
            this.panelTimetable.Controls.Add(this.panelPeriod5);
            this.panelTimetable.Controls.Add(this.panelPeriod6);

            // ========================================
            // panelTableHeader - Column Headers
            // ========================================
            this.panelTableHeader.BackColor = Color.FromArgb(52, 73, 94);
            this.panelTableHeader.Location = new Point(0, 0);
            this.panelTableHeader.Size = new Size(698, 45);
            this.panelTableHeader.Controls.Add(this.lblHeaderPeriod);
            this.panelTableHeader.Controls.Add(this.lblHeaderTime);
            this.panelTableHeader.Controls.Add(this.lblHeaderSubject);

            // lblHeaderPeriod
            this.lblHeaderPeriod.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblHeaderPeriod.ForeColor = Color.White;
            this.lblHeaderPeriod.Location = new Point(20, 10);
            this.lblHeaderPeriod.Size = new Size(180, 25);
            this.lblHeaderPeriod.Text = "Period";

            // lblHeaderTime
            this.lblHeaderTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblHeaderTime.ForeColor = Color.White;
            this.lblHeaderTime.Location = new Point(220, 10);
            this.lblHeaderTime.Size = new Size(200, 25);
            this.lblHeaderTime.Text = "Time";

            // lblHeaderSubject
            this.lblHeaderSubject.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblHeaderSubject.ForeColor = Color.White;
            this.lblHeaderSubject.Location = new Point(450, 10);
            this.lblHeaderSubject.Size = new Size(220, 25);
            this.lblHeaderSubject.Text = "Subject";

            // ========================================
            // panelPeriod1 - Period 1
            // ========================================
            this.panelPeriod1.BackColor = Color.FromArgb(250, 250, 250);
            this.panelPeriod1.Location = new Point(0, 45);
            this.panelPeriod1.Size = new Size(698, 42);
            this.panelPeriod1.Controls.Add(this.lblPeriod1);
            this.panelPeriod1.Controls.Add(this.lblTime1);
            this.panelPeriod1.Controls.Add(this.lblSubject1);

            this.lblPeriod1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblPeriod1.ForeColor = Color.FromArgb(41, 128, 185);
            this.lblPeriod1.Location = new Point(20, 10);
            this.lblPeriod1.Size = new Size(180, 22);
            this.lblPeriod1.Text = "Period 1";

            this.lblTime1.Font = new Font("Segoe UI", 11F);
            this.lblTime1.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblTime1.Location = new Point(220, 10);
            this.lblTime1.Size = new Size(200, 22);
            this.lblTime1.Text = "8:00 AM - 8:45 AM";

            this.lblSubject1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblSubject1.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblSubject1.Location = new Point(450, 10);
            this.lblSubject1.Size = new Size(220, 22);
            this.lblSubject1.Text = "Mathematics";

            // ========================================
            // panelPeriod2 - Period 2
            // ========================================
            this.panelPeriod2.BackColor = Color.White;
            this.panelPeriod2.Location = new Point(0, 87);
            this.panelPeriod2.Size = new Size(698, 42);
            this.panelPeriod2.Controls.Add(this.lblPeriod2);
            this.panelPeriod2.Controls.Add(this.lblTime2);
            this.panelPeriod2.Controls.Add(this.lblSubject2);

            this.lblPeriod2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblPeriod2.ForeColor = Color.FromArgb(41, 128, 185);
            this.lblPeriod2.Location = new Point(20, 10);
            this.lblPeriod2.Size = new Size(180, 22);
            this.lblPeriod2.Text = "Period 2";

            this.lblTime2.Font = new Font("Segoe UI", 11F);
            this.lblTime2.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblTime2.Location = new Point(220, 10);
            this.lblTime2.Size = new Size(200, 22);
            this.lblTime2.Text = "8:45 AM - 9:30 AM";

            this.lblSubject2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblSubject2.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblSubject2.Location = new Point(450, 10);
            this.lblSubject2.Size = new Size(220, 22);
            this.lblSubject2.Text = "English";

            // ========================================
            // panelPeriod3 - Period 3
            // ========================================
            this.panelPeriod3.BackColor = Color.FromArgb(250, 250, 250);
            this.panelPeriod3.Location = new Point(0, 129);
            this.panelPeriod3.Size = new Size(698, 42);
            this.panelPeriod3.Controls.Add(this.lblPeriod3);
            this.panelPeriod3.Controls.Add(this.lblTime3);
            this.panelPeriod3.Controls.Add(this.lblSubject3);

            this.lblPeriod3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblPeriod3.ForeColor = Color.FromArgb(41, 128, 185);
            this.lblPeriod3.Location = new Point(20, 10);
            this.lblPeriod3.Size = new Size(180, 22);
            this.lblPeriod3.Text = "Period 3";

            this.lblTime3.Font = new Font("Segoe UI", 11F);
            this.lblTime3.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblTime3.Location = new Point(220, 10);
            this.lblTime3.Size = new Size(200, 22);
            this.lblTime3.Text = "9:30 AM - 10:15 AM";

            this.lblSubject3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblSubject3.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblSubject3.Location = new Point(450, 10);
            this.lblSubject3.Size = new Size(220, 22);
            this.lblSubject3.Text = "Science";

            // ========================================
            // panelBreak - Break Time
            // ========================================
            this.panelBreak.BackColor = Color.FromArgb(46, 204, 113);
            this.panelBreak.Location = new Point(0, 171);
            this.panelBreak.Size = new Size(698, 42);
            this.panelBreak.Controls.Add(this.lblBreak);
            this.panelBreak.Controls.Add(this.lblBreakTime);
            this.panelBreak.Controls.Add(this.lblBreakNote);

            this.lblBreak.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblBreak.ForeColor = Color.White;
            this.lblBreak.Location = new Point(20, 10);
            this.lblBreak.Size = new Size(180, 22);
            this.lblBreak.Text = "☕ Break";

            this.lblBreakTime.Font = new Font("Segoe UI", 11F);
            this.lblBreakTime.ForeColor = Color.White;
            this.lblBreakTime.Location = new Point(220, 10);
            this.lblBreakTime.Size = new Size(200, 22);
            this.lblBreakTime.Text = "10:15 AM - 10:45 AM";

            this.lblBreakNote.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            this.lblBreakNote.ForeColor = Color.White;
            this.lblBreakNote.Location = new Point(450, 10);
            this.lblBreakNote.Size = new Size(220, 22);
            this.lblBreakNote.Text = "30 Minutes";

            // ========================================
            // panelPeriod4 - Period 4
            // ========================================
            this.panelPeriod4.BackColor = Color.White;
            this.panelPeriod4.Location = new Point(0, 213);
            this.panelPeriod4.Size = new Size(698, 42);
            this.panelPeriod4.Controls.Add(this.lblPeriod4);
            this.panelPeriod4.Controls.Add(this.lblTime4);
            this.panelPeriod4.Controls.Add(this.lblSubject4);

            this.lblPeriod4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblPeriod4.ForeColor = Color.FromArgb(41, 128, 185);
            this.lblPeriod4.Location = new Point(20, 10);
            this.lblPeriod4.Size = new Size(180, 22);
            this.lblPeriod4.Text = "Period 4";

            this.lblTime4.Font = new Font("Segoe UI", 11F);
            this.lblTime4.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblTime4.Location = new Point(220, 10);
            this.lblTime4.Size = new Size(200, 22);
            this.lblTime4.Text = "10:45 AM - 11:30 AM";

            this.lblSubject4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblSubject4.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblSubject4.Location = new Point(450, 10);
            this.lblSubject4.Size = new Size(220, 22);
            this.lblSubject4.Text = "Urdu";

            // ========================================
            // panelPeriod5 - Period 5
            // ========================================
            this.panelPeriod5.BackColor = Color.FromArgb(250, 250, 250);
            this.panelPeriod5.Location = new Point(0, 255);
            this.panelPeriod5.Size = new Size(698, 42);
            this.panelPeriod5.Controls.Add(this.lblPeriod5);
            this.panelPeriod5.Controls.Add(this.lblTime5);
            this.panelPeriod5.Controls.Add(this.lblSubject5);

            this.lblPeriod5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblPeriod5.ForeColor = Color.FromArgb(41, 128, 185);
            this.lblPeriod5.Location = new Point(20, 10);
            this.lblPeriod5.Size = new Size(180, 22);
            this.lblPeriod5.Text = "Period 5";

            this.lblTime5.Font = new Font("Segoe UI", 11F);
            this.lblTime5.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblTime5.Location = new Point(220, 10);
            this.lblTime5.Size = new Size(200, 22);
            this.lblTime5.Text = "11:30 AM - 12:15 PM";

            this.lblSubject5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblSubject5.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblSubject5.Location = new Point(450, 10);
            this.lblSubject5.Size = new Size(220, 22);
            this.lblSubject5.Text = "Islamiat";

            // ========================================
            // panelPeriod6 - Period 6
            // ========================================
            this.panelPeriod6.BackColor = Color.White;
            this.panelPeriod6.Location = new Point(0, 297);
            this.panelPeriod6.Size = new Size(698, 42);
            this.panelPeriod6.Controls.Add(this.lblPeriod6);
            this.panelPeriod6.Controls.Add(this.lblTime6);
            this.panelPeriod6.Controls.Add(this.lblSubject6);

            this.lblPeriod6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblPeriod6.ForeColor = Color.FromArgb(41, 128, 185);
            this.lblPeriod6.Location = new Point(20, 10);
            this.lblPeriod6.Size = new Size(180, 22);
            this.lblPeriod6.Text = "Period 6";

            this.lblTime6.Font = new Font("Segoe UI", 11F);
            this.lblTime6.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblTime6.Location = new Point(220, 10);
            this.lblTime6.Size = new Size(200, 22);
            this.lblTime6.Text = "12:15 PM - 1:00 PM";

            this.lblSubject6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblSubject6.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblSubject6.Location = new Point(450, 10);
            this.lblSubject6.Size = new Size(220, 22);
            this.lblSubject6.Text = "Computer";

            // ========================================
            // panelFooter
            // ========================================
            this.panelFooter.BackColor = Color.FromArgb(236, 240, 241);
            this.panelFooter.Location = new Point(0, 540);
            this.panelFooter.Size = new Size(900, 60);
            this.panelFooter.Controls.Add(this.btnBackToDashboard);
            this.panelFooter.Controls.Add(this.lblFooterNote);

            // btnBackToDashboard
            this.btnBackToDashboard.BackColor = Color.FromArgb(52, 73, 94);
            this.btnBackToDashboard.FlatStyle = FlatStyle.Flat;
            this.btnBackToDashboard.FlatAppearance.BorderSize = 0;
            this.btnBackToDashboard.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnBackToDashboard.ForeColor = Color.White;
            this.btnBackToDashboard.Location = new Point(30, 12);
            this.btnBackToDashboard.Size = new Size(180, 40);
            this.btnBackToDashboard.Text = "← Back to Dashboard";
            this.btnBackToDashboard.Cursor = Cursors.Hand;
            this.btnBackToDashboard.Click += new EventHandler(this.btnBackToDashboard_Click);

            // lblFooterNote
            this.lblFooterNote.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            this.lblFooterNote.ForeColor = Color.FromArgb(127, 140, 141);
            this.lblFooterNote.Location = new Point(550, 20);
            this.lblFooterNote.Size = new Size(320, 20);
            this.lblFooterNote.Text = "School timings: 8:00 AM - 1:00 PM";
            this.lblFooterNote.TextAlign = ContentAlignment.MiddleRight;

            // ========================================
            // ClassTimetableForm
            // ========================================
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new Size(900, 600);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelFooter);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ClassTimetableForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Class Timetable - School Management System";

            // Resume Layout
            this.panelHeader.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelTimetable.ResumeLayout(false);
            this.panelTableHeader.ResumeLayout(false);
            this.panelPeriod1.ResumeLayout(false);
            this.panelPeriod2.ResumeLayout(false);
            this.panelPeriod3.ResumeLayout(false);
            this.panelBreak.ResumeLayout(false);
            this.panelPeriod4.ResumeLayout(false);
            this.panelPeriod5.ResumeLayout(false);
            this.panelPeriod6.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // Header
        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblSchoolIcon;

        // Main Content
        private Panel panelMain;
        private Panel panelTimetable;

        // Table Header
        private Panel panelTableHeader;
        private Label lblHeaderPeriod;
        private Label lblHeaderTime;
        private Label lblHeaderSubject;

        // Period 1
        private Panel panelPeriod1;
        private Label lblPeriod1;
        private Label lblTime1;
        private Label lblSubject1;

        // Period 2
        private Panel panelPeriod2;
        private Label lblPeriod2;
        private Label lblTime2;
        private Label lblSubject2;

        // Period 3
        private Panel panelPeriod3;
        private Label lblPeriod3;
        private Label lblTime3;
        private Label lblSubject3;

        // Break
        private Panel panelBreak;
        private Label lblBreak;
        private Label lblBreakTime;
        private Label lblBreakNote;

        // Period 4
        private Panel panelPeriod4;
        private Label lblPeriod4;
        private Label lblTime4;
        private Label lblSubject4;

        // Period 5
        private Panel panelPeriod5;
        private Label lblPeriod5;
        private Label lblTime5;
        private Label lblSubject5;

        // Period 6
        private Panel panelPeriod6;
        private Label lblPeriod6;
        private Label lblTime6;
        private Label lblSubject6;

        // Footer
        private Panel panelFooter;
        private Button btnBackToDashboard;
        private Label lblFooterNote;
    }
}
