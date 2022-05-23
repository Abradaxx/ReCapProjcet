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
    public class EfUserDal : EfEntityRepositoryBase<User, ReCapProjectContext>, IUserDal
    {
        public List<UserDetailDto> GetUserDetailDto()
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                var result = from u in context.Users
                             join c in context.Customers
                             on u.Id equals c.UserId
                             select new UserDetailDto { Id = u.Id, FirstName = u.FirstName, LastName = u.LastName, CompanyName = c.CompanyName };
                             return result.ToList();

            }
        }
    }
}
