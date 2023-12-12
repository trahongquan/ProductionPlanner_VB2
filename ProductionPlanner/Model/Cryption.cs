using System.Security.Cryptography;

namespace ProductionPlanner.Model
{
    internal class Cryption
    {
        public Cryption()
        {
        }

        #region Support
        private string Reverse(string st)
        {
            string tmp = "";

            for (int i = st.Length - 1; i >= 0; --i)
            {
                tmp += st[i];
            }

            return tmp;
        }
        private string Complicate(string st)
        {
            st += @"8f";
            string st1 = st.Substring(0, st.Length >> 1);
            string st2 = st.Substring(st.Length >> 1);

            st1 = Reverse(st1);
            st2 = Reverse(st2);

            return (st1 + st2);
        }
        private string ComplicateX(string st)
        {
            Random rand = new Random();
            st += rand.Next(10, 99).ToString();
            string st1 = st.Substring(0, st.Length >> 1);
            string st2 = st.Substring(st.Length >> 1);

            st1 = Reverse(st1);
            st2 = Reverse(st2);

            return (st1 + st2);
        }
        private string Simplify(string st)
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
        public string getMD5(string plainText)
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

        public string getEncrypt(string st)
        {
            st = Complicate(st);

            st = Eramake.eCryptography.Encrypt(st);

            st = Complicate(st);

            return Reverse(st);
        }

        public string getEncryptX(string st)
        {
            st = ComplicateX(st);

            st = Eramake.eCryptography.Encrypt(st);

            st = Complicate(st);

            return Reverse(st);
        }

        public string getDecrypt(string st)
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
    }


}
