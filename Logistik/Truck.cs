namespace Logistik;

public class Truck : Transport, ICargo
{
    public uint MaxWeight { get; }
    public Truck(int maxSpeed, uint maxWeight) : base(maxSpeed)
    {
        MaxWeight = maxWeight;
    }

    public void Load()
    {
        Console.WriteLine($"Погрузка груза в {nameof(Truck)} [{Id}]");
    }

    public void UnLoad()
    {
        Console.WriteLine($"Выгрузка груза из {nameof(Truck)} [{Id}]");
    }
}