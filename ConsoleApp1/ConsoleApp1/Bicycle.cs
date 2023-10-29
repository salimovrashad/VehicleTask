namespace ConsoleApp1
{
    internal class Bicycle : IWheel
    {
        private int _wheelthickness;
        private int _pedalkind;
        public int PedalKind
        {
            get => _pedalkind;
            set
            {
                while (value < 1)
                {
                    Console.WriteLine("Invalid Input!!!");
                    Console.Write("PedalKind: ");
                    value = Convert.ToInt32(Console.ReadLine());
                }

                _pedalkind = value;
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
