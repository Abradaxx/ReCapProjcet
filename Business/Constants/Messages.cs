using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        /////////////////////////////////////////////////////////////////////////
        public static string CarAdded = "Ürün Eklendi";
        public static string CarNameInvalid = "Ürün ismi geçersiz";
        public static string CarUpdated = "Ürün güncellendi Başarıyla";
        public static string CarDeleted = "Ürün Silindi Başarıyla";
        /////////////////////////////////////////////////////////////////////////
        public static string ColorAdded = "Ürün Eklendi";
        public static string ColorNameInvalid = "Ürün ismi geçersiz";
        public static string ColorUpdated = "Ürün güncellendi Başarıyla";
        public static string ColorDeleted = "Ürün Silindi Başarıyla";
        /////////////////////////////////////////////////////////////////////////
        public static string BrandAdded = "Ürün Eklendi";
        public static string BrandAddedInvalid = "Ürün ismi geçersiz";
        public static string BrandUpdated = "Ürün güncellendi Başarıyla";
        public static string BrandDeleted = "Ürün Silindi Başarıyla";
        ////////////////////////////////////////////////////////////////////
        public static string UserAdded = "Ürün Eklendi";
        public static string UserAddedInvalid = "Ürün ismi geçersiz";
        public static string UserUpdated = "Ürün güncellendi Başarıyla";
        public static string UserDeleted = "Ürün Silindi Başarıyla";
        ///////////////////////////////////////////////////////////////////
        public static string CustomerAdded = "Ürün Eklendi";
        public static string CustomerAddedInvalid = "Ürün ismi geçersiz";
        public static string CustomerUpdated = "Ürün güncellendi Başarıyla";
        public static string CustomerDeleted = "Ürün Silindi Başarıyla";
        ////////////////////////////////////////////////////////////////////
        public static string RentalAdded = "Ürün Eklendi";
        public static string RentalAddedInvalid = "Ürün ismi geçersiz";
        public static string RentalUpdated = "Ürün güncellendi Başarıyla";
        public static string RentalDeleted = "Ürün Silindi Başarıyla";

        ///////////////////////////////////////////////////////////////////
        internal static string CarCountOfColorSucces="Araba renk id okey";
        internal static string CarCountOfColorError="Araba renk id 15 den fazla";
        internal static string BrandLimitExceded="Brand sayısı 15 i aştı ürün eklenemez";
        internal static string CarImageAdded;
        internal static string CarImageDeleted;
        internal static string CarImageUpdated;
        ////////////////////////////kk///////////////////////////////////////////
        public static string CarRemoved = "Araba kaydı silindi";
        public static string InvalidCarNameInput = "Araba ismi en az 2 karakterden oluşmalı";
        public static string InvalidBrandId = "Brand id bulunamadı";
        public static string CarDontHaveAnyImages = "Kayıtlı fotoğraf bulunamadı";
    }
}
