namespace ConsoleApp1
{
    internal class Plane : ITransmission, IEngine
    {
        public string TransmissionKind { get; set; }
        public int HorsePower { get; set; }
        public int TankSize { get; set; }
        public int CurrentOil { get; set; }
        public string FuelType { get; set; }
    }
}
