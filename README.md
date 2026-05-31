# 🏫 School Management System

A comprehensive desktop-based School Management System built with **C# Windows Forms** and **SQL Server**, designed to streamline school operations for Administrators and Teachers.

---

## 📋 Table of Contents

- [About the Project](#about-the-project)
- [Features](#features)
- [Tech Stack](#tech-stack)
- [Project Structure](#project-structure)
- [Database Setup](#database-setup)
- [Getting Started](#getting-started)
- [Screenshots](#screenshots)
- [Usage](#usage)
- [Contributing](#contributing)

---

## 📖 About the Project

The **School Management System** is a multi-role desktop application that allows school administrators and teachers to manage day-to-day academic and administrative tasks efficiently. It features a clean sidebar navigation UI with role-based dashboards, full CRUD operations, and real-time database interaction via SQL Server.

---

## ✨ Features

### 🔐 Authentication
- Secure role-based login for **Administrator** and **Teacher**
- Password validation with active/inactive user status
- Last login timestamp tracking

### 👨‍💼 Admin Dashboard
- Dynamic greeting based on time of day
- Collapsible sidebar navigation with submenus
- Access to all management modules

### 👨‍🎓 Student Management
- Add new students
- Modify existing student records
- Remove students from the system

### 👨‍🏫 Teacher Management
- Add new teachers
- Modify teacher information
- Remove teachers from the system

### 📚 Academic Management
- View class assignments
- Update class assignments

### 💰 Fee Management
- Submit monthly fee payments
- Submit annual charges
- View paid students
- View unpaid students

### 👔 Teacher Attendance & Salary
- Mark teacher attendance
- Process teacher salary payments

### 📊 Results & Marks
- Add student marks
- Modify existing marks
- View student results
- Generate result cards

### 🗓️ Attendance
- Mark student attendance
- View past attendance records

### 🕐 Timetable
- Class timetable management

---

## 🛠️ Tech Stack

| Technology | Details |
|---|---|
| **Language** | C# (.NET Framework) |
| **UI Framework** | Windows Forms (WinForms) |
| **Database** | Microsoft SQL Server (SQL Express) |
| **IDE** | Visual Studio |
| **DB Access** | ADO.NET (`SqlConnection`, `SqlCommand`, `SqlDataAdapter`) |

---

## 📁 Project Structure

```
SchoolManagementSystem/
│
├── LoginForm.cs                        # Entry point - login screen
├── Program.cs                          # Application startup
├── DatabaseHelper.cs                   # Centralized DB connection & query helper
│
├── AdminDashboard.cs                   # Admin home with sidebar navigation
├── TeacherDashboard.cs                 # Teacher home dashboard
│
├── AddStudentForm.cs                   # Add new student
├── ModifyStudentForm.cs                # Edit student records
├── RemoveStudentForm.cs                # Delete student
│
├── AddTeacherForm.cs                   # Add new teacher
├── ModifyTeacherForm.cs                # Edit teacher records
├── RemoveTeacherForm.cs                # Delete teacher
│
├── AddMarksForm.cs                     # Enter student marks
├── ModifyMarksForm.cs                  # Update student marks
├── ViewResultForm.cs                   # View student results
├── GenerateResultCardForm.cs           # Generate result cards
│
├── AttendanceForm.cs                   # Mark student attendance
├── ViewPastAttendanceForm.cs           # View attendance history
├── MarkTeacherAttendanceForm.cs        # Mark teacher attendance
│
├── ClassTimetableForm.cs               # Manage class timetable
├── ViewClassAssignmentsForm.cs         # View teacher-class assignments
├── UpdateClassAssignmentForm.cs        # Update class assignments
│
├── SubmitMonthlyFeeForm.cs             # Process monthly fee
├── SubmitAnnualFeeForm.cs              # Process annual charges
├── ViewPaidStudentsForm.cs             # List of fee-paid students
├── ViewUnpaidStudentsForm.cs           # List of pending-fee students
│
├── PayTeacherSalaryForm.cs             # Process teacher salary
│
├── SchoolManagementSystem.csproj       # Project file
├── bin/Debug/                          # Compiled output
└── obj/                                # Build objects
```

---

## 🗄️ Database Setup

The application connects to a **SQL Server Express** instance. Update the connection string in `DatabaseHelper.cs` to match your environment:

```csharp
private static readonly string connectionString =
    @"Data Source=YOUR_SERVER\SQLEXPRESS;
      Initial Catalog=SchoolManagementSystem;
      Integrated Security=True;
      TrustServerCertificate=True;";
```

Replace `YOUR_SERVER` with your machine/server name (e.g., `DESKTOP-ABC\SQLEXPRESS`).

### Required Tables (example structure)

The database should include at minimum the following tables:
- `User` — stores login credentials (Username, Password, UserType, ReferenceID, IsActive, LastLogin)
- `Administrator` — admin profiles (AdminID, FullName)
- `Principal` — principal profiles (PrincipalID, FullName)
- `Teacher` — teacher profiles (TeacherID, Name, ...)
- `Student` — student records
- `Attendance` — student & teacher attendance
- `Marks` — student marks per subject
- `Fee` — monthly and annual fee records
- `Salary` — teacher salary records
- `ClassAssignment` — teacher-to-class mappings
- `Timetable` — class schedule entries

---

## 🚀 Getting Started

### Prerequisites

- Windows OS
- [Visual Studio](https://visualstudio.microsoft.com/) (2019 or later recommended)
- [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- .NET Framework (4.7.2 or compatible)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/ZarwaAyaz/School-Management-System-Database-.git
   ```

2. **Open the project**
   - Launch Visual Studio
   - Open `SchoolManagementSystem.csproj`

3. **Configure the database**
   - Create a SQL Server database named `SchoolManagementSystem`
   - Run your SQL scripts to create the required tables
   - Update the connection string in `DatabaseHelper.cs`

4. **Build and run**
   - Press `Ctrl + F5` or click **Start** in Visual Studio

---

## 📸 Screenshots


4. **Embed them in this README** by replacing the placeholder lines below:

```markdown
### Login Screen
![Login Screen](screenshots/login.png)

### Admin Dashboard
![Admin Dashboard](screenshots/admin-dashboard.png)

### Student Management
![Add Student](screenshots/add-student.png)

### Fee Management
![Fee Management](screenshots/fee-management.png)

### Result Card
![Result Card](screenshots/result-card.png)
```

---

## 🧑‍💻 Usage

### Login Roles

| Role | Access |
|---|---|
| **Administrator** | Full access to all modules |
| **Teacher** | Access to marks, attendance, timetable, and results |

### Workflow Example (Admin)

1. Login with Administrator credentials
2. From the sidebar, expand **Student Management**
3. Click **Add Student** to enroll a new student
4. Expand **Fee Management** → **Submit Monthly Fee** to record a payment
5. Expand **Teacher Attendance & Salary** → **Pay Teacher Salary** to process payroll

---

## 👩‍💻 Author

**Zarwa Ayaz**
- GitHub: [@ZarwaAyaz](https://github.com/ZarwaAyaz)

---

> Built as a database systems project using C# Windows Forms and SQL Server.
