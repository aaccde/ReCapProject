﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear="1995",DailyPrice=30000, Description="Opel"},
                new Car{Id=2,BrandId=1,ColorId=1,ModelYear="1998",DailyPrice=40000, Description="Toyota"},
                new Car{Id=3,BrandId=2,ColorId=2,ModelYear="2000",DailyPrice=50000, Description="Mercedes"},
                new Car{Id=4,BrandId=2,ColorId=3,ModelYear="2016",DailyPrice=120000, Description="Fiat"},
                new Car{Id=5,BrandId=2,ColorId=3,ModelYear="2021",DailyPrice=230000, Description="BMW"},
            };
        }
     
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete=null;
            /*foreach (var c in _cars)
            {
                if (car.Id == c.Id)
                {
                    carToDelete = c;
                }
            }
            
            */
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
            var result=_cars.Any(c => c.Description == "Opel");
            Console.WriteLine(result);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByColorId(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = carToUpdate.Description;
        }
    }
}
