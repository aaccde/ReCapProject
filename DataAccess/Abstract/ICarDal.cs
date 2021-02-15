using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    { //Veritabanında yapacağım operasyonları içeren interfacedir.
      //GetById, GetAll, Add, Update, Delete
       

    }
}
