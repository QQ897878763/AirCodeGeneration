using System;
using System.Collections.Generic;
using System.Text;

namespace Air.Currency.Frame.Library
{
    /// <summary>
    /// 随机数生成工具类
    /// </summary>
    public class RandomHelper
    {
        /// <summary>
        /// 随机生成不重复数字字符串
        /// </summary>
        /// <param name="length">生成随机码的长度</param>
        /// <returns></returns>
        public static string CreateNumRandomCode(int length)
        {
            int rep = 0;
            string str = string.Empty;
            long num2 = DateTime.Now.Ticks + rep;
            rep++;
            Random random = new Random(((int)(((ulong)num2) & 0xffffffffL)) | ((int)(num2 >> rep)));
            for (int i = 0; i < length; i++)
            {
                int num = random.Next();
                str = str + ((char)(0x30 + ((ushort)(num % 10)))).ToString();
            }
            return str;
        }

        /// <summary>
        /// 随机生成字符串（数字和字母混和）
        /// </summary>
        /// <param name="length">生成随机码的长度</param>
        /// <returns></returns>
        public static string CreateRandomCode(int length)
        {
            int rep = 0;
            string str = string.Empty;
            long num2 = DateTime.Now.Ticks + rep;
            rep++;
            Random random = new Random(((int)(((ulong)num2) & 0xffffffffL)) | ((int)(num2 >> rep)));
            for (int i = 0; i < length; i++)
            {
                char ch;
                int num = random.Next();
                if ((num % 2) == 0)
                {
                    ch = (char)(0x30 + ((ushort)(num % 10)));
                }
                else
                {
                    ch = (char)(0x41 + ((ushort)(num % 0x1a)));
                }
                str = str + ch.ToString();
            }
            return str;
        }

        /// <summary>
        /// 从字符串里随机得到，规定个数的字符串.
        /// </summary>
        /// <param name="allChar">需随机获取规定个数的字符串</param>
        /// <param name="CodeCount">随机数长度</param>
        /// <returns></returns>
        private static string GetRandomCode(string allChar, int CodeCount)
        {
            string[] allCharArray = allChar.Split(',');
            string RandomCode = "";
            int temp = -1;
            Random rand = new Random();
            for (int i = 0; i < CodeCount; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(temp * i * ((int)DateTime.Now.Ticks));
                }
                int t = rand.Next(allCharArray.Length - 1);
                while (temp == t)
                {
                    t = rand.Next(allCharArray.Length - 1);
                }
                temp = t;
                RandomCode += allCharArray[t];
            }
            return RandomCode;
        }
    }
}
