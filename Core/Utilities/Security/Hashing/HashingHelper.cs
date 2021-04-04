using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        //Bu yöntem, şifre için Salt ve Hash değerlerinin oluşturulmasına izin verir.
        public static void CreatePasswordHash(string password, out byte[] passworHash, out byte[] passswordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passswordSalt = hmac.Key;
                passworHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
        // Bu yöntem, sisteme daha sonra giren kullanıcının şifresinin oluşturduğu Hash'i veritabanındaki Hash ile karşılaştırır.
        public static bool VerifyPasswordHash(string password, byte[] passworHash, byte[] passswordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passswordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passworHash[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
