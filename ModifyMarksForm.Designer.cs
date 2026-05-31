namespace SchoolManagementSystem
{
    partial class ModifyMarksForm
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

            // Selection Panel
            this.panelSelection = new Panel();
            this.lblSubject = new Label();
            this.cmbSubject = new ComboBox();
            this.lblTerm = new Label();
            this.cmbTerm = new ComboBox();
            this.btnLoadMarks = new Button();

            // Marks Grid Panel
            this.panelMarksGrid = new Panel();
            this.lblGridTitle = new Label();
            this.dgvMarks = new DataGridView();
            this.colRollNo = new DataGridViewTextBoxColumn();
            this.colStudentName = new DataGridViewTextBoxColumn();
            this.colTotalMarks = new DataGridViewTextBoxColumn();
            this.colObtainedMarks = new DataGridViewTextBoxColumn();

            // Footer
            this.panelFooter = new Panel();
            this.btnBackToDashboard = new Button();
            this.btnUpdateMarks = new Button();

            // Suspend Layout
            this.panelHeader.SuspendLayout();
            this.panelSelection.SuspendLayout();
            this.panelMarksGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();

            // ========================================
            // panelHeader
            // ========================================
            this.panelHeader.BackColor = Color.FromArgb(41, 128, 185);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Location = new Point(0, 0);
            this.panelHeader.Size = new Size(900, 80);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblSubtitle);

            this.lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Location = new Point(0, 15);
            this.lblTitle.Size = new Size(900, 35);
            this.lblTitle.Text = "Modify Marks – Grade 4 – Section A";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSubtitle.Font = new Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = Color.FromArgb(214, 234, 248);
            this.lblSubtitle.Location = new Point(0, 50);
            this.lblSubtitle.Size = new Size(900, 20);
            this.lblSubtitle.Text = "Select subject and term to load existing marks";
            this.lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;

            // ========================================
            // panelSelection
            // ========================================
            this.panelSelection.BackColor = Color.White;
            this.panelSelection.Location = new Point(30, 95);
            this.panelSelection.Size = new Size(840, 70);
            this.panelSelection.BorderStyle = BorderStyle.FixedSingle;
            this.panelSelection.Controls.Add(this.lblSubject);
            this.panelSelection.Controls.Add(this.cmbSubject);
            this.panelSelection.Controls.Add(this.lblTerm);
            this.panelSelection.Controls.Add(this.cmbTerm);
            this.panelSelection.Controls.Add(this.btnLoadMarks);

            this.lblSubject.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblSubject.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblSubject.Location = new Point(20, 22);
            this.lblSubject.Size = new Size(70, 25);
            this.lblSubject.Text = "Subject:";

            this.cmbSubject.Font = new Font("Segoe UI", 10F);
            this.cmbSubject.Location = new Point(95, 20);
            this.cmbSubject.Size = new Size(200, 30);
            this.cmbSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbSubject.FlatStyle = FlatStyle.Flat;

            this.lblTerm.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblTerm.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblTerm.Location = new Point(330, 22);
            this.lblTerm.Size = new Size(50, 25);
            this.lblTerm.Text = "Term:";

            this.cmbTerm.Font = new Font("Segoe UI", 10F);
            this.cmbTerm.Location = new Point(385, 20);
            this.cmbTerm.Size = new Size(180, 30);
            this.cmbTerm.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbTerm.FlatStyle = FlatStyle.Flat;

            this.btnLoadMarks.BackColor = Color.FromArgb(41, 128, 185);
            this.btnLoadMarks.FlatStyle = FlatStyle.Flat;
            this.btnLoadMarks.FlatAppearance.BorderSize = 0;
            this.btnLoadMarks.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnLoadMarks.ForeColor = Color.White;
            this.btnLoadMarks.Location = new Point(700, 17);
            this.btnLoadMarks.Size = new Size(120, 36);
            this.btnLoadMarks.Text = "📥 Load Marks";
            this.btnLoadMarks.Cursor = Cursors.Hand;
            this.btnLoadMarks.Click += new EventHandler(this.btnLoadMarks_Click);

            // ========================================
            // panelMarksGrid
            // ========================================
            this.panelMarksGrid.BackColor = Color.White;
            this.panelMarksGrid.Location = new Point(30, 180);
            this.panelMarksGrid.Size = new Size(840, 330);
            this.panelMarksGrid.BorderStyle = BorderStyle.FixedSingle;
            this.panelMarksGrid.Visible = false;
            this.panelMarksGrid.Controls.Add(this.lblGridTitle);
            this.panelMarksGrid.Controls.Add(this.dgvMarks);

            this.lblGridTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblGridTitle.ForeColor = Color.FromArgb(41, 128, 185);
            this.lblGridTitle.Location = new Point(15, 10);
            this.lblGridTitle.Size = new Size(300, 25);
            this.lblGridTitle.Text = "📝 Student Marks";

            // ========================================
            // DataGridView - dgvMarks
            // ========================================
            this.dgvMarks.Location = new Point(15, 45);
            this.dgvMarks.Size = new Size(808, 270);
            this.dgvMarks.BackgroundColor = Color.White;
            this.dgvMarks.BorderStyle = BorderStyle.None;
            this.dgvMarks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMarks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgvMarks.EnableHeadersVisualStyles = false;
            this.dgvMarks.GridColor = Color.FromArgb(224, 224, 224);
            this.dgvMarks.RowHeadersVisible = false;
            this.dgvMarks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarks.AllowUserToAddRows = false;
            this.dgvMarks.AllowUserToDeleteRows = false;
            this.dgvMarks.AllowUserToResizeRows = false;
            this.dgvMarks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarks.MultiSelect = false;

            // Column Header Style
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.BackColor = Color.FromArgb(52, 73, 94);
            headerStyle.ForeColor = Color.White;
            headerStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            headerStyle.Padding = new Padding(5);
            this.dgvMarks.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvMarks.ColumnHeadersHeight = 40;
            this.dgvMarks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Row Style
            DataGridViewCellStyle rowStyle = new DataGridViewCellStyle();
            rowStyle.BackColor = Color.White;
            rowStyle.ForeColor = Color.FromArgb(44, 62, 80);
            rowStyle.Font = new Font("Segoe UI", 10F);
            rowStyle.SelectionBackColor = Color.FromArgb(214, 234, 248);
            rowStyle.SelectionForeColor = Color.FromArgb(44, 62, 80);
            rowStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            rowStyle.Padding = new Padding(5);
            this.dgvMarks.DefaultCellStyle = rowStyle;
            this.dgvMarks.RowTemplate.Height = 35;

            // Alternate Row Style
            DataGridViewCellStyle alternateRowStyle = new DataGridViewCellStyle();
            alternateRowStyle.BackColor = Color.FromArgb(250, 250, 250);
            alternateRowStyle.ForeColor = Color.FromArgb(44, 62, 80);
            alternateRowStyle.Font = new Font("Segoe UI", 10F);
            alternateRowStyle.SelectionBackColor = Color.FromArgb(214, 234, 248);
            alternateRowStyle.SelectionForeColor = Color.FromArgb(44, 62, 80);
            alternateRowStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvMarks.AlternatingRowsDefaultCellStyle = alternateRowStyle;

            // Columns
            this.colRollNo.HeaderText = "Roll No";
            this.colRollNo.Name = "colRollNo";
            this.colRollNo.ReadOnly = true;
            this.colRollNo.FillWeight = 15;

            this.colStudentName.HeaderText = "Student Name";
            this.colStudentName.Name = "colStudentName";
            this.colStudentName.ReadOnly = true;
            this.colStudentName.FillWeight = 40;

            this.colTotalMarks.HeaderText = "Total Marks";
            this.colTotalMarks.Name = "colTotalMarks";
            this.colTotalMarks.ReadOnly = true;
            this.colTotalMarks.FillWeight = 20;

            this.colObtainedMarks.HeaderText = "Obtained Marks";
            this.colObtainedMarks.Name = "colObtainedMarks";
            this.colObtainedMarks.ReadOnly = false;
            this.colObtainedMarks.FillWeight = 25;

            this.dgvMarks.Columns.AddRange(new DataGridViewColumn[] {
                this.colRollNo,
                this.colStudentName,
                this.colTotalMarks,
                this.colObtainedMarks
            });

            this.dgvMarks.CellValidating += new DataGridViewCellValidatingEventHandler(this.dgvMarks_CellValidating);
            this.dgvMarks.CellEndEdit += new DataGridViewCellEventHandler(this.dgvMarks_CellEndEdit);

            // ========================================
            // panelFooter
            // ========================================
            this.panelFooter.BackColor = Color.FromArgb(236, 240, 241);
            this.panelFooter.Dock = DockStyle.Bottom;
            this.panelFooter.Location = new Point(0, 525);
            this.panelFooter.Size = new Size(900, 55);
            this.panelFooter.Controls.Add(this.btnBackToDashboard);
            this.panelFooter.Controls.Add(this.btnUpdateMarks);

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

            this.btnUpdateMarks.BackColor = Color.FromArgb(39, 174, 96);
            this.btnUpdateMarks.FlatStyle = FlatStyle.Flat;
            this.btnUpdateMarks.FlatAppearance.BorderSize = 0;
            this.btnUpdateMarks.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnUpdateMarks.ForeColor = Color.White;
            this.btnUpdateMarks.Location = new Point(690, 10);
            this.btnUpdateMarks.Size = new Size(180, 38);
            this.btnUpdateMarks.Text = "💾 Update Marks";
            this.btnUpdateMarks.Cursor = Cursors.Hand;
            this.btnUpdateMarks.Visible = false;
            this.btnUpdateMarks.Click += new EventHandler(this.btnUpdateMarks_Click);

            // ========================================
            // ModifyMarksForm
            // ========================================
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new Size(900, 580);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSelection);
            this.Controls.Add(this.panelMarksGrid);
            this.Controls.Add(this.panelFooter);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ModifyMarksForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Modify Marks - School Management System";

            // Resume Layout
            this.panelHeader.ResumeLayout(false);
            this.panelSelection.ResumeLayout(false);
            this.panelMarksGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // Header
        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;

        // Selection Panel
        private Panel panelSelection;
        private Label lblSubject;
        private ComboBox cmbSubject;
        private Label lblTerm;
        private ComboBox cmbTerm;
        private Button btnLoadMarks;

        // Marks Grid Panel
        private Panel panelMarksGrid;
        private Label lblGridTitle;
        private DataGridView dgvMarks;
        private DataGridViewTextBoxColumn colRollNo;
        private DataGridViewTextBoxColumn colStudentName;
        private DataGridViewTextBoxColumn colTotalMarks;
        private DataGridViewTextBoxColumn colObtainedMarks;

        // Footer
        private Panel panelFooter;
        private Button btnBackToDashboard;
        private Button btnUpdateMarks;
    }
}
