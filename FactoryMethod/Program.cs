public interface IVehicle
{
	void Drive();
}

public class Car : IVehicle
{
	public void Drive()
	{
		Console.WriteLine("Drive some car");
	}
}

public class Bike : IVehicle
{
	public void Drive()
	{
		Console.WriteLine("Drive a bike");
	}
}

public abstract class VehicleFactory
{
	public abstract IVehicle CreateVehicle();

	public void SomeOperation()
	{
		var vehicle = CreateVehicle();
		vehicle.Drive();
	}
}

public class CarFactory : VehicleFactory
{
	public override IVehicle CreateVehicle()
	{
		return new Car();
	}
}

public class BikeFactory : VehicleFactory
{
	public override IVehicle CreateVehicle()
	{
		return new Bike();
	}
}

public class Program
{
	public static void Main(string[] args)
	{
		VehicleFactory factory;
		factory = new CarFactory();
		factory.SomeOperation();

		factory = new BikeFactory();
		factory.SomeOperation();
	}
}