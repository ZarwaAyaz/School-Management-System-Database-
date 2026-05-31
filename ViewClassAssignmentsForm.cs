using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManagementSystem
{
    public partial class ViewClassAssignmentsForm : Form
    {
        // Sample class assignment data
        private List<ClassAssignment> assignments = new List<ClassAssignment>
        {
            new ClassAssignment("EMP-2024-1001", "Ahmed Khan", "Nursery", "A", 25, "Mathematics", "Active"),
            new ClassAssignment("EMP-2024-1002", "Fatima Ali", "Nursery", "B", 23, "English", "Active"),
            new ClassAssignment("EMP-2024-1003", "Muhammad Usman", "Prep", "A", 28, "Physics", "Active"),
            new ClassAssignment("EMP-2024-1004", "Ayesha Malik", "Prep", "B", 26, "Urdu", "Active"),
            new ClassAssignment("EMP-2024-1005", "Hassan Raza", "Class 1", "A", 30, "Computer Science", "Active"),
            new ClassAssignment("EMP-2024-1006", "Sara Ahmed", "Class 1", "B", 27, "Art & Drawing", "Active"),
            new ClassAssignment("EMP-2024-1007", "Ali Abbas", "Class 2", "A", 29, "Chemistry", "Active"),
            new ClassAssignment("EMP-2024-1008", "Zainab Fatima", "Class 2", "B", 25, "Biology", "Active"),
            new ClassAssignment("EMP-2024-1009", "Imran Sheikh", "Class 3", "A", 32, "History", "Active"),
            new ClassAssignment("EMP-2024-1010", "Mariam Bibi", "Class 3", "B", 28, "Islamiat", "Active"),
            new ClassAssignment("EMP-2024-1011", "Khalid Mahmood", "Class 4", "A", 30, "Mathematics", "Active"),
            new ClassAssignment("EMP-2024-1012", "Nadia Hussain", "Class 4", "B", 26, "English", "Active"),
            new ClassAssignment("EMP-2024-1013", "Tariq Aziz", "Class 5", "A", 31, "Science", "Active"),
            new ClassAssignment("EMP-2024-1014", "Sana Iqbal", "Class 5", "B", 27, "Social Studies", "Active"),
            new ClassAssignment("EMP-2024-1015", "Bilal Ahmad", "Class 6", "A", 33, "Physics", "Active"),
            new ClassAssignment("EMP-2024-1016", "Hira Nawaz", "Class 6", "B", 29, "Chemistry", "Active"),
            new ClassAssignment("EMP-2024-1017", "Umar Farooq", "Class 7", "A", 30, "Mathematics", "Active"),
            new ClassAssignment("EMP-2024-1018", "Amina Khan", "Class 7", "B", 28, "Biology", "Active"),
            new ClassAssignment("EMP-2024-1019", "Rashid Ali", "Class 8", "A", 32, "Computer Science", "Active"),
            new ClassAssignment("EMP-2024-1020", "Farah Naz", "Class 8", "B", 27, "English", "Active"),
            new ClassAssignment("EMP-2024-1021", "Waqar Hassan", "Class 9", "A", 35, "Physics", "Active"),
            new ClassAssignment("EMP-2024-1022", "Uzma Saleem", "Class 9", "B", 33, "Chemistry", "Active"),
            new ClassAssignment("EMP-2024-1023", "Danish Raza", "Class 10", "A", 30, "Mathematics", "Active"),
            new ClassAssignment("EMP-2024-1024", "Mehreen Asif", "Class 10", "B", 28, "Biology", "Active")
        };

        // Class/Grade options
        private readonly string[] classes = {
            "Nursery", "Prep", "Class 1", "Class 2", "Class 3", "Class 4",
            "Class 5", "Class 6", "Class 7", "Class 8", "Class 9", "Class 10"
        };

        private readonly string[] sections = { "A", "B", "C", "D" };

        // Current sort state
        private string currentSortColumn = "";
        private bool sortAscending = true;

        public ViewClassAssignmentsForm()
        {
            InitializeComponent();
            SetupForm();
            SetupEventHandlers();
            LoadAssignmentsToGrid();
            UpdateStatistics();
        }

        private void SetupForm()
        {
            // Setup class filter
            cmbClassFilter.Items.Add("All Classes");
            cmbClassFilter.Items.AddRange(classes);
            cmbClassFilter.SelectedIndex = 0;

            // Setup section filter
            cmbSectionFilter.Items.Add("All Sections");
            cmbSectionFilter.Items.AddRange(sections);
            cmbSectionFilter.SelectedIndex = 0;

            // Setup sort options
            cmbSortBy.Items.AddRange(new string[] {
                "Teacher Name (A-Z)",
                "Teacher Name (Z-A)",
                "Employee ID (Asc)",
                "Employee ID (Desc)",
                "Class (Low to High)",
                "Class (High to Low)",
                "Students (Low to High)",
                "Students (High to Low)"
            });
            cmbSortBy.SelectedIndex = 4; // Default: Class (Low to High)
        }

        private void SetupEventHandlers()
        {
            // Search and filter events
            txtSearch.TextChanged += TxtSearch_TextChanged;
            cmbClassFilter.SelectedIndexChanged += Filter_Changed;
            cmbSectionFilter.SelectedIndexChanged += Filter_Changed;
            cmbSortBy.SelectedIndexChanged += CmbSortBy_SelectedIndexChanged;
            btnClearFilter.Click += BtnClearFilter_Click;
            btnRefresh.Click += BtnRefresh_Click;
            btnExport.Click += BtnExport_Click;

            // DataGridView events
            dgvAssignments.CellDoubleClick += DgvAssignments_CellDoubleClick;

            // Hover effects
            SetupButtonHoverEffects(btnClearFilter, Color.FromArgb(149, 165, 166), Color.FromArgb(189, 195, 199));
            SetupButtonHoverEffects(btnRefresh, Color.FromArgb(41, 128, 185), Color.FromArgb(52, 152, 219));
            SetupButtonHoverEffects(btnExport, Color.FromArgb(39, 174, 96), Color.FromArgb(46, 204, 113));
        }

        private void SetupButtonHoverEffects(Button btn, Color normalColor, Color hoverColor)
        {
            btn.MouseEnter += (s, e) => btn.BackColor = hoverColor;
            btn.MouseLeave += (s, e) => btn.BackColor = normalColor;
        }

        private void LoadAssignmentsToGrid()
        {
            dgvAssignments.Rows.Clear();
            
            var sortedAssignments = ApplySorting(assignments);
            
            foreach (var assignment in sortedAssignments)
            {
                int rowIndex = dgvAssignments.Rows.Add(
                    assignment.EmployeeId,
                    assignment.TeacherName,
                    assignment.ClassName,
                    assignment.Section,
                    $"{assignment.ClassName} - {assignment.Section}",
                    assignment.TotalStudents,
                    assignment.Specialization,
                    assignment.Status
                );

                // Color code based on student count
                if (assignment.TotalStudents >= 32)
                {
                    dgvAssignments.Rows[rowIndex].Cells["colStudents"].Style.ForeColor = Color.FromArgb(192, 57, 43);
                    dgvAssignments.Rows[rowIndex].Cells["colStudents"].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                }
                else if (assignment.TotalStudents >= 28)
                {
                    dgvAssignments.Rows[rowIndex].Cells["colStudents"].Style.ForeColor = Color.FromArgb(230, 126, 34);
                }
            }
            
            UpdateResultsCount();
        }

        private void FilterAssignments()
        {
            string searchText = txtSearch.Text.ToLower().Trim();
            string classFilter = cmbClassFilter.SelectedItem?.ToString() ?? "All Classes";
            string sectionFilter = cmbSectionFilter.SelectedItem?.ToString() ?? "All Sections";

            var filteredList = assignments.Where(a =>
            {
                bool matchesSearch = string.IsNullOrEmpty(searchText) ||
                    a.TeacherName.ToLower().Contains(searchText) ||
                    a.EmployeeId.ToLower().Contains(searchText);

                bool matchesClass = classFilter == "All Classes" || a.ClassName == classFilter;
                bool matchesSection = sectionFilter == "All Sections" || a.Section == sectionFilter;

                return matchesSearch && matchesClass && matchesSection;
            }).ToList();

            var sortedList = ApplySorting(filteredList);

            dgvAssignments.Rows.Clear();
            foreach (var assignment in sortedList)
            {
                int rowIndex = dgvAssignments.Rows.Add(
                    assignment.EmployeeId,
                    assignment.TeacherName,
                    assignment.ClassName,
                    assignment.Section,
                    $"{assignment.ClassName} - {assignment.Section}",
                    assignment.TotalStudents,
                    assignment.Specialization,
                    assignment.Status
                );

                // Color code based on student count
                if (assignment.TotalStudents >= 32)
                {
                    dgvAssignments.Rows[rowIndex].Cells["colStudents"].Style.ForeColor = Color.FromArgb(192, 57, 43);
                    dgvAssignments.Rows[rowIndex].Cells["colStudents"].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                }
                else if (assignment.TotalStudents >= 28)
                {
                    dgvAssignments.Rows[rowIndex].Cells["colStudents"].Style.ForeColor = Color.FromArgb(230, 126, 34);
                }
            }

            UpdateResultsCount();
        }

        private List<ClassAssignment> ApplySorting(List<ClassAssignment> list)
        {
            int sortIndex = cmbSortBy.SelectedIndex;

            return sortIndex switch
            {
                0 => list.OrderBy(a => a.TeacherName).ToList(),
                1 => list.OrderByDescending(a => a.TeacherName).ToList(),
                2 => list.OrderBy(a => a.EmployeeId).ToList(),
                3 => list.OrderByDescending(a => a.EmployeeId).ToList(),
                4 => list.OrderBy(a => GetClassOrder(a.ClassName)).ThenBy(a => a.Section).ToList(),
                5 => list.OrderByDescending(a => GetClassOrder(a.ClassName)).ThenByDescending(a => a.Section).ToList(),
                6 => list.OrderBy(a => a.TotalStudents).ToList(),
                7 => list.OrderByDescending(a => a.TotalStudents).ToList(),
                _ => list
            };
        }

        private int GetClassOrder(string className)
        {
            return Array.IndexOf(classes, className);
        }

        private void UpdateResultsCount()
        {
            lblResultsCount.Text = $"Showing {dgvAssignments.Rows.Count} of {assignments.Count} assignments";
        }

        private void UpdateStatistics()
        {
            // Total classes
            int totalClasses = assignments.Select(a => $"{a.ClassName}-{a.Section}").Distinct().Count();
            lblTotalClasses.Text = totalClasses.ToString();

            // Total teachers assigned
            int totalTeachers = assignments.Select(a => a.EmployeeId).Distinct().Count();
            lblTotalTeachers.Text = totalTeachers.ToString();

            // Total students
            int totalStudents = assignments.Sum(a => a.TotalStudents);
            lblTotalStudents.Text = totalStudents.ToString();

            // Average students per class
            double avgStudents = assignments.Count > 0 ? assignments.Average(a => a.TotalStudents) : 0;
            lblAvgStudents.Text = avgStudents.ToString("F1");
        }

        #region Event Handlers

        private void TxtSearch_TextChanged(object? sender, EventArgs e)
        {
            FilterAssignments();
        }

        private void Filter_Changed(object? sender, EventArgs e)
        {
            FilterAssignments();
        }

        private void CmbSortBy_SelectedIndexChanged(object? sender, EventArgs e)
        {
            FilterAssignments();
        }

        private void BtnClearFilter_Click(object? sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbClassFilter.SelectedIndex = 0;
            cmbSectionFilter.SelectedIndex = 0;
            cmbSortBy.SelectedIndex = 4;
            LoadAssignmentsToGrid();
        }

        private void BtnRefresh_Click(object? sender, EventArgs e)
        {
            LoadAssignmentsToGrid();
            UpdateStatistics();
            MessageBox.Show("Data refreshed successfully!", "Refresh",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnExport_Click(object? sender, EventArgs e)
        {
            // Simulate export functionality
            MessageBox.Show("Class Assignments Report\n\n" +
                $"Total Classes: {lblTotalClasses.Text}\n" +
                $"Total Teachers: {lblTotalTeachers.Text}\n" +
                $"Total Students: {lblTotalStudents.Text}\n" +
                $"Average Students/Class: {lblAvgStudents.Text}\n\n" +
                "Export functionality would generate an Excel/PDF report.",
                "Export Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DgvAssignments_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string employeeId = dgvAssignments.Rows[e.RowIndex].Cells["colEmployeeId"].Value?.ToString() ?? "";
                string teacherName = dgvAssignments.Rows[e.RowIndex].Cells["colTeacherName"].Value?.ToString() ?? "";
                string classSection = dgvAssignments.Rows[e.RowIndex].Cells["colClassSection"].Value?.ToString() ?? "";
                string students = dgvAssignments.Rows[e.RowIndex].Cells["colStudents"].Value?.ToString() ?? "";
                string specialization = dgvAssignments.Rows[e.RowIndex].Cells["colSpecialization"].Value?.ToString() ?? "";

                MessageBox.Show(
                    $"Teacher Assignment Details\n\n" +
                    $"Employee ID: {employeeId}\n" +
                    $"Teacher Name: {teacherName}\n" +
                    $"Assigned Class: {classSection}\n" +
                    $"Total Students: {students}\n" +
                    $"Specialization: {specialization}\n\n" +
                    $"This teacher handles all subjects for {classSection}.",
                    "Assignment Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        #endregion
    }

    /// <summary>
    /// Class assignment data model
    /// </summary>
    public class ClassAssignment
    {
        public string EmployeeId { get; set; }
        public string TeacherName { get; set; }
        public string ClassName { get; set; }
        public string Section { get; set; }
        public int TotalStudents { get; set; }
        public string Specialization { get; set; }
        public string Status { get; set; }

        public ClassAssignment(string employeeId, string teacherName, string className, 
            string section, int totalStudents, string specialization, string status)
        {
            EmployeeId = employeeId;
            TeacherName = teacherName;
            ClassName = className;
            Section = section;
            TotalStudents = totalStudents;
            Specialization = specialization;
            Status = status;
        }
    }
}
