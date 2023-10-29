namespace ConsoleApp1
{
    internal class Vehicle
    {
        int _drivetime;
        int _drivepath;
        public int DriveTime
        {
            get => _drivetime;
            set
            {
                while (value <= 0)
                {
                    Console.WriteLine("Invalid Input!!!");
                    Console.Write("DriveTime: ");
                    value = Convert.ToInt32(Console.ReadLine());
                }

                _drivetime = value;
            }
        }
        public int DrivePath
        {
            get => _drivepath;
            set
            {
                while (value <= 0)
                {
                    Console.WriteLine("Invalid Input!!!");
                    Console.Write("DrivePath: ");
                    value = Convert.ToInt32(Console.ReadLine());
                }

                _drivepath = value;
            }
        }

        public int AverageSpeed()
        {
            return _drivepath / _drivetime;
        }
    }
}
