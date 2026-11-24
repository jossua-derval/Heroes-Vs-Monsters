# Heroes vs Monsters

A turn-based console RPG built in **C# / .NET 10** to practice Object-Oriented Programming (OOP) principles, inheritance, and interface design.

*(Note: Console prompts and in-game messages are in French.)*

### Key Concepts Applied
* **Object-Oriented Architecture:** Separation between entities (`Models`), contracts (`Interfaces`), and console rendering (`Afficher`).
* **Polymorphism & Inheritance:** Shared combat mechanics across different hero and monster classes.
* **Interface Segregation:** Decoupled behaviors and abilities implemented via C# interfaces.

### Project Structure

    Heroes-Vs-Monsters/
    ├── Afficher/               # Console display and combat log formatting
    ├── Interfaces/             # Shared behavior contracts
    ├── Models/                 # Hero, monster, and game entity classes
    ├── Program.cs              # Main game loop and turn management
    └── HeroesVSMonsters.csproj # .NET 10.0 project configuration

### Getting Started
* **Prerequisite:** [.NET 10.0 SDK](https://dotnet.microsoft.com/download)

    git clone https://github.com/jossua-derval/Heroes-Vs-Monsters.git
    cd Heroes-Vs-Monsters
    dotnet run
