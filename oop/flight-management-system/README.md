# ✈️ Flight & Pilot Management System (UML Design)

This repository contains an **object-oriented design** for a flight and pilot management system.

The goal of this project is to model:
- Airlines
- Flights
- Airplanes
- Pilots
- Airports

using **UML Class Diagrams**.

---

## 📌 System Overview

- Airlines operate flights.
- Airlines own airplanes and employ pilots.
- Each flight:
  - Has a unique ID
  - Uses one airplane
  - Has one pilot and one co-pilot
  - Has departure and arrival airports
- Airplanes can be **working** or **under maintenance**
- Each airplane has a type
- Airplane types define how many pilots are required
- Pilots have experience levels

---

## 🧩 UML Class Diagram

The class diagram below represents the system design:

![Class Diagram](diagrams/class-diagram.png)

---

## 🛠️ Tools Used

- UML notation
- PlantUML (for diagram generation)

---

## 🚀 Future Improvements

- Add source code implementation (C# / Java)
- Add sequence diagrams
- Add validation rules (pilot experience vs airplane type)

---

## 👤 Author

Designed for learning **Object-Oriented Programming & UML** concepts.
