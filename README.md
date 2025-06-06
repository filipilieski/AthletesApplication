# 🏅 AthletesApplication

A full-stack ASP.NET Core MVC application for managing athletes, teams, tournaments, and participations. Built using clean architecture principles with Entity Framework Core and layered separation of concerns.

---

## 📌 Features

- 🧍‍♂️ Manage Athletes (CRUD)
- 🏆 Manage Teams and assign athletes
- 🎯 Track Tournament participations
- 📊 Display athlete/team statistics
- 🔐 Identity-based authentication
- 💡 Clean architecture with services & repositories

---

## 🛠 Tech Stack

| Layer                     | Tech                                  |
|---------------------------|---------------------------------------|
| Frontend (Views)          | Razor Pages, Bootstrap                |
| Backend (Web/API)         | ASP.NET Core MVC                      |
| Business Logic Layer      | C# Services with Interfaces           |
| Data Access Layer         | Entity Framework Core                 |
| Database                  | SQL Server (localdb or configured)    |
| Identity & Auth           | ASP.NET Core Identity                 |

---

## 🗂 Project Structure

```
AthletesApplication/
│
├── AthletesApplication.sln         # Solution file
├── AthletesApplication.Domain/     # Entity models
├── AthletesApplication.Repository/ # Data access (EF Core)
├── AthletesApplication.Service/    # Business logic layer
├── AthletesApplication.Web/        # MVC controllers & views
└── README.md                       # This file
```

---

## 🚀 Getting Started

1. **Clone the repository**
   ```bash
   git clone https://github.com/filipilieski/AthletesApplication.git
   cd AthletesApplication
   ```

2. **Open in Visual Studio**

   Open `AthletesApplication.sln`
   
   
4. **Apply EF Core migrations**
   In the Package Manager Console:
   ```bash
   Update-Database
   ```

5. **Run the project**
   
   Press `F5` or run with `dotnet run` if using CLI.

---

## 📸 Screenshots

#TODO
---

## 👨‍💻 Author

**Filip Ilieski**  
Computer Science Student  
[GitHub](https://github.com/filipilieski)
