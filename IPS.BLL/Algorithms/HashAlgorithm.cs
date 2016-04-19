using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace IPS.BLL.Algorithms
{
    public static class HashAlgorithm
    {
        public static string GetHashCode(string input)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            var hash = md5.ComputeHash(
                    System.Text.Encoding.ASCII.GetBytes(input));

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                output.Append(hash[i].ToString("X2"));
            }
            return output.ToString();
        }
    }
}
