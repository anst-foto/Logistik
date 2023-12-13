namespace Logistik;

public interface IPassenger
{
    public uint PlaceCount { get; }
    public void Boarding();
    public void UnBoarding();
}