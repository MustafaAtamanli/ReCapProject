using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            NewMethod();
        }

        private static void NewMethod()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails())
            {
                //Console.WriteLine(car.Id +" / "+car.ColorName + " / " +car.BrandName + " / " +car.DailyPrice);
                Console.WriteLine(car.BrandName+" / "+car.ColorName);
            }
        }
    }
}
