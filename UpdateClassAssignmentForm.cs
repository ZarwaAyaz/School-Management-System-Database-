using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManagementSystem
{
    public partial class UpdateClassAssignmentForm : Form
    {
        // Sample data - represents current assignments
        private List<TeacherAssignment> currentAssignments = new List<TeacherAssignment>
        {
            new TeacherAssignment("EMP-2024-1001", "Ahmed Khan", "Nursery"),
            new TeacherAssignment("EMP-2024-1002", "Fatima Ali", "Prep"),
            new TeacherAssignment("EMP-2024-1003", "Muhammad Usman", "Class 1"),
            new TeacherAssignment("EMP-2024-1004", "Ayesha Malik", "Class 2"),
            new TeacherAssignment("EMP-2024-1005", "Hassan Raza", "Class 3"),
            new TeacherAssignment("EMP-2024-1006", "Sara Ahmed", "Class 4"),
            new TeacherAssignment("EMP-2024-1007", "Ali Abbas", "Class 5"),
            new TeacherAssignment("EMP-2024-1008", "Zainab Fatima", "Class 6"),
            new TeacherAssignment("EMP-2024-1009", "Imran Sheikh", "Class 7"),
            new TeacherAssignment("EMP-2024-1010", "Mariam Bibi", "Class 8")
        };

        // Available teachers (not yet assigned)
        private List<Teacher> availableTeachers = new List<Teacher>
        {
            new Teacher("EMP-2024-1011", "Khalid Mahmood"),
            new Teacher("EMP-2024-1012", "Nadia Hussain"),
            new Teacher("EMP-2024-1013", "Tariq Aziz"),
            new Teacher("EMP-2024-1014", "Sana Iqbal")
        };

        private readonly string[] classes = {
            "Nursery", "Prep", "Class 1", "Class 2", "Class 3", "Class 4",
            "Class 5", "Class 6", "Class 7", "Class 8", "Class 9", "Class 10"
        };

        private string selectedEmployeeId = "";
        private string originalClass = "";

        public UpdateClassAssignmentForm()
        {
            InitializeComponent();
            SetupForm();
            LoadCurrentAssignments();
            LoadTeachers();
        }

        private void SetupForm()
        {
            // Disable save initially
            btnSave.Enabled = false;
        }

        private void LoadCurrentAssignments()
        {
            dgvCurrentAssignments.Rows.Clear();

            foreach (var assignment in currentAssignments.OrderBy(a => GetClassOrder(a.AssignedClass)))
            {
                dgvCurrentAssignments.Rows.Add(
                    assignment.AssignedClass,
                    assignment.TeacherName,
                    assignment.EmployeeId
                );
            }
        }

        private int GetClassOrder(string className)
        {
            return Array.IndexOf(classes, className);
        }

        private void LoadTeachers()
        {
            cmbTeacher.Items.Clear();
            cmbTeacher.Items.Add("-- Select Teacher --");

            // Add all teachers (assigned and available) to dropdown
            foreach (var assignment in currentAssignments.OrderBy(a => a.TeacherName))
            {
                cmbTeacher.Items.Add($"{assignment.TeacherName} ({assignment.EmployeeId})");
            }

            foreach (var teacher in availableTeachers.OrderBy(t => t.Name))
            {
                cmbTeacher.Items.Add($"{teacher.Name} ({teacher.EmployeeId})");
            }

            cmbTeacher.SelectedIndex = 0;
        }

        private void LoadClassDropdown()
        {
            cmbClass.Items.Clear();

            foreach (var className in classes)
            {
                var assignedTo = currentAssignments.FirstOrDefault(a => a.AssignedClass == className);
                if (assignedTo != null)
                {
                    cmbClass.Items.Add($"{className} - Assigned to {assignedTo.TeacherName}");
                }
                else
                {
                    cmbClass.Items.Add($"{className} - Available");
                }
            }
        }

        private void CmbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTeacher.SelectedIndex <= 0)
            {
                txtEmployeeId.Clear();
                txtCurrentAssignment.Clear();
                cmbClass.Items.Clear();
                cmbClass.Enabled = false;
                originalClass = "";
                selectedEmployeeId = "";
                lblValidation.Text = "";
                btnSave.Enabled = false;
                return;
            }

            string? selected = cmbTeacher.SelectedItem?.ToString();
            if (selected == null) return;
            
            // Extract Employee ID from selection
            int startIndex = selected.IndexOf("(") + 1;
            int endIndex = selected.IndexOf(")");
            selectedEmployeeId = selected.Substring(startIndex, endIndex - startIndex);
            
            txtEmployeeId.Text = selectedEmployeeId;

            // Check if teacher already has assignment
            var existing = currentAssignments.FirstOrDefault(a => a.EmployeeId == selectedEmployeeId);
            if (existing != null)
            {
                originalClass = existing.AssignedClass;
                txtCurrentAssignment.Text = originalClass;
                txtCurrentAssignment.BackColor = Color.FromArgb(255, 243, 224);
            }
            else
            {
                originalClass = "";
                txtCurrentAssignment.Text = "None";
                txtCurrentAssignment.BackColor = Color.FromArgb(232, 245, 233);
            }

            // Load class dropdown with availability info
            LoadClassDropdown();
            cmbClass.Enabled = true;
            cmbClass.SelectedIndex = -1;
            lblValidation.Text = "Select a class to assign";
            lblValidation.ForeColor = Color.FromArgb(52, 152, 219);
            btnSave.Enabled = false;
        }

        private void CmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateAssignment();
        }

        private void ValidateAssignment()
        {
            if (string.IsNullOrEmpty(selectedEmployeeId) || cmbClass.SelectedIndex < 0)
            {
                btnSave.Enabled = false;
                return;
            }

            string? selectedItem = cmbClass.SelectedItem?.ToString();
            if (selectedItem == null) return;
            
            string selectedClass = selectedItem.Split('-')[0].Trim();

            // Check if this is the same as original (no change)
            if (selectedClass == originalClass)
            {
                lblValidation.Text = "No changes to save";
                lblValidation.ForeColor = Color.FromArgb(149, 165, 166);
                btnSave.Enabled = false;
                return;
            }

            // Check if selected class is already assigned to another teacher
            var existingAssignment = currentAssignments.FirstOrDefault(a => 
                a.AssignedClass == selectedClass && a.EmployeeId != selectedEmployeeId);

            if (existingAssignment != null)
            {
                lblValidation.Text = $"⚠ {selectedClass} is assigned to {existingAssignment.TeacherName}. Reassigning will remove their assignment.";
                lblValidation.ForeColor = Color.FromArgb(243, 156, 18);
                btnSave.Enabled = true;
                return;
            }

            // Check if teacher already has another assignment
            var teacherAssignment = currentAssignments.FirstOrDefault(a => a.EmployeeId == selectedEmployeeId);
            if (teacherAssignment != null && teacherAssignment.AssignedClass != selectedClass)
            {
                lblValidation.Text = $"✓ Ready to reassign from {teacherAssignment.AssignedClass} to {selectedClass}";
                lblValidation.ForeColor = Color.FromArgb(39, 174, 96);
                btnSave.Enabled = true;
                return;
            }

            // New assignment
            lblValidation.Text = $"✓ Ready to assign {selectedClass}";
            lblValidation.ForeColor = Color.FromArgb(39, 174, 96);
            btnSave.Enabled = true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedEmployeeId) || cmbClass.SelectedIndex < 0)
                return;

            string? selectedItem = cmbClass.SelectedItem?.ToString();
            if (selectedItem == null) return;
            
            string selectedClass = selectedItem.Split('-')[0].Trim();
            
            string? teacherItem = cmbTeacher.SelectedItem?.ToString();
            if (teacherItem == null) return;
            
            string teacherName = teacherItem.Split('(')[0].Trim();

            // Check if another teacher has this class and remove it
            var existingClassHolder = currentAssignments.FirstOrDefault(a => 
                a.AssignedClass == selectedClass && a.EmployeeId != selectedEmployeeId);
            
            if (existingClassHolder != null)
            {
                currentAssignments.Remove(existingClassHolder);
                availableTeachers.Add(new Teacher(existingClassHolder.EmployeeId, existingClassHolder.TeacherName));
            }

            // Update or create assignment
            var existing = currentAssignments.FirstOrDefault(a => a.EmployeeId == selectedEmployeeId);
            if (existing != null)
            {
                existing.AssignedClass = selectedClass;
                MessageBox.Show(
                    $"Class assignment updated successfully!\n\n" +
                    $"Teacher: {teacherName}\n" +
                    $"Employee ID: {selectedEmployeeId}\n" +
                    $"New Assignment: {selectedClass}",
                    "Assignment Updated",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                // New assignment from available teachers
                currentAssignments.Add(new TeacherAssignment(selectedEmployeeId, teacherName, selectedClass));
                availableTeachers.RemoveAll(t => t.EmployeeId == selectedEmployeeId);
                
                MessageBox.Show(
                    $"Class assigned successfully!\n\n" +
                    $"Teacher: {teacherName}\n" +
                    $"Employee ID: {selectedEmployeeId}\n" +
                    $"Class: {selectedClass}",
                    "Assignment Created",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            // Reload everything
            LoadCurrentAssignments();
            LoadTeachers();
            txtEmployeeId.Clear();
            txtCurrentAssignment.Clear();
            cmbClass.Items.Clear();
            cmbClass.Enabled = false;
            lblValidation.Text = "";
            btnSave.Enabled = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // Reset form
            cmbTeacher.SelectedIndex = 0;
            txtEmployeeId.Clear();
            txtCurrentAssignment.Clear();
            cmbClass.Items.Clear();
            cmbClass.Enabled = false;
            lblValidation.Text = "";
            btnSave.Enabled = false;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            // Navigate back to admin dashboard
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
        }
    }

    // Data classes
    public class TeacherAssignment
    {
        public string EmployeeId { get; set; }
        public string TeacherName { get; set; }
        public string AssignedClass { get; set; }

        public TeacherAssignment(string employeeId, string teacherName, string assignedClass)
        {
            EmployeeId = employeeId;
            TeacherName = teacherName;
            AssignedClass = assignedClass;
        }
    }

    public class Teacher
    {
        public string EmployeeId { get; set; }
        public string Name { get; set; }

        public Teacher(string employeeId, string name)
        {
            EmployeeId = employeeId;
            Name = name;
        }
    }
}
