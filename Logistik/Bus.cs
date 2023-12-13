namespace Logistik;

public class Bus : Transport, IPassenger
{
    public uint PlaceCount { get; }
    public Bus(int maxSpeed, uint placeCount) : base(maxSpeed)
    {
        PlaceCount = placeCount;
    }

    public void Boarding()
    {
        Console.WriteLine($"Посадка пассажиров в {nameof(Bus)} [{Id}]");
    }

    public void UnBoarding()
    {
        Console.WriteLine($"Высадка пассажиров из {nameof(Bus)} [{Id}]");
    }
}