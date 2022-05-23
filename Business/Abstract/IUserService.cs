using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<List<UserDetailDto>> GetUserDetail();
        IResult Add(User user);
        IResult Remove(User user);
        IResult Update(User user);
    }
}
