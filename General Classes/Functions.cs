using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SonarSUPREME.General_Classes
{
    public class TextArgs : EventArgs
    {
        #region Fields
        private string szMessage;
        #endregion Fields

        #region ConstructorsH
        public TextArgs(string TextMessage)
        {
            szMessage = TextMessage;
        }
        #endregion Constructors

        #region Properties
        public string Message
        {
            get { return szMessage; }
            set { szMessage = value; }
        }
        #endregion Properties
    }
    class Functions
    {
        private static Random rand = new Random();

        public static int Compute(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];

            // Step 1
            if (n == 0)
            {
                return m;
            }

            if (m == 0)
            {
                return n;
            }

            // Step 2
            for (int i = 0; i <= n; d[i, 0] = i++)
            {
            }

            for (int j = 0; j <= m; d[0, j] = j++)
            {
            }

            // Step 3
            for (int i = 1; i <= n; i++)
            {
                //Step 4
                for (int j = 1; j <= m; j++)
                {
                    // Step 5
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;

                    // Step 6
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }
            // Step 7
            return d[n, m];
        }

        public static string Shuffle(String str)
        {
            var list = new SortedList<int, char>();
            foreach (var c in str)
                list.Add(rand.Next(), c);
            return new string(list.Values.ToArray());
        }
        public static readonly Random _rng = new Random();
        private const string _chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";


        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static string RandomString(int size)
        {
            char[] buffer = new char[size];

            for (int i = 0; i < size; i++)
            {
                buffer[i] = _chars[_rng.Next(_chars.Length)];
            }
            return new string(buffer);
        }

        private static readonly DateTime Jan1st1970 = new DateTime(0x7b2, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        public static byte[] ReadFully(Stream input)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                input.CopyTo(stream);
                return stream.ToArray();
            }
        }

        public static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        public static void LogToConsole(string input)
        {
            //Console.WriteLine(" ");
            //Console.WriteLine(" ");
            //Console.WriteLine("----------------------------");
            //Console.WriteLine(input);
            //Console.WriteLine("----------------------------");
            //Console.WriteLine(" ");
            //Console.WriteLine(" ");
        }



        public static long CurrentTimeMillis()
        {
            TimeSpan span = (TimeSpan)(DateTime.UtcNow - Jan1st1970);
            return (long)span.TotalMilliseconds;
        }

        public static string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

        public static long CurrentTimeSeconds()
        {
            TimeSpan span = (TimeSpan)(DateTime.UtcNow - Jan1st1970);
            return (long)span.TotalSeconds;
        }

        public static string ExtractBetween(string original, string first, string second)
        {
            if (String.IsNullOrEmpty(original))
            {
                return String.Empty;
            }
            try
            {
                int startIndex = original.IndexOf(first) + first.Length;
                int index = original.IndexOf(second, startIndex);
                return original.Substring(startIndex, index - startIndex);
            }
            catch (Exception)
            {
                return String.Empty;
            }
        }

        public static string UrlEncode(string data)
        {
            return System.Uri.EscapeDataString(data);
        }

        public static byte[] DecompressGZIP(byte[] gzip)
        {
            byte[] buffer2;
            using (GZipStream stream = new GZipStream(new MemoryStream(gzip), CompressionMode.Decompress))
            {
                byte[] buffer = new byte[0x1000];
                using (MemoryStream stream2 = new MemoryStream())
                {
                    int count = 0;
                    do
                    {
                        count = stream.Read(buffer, 0, 0x1000);
                        if (count > 0)
                        {
                            stream2.Write(buffer, 0, count);
                        }
                    }
                    while (count > 0);
                    buffer2 = stream2.ToArray();
                }
            }
            return buffer2;
        }

    }
}

