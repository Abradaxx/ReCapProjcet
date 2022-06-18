using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Validation;
using Core.Utilities.Business;
using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemoryDal;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
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
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
           IResult result =BusinessRules.Run(CheckIfCarCountOfColorCorrect(car.ColorId),CheckIfCarNameExist(car.Description));
            if (result != null)
            {
                return result;
            }
            _carDal.Add(car);
            return new SuccesResult(Messages.CarAdded);
        }

        public IDataResult<List<Car>> GetAll()
        {

            return new SuccesDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccesDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
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
        private IResult CheckIfCarCountOfColorCorrect(int colorId)
        {
            var result = _carDal.GetAll(c => c.ColorId == colorId).Count;
            if (result >= 5)
            {
                return new ErrorResult(Messages.CarCountOfColorError);
            }
            return new SuccesResult(); 
        }
        private IResult CheckIfCarNameExist(string carName)
        {
            var result =_carDal.GetAll(c=>c.Description==carName).Any();
            if (result)
            {
                return new ErrorResult();

            }
            return new SuccesResult();
        }
    }
}

