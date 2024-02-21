using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TestFunction
{
    internal class Program
    {
        #region Support
        private static string Reverse(string st)
        {
            string tmp = "";

            for (int i = st.Length - 1; i >= 0; --i)
            {
                tmp += st[i];
            }

            return tmp;
        }
        private static string Complicate(string st)
        {
            st += @"8f";
            //chia thành 2 nửa chuỗi bằng nhau
            string st1 = st.Substring(0, st.Length >> 1);
            string st2 = st.Substring(st.Length >> 1);

            Console.WriteLine(st.Length);
            Console.WriteLine(st1);
            Console.WriteLine(st2);
            st1 = Reverse(st1);
            st2 = Reverse(st2);

            return (st1 + st2);
        }
        private static string ComplicateX(string st)
        {
            Random rand = new Random();
            st += rand.Next(10, 99).ToString();
            string st1 = st.Substring(0, st.Length >> 1);
            string st2 = st.Substring(st.Length >> 1);

            st1 = Reverse(st1);
            st2 = Reverse(st2);

            return (st1 + st2);
        }
        private static string Simplify(string st)
        {
            string st1 = st.Substring(0, st.Length >> 1);
            string st2 = st.Substring(st.Length >> 1);

            st1 = Reverse(st1);
            st2 = Reverse(st2);

            st = (st1 + st2);

            st = st.Substring(0, st.Length - 2);
            return st;
        }
        #endregion

        #region crypt
        public static string getMD5(string plainText)
        {
            plainText = Complicate(plainText);

            string str_md5 = "";
            byte[] arr = System.Text.Encoding.UTF8.GetBytes(plainText);

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            arr = my_md5.ComputeHash(arr);
            int n = arr.Length;

            for (int i = 0; i < n; ++i)
            {
                str_md5 += arr[i].ToString();
            }

            return Reverse(str_md5);
        }

        public static string getEncrypt(string st)
        {
            st = Complicate(st);

            st = Eramake.eCryptography.Encrypt(st);

            st = Complicate(st);

            return Reverse(st);
        }

        public static string getEncryptX(string st)
        {
            st = ComplicateX(st);

            st = Eramake.eCryptography.Encrypt(st);

            st = Complicate(st);

            return Reverse(st);
        }

        public static string getDecrypt(string st)
        {
            string s0 = st;
            st = Reverse(st);
            st = Simplify(st);

            try
            {
                st = Eramake.eCryptography.Decrypt(st);
            }
            catch
            {
                return s0;
            }

            return Simplify(st);
        }
        #endregion
        static void Main(string[] args)
        {
            //Console.WriteLine(getEncrypt("cn1"));
            //Console.WriteLine(getMD5("123"));
            Console.WriteLine(getEncrypt("lovenevertolate97@gmail.com"));
            Console.WriteLine(getDecrypt("85F7t2bJlAJkwwUe6u1U=8fxCGW1HpEtvIdOLYZhJmb2ef"));
        }
    }
}
