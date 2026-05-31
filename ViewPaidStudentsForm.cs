using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManagementSystem
{
    public partial class ViewPaidStudentsForm : Form
    {
        // Sample paid fee records
        private List<PaidFeeRecord> paidRecords = new List<PaidFeeRecord>();

        private readonly string[] classes = {
            "Nursery", "Prep", "Class 1", "Class 2", "Class 3", "Class 4",
            "Class 5", "Class 6", "Class 7", "Class 8", "Class 9", "Class 10"
        };

        private readonly string[] sections = { "A", "B", "C", "D" };

        // Statistics
        private decimal totalMonthlyCollected = 0;
        private decimal totalAnnualCollected = 0;
        private int totalMonthlyPayments = 0;
        private int totalAnnualPayments = 0;

        public ViewPaidStudentsForm()
        {
            InitializeComponent();
            GenerateSampleData();
            SetupForm();
            SetupEventHandlers();
            LoadPaidRecordsToGrid();
        }

        private void GenerateSampleData()
        {
            string[] firstNames = { "Ahmed", "Fatima", "Muhammad", "Ayesha", "Hassan", "Sara", "Ali", "Zainab", "Imran", "Mariam",
                                   "Bilal", "Hira", "Umar", "Amina", "Khalid", "Nadia", "Rashid", "Sana", "Waqar", "Mehreen",
                                   "Farhan", "Rabia", "Tariq", "Samina", "Jawad", "Asma", "Hamza", "Noor", "Faisal", "Maryam" };
            string[] lastNames = { "Khan", "Ali", "Ahmed", "Malik", "Raza", "Hussain", "Sheikh", "Bibi", "Farooq", "Iqbal",
                                  "Qureshi", "Siddiqui", "Chaudhry", "Mirza", "Butt" };

            // Monthly fee structure
            Dictionary<string, decimal> monthlyFees = new Dictionary<string, decimal>
            {
                { "Nursery", 2000 }, { "Prep", 2200 }, { "Class 1", 2500 }, { "Class 2", 2500 },
                { "Class 3", 2800 }, { "Class 4", 2800 }, { "Class 5", 3000 }, { "Class 6", 3200 },
                { "Class 7", 3200 }, { "Class 8", 3500 }, { "Class 9", 4000 }, { "Class 10", 4000 }
            };

            // Annual fee structure
            Dictionary<string, decimal> annualFees = new Dictionary<string, decimal>
            {
                { "Nursery", 15000 }, { "Prep", 16500 }, { "Class 1", 18000 }, { "Class 2", 18000 },
                { "Class 3", 20000 }, { "Class 4", 20000 }, { "Class 5", 22000 }, { "Class 6", 24000 },
                { "Class 7", 24000 }, { "Class 8", 26000 }, { "Class 9", 30000 }, { "Class 10", 30000 }
            };

            Random rand = new Random(42);
            int receiptCounter = 10001;
            int admissionCounter = 1001;

            // Generate paid records for the current academic year
            DateTime currentDate = DateTime.Now;
            string[] months = { "January", "February", "March", "April", "May", "June", 
                               "July", "August", "September", "October", "November", "December" };

            foreach (var className in classes)
            {
                foreach (var section in new[] { "A", "B" })
                {
                    int studentCount = rand.Next(15, 25);

                    for (int i = 0; i < studentCount; i++)
                    {
                        string firstName = firstNames[rand.Next(firstNames.Length)];
                        string lastName = lastNames[rand.Next(lastNames.Length)];
                        string name = $"{firstName} {lastName}";
                        string admNo = $"ADM-2024-{admissionCounter++}";
                        int rollNo = i + 1;

                        // Random scholarship
                        bool hasScholarship = rand.Next(7) == 0;
                        decimal monthlyFee = hasScholarship ? monthlyFees[className] * 0.8m : monthlyFees[className];
                        decimal annualFee = hasScholarship ? annualFees[className] * 0.75m : annualFees[className];

                        // Generate monthly fee payments (random months paid)
                        int monthsPaid = rand.Next(3, 12); // 3 to 11 months paid
                        for (int m = 0; m < monthsPaid; m++)
                        {
                            int monthIndex = rand.Next(0, currentDate.Month);
                            DateTime paymentDate = new DateTime(currentDate.Year, monthIndex + 1, rand.Next(1, 28));
                            
                            // Skip if already added this month for this student
                            if (paidRecords.Any(r => r.AdmissionNo == admNo && r.FeeType == "Monthly" && r.FeeMonth == months[monthIndex]))
                                continue;

                            decimal lateFine = paymentDate.Day > 10 ? (paymentDate.Day - 10) * 50 : 0;

                            paidRecords.Add(new PaidFeeRecord(
                                $"RCP-{receiptCounter++}",
                                admNo,
                                name,
                                className,
                                section,
                                rollNo,
                                "Monthly",
                                months[monthIndex],
                                monthlyFee,
                                lateFine,
                                monthlyFee + lateFine,
                                paymentDate,
                                hasScholarship ? "20%" : "-",
                                "Cash"
                            ));

                            totalMonthlyCollected += monthlyFee + lateFine;
                            totalMonthlyPayments++;
                        }

                        // Generate annual fee payment (40% have paid)
                        if (rand.Next(5) < 2)
                        {
                            DateTime annualPaymentDate = new DateTime(currentDate.Year, 4, rand.Next(1, 28));

                            paidRecords.Add(new PaidFeeRecord(
                                $"RCP-{receiptCounter++}",
                                admNo,
                                name,
                                className,
                                section,
                                rollNo,
                                "Annual",
                                $"{currentDate.Year}-{currentDate.Year + 1}",
                                annualFee,
                                0,
                                annualFee,
                                annualPaymentDate,
                                hasScholarship ? "25%" : "-",
                                rand.Next(2) == 0 ? "Cash" : "Bank Transfer"
                            ));

                            totalAnnualCollected += annualFee;
                            totalAnnualPayments++;
                        }
                    }
                }
            }

            // Sort by payment date descending (most recent first)
            paidRecords = paidRecords.OrderByDescending(r => r.PaymentDate).ToList();
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

            // Setup fee type filter
            cmbFeeType.Items.AddRange(new string[] { "All Types", "Monthly", "Annual" });
            cmbFeeType.SelectedIndex = 0;

            // Setup sort options
            cmbSort.Items.AddRange(new string[] { 
                "Payment Date (Recent)", 
                "Payment Date (Oldest)", 
                "Student Name (A-Z)", 
                "Student Name (Z-A)",
                "Amount (High-Low)",
                "Amount (Low-High)",
                "Class",
                "Roll Number"
            });
            cmbSort.SelectedIndex = 0;

            // Setup month filter
            cmbMonth.Items.Add("All Months");
            cmbMonth.Items.AddRange(new string[] { "January", "February", "March", "April", "May", "June",
                                                   "July", "August", "September", "October", "November", "December" });
            cmbMonth.SelectedIndex = 0;

            // Update statistics
            UpdateStatistics();
        }

        private void SetupEventHandlers()
        {
            // Filter events
            cmbClass.SelectedIndexChanged += Filter_Changed;
            cmbSection.SelectedIndexChanged += Filter_Changed;
            cmbFeeType.SelectedIndexChanged += Filter_Changed;
            cmbSort.SelectedIndexChanged += Filter_Changed;
            cmbMonth.SelectedIndexChanged += Filter_Changed;
            txtSearch.TextChanged += Filter_Changed;
            txtRollNumber.TextChanged += Filter_Changed;

            // Button events
            btnRefresh.Click += BtnRefresh_Click;
            btnExport.Click += BtnExport_Click;
            btnPrintReceipt.Click += BtnPrintReceipt_Click;

            // DataGridView events
            dgvPaidStudents.CellDoubleClick += DgvPaidStudents_CellDoubleClick;
            dgvPaidStudents.SelectionChanged += DgvPaidStudents_SelectionChanged;

            // Hover effects
            SetupButtonHoverEffects(btnRefresh, Color.FromArgb(52, 73, 94), Color.FromArgb(74, 90, 107));
            SetupButtonHoverEffects(btnExport, Color.FromArgb(39, 174, 96), Color.FromArgb(46, 204, 113));
            SetupButtonHoverEffects(btnPrintReceipt, Color.FromArgb(41, 128, 185), Color.FromArgb(52, 152, 219));
        }

        private void SetupButtonHoverEffects(Button btn, Color normalColor, Color hoverColor)
        {
            btn.MouseEnter += (s, e) => btn.BackColor = hoverColor;
            btn.MouseLeave += (s, e) => btn.BackColor = normalColor;
        }

        private void UpdateStatistics()
        {
            lblTotalPayments.Text = paidRecords.Count.ToString("N0");
            lblMonthlyPayments.Text = totalMonthlyPayments.ToString("N0");
            lblAnnualPayments.Text = totalAnnualPayments.ToString("N0");
            lblTotalCollected.Text = $"Rs. {(totalMonthlyCollected + totalAnnualCollected):N0}";
        }

        private void LoadPaidRecordsToGrid()
        {
            dgvPaidStudents.Rows.Clear();

            string classFilter = cmbClass.SelectedItem?.ToString() ?? "All Classes";
            string sectionFilter = cmbSection.SelectedItem?.ToString() ?? "All Sections";
            string feeTypeFilter = cmbFeeType.SelectedItem?.ToString() ?? "All Types";
            string monthFilter = cmbMonth.SelectedItem?.ToString() ?? "All Months";
            string searchText = txtSearch.Text.ToLower().Trim();
            string rollNumberText = txtRollNumber.Text.Trim();
            string sortOption = cmbSort.SelectedItem?.ToString() ?? "Payment Date (Recent)";

            var filteredRecords = paidRecords.Where(r =>
            {
                bool matchesClass = classFilter == "All Classes" || r.ClassName == classFilter;
                bool matchesSection = sectionFilter == "All Sections" || r.Section == sectionFilter;
                bool matchesFeeType = feeTypeFilter == "All Types" || r.FeeType == feeTypeFilter;
                bool matchesMonth = monthFilter == "All Months" || r.FeeMonth.Contains(monthFilter);
                bool matchesSearch = string.IsNullOrEmpty(searchText) ||
                    r.StudentName.ToLower().Contains(searchText) ||
                    r.AdmissionNo.ToLower().Contains(searchText) ||
                    r.ReceiptNo.ToLower().Contains(searchText);
                bool matchesRollNo = string.IsNullOrEmpty(rollNumberText) ||
                    r.RollNo.ToString() == rollNumberText;

                return matchesClass && matchesSection && matchesFeeType && matchesMonth && matchesSearch && matchesRollNo;
            });

            // Apply sorting
            filteredRecords = sortOption switch
            {
                "Payment Date (Recent)" => filteredRecords.OrderByDescending(r => r.PaymentDate),
                "Payment Date (Oldest)" => filteredRecords.OrderBy(r => r.PaymentDate),
                "Student Name (A-Z)" => filteredRecords.OrderBy(r => r.StudentName),
                "Student Name (Z-A)" => filteredRecords.OrderByDescending(r => r.StudentName),
                "Amount (High-Low)" => filteredRecords.OrderByDescending(r => r.TotalPaid),
                "Amount (Low-High)" => filteredRecords.OrderBy(r => r.TotalPaid),
                "Class" => filteredRecords.OrderBy(r => Array.IndexOf(classes, r.ClassName)).ThenBy(r => r.Section).ThenBy(r => r.RollNo),
                "Roll Number" => filteredRecords.OrderBy(r => r.ClassName).ThenBy(r => r.Section).ThenBy(r => r.RollNo),
                _ => filteredRecords.OrderByDescending(r => r.PaymentDate)
            };

            decimal filteredTotal = 0;

            foreach (var record in filteredRecords)
            {
                int rowIndex = dgvPaidStudents.Rows.Add(
                    record.ReceiptNo,
                    record.AdmissionNo,
                    record.StudentName,
                    record.ClassName,
                    record.Section,
                    record.RollNo,
                    record.FeeType,
                    record.FeeMonth,
                    $"Rs. {record.BaseFee:N0}",
                    record.LateFine > 0 ? $"Rs. {record.LateFine:N0}" : "-",
                    $"Rs. {record.TotalPaid:N0}",
                    record.PaymentDate.ToString("dd MMM yyyy"),
                    record.Scholarship,
                    record.PaymentMethod
                );

                // Style the row based on fee type
                DataGridViewRow row = dgvPaidStudents.Rows[rowIndex];

                if (record.FeeType == "Annual")
                {
                    row.Cells["colFeeType"].Style.BackColor = Color.FromArgb(232, 245, 255);
                    row.Cells["colFeeType"].Style.ForeColor = Color.FromArgb(41, 128, 185);
                    row.Cells["colFeeType"].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
                else
                {
                    row.Cells["colFeeType"].Style.BackColor = Color.FromArgb(232, 245, 233);
                    row.Cells["colFeeType"].Style.ForeColor = Color.FromArgb(39, 174, 96);
                    row.Cells["colFeeType"].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }

                // Highlight late fine
                if (record.LateFine > 0)
                {
                    row.Cells["colLateFine"].Style.ForeColor = Color.FromArgb(192, 57, 43);
                    row.Cells["colLateFine"].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }

                // Highlight scholarship
                if (record.Scholarship != "-")
                {
                    row.Cells["colScholarship"].Style.ForeColor = Color.FromArgb(155, 89, 182);
                    row.Cells["colScholarship"].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }

                // Style total paid
                row.Cells["colTotalPaid"].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                row.Cells["colTotalPaid"].Style.ForeColor = Color.FromArgb(39, 174, 96);

                filteredTotal += record.TotalPaid;
            }

            // Update filtered results summary
            lblFilteredCount.Text = dgvPaidStudents.Rows.Count.ToString("N0");
            lblFilteredTotal.Text = $"Rs. {filteredTotal:N0}";
        }

        #region Event Handlers

        private void Filter_Changed(object? sender, EventArgs e)
        {
            LoadPaidRecordsToGrid();
        }

        private void BtnRefresh_Click(object? sender, EventArgs e)
        {
            // Reset all filters
            cmbClass.SelectedIndex = 0;
            cmbSection.SelectedIndex = 0;
            cmbFeeType.SelectedIndex = 0;
            cmbMonth.SelectedIndex = 0;
            cmbSort.SelectedIndex = 0;
            txtSearch.Clear();
            txtRollNumber.Clear();

            LoadPaidRecordsToGrid();
            MessageBox.Show("Data refreshed and filters reset.", "Refresh",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnExport_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(
                $"Export Feature\n\n" +
                $"Records to export: {dgvPaidStudents.Rows.Count}\n" +
                $"Total Amount: {lblFilteredTotal.Text}\n\n" +
                $"This would export the filtered data to Excel/CSV.",
                "Export Data",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void BtnPrintReceipt_Click(object? sender, EventArgs e)
        {
            if (dgvPaidStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a payment record to print receipt.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvPaidStudents.SelectedRows[0];
            string receiptNo = selectedRow.Cells["colReceiptNo"].Value?.ToString() ?? "";
            var record = paidRecords.FirstOrDefault(r => r.ReceiptNo == receiptNo);

            if (record != null)
            {
                ShowReceiptDialog(record);
            }
        }

        private void DgvPaidStudents_SelectionChanged(object? sender, EventArgs e)
        {
            btnPrintReceipt.Enabled = dgvPaidStudents.SelectedRows.Count > 0;
        }

        private void DgvPaidStudents_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string receiptNo = dgvPaidStudents.Rows[e.RowIndex].Cells["colReceiptNo"].Value?.ToString() ?? "";
                var record = paidRecords.FirstOrDefault(r => r.ReceiptNo == receiptNo);

                if (record != null)
                {
                    ShowPaymentDetailsDialog(record);
                }
            }
        }

        #endregion

        private void ShowReceiptDialog(PaidFeeRecord record)
        {
            Form dialog = new Form
            {
                Text = $"Fee Receipt - {record.ReceiptNo}",
                Size = new Size(450, 550),
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
                Height = 80,
                BackColor = Color.FromArgb(39, 174, 96)
            };

            Label lblSchoolName = new Label
            {
                Text = "🏫 ABC School",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(20, 10),
                AutoSize = true
            };

            Label lblReceiptTitle = new Label
            {
                Text = "FEE RECEIPT",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(200, 255, 200),
                Location = new Point(20, 40),
                AutoSize = true
            };

            Label lblReceiptNo = new Label
            {
                Text = record.ReceiptNo,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(300, 25),
                AutoSize = true
            };

            headerPanel.Controls.Add(lblSchoolName);
            headerPanel.Controls.Add(lblReceiptTitle);
            headerPanel.Controls.Add(lblReceiptNo);

            // Receipt content
            int yPos = 100;
            string[] labels = { "Student Name:", "Admission No:", "Class / Section:", "Roll Number:", 
                               "Fee Type:", "Fee Period:", "Base Fee:", "Late Fine:", "Total Paid:",
                               "Payment Date:", "Payment Method:", "Scholarship:" };
            string[] values = {
                record.StudentName,
                record.AdmissionNo,
                $"{record.ClassName} - {record.Section}",
                record.RollNo.ToString(),
                record.FeeType,
                record.FeeMonth,
                $"Rs. {record.BaseFee:N0}",
                record.LateFine > 0 ? $"Rs. {record.LateFine:N0}" : "Nil",
                $"Rs. {record.TotalPaid:N0}",
                record.PaymentDate.ToString("dd MMM yyyy"),
                record.PaymentMethod,
                record.Scholarship
            };

            for (int i = 0; i < labels.Length; i++)
            {
                Label lbl = new Label
                {
                    Text = labels[i],
                    Font = new Font("Segoe UI", 10),
                    ForeColor = Color.FromArgb(127, 140, 141),
                    Location = new Point(30, yPos),
                    Size = new Size(130, 25)
                };

                Label val = new Label
                {
                    Text = values[i],
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = Color.FromArgb(44, 62, 80),
                    Location = new Point(170, yPos),
                    AutoSize = true
                };

                // Special styling for total
                if (labels[i] == "Total Paid:")
                {
                    val.ForeColor = Color.FromArgb(39, 174, 96);
                    val.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                }

                dialog.Controls.Add(lbl);
                dialog.Controls.Add(val);
                yPos += 28;
            }

            // Separator line
            Panel separator = new Panel
            {
                BackColor = Color.FromArgb(236, 240, 241),
                Location = new Point(30, yPos + 10),
                Size = new Size(380, 2)
            };

            // Footer
            Label lblFooter = new Label
            {
                Text = "Thank you for your payment!",
                Font = new Font("Segoe UI", 10, FontStyle.Italic),
                ForeColor = Color.FromArgb(127, 140, 141),
                Location = new Point(130, yPos + 25),
                AutoSize = true
            };

            // Print button
            Button btnPrint = new Button
            {
                Text = "🖨️ Print",
                Size = new Size(100, 40),
                Location = new Point(220, yPos + 55),
                BackColor = Color.FromArgb(41, 128, 185),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.Click += (s, e) => MessageBox.Show("Printing receipt...", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close button
            Button btnClose = new Button
            {
                Text = "Close",
                Size = new Size(100, 40),
                Location = new Point(330, yPos + 55),
                BackColor = Color.FromArgb(149, 165, 166),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Cursor = Cursors.Hand,
                DialogResult = DialogResult.OK
            };
            btnClose.FlatAppearance.BorderSize = 0;

            dialog.Controls.Add(headerPanel);
            dialog.Controls.Add(separator);
            dialog.Controls.Add(lblFooter);
            dialog.Controls.Add(btnPrint);
            dialog.Controls.Add(btnClose);

            dialog.ShowDialog(this);
        }

        private void ShowPaymentDetailsDialog(PaidFeeRecord record)
        {
            Form dialog = new Form
            {
                Text = $"Payment Details - {record.StudentName}",
                Size = new Size(450, 420),
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
                Text = "💳",
                Font = new Font("Segoe UI", 28),
                ForeColor = Color.White,
                Location = new Point(15, 8),
                AutoSize = true
            };

            Label lblTitle = new Label
            {
                Text = "Payment Details",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(70, 12),
                AutoSize = true
            };

            Label lblReceiptNo = new Label
            {
                Text = record.ReceiptNo,
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.FromArgb(200, 230, 255),
                Location = new Point(72, 40),
                AutoSize = true
            };

            headerPanel.Controls.Add(lblIcon);
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Controls.Add(lblReceiptNo);

            // Details
            int yPos = 85;
            string[] labels = { "Student:", "Admission No:", "Class/Section:", "Roll Number:", 
                               "Fee Type:", "Period:", "Amount:", "Late Fine:", "Total:", "Date:", "Method:" };
            string[] values = {
                record.StudentName,
                record.AdmissionNo,
                $"{record.ClassName} - {record.Section}",
                record.RollNo.ToString(),
                record.FeeType,
                record.FeeMonth,
                $"Rs. {record.BaseFee:N0}",
                record.LateFine > 0 ? $"Rs. {record.LateFine:N0}" : "-",
                $"Rs. {record.TotalPaid:N0}",
                record.PaymentDate.ToString("dd MMM yyyy, dddd"),
                record.PaymentMethod
            };

            for (int i = 0; i < labels.Length; i++)
            {
                Label lbl = new Label
                {
                    Text = labels[i],
                    Font = new Font("Segoe UI", 10),
                    ForeColor = Color.FromArgb(127, 140, 141),
                    Location = new Point(30, yPos),
                    Size = new Size(110, 25)
                };

                Label val = new Label
                {
                    Text = values[i],
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = Color.FromArgb(44, 62, 80),
                    Location = new Point(150, yPos),
                    AutoSize = true
                };

                if (labels[i] == "Total:")
                {
                    val.ForeColor = Color.FromArgb(39, 174, 96);
                    val.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                }

                dialog.Controls.Add(lbl);
                dialog.Controls.Add(val);
                yPos += 27;
            }

            // Close button
            Button btnClose = new Button
            {
                Text = "Close",
                Size = new Size(100, 40),
                Location = new Point(320, 335),
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
    }

    /// <summary>
    /// Paid fee record for viewing paid students
    /// </summary>
    public class PaidFeeRecord
    {
        public string ReceiptNo { get; set; }
        public string AdmissionNo { get; set; }
        public string StudentName { get; set; }
        public string ClassName { get; set; }
        public string Section { get; set; }
        public int RollNo { get; set; }
        public string FeeType { get; set; } // Monthly or Annual
        public string FeeMonth { get; set; } // Month name or Academic Year
        public decimal BaseFee { get; set; }
        public decimal LateFine { get; set; }
        public decimal TotalPaid { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Scholarship { get; set; }
        public string PaymentMethod { get; set; }

        public PaidFeeRecord(string receiptNo, string admissionNo, string studentName, string className,
            string section, int rollNo, string feeType, string feeMonth, decimal baseFee, decimal lateFine,
            decimal totalPaid, DateTime paymentDate, string scholarship, string paymentMethod)
        {
            ReceiptNo = receiptNo;
            AdmissionNo = admissionNo;
            StudentName = studentName;
            ClassName = className;
            Section = section;
            RollNo = rollNo;
            FeeType = feeType;
            FeeMonth = feeMonth;
            BaseFee = baseFee;
            LateFine = lateFine;
            TotalPaid = totalPaid;
            PaymentDate = paymentDate;
            Scholarship = scholarship;
            PaymentMethod = paymentMethod;
        }
    }
}
