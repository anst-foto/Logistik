namespace Logistik;

public class LogisticCompany
{
    private readonly List<Transport> _transports;

    public LogisticCompany()
    {
        _transports = new List<Transport>();
    }

    public Transport? FindTransport(int id)
    {
        foreach (var transport in _transports)
        {
            if (transport.Id == id)
            {
                return transport;
            }
        }

        return null;
    }

    public void AddTransport(Transport transport)
    {
        _transports.Add(transport);
    }

    public IEnumerable<Transport> GetTransports() => _transports;

    public int GetPassengerTransports()
    {
        int sum = 0;
        foreach (var transport in _transports)
        {
            if (transport is IPassenger)
            {
                sum += 1;
            }
        }

        return sum;
    }
    
    public int GetCargoTransports()
    {
        int sum = 0;
        foreach (var transport in _transports)
        {
            if (transport is ICargo)
            {
                sum += 1;
            }
        }

        return sum;
    }
}