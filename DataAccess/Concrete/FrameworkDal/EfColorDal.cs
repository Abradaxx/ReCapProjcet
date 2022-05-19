using Core.DataAcces.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.FrameworkDal
{
    public class EfColorDal :EfEntityRepositoryBase<Color,ReCapProjectContext> ,IColorDal
    {
        
    }
}
