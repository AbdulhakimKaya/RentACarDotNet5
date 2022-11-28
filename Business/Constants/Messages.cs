using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarListed = "Arabalar listelendi";
        public static string CarDailyPriceInvalid = "Araba ücreti 0 TL den fazla olmalıdır";
        public static string CarImageListed = "Arabanın resimleri listelendi";
        public static string CarImageLimitedExceded = "En fazla 5 resim ekleyebilirsiniz. ";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt başarılı bir şekilde gerçekleştirildi.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Parola hatası!";
        public static string AccessTokenCreated = "Token oluşturuldu.";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut!";
    }
}
