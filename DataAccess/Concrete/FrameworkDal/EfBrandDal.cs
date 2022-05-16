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
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                context.Brands.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                context.Brands.Remove(context.Brands.SingleOrDefault(b => b.BrandId == entity.BrandId));
                context.SaveChanges();
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll()
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                return context.Brands.ToList();
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Brand GetById(int id)
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                return context.Brands.SingleOrDefault(b => b.BrandId == id);
            }
        }

        public void Update(Brand entity)
        {
            using (ReCapProjectContext context =new ReCapProjectContext())
            {
                var brandToUpdate = context.Brands.SingleOrDefault(b => b.BrandId == entity.BrandId);
                brandToUpdate.BrandName = entity.BrandName;
                context.SaveChanges();
            }
        }
    }
}
