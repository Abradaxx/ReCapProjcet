using Business.Concrete;
using DataAccess.Concrete.FrameworkDal;
using DataAccess.Concrete.InMemoryDal;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car() {Id=2,BrandId=1,ColorId=1,DailyPrice=11111,Description="ford",ModelYear=2001 });
            
        }
    }
}
