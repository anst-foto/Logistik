namespace Logistik;

public interface ICargo
{
    public uint MaxWeight { get; }
    public void Load();
    public void UnLoad();
}