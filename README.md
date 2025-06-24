<<<<<<< HEAD
# BookMart 📚

A full-stack e-commerce bookstore built with ASP.NET Core 8.0 MVC, providing a comprehensive platform for online book sales with separate customer and administrator interfaces.

## 🌟 Features

### Customer Features
- Browse and search books by various criteria
- Shopping cart management with real-time updates
- Secure checkout process
- Order tracking and history
- User profile management
- Address management
- Personalized book recommendations

### Admin Features
- Comprehensive dashboard with sales analytics
- Inventory management system
- Order processing and tracking
- Stock level monitoring with alerts
- Book and genre management
- Customer order management
- Sales and revenue reports

## 🛠️ Technology Stack

- **Backend**: ASP.NET Core 8.0 MVC
- **Database**: SQL Server
- **ORM**: Entity Framework Core 9.0.5
- **Authentication**: Cookie-based with BCrypt.NET-Core
- **Frontend**: Bootstrap, jQuery, Font Awesome
- **JSON Handling**: Newtonsoft.Json

## 🚀 Getting Started

### Prerequisites

- Visual Studio 2022 or later
- SQL Server 2019 or later
- .NET SDK 8.0
- Node.js (for frontend package management)

### Installation

1. Clone the repository
```bash
git clone [repository-url]
```

2. Update the connection string in `appsettings.json`:
```json
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=YOUR_SERVER;Database=BookMartDB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;"
    }
}
```

3. Apply database migrations:
```bash
dotnet ef database update
```

4. Run the application:
```bash
dotnet run
```

## 🏗️ Architecture

The application follows the MVC pattern with a clean separation of concerns:

```
BookMart/
├── Controllers/         # Request handling and business logic
├── Models/             # Domain models and ViewModels
├── Views/              # Razor views for UI
├── Data/              # Database context and configurations
└── wwwroot/           # Static files (CSS, JS, images)
```

## 🔒 Security Features

- BCrypt password hashing
- Anti-forgery token validation
- HTTP-only cookies
- Role-based access control (Admin/User)
- Input validation and sanitization
- XSS prevention
- CSRF protection

## 💾 Database Design

- Code-First approach with Entity Framework Core
- Proper relationships and constraints
- Optimized indexing strategy
- Audit trails for critical operations
- Concurrency handling

## ⚡ Performance Features

- Async/await patterns for scalability
- Strategic database indexing
- Efficient query optimization
- Client-side caching
- Image optimization
- Bundling and minification

## 🧪 Testing

- Unit tests for business logic
- Integration tests for API endpoints
- UI automation tests
- Performance testing
- Security testing

## 📊 Monitoring & Logging

- Structured logging
- Performance monitoring
- Error tracking
- User activity monitoring
- Stock level alerts

## 🚀 Deployment

- Supports Azure deployment
- CI/CD pipeline ready
- Environment-specific configurations
- Health monitoring
- Backup and recovery procedures

## 🔄 Best Practices

- Clean Code principles
- SOLID design principles
- Dependency Injection
- Repository Pattern
- Proper error handling
- Comprehensive logging
- Security best practices

## 📝 API Documentation

API documentation is available at `/swagger` when running in Development mode.

## 🤝 Contributing

Please read CONTRIBUTING.md for details on our code of conduct and the process for submitting pull requests.

## 📜 License

This project is licensed under the MIT License - see the LICENSE.md file for details

## 🎯 Future Improvements

- Payment gateway integration
- Real-time notifications
- Advanced search features
- Mobile application
- Analytics dashboard enhancement
- Cache implementation
- Performance optimization
- API documentation
- Multilingual support
- Reviews and ratings system
=======
# BookMart

## Overview
BookMart is a modern web application designed for book enthusiasts. It provides a seamless experience for users to browse, purchase, and manage their book orders. The application features a clean, black and white theme with smooth transitions and animations, ensuring a visually appealing and user-friendly interface.

## Features
- **User Authentication:** Secure login and registration system.
- **Book Browsing:** Users can explore a wide range of books with detailed descriptions.
- **Shopping Cart:** Add books to the cart, view cart details, and proceed to checkout.
- **Order Management:** Track and manage orders with a modern UI.
- **Admin Dashboard:** Comprehensive admin interface for managing books, orders, and user accounts.
- **Responsive Design:** Fully responsive layout for desktop and mobile devices.

## Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/BookMart.git
   ```
2. Navigate to the project directory:
   ```bash
   cd BookMart
   ```
3. Install dependencies:
   ```bash
   dotnet restore
   ```
4. Run the application:
   ```bash
   dotnet run
   ```

## Usage
- **User Registration/Login:** Create an account or log in to access personalized features.
- **Browse Books:** Use the search bar to find books or browse categories.
- **Add to Cart:** Select books and add them to your cart.
- **Checkout:** Review your cart and proceed to checkout.
- **Admin Access:** Log in as an admin to manage books and orders.

## Design Principles
- **Modern UI:** Utilizes a black and white theme with smooth transitions and animations.
- **User Experience:** Focuses on intuitive navigation and responsive design.
- **Accessibility:** Ensures the application is accessible to all users.

## Contributing
Contributions are welcome! Please open an issue or submit a pull request for any improvements or bug fixes.

## License
This project is licensed under the MIT License - see the LICENSE file for details.

## Technologies Used
- **Backend:** ASP.NET Core, C#
- **Frontend:** HTML, CSS, JavaScript
- **Database:** SQL Server
- **Authentication:** ASP.NET Core Identity
- **UI Framework:** Bootstrap 5
- **Version Control:** Git



>>>>>>> 240bdea2d220685cc763160160911d56d7405be0
