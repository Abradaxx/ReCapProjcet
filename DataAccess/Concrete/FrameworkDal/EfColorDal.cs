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
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                var addedEntity = context.Entry(entity);//bu entry entity framework e özel
                //buradaki referansı yakaladık
                addedEntity.State = EntityState.Added;//
                context.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                var deletedEntity = context.Entry(entity);//bu entry entity framework e özel
                //buradaki referansı yakaladık
                deletedEntity.State = EntityState.Deleted;//
                context.SaveChanges();
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter = null)
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }

      
        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
            return filter == null 
                    ? context.Set<Color>().ToList() //filtre null ise bu çalışır
                    : context.Set<Color>().Where(filter).ToList();//filtre null degilse bunu çalıştır.

                    //context.Set<Color>() bu ReCapProjectContexttteki dbset ile
                    //belirtiğimiz database deki color tablosuna baglamaştık burada
                    //o tabloyu aldık elimize refi yani ve bunu liste çevirdik
                    //yani arka planda select*from procut donduruyor bu bize veriyor.

            }
        }

        public Color GetById(int id)
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                return context.Set<Color>().SingleOrDefault(c => c.ColorId == id);
            }
        }

        public void Update(Color entity)
        {
            using (ReCapProjectContext context =new ReCapProjectContext())
            {
                var updatedEntity = context.Entry(entity);//bu entry entity framework e özel
                //buradaki referansı yakaladık
                updatedEntity.State = EntityState.Modified;//
                context.SaveChanges();
            }
        }
    }
}
