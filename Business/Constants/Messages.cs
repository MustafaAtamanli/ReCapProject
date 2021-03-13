using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string MaintenanceTime="Bakım Zamanı";
        public static string CarsListed="Arabalar Listelendi";
        public static string Added = "Ekleme işlemi başarılı";
        public static string NameInvalid = "Eksik veya hatalı bilgi";
        public static string Updated = "Güncelleme işlemi başarılı";
        public static string Deleted = "Silme işlemi başarılı";
        public static string DeletedInvalid = "Silme işlemi başarısız";
        public static string Listed = "Listeleme işlemi başarılı";
        public static string AuthorizationDenied="Yetkiniz Yok";
        public static string UserRegistered="Kayıt Oldu";
        public static string UserNotFound="Kullanıcı Bulunamadı";
        public static string PasswordError="Hatalı Şifre";
        public static string SuccessfulLogin="Giriş Başarılı";
        public static string UserAlreadyExists="Kullanıcı Mevcut";
        public static string AccessTokenCreated="Token Oluşturuldu";
        public static string UserAdded="Kullanıcı Eklendi";
        public static string UserDeleted="Kullanıcı Silindi";
        public static string UserUpdated="Kullanıcı Güncellendi";
        public static string ColorAdded="Renk Eklendi";
        public static string ColorDeleted="Renk Silindi";
        public static string ColorsListed="Renkler Listelendi";
        public static string colorUpdated="Renk Güncellendi";
    }
}
