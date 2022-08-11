// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



Car car = new(0);
car.Drive();
car.Refuel(int.Parse(Console.ReadLine()));
car.Drive();


interface IVehiculo
{
    void Drive();

    bool Refuel(int gasoline);
}


public class Car : IVehiculo
{
    public int _gasoline;

    public Car(int gasoline)
    {
        _gasoline = gasoline;
    }

    public void Drive()
    {
        if(_gasoline > 0)
        {
            Console.WriteLine("Driving");
        }
        else
        {
            Console.WriteLine("No fuel, refuel to drive");
        }
        
    }

    public bool Refuel(int gasoline)
    {
         _gasoline += gasoline;
        Console.WriteLine("Fuel increased by "+gasoline);
        return true;
    }
}