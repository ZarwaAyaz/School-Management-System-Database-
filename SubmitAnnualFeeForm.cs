using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManagementSystem
{
    public partial class SubmitAnnualFeeForm : Form
    {
        // Annual fee constants
        private const int ANNUAL_FEE_DUE_DAY = 15; // Due by 15th of the academic year start month
        private const int ACADEMIC_YEAR_START_MONTH = 4; // April

        // Current date for calculations
        private DateTime currentDate = DateTime.Now;

        // Sample student annual fee data
        private List<StudentAnnualFeeRecord> students = new List<StudentAnnualFeeRecord>();

        // Class annual fee structure
        private readonly Dictionary<string, decimal> classAnnualFees = new Dictionary<string, decimal>
        {
            { "Nursery", 15000 }, { "Prep", 16500 }, { "Class 1", 18000 }, { "Class 2", 18000 },
            { "Class 3", 20000 }, { "Class 4", 20000 }, { "Class 5", 22000 }, { "Class 6", 24000 },
            { "Class 7", 24000 }, { "Class 8", 26000 }, { "Class 9", 30000 }, { "Class 10", 30000 }
        };

        // Fee components breakdown
        private readonly Dictionary<string, Dictionary<string, decimal>> feeBreakdown = new Dictionary<string, Dictionary<string, decimal>>
        {
            { "Nursery", new Dictionary<string, decimal> { { "Admission", 3000 }, { "Registration", 1000 }, { "Lab", 0 }, { "Sports", 2000 }, { "Library", 1500 }, { "Computer", 2000 }, { "Exam", 2500 }, { "Development", 3000 } } },
            { "Prep", new Dictionary<string, decimal> { { "Admission", 3500 }, { "Registration", 1000 }, { "Lab", 0 }, { "Sports", 2000 }, { "Library", 1500 }, { "Computer", 2500 }, { "Exam", 3000 }, { "Development", 3000 } } },
            { "Class 1", new Dictionary<string, decimal> { { "Admission", 4000 }, { "Registration", 1000 }, { "Lab", 0 }, { "Sports", 2000 }, { "Library", 2000 }, { "Computer", 3000 }, { "Exam", 3000 }, { "Development", 3000 } } },
            { "Class 2", new Dictionary<string, decimal> { { "Admission", 4000 }, { "Registration", 1000 }, { "Lab", 0 }, { "Sports", 2000 }, { "Library", 2000 }, { "Computer", 3000 }, { "Exam", 3000 }, { "Development", 3000 } } },
            { "Class 3", new Dictionary<string, decimal> { { "Admission", 4500 }, { "Registration", 1000 }, { "Lab", 1500 }, { "Sports", 2000 }, { "Library", 2000 }, { "Computer", 3000 }, { "Exam", 3000 }, { "Development", 3000 } } },
            { "Class 4", new Dictionary<string, decimal> { { "Admission", 4500 }, { "Registration", 1000 }, { "Lab", 1500 }, { "Sports", 2000 }, { "Library", 2000 }, { "Computer", 3000 }, { "Exam", 3000 }, { "Development", 3000 } } },
            { "Class 5", new Dictionary<string, decimal> { { "Admission", 5000 }, { "Registration", 1000 }, { "Lab", 2000 }, { "Sports", 2000 }, { "Library", 2000 }, { "Computer", 3500 }, { "Exam", 3500 }, { "Development", 3000 } } },
            { "Class 6", new Dictionary<string, decimal> { { "Admission", 5500 }, { "Registration", 1000 }, { "Lab", 2500 }, { "Sports", 2500 }, { "Library", 2000 }, { "Computer", 4000 }, { "Exam", 3500 }, { "Development", 3000 } } },
            { "Class 7", new Dictionary<string, decimal> { { "Admission", 5500 }, { "Registration", 1000 }, { "Lab", 2500 }, { "Sports", 2500 }, { "Library", 2000 }, { "Computer", 4000 }, { "Exam", 3500 }, { "Development", 3000 } } },
            { "Class 8", new Dictionary<string, decimal> { { "Admission", 6000 }, { "Registration", 1000 }, { "Lab", 3000 }, { "Sports", 2500 }, { "Library", 2500 }, { "Computer", 4500 }, { "Exam", 3500 }, { "Development", 3000 } } },
            { "Class 9", new Dictionary<string, decimal> { { "Admission", 7000 }, { "Registration", 1500 }, { "Lab", 4000 }, { "Sports", 3000 }, { "Library", 2500 }, { "Computer", 5000 }, { "Exam", 4000 }, { "Development", 3000 } } },
            { "Class 10", new Dictionary<string, decimal> { { "Admission", 7000 }, { "Registration", 1500 }, { "Lab", 4000 }, { "Sports", 3000 }, { "Library", 2500 }, { "Computer", 5000 }, { "Exam", 4000 }, { "Development", 3000 } } }
        };

        private readonly string[] classes = {
            "Nursery", "Prep", "Class 1", "Class 2", "Class 3", "Class 4",
            "Class 5", "Class 6", "Class 7", "Class 8", "Class 9", "Class 10"
        };

        private readonly string[] sections = { "A", "B", "C", "D" };

        public SubmitAnnualFeeForm()
        {
            InitializeComponent();
            GenerateSampleData();
            SetupForm();
            SetupEventHandlers();
        }

        private void GenerateSampleData()
        {
            string[] firstNames = { "Ahmed", "Fatima", "Muhammad", "Ayesha", "Hassan", "Sara", "Ali", "Zainab", "Imran", "Mariam",
                                   "Bilal", "Hira", "Umar", "Amina", "Khalid", "Nadia", "Rashid", "Sana", "Waqar", "Mehreen",
                                   "Farhan", "Rabia", "Tariq", "Samina", "Jawad", "Asma", "Hamza", "Noor", "Faisal", "Maryam" };
            string[] lastNames = { "Khan", "Ali", "Ahmed", "Malik", "Raza", "Hussain", "Sheikh", "Bibi", "Farooq", "Iqbal",
                                  "Qureshi", "Siddiqui", "Chaudhry", "Mirza", "Butt" };

            Random rand = new Random(42);
            int admissionCounter = 1001;

            // Current academic year
            int academicYear = currentDate.Month >= ACADEMIC_YEAR_START_MONTH ? currentDate.Year : currentDate.Year - 1;
            DateTime dueDate = new DateTime(academicYear, ACADEMIC_YEAR_START_MONTH, ANNUAL_FEE_DUE_DAY);

            foreach (var className in classes)
            {
                foreach (var section in new[] { "A", "B" })
                {
                    int studentCount = rand.Next(15, 25);
                    decimal baseFee = classAnnualFees[className];

                    for (int i = 0; i < studentCount; i++)
                    {
                        string firstName = firstNames[rand.Next(firstNames.Length)];
                        string lastName = lastNames[rand.Next(lastNames.Length)];
                        string name = $"{firstName} {lastName}";
                        string admNo = $"ADM-2024-{admissionCounter++}";
                        int rollNo = i + 1;

                        // Random scholarship (15% have scholarship)
                        bool hasScholarship = rand.Next(7) == 0;
                        decimal fee = hasScholarship ? baseFee * 0.75m : baseFee; // 25% scholarship

                        // Random payment status (40% already paid)
                        bool isPaid = rand.Next(5) < 2;

                        // Random partial payment for some unpaid students
                        decimal amountPaid = 0;
                        if (!isPaid && rand.Next(3) == 0)
                        {
                            // Partial payment (25%, 50%, or 75%)
                            int[] partialOptions = { 25, 50, 75 };
                            int partialPercent = partialOptions[rand.Next(partialOptions.Length)];
                            amountPaid = fee * partialPercent / 100;
                        }
                        else if (isPaid)
                        {
                            amountPaid = fee;
                        }

                        students.Add(new StudentAnnualFeeRecord(
                            admNo, name, className, section, rollNo,
                            fee, amountPaid, hasScholarship, isPaid, dueDate
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

            // Setup payment status filter
            cmbPaymentStatus.Items.AddRange(new string[] { "All Students", "Unpaid/Partial", "Fully Paid" });
            cmbPaymentStatus.SelectedIndex = 1; // Default to unpaid

            // Setup sort options
            cmbSort.Items.AddRange(new string[] { "Name (A-Z)", "Name (Z-A)", "Roll Number", "Amount Due (High-Low)", "Amount Due (Low-High)", "Payment Status" });
            cmbSort.SelectedIndex = 0;

            // Update academic year display
            UpdateAcademicYearDisplay();
        }

        private void SetupEventHandlers()
        {
            // Filter events
            cmbClass.SelectedIndexChanged += Filter_Changed;
            cmbSection.SelectedIndexChanged += Filter_Changed;
            cmbPaymentStatus.SelectedIndexChanged += Filter_Changed;
            cmbSort.SelectedIndexChanged += Filter_Changed;
            txtSearch.TextChanged += Filter_Changed;
            txtRollNumber.TextChanged += Filter_Changed;

            // Button events
            btnLoadStudents.Click += BtnLoadStudents_Click;
            btnSelectAll.Click += BtnSelectAll_Click;
            btnDeselectAll.Click += BtnDeselectAll_Click;
            btnSubmitSelected.Click += BtnSubmitSelected_Click;
            btnViewBreakdown.Click += BtnViewBreakdown_Click;

            // DataGridView events
            dgvStudents.CellValueChanged += DgvStudents_CellValueChanged;
            dgvStudents.CellContentClick += DgvStudents_CellContentClick;
            dgvStudents.CurrentCellDirtyStateChanged += DgvStudents_CurrentCellDirtyStateChanged;
            dgvStudents.CellDoubleClick += DgvStudents_CellDoubleClick;

            // Hover effects
            SetupButtonHoverEffects(btnLoadStudents, Color.FromArgb(41, 128, 185), Color.FromArgb(52, 152, 219));
            SetupButtonHoverEffects(btnSelectAll, Color.FromArgb(39, 174, 96), Color.FromArgb(46, 204, 113));
            SetupButtonHoverEffects(btnDeselectAll, Color.FromArgb(149, 165, 166), Color.FromArgb(189, 195, 199));
            SetupButtonHoverEffects(btnSubmitSelected, Color.FromArgb(39, 174, 96), Color.FromArgb(46, 204, 113));
            SetupButtonHoverEffects(btnViewBreakdown, Color.FromArgb(155, 89, 182), Color.FromArgb(175, 122, 197));
        }

        private void SetupButtonHoverEffects(Button btn, Color normalColor, Color hoverColor)
        {
            btn.MouseEnter += (s, e) => btn.BackColor = hoverColor;
            btn.MouseLeave += (s, e) => btn.BackColor = normalColor;
        }

        private void UpdateAcademicYearDisplay()
        {
            int academicYear = currentDate.Month >= ACADEMIC_YEAR_START_MONTH ? currentDate.Year : currentDate.Year - 1;
            DateTime dueDate = new DateTime(academicYear, ACADEMIC_YEAR_START_MONTH, ANNUAL_FEE_DUE_DAY);

            lblAcademicYear.Text = $"📅 Academic Year: {academicYear}-{academicYear + 1}";
            lblDueDate.Text = $"Due Date: {dueDate:dd MMM yyyy}";

            // Calculate days overdue/remaining
            if (currentDate > dueDate)
            {
                int daysOverdue = (currentDate - dueDate).Days;
                lblOverdueInfo.Text = $"⚠ {daysOverdue} days past due date";
                lblOverdueInfo.ForeColor = Color.FromArgb(192, 57, 43);
            }
            else
            {
                int daysRemaining = (dueDate - currentDate).Days;
                lblOverdueInfo.Text = $"✓ {daysRemaining} days remaining";
                lblOverdueInfo.ForeColor = Color.FromArgb(39, 174, 96);
            }
        }

        private void LoadStudentsToGrid()
        {
            dgvStudents.Rows.Clear();

            string classFilter = cmbClass.SelectedItem?.ToString() ?? "All Classes";
            string sectionFilter = cmbSection.SelectedItem?.ToString() ?? "All Sections";
            string statusFilter = cmbPaymentStatus.SelectedItem?.ToString() ?? "All Students";
            string searchText = txtSearch.Text.ToLower().Trim();
            string rollNumberText = txtRollNumber.Text.Trim();
            string sortOption = cmbSort.SelectedItem?.ToString() ?? "Name (A-Z)";

            var filteredStudents = students.Where(s =>
            {
                bool matchesClass = classFilter == "All Classes" || s.ClassName == classFilter;
                bool matchesSection = sectionFilter == "All Sections" || s.Section == sectionFilter;
                bool matchesStatus = statusFilter == "All Students" ||
                    (statusFilter == "Unpaid/Partial" && !s.IsFullyPaid) ||
                    (statusFilter == "Fully Paid" && s.IsFullyPaid);
                bool matchesSearch = string.IsNullOrEmpty(searchText) ||
                    s.StudentName.ToLower().Contains(searchText) ||
                    s.AdmissionNo.ToLower().Contains(searchText);
                bool matchesRollNo = string.IsNullOrEmpty(rollNumberText) ||
                    s.RollNo.ToString() == rollNumberText;

                return matchesClass && matchesSection && matchesStatus && matchesSearch && matchesRollNo;
            });

            // Apply sorting
            filteredStudents = sortOption switch
            {
                "Name (A-Z)" => filteredStudents.OrderBy(s => s.StudentName),
                "Name (Z-A)" => filteredStudents.OrderByDescending(s => s.StudentName),
                "Roll Number" => filteredStudents.OrderBy(s => s.ClassName).ThenBy(s => s.Section).ThenBy(s => s.RollNo),
                "Amount Due (High-Low)" => filteredStudents.OrderByDescending(s => s.AmountDue),
                "Amount Due (Low-High)" => filteredStudents.OrderBy(s => s.AmountDue),
                "Payment Status" => filteredStudents.OrderBy(s => s.IsFullyPaid).ThenByDescending(s => s.AmountDue),
                _ => filteredStudents.OrderBy(s => s.StudentName)
            };

            foreach (var student in filteredStudents)
            {
                string paymentStatus;
                if (student.IsFullyPaid)
                    paymentStatus = "✓ Paid";
                else if (student.AmountPaid > 0)
                    paymentStatus = $"Partial ({student.AmountPaid / student.AnnualFee * 100:F0}%)";
                else
                    paymentStatus = "Unpaid";

                int rowIndex = dgvStudents.Rows.Add(
                    false, // Checkbox
                    student.AdmissionNo,
                    student.StudentName,
                    student.ClassName,
                    student.Section,
                    student.RollNo,
                    $"Rs. {student.AnnualFee:N0}",
                    $"Rs. {student.AmountPaid:N0}",
                    $"Rs. {student.AmountDue:N0}",
                    paymentStatus,
                    student.HasScholarship ? "25% Off" : "-"
                );

                // Style the row based on payment status
                DataGridViewRow row = dgvStudents.Rows[rowIndex];

                if (student.IsFullyPaid)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(232, 245, 233);
                    row.Cells["colStatus"].Style.ForeColor = Color.FromArgb(39, 174, 96);
                    row.Cells["colStatus"].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    row.Cells["colSelect"].Value = false;
                    row.Cells["colSelect"].ReadOnly = true;
                }
                else if (student.AmountPaid > 0)
                {
                    // Partial payment - orange highlight
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 248, 225);
                    row.Cells["colAmountDue"].Style.ForeColor = Color.FromArgb(230, 126, 34);
                    row.Cells["colAmountDue"].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    row.Cells["colStatus"].Style.ForeColor = Color.FromArgb(230, 126, 34);
                    row.Cells["colStatus"].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
                else
                {
                    // Fully unpaid - red highlight
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 238);
                    row.Cells["colAmountDue"].Style.ForeColor = Color.FromArgb(192, 57, 43);
                    row.Cells["colAmountDue"].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    row.Cells["colStatus"].Style.ForeColor = Color.FromArgb(192, 57, 43);
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
            decimal totalAmountDue = 0;
            decimal selectedAmountDue = 0;
            int paidCount = 0;
            int unpaidCount = 0;
            int partialCount = 0;

            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["colSelect"].Value);
                string status = row.Cells["colStatus"].Value?.ToString() ?? "";
                string amountDueStr = row.Cells["colAmountDue"].Value?.ToString()?.Replace("Rs. ", "").Replace(",", "") ?? "0";
                decimal amountDue = decimal.TryParse(amountDueStr, out decimal d) ? d : 0;

                totalAmountDue += amountDue;

                if (status.Contains("Paid") && status.Contains("✓"))
                {
                    paidCount++;
                }
                else if (status.Contains("Partial"))
                {
                    partialCount++;
                    if (isSelected)
                    {
                        selectedCount++;
                        selectedAmountDue += amountDue;
                    }
                }
                else
                {
                    unpaidCount++;
                    if (isSelected)
                    {
                        selectedCount++;
                        selectedAmountDue += amountDue;
                    }
                }
            }

            lblTotalStudents.Text = totalStudents.ToString();
            lblPaidCount.Text = paidCount.ToString();
            lblPartialCount.Text = partialCount.ToString();
            lblUnpaidCount.Text = unpaidCount.ToString();
            lblSelectedCount.Text = selectedCount.ToString();
            lblTotalAmountDue.Text = $"Rs. {totalAmountDue:N0}";
            lblSelectedAmount.Text = $"Rs. {selectedAmountDue:N0}";

            btnSubmitSelected.Enabled = selectedCount > 0;
            btnSubmitSelected.Text = selectedCount > 0
                ? $"💳 Submit Annual Fee ({selectedCount})"
                : "💳 Submit Annual Fee";
        }

        #region Event Handlers

        private void Filter_Changed(object? sender, EventArgs e)
        {
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
                string status = row.Cells["colStatus"].Value?.ToString() ?? "";
                if (!status.Contains("✓"))
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

        private void BtnViewBreakdown_Click(object? sender, EventArgs e)
        {
            string selectedClass = cmbClass.SelectedItem?.ToString() ?? "Nursery";
            if (selectedClass == "All Classes")
                selectedClass = "Nursery";

            ShowFeeBreakdownDialog(selectedClass);
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
            // Handled by CurrentCellDirtyStateChanged
        }

        private void DgvStudents_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvStudents.Columns["colSelect"] != null && e.ColumnIndex == dgvStudents.Columns["colSelect"]!.Index)
            {
                UpdateSummary();
            }
        }

        private void DgvStudents_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string admNo = dgvStudents.Rows[e.RowIndex].Cells["colAdmissionNo"].Value?.ToString() ?? "";
                var student = students.FirstOrDefault(s => s.AdmissionNo == admNo);
                if (student != null)
                {
                    ShowStudentDetailsDialog(student);
                }
            }
        }

        private void BtnSubmitSelected_Click(object? sender, EventArgs e)
        {
            List<(string AdmNo, string Name, decimal AmountDue)> selectedStudents = new List<(string, string, decimal)>();

            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                if (Convert.ToBoolean(row.Cells["colSelect"].Value))
                {
                    string admNo = row.Cells["colAdmissionNo"].Value?.ToString() ?? "";
                    string name = row.Cells["colStudentName"].Value?.ToString() ?? "";
                    string amountStr = row.Cells["colAmountDue"].Value?.ToString()?.Replace("Rs. ", "").Replace(",", "") ?? "0";
                    decimal amount = decimal.TryParse(amountStr, out decimal a) ? a : 0;

                    selectedStudents.Add((admNo, name, amount));
                }
            }

            if (selectedStudents.Count == 0)
            {
                MessageBox.Show("Please select at least one student to submit annual fee.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal grandTotal = selectedStudents.Sum(s => s.AmountDue);

            using (Form confirmDialog = CreateConfirmationDialog(selectedStudents, grandTotal))
            {
                if (confirmDialog.ShowDialog(this) == DialogResult.Yes)
                {
                    ProcessAnnualFeeSubmission(selectedStudents, grandTotal);
                }
            }
        }

        #endregion

        private void ShowFeeBreakdownDialog(string className)
        {
            Form dialog = new Form
            {
                Text = $"Annual Fee Breakdown - {className}",
                Size = new Size(450, 450),
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
                Height = 60,
                BackColor = Color.FromArgb(155, 89, 182)
            };

            Label lblTitle = new Label
            {
                Text = $"📋 Fee Breakdown - {className}",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(20, 15),
                AutoSize = true
            };

            headerPanel.Controls.Add(lblTitle);

            // Fee breakdown list
            ListView lvBreakdown = new ListView
            {
                Location = new Point(20, 75),
                Size = new Size(395, 250),
                View = View.Details,
                FullRowSelect = true,
                GridLines = true,
                Font = new Font("Segoe UI", 10)
            };

            lvBreakdown.Columns.Add("Fee Component", 250);
            lvBreakdown.Columns.Add("Amount (Rs.)", 120, HorizontalAlignment.Right);

            if (feeBreakdown.ContainsKey(className))
            {
                decimal total = 0;
                foreach (var component in feeBreakdown[className])
                {
                    if (component.Value > 0)
                    {
                        lvBreakdown.Items.Add(new ListViewItem(new[] { component.Key + " Fee", component.Value.ToString("N0") }));
                        total += component.Value;
                    }
                }

                // Add total row
                ListViewItem totalItem = new ListViewItem(new[] { "TOTAL", total.ToString("N0") });
                totalItem.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                totalItem.BackColor = Color.FromArgb(232, 245, 233);
                lvBreakdown.Items.Add(totalItem);
            }

            // Scholarship info
            Label lblScholarship = new Label
            {
                Text = "💡 Students with scholarship receive 25% discount on total annual fee.",
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.FromArgb(127, 140, 141),
                Location = new Point(20, 335),
                Size = new Size(395, 20)
            };

            // Close button
            Button btnClose = new Button
            {
                Text = "Close",
                Size = new Size(100, 40),
                Location = new Point(315, 360),
                BackColor = Color.FromArgb(149, 165, 166),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Cursor = Cursors.Hand,
                DialogResult = DialogResult.OK
            };
            btnClose.FlatAppearance.BorderSize = 0;

            dialog.Controls.Add(headerPanel);
            dialog.Controls.Add(lvBreakdown);
            dialog.Controls.Add(lblScholarship);
            dialog.Controls.Add(btnClose);

            dialog.ShowDialog(this);
        }

        private void ShowStudentDetailsDialog(StudentAnnualFeeRecord student)
        {
            Form dialog = new Form
            {
                Text = $"Student Details - {student.StudentName}",
                Size = new Size(450, 400),
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
                BackColor = Color.FromArgb(41, 128, 185)
            };

            Label lblIcon = new Label
            {
                Text = "👤",
                Font = new Font("Segoe UI", 28),
                ForeColor = Color.White,
                Location = new Point(15, 8),
                AutoSize = true
            };

            Label lblTitle = new Label
            {
                Text = student.StudentName,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(70, 12),
                AutoSize = true
            };

            Label lblAdmNo = new Label
            {
                Text = student.AdmissionNo,
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.FromArgb(200, 230, 255),
                Location = new Point(72, 40),
                AutoSize = true
            };

            headerPanel.Controls.Add(lblIcon);
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Controls.Add(lblAdmNo);

            // Details
            int yPos = 85;
            string[] labels = { "Class:", "Section:", "Roll Number:", "Annual Fee:", "Amount Paid:", "Amount Due:", "Scholarship:", "Status:" };
            string[] values = {
                student.ClassName,
                student.Section,
                student.RollNo.ToString(),
                $"Rs. {student.AnnualFee:N0}",
                $"Rs. {student.AmountPaid:N0}",
                $"Rs. {student.AmountDue:N0}",
                student.HasScholarship ? "25% Discount" : "None",
                student.IsFullyPaid ? "Fully Paid" : (student.AmountPaid > 0 ? $"Partial ({student.AmountPaid / student.AnnualFee * 100:F0}%)" : "Unpaid")
            };

            for (int i = 0; i < labels.Length; i++)
            {
                Label lbl = new Label
                {
                    Text = labels[i],
                    Font = new Font("Segoe UI", 10),
                    ForeColor = Color.FromArgb(127, 140, 141),
                    Location = new Point(30, yPos),
                    Size = new Size(120, 25)
                };

                Label val = new Label
                {
                    Text = values[i],
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = Color.FromArgb(44, 62, 80),
                    Location = new Point(160, yPos),
                    AutoSize = true
                };

                // Color coding for status
                if (labels[i] == "Amount Due:" && student.AmountDue > 0)
                {
                    val.ForeColor = Color.FromArgb(192, 57, 43);
                }
                else if (labels[i] == "Status:")
                {
                    val.ForeColor = student.IsFullyPaid ? Color.FromArgb(39, 174, 96) :
                                   (student.AmountPaid > 0 ? Color.FromArgb(230, 126, 34) : Color.FromArgb(192, 57, 43));
                }

                dialog.Controls.Add(lbl);
                dialog.Controls.Add(val);
                yPos += 32;
            }

            // Close button
            Button btnClose = new Button
            {
                Text = "Close",
                Size = new Size(100, 40),
                Location = new Point(320, 315),
                BackColor = Color.FromArgb(149, 165, 166),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Cursor = Cursors.Hand,
                DialogResult = DialogResult.OK
            };
            btnClose.FlatAppearance.BorderSize = 0;

            dialog.Controls.Add(headerPanel);
            dialog.Controls.Add(btnClose);

            dialog.ShowDialog(this);
        }

        private Form CreateConfirmationDialog(List<(string AdmNo, string Name, decimal AmountDue)> selectedStudents, decimal grandTotal)
        {
            Form dialog = new Form
            {
                Text = "Confirm Annual Fee Submission",
                Size = new Size(600, 550),
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
                Text = "Confirm Annual Fee Submission",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(75, 8),
                AutoSize = true
            };

            int academicYear = currentDate.Month >= ACADEMIC_YEAR_START_MONTH ? currentDate.Year : currentDate.Year - 1;
            Label lblSubtitle = new Label
            {
                Text = $"Academic Year {academicYear}-{academicYear + 1}",
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.FromArgb(200, 255, 200),
                Location = new Point(77, 40),
                AutoSize = true
            };

            headerPanel.Controls.Add(lblIcon);
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Controls.Add(lblSubtitle);

            // Summary panel
            Panel summaryPanel = new Panel
            {
                Location = new Point(20, 85),
                Size = new Size(545, 70),
                BackColor = Color.FromArgb(245, 247, 250)
            };

            Label lblSummary = new Label
            {
                Text = $"📋 {selectedStudents.Count} Student(s) Selected",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location = new Point(15, 10),
                AutoSize = true
            };

            Label lblTotalAmount = new Label
            {
                Text = $"Grand Total: Rs. {grandTotal:N0}",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(39, 174, 96),
                Location = new Point(15, 35),
                AutoSize = true
            };

            summaryPanel.Controls.Add(lblSummary);
            summaryPanel.Controls.Add(lblTotalAmount);

            // Students list
            Label lblStudentsList = new Label
            {
                Text = "Selected Students:",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94),
                Location = new Point(20, 165),
                AutoSize = true
            };

            ListView lvStudents = new ListView
            {
                Location = new Point(20, 185),
                Size = new Size(545, 230),
                View = View.Details,
                FullRowSelect = true,
                GridLines = true,
                Font = new Font("Segoe UI", 9)
            };

            lvStudents.Columns.Add("Admission #", 120);
            lvStudents.Columns.Add("Student Name", 250);
            lvStudents.Columns.Add("Amount Due", 150, HorizontalAlignment.Right);

            foreach (var student in selectedStudents)
            {
                lvStudents.Items.Add(new ListViewItem(new[] { student.AdmNo, student.Name, $"Rs. {student.AmountDue:N0}" }));
            }

            // Warning
            Label lblWarning = new Label
            {
                Text = "⚠ This action will mark the selected students' annual fee as fully paid.",
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.FromArgb(230, 126, 34),
                Location = new Point(20, 425),
                Size = new Size(545, 20)
            };

            // Buttons
            Button btnConfirm = new Button
            {
                Text = "✓ Confirm Payment",
                Size = new Size(160, 45),
                Location = new Point(280, 455),
                BackColor = Color.FromArgb(39, 174, 96),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Cursor = Cursors.Hand,
                DialogResult = DialogResult.Yes
            };
            btnConfirm.FlatAppearance.BorderSize = 0;

            Button btnCancel = new Button
            {
                Text = "Cancel",
                Size = new Size(100, 45),
                Location = new Point(450, 455),
                BackColor = Color.FromArgb(149, 165, 166),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Cursor = Cursors.Hand,
                DialogResult = DialogResult.No
            };
            btnCancel.FlatAppearance.BorderSize = 0;

            dialog.Controls.Add(headerPanel);
            dialog.Controls.Add(summaryPanel);
            dialog.Controls.Add(lblStudentsList);
            dialog.Controls.Add(lvStudents);
            dialog.Controls.Add(lblWarning);
            dialog.Controls.Add(btnConfirm);
            dialog.Controls.Add(btnCancel);

            return dialog;
        }

        private void ProcessAnnualFeeSubmission(List<(string AdmNo, string Name, decimal AmountDue)> selectedStudents, decimal grandTotal)
        {
            // Update payment status for selected students
            foreach (var selected in selectedStudents)
            {
                var student = students.FirstOrDefault(s => s.AdmissionNo == selected.AdmNo);
                if (student != null)
                {
                    student.AmountPaid = student.AnnualFee;
                    student.IsFullyPaid = true;
                }
            }

            int academicYear = currentDate.Month >= ACADEMIC_YEAR_START_MONTH ? currentDate.Year : currentDate.Year - 1;

            // Show success message
            MessageBox.Show(
                $"Annual Fee Submission Successful!\n\n" +
                $"Academic Year: {academicYear}-{academicYear + 1}\n" +
                $"Students: {selectedStudents.Count}\n" +
                $"Total Amount: Rs. {grandTotal:N0}\n\n" +
                $"Receipt numbers have been generated and recorded.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Reload grid
            LoadStudentsToGrid();
        }
    }

    /// <summary>
    /// Student annual fee record
    /// </summary>
    public class StudentAnnualFeeRecord
    {
        public string AdmissionNo { get; set; }
        public string StudentName { get; set; }
        public string ClassName { get; set; }
        public string Section { get; set; }
        public int RollNo { get; set; }
        public decimal AnnualFee { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal AmountDue => AnnualFee - AmountPaid;
        public bool HasScholarship { get; set; }
        public bool IsFullyPaid { get; set; }
        public DateTime DueDate { get; set; }

        public StudentAnnualFeeRecord(string admissionNo, string studentName, string className,
            string section, int rollNo, decimal annualFee, decimal amountPaid, bool hasScholarship,
            bool isFullyPaid, DateTime dueDate)
        {
            AdmissionNo = admissionNo;
            StudentName = studentName;
            ClassName = className;
            Section = section;
            RollNo = rollNo;
            AnnualFee = annualFee;
            AmountPaid = amountPaid;
            HasScholarship = hasScholarship;
            IsFullyPaid = isFullyPaid;
            DueDate = dueDate;
        }
    }
}
