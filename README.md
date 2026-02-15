# Student Grade Management System

A Windows Forms application built with C# that allows users to manage student records and grades efficiently.

## Features

- **Add Student**: Add students with their names and grades (0-100)
- **Display All Students**: View all registered students with their grades and categories
- **Search Student**: Find a specific student by name and view their grade
- **Calculate Average**: Get the average grade of all students
- **Find Highest & Lowest**: Quickly identify the best and worst performing students
- **Grade Categories**: Automatically categorizes grades into:
  - Excellent (80-100)
  - Better (70-79)
  - Good (60-69)
  - Pass (50-59)
  - Fail (0-49)

## Technical Features

- Uses `Dictionary<string, int>` to store student data
- Comprehensive error handling for invalid inputs
- Input validation for grades (must be 0-100)
- Prevents duplicate student entries
- Clean and intuitive Windows Forms UI
- Uses LINQ methods (`Max()`, `Min()`, `Average()`)
- Implements enums for grade categorization

## Requirements

- .NET 8.0 or higher
- Windows Operating System
- Visual Studio 2022 (or higher) or .NET SDK

## How to Run

### Option 1: Using Visual Studio

1. Open the project folder in Visual Studio
2. Open `StudentGradeManagement.csproj`
3. Press `F5` or click the "Start" button to run the application

### Option 2: Using Command Line

1. Open a terminal/command prompt in the project directory
2. Run the following commands:

```bash
dotnet restore
dotnet build
dotnet run
```

## Usage Guide

### Adding a Student
1. Enter the student's name in the "Student Name" field
2. Enter a grade between 0 and 100 in the "Grade" field
3. Click "Add Student" button
4. The system will confirm the addition and display the grade category

### Viewing All Students
- Click the "Display All Students" button to see a formatted list of all students with their grades and categories(it automatical show it self no problem )

### Searching for a Student
1. Enter the student's name in the search field
2. Click "Search" button
3. View the student's grade and category in a popup message

### Calculating Average
- Click "Calculate Average" to see the mean grade of all students

### Finding Highest and Lowest Grades
- Click "Highest & Lowest" to view the top and bottom grades in the system

### Clearing All Data
- Click "Clear All Students" to remove all records (confirmation required)

## Error Handling

The application handles various error scenarios:
- Empty or invalid student names
- Out-of-range grades (not between 0-100)
- Duplicate student names
- Searching for non-existent students
- Calculating statistics with no data
- Invalid numeric input

## Project Structure

```
Student Grade Management System/
├── Program.cs                 # Application entry point
├── MainForm.cs                # Main form logic and event handlers
├── MainForm.Designer.cs       # UI design and component initialization
├── StudentManager.cs          # Business logic for managing students
├── GradeCategory.cs           # Enum for grade categories
├── StudentGradeManagement.csproj  # Project configuration
└── README.md                  # This file
```

## Code Highlights

- **Data Structure**: Dictionary for O(1) lookup performance
- **LINQ Integration**: Uses Max(), Min(), and Average() for calculations
- **Exception Handling**: Try-catch blocks with specific exception types
- **Separation of Concerns**: UI logic separate from business logic
- **User-Friendly**: Clear error messages and confirmation dialogs

## Author

Created as part of a C# learning assignment focusing on:
- Data structures (Dictionary, List)
- Control flow (if/else, loops)
- Functions and methods
- Exception handling
- Windows Forms 

## Video Link 
- https://youtu.be/D_VnPaHWcYo

## License

This project is created for educational purposes.
