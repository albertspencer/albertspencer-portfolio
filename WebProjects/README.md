# Lab 10 — Razor Pages + EF Core Web Application

This project is a full **ASP.NET Core Razor Pages** application backed by **Entity Framework Core (EF Core)**. It demonstrates how to build a dynamic web application with CRUD functionality, validation, and database persistence.

---

## ✨ Features
- Razor Pages with `PageModel` handlers (`OnGet`, `OnPost`)
- **Entity Framework Core** for data access
- Database Migrations (see `Migrations/` folder)
- Validation attributes and model binding
- Static assets served from `wwwroot/` (CSS/JS/images)
- Configurable connection string via `appsettings.json`

---

## 🧰 Tech Stack
- ASP.NET Core Razor Pages
- Entity Framework Core (SQLite in development)
- C# (.NET 9)

---

## ▶️ How to Run

```bash
# move into the project folder
cd WebProjects/Lab10-RazorPages-EFCore/lab-10-albertspencer

# build and run
dotnet build
dotnet run
