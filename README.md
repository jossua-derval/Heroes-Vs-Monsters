# Heroes vs Monsters

A turn-based console RPG built in **C# / .NET 10** to practice Object-Oriented Programming (OOP) principles, inheritance, and interface design.

*(Note: Console prompts and in-game messages are in French.)*

### Key Concepts Applied
* **Object-Oriented Architecture:** Separation between entities (`Models`), contracts (`Interfaces`), and console rendering (`Afficher`).
* **Polymorphism & Inheritance:** Shared combat mechanics across different hero and monster classes.
* **Interface Segregation:** Decoupled behaviors and abilities implemented via C# interfaces.

### Project Structure

    Heroes-Vs-Monsters/
    ├── Afficher/
    │   └── AfficherConsole.cs    # Console UI and combat log rendering
    ├── Interfaces/
    │   ├── ICuir.cs              # Leather loot interface
    │   └── IOr.cs                # Gold loot interface
    ├── Models/
    │   ├── Heros/                # Hero base class and playable races (Humain, Nain)
    │   ├── Monstres/             # Monster base class and enemy types (Dragonnet, Loup, Orque)
    │   ├── Combat.cs             # Turn-based battle resolution
    │   ├── De.cs                 # Dice roll mechanics
    │   ├── Personnage.cs         # Base character stats and attributes
    │   └── Plateau.cs            # Grid map and movement logic
    ├── Program.cs                # Main game loop
    └── HeroesVSMonsters.csproj   # .NET 10.0 project configuration

### Getting Started
* **Prerequisite:** [.NET 10.0 SDK](https://dotnet.microsoft.com/download)

    git clone https://github.com/jossua-derval/Heroes-Vs-Monsters.git
    cd Heroes-Vs-Monsters
    dotnet run
