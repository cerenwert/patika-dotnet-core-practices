# 🎬 Online Movie Rental & Sales System

This repository contains a **UML-based system design** and a **C# class skeleton**
for an online application that sells and rents movies.

The project is designed to demonstrate **Object-Oriented Programming (OOP)** concepts.

---

## 📌 System Overview

The application supports the following features:

- Movies can be listed and sorted
- Users can register and use the system
- Users can be:
  - Normal users
  - Subscribers
- Subscribers can:
  - Buy credits
  - Rent movies using credits
- Both normal users and subscribers can purchase movies
- If a movie is not available, users can request it

---

## User Types

### User
- Can purchase movies
- Can request unavailable movies

### Subscriber (inherits from User)
- Has a credit balance
- Can buy credits
- Can rent movies using credits

---

## 🎬 Movie Rules

- Movies have:
  - Purchase price
  - Rental credit cost
  - Availability status
- Renting a movie:
  - Requires an active subscription
  - Deducts credits from the subscriber account

---

## UML Class Diagram

The system is modeled using a **UML Class Diagram**.

Main design decisions:
- `Subscriber` inherits from `User`
- Renting and purchasing are modeled as separate classes
- Movie requests are handled with a dedicated class

📄 UML source file:  
➡️ **ClassDiagram.puml**

<img width="517" height="695" alt="movie-rental-system" src="https://github.com/user-attachments/assets/10a8eb11-5363-485e-8f80-ce162eaa4165" />

---

## 💻 C# Implementation

A simple **C# class skeleton** is provided to reflect the UML design.

- All classes are defined in a single file
- No complex business logic
- Focused on structure and relationships

📄 C# source file:  
➡️ **Program.cs**

---

## Concepts Demonstrated

- Object-Oriented Design
- Inheritance
- Association & Composition
- UML to Code mapping
- Enum usage

---

## Possible Improvements

- Add business logic (credit validation, availability checks)
- Split classes into separate files
- Add sequence diagrams
- Add unit tests

---

##  Author

Created as an Object-Oriented Programming (OOP) practice project.
