# Zoo Management System (OOP)

This project demonstrates object-oriented programming concepts such as
inheritance, abstraction, and polymorphism using a zoo management scenario.

## Features
- Abstract Animal class with common properties
- Different animal types with custom feeding and dosage logic
- Polymorphism via overridden methods

## Class Diagram
![Class Diagram](diagrams/class-diagram.png)

## Technologies
- Java
- Object-Oriented Programming (OOP)

## Purpose
Educational project for demonstrating OOP principles.
## Class Diagram

```plantuml
@startuml
abstract class Animal {
  - speciesName : String
  - weight : double
  - age : int
  + getDosage() : double
  + getFeedSchedule() : String
}

class Horse
class Lion
class Rat

Animal <|-- Horse
Animal <|-- Lion
Animal <|-- Rat
@enduml

