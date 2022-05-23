using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemoryDal;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;//Yıldız
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public IResult Add(Car car)
        {
            if (car.Description.Length>=2&&car.DailyPrice>0)
            {
                _carDal.Add(car);
                return new SuccesResult(Messages.CarAdded);
            }else
                return new ErrorResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {

            return new SuccesDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccesDataResult<List<CarDetailDto>>(_carDal.GetCarDetailDto());
        }

        public IResult Remove(Car car)
        {
            _carDal.Delete(car);
            return new SuccesResult(Messages.CarDeleted);

        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccesResult(Messages.CarUpdated);

        }
    }
}

