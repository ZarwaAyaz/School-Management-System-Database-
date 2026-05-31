using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManagementSystem
{
    public partial class SubmitMonthlyFeeForm : Form
    {
        // Fee constants
        private const decimal LATE_FEE_PER_DAY = 50;
        private const int DUE_DATE_DAY = 10;

        // Current date for calculations
        private DateTime currentDate = DateTime.Now;

        // Sample student fee data
        private List<StudentFeeRecord> students = new List<StudentFeeRecord>();

        // Class fee structure
        private readonly Dictionary<string, decimal> classFees = new Dictionary<string, decimal>
        {
            { "Nursery", 2000 }, { "Prep", 2200 }, { "Class 1", 2500 }, { "Class 2", 2500 },
            { "Class 3", 2800 }, { "Class 4", 2800 }, { "Class 5", 3000 }, { "Class 6", 3200 },
            { "Class 7", 3200 }, { "Class 8", 3500 }, { "Class 9", 4000 }, { "Class 10", 4000 }
        };

        private readonly string[] classes = {
            "Nursery", "Prep", "Class 1", "Class 2", "Class 3", "Class 4",
            "Class 5", "Class 6", "Class 7", "Class 8", "Class 9", "Class 10"
        };

        private readonly string[] sections = { "A", "B", "C", "D" };
        private readonly string[] months = {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };

        public SubmitMonthlyFeeForm()
        {
            InitializeComponent();
            GenerateSampleData();
            SetupForm();
            SetupEventHandlers();
        }

        private void GenerateSampleData()
        {
            // Generate sample student data
            string[] firstNames = { "Ahmed", "Fatima", "Muhammad", "Ayesha", "Hassan", "Sara", "Ali", "Zainab", "Imran", "Mariam",
                                   "Bilal", "Hira", "Umar", "Amina", "Khalid", "Nadia", "Rashid", "Sana", "Waqar", "Mehreen" };
            string[] lastNames = { "Khan", "Ali", "Ahmed", "Malik", "Raza", "Hussain", "Sheikh", "Bibi", "Farooq", "Iqbal" };

            Random rand = new Random(42); // Fixed seed for consistent data
            int admissionCounter = 1001;

            foreach (var className in classes)
            {
                foreach (var section in new[] { "A", "B" })
                {
                    int studentCount = rand.Next(20, 30);
                    decimal baseFee = classFees[className];

                    for (int i = 0; i < studentCount; i++)
                    {
                        string firstName = firstNames[rand.Next(firstNames.Length)];
                        string lastName = lastNames[rand.Next(lastNames.Length)];
                        string name = $"{firstName} {lastName}";
                        string admNo = $"ADM-2024-{admissionCounter++}";
                        int rollNo = i + 1;

                        // Random scholarship (20% have scholarship)
                        bool hasScholarship = rand.Next(5) == 0;
                        decimal fee = hasScholarship ? baseFee * 0.8m : baseFee;

                        // Random payment status for current month
                        bool isPaid = rand.Next(3) == 0; // 33% already paid

                        students.Add(new StudentFeeRecord(
                            admNo, name, className, section, rollNo,
                            fee, hasScholarship, isPaid
                        ));
                    }
                }
            }
        }

        private void SetupForm()
        {
            // Setup class filter
            cmbClass.Items.Add("All Classes");
            cmbClass.Items.AddRange(classes);
            cmbClass.SelectedIndex = 0;

            // Setup section filter
            cmbSection.Items.Add("All Sections");
            cmbSection.Items.AddRange(sections);
            cmbSection.SelectedIndex = 0;

            // Setup month dropdown
            cmbMonth.Items.AddRange(months);
            cmbMonth.SelectedIndex = currentDate.Month - 1;

            // Setup year dropdown
            for (int year = currentDate.Year - 1; year <= currentDate.Year + 1; year++)
            {
                cmbYear.Items.Add(year.ToString());
            }
            cmbYear.SelectedItem = currentDate.Year.ToString();

            // Setup payment status filter
            cmbPaymentStatus.Items.AddRange(new string[] { "All Students", "Unpaid Only", "Paid Only" });
            cmbPaymentStatus.SelectedIndex = 1; // Default to unpaid

            // Update due date display
            UpdateDueDateDisplay();
        }

        private void SetupEventHandlers()
        {
            // Filter events
            cmbClass.SelectedIndexChanged += Filter_Changed;
            cmbSection.SelectedIndexChanged += Filter_Changed;
            cmbPaymentStatus.SelectedIndexChanged += Filter_Changed;
            txtSearch.TextChanged += Filter_Changed;
            cmbMonth.SelectedIndexChanged += MonthYear_Changed;
            cmbYear.SelectedIndexChanged += MonthYear_Changed;

            // Button events
            btnLoadStudents.Click += BtnLoadStudents_Click;
            btnSelectAll.Click += BtnSelectAll_Click;
            btnDeselectAll.Click += BtnDeselectAll_Click;
            btnSubmitSelected.Click += BtnSubmitSelected_Click;
            btnRefresh.Click += BtnRefresh_Click;

            // DataGridView events
            dgvStudents.CellValueChanged += DgvStudents_CellValueChanged;
            dgvStudents.CellContentClick += DgvStudents_CellContentClick;
            dgvStudents.CurrentCellDirtyStateChanged += DgvStudents_CurrentCellDirtyStateChanged;

            // Hover effects
            SetupButtonHoverEffects(btnLoadStudents, Color.FromArgb(41, 128, 185), Color.FromArgb(52, 152, 219));
            SetupButtonHoverEffects(btnSelectAll, Color.FromArgb(39, 174, 96), Color.FromArgb(46, 204, 113));
            SetupButtonHoverEffects(btnDeselectAll, Color.FromArgb(149, 165, 166), Color.FromArgb(189, 195, 199));
            SetupButtonHoverEffects(btnSubmitSelected, Color.FromArgb(39, 174, 96), Color.FromArgb(46, 204, 113));
            SetupButtonHoverEffects(btnRefresh, Color.FromArgb(52, 73, 94), Color.FromArgb(74, 90, 107));
        }

        private void SetupButtonHoverEffects(Button btn, Color normalColor, Color hoverColor)
        {
            btn.MouseEnter += (s, e) => btn.BackColor = hoverColor;
            btn.MouseLeave += (s, e) => btn.BackColor = normalColor;
        }

        private void UpdateDueDateDisplay()
        {
            int month = cmbMonth.SelectedIndex + 1;
            int year = int.Parse(cmbYear.SelectedItem?.ToString() ?? currentDate.Year.ToString());
            DateTime dueDate = new DateTime(year, month, DUE_DATE_DAY);

            lblDueDate.Text = $"Due Date: {dueDate:dd MMM yyyy}";

            // Calculate days overdue
            if (currentDate > dueDate)
            {
                int daysOverdue = (currentDate - dueDate).Days;
                lblOverdueInfo.Text = $"⚠ {daysOverdue} days overdue (Late fee: Rs. {daysOverdue * LATE_FEE_PER_DAY:N0})";
                lblOverdueInfo.ForeColor = Color.FromArgb(192, 57, 43);
                lblOverdueInfo.Visible = true;
            }
            else
            {
                int daysRemaining = (dueDate - currentDate).Days;
                lblOverdueInfo.Text = $"✓ {daysRemaining} days remaining until due date";
                lblOverdueInfo.ForeColor = Color.FromArgb(39, 174, 96);
                lblOverdueInfo.Visible = true;
            }
        }

        private void LoadStudentsToGrid()
        {
            dgvStudents.Rows.Clear();

            string classFilter = cmbClass.SelectedItem?.ToString() ?? "All Classes";
            string sectionFilter = cmbSection.SelectedItem?.ToString() ?? "All Sections";
            string statusFilter = cmbPaymentStatus.SelectedItem?.ToString() ?? "All Students";
            string searchText = txtSearch.Text.ToLower().Trim();

            int month = cmbMonth.SelectedIndex + 1;
            int year = int.Parse(cmbYear.SelectedItem?.ToString() ?? currentDate.Year.ToString());
            DateTime dueDate = new DateTime(year, month, DUE_DATE_DAY);
            int daysOverdue = currentDate > dueDate ? (currentDate - dueDate).Days : 0;

            var filteredStudents = students.Where(s =>
            {
                bool matchesClass = classFilter == "All Classes" || s.ClassName == classFilter;
                bool matchesSection = sectionFilter == "All Sections" || s.Section == sectionFilter;
                bool matchesStatus = statusFilter == "All Students" ||
                    (statusFilter == "Unpaid Only" && !s.IsPaidCurrentMonth) ||
                    (statusFilter == "Paid Only" && s.IsPaidCurrentMonth);
                bool matchesSearch = string.IsNullOrEmpty(searchText) ||
                    s.StudentName.ToLower().Contains(searchText) ||
                    s.AdmissionNo.ToLower().Contains(searchText) ||
                    s.RollNo.ToString().Contains(searchText);

                return matchesClass && matchesSection && matchesStatus && matchesSearch;
            }).OrderBy(s => s.ClassName).ThenBy(s => s.Section).ThenBy(s => s.RollNo).ToList();

            foreach (var student in filteredStudents)
            {
                decimal lateFee = student.IsPaidCurrentMonth ? 0 : daysOverdue * LATE_FEE_PER_DAY;
                decimal totalDue = student.IsPaidCurrentMonth ? 0 : student.MonthlyFee + lateFee;

                int rowIndex = dgvStudents.Rows.Add(
                    false, // Checkbox
                    student.AdmissionNo,
                    student.StudentName,
                    student.ClassName,
                    student.Section,
                    student.RollNo,
                    $"Rs. {student.MonthlyFee:N0}",
                    lateFee > 0 ? $"Rs. {lateFee:N0}" : "-",
                    $"Rs. {totalDue:N0}",
                    student.IsPaidCurrentMonth ? "Paid" : "Unpaid",
                    student.HasScholarship ? "20% Off" : "-"
                );

                // Style the row based on payment status
                DataGridViewRow row = dgvStudents.Rows[rowIndex];

                if (student.IsPaidCurrentMonth)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(232, 245, 233);
                    row.Cells["colStatus"].Style.ForeColor = Color.FromArgb(39, 174, 96);
                    row.Cells["colStatus"].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    row.Cells["colSelect"].Value = false;
                    row.Cells["colSelect"].ReadOnly = true;
                }
                else
                {
                    if (lateFee > 0)
                    {
                        row.Cells["colLateFee"].Style.ForeColor = Color.FromArgb(192, 57, 43);
                        row.Cells["colLateFee"].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                        row.Cells["colTotalDue"].Style.ForeColor = Color.FromArgb(192, 57, 43);
                        row.Cells["colTotalDue"].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    }
                    row.Cells["colStatus"].Style.ForeColor = Color.FromArgb(230, 126, 34);
                    row.Cells["colStatus"].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }

                if (student.HasScholarship)
                {
                    row.Cells["colScholarship"].Style.ForeColor = Color.FromArgb(155, 89, 182);
                    row.Cells["colScholarship"].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
            }

            UpdateSummary();
        }

        private void UpdateSummary()
        {
            int totalStudents = dgvStudents.Rows.Count;
            int selectedCount = 0;
            decimal totalFees = 0;
            decimal totalLateFees = 0;
            decimal totalAmount = 0;
            int paidCount = 0;
            int unpaidCount = 0;

            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["colSelect"].Value);
                string status = row.Cells["colStatus"].Value?.ToString() ?? "";
                string feeStr = row.Cells["colMonthlyFee"].Value?.ToString()?.Replace("Rs. ", "").Replace(",", "") ?? "0";
                string lateStr = row.Cells["colLateFee"].Value?.ToString()?.Replace("Rs. ", "").Replace(",", "").Replace("-", "0") ?? "0";
                string totalStr = row.Cells["colTotalDue"].Value?.ToString()?.Replace("Rs. ", "").Replace(",", "") ?? "0";

                decimal fee = decimal.TryParse(feeStr, out decimal f) ? f : 0;
                decimal late = decimal.TryParse(lateStr, out decimal l) ? l : 0;
                decimal total = decimal.TryParse(totalStr, out decimal t) ? t : 0;

                if (status == "Paid")
                {
                    paidCount++;
                }
                else
                {
                    unpaidCount++;
                    if (isSelected)
                    {
                        selectedCount++;
                        totalFees += fee;
                        totalLateFees += late;
                        totalAmount += total;
                    }
                }
            }

            lblTotalStudents.Text = totalStudents.ToString();
            lblPaidCount.Text = paidCount.ToString();
            lblUnpaidCount.Text = unpaidCount.ToString();
            lblSelectedCount.Text = selectedCount.ToString();
            lblTotalFees.Text = $"Rs. {totalFees:N0}";
            lblTotalLateFees.Text = $"Rs. {totalLateFees:N0}";
            lblGrandTotal.Text = $"Rs. {totalAmount:N0}";

            btnSubmitSelected.Enabled = selectedCount > 0;
            btnSubmitSelected.Text = selectedCount > 0 
                ? $"💳 Submit Fee ({selectedCount} Students)" 
                : "💳 Submit Fee";
        }

        #region Event Handlers

        private void Filter_Changed(object? sender, EventArgs e)
        {
            if (dgvStudents.Rows.Count > 0)
            {
                LoadStudentsToGrid();
            }
        }

        private void MonthYear_Changed(object? sender, EventArgs e)
        {
            UpdateDueDateDisplay();
            if (dgvStudents.Rows.Count > 0)
            {
                LoadStudentsToGrid();
            }
        }

        private void BtnLoadStudents_Click(object? sender, EventArgs e)
        {
            LoadStudentsToGrid();
        }

        private void BtnSelectAll_Click(object? sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                if (row.Cells["colStatus"].Value?.ToString() != "Paid")
                {
                    row.Cells["colSelect"].Value = true;
                }
            }
            UpdateSummary();
        }

        private void BtnDeselectAll_Click(object? sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                row.Cells["colSelect"].Value = false;
            }
            UpdateSummary();
        }

        private void BtnRefresh_Click(object? sender, EventArgs e)
        {
            LoadStudentsToGrid();
            MessageBox.Show("Data refreshed successfully!", "Refresh",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DgvStudents_CurrentCellDirtyStateChanged(object? sender, EventArgs e)
        {
            if (dgvStudents.IsCurrentCellDirty)
            {
                dgvStudents.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void DgvStudents_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvStudents.Columns["colSelect"] != null && e.ColumnIndex == dgvStudents.Columns["colSelect"]!.Index)
            {
                // Will trigger CellValueChanged after commit
            }
        }

        private void DgvStudents_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvStudents.Columns["colSelect"] != null && e.ColumnIndex == dgvStudents.Columns["colSelect"]!.Index)
            {
                UpdateSummary();
            }
        }

        private void BtnSubmitSelected_Click(object? sender, EventArgs e)
        {
            // Collect selected students
            List<string> selectedStudents = new List<string>();
            decimal grandTotal = 0;

            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                if (Convert.ToBoolean(row.Cells["colSelect"].Value))
                {
                    string name = row.Cells["colStudentName"].Value?.ToString() ?? "";
                    string admNo = row.Cells["colAdmissionNo"].Value?.ToString() ?? "";
                    string totalStr = row.Cells["colTotalDue"].Value?.ToString()?.Replace("Rs. ", "").Replace(",", "") ?? "0";
                    decimal total = decimal.TryParse(totalStr, out decimal t) ? t : 0;

                    selectedStudents.Add($"{name} ({admNo}) - Rs. {total:N0}");
                    grandTotal += total;
                }
            }

            if (selectedStudents.Count == 0)
            {
                MessageBox.Show("Please select at least one student to submit fee.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Show confirmation dialog
            string month = cmbMonth.SelectedItem?.ToString() ?? "";
            string year = cmbYear.SelectedItem?.ToString() ?? "";

            using (Form confirmDialog = CreateConfirmationDialog(selectedStudents, grandTotal, month, year))
            {
                if (confirmDialog.ShowDialog(this) == DialogResult.Yes)
                {
                    ProcessFeeSubmission(selectedStudents.Count, grandTotal, month, year);
                }
            }
        }

        #endregion

        private Form CreateConfirmationDialog(List<string> selectedStudents, decimal grandTotal, string month, string year)
        {
            Form dialog = new Form
            {
                Text = "Confirm Fee Submission",
                Size = new Size(550, 500),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                BackColor = Color.White
            };

            // Header
            Panel headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 70,
                BackColor = Color.FromArgb(39, 174, 96)
            };

            Label lblIcon = new Label
            {
                Text = "💳",
                Font = new Font("Segoe UI", 28),
                ForeColor = Color.White,
                Location = new Point(20, 10),
                AutoSize = true
            };

            Label lblTitle = new Label
            {
                Text = "Confirm Fee Submission",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(75, 8),
                AutoSize = true
            };

            Label lblSubtitle = new Label
            {
                Text = $"Monthly Fee for {month} {year}",
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.FromArgb(200, 255, 200),
                Location = new Point(77, 38),
                AutoSize = true
            };

            headerPanel.Controls.Add(lblIcon);
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Controls.Add(lblSubtitle);

            // Summary panel
            Panel summaryPanel = new Panel
            {
                Location = new Point(20, 85),
                Size = new Size(495, 60),
                BackColor = Color.FromArgb(245, 247, 250)
            };

            Label lblSummary = new Label
            {
                Text = $"📋 {selectedStudents.Count} Student(s) Selected",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location = new Point(15, 10),
                AutoSize = true
            };

            Label lblTotalAmount = new Label
            {
                Text = $"Total Amount: Rs. {grandTotal:N0}",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.FromArgb(39, 174, 96),
                Location = new Point(15, 32),
                AutoSize = true
            };

            summaryPanel.Controls.Add(lblSummary);
            summaryPanel.Controls.Add(lblTotalAmount);

            // Students list
            Label lblStudentsList = new Label
            {
                Text = "Students:",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94),
                Location = new Point(20, 155),
                AutoSize = true
            };

            ListBox lstStudents = new ListBox
            {
                Location = new Point(20, 175),
                Size = new Size(495, 200),
                Font = new Font("Segoe UI", 9),
                BorderStyle = BorderStyle.FixedSingle
            };
            lstStudents.Items.AddRange(selectedStudents.ToArray());

            // Warning
            Label lblWarning = new Label
            {
                Text = "⚠ This action will mark the selected students as paid for " + month + " " + year + ".",
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.FromArgb(230, 126, 34),
                Location = new Point(20, 385),
                Size = new Size(495, 20)
            };

            // Buttons
            Button btnConfirm = new Button
            {
                Text = "✓ Confirm Payment",
                Size = new Size(150, 42),
                Location = new Point(220, 415),
                BackColor = Color.FromArgb(39, 174, 96),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Cursor = Cursors.Hand,
                DialogResult = DialogResult.Yes
            };
            btnConfirm.FlatAppearance.BorderSize = 0;

            Button btnCancel = new Button
            {
                Text = "Cancel",
                Size = new Size(100, 42),
                Location = new Point(380, 415),
                BackColor = Color.FromArgb(149, 165, 166),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Cursor = Cursors.Hand,
                DialogResult = DialogResult.No
            };
            btnCancel.FlatAppearance.BorderSize = 0;

            dialog.Controls.Add(headerPanel);
            dialog.Controls.Add(summaryPanel);
            dialog.Controls.Add(lblStudentsList);
            dialog.Controls.Add(lstStudents);
            dialog.Controls.Add(lblWarning);
            dialog.Controls.Add(btnConfirm);
            dialog.Controls.Add(btnCancel);

            return dialog;
        }

        private void ProcessFeeSubmission(int count, decimal total, string month, string year)
        {
            // Update payment status for selected students
            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                if (Convert.ToBoolean(row.Cells["colSelect"].Value))
                {
                    string admNo = row.Cells["colAdmissionNo"].Value?.ToString() ?? "";
                    var student = students.FirstOrDefault(s => s.AdmissionNo == admNo);
                    if (student != null)
                    {
                        student.IsPaidCurrentMonth = true;
                    }
                }
            }

            // Show success message
            MessageBox.Show(
                $"Fee Submission Successful!\n\n" +
                $"Month: {month} {year}\n" +
                $"Students: {count}\n" +
                $"Total Amount: Rs. {total:N0}\n\n" +
                $"Receipt numbers have been generated.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Reload grid
            LoadStudentsToGrid();
        }
    }

    /// <summary>
    /// Student fee record for monthly fee submission
    /// </summary>
    public class StudentFeeRecord
    {
        public string AdmissionNo { get; set; }
        public string StudentName { get; set; }
        public string ClassName { get; set; }
        public string Section { get; set; }
        public int RollNo { get; set; }
        public decimal MonthlyFee { get; set; }
        public bool HasScholarship { get; set; }
        public bool IsPaidCurrentMonth { get; set; }

        public StudentFeeRecord(string admissionNo, string studentName, string className,
            string section, int rollNo, decimal monthlyFee, bool hasScholarship, bool isPaid)
        {
            AdmissionNo = admissionNo;
            StudentName = studentName;
            ClassName = className;
            Section = section;
            RollNo = rollNo;
            MonthlyFee = monthlyFee;
            HasScholarship = hasScholarship;
            IsPaidCurrentMonth = isPaid;
        }
    }
}
