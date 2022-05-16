using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Generic Constraint
    public interface IEntityRepository<T> where T:class, IEntity,new()//kısıtlayıcıları koyduk
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter = null);//Listedeki bir şeye basıp onun detayına gitmek için
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
       

    }
}
//Linq sayesinde çok işe yarayan bir expression var 
//Expression<Func<T,bool>> filter=null bu da spesifik dataları çekmemizi saglar yani fonksiyon içine
//p=>p. ... tarzı filter yazmamıza yarıyor.

