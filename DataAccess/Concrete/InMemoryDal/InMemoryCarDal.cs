using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemoryDal
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars = new List<Car>()
        {
            new Car{Id=1,ColorId=1,BrandId=1,DailyPrice=1000000,ModelYear=2018,Description="Ford Focus Black "},
            new Car{Id=2,ColorId=2,BrandId=1,DailyPrice=2000000,ModelYear=2019,Description="Ford Focus Orange"},
            new Car{Id=3,ColorId=3,BrandId=2,DailyPrice=3000000,ModelYear=2020,Description="Hundai i20 Red"},
            new Car{Id=4,ColorId=2,BrandId=3,DailyPrice=4000000,ModelYear=2021,Description="Toyota Supra Orange"},
            new Car{Id=5,ColorId=2,BrandId=3,DailyPrice=5000000,ModelYear=2022,Description="Toyota Coralla Orange"},
        };
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carsToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carsToDelete);


        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
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

        public List<Car> GetById(Car car)
        {
            return _cars.Where(c => c.Id == car.Id).ToList();
        }

        public Car GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailDto()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carsToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carsToUpdate.BrandId = car.BrandId;
            carsToUpdate.ColorId = car.ColorId;
            carsToUpdate.Description = car.Description;
            carsToUpdate.ModelYear = car.ModelYear;
            carsToUpdate.DailyPrice = car.DailyPrice;
            
        }
    }
}
