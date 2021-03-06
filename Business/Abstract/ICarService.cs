using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult <List<CarDetailDto>> GetCarDetails();
        IResult Add(Car car);
        IResult Remove(Car car);
        IResult Update(Car car);
        

    }
}
