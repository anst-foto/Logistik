using Logistik;

var company = new LogisticCompany();

var bus1 = new Bus(100, 100);
var bus2 = new Bus(150, 10);

var truck = new Truck(100, 10000);

company.AddTransport(bus2);
company.AddTransport(truck);
company.AddTransport(bus1);

var user = new User()
{
    Name = "User"
};

var trucks = company.GetCargoTransports()?.ToList();
if (trucks == null) return;

foreach (var t in trucks)
{
    PrintTransport(t);
}

var orderTruck = new Order()
{
    Transport = company.FindTransport(trucks[0].Id),
    User = user
};
Console.WriteLine($"{orderTruck.User.Name}: {orderTruck.Transport.Id}");


return;

void PrintTransport(Transport transport)
{
    Console.Write($"[{transport.Id}]: <{transport.GetType().Name}> max_speed = {transport.MaxSpeed} ");

    /*if (transport is IPassenger passenger)
    {
        PrintPassenger(passenger);
    }

    if (transport is ICargo cargo)
    {
        PrintCargo(cargo);
    }*/

    switch (transport)
    {
        case IPassenger passenger:
            PrintPassenger(passenger);
            break;
        case ICargo cargo:
            PrintCargo(cargo);
            break;
    }
}

void PrintPassenger(IPassenger passenger)
{
    Console.WriteLine($"place_count = {passenger.PlaceCount}");
}

void PrintCargo(ICargo cargo)
{
    Console.WriteLine($"max_weight = {cargo.MaxWeight}");
}