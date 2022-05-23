using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            //mantıken arabanın rent date i yoksa return date i yoktur ve araba duruyordur.
            if (rental.RentDate==null&&rental.ReturnDate==null)
            {
                
                _rentalDal.Add(rental);
                return new SuccesResult(Messages.RentalAdded);
            }
            return new ErrorResult(Messages.RentalAddedInvalid);
            
        
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccesDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<List<RentalDetailDto>> GetCarDetails()
        {
            return new SuccesDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetailDto());
        }

        public IResult Remove(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccesResult(Messages.RentalDeleted);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccesResult(Messages.RentalUpdated);
        }
    }
}
