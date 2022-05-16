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
            _carDal = carDal;
        }
        public void Add(Car car)
        {
            if (car.Description.Length>=2&&car.DailyPrice>0)
            {
                _carDal.Add(car);
            }else
            throw new NotImplementedException("That is not able to add with these states");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public void Remove(Car car)
        {
            _carDal.Delete(car);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
