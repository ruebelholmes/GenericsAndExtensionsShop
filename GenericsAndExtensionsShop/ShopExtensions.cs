using System;

namespace GenericsAndExtensionsShop
{
    public class ShopExtensions
    {
        public static void ChangeTires<T>(Shop<T> shop, IVehicle v) where T : IVehicle
        {
            Console.WriteLine($"{v}'s tires were changed ");

            v.ChangeTire = true;
        }
    }
}