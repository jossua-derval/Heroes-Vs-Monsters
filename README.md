# Heroes vs Monsters

A turn-based console RPG built in **C# / .NET 10** to practice Object-Oriented Programming (OOP) principles, inheritance, and interface design.

*(Note: Console prompts and in-game messages are in French.)*

### Preview
![Gameplay Preview](./preview.png)

### Technologies & Architecture
* **Language & Runtime:** C#, .NET 10.0
* **Concepts:** Inheritance (`Personnage` -> `Hero` / `Monstre`), Interfaces (`ICuir`, `IOr`), Console UI separation (`AfficherConsole`)

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

### What I Learned
* Structuring a multi-folder C# project by separating models, interfaces, and display logic.
* Using inheritance to factorize shared character stats (`Personnage`) and interfaces (`ICuir`, `IOr`) to handle lootable resources cleanly without multiple inheritance.

### Next Improvements
* [ ] Add unit tests (xUnit) for dice rolls and combat damage calculations.
* [ ] Refactor console display into a dedicated service interface to decouple game logic from `System.Console`.
