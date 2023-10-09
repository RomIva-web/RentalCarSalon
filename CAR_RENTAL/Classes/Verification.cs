using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CAR_RENTAL.Classes
{
    class Verification
    {
        //internal static string ConnectionStr = @"Data Source=172.20.105.2;Initial Catalog=user33;User ID=user33;Password=user33#33;"; // Colledge
        internal static string ConnectionStr = @"Data Source=DESKTOP-LBQ04FP\SQLEXPRESS03;Initial Catalog=CarRentalSalon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; // Home
        public static bool VerifySHA512Hash(string input, string hash)
        {
            string hashOfInput = GetSHA512Hash(input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string GetSHA512Hash(string input)
        {
            SHA512CryptoServiceProvider SHA512Hasher = new SHA512CryptoServiceProvider();
            byte[] data = SHA512Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}

