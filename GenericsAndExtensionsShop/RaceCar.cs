namespace GenericsAndExtensionsShop
{
    public class RaceCar : IVehicle
    {
        public RaceCar()
        {
            FuelType = "High Performance Gas";
        }

        public override string ToString()
        {
            return "Race Car";
        }
    }
}