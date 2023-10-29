namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input down options: \n 1.Masin yaradin.\n 2.Velosiped yaradin. \n 3.Teyyare yaradin. \n 4.Butun hamisina baxin. \n 5.Silin.");
                int choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 1)
                {
                    Car car = new Car();
                    Console.WriteLine("Input the car about: ");

                    Console.WriteLine("HorsePower: ");
                    car.HorsePower = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("TankSize: ");
                    car.TankSize = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("CurrentOil: ");
                    car.CurrentOil = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("FuelType: ");
                    car.FuelType = Console.ReadLine();

                    Console.WriteLine("WheelThickness: ");
                    car.WheelThickness = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("TransmissionKind: ");
                    car.TransmissionKind = Console.ReadLine();

                    Console.WriteLine("DoorCount: ");
                    car.DoorCount = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Wincode: ");
                    car.WinCode = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("DrivePath");
                    car.DrivePath = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("DriveTime");
                    car.DriveTime = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Car created");
                    Console.WriteLine($"HorsePower: {car.HorsePower}-HP, \nTankSize: {car.TankSize}Litr, \nCurrentOil: {car.CurrentOil}Litr, \nFuelType: {car.FuelType}, \nWheelThickness: {car.WheelThickness}sm, \nTransmissionKind: {car.TransmissionKind}, \nDoorCount: {car.DoorCount}, \nWinCode: {car.WinCode}, \nSpeed: {car.AverageSpeed()} km/hour");

                }
                if (choose == 2)
                {
                    Bicycle bicycle = new Bicycle();
                    Console.WriteLine("Melumatlari daxil edin: ");

                    Console.WriteLine("PedalKind: ");
                    bicycle.PedalKind = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("WheelThickness: ");
                    bicycle.WheelThickness = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Velosiped yaradildi");
                    Console.WriteLine($"PedalKind: {bicycle.PedalKind}, WheelThickness: {bicycle.WheelThickness}");
                }
                if (choose == 3)
                {
                    Plane plane = new Plane();
                    Console.WriteLine("Melumatlari daxil edin: ");

                    Console.WriteLine("HorsePower: ");
                    plane.HorsePower = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("TransmissionKind: ");
                    plane.TransmissionKind = Console.ReadLine();

                    Console.WriteLine("TankSize: ");
                    plane.TankSize = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("CurrentOil: ");
                    plane.CurrentOil = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("FuelType: ");
                    plane.FuelType = Console.ReadLine();

                    Console.WriteLine("Teyyare yaradildi");
                    Console.WriteLine($"HorsePower: {plane.HorsePower}, TransmissionKind: {plane.TransmissionKind}, TankSize: {plane.TankSize}, CurrentOil: {plane.CurrentOil}, FuelType: {plane.FuelType}");
                }
            }
        }
    }
}