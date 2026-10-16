# 🛍️ Product Catalog

A clean and simple ASP.NET MVC web application for managing and displaying a product catalog with product details, categories, prices, and images.

---

## 🌟 Features

- **Product Listing**: Displays product cards with image, product name, category, and price.
- **ASP.NET MVC Architecture**: Built using standard MVC pattern (Model, View, Controller).
- **Responsive Layout**: Includes top navigation bar, banner section, and footer.
- **Razor Views**: Clean, strongly-typed Razor view rendering (`@model List<Product>`).

---

## 🛠️ Tech Stack

- **Framework**: ASP.NET MVC 5 (.NET Framework 4.7.2)
- **Language**: C#
- **View Engine**: Razor (`.cshtml`)
- **Server**: IIS Express / IIS

---

## 📁 Project Structure

```text
ProductCatalog/
├── ProductCatalog/
│   ├── App_Start/
│   │   └── RouteConfig.cs       # Custom route configurations
│   ├── Controllers/
│   │   └── ProductController.cs # Product logic & data source
│   ├── Models/
│   │   └── Product.cs           # Product entity model
│   ├── Views/
│   │   ├── Product/
│   │   │   └── Index.cshtml     # Product catalog catalog view
│   │   └── Shared/
│   │       └── _Layout.cshtml   # Master layout with banner & navigation
│   ├── Content/
│   │   ├── images/              # Banner and product images
│   │   └── Site.css             # Custom styles
│   └── Web.config               # Application configuration
├── ProductCatalog.sln           # Visual Studio solution file
└── README.md
```

---

## 🚀 How to Run Locally

### Option 1: Visual Studio
1. Open `ProductCatalog.sln` in **Visual Studio 2022** (or 2019).
2. Right-click on the `ProductCatalog` project and click **Build**.
3. Press `F5` or `Ctrl + F5` to run with IIS Express.

### Option 2: IIS Express via Command Line
```powershell
& "C:\Program Files\IIS Express\iisexpress.exe" /path:"<path-to-ProductCatalog-folder>" /port:5000
```
Then visit: `http://localhost:5000/`

---

## 👤 Author

Developed by [Ayush Sharma](https://github.com/ius-sharma)
