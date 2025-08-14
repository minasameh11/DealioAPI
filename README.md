# DealioAPI

DealioAPI is a RESTful API for managing and selling used products.  
It allows users to list items for sale, browse available products, and manage offers securely.

---

## ✨ Features

- **User Authentication & Authorization** – Secure login and registration.
- **Product Listings** – Create, update, and delete used product entries.
- **Search & Filter** – Find products by category, price range, or keywords.
- **Offer Management** – Send and manage offers on products.
- **Secure Data Handling** – Built with best practices for API security.

---

## ⚙️ Prerequisites

- [.NET 7.0 SDK or higher](https://dotnet.microsoft.com/en-us/download/dotnet)
- SQL Server (or any supported database)
- Git

---

## 🚀 Installation & Setup

```bash
# Clone the repository
git clone https://github.com/minasameh11/DealioAPI.git
cd DealioAPI

# Restore dependencies
dotnet restore

# Update database (Entity Framework migrations)
dotnet ef database update

# Build the project
dotnet build

# Run the API
dotnet run --project Dealio.API/Dealio.API.csproj
