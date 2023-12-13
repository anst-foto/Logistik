namespace Logistik;

public abstract class Transport
{
    private static int _id = 0;
    
    public int Id { get; }
    public int MaxSpeed { get; }

    protected Transport(int maxSpeed)
    {
        MaxSpeed = maxSpeed;
        Id = ++_id;
    }
}