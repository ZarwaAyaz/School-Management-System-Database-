using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class ViewUnpaidStudentsForm : Form
    {
        private List<UnpaidFeeRecord> allUnpaidRecords = new List<UnpaidFeeRecord>();
        private List<UnpaidFeeRecord> filteredRecords = new List<UnpaidFeeRecord>();
        private string currentMonth = DateTime.Now.ToString("MMMM yyyy");

        public ViewUnpaidStudentsForm()
        {
            InitializeComponent();
            this.Load += ViewUnpaidStudentsForm_Load;
        }

        private void ViewUnpaidStudentsForm_Load(object? sender, EventArgs e)
        {
            SetupForm();
            LoadComboBoxes();
            GenerateSampleUnpaidRecords();
            LoadUnpaidToGrid();
            UpdateStatistics();
        }

        private void SetupForm()
        {
            this.Text = "View Unpaid Students - Fee Management";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.FromArgb(236, 240, 241);
        }

        private void LoadComboBoxes()
        {
            // Class dropdown
            cmbClass.Items.Clear();
            cmbClass.Items.Add("All Classes");
            cmbClass.Items.AddRange(new object[] { "Nursery", "Prep", "Class 1", "Class 2", "Class 3", 
                "Class 4", "Class 5", "Class 6", "Class 7", "Class 8", "Class 9", "Class 10" });
            cmbClass.SelectedIndex = 0;

            // Section dropdown
            cmbSection.Items.Clear();
            cmbSection.Items.AddRange(new object[] { "All Sections", "A", "B", "C" });
            cmbSection.SelectedIndex = 0;

            // Fee Type dropdown
            cmbFeeType.Items.Clear();
            cmbFeeType.Items.AddRange(new object[] { "All Types", "Monthly Fee", "Annual Charges" });
            cmbFeeType.SelectedIndex = 0;
        }

        private void GenerateSampleUnpaidRecords()
        {
            allUnpaidRecords.Clear();
            
            string[] firstNames = { "Ahmed", "Fatima", "Hassan", "Ayesha", "Ali", "Zainab", "Omar", "Sara", 
                "Ibrahim", "Maryam", "Usman", "Hira", "Bilal", "Amina", "Hamza", "Khadija" };
            string[] lastNames = { "Khan", "Ahmed", "Ali", "Hassan", "Malik", "Sheikh", "Qureshi", "Syed", 
                "Iqbal", "Nawaz", "Rashid", "Mahmood", "Tariq", "Javed", "Aslam", "Raza" };
            string[] classes = { "Nursery", "Prep", "Class 1", "Class 2", "Class 3", "Class 4", "Class 5", 
                "Class 6", "Class 7", "Class 8", "Class 9", "Class 10" };
            string[] sections = { "A", "B", "C" };

            Random rnd = new Random(42);
            int admNo = 2024001;

            // Generate unpaid records - only current month and annual charges
            for (int i = 0; i < 30; i++)
            {
                string className = classes[rnd.Next(classes.Length)];
                string feeType = rnd.Next(100) < 75 ? "Monthly Fee" : "Annual Charges";
                
                decimal amount = GetFeeAmount(className, feeType);

                allUnpaidRecords.Add(new UnpaidFeeRecord
                {
                    AdmissionNo = "ADM-" + admNo++,
                    StudentName = firstNames[rnd.Next(firstNames.Length)] + " " + lastNames[rnd.Next(lastNames.Length)],
                    ClassName = className,
                    Section = sections[rnd.Next(sections.Length)],
                    RollNo = rnd.Next(1, 45),
                    FeeType = feeType,
                    Period = feeType == "Monthly Fee" ? currentMonth : "2024-2025",
                    AmountDue = amount
                });
            }
        }

        private decimal GetFeeAmount(string className, string feeType)
        {
            Dictionary<string, decimal> monthlyFees = new Dictionary<string, decimal>
            {
                { "Nursery", 2000 }, { "Prep", 2200 }, { "Class 1", 2500 }, { "Class 2", 2500 },
                { "Class 3", 2800 }, { "Class 4", 2800 }, { "Class 5", 3000 }, { "Class 6", 3200 },
                { "Class 7", 3500 }, { "Class 8", 3500 }, { "Class 9", 4000 }, { "Class 10", 4000 }
            };

            Dictionary<string, decimal> annualCharges = new Dictionary<string, decimal>
            {
                { "Nursery", 15000 }, { "Prep", 16000 }, { "Class 1", 18000 }, { "Class 2", 18000 },
                { "Class 3", 20000 }, { "Class 4", 20000 }, { "Class 5", 22000 }, { "Class 6", 24000 },
                { "Class 7", 26000 }, { "Class 8", 26000 }, { "Class 9", 30000 }, { "Class 10", 30000 }
            };

            if (feeType == "Monthly Fee")
                return monthlyFees.ContainsKey(className) ? monthlyFees[className] : 2500;
            else
                return annualCharges.ContainsKey(className) ? annualCharges[className] : 20000;
        }

        private void LoadUnpaidToGrid()
        {
            filteredRecords = allUnpaidRecords.ToList();

            // Filter by class
            if (cmbClass.SelectedIndex > 0)
            {
                string selectedClass = cmbClass.SelectedItem?.ToString() ?? "";
                filteredRecords = filteredRecords.Where(r => r.ClassName == selectedClass).ToList();
            }

            // Filter by section
            if (cmbSection.SelectedIndex > 0)
            {
                string selectedSection = cmbSection.SelectedItem?.ToString() ?? "";
                filteredRecords = filteredRecords.Where(r => r.Section == selectedSection).ToList();
            }

            // Filter by fee type
            if (cmbFeeType.SelectedIndex > 0)
            {
                string selectedType = cmbFeeType.SelectedItem?.ToString() ?? "";
                filteredRecords = filteredRecords.Where(r => r.FeeType == selectedType).ToList();
            }

            // Filter by search text
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                string search = txtSearch.Text.ToLower();
                filteredRecords = filteredRecords.Where(r =>
                    r.StudentName.ToLower().Contains(search) ||
                    r.AdmissionNo.ToLower().Contains(search)).ToList();
            }

            // Load to grid
            dgvUnpaid.Rows.Clear();
            foreach (var record in filteredRecords)
            {
                int rowIndex = dgvUnpaid.Rows.Add(
                    record.AdmissionNo,
                    record.StudentName,
                    record.ClassName,
                    record.Section,
                    record.RollNo,
                    record.FeeType,
                    record.Period,
                    "Rs. " + record.AmountDue.ToString("N0")
                );

                // Color code by fee type
                DataGridViewRow row = dgvUnpaid.Rows[rowIndex];
                if (record.FeeType == "Annual Charges")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 248, 230);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(211, 84, 0);
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(44, 62, 80);
                }
            }

            UpdateStatistics();
        }

        private void UpdateStatistics()
        {
            int totalUnpaid = filteredRecords.Count;
            int monthlyCount = filteredRecords.Count(r => r.FeeType == "Monthly Fee");
            int annualCount = filteredRecords.Count(r => r.FeeType == "Annual Charges");
            decimal totalAmount = filteredRecords.Sum(r => r.AmountDue);

            lblTotalUnpaid.Text = totalUnpaid.ToString();
            lblMonthlyCount.Text = monthlyCount.ToString();
            lblAnnualCount.Text = annualCount.ToString();
            lblTotalAmount.Text = "Rs. " + totalAmount.ToString("N0");
        }

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            LoadUnpaidToGrid();
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            cmbClass.SelectedIndex = 0;
            cmbSection.SelectedIndex = 0;
            cmbFeeType.SelectedIndex = 0;
            txtSearch.Text = "";
            LoadUnpaidToGrid();
        }

        private void btnBack_Click(object? sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Close();
        }
    }

    public class UnpaidFeeRecord
    {
        public string AdmissionNo { get; set; } = "";
        public string StudentName { get; set; } = "";
        public string ClassName { get; set; } = "";
        public string Section { get; set; } = "";
        public int RollNo { get; set; }
        public string FeeType { get; set; } = "";
        public string Period { get; set; } = "";
        public decimal AmountDue { get; set; }
    }
}
