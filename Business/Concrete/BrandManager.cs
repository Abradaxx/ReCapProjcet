using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brand)
        {
            _brandDal = brand;
        }
        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public void Remove(Brand brand)
        {
            _brandDal.Delete(brand);

        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
        }
    }
}
