namespace SchoolManagementSystem
{
    partial class ViewPastAttendanceForm
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblTeacherInfo = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpAttendanceDate = new System.Windows.Forms.DateTimePicker();
            this.lblEditMode = new System.Windows.Forms.Label();
            this.btnEditAttendance = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.panelStats = new System.Windows.Forms.Panel();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.lblPresentLabel = new System.Windows.Forms.Label();
            this.lblPresentCount = new System.Windows.Forms.Label();
            this.lblAbsentLabel = new System.Windows.Forms.Label();
            this.lblAbsentCount = new System.Windows.Forms.Label();
            this.lblLeaveLabel = new System.Windows.Forms.Label();
            this.lblLeaveCount = new System.Windows.Forms.Label();
            this.lblPercentLabel = new System.Windows.Forms.Label();
            this.lblAttendancePercent = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.colAdmissionNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRollNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.btnBack);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(900, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(270, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "View Past Attendance";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(20, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 40);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panelInfo.Controls.Add(this.lblTeacherInfo);
            this.panelInfo.Location = new System.Drawing.Point(20, 100);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(860, 45);
            this.panelInfo.TabIndex = 1;
            // 
            // lblTeacherInfo
            // 
            this.lblTeacherInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTeacherInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTeacherInfo.ForeColor = System.Drawing.Color.White;
            this.lblTeacherInfo.Location = new System.Drawing.Point(0, 0);
            this.lblTeacherInfo.Name = "lblTeacherInfo";
            this.lblTeacherInfo.Size = new System.Drawing.Size(860, 45);
            this.lblTeacherInfo.TabIndex = 0;
            this.lblTeacherInfo.Text = "Teacher: Ahmed Khan | Assigned Class: Class 5";
            this.lblTeacherInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.lblDate);
            this.panelTop.Controls.Add(this.dtpAttendanceDate);
            this.panelTop.Controls.Add(this.lblEditMode);
            this.panelTop.Controls.Add(this.btnEditAttendance);
            this.panelTop.Controls.Add(this.btnCancelEdit);
            this.panelTop.Location = new System.Drawing.Point(20, 165);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(860, 70);
            this.panelTop.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDate.Location = new System.Drawing.Point(20, 15);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(89, 20);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Select Date:";
            // 
            // dtpAttendanceDate
            // 
            this.dtpAttendanceDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpAttendanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAttendanceDate.Location = new System.Drawing.Point(20, 40);
            this.dtpAttendanceDate.Name = "dtpAttendanceDate";
            this.dtpAttendanceDate.Size = new System.Drawing.Size(200, 27);
            this.dtpAttendanceDate.TabIndex = 1;
            this.dtpAttendanceDate.ValueChanged += new System.EventHandler(this.DtpAttendanceDate_ValueChanged);
            // 
            // lblEditMode
            // 
            this.lblEditMode.AutoSize = true;
            this.lblEditMode.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblEditMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.lblEditMode.Location = new System.Drawing.Point(250, 25);
            this.lblEditMode.Name = "lblEditMode";
            this.lblEditMode.Size = new System.Drawing.Size(188, 20);
            this.lblEditMode.TabIndex = 2;
            this.lblEditMode.Text = "⚠ EDIT MODE ACTIVE";
            this.lblEditMode.Visible = false;
            // 
            // btnEditAttendance
            // 
            this.btnEditAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnEditAttendance.FlatAppearance.BorderSize = 0;
            this.btnEditAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAttendance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditAttendance.ForeColor = System.Drawing.Color.White;
            this.btnEditAttendance.Location = new System.Drawing.Point(550, 15);
            this.btnEditAttendance.Name = "btnEditAttendance";
            this.btnEditAttendance.Size = new System.Drawing.Size(150, 40);
            this.btnEditAttendance.TabIndex = 3;
            this.btnEditAttendance.Text = "✏️ Edit Attendance";
            this.btnEditAttendance.UseVisualStyleBackColor = false;
            this.btnEditAttendance.Click += new System.EventHandler(this.BtnEditAttendance_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCancelEdit.FlatAppearance.BorderSize = 0;
            this.btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelEdit.ForeColor = System.Drawing.Color.White;
            this.btnCancelEdit.Location = new System.Drawing.Point(710, 15);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(130, 40);
            this.btnCancelEdit.TabIndex = 4;
            this.btnCancelEdit.Text = "✗ Cancel";
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Visible = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.BtnCancelEdit_Click);
            // 
            // panelStats
            // 
            this.panelStats.BackColor = System.Drawing.Color.White;
            this.panelStats.Controls.Add(this.lblTotalLabel);
            this.panelStats.Controls.Add(this.lblTotalCount);
            this.panelStats.Controls.Add(this.lblPresentLabel);
            this.panelStats.Controls.Add(this.lblPresentCount);
            this.panelStats.Controls.Add(this.lblAbsentLabel);
            this.panelStats.Controls.Add(this.lblAbsentCount);
            this.panelStats.Controls.Add(this.lblLeaveLabel);
            this.panelStats.Controls.Add(this.lblLeaveCount);
            this.panelStats.Controls.Add(this.lblPercentLabel);
            this.panelStats.Controls.Add(this.lblAttendancePercent);
            this.panelStats.Location = new System.Drawing.Point(20, 255);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(860, 80);
            this.panelStats.TabIndex = 3;
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTotalLabel.Location = new System.Drawing.Point(50, 15);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(42, 19);
            this.lblTotalLabel.TabIndex = 0;
            this.lblTotalLabel.Text = "Total";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTotalCount.Location = new System.Drawing.Point(40, 35);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(70, 35);
            this.lblTotalCount.TabIndex = 1;
            this.lblTotalCount.Text = "0";
            this.lblTotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPresentLabel
            // 
            this.lblPresentLabel.AutoSize = true;
            this.lblPresentLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPresentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblPresentLabel.Location = new System.Drawing.Point(200, 15);
            this.lblPresentLabel.Name = "lblPresentLabel";
            this.lblPresentLabel.Size = new System.Drawing.Size(58, 19);
            this.lblPresentLabel.TabIndex = 2;
            this.lblPresentLabel.Text = "Present";
            // 
            // lblPresentCount
            // 
            this.lblPresentCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblPresentCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblPresentCount.Location = new System.Drawing.Point(190, 35);
            this.lblPresentCount.Name = "lblPresentCount";
            this.lblPresentCount.Size = new System.Drawing.Size(70, 35);
            this.lblPresentCount.TabIndex = 3;
            this.lblPresentCount.Text = "0";
            this.lblPresentCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAbsentLabel
            // 
            this.lblAbsentLabel.AutoSize = true;
            this.lblAbsentLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAbsentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblAbsentLabel.Location = new System.Drawing.Point(350, 15);
            this.lblAbsentLabel.Name = "lblAbsentLabel";
            this.lblAbsentLabel.Size = new System.Drawing.Size(55, 19);
            this.lblAbsentLabel.TabIndex = 4;
            this.lblAbsentLabel.Text = "Absent";
            // 
            // lblAbsentCount
            // 
            this.lblAbsentCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblAbsentCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblAbsentCount.Location = new System.Drawing.Point(340, 35);
            this.lblAbsentCount.Name = "lblAbsentCount";
            this.lblAbsentCount.Size = new System.Drawing.Size(70, 35);
            this.lblAbsentCount.TabIndex = 5;
            this.lblAbsentCount.Text = "0";
            this.lblAbsentCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLeaveLabel
            // 
            this.lblLeaveLabel.AutoSize = true;
            this.lblLeaveLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLeaveLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.lblLeaveLabel.Location = new System.Drawing.Point(490, 15);
            this.lblLeaveLabel.Name = "lblLeaveLabel";
            this.lblLeaveLabel.Size = new System.Drawing.Size(69, 19);
            this.lblLeaveLabel.TabIndex = 6;
            this.lblLeaveLabel.Text = "On Leave";
            // 
            // lblLeaveCount
            // 
            this.lblLeaveCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblLeaveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.lblLeaveCount.Location = new System.Drawing.Point(490, 35);
            this.lblLeaveCount.Name = "lblLeaveCount";
            this.lblLeaveCount.Size = new System.Drawing.Size(70, 35);
            this.lblLeaveCount.TabIndex = 7;
            this.lblLeaveCount.Text = "0";
            this.lblLeaveCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPercentLabel
            // 
            this.lblPercentLabel.AutoSize = true;
            this.lblPercentLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPercentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblPercentLabel.Location = new System.Drawing.Point(680, 15);
            this.lblPercentLabel.Name = "lblPercentLabel";
            this.lblPercentLabel.Size = new System.Drawing.Size(95, 19);
            this.lblPercentLabel.TabIndex = 8;
            this.lblPercentLabel.Text = "Attendance %";
            // 
            // lblAttendancePercent
            // 
            this.lblAttendancePercent.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblAttendancePercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblAttendancePercent.Location = new System.Drawing.Point(670, 35);
            this.lblAttendancePercent.Name = "lblAttendancePercent";
            this.lblAttendancePercent.Size = new System.Drawing.Size(120, 35);
            this.lblAttendancePercent.TabIndex = 9;
            this.lblAttendancePercent.Text = "0%";
            this.lblAttendancePercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.dgvAttendance);
            this.panelMain.Location = new System.Drawing.Point(20, 355);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(860, 395);
            this.panelMain.TabIndex = 4;
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToDeleteRows = false;
            this.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAttendance.ColumnHeadersHeight = 40;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAdmissionNo,
            this.colStudentName,
            this.colRollNo,
            this.colStatus});
            this.dgvAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAttendance.Location = new System.Drawing.Point(0, 0);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.ReadOnly = true;
            this.dgvAttendance.RowHeadersVisible = false;
            this.dgvAttendance.RowTemplate.Height = 35;
            this.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendance.Size = new System.Drawing.Size(860, 395);
            this.dgvAttendance.TabIndex = 0;
            this.dgvAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAttendance_CellContentClick);
            // 
            // colAdmissionNo
            // 
            this.colAdmissionNo.HeaderText = "Admission No";
            this.colAdmissionNo.Name = "colAdmissionNo";
            this.colAdmissionNo.ReadOnly = true;
            this.colAdmissionNo.FillWeight = 20F;
            // 
            // colStudentName
            // 
            this.colStudentName.HeaderText = "Student Name";
            this.colStudentName.Name = "colStudentName";
            this.colStudentName.ReadOnly = true;
            this.colStudentName.FillWeight = 45F;
            // 
            // colRollNo
            // 
            this.colRollNo.HeaderText = "Roll No";
            this.colRollNo.Name = "colRollNo";
            this.colRollNo.ReadOnly = true;
            this.colRollNo.FillWeight = 15F;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.FillWeight = 20F;
            // 
            // ViewPastAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(900, 770);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ViewPastAttendanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Past Attendance";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelStats.ResumeLayout(false);
            this.panelStats.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblTeacherInfo;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpAttendanceDate;
        private System.Windows.Forms.Label lblEditMode;
        private System.Windows.Forms.Button btnEditAttendance;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblPresentLabel;
        private System.Windows.Forms.Label lblPresentCount;
        private System.Windows.Forms.Label lblAbsentLabel;
        private System.Windows.Forms.Label lblAbsentCount;
        private System.Windows.Forms.Label lblLeaveLabel;
        private System.Windows.Forms.Label lblLeaveCount;
        private System.Windows.Forms.Label lblPercentLabel;
        private System.Windows.Forms.Label lblAttendancePercent;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdmissionNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRollNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
