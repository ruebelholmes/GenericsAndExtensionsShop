namespace GenericsAndExtensionsShop
{
    public class Sedan : IVehicle
    {
        public Sedan()
        {
            FuelType = "Regular Gas";
        }

        public override string ToString()
        {
            return "Sedan";
        }
    }
}