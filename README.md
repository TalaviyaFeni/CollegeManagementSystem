# 🎓 College Management System (ASP.NET Core MVC)

A complete **College Management System** built with **ASP.NET Core MVC** and **Entity Framework Core**, designed to manage Students, Faculties, Departments, Courses, and Results — all through a modern, real-time updating dashboard.

---

## 🚀 Features

- 🧑‍🎓 **Student Management** — Add, view, edit, and delete students.
- 👨‍🏫 **Faculty Management** — Manage faculty information.
- 🏢 **Department Management** — Create and organize departments.
- 📚 **Course Management** — Assign and manage courses.
- 🧾 **Result Management** — Record and view student results.
- 📊 **Dashboard** — Live count updates with clickable cards.
- 💡 **Modern UI** — Clean and responsive design with hover effects.
- ⚡ **Real-Time Dashboard Updates** — Uses AJAX to refresh counts every 5 seconds.

---

## 🏗️ Tech Stack

| Layer | Technology |
|-------|-------------|
| Frontend | Razor Views, Bootstrap 5, jQuery |
| Backend | ASP.NET Core MVC 9.0 |
| ORM | Entity Framework Core |
| Database | SQLite (default) |
| Language | C# |
| Styling | Bootstrap Icons + Custom CSS |

---

## ⚙️ Installation Guide

### 2️⃣ Install Dependencies

```bash
dotnet restore
```

### 3️⃣ Apply Migrations and Update Database

```bash
dotnet ef migrations add InitDb --context ApplicationDbContext
dotnet ef database update --context ApplicationDbContext
```

### 4️⃣ Run the Application

```bash
dotnet run
```

Now open in browser:  
👉 http://localhost:5001  

---

## 🧑‍💻 Developer

**Author:** Feni Talaviya  
📧 Email: 23amtics436@gmail.com 
💻 GitHub Profile :- https://github.com/TalaviyaFeni




