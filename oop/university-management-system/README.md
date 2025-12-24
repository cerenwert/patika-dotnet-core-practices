# Üniversite Yönetim Sistemi – Class Diagram

Bu diyagram, üniversite yönetim sistemini nesne yönelimli
programlama (OOP) yaklaşımıyla modellemek amacıyla hazırlanmıştır.

## Class Diagram

```mermaid
classDiagram
    University "1" --> "*" Department
    Department "1" --> "*" Office
    University "1" --> "*" Employee
    Employee <|-- Professor
    Employee <|-- Officer
    Employee "1" --> "1" Office
    University "1" --> "*" Classroom
