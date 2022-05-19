using Core.DataAcces.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.FrameworkDal
{
    //bu kod da udemy dersinden yazdım framework u
    public class EfBrandDal :EfEntityRepositoryBase<Brand,ReCapProjectContext>,IBrandDal
    {
        
    }
}
