namespace SchoolManagementSystem
{
    partial class AddMarksForm
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

            // Dropdown Section Panel
            this.panelDropdowns = new Panel();
            
            // Class Dropdown
            this.lblSelectClass = new Label();
            this.cmbClass = new ComboBox();
            
            // Section Dropdown
            this.lblSelectSection = new Label();
            this.cmbSection = new ComboBox();
            
            // Subject Dropdown
            this.lblSelectSubject = new Label();
            this.cmbSubject = new ComboBox();
            
            // Exam Type Dropdown
            this.lblSelectExamType = new Label();
            this.cmbExamType = new ComboBox();

            // Load Students Button
            this.btnLoadStudents = new Button();

            // DataGridView for Marks Entry
            this.dgvMarks = new DataGridView();

            // Columns
            this.colRollNo = new DataGridViewTextBoxColumn();
            this.colStudentName = new DataGridViewTextBoxColumn();
            this.colTotalMarks = new DataGridViewTextBoxColumn();
            this.colObtainedMarks = new DataGridViewTextBoxColumn();
            this.colPercentage = new DataGridViewTextBoxColumn();
            this.colStatus = new DataGridViewTextBoxColumn();

            // Button Panel
            this.panelButtons = new Panel();
            this.btnSaveMarks = new Button();
            this.btnClearAll = new Button();
            this.btnGoBack = new Button();

