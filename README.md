
# Student CRUD Application

An ASP.NET Core MVC application for managing
student records using SQLite and Entity Framework Core.

## Features

- Create student records
- View registered students
- Update student information
- Delete student records
- Form validation
- SQLite database integration

## Technologies Used

- C#
- ASP.NET Core MVC
- Entity Framework Core
- SQLite
- Bootstrap
- Razor Views

## Database Structure

### Students

| Column | Type |
|---|---|
| StudentId | Integer |
| Name | Text |
| Section | Text |
| EmailId | Text |
| Branch | Text |

## Installation

1. Clone the repository.
2. Navigate to the StudentCRUD directory.
3. Restore dependencies:

   dotnet restore

4. Apply database migrations:

   dotnet ef database update

5. Run the application:

   dotnet run

## CRUD Operations

| Operation | Description |
|---|---|
| Create | Add a student |
| Read | View students |
| Update | Edit student details |
| Delete | Remove a student |

## Author

Michael Angelo Ricamata

## License

For educational purposes.
