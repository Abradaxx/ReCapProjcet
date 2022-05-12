using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemoryDal;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            carDal = new InMemoryCarDal();
            _carDal = carDal;
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
    }
}
