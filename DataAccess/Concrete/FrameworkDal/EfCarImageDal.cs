using Core.DataAcces.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.FrameworkDal
{
    public class EfCarImageDal: EfEntityRepositoryBase<CarImage, ReCapProjectContext>, ICarImageDal
    {
       
    }
}

