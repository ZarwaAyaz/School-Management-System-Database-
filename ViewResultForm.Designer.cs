namespace SchoolManagementSystem
{
    partial class ViewResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // ========================================
            // Control Declarations
            // ========================================
            
            // Header Panel
            this.panelHeader = new Panel();
            this.lblFormTitle = new Label();
            this.btnBack = new Button();

            // Search Section Panel
            this.panelSearch = new Panel();
            this.lblSearchTitle = new Label();
            this.lblStudentName = new Label();
            this.txtStudentName = new TextBox();
            this.lblRollNumber = new Label();
            this.txtRollNumber = new TextBox();
            this.btnSearch = new Button();

            // Student Info Panel (appears after search)
            this.panelStudentInfo = new Panel();
            this.lblStudentInfoTitle = new Label();
            this.lblStudentNameDisplay = new Label();
            this.lblRollNoDisplay = new Label();
            this.lblClassDisplay = new Label();

            // Term Selection Panel
            this.panelTermSelection = new Panel();
            this.lblSelectTerm = new Label();
            this.btn1stTerm = new Button();
            this.btn2ndTerm = new Button();
            this.btn3rdTerm = new Button();

            // Results DataGridView
            this.dgvResults = new DataGridView();
            this.colSubject = new DataGridViewTextBoxColumn();
            this.colTotalMarks = new DataGridViewTextBoxColumn();
            this.colObtainedMarks = new DataGridViewTextBoxColumn();
            this.colGrade = new DataGridViewTextBoxColumn();

            // Summary Panel
            this.panelSummary = new Panel();
            this.lblSummaryTitle = new Label();
            this.lblOverallPercentage = new Label();
            this.lblOverallPercentageValue = new Label();
            this.lblClassPosition = new Label();
            this.lblClassPositionValue = new Label();
            this.lblAttendance = new Label();
            this.lblAttendanceValue = new Label();
            this.lblFinalStatus = new Label();
            this.lblFinalStatusValue = new Label();

            // No Data Label
            this.lblNoData = new Label();

            // Suspend layout
            this.panelHeader.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelStudentInfo.SuspendLayout();
            this.panelTermSelection.SuspendLayout();
            this.panelSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();

            // ========================================
            // panelHeader - Top Header
            // ========================================
            this.panelHeader.BackColor = Color.FromArgb(41, 128, 185);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Location = new Point(0, 0);
            this.panelHeader.Size = new Size(950, 60);
            this.panelHeader.Controls.Add(this.lblFormTitle);
            this.panelHeader.Controls.Add(this.btnBack);

            // ========================================
            // lblFormTitle - Form Title
            // ========================================
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblFormTitle.ForeColor = Color.White;
            this.lblFormTitle.Location = new Point(20, 12);
            this.lblFormTitle.Size = new Size(200, 35);
            this.lblFormTitle.Text = "📊 View Student Result";

            // ========================================
            // btnBack - Back Button
            // ========================================
            this.btnBack.BackColor = Color.FromArgb(52, 73, 94);
            this.btnBack.FlatStyle = FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.btnBack.ForeColor = Color.White;
            this.btnBack.Location = new Point(850, 15);
            this.btnBack.Size = new Size(80, 32);
            this.btnBack.Text = "← Back";
            this.btnBack.Cursor = Cursors.Hand;
            this.btnBack.Click += new EventHandler(this.btnBack_Click);

            // ========================================
            // panelSearch - Search Section
            // ========================================
            this.panelSearch.BackColor = Color.White;
            this.panelSearch.Location = new Point(20, 80);
            this.panelSearch.Size = new Size(910, 90);
            this.panelSearch.Controls.Add(this.lblSearchTitle);
            this.panelSearch.Controls.Add(this.lblStudentName);
            this.panelSearch.Controls.Add(this.txtStudentName);
            this.panelSearch.Controls.Add(this.lblRollNumber);
            this.panelSearch.Controls.Add(this.txtRollNumber);
            this.panelSearch.Controls.Add(this.btnSearch);

            // ========================================
            // lblSearchTitle
            // ========================================
            this.lblSearchTitle.AutoSize = true;
            this.lblSearchTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblSearchTitle.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblSearchTitle.Location = new Point(15, 12);
            this.lblSearchTitle.Size = new Size(150, 25);
            this.lblSearchTitle.Text = "🔍 Search Student";

            // ========================================
            // lblStudentName
            // ========================================
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.lblStudentName.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblStudentName.Location = new Point(20, 50);
            this.lblStudentName.Size = new Size(100, 20);
            this.lblStudentName.Text = "Student Name:";

            // ========================================
            // txtStudentName
            // ========================================
            this.txtStudentName.Font = new Font("Segoe UI", 11F);
            this.txtStudentName.Location = new Point(130, 47);
            this.txtStudentName.Size = new Size(250, 30);
            this.txtStudentName.PlaceholderText = "Enter student name";

            // ========================================
            // lblRollNumber
            // ========================================
            this.lblRollNumber.AutoSize = true;
            this.lblRollNumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.lblRollNumber.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblRollNumber.Location = new Point(420, 50);
            this.lblRollNumber.Size = new Size(90, 20);
            this.lblRollNumber.Text = "Roll Number:";

            // ========================================
            // txtRollNumber
            // ========================================
            this.txtRollNumber.Font = new Font("Segoe UI", 11F);
            this.txtRollNumber.Location = new Point(520, 47);
            this.txtRollNumber.Size = new Size(150, 30);
            this.txtRollNumber.PlaceholderText = "Enter roll no";

            // ========================================
            // btnSearch - Search Button
            // ========================================
            this.btnSearch.BackColor = Color.FromArgb(41, 128, 185);
            this.btnSearch.FlatStyle = FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnSearch.ForeColor = Color.White;
            this.btnSearch.Location = new Point(700, 43);
            this.btnSearch.Size = new Size(120, 38);
            this.btnSearch.Text = "🔍 Search";
            this.btnSearch.Cursor = Cursors.Hand;
            this.btnSearch.Click += new EventHandler(this.btnSearch_Click);

            // ========================================
            // panelStudentInfo - Student Info Display
            // ========================================
            this.panelStudentInfo.BackColor = Color.FromArgb(236, 240, 241);
            this.panelStudentInfo.Location = new Point(20, 185);
            this.panelStudentInfo.Size = new Size(910, 50);
            this.panelStudentInfo.Visible = false;
            this.panelStudentInfo.Controls.Add(this.lblStudentInfoTitle);
            this.panelStudentInfo.Controls.Add(this.lblStudentNameDisplay);
            this.panelStudentInfo.Controls.Add(this.lblRollNoDisplay);
            this.panelStudentInfo.Controls.Add(this.lblClassDisplay);

            // ========================================
            // lblStudentInfoTitle
            // ========================================
            this.lblStudentInfoTitle.AutoSize = true;
            this.lblStudentInfoTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblStudentInfoTitle.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblStudentInfoTitle.Location = new Point(15, 15);
            this.lblStudentInfoTitle.Size = new Size(80, 20);
            this.lblStudentInfoTitle.Text = "Student:";

            // ========================================
            // lblStudentNameDisplay
            // ========================================
            this.lblStudentNameDisplay.AutoSize = true;
            this.lblStudentNameDisplay.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblStudentNameDisplay.ForeColor = Color.FromArgb(41, 128, 185);
            this.lblStudentNameDisplay.Location = new Point(90, 15);
            this.lblStudentNameDisplay.Size = new Size(150, 20);
            this.lblStudentNameDisplay.Text = "Ali Ahmed";

            // ========================================
            // lblRollNoDisplay
            // ========================================
            this.lblRollNoDisplay.AutoSize = true;
            this.lblRollNoDisplay.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.lblRollNoDisplay.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblRollNoDisplay.Location = new Point(300, 15);
            this.lblRollNoDisplay.Size = new Size(100, 20);
            this.lblRollNoDisplay.Text = "Roll No: 01";

            // ========================================
            // lblClassDisplay
            // ========================================
            this.lblClassDisplay.AutoSize = true;
            this.lblClassDisplay.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.lblClassDisplay.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblClassDisplay.Location = new Point(450, 15);
            this.lblClassDisplay.Size = new Size(200, 20);
            this.lblClassDisplay.Text = "Class: Grade 4 – Section A";

            // ========================================
            // panelTermSelection - Term Selection
            // ========================================
            this.panelTermSelection.BackColor = Color.White;
            this.panelTermSelection.Location = new Point(20, 250);
            this.panelTermSelection.Size = new Size(910, 60);
            this.panelTermSelection.Visible = false;
            this.panelTermSelection.Controls.Add(this.lblSelectTerm);
            this.panelTermSelection.Controls.Add(this.btn1stTerm);
            this.panelTermSelection.Controls.Add(this.btn2ndTerm);
            this.panelTermSelection.Controls.Add(this.btn3rdTerm);

            // ========================================
            // lblSelectTerm
            // ========================================
            this.lblSelectTerm.AutoSize = true;
            this.lblSelectTerm.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblSelectTerm.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblSelectTerm.Location = new Point(15, 18);
            this.lblSelectTerm.Size = new Size(100, 25);
            this.lblSelectTerm.Text = "Select Term:";

            // ========================================
            // btn1stTerm
            // ========================================
            this.btn1stTerm.BackColor = Color.FromArgb(52, 73, 94);
            this.btn1stTerm.FlatStyle = FlatStyle.Flat;
            this.btn1stTerm.FlatAppearance.BorderSize = 0;
            this.btn1stTerm.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btn1stTerm.ForeColor = Color.White;
            this.btn1stTerm.Location = new Point(150, 12);
            this.btn1stTerm.Size = new Size(120, 38);
            this.btn1stTerm.Text = "1st Term";
            this.btn1stTerm.Cursor = Cursors.Hand;
            this.btn1stTerm.Click += new EventHandler(this.btn1stTerm_Click);

            // ========================================
            // btn2ndTerm
            // ========================================
            this.btn2ndTerm.BackColor = Color.FromArgb(52, 73, 94);
            this.btn2ndTerm.FlatStyle = FlatStyle.Flat;
            this.btn2ndTerm.FlatAppearance.BorderSize = 0;
            this.btn2ndTerm.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btn2ndTerm.ForeColor = Color.White;
            this.btn2ndTerm.Location = new Point(290, 12);
            this.btn2ndTerm.Size = new Size(120, 38);
            this.btn2ndTerm.Text = "2nd Term";
            this.btn2ndTerm.Cursor = Cursors.Hand;
            this.btn2ndTerm.Click += new EventHandler(this.btn2ndTerm_Click);

            // ========================================
            // btn3rdTerm
            // ========================================
            this.btn3rdTerm.BackColor = Color.FromArgb(52, 73, 94);
            this.btn3rdTerm.FlatStyle = FlatStyle.Flat;
            this.btn3rdTerm.FlatAppearance.BorderSize = 0;
            this.btn3rdTerm.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btn3rdTerm.ForeColor = Color.White;
            this.btn3rdTerm.Location = new Point(430, 12);
            this.btn3rdTerm.Size = new Size(120, 38);
            this.btn3rdTerm.Text = "3rd Term";
            this.btn3rdTerm.Cursor = Cursors.Hand;
            this.btn3rdTerm.Click += new EventHandler(this.btn3rdTerm_Click);

            // ========================================
            // dgvResults - Results Grid
            // ========================================
            this.dgvResults.BackgroundColor = Color.White;
            this.dgvResults.BorderStyle = BorderStyle.None;
            this.dgvResults.Location = new Point(20, 325);
            this.dgvResults.Size = new Size(600, 250);
            this.dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.ReadOnly = true;
            this.dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.DefaultCellStyle.Font = new Font("Segoe UI", 11F);
            this.dgvResults.DefaultCellStyle.Padding = new Padding(5);
            this.dgvResults.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.dgvResults.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            this.dgvResults.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvResults.EnableHeadersVisualStyles = false;
            this.dgvResults.RowTemplate.Height = 35;
            this.dgvResults.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 250);
            this.dgvResults.Visible = false;

            // ========================================
            // colSubject
            // ========================================
            this.colSubject.HeaderText = "Subject";
            this.colSubject.Name = "colSubject";
            this.colSubject.FillWeight = 35;

            // ========================================
            // colTotalMarks
            // ========================================
            this.colTotalMarks.HeaderText = "Total Marks";
            this.colTotalMarks.Name = "colTotalMarks";
            this.colTotalMarks.FillWeight = 22;
            this.colTotalMarks.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // ========================================
            // colObtainedMarks
            // ========================================
            this.colObtainedMarks.HeaderText = "Obtained";
            this.colObtainedMarks.Name = "colObtainedMarks";
            this.colObtainedMarks.FillWeight = 22;
            this.colObtainedMarks.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // ========================================
            // colGrade
            // ========================================
            this.colGrade.HeaderText = "Grade";
            this.colGrade.Name = "colGrade";
            this.colGrade.FillWeight = 21;
            this.colGrade.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Add columns to DataGridView
            this.dgvResults.Columns.AddRange(new DataGridViewColumn[] {
                this.colSubject,
                this.colTotalMarks,
                this.colObtainedMarks,
                this.colGrade
            });

            // ========================================
            // lblNoData - No Data Label
            // ========================================
            this.lblNoData.BackColor = Color.White;
            this.lblNoData.Font = new Font("Segoe UI", 14F, FontStyle.Italic);
            this.lblNoData.ForeColor = Color.FromArgb(149, 165, 166);
            this.lblNoData.Location = new Point(20, 325);
            this.lblNoData.Size = new Size(600, 250);
            this.lblNoData.Text = "No Data Available\n\nStudent has not given exams yet.";
            this.lblNoData.TextAlign = ContentAlignment.MiddleCenter;
            this.lblNoData.Visible = false;

            // ========================================
            // panelSummary - Summary Section
            // ========================================
            this.panelSummary.BackColor = Color.White;
            this.panelSummary.Location = new Point(640, 325);
            this.panelSummary.Size = new Size(290, 250);
            this.panelSummary.Visible = false;
            this.panelSummary.Controls.Add(this.lblSummaryTitle);
            this.panelSummary.Controls.Add(this.lblOverallPercentage);
            this.panelSummary.Controls.Add(this.lblOverallPercentageValue);
            this.panelSummary.Controls.Add(this.lblClassPosition);
            this.panelSummary.Controls.Add(this.lblClassPositionValue);
            this.panelSummary.Controls.Add(this.lblAttendance);
            this.panelSummary.Controls.Add(this.lblAttendanceValue);
            this.panelSummary.Controls.Add(this.lblFinalStatus);
            this.panelSummary.Controls.Add(this.lblFinalStatusValue);

            // ========================================
            // lblSummaryTitle
            // ========================================
            this.lblSummaryTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            this.lblSummaryTitle.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblSummaryTitle.Location = new Point(15, 15);
            this.lblSummaryTitle.Size = new Size(260, 30);
            this.lblSummaryTitle.Text = "📋 Result Summary";

            // ========================================
            // lblOverallPercentage
            // ========================================
            this.lblOverallPercentage.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.lblOverallPercentage.ForeColor = Color.FromArgb(127, 140, 141);
            this.lblOverallPercentage.Location = new Point(15, 60);
            this.lblOverallPercentage.Size = new Size(130, 25);
            this.lblOverallPercentage.Text = "Overall Percentage:";

            // ========================================
            // lblOverallPercentageValue
            // ========================================
            this.lblOverallPercentageValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblOverallPercentageValue.ForeColor = Color.FromArgb(41, 128, 185);
            this.lblOverallPercentageValue.Location = new Point(150, 55);
            this.lblOverallPercentageValue.Size = new Size(120, 30);
            this.lblOverallPercentageValue.Text = "85.5%";

            // ========================================
            // lblClassPosition
            // ========================================
            this.lblClassPosition.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.lblClassPosition.ForeColor = Color.FromArgb(127, 140, 141);
            this.lblClassPosition.Location = new Point(15, 100);
            this.lblClassPosition.Size = new Size(130, 25);
            this.lblClassPosition.Text = "Class Position:";

            // ========================================
            // lblClassPositionValue
            // ========================================
            this.lblClassPositionValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblClassPositionValue.ForeColor = Color.FromArgb(39, 174, 96);
            this.lblClassPositionValue.Location = new Point(150, 95);
            this.lblClassPositionValue.Size = new Size(120, 30);
            this.lblClassPositionValue.Text = "1st";

            // ========================================
            // lblAttendance
            // ========================================
            this.lblAttendance.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.lblAttendance.ForeColor = Color.FromArgb(127, 140, 141);
            this.lblAttendance.Location = new Point(15, 140);
            this.lblAttendance.Size = new Size(130, 25);
            this.lblAttendance.Text = "Attendance:";

            // ========================================
            // lblAttendanceValue
            // ========================================
            this.lblAttendanceValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblAttendanceValue.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblAttendanceValue.Location = new Point(150, 135);
            this.lblAttendanceValue.Size = new Size(120, 30);
            this.lblAttendanceValue.Text = "92%";

            // ========================================
            // lblFinalStatus
            // ========================================
            this.lblFinalStatus.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.lblFinalStatus.ForeColor = Color.FromArgb(127, 140, 141);
            this.lblFinalStatus.Location = new Point(15, 180);
            this.lblFinalStatus.Size = new Size(130, 25);
            this.lblFinalStatus.Text = "Final Status:";

            // ========================================
            // lblFinalStatusValue
            // ========================================
            this.lblFinalStatusValue.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblFinalStatusValue.ForeColor = Color.FromArgb(39, 174, 96);
            this.lblFinalStatusValue.Location = new Point(150, 175);
            this.lblFinalStatusValue.Size = new Size(120, 35);
            this.lblFinalStatusValue.Text = "PASS";

            // ========================================
            // ViewResultForm - Main Form
            // ========================================
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new Size(950, 600);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelStudentInfo);
            this.Controls.Add(this.panelTermSelection);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.panelSummary);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ViewResultForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "School Management System - View Result";

            // Resume layout
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelStudentInfo.ResumeLayout(false);
            this.panelStudentInfo.PerformLayout();
            this.panelTermSelection.ResumeLayout(false);
            this.panelTermSelection.PerformLayout();
            this.panelSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        // Control Declarations
        private Panel panelHeader;
        private Label lblFormTitle;
        private Button btnBack;

        private Panel panelSearch;
        private Label lblSearchTitle;
        private Label lblStudentName;
        private TextBox txtStudentName;
        private Label lblRollNumber;
        private TextBox txtRollNumber;
        private Button btnSearch;

        private Panel panelStudentInfo;
        private Label lblStudentInfoTitle;
        private Label lblStudentNameDisplay;
        private Label lblRollNoDisplay;
        private Label lblClassDisplay;

        private Panel panelTermSelection;
        private Label lblSelectTerm;
        private Button btn1stTerm;
        private Button btn2ndTerm;
        private Button btn3rdTerm;

        private DataGridView dgvResults;
        private DataGridViewTextBoxColumn colSubject;
        private DataGridViewTextBoxColumn colTotalMarks;
        private DataGridViewTextBoxColumn colObtainedMarks;
        private DataGridViewTextBoxColumn colGrade;

        private Label lblNoData;

        private Panel panelSummary;
        private Label lblSummaryTitle;
        private Label lblOverallPercentage;
        private Label lblOverallPercentageValue;
        private Label lblClassPosition;
        private Label lblClassPositionValue;
        private Label lblAttendance;
        private Label lblAttendanceValue;
        private Label lblFinalStatus;
        private Label lblFinalStatusValue;
    }
}
