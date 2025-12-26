## 🛗 Elevator Simulation System – Class Diagram

```mermaid
classDiagram
    class Building

    class Elevator {
        elevatorId
        currentFloor
        direction
        capacity
    }

    class Floor {
        floorNumber
    }

    class Door {
        isOpen
    }

    class ControlPanel

    class Button {
        <<abstract>>
        press()
    }

    class CallButton {
        direction
    }

    class FloorButton {
        floorNumber
    }

    class Passenger {
        startFloor
        destinationFloor
    }

    class ElevatorController

    %% Inheritance
    Button <|-- CallButton
    Button <|-- FloorButton

    %% Associations
    Building "1" --> "*" Elevator
    Building "1" --> "*" Floor

    Elevator "1" --> "1" Door
    Elevator "1" --> "1" ControlPanel

    Floor "1" --> "*" CallButton

    Passenger "*" --> "1" Elevator

    ElevatorController "1" --> "*" Elevator
