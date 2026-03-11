# Digital Shop Software

A comprehensive Enterprise Resource Planning (ERP) system built with .NET 6.0 and Windows Forms for managing digital shop operations. This application provides a complete solution for handling customers, suppliers, inventory, orders, users, and reporting.

## Features

### User Management
- User authentication and login system
- Password reset functionality
- Role-based access control

### Customer Management
- Add, view, and manage customer information
- Track customer registration dates, order history, and contact details
- Link customers to user accounts

### Supplier Management
- Manage supplier information and contacts
- Track supplier relationships

### Inventory Management
- Stock tracking and management
- Add new stock items
- Monitor inventory levels

### Order Management
- Create and manage client orders
- Purchase order processing
- Order history and tracking

### Reporting
- Generate various reports
- Data analysis and visualization

### Additional Features
- Main menu navigation
- Form-based user interface
- SQLite database integration

## Technologies Used

- **Framework**: .NET 6.0 Windows Forms
- **Database**: SQLite
- **Language**: C#
- **UI**: Windows Forms

## Prerequisites

- Windows operating system
- .NET 6.0 SDK installed
- SQLite database engine

## Installation

1. Clone or download the project repository
2. Ensure .NET 6.0 SDK is installed on your system
3. The project uses NuGet packages, which will be restored automatically

## Database Setup

The application uses a SQLite database located in the `Digital Shop Database` folder. The database file is `Digital Shop Database.db`. The database connection is established automatically when the application starts.

Key database tables include:
- Users
- Client (Customers)
- Suppliers
- Stock
- Orders
- And others as defined in the application

## How to Run

1. Open the solution file `Digital Shop Software.sln` in Visual Studio
2. Build the project (Ctrl+Shift+B)
3. Run the application (F5 or Ctrl+F5)
4. The application will start with the Login form

## Project Structure

```
Digital Shop Software/
├── Program.cs                    # Application entry point
├── Database.cs                   # Database connection management
├── Login.cs                      # User authentication form
├── MainMenu.cs                   # Main navigation menu
├── User.cs                       # User management logic
├── Customer.cs                   # Customer management logic
├── Supplier.cs                   # Supplier management logic
├── Stock.cs                      # Inventory management logic
├── Order.cs                      # Order processing logic
├── Report.cs                     # Reporting functionality
├── Forms/                        # Windows Forms files
│   ├── AddClientOrder.cs
│   ├── AddCustomer.cs
│   ├── AddPurchaseOrder.cs
│   ├── AddStock.cs
│   ├── AddSupplier.cs
│   ├── AddUser.cs
│   ├── Customers.cs
│   ├── Orders.cs
│   ├── Products.cs
│   ├── Reports.cs
│   ├── ResetPassword.cs
│   ├── Stock.cs
│   ├── Suppliers.cs
│   └── Users.cs
├── Digital Shop Software.csproj  # Project configuration
├── Digital Shop Database/        # Database files
└── Resources/                    # Application resources
```

## Key Classes

- **Database**: Singleton pattern for SQLite connection management
- **User**: Handles user authentication and user data operations
- **Customer**: Manages customer information and operations
- **MainMenu**: Main application navigation and form hosting
- **Login**: User login interface and validation

## Contributing

1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Test thoroughly
5. Submit a pull request

## License

This project is proprietary software. Please refer to the license file for usage rights.

## Support

For support or questions, please contact the development team.