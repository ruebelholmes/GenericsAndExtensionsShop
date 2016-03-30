using System;

namespace GenericsAndExtensionsShop
{
    public abstract class Shop<T> where T : IVehicle

    {

        public void ChangeOil(T vehicle)
        {
            Console.WriteLine($"{vehicle} got an oil change!");

            vehicle.OilChanged = true;
        }

        public void FillUp(T vehicle)
        {
            Console.WriteLine($"{vehicle} has been filled with {vehicle.FuelType} ");

            vehicle.GasFull = true;
        }
    }
}