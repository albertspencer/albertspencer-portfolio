# Lab 10 — ASP.NET Core Razor Pages + EF Core

A full **ASP.NET Core Razor Pages** application backed by **Entity Framework Core**. This project demonstrates CRUD pages, EF Core **Migrations/**, and a clean separation across `Pages/`, `Models/`, and static assets in `wwwroot/`.

## ✨ What this demonstrates
- Razor Pages with `PageModel` handlers (`OnGet/OnPost`)
- **EF Core** with `DbContext`, entities, and **Migrations/**
- Validation attributes and model binding
- Static assets under `wwwroot/` (css/js/img)
- Environment config via `appsettings*.json`

## 🧰 Tech Stack
- .NET / C#
- ASP.NET Core Razor Pages
- Entity Framework Core (SQLite or your DB of choice)

## ▶️ Run locally
```bash
dotnet build
dotnet run
# open the URL printed by Kestrel (e.g., http://localhost:5093)
```

### Database setup
This repo ships with **placeholder** connection strings. To run with a database:

1. Open `appsettings.Development.json` and set:
```json
{
  "ConnectionStrings": { "DefaultConnection": "YOUR_CONNECTION_STRING_HERE" }
}
```
2. If migrations are present (see `Migrations/`), apply them:
```bash
dotnet tool install --global dotnet-ef   # if needed
dotnet ef database update
```

> Do not commit real credentials/connection strings.

