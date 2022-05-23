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

            //TestDTO();
            User user1 = new User { Id = 1, FirstName = "Kerem", LastName = "Bozkurt", Email = "blablamail", Password = "123" };
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(user1);
           
          
           
            


        }

        private static void TestDTO()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetCarDetails())
            {
                Console.WriteLine(item.CarName + "/" + item.ColorName + "/" + item.BrandName + "/" + item.DailyPrice);
            }
        }
    }
}
