﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            carManager.Add(new Car {BrandId = 3, ColorId = 2, ModelYear = "2021", DailyPrice = 0, Description = "Hyundai Getz" });
            
        }
    }
}
