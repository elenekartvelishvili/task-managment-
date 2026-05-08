# Task Management API

A RESTful Web API built with ASP.NET Core and Entity Framework Core for managing tasks.  
This project was created to practice backend development concepts such as CRUD operations, layered architecture, REST APIs, SQL Server integration, and SOLID principles.

## Features

- Create new tasks
- Retrieve all tasks
- Retrieve task by ID
- Update existing tasks
- Delete tasks
- SQL Server database integration
- Swagger API documentation
- Clean layered architecture using interfaces and services

## Technologies Used

- ASP.NET Core Web API
- C#
- Entity Framework Core
- SQL Server
- Swagger
- REST API Architecture

## Project Structure

TaskManagementAPI
│
├── Controllers
├── Models
├── Interfaces
├── Services
├── Data
├── Migrations
└── Program.cs

## API Endpoints

| Method | Endpoint            | Description            |
|--------|---------------------|------------------------|
| GET    | /api/tasks          | Get all tasks          |
| GET    | /api/tasks/{id}     | Get task by ID         |
| POST   | /api/tasks          | Create new task        |
| PUT    | /api/tasks/{id}     | Update existing task   |
| DELETE | /api/tasks/{id}     | Delete task            |

## Example JSON Request

```json
{
  "title": "Study ASP.NET Core",
  "description": "Practice building REST APIs",
  "isCompleted": false,
  "dueDate": "2026-05-20"
}
