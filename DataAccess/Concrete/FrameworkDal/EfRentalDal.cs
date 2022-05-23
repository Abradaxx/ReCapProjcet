using Core.DataAcces.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.FrameworkDal
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapProjectContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetailDto()
        {
            using (ReCapProjectContext context =new ReCapProjectContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join u in context.Users
                             on r.Id equals u.Id
                             select new RentalDetailDto { CarId = c.Id, CustomerId = u.Id, Id = u.Id, DailyPrice = c.DailyPrice, Description = c.Description, RentDate = r.RentDate, ReturnDate = r.ReturnDate };
                    return result.ToList();
           
             }
        }
    }
}
/* public List<CarDetailDto> GetCarDetailDto()
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                var result = from c in context.Cars
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             select new CarDetailDto { CarName = c.Description, BrandName = b.BrandName, ColorName = co.ColorName, DailyPrice = c.DailyPrice };
                return result.ToList();
                //list yapmamızın sebebi result kendi içinde dönen IDenum tarzı bir veri
            }
        }
 */