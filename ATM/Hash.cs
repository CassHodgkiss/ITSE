using System.Security.Cryptography;
using System.Text;

namespace ATM
{
    public static class Hash
    {
        public static string GenerateHash(string s) 
        {
            using var hasher = SHA256.Create(); 
            byte[] hashBytes = hasher.ComputeHash(Encoding.UTF8.GetBytes(s)); 

            var hash = new StringBuilder();
            for (int x = 0; x < hashBytes.Length; x++) 
                hash.Append(hashBytes[x].ToString("x2")); 

            return hash.ToString();
        }

        public static bool VerifyHash(string s, string sHash)
        {
            using var hasher = SHA256.Create();
            byte[] hashBytes = hasher.ComputeHash(Encoding.UTF8.GetBytes(s)); 

            var hash = new StringBuilder();
            for (int x = 0; x < hashBytes.Length; x++)
                hash.Append(hashBytes[x].ToString("x2"));

            return hash.ToString() == sHash;
        }
    }
}
