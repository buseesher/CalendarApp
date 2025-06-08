# 🗓️ CalendarApp

CalendarApp is a simple C# console application designed to manage meetings and to-do tasks. It demonstrates basic OOP concepts like inheritance, interfaces, and class composition through a calendar-based reminder system.

---

## 🚀 Features

- 📅 Create meetings and to-do tasks with title, details, start and end times
- 👥 Add guests to meetings
- 🔔 Notification system via `INotification` interface
- 🧱 Reusable `Event` base class for shared properties
- 🖨️ Console output simulating user reminders

---

## 📁 Project Structure

  ```bash
CalendarApp/
├── Abstract/
│   └── INotification.cs           # Interface for notification functionality
├── Common/
│   └── Event.cs                   # Base class for shared fields (title, time, etc.)
├── Entities/
│   ├── Meeting.cs                 # Inherits from Event, notifies guests
│   ├── ToDo.cs                    # Inherits from Event, adds priority
├── Program.cs                     # Main method: creates and runs demo
├── calendar_deneme.csproj         # Project file
└── calendar_deneme.sln            # Solution file
  ```
---
## 🧠Code Overview

The project consists of a reusable and extensible code structure built around object-oriented principles:

-An INotification interface defines a common method that all notification-capable objects must implement.

-The Event class acts as a base class and holds shared properties such as ID, Title, StartTime, FinishTime, and Details.

-Meeting and ToDo classes inherit from Event and implement the INotification interface in their own customized way.

-The Program.cs file serves as the main entry point and demonstrates how to instantiate and use these entities.

This architecture makes it easy to expand the application with new event types or notification behaviors in the future.

---

## ⚙️ How to Run
    
  ```bash
dotnet build
dotnet run
  ```

---
## 🎯 Concepts Demonstrated

This application is designed as a simple example of key OOP concepts in C#:

-Interfaces: The use of INotification enforces a consistent notification method across different types.

-Inheritance: Shared logic and properties are defined in a base Event class, which is extended by specialized child classes.

-Polymorphism: Objects implementing the same interface can be handled uniformly.

-Encapsulation: Fields are exposed through properties with get and set accessors.

-Separation of Concerns: Each class handles its specific responsibilities clearly.

---
## 🙌 Acknowledgements
Developed for educational purposes to demonstrate C# fundamentals like interfaces, inheritance, and class composition.

