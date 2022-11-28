using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + " - " + car.ColorName + " - " + car.ModelYear);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
            //var car = carManager.GetById(1);
            //Console.WriteLine(car.ToString());
        }
    }
}
