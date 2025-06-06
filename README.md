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

![image](https://github.com/user-attachments/assets/8fb7775c-6428-4440-b297-62692b1ee3fc)
![image](https://github.com/user-attachments/assets/795d96ac-12b6-476a-bff8-b2e2356d7985)
![image](https://github.com/user-attachments/assets/86ab424b-b7f1-425d-a6f1-11e4a7943c54)
![image](https://github.com/user-attachments/assets/e8a23454-db20-4d0b-9ef5-947ed459779f)
![image](https://github.com/user-attachments/assets/d7688e4d-5ba6-4a50-a9b9-51afa4a01605)
![image](https://github.com/user-attachments/assets/742e62db-e685-4900-a437-7f946ae33b5f)
![image](https://github.com/user-attachments/assets/89bb50f9-fde4-48ac-8930-e2e7e0b1bbcd)

---

## 👨‍💻 Author

**Filip Ilieski**  
Computer Science Student  
[GitHub](https://github.com/filipilieski)
