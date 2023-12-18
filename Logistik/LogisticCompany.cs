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

    public IEnumerable<Transport> GetPassengerTransports()
    {
        var result = new List<Transport>();
        foreach (var transport in _transports)
        {
            if (transport is IPassenger)
            {
                result.Add(transport);
            }
        }

        return result;
    }
    
    public IEnumerable<Transport> GetCargoTransports()
    {
        foreach (var transport in _transports)
        {
            if (transport is ICargo)
            {
                yield return transport;
            }
        }
    }
}