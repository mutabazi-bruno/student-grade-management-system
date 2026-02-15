using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentGradeManagement
{
    public partial class MainForm : Form
    {
        private StudentManager manager;

        public MainForm()
        {
            InitializeComponent();
            manager = new StudentManager();
        }

        // Add student button click event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                
                // Validate grade input
                if (!int.TryParse(txtGrade.Text, out int grade))
                {
                    MessageBox.Show("Please enter a valid numeric grade.", "Invalid Input", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGrade.Focus();
                    return;
                }

                // Add the student
                manager.AddStudent(name, grade);
                
                MessageBox.Show($"Student '{name}' added successfully with grade {grade}!", 
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Clear input fields
                txtName.Clear();
                txtGrade.Clear();
                txtName.Focus();
                
                // Refresh the display
                RefreshStudentList();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Grade must be between 0 and 100.", "Invalid Grade", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGrade.Focus();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Display all students button click event
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            RefreshStudentList();
        }

        // Refresh the student list display
        private void RefreshStudentList()
        {
            try
            {
                var allStudents = manager.GetAllStudents();
                
                if (allStudents.Count == 0)
                {
                    lstStudents.Items.Clear();
                    lstStudents.Items.Add("No students in the system yet.");
                    return;
                }

                lstStudents.Items.Clear();
                lstStudents.Items.Add("========================================");
                lstStudents.Items.Add("  STUDENT NAME          GRADE   CATEGORY");
                lstStudents.Items.Add("========================================");

                foreach (var student in allStudents)
                {
                    string category = StudentManager.GetGradeCategory(student.Value).ToString();
                    string line = $"  {student.Key,-20} {student.Value,5}   {category}";
                    lstStudents.Items.Add(line);
                }

                lstStudents.Items.Add("========================================");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying students: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Search student button click event
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchName = txtSearch.Text.Trim();
                int? grade = manager.SearchStudent(searchName);

                if (grade.HasValue)
                {
                    GradeCategory category = StudentManager.GetGradeCategory(grade.Value);
                    MessageBox.Show(
                        $"Student: {searchName}\n" +
                        $"Grade: {grade.Value}\n" +
                        $"Category: {category}",
                        "Student Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Student '{searchName}' not found in the system.", 
                        "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                txtSearch.Clear();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Calculate average button click event
        private void btnAverage_Click(object sender, EventArgs e)
        {
            try
            {
                double average = manager.CalculateAverageGrade();
                MessageBox.Show($"The average grade of all students is: {average:F2}", 
                    "Average Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "No Data", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating average: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Find highest and lowest grades button click event
        private void btnHighLow_Click(object sender, EventArgs e)
        {
            try
            {
                int highest = manager.GetHighestGrade();
                int lowest = manager.GetLowestGrade();

                MessageBox.Show(
                    $"Highest Grade: {highest}\n" +
                    $"Lowest Grade: {lowest}",
                    "Grade Statistics",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "No Data", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error finding grades: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clear all students button click event
        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to clear all student records?",
                "Confirm Clear",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                manager.ClearAllStudents();
                RefreshStudentList();
                MessageBox.Show("All student records have been cleared.", "Cleared", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
