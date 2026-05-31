namespace SchoolManagementSystem
{
    partial class AttendanceForm
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

            // Date Picker Section
            this.panelDateSection = new Panel();
            this.lblSelectDate = new Label();
            this.dtpAttendanceDate = new DateTimePicker();

            // DataGridView for Students
            this.dgvAttendance = new DataGridView();

            // Columns
            this.colRollNo = new DataGridViewTextBoxColumn();
            this.colStudentName = new DataGridViewTextBoxColumn();
            this.colPresent = new DataGridViewCheckBoxColumn();
            this.colAbsent = new DataGridViewCheckBoxColumn();
            this.colLeave = new DataGridViewCheckBoxColumn();

            // Save Button
            this.btnSaveAttendance = new Button();

            // Back Button
            this.btnBack = new Button();

            // Suspend layout
            this.panelHeader.SuspendLayout();
            this.panelDateSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();

            // ========================================
            // panelHeader - Top Header
            // ========================================
            this.panelHeader.BackColor = Color.FromArgb(41, 128, 185);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Location = new Point(0, 0);
            this.panelHeader.Size = new Size(900, 60);
            this.panelHeader.Controls.Add(this.lblFormTitle);
            this.panelHeader.Controls.Add(this.btnBack);

            // ========================================
            // lblFormTitle - Form Title
            // ========================================
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblFormTitle.ForeColor = Color.White;
            this.lblFormTitle.Location = new Point(20, 12);
            this.lblFormTitle.Size = new Size(400, 35);
            this.lblFormTitle.Text = "Attendance – Grade 4 – Section A";

            // ========================================
            // btnBack - Back Button
            // ========================================
            this.btnBack.BackColor = Color.FromArgb(52, 73, 94);
            this.btnBack.FlatStyle = FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.btnBack.ForeColor = Color.White;
            this.btnBack.Location = new Point(800, 15);
            this.btnBack.Size = new Size(80, 32);
            this.btnBack.Text = "← Back";
            this.btnBack.Cursor = Cursors.Hand;
            this.btnBack.Click += new EventHandler(this.btnBack_Click);

            // ========================================
            // panelDateSection - Date Picker Section
            // ========================================
            this.panelDateSection.BackColor = Color.White;
            this.panelDateSection.Location = new Point(20, 80);
            this.panelDateSection.Size = new Size(860, 60);
            this.panelDateSection.Controls.Add(this.lblSelectDate);
            this.panelDateSection.Controls.Add(this.dtpAttendanceDate);

            // ========================================
            // lblSelectDate - Date Label
            // ========================================
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblSelectDate.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblSelectDate.Location = new Point(20, 18);
            this.lblSelectDate.Size = new Size(100, 25);
            this.lblSelectDate.Text = "Select Date:";

            // ========================================
            // dtpAttendanceDate - Date Picker
            // ========================================
            this.dtpAttendanceDate.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            this.dtpAttendanceDate.Format = DateTimePickerFormat.Long;
            this.dtpAttendanceDate.Location = new Point(140, 15);
            this.dtpAttendanceDate.Size = new Size(280, 32);
            this.dtpAttendanceDate.Value = DateTime.Today;

            // ========================================
            // dgvAttendance - Student Attendance Grid
            // ========================================
            this.dgvAttendance.BackgroundColor = Color.White;
            this.dgvAttendance.BorderStyle = BorderStyle.None;
            this.dgvAttendance.Location = new Point(20, 160);
            this.dgvAttendance.Size = new Size(860, 380);
            this.dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.RowHeadersVisible = false;
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToDeleteRows = false;
            this.dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendance.DefaultCellStyle.Font = new Font("Segoe UI", 11F);
            this.dgvAttendance.DefaultCellStyle.Padding = new Padding(5);
            this.dgvAttendance.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.dgvAttendance.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            this.dgvAttendance.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvAttendance.EnableHeadersVisualStyles = false;
            this.dgvAttendance.RowTemplate.Height = 40;
            this.dgvAttendance.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 250);
            this.dgvAttendance.CellContentClick += new DataGridViewCellEventHandler(this.dgvAttendance_CellContentClick);

            // ========================================
            // colRollNo - Roll Number Column
            // ========================================
            this.colRollNo.HeaderText = "Roll No";
            this.colRollNo.Name = "colRollNo";
            this.colRollNo.ReadOnly = true;
            this.colRollNo.FillWeight = 15;

            // ========================================
            // colStudentName - Student Name Column
            // ========================================
            this.colStudentName.HeaderText = "Student Name";
            this.colStudentName.Name = "colStudentName";
            this.colStudentName.ReadOnly = true;
            this.colStudentName.FillWeight = 40;

            // ========================================
            // colPresent - Present Checkbox Column
            // ========================================
            this.colPresent.HeaderText = "Present";
            this.colPresent.Name = "colPresent";
            this.colPresent.FillWeight = 15;

            // ========================================
            // colAbsent - Absent Checkbox Column
            // ========================================
            this.colAbsent.HeaderText = "Absent";
            this.colAbsent.Name = "colAbsent";
            this.colAbsent.FillWeight = 15;

            // ========================================
            // colLeave - Leave Checkbox Column
            // ========================================
            this.colLeave.HeaderText = "Leave";
            this.colLeave.Name = "colLeave";
            this.colLeave.FillWeight = 15;

            // Add columns to DataGridView
            this.dgvAttendance.Columns.AddRange(new DataGridViewColumn[] {
                this.colRollNo,
                this.colStudentName,
                this.colPresent,
                this.colAbsent,
                this.colLeave
            });

            // ========================================
            // btnSaveAttendance - Save Button
            // ========================================
            this.btnSaveAttendance.BackColor = Color.FromArgb(41, 128, 185);
            this.btnSaveAttendance.FlatStyle = FlatStyle.Flat;
            this.btnSaveAttendance.FlatAppearance.BorderSize = 0;
            this.btnSaveAttendance.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.btnSaveAttendance.ForeColor = Color.White;
            this.btnSaveAttendance.Location = new Point(350, 560);
            this.btnSaveAttendance.Size = new Size(200, 50);
            this.btnSaveAttendance.Text = "Save Attendance";
            this.btnSaveAttendance.Cursor = Cursors.Hand;
            this.btnSaveAttendance.Click += new EventHandler(this.btnSaveAttendance_Click);

            // ========================================
            // AttendanceForm - Main Form
            // ========================================
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new Size(900, 630);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelDateSection);
            this.Controls.Add(this.dgvAttendance);
            this.Controls.Add(this.btnSaveAttendance);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AttendanceForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "School Management System - Attendance";

            // Resume layout
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelDateSection.ResumeLayout(false);
            this.panelDateSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        // Control Declarations
        private Panel panelHeader;
        private Label lblFormTitle;
        private Button btnBack;
        private Panel panelDateSection;
        private Label lblSelectDate;
        private DateTimePicker dtpAttendanceDate;
        private DataGridView dgvAttendance;
        private DataGridViewTextBoxColumn colRollNo;
        private DataGridViewTextBoxColumn colStudentName;
        private DataGridViewCheckBoxColumn colPresent;
        private DataGridViewCheckBoxColumn colAbsent;
        private DataGridViewCheckBoxColumn colLeave;
        private Button btnSaveAttendance;
    }
}
