# Authentication System

A modern, secure authentication system built with .NET Core and React. This project provides a complete authentication solution with user registration, login, and session management.

## 🚀 Features

- User registration and login
- JWT-based authentication
- Secure password hashing with BCrypt
- Protected routes
- Modern, responsive UI with Material-UI
- Clean and intuitive user interface
- Role-based authorization
- Logout functionality
- Session persistence

## 🛠️ Tech Stack

### Backend
- .NET 9.0
- Entity Framework Core
- JWT Authentication
- BCrypt.Net-Next
- SQL Server
- CORS enabled
- RESTful API

### Frontend
- React 19
- TypeScript
- Vite
- Material-UI
- React Router DOM
- Axios
- Context API for state management

## 📦 Installation

### Prerequisites
- Node.js (latest LTS version)
- .NET 9.0 SDK
- SQL Server

### Backend Setup
1. Navigate to the backend directory:
```bash
cd BackEnd
```

2. Install dependencies:
```bash
dotnet restore
```

3. Update the database:
```bash
dotnet ef database update
```

4. Start the backend server:
```bash
dotnet run
```

The backend will start on `http://localhost:5205`

### Frontend Setup
1. Navigate to the frontend directory:
```bash
cd FrontEnd
```

2. Install dependencies:
```bash
npm install
```

3. Start the development server:
```bash
npm run dev
```

The frontend will start on `http://localhost:5173`

## 🔑 API Endpoints

### Authentication
- POST `/api/auth/register` - Register a new user
- POST `/api/auth/login` - Login user

## 🏗️ Project Structure

### Backend
```
BackEnd/
├── Controllers/
│   └── AuthController.cs
├── Models/
│   └── User.cs
├── Services/
│   └── AuthService.cs
├── DTOs/
│   ├── LoginDTO.cs
│   └── RegisterDTO.cs
└── Program.cs
```

### Frontend
```
FrontEnd/
├── src/
│   ├── components/
│   │   ├── Login.tsx
│   │   ├── Register.tsx
│   │   └── Dashboard.tsx
│   ├── context/
│   │   └── AuthContext.tsx
│   ├── api/
│   │   └── axios.ts
│   └── App.tsx
└── package.json
```

## 🔒 Security Features

- JWT token-based authentication
- Secure password hashing using BCrypt
- Protected routes in frontend
- HTTP-only cookies for token storage
- CORS protection
- Input validation and sanitization

## 💼 Usage

1. Register a new account at `/register`
2. Login with your credentials at `/login`
3. After successful login, you'll be redirected to the dashboard
4. Use the logout button to end your session

## 🤝 Contributing

1. Fork the repository
2. Create a new branch for your feature
3. Commit your changes
4. Push to the branch
5. Open a Pull Request

## 📄 License

This project is licensed under the MIT License - see the LICENSE file for details.
