# LINQ Exercise

A simple ASP.NET Core MVC project created for practicing LINQ queries using Repository and Service patterns.

---

## 📖 About The Project

This project demonstrates how to use LINQ in a layered ASP.NET Core MVC application.

Product data is stored statically in the `ProductRepository`, and all LINQ queries are implemented inside the `ProductService` layer.

---

## 🏗️ Project Architecture

| Layer          | Responsibility                           |
| -------------- | ---------------------------------------- |
| **Repository** | Provides access to product data          |
| **Service**    | Contains business logic and LINQ queries |
| **Controller** | Handles requests and returns responses   |
| **View**       | Displays data to users                   |

---

## 📂 Project Structure

```text
LINQExercise
│
├── Controllers
│   └── ProductController.cs
│
├── Data
│   ├── IProductRepository.cs
│   └── ProductRepository.cs
│
├── Models
│   ├── Product.cs
│   └── Categories.cs
│
├── Services
│   ├── IProductService.cs
│   └── ProductService.cs
│
├── Views
│   ├── Product
│   │   ├── Index.cshtml
│   │   └── _AnswerModal.cshtml
│   │
│   ├── Shared
│   │   ├── _Layout.cshtml
│   │   └── _ValidationScriptsPartial.cshtml
│   │
│   ├── _ViewImports.cshtml
│   └── _ViewStart.cshtml
│
├── Program.cs
└── appsettings.json
```

---

## 📦 Sample Data

```csharp
new Product
{
    Id = 1,
    Name = "Product A",
    Category = Categories.Category1,
    Price = 100
};

new Product
{
    Id = 2,
    Name = "Product B",
    Category = Categories.Category1,
    Price = 150
};

new Product
{
    Id = 3,
    Name = "Product C",
    Category = Categories.Category2,
    Price = 120
};

new Product
{
    Id = 4,
    Name = "Product D",
    Category = Categories.Category3,
    Price = 200
};

new Product
{
    Id = 5,
    Name = "Product E",
    Category = Categories.Category1,
    Price = 80
};
```

---

## 🎯 Implemented LINQ Queries

### 1️⃣ Get Products By Category

```csharp
_repository
    .GetAll()
    .Where(p => p.Category == Categories.Category1);
```

### 2️⃣ Get Most Expensive Product

```csharp
_repository
    .GetAll()
    .OrderByDescending(p => p.Price)
    .FirstOrDefault();
```

### 3️⃣ Calculate Total Price

```csharp
_repository
    .GetAll()
    .Sum(p => p.Price);
```

**Result**

```text
650
```

### 4️⃣ Group Products By Category

```csharp
_repository
    .GetAll()
    .GroupBy(p => p.Category);
```

### 5️⃣ Calculate Average Price

```csharp
_repository
    .GetAll()
    .Average(p => (double)p.Price);
```

**Result**

```text
130
```

---

## 🛠️ Technologies Used

* ASP.NET Core MVC (.NET 8)
* C#
* LINQ
* Repository Pattern
* Service Pattern
* Bootstrap
* Git
* GitHub

---

## 🚀 Getting Started

### Clone Repository

```bash
git clone https://github.com/MasoudMiri/LINQExercise.git
```

### Restore Packages

```bash
dotnet restore
```

### Build Project

```bash
dotnet build
```

### Run Project

```bash
dotnet run
```

Open your browser and navigate to:

```text
https://localhost:xxxx/Product/Index
```

---

## 📸 Features

✅ LINQ Filtering

✅ Sorting

✅ Aggregation (Sum, Average)

✅ Grouping

✅ Repository Pattern

✅ Service Layer Architecture

✅ ASP.NET Core MVC

---

## 👨‍💻 Author

**Masoud Miri**

📧 Email: [masoudmiri7667@gmail.com](mailto:masoudmiri7667@gmail.com)

🔗 GitHub: https://github.com/MasoudMiri

---

## ⭐ Support

If you found this project useful, please consider giving it a star on GitHub.

## Documentation

- [LINQ Queries Explanation](./LINQ-Queries-Explanation.md)
