using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç Eklendi";
        public static string CarNameInvalid = "Araç ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarListed = "Araçlar Listelendi";
        public static string CarDeleted = "Araç Silindi";
        public static string CarUpdated = "Araç Güncellendi";

        public static string BrandAdded = "Marka Eklendi";
        public static string BrandNameInvalid = "Marka ismi geçersiz";
        public static string BrandListed = "Markalar Listelendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandUpdated = "Marka Güncellendi";
        public static string BrandAlreadyExists = "Bu marka zaten mevcut";

        public static string ColorAdded = "Renk Eklendi";
        public static string ColorNameInvalid = "Renk ismi geçersiz";
        public static string ColorListed = "Renkler Listelendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorUpdated = "Renk Güncellendi";


        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerDeleted = "Müşteri Silindi.";
        public static string CustomerUpdated = "Müşteri Güncellendi.";
        public static string CustomerListed = "Müşteri Listelendi.";

        public static string RentalAdded = "Kiralama eklendi.";
        public static string RentalInValid = "Maalesef şuan boş aracımız yok.";
        public static string RentalDeleted = "Kiralama Silindi.";
        public static string RentalUpdated = "Kiralama Güncellendi.";
        public static string RentalListed = "Kiralama Listelendi.";


        public static string UserListed = "Kullanıcı Listelendi.";
        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string UserUpdated = "Kullanıcı güncellendi.";


        public static string CarImageAdded = "Resim eklendi.";
        public static string CarImageDeleted = "Resim Silindi.";
        public static string CarImageUpdated = "Resim Güncellendi.";
        public static string CarImagesListed = "Resimler Listelendi.";

        public static string FindexAdded = "Findekx Eklendi.";
        public static string FindexUpdated = "Findex Güncellendi.";
        public static string FindexDeleted = "Findekx Silindi.";

        public static string PaymentListed = "Ödemeler Listelendi.";
        public static string PaymentAdded = "Ödeme Eklendi.";
        public static object PaymentRecevid = "Ödeme Alındı";

        public static string CreditCardAdded = "Kredi kartı Eklendi";
        public static string CreditCardDeleted = "Kredi kartı Silindi";
        public static string CreditCardListed = "Kredi kartları Listelendi";
        public static string CreditCardUpdated = "Kredi kartı Güncellendi";

        //Business Rule Messages
        public static string CarCheckImageLimited = "Bir araca en fazla 5 resim yükliyebilirsin.";
        public static string ProductAlreadyExists = "Eklemek istediğiniz ürün zaten mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre Hatalı!";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten var";
        public static string UserRegistered = "Kullanıcı başarıyla kayıt oldu.";
        public static string AuthorizationDenied = "Yetkilendirme reddedildi.";


       
    }
}