using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    { //Veritabanında yapacağım operasyonları içeren interfacedir.
      //GetById, GetAll, Add, Update, Delete
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

        List<Car> GetByColorId(int colorId);

    }
}
