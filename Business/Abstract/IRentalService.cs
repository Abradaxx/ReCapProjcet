using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<RentalDetailDto>> GetCarDetails();
        IResult Add(Rental rental);
        IResult Remove(Rental rental);
        IResult Update(Rental rental);
    }
}
