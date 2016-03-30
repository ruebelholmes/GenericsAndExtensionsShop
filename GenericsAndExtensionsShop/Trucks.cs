namespace GenericsAndExtensionsShop
{
    public class Trucks : IVehicle
    {
        public Trucks()
        {
            FuelType = "Diesel";
        }

        public override string ToString()
        {
            return "Truck";
        }
    }
}