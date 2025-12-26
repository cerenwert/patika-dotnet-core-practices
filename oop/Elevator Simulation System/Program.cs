using System;
using System.Collections.Generic;

#region Enums

enum Direction
{
    Up,
    Down,
    Idle
}

enum ElevatorStatus
{
    Moving,
    Stopped
}

#endregion

#region Abstract Classes

abstract class Button
{
    public abstract void Press();
}

#endregion

#region Buttons

class CallButton : Button
{
    public Direction Direction { get; set; }

    public override void Press()
    {
        Console.WriteLine($"Call button pressed: {Direction}");
    }
}

class FloorButton : Button
{
    public int FloorNumber { get; set; }

    public override void Press()
    {
        Console.WriteLine($"Floor button pressed: {FloorNumber}");
    }
}

#endregion

#region Elevator Components

class Door
{
    public bool IsOpen { get; private set; }

    public void Open()
    {
        IsOpen = true;
        Console.WriteLine("Door opened");
    }

    public void Close()
    {
        IsOpen = false;
        Console.WriteLine("Door closed");
    }
}

class SignalLight
{
    public Direction Direction { get; set; }

    public void TurnOn()
    {
        Console.WriteLine($"Signal light: {Direction}");
    }
}

class ArrivalBell
{
    public void Ring()
    {
        Console.WriteLine("Arrival bell rang");
    }
}

class ControlPanel
{
    public List<FloorButton> FloorButtons { get; set; } = new();
    public Button OpenDoorButton { get; set; }
    public Button CloseDoorButton { get; set; }
    public Button EmergencyButton { get; set; }
}

#endregion

#region Core Classes

class Elevator
{
    public int ElevatorId { get; set; }
    public int CurrentFloor { get; set; }
    public Direction Direction { get; set; }
    public int Capacity { get; set; } = 6;
    public ElevatorStatus Status { get; set; }

    public Door Door { get; set; } = new();
    public ControlPanel ControlPanel { get; set; } = new();
    public SignalLight IndicatorLight { get; set; } = new();

    public void MoveToFloor(int floor)
    {
        Status = ElevatorStatus.Moving;
        Direction = floor > CurrentFloor ? Direction.Up : Direction.Down;

        Console.WriteLine($"Elevator {ElevatorId} moving to floor {floor}");
        CurrentFloor = floor;

        Status = ElevatorStatus.Stopped;
        Direction = Direction.Idle;
    }
}

class Floor
{
    public int FloorNumber { get; set; }
    public List<CallButton> CallButtons { get; set; } = new();
    public ArrivalBell ArrivalBell { get; set; } = new();
    public SignalLight SignalLight { get; set; } = new();
}

class Passenger
{
    public int PassengerId { get; set; }
    public int StartFloor { get; set; }
    public int DestinationFloor { get; set; }
}

#endregion

#region Simulation Support

class ElevatorController
{
    public List<Elevator> Elevators { get; set; } =
