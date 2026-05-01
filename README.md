# Pokemon Arena Battle 🎮

## Project Overview ⚔️
Welcome to the Arena! This project is a tactical, terminal-based battle simulator that pits a player against an unpredictable CPU opponent. 

The goal was to recreate the core mechanics of the classic Gen 1 battle system, focusing on team management, type-effectiveness logic, and turn-based state machines.

## The Architectural Journey: Inheritance vs. Composition 🏗️
This project served as a pivotal learning milestone. Initially, the engine was built using **Class Inheritance**, but as the complexity grew, I refactored the entire codebase to utilize **Composition**.

*   **Why the shift?** Composition allowed for greater flexibility in assigning behaviors and types to Pokemon without the "fragile base class" trap. 
*   **Result:** A more modular system where Pokemon "have" stats and moves rather than just inheriting them, making it easier to scale to the full Gen 1 roster.

## Core Features 🛡️
*   **Strategic Team Drafting:** Select a squad of 3 Pokemon to face off against a randomized CPU team.
*   **Dynamic Battle Logic:** 
    *   **Speed Check:** Initial turns are decided by a speed-stat comparison.
    *   **STAB (Same Type Attack Bonus):** 1.5x damage when a Pokemon uses a move matching its own type.
    *   **Type Advantage:** Fully implemented 2x (Super Effective) and 0.5x (Not Very Effective) damage modifiers.
*   **Active Swapping:** Switch your active Pokemon at any time to gain a tactical edge or replace a fainted teammate.

## Tech Stack 🛠️
*   **Language:** C#
*   **Runtime:** .NET 6.0+
*   **Interface:** CLI (Command Line Interface)
*   **Environment:** Visual Studio 2022 / VS Code

## Future Roadmap 🗺️
- [ ] Implement all 151 Original Gen 1 Pokemon.
- [ ] Refine move-set logic (Status effects like Sleep/Paralysis).
- [ ] Balance-tweak damage calculations for competitive parity.
