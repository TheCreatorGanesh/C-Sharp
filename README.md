# C# Learning & Design Patterns Repository

A comprehensive collection of C# projects demonstrating various programming concepts, design patterns, authentication mechanisms, and event-driven architecture.

---

## 📚 Projects Overview

### 1. **CodingSolutions**
**Location:** `/CodingSolutions/`

A console application demonstrating string manipulation and character analysis.

**Key Features:**
- String utility extension methods
- Character occurrence counter
- Console output examples

**Main Components:**
- `Program.cs` - Entry point demonstrating the letter occurrence counter
- `Functions.cs` - Contains `PrintLetterOccurrencesInString()` extension method that counts and displays occurrences of each non-space character in a string

**Usage Example:**
```csharp
string str = "Ganesh lives in india";
str.PrintLetterOccurrencesInString();
// Output: Letter G occured 1 time(s), a occured 3 time(s), etc.
```

---

### 2. **Cookie-based-authentication**
**Location:** `/Cookie-based-authentication/`

An ASP.NET Core web application implementing cookie-based authentication with role-based authorization.

**Key Features:**
- Cookie-based authentication system
- Role-based access control (Admin & User roles)
- Custom claim-based authorization policies
- Login/Logout functionality
- Access denied handling

**Project Structure:**
- `Program.cs` - Configures authentication and authorization middleware
- `Settings.cs` - Application settings configuration
- **Controllers/**
  - `AuthController.cs` - Handles login/logout operations
  - `HomeController.cs` - Main application controller
- **Models/**
  - `LoginFormModel.cs` - Login form model
  - `UserManager.cs` - User account management with predefined users (admin/user)
- **Views/** - Razor templates for UI rendering

**Authentication Configuration:**
- Two default users: `admin`/`admin123` and `user`/`user123`
- Claims-based authorization policies for Admin and User roles
- Secure cookie configuration with encrypted credentials

---

### 3. **VirtualMethods**
**Location:** `/VirtualMethods/`

A console application demonstrating polymorphism through virtual methods and method overriding in C#.

**Key Features:**
- Virtual method declarations
- Method overriding in derived classes
- Polymorphic behavior demonstration
- Base class reference with derived class objects

**Main Components:**
- `Program.cs` - Demonstrates three scenarios of virtual method usage
- `Data.cs` - Contains `BaseClass` and `DerivedClass` implementations

**Concepts Demonstrated:**
1. **Virtual Methods:** Base class methods marked as virtual that can be overridden
2. **Non-virtual Methods:** Regular methods that cannot be overridden (method hiding)
3. **Polymorphic Behavior:** How base class references call derived class methods

---

### 4. **EventsAndDelegates**
**Location:** `/EventsAndDelegates/`

A console application demonstrating the event-driven programming pattern using delegates and event handlers.

**Key Features:**
- Event publishers (VideoEncoder)
- Event subscribers (MailService)
- Custom event handling
- Async event simulation with threading

**Main Components:**
- `Program.cs` - Orchestrates the video encoding workflow
- `VideoEncoder.cs` - Publisher class that raises encoding start/completion events
- `MailService.cs` - Subscriber class that handles events and sends notifications
- **Model/** - Contains data models like `Video`

**How It Works:**
1. VideoEncoder publishes `videoEncodeStarted` and `videoEncodeCompleted` events
2. MailService subscribes to these events
3. When VideoEncoder encodes a video, it raises events
4. MailService receives notifications and sends confirmation emails

---

### 5. **DesignPatterns**
**Location:** `/DesignPatterns/`

A comprehensive collection of design pattern implementations covering structural and behavioral patterns.

**Included Patterns:**

#### a. **Abstract Factory Pattern**
- **Location:** `/DesignPatterns/AbstractFactory-Pattern/`
- Creates families of related objects without specifying their concrete classes
- **Components:**
  - FurnitureShop example with furniture factory
  - Products for different furniture types

#### b. **Adapter Pattern**
- **Location:** `/DesignPatterns/Adapter-Pattern/`
- Adapts old coffee machine interface to work with new touchscreen interface
- **Key Classes:**
  - `OldCoffeeMachine.cs` - Legacy interface
  - `CoffeeTouchscreenAdapter.cs` - Adapter implementation
  - `ICoffeeMachine.cs` - Target interface
  - `ProblemStatement.cs` - Problem description

#### c. **Composite Pattern**
- **Location:** `/DesignPatterns/Composite-Pattern/`
- Composes objects into tree structures to represent part-whole hierarchies
- **Examples:**
  - HousingExample - Building hierarchy with floors and rooms
  - PlaylistApplicationExample - Playlist structure with songs and albums

#### d. **Client Application**
- **Location:** `/DesignPatterns/Client/`
- `Program.cs` - Demonstrates usage of various design patterns
- Contains executable examples for each pattern implementation
- Switch cases for running different pattern demonstrations

---

### 6. **EventDrivenArchitecture (E.D.A)**
**Location:** `/EventDrivenArchitecture(E.D.A)/`

An ASP.NET Core API project implementing event-driven architecture patterns.

**Key Features:**
- Swagger API documentation
- REST endpoint design
- Event-driven design principles
- Docker containerization support

**Project Structure:**
- `Program.cs` - Configures API services and middleware
- `E.D.A.Ubiquitous.csproj` - Project configuration
- **Properties/**
  - `launchSettings.json` - Launch configuration
- **Docker/**
  - `docker-compose.yml` - Container orchestration
- Configuration Files:
  - `appsettings.json` - Production settings
  - `appsettings.Development.json` - Development settings

**API Endpoints:**
- Weather forecast endpoints configured
- Swagger/OpenAPI documentation available in development environment

---

## 🛠️ Technology Stack

- **.NET Framework:** .NET 8.0
- **Languages:** C#
- **Web Framework:** ASP.NET Core
- **Containerization:** Docker
- **API Documentation:** Swagger/OpenAPI
- **Authentication:** Cookie-based with Claims

---

## 🚀 Getting Started

### Prerequisites
- .NET SDK 8.0 or higher
- Visual Studio or Visual Studio Code
- Git (for version control)

### Building Projects

#### Console Applications
```bash
cd CodingSolutions
dotnet build
dotnet run
```

#### Web Applications
```bash
cd Cookie-based-authentication
dotnet build
dotnet run
# Access at https://localhost:5001
```

#### Design Patterns
```bash
cd DesignPatterns/Client
dotnet build
dotnet run
```

#### Event-Driven Architecture API
```bash
cd EventDrivenArchitecture(E.D.A)/E.D.A.Ubiquitous
dotnet build
dotnet run
# Swagger UI available at https://localhost:xxxx/swagger
```

### Docker Deployment
```bash
cd EventDrivenArchitecture(E.D.A)
docker-compose up
```

---

## 📖 Learning Concepts

### OOP Principles
- Inheritance and polymorphism (VirtualMethods)
- Encapsulation (UserManager, VideoEncoder)
- Extension methods (CodingSolutions)

### Design Patterns
- **Creational:** Abstract Factory Pattern
- **Structural:** Adapter Pattern, Composite Pattern
- **Behavioral:** Observer/Events Pattern, Event-Driven Architecture

### Web Development
- ASP.NET Core MVC
- Cookie-based authentication and authorization
- Role-based access control (RBAC)
- Claims-based authorization

### Async Programming
- Event-driven programming model
- Delegate-based callbacks
- Multi-threaded simulations

---

## 📁 Directory Structure

```
C-Sharp/
├── CodingSolutions/                          # String utilities console app
├── Cookie-based-authentication/              # ASP.NET Core auth web app
├── VirtualMethods/                           # Polymorphism demonstration
├── EventsAndDelegates/                       # Event-driven console app
├── DesignPatterns/
│   ├── AbstractFactory-Pattern/              # Factory pattern implementation
│   ├── Adapter-Pattern/                      # Adapter pattern implementation
│   ├── Composite-Pattern/                    # Composite pattern implementation
│   ├── Client/                               # Pattern demonstrations
│   └── DesignPatterns.sln
├── EventDrivenArchitecture(E.D.A)/
│   ├── E.D.A.Ubiquitous/                    # Main API service
│   ├── Docker/                               # Container configuration
│   └── EventDrivenArchitecture(E.D.A).sln
├── .git/                                     # Git repository
├── .gitignore                                # Git ignore rules
├── .gitattributes                            # Git attributes
├── README.md                                 # This file
└── .github/                                  # GitHub configuration
```

---

## 🔐 Security Notes

### Cookie-based Authentication
- **Important:** In production, implement proper:
  - Password hashing (bcrypt, PBKDF2)
  - Database persistence
  - HTTPS enforcement
  - CSRF protection
  - Secure cookie flags (HttpOnly, Secure, SameSite)

---

## 📝 Notes

- All projects are .NET 8.0 console or ASP.NET Core applications
- Design patterns demonstrate different structural and behavioral approaches
- Examples include real-world scenarios (furniture shop, coffee machines, playlists)
- Event-driven architecture showcases modern async/reactive patterns

---

## 🤝 Contributing

This is a learning repository. Feel free to explore, modify, and extend the projects for educational purposes.

---

## 📄 License

This repository is for educational and learning purposes.

---

**Last Updated:** February 2026

For more information, consult the individual project files and code documentation.
