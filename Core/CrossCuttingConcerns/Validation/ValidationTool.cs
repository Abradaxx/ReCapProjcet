using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

            /*Şimdi bu yapıya iyi bakalım
             * Car Validator degisiyor gerisi aynı
             * Bu yapıyı tüm projelerde kullanacagım için Core katmanına atıyorum
             * Git hubdan kod alıcaz engin hocanın
             * AOP nedir
             * örneğin siz metodlarınızı loglamak istiyorsunuz metod ya başında loglanır
             * AOP yöntemiyle bu tarz olaylar yazılabilir Try catch veya başka bişi kullanılmaya
             * gerek duyulmaz Bu yönteme Interception denir.
             * Interception araya girmek demek
             * Utilities altına bir tane interceptors açın 
             * MethodInterceptionBaseAttribute a girelim
             * Attribute i sen ödevlerden izledin bu validation gibi log gibi cache gibi şeyleri biz metodların
             * üzerine attribute olarak koyuyoruz [validate] demiş oluyoruz
             * [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, ------> şu kısım nereye ekleyebilirim onu gösteriyor
             * AllowMultiple = true---> birden fazla yere atribute edebilirsin, Inherited = true------> İnherit edilen bir noktada attribute çalışsn diyebilirim)]
    public abstract partial class MethodInterceptionBaseAttribute : Attribute, IInterceptor

             */
        }
    }
}
