using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentGradeManagement
{
    public class StudentManager
    {
        // Dictionary to store student names and their grades
        private Dictionary<string, int> students;

        public StudentManager()
        {
            students = new Dictionary<string, int>();
        }

        // Add a new student with their grade
        public bool AddStudent(string name, int grade)
        {
            // Validate student name
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Student name cannot be empty.");
            }

            // Validate grade range
            if (grade < 0 || grade > 100)
            {
                throw new ArgumentOutOfRangeException("Grade must be between 0 and 100.");
            }

            // Check if student already exists
            if (students.ContainsKey(name))
            {
                throw new InvalidOperationException($"Student '{name}' already exists. Please use a different name or update the existing record.");
            }

            students.Add(name, grade);
            return true;
        }

        // Get all students and their grades
        public Dictionary<string, int> GetAllStudents()
        {
            return new Dictionary<string, int>(students);
        }

        // Search for a specific student by name
        public int? SearchStudent(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Please enter a student name to search.");
            }

            if (students.ContainsKey(name))
            {
                return students[name];
            }

            return null; // Student not found
        }

        // Calculate the average grade of all students
        public double CalculateAverageGrade()
        {
            if (students.Count == 0)
            {
                throw new InvalidOperationException("No students in the system to calculate average.");
            }

            return students.Values.Average();
        }

        // Find the highest grade
        public int GetHighestGrade()
        {
            if (students.Count == 0)
            {
                throw new InvalidOperationException("No students in the system.");
            }

            return students.Values.Max();
        }

        // Find the lowest grade
        public int GetLowestGrade()
        {
            if (students.Count == 0)
            {
                throw new InvalidOperationException("No students in the system.");
            }

            return students.Values.Min();
        }

        // Get grade category based on the grade value
        public static GradeCategory GetGradeCategory(int grade)
        {
            if (grade >= 80)
                return GradeCategory.Excellent;
            else if (grade >= 70)
                return GradeCategory.Better;
            else if (grade >= 60)
                return GradeCategory.Good;
            else if (grade >= 50)
                return GradeCategory.Pass;
            else
                return GradeCategory.Fail;
        }

        // Get the count of students
        public int GetStudentCount()
        {
            return students.Count;
        }

        // Clear all students
        public void ClearAllStudents()
        {
            students.Clear();
        }
    }
}