            // Suspend layout
            this.panelHeader.SuspendLayout();
            this.panelDropdowns.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).BeginInit();
            this.SuspendLayout();

            // ========================================
            // panelHeader - Top Header
            // ========================================
            this.panelHeader.BackColor = Color.FromArgb(41, 128, 185);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Location = new Point(0, 0);
            this.panelHeader.Size = new Size(1000, 60);
            this.panelHeader.Controls.Add(this.lblFormTitle);
            this.panelHeader.Controls.Add(this.btnBack);

            // ========================================
            // lblFormTitle - Form Title
            // ========================================
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblFormTitle.ForeColor = Color.White;
            this.lblFormTitle.Location = new Point(20, 12);
            this.lblFormTitle.Size = new Size(250, 35);
            this.lblFormTitle.Text = "📝 Add Student Marks";

            // ========================================
            // btnBack - Back Button in Header
            // ========================================
            this.btnBack.BackColor = Color.FromArgb(52, 73, 94);
            this.btnBack.FlatStyle = FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.btnBack.ForeColor = Color.White;
            this.btnBack.Location = new Point(900, 15);
            this.btnBack.Size = new Size(80, 32);
            this.btnBack.Text = "← Back";
            this.btnBack.Cursor = Cursors.Hand;
            this.btnBack.Click += new EventHandler(this.btnBack_Click);

            // ========================================
            // panelDropdowns - Dropdown Section
            // ========================================
            this.panelDropdowns.BackColor = Color.White;
            this.panelDropdowns.Location = new Point(20, 80);
            this.panelDropdowns.Size = new Size(960, 100);
            this.panelDropdowns.Controls.Add(this.lblSelectClass);
            this.panelDropdowns.Controls.Add(this.cmbClass);
            this.panelDropdowns.Controls.Add(this.lblSelectSection);
            this.panelDropdowns.Controls.Add(this.cmbSection);
            this.panelDropdowns.Controls.Add(this.lblSelectSubject);
            this.panelDropdowns.Controls.Add(this.cmbSubject);
            this.panelDropdowns.Controls.Add(this.lblSelectExamType);
            this.panelDropdowns.Controls.Add(this.cmbExamType);
            this.panelDropdowns.Controls.Add(this.btnLoadStudents);

            // ========================================
            // lblSelectClass
            // ========================================
            this.lblSelectClass.AutoSize = true;
            this.lblSelectClass.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblSelectClass.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblSelectClass.Location = new Point(20, 15);
            this.lblSelectClass.Size = new Size(100, 20);
            this.lblSelectClass.Text = "Select Class:";

            // ========================================
            // cmbClass - Class Dropdown
            // ========================================
            this.cmbClass.Font = new Font("Segoe UI", 10F);
            this.cmbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbClass.Location = new Point(20, 40);
            this.cmbClass.Size = new Size(140, 30);
            this.cmbClass.Items.AddRange(new object[] { "Grade 1", "Grade 2", "Grade 3", "Grade 4", "Grade 5", "Grade 6", "Grade 7", "Grade 8", "Grade 9", "Grade 10" });
            this.cmbClass.SelectedIndex = 3; // Default: Grade 4

            // ========================================
            // lblSelectSection
            // ========================================
            this.lblSelectSection.AutoSize = true;
            this.lblSelectSection.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblSelectSection.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblSelectSection.Location = new Point(180, 15);
            this.lblSelectSection.Size = new Size(110, 20);
            this.lblSelectSection.Text = "Select Section:";

            // ========================================
            // cmbSection - Section Dropdown
            // ========================================
            this.cmbSection.Font = new Font("Segoe UI", 10F);
            this.cmbSection.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbSection.Location = new Point(180, 40);
            this.cmbSection.Size = new Size(120, 30);
            this.cmbSection.Items.AddRange(new object[] { "Section A", "Section B", "Section C", "Section D" });
            this.cmbSection.SelectedIndex = 0; // Default: Section A

            // ========================================
            // lblSelectSubject
            // ========================================
            this.lblSelectSubject.AutoSize = true;
            this.lblSelectSubject.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblSelectSubject.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblSelectSubject.Location = new Point(320, 15);
            this.lblSelectSubject.Size = new Size(110, 20);
            this.lblSelectSubject.Text = "Select Subject:";

            // ========================================
            // cmbSubject - Subject Dropdown
            // ========================================
            this.cmbSubject.Font = new Font("Segoe UI", 10F);
            this.cmbSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbSubject.Location = new Point(320, 40);
            this.cmbSubject.Size = new Size(150, 30);
            this.cmbSubject.Items.AddRange(new object[] { "Mathematics", "English", "Science", "Urdu", "Islamiat", "Social Studies", "Computer" });
            this.cmbSubject.SelectedIndex = 0; // Default: Mathematics

            // ========================================
            // lblSelectExamType
            // ========================================
            this.lblSelectExamType.AutoSize = true;
            this.lblSelectExamType.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblSelectExamType.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblSelectExamType.Location = new Point(490, 15);
            this.lblSelectExamType.Size = new Size(120, 20);
            this.lblSelectExamType.Text = "Select Exam Type:";

            // ========================================
            // cmbExamType - Exam Type Dropdown
            // ========================================
            this.cmbExamType.Font = new Font("Segoe UI", 10F);
            this.cmbExamType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbExamType.Location = new Point(490, 40);
            this.cmbExamType.Size = new Size(150, 30);
            this.cmbExamType.Items.AddRange(new object[] { "Monthly Test", "Midterm", "Final Term", "Assignment" });
            this.cmbExamType.SelectedIndex = 0; // Default: Monthly Test
            this.cmbExamType.SelectedIndexChanged += new EventHandler(this.cmbExamType_SelectedIndexChanged);

            // ========================================
            // btnLoadStudents - Load Students Button
            // ========================================
            this.btnLoadStudents.BackColor = Color.FromArgb(46, 204, 113);
            this.btnLoadStudents.FlatStyle = FlatStyle.Flat;
            this.btnLoadStudents.FlatAppearance.BorderSize = 0;
            this.btnLoadStudents.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnLoadStudents.ForeColor = Color.White;
            this.btnLoadStudents.Location = new Point(680, 35);
            this.btnLoadStudents.Size = new Size(150, 38);
            this.btnLoadStudents.Text = "🔍 Load Students";
            this.btnLoadStudents.Cursor = Cursors.Hand;
            this.btnLoadStudents.Click += new EventHandler(this.btnLoadStudents_Click);

            // ========================================
            // dgvMarks - Student Marks Entry Grid
            // ========================================
            this.dgvMarks.BackgroundColor = Color.White;
            this.dgvMarks.BorderStyle = BorderStyle.None;
            this.dgvMarks.Location = new Point(20, 200);
            this.dgvMarks.Size = new Size(960, 380);
            this.dgvMarks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarks.RowHeadersVisible = false;
            this.dgvMarks.AllowUserToAddRows = false;
            this.dgvMarks.AllowUserToDeleteRows = false;
            this.dgvMarks.SelectionMode = DataGridViewSelectionMode.CellSelect;
            this.dgvMarks.DefaultCellStyle.Font = new Font("Segoe UI", 11F);
            this.dgvMarks.DefaultCellStyle.Padding = new Padding(5);
            this.dgvMarks.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.dgvMarks.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            this.dgvMarks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvMarks.EnableHeadersVisualStyles = false;
            this.dgvMarks.RowTemplate.Height = 40;
            this.dgvMarks.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 250);
            this.dgvMarks.CellEndEdit += new DataGridViewCellEventHandler(this.dgvMarks_CellEndEdit);
            this.dgvMarks.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dgvMarks_EditingControlShowing);

            // ========================================
            // colRollNo - Roll Number Column
            // ========================================
            this.colRollNo.HeaderText = "Roll No";
            this.colRollNo.Name = "colRollNo";
            this.colRollNo.ReadOnly = true;
            this.colRollNo.FillWeight = 12;

            // ========================================
            // colStudentName - Student Name Column
            // ========================================
            this.colStudentName.HeaderText = "Student Name";
            this.colStudentName.Name = "colStudentName";
            this.colStudentName.ReadOnly = true;
            this.colStudentName.FillWeight = 30;

            // ========================================
            // colTotalMarks - Total Marks Column
            // ========================================
            this.colTotalMarks.HeaderText = "Total Marks";
            this.colTotalMarks.Name = "colTotalMarks";
            this.colTotalMarks.ReadOnly = true;
            this.colTotalMarks.FillWeight = 15;
            this.colTotalMarks.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // ========================================
            // colObtainedMarks - Obtained Marks Column
            // ========================================
            this.colObtainedMarks.HeaderText = "Obtained Marks";
            this.colObtainedMarks.Name = "colObtainedMarks";
            this.colObtainedMarks.FillWeight = 18;
            this.colObtainedMarks.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.colObtainedMarks.DefaultCellStyle.BackColor = Color.FromArgb(255, 250, 230);

            // ========================================
            // colPercentage - Percentage Column
            // ========================================
            this.colPercentage.HeaderText = "Percentage";
            this.colPercentage.Name = "colPercentage";
            this.colPercentage.ReadOnly = true;
            this.colPercentage.FillWeight = 13;
            this.colPercentage.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // ========================================
            // colStatus - Status Column
            // ========================================
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.FillWeight = 12;
            this.colStatus.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Add columns to DataGridView
            this.dgvMarks.Columns.AddRange(new DataGridViewColumn[] {
                this.colRollNo,
                this.colStudentName,
                this.colTotalMarks,
                this.colObtainedMarks,
                this.colPercentage,
                this.colStatus
            });

            // ========================================
            // panelButtons - Bottom Button Section
            // ========================================
            this.panelButtons.BackColor = Color.FromArgb(236, 240, 241);
            this.panelButtons.Location = new Point(0, 600);
            this.panelButtons.Size = new Size(1000, 70);
            this.panelButtons.Controls.Add(this.btnSaveMarks);
            this.panelButtons.Controls.Add(this.btnClearAll);
            this.panelButtons.Controls.Add(this.btnGoBack);

            // ========================================
            // btnSaveMarks - Save Marks Button
            // ========================================
            this.btnSaveMarks.BackColor = Color.FromArgb(41, 128, 185);
            this.btnSaveMarks.FlatStyle = FlatStyle.Flat;
            this.btnSaveMarks.FlatAppearance.BorderSize = 0;
            this.btnSaveMarks.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnSaveMarks.ForeColor = Color.White;
            this.btnSaveMarks.Location = new Point(300, 15);
            this.btnSaveMarks.Size = new Size(160, 45);
            this.btnSaveMarks.Text = "💾 Save Marks";
            this.btnSaveMarks.Cursor = Cursors.Hand;
            this.btnSaveMarks.Click += new EventHandler(this.btnSaveMarks_Click);

            // ========================================
            // btnClearAll - Clear All Button
            // ========================================
            this.btnClearAll.BackColor = Color.FromArgb(231, 76, 60);
            this.btnClearAll.FlatStyle = FlatStyle.Flat;
            this.btnClearAll.FlatAppearance.BorderSize = 0;
            this.btnClearAll.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnClearAll.ForeColor = Color.White;
            this.btnClearAll.Location = new Point(480, 15);
            this.btnClearAll.Size = new Size(140, 45);
            this.btnClearAll.Text = "🗑️ Clear All";
            this.btnClearAll.Cursor = Cursors.Hand;
            this.btnClearAll.Click += new EventHandler(this.btnClearAll_Click);

            // ========================================
            // btnGoBack - Go Back Button
            // ========================================
            this.btnGoBack.BackColor = Color.FromArgb(149, 165, 166);
            this.btnGoBack.FlatStyle = FlatStyle.Flat;
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnGoBack.ForeColor = Color.White;
            this.btnGoBack.Location = new Point(640, 15);
            this.btnGoBack.Size = new Size(140, 45);
            this.btnGoBack.Text = "← Go Back";
            this.btnGoBack.Cursor = Cursors.Hand;
            this.btnGoBack.Click += new EventHandler(this.btnGoBack_Click);

            // ========================================
            // AddMarksForm - Main Form
            // ========================================
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new Size(1000, 670);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelDropdowns);
            this.Controls.Add(this.dgvMarks);
            this.Controls.Add(this.panelButtons);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddMarksForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "School Management System - Add Student Marks";

            // Resume layout
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelDropdowns.ResumeLayout(false);
            this.panelDropdowns.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        // Control Declarations
        private Panel panelHeader;
        private Label lblFormTitle;
        private Button btnBack;
        
        private Panel panelDropdowns;
        private Label lblSelectClass;
        private ComboBox cmbClass;
        private Label lblSelectSection;
        private ComboBox cmbSection;
        private Label lblSelectSubject;
        private ComboBox cmbSubject;
        private Label lblSelectExamType;
        private ComboBox cmbExamType;
        private Button btnLoadStudents;
        
        private DataGridView dgvMarks;
        private DataGridViewTextBoxColumn colRollNo;
        private DataGridViewTextBoxColumn colStudentName;
        private DataGridViewTextBoxColumn colTotalMarks;
        private DataGridViewTextBoxColumn colObtainedMarks;
        private DataGridViewTextBoxColumn colPercentage;
        private DataGridViewTextBoxColumn colStatus;
        
        private Panel panelButtons;
        private Button btnSaveMarks;
        private Button btnClearAll;
        private Button btnGoBack;
    }
}
