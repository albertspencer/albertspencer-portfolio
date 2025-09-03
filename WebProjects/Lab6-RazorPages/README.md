# Lab 6 – ASP.NET Core Razor Pages Web App

A small **ASP.NET Core Razor Pages** application demonstrating page handlers, model binding, validation, and organized page structure with `Pages/`, `Models/`, and static assets under `wwwroot/`. This project is cleaned for a public portfolio (no build artifacts or secrets).

## ✨ What this demonstrates
- ASP.NET Core **Razor Pages** architecture (no MVC boilerplate)
- **PageModel** classes with handlers (`OnGet`, `OnPost`, etc.)
- **Model binding** and **data validation** attributes
- Separation of concerns with `Models/` and `Pages/`
- Static content organization in `wwwroot/` (css/js/img)
- Environment-based configuration via `appsettings*.json`

## 🧰 Tech Stack
- .NET / C#
- ASP.NET Core Razor Pages
- (Optional) EF Core if a DbContext is added later

## 🗂 Project Structure
```text
lab-6-albertspencer/
├─ Models/
├─ Pages/
├─ Properties/
├─ wwwroot/
├─ Program.cs
├─ lab-6-albertspencer.csproj
├─ appsettings.json                 # scrubbed (placeholder connection string)
├─ appsettings.Development.json     # scrubbed (placeholder connection string)
└─ .gitignore
```

## ▶️ How to Run
```bash
dotnet build
dotnet run
# then open the shown URL, e.g. https://localhost:5001
```

> If the app uses a database, set a real value for `ConnectionStrings:DefaultConnection`
> in `appsettings.Development.json` (do **not** commit secrets). For EF Core:
>
> ```bash
> dotnet tool install --global dotnet-ef  # if needed
> dotnet ef database update               # apply migrations
> ```

## 📸 Screenshot (optional)
Add a `screenshots/` folder with a UI screenshot and link it here.
