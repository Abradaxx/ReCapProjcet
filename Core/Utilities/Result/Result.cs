using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    public class Result : IResult
    {
        //Şimdi dediğimiz gibi mesala add fonksiyonunda add yapıldıktan sonra sistemde eklendi diye
        //return almak istiyorum
        //bu return ü almak için utilites diye dosya oluşturduk bu dosya araçlar anlamında ve bu core da olmalı
        //bunu code refactoring ile over düzeltme ile bağımlılığımızı azaltana kadar olasılıkları düşünmek lazım
        //ilk öncelikle result interface i oluşturduk bu interface de bool ve string degerlerimizi oluşturduk
        // sonra biz demiştik ki void set ediyordu fakat ben hem set hem de return istityorum
        //encapsulation kullanacaz
        // şimdi ilk önce bu iki prop için varyasyonlarımı yazalım mesala bi sistem hem 
        //mesaj hem de true deger döndürebilir
        //propları her ne kadar get yaptıysak ve bunlar return döndürdüyse bile unutma ctor içinde set edilirler
        public Result(bool succes, string message):this(succes)
        {
            
            this.Message = message;

        }
        //dediğimiz gibi overdesign da istiyoruz mesala biz mantıken şöyle yapabiliriz
        //public Result(bool succes)
        //{
        //    this.Succes = succes;

        //}
        //public Result(string message)
        //{
        //    this.Message = message;
        //}
        //fakat fazla set işlemi sıkıntı
        //bunun için şöyle yapıcaz mesala bide true mesajı istediğimizi düşünelim
        public Result(bool succes)
        {
            this.Succes = succes;
        }
        public bool Succes { get; }

        public string Message { get; }
    }
}
