namespace ConsoleApp1
{
    internal class Car : Vehicle, IEngine, ITransmission, IWheel
    {
        private int _doorcount;
        private string _fueltype;
        private string _transmissionkind;
        private int _wheelthickness;


        public int DoorCount { 
            get => _doorcount;
            set
            {
                while (value < 2 && value > 4)
                {
                    Console.WriteLine("Invalid Input!!!");
                    Console.Write("DoorCount: ");
                    value = Convert.ToInt32(Console.ReadLine());
                }

                _doorcount = value;
            }
        }
        public int WinCode { get; set; }
        public int HorsePower { get; set; }
        public int TankSize { get; set; }
        public int CurrentOil { get; set; }
        public string FuelType { 
            get => _fueltype;
            set
            {
                while (value != "benzin" && value != "dizel")
                {
                    Console.WriteLine("Invalid Input!!!");
                    Console.Write("FuelType: ");
                    value = Console.ReadLine();
                }

                _fueltype = value;
            }
        }
        public string TransmissionKind
        {
            get => _transmissionkind;
            set
            {
                while (value != "avtomat" && value != "mexaniki")
                {
                    Console.WriteLine("Invalid Input!!!");
                    Console.Write("TransmissionKind: ");
                    value = Console.ReadLine();
                }

                _transmissionkind = value;
            }
        }
        public int WheelThickness
        {
            get => _wheelthickness;
            set
            {
                while (value < 1)
                {
                    Console.WriteLine("Invalid Input!!!");
                    Console.Write("WheelThickness: ");
                    value = Convert.ToInt32(Console.ReadLine());
                }

                _wheelthickness = value;
            }
        }
    }
}
