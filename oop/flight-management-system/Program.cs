enum AirplaneStatus
{
    Working,
    Maintenance
}

class Airline
{
    public int AirlineId { get; set; }
    public string Name { get; set; }
}

class AirplaneType
{
    public string TypeName { get; set; }
    public int RequiredPilotCount { get; set; }
}

class Airplane
{
    public int AirplaneId { get; set; }
    public AirplaneStatus Status { get; set; }
    public AirplaneType Type { get; set; }
}

class Pilot
{
    public int PilotId { get; set; }
    public string Name { get; set; }
    public int ExperienceLevel { get; set; }
}

class Airport
{
    public int AirportId { get; set; }
    public string Name { get; set; }
}

class Flight
{
    public int FlightId { get; set; }
    public Pilot Pilot { get; set; }
    public Pilot CoPilot { get; set; }
    public Airplane Airplane { get; set; }
    public Airport DepartureAirport { get; set; }
    public Airport ArrivalAirport { get; set; }
}
