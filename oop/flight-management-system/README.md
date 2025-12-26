# ✈️ Flight & Pilot Management System

This repository contains a simple **UML-based system design** for managing flights, pilots, airplanes, and airlines.
The project focuses on **Object-Oriented Programming (OOP)** fundamentals.

---

## 📌 Project Scope

The system models the following concepts:

- Airlines operate flights
- Airlines own airplanes and employ pilots
- Each flight:
  - Has a unique ID
  - Uses one airplane
  - Has one pilot and one co-pilot
  - Has departure and arrival airports
- Airplanes can be in working or maintenance state
- Each airplane has a type
- Airplane types define required pilot count
- Pilots have experience levels

---

##  UML Class Diagram

The system is designed using a **UML Class Diagram**.

- `Airline` owns airplanes and employs pilots
- `Flight` is the central class that connects:
  - `Airplane`
  - `Pilot` (Pilot & Co-Pilot)
  - `Airport`
- `AirplaneType` defines how many pilots are required for an airplane

📄 UML source file:  
➡️ **ClassDiagram.puml*
<img width="558" height="441" alt="flight-management-system-uml" src="https://github.com/user-attachments/assets/9cb88d99-e358-4ac0-af0a-4365c60cc794" />


---

## 💻 C# Skeleton (Program.cs)

A simple **C# class skeleton** is provided to demonstrate the UML design in code form.

- All classes are defined in a single file
- No business logic is implemented
- Focus is on structure, not functionality

📄 C# source file:  
➡️ **Program.cs**

---

##  Concepts Demonstrated

- Object-Oriented Design
- UML Class Diagrams
- Associations & Multiplicity
- Composition-like relationships
- Enum usage (airplane status)

---

##  Possible Improvements

- Add validation rules (pilot experience vs airplane type)
- Split classes into separate files
- Add sequence diagrams
- Implement business logic

---

##  Author

Created for learning and portfolio purposes.
