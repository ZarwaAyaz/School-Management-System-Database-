namespace SchoolManagementSystem
{
    partial class MarkTeacherAttendanceForm
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpAttendanceDate = new System.Windows.Forms.DateTimePicker();
            this.btnMarkAllPresent = new System.Windows.Forms.Button();
            this.panelStats = new System.Windows.Forms.Panel();
            this.lblPresentLabel = new System.Windows.Forms.Label();
            this.lblPresentCount = new System.Windows.Forms.Label();
            this.lblAbsentLabel = new System.Windows.Forms.Label();
            this.lblAbsentCount = new System.Windows.Forms.Label();
            this.lblLeaveLabel = new System.Windows.Forms.Label();
            this.lblLeaveCount = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.colEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignedClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAffectedClasses = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.panelBottom.SuspendLayout();
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
            this.panelHeader.Size = new System.Drawing.Size(1000, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(300, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(370, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Mark Teacher Attendance";
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
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.lblDate);
            this.panelTop.Controls.Add(this.dtpAttendanceDate);
            this.panelTop.Controls.Add(this.btnMarkAllPresent);
            this.panelTop.Location = new System.Drawing.Point(20, 100);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(960, 70);
            this.panelTop.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDate.Location = new System.Drawing.Point(20, 15);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(121, 20);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Attendance Date:";
            // 
            // dtpAttendanceDate
            // 
            this.dtpAttendanceDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpAttendanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAttendanceDate.Location = new System.Drawing.Point(150, 12);
            this.dtpAttendanceDate.Name = "dtpAttendanceDate";
            this.dtpAttendanceDate.Size = new System.Drawing.Size(200, 27);
            this.dtpAttendanceDate.TabIndex = 1;
            this.dtpAttendanceDate.ValueChanged += new System.EventHandler(this.DtpAttendanceDate_ValueChanged);
            // 
            // btnMarkAllPresent
            // 
            this.btnMarkAllPresent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnMarkAllPresent.FlatAppearance.BorderSize = 0;
            this.btnMarkAllPresent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkAllPresent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMarkAllPresent.ForeColor = System.Drawing.Color.White;
            this.btnMarkAllPresent.Location = new System.Drawing.Point(750, 15);
            this.btnMarkAllPresent.Name = "btnMarkAllPresent";
            this.btnMarkAllPresent.Size = new System.Drawing.Size(180, 40);
            this.btnMarkAllPresent.TabIndex = 2;
            this.btnMarkAllPresent.Text = "✓ Mark All Present";
            this.btnMarkAllPresent.UseVisualStyleBackColor = false;
            this.btnMarkAllPresent.Click += new System.EventHandler(this.BtnMarkAllPresent_Click);
            // 
            // panelStats
            // 
            this.panelStats.BackColor = System.Drawing.Color.White;
            this.panelStats.Controls.Add(this.lblPresentLabel);
            this.panelStats.Controls.Add(this.lblPresentCount);
            this.panelStats.Controls.Add(this.lblAbsentLabel);
            this.panelStats.Controls.Add(this.lblAbsentCount);
            this.panelStats.Controls.Add(this.lblLeaveLabel);
            this.panelStats.Controls.Add(this.lblLeaveCount);
            this.panelStats.Location = new System.Drawing.Point(20, 190);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(960, 80);
            this.panelStats.TabIndex = 2;
            // 
            // lblPresentLabel
            // 
            this.lblPresentLabel.AutoSize = true;
            this.lblPresentLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPresentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblPresentLabel.Location = new System.Drawing.Point(100, 15);
            this.lblPresentLabel.Name = "lblPresentLabel";
            this.lblPresentLabel.Size = new System.Drawing.Size(61, 20);
            this.lblPresentLabel.TabIndex = 0;
            this.lblPresentLabel.Text = "Present";
            // 
            // lblPresentCount
            // 
            this.lblPresentCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblPresentCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblPresentCount.Location = new System.Drawing.Point(90, 35);
            this.lblPresentCount.Name = "lblPresentCount";
            this.lblPresentCount.Size = new System.Drawing.Size(80, 40);
            this.lblPresentCount.TabIndex = 1;
            this.lblPresentCount.Text = "0";
            this.lblPresentCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAbsentLabel
            // 
            this.lblAbsentLabel.AutoSize = true;
            this.lblAbsentLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAbsentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblAbsentLabel.Location = new System.Drawing.Point(430, 15);
            this.lblAbsentLabel.Name = "lblAbsentLabel";
            this.lblAbsentLabel.Size = new System.Drawing.Size(58, 20);
            this.lblAbsentLabel.TabIndex = 2;
            this.lblAbsentLabel.Text = "Absent";
            // 
            // lblAbsentCount
            // 
            this.lblAbsentCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblAbsentCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblAbsentCount.Location = new System.Drawing.Point(420, 35);
            this.lblAbsentCount.Name = "lblAbsentCount";
            this.lblAbsentCount.Size = new System.Drawing.Size(80, 40);
            this.lblAbsentCount.TabIndex = 3;
            this.lblAbsentCount.Text = "0";
            this.lblAbsentCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLeaveLabel
            // 
            this.lblLeaveLabel.AutoSize = true;
            this.lblLeaveLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblLeaveLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.lblLeaveLabel.Location = new System.Drawing.Point(740, 15);
            this.lblLeaveLabel.Name = "lblLeaveLabel";
            this.lblLeaveLabel.Size = new System.Drawing.Size(73, 20);
            this.lblLeaveLabel.TabIndex = 4;
            this.lblLeaveLabel.Text = "On Leave";
            // 
            // lblLeaveCount
            // 
            this.lblLeaveCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblLeaveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.lblLeaveCount.Location = new System.Drawing.Point(730, 35);
            this.lblLeaveCount.Name = "lblLeaveCount";
            this.lblLeaveCount.Size = new System.Drawing.Size(80, 40);
            this.lblLeaveCount.TabIndex = 5;
            this.lblLeaveCount.Text = "0";
            this.lblLeaveCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.dgvAttendance);
            this.panelMain.Controls.Add(this.lblAffectedClasses);
            this.panelMain.Location = new System.Drawing.Point(20, 290);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(960, 370);
            this.panelMain.TabIndex = 3;
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
            this.colEmployeeId,
            this.colTeacherName,
            this.colAssignedClass,
            this.colStatus});
            this.dgvAttendance.Location = new System.Drawing.Point(0, 0);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.ReadOnly = true;
            this.dgvAttendance.RowHeadersVisible = false;
            this.dgvAttendance.RowTemplate.Height = 40;
            this.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendance.Size = new System.Drawing.Size(960, 320);
            this.dgvAttendance.TabIndex = 0;
            this.dgvAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAttendance_CellContentClick);
            // 
            // colEmployeeId
            // 
            this.colEmployeeId.HeaderText = "Employee ID";
            this.colEmployeeId.Name = "colEmployeeId";
            this.colEmployeeId.ReadOnly = true;
            this.colEmployeeId.FillWeight = 20F;
            // 
            // colTeacherName
            // 
            this.colTeacherName.HeaderText = "Teacher Name";
            this.colTeacherName.Name = "colTeacherName";
            this.colTeacherName.ReadOnly = true;
            this.colTeacherName.FillWeight = 35F;
            // 
            // colAssignedClass
            // 
            this.colAssignedClass.HeaderText = "Assigned Class";
            this.colAssignedClass.Name = "colAssignedClass";
            this.colAssignedClass.ReadOnly = true;
            this.colAssignedClass.FillWeight = 25F;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status (Click to Change)";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.FillWeight = 20F;
            // 
            // lblAffectedClasses
            // 
            this.lblAffectedClasses.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAffectedClasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblAffectedClasses.Location = new System.Drawing.Point(10, 330);
            this.lblAffectedClasses.Name = "lblAffectedClasses";
            this.lblAffectedClasses.Size = new System.Drawing.Size(940, 30);
            this.lblAffectedClasses.TabIndex = 1;
            this.lblAffectedClasses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAffectedClasses.Visible = false;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.White;
            this.panelBottom.Controls.Add(this.btnSave);
            this.panelBottom.Location = new System.Drawing.Point(20, 680);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(960, 70);
            this.panelBottom.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(350, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(260, 50);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save Attendance";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // MarkTeacherAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1000, 770);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MarkTeacherAttendanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mark Teacher Attendance";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelStats.ResumeLayout(false);
            this.panelStats.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpAttendanceDate;
        private System.Windows.Forms.Button btnMarkAllPresent;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label lblPresentLabel;
        private System.Windows.Forms.Label lblPresentCount;
        private System.Windows.Forms.Label lblAbsentLabel;
        private System.Windows.Forms.Label lblAbsentCount;
        private System.Windows.Forms.Label lblLeaveLabel;
        private System.Windows.Forms.Label lblLeaveCount;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Label lblAffectedClasses;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnSave;
    }
}
