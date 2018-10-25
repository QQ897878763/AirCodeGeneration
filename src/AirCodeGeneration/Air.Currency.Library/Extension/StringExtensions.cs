using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Air.Currency.Library.Extension
{
    /// <summary>
    /// 字符串扩展函数
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// 是否为空字符串
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsNullOrWhiteSpace(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return true;
            else
                return false;
        }

        /// <summary>
        /// 获取单个字符的ASCII码
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        public static int Asc(this string character)
        {
            if (character.Length == 1)
            {
                System.Text.ASCIIEncoding asciiEncoding = new System.Text.ASCIIEncoding();
                int intAsciiCode = (int)asciiEncoding.GetBytes(character)[0];
                return (intAsciiCode);
            }
            else
            {
                throw new Exception("字符数量长度不为1,转换ASCII码失败！");
            }
        }

        /// <summary>
        /// 字符串转ASCII码
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string AscAll(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new Exception("字符为空,转换ASCII码失败！");
            string result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                string item = input.Substring(i, 1);
                int value = Asc(item);
                result += value.ToString();
            }
            return result;

        }

        /// <summary>
        /// ASCII码转换字符串
        /// </summary>
        /// <param name="asciiCode"></param>
        /// <returns></returns>
        public static string Chr(this int asciiCode)
        {
            if (asciiCode >= 0 && asciiCode <= 255)
            {
                System.Text.ASCIIEncoding asciiEncoding = new System.Text.ASCIIEncoding();
                byte[] byteArray = new byte[] { (byte)asciiCode };
                string strCharacter = asciiEncoding.GetString(byteArray);
                return (strCharacter);
            }
            else
            {
                throw new Exception("ASCII码为空,转换字符串失败!");
            }
        }


        /// <summary>
        /// 将16进制的字符串转为byte[]
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        public static byte[] strToToHexByte(this string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            return returnBytes;
        }

        /// <summary>
        /// 验证是否为身份证
        /// </summary>
        /// <param name="input">值</param>
        /// <returns></returns>
        public static bool IsIDCard(this string input)
        {
            Regex regex;
            string[] strArray;
            DateTime time;
            if ((input.Length != 15) && (input.Length != 0x12))
            {
                return false;
            }
            if (input.Length == 15)
            {
                regex = new Regex(@"^(\d{6})(\d{2})(\d{2})(\d{2})(\d{3})$");
                if (!regex.Match(input).Success)
                {
                    return false;
                }
                strArray = regex.Split(input);
                try
                {
                    time = new DateTime(int.Parse("19" + strArray[2]), int.Parse(strArray[3]), int.Parse(strArray[4]));
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            regex = new Regex(@"^(\d{6})(\d{4})(\d{2})(\d{2})(\d{3})([0-9Xx])$");
            if (!regex.Match(input).Success)
            {
                return false;
            }
            strArray = regex.Split(input);
            try
            {
                time = new DateTime(int.Parse(strArray[2]), int.Parse(strArray[3]), int.Parse(strArray[4]));
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 验证字符串是否为整数数字
        /// </summary>
        /// <param name="value">字符串</param>
        /// <returns></returns>
        public static bool IsNumeric(this string input)
        {
            return QuickValidate("^[1-9]*[0-9]*$", input);
        }
        /// <summary>
        /// 二位小数
        /// </summary>
        /// <param name="_value"></param>
        /// <returns></returns>
        public static bool IsNumber(this string input)
        {
            return QuickValidate("^(0|([1-9]+[0-9]*))(.[0-9][0-9])?$", input);
        }
        /// <summary>
        /// 是否为电子邮件
        /// </summary>
        public static bool EmailRegex(this string input)
        {
            string patternRegex = @"[\w!#$%&'*+/=?^_`{|}~-]+(?:\.[\w!#$%&'*+/=?^_`{|}~-]+)*@(?:[\w](?:[\w-]*[\w])?\.)+[\w](?:[\w-]*[\w])?";
            return RegexAll(input, patternRegex);
        }

        /// <summary>
        /// 校验是否为银行卡号扩展函数：16位银行卡号（19位通用）:
        /// </summary>
        /// <param name="cardNO">银行卡号</param>
        /// <returns></returns>
        public static bool IsBankCardNum(this string input)
        {
            //1.将未带校验位的 15（或18）位卡号从右依次编号 1 到 15（18），位于奇数位号上的数字乘以 2
            //2.将奇位乘积的个十位全部相加(大于9则减9)，再加上所有偶数位上的数字。
            //3.将加法和加上校验位能被 10 整除。
            //总和被10整除 则合法卡号
            //校验位
            int lastNum = int.Parse(input.Substring(input.Length - 1, 1));
            //取出15或18的卡号
            input = input.Substring(0, input.Length - 1);
            int sum = 0;
            //是否奇数
            bool isOdd = true;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (isOdd)
                {
                    //奇数位乘2后个位与十位相加
                    int temp = int.Parse(input.Substring(i, 1));
                    temp *= 2;
                    //大于9则减9
                    if (temp > 9)
                        temp -= 9;
                    sum += temp;
                }
                else
                {
                    //偶数位
                    sum += int.Parse(input.Substring(i, 1));
                }
                //前进一位则奇偶变换
                isOdd = !isOdd;
            }
            return (sum + lastNum) % 10 == 0;//总和被10整除 则合法卡号
        }
        /// <summary>
        /// 校验是否为手机号码扩展函数
        /// </summary>
        /// <param name="input">手机号</param>
        /// <returns></returns>
        public static bool IsMobileNum(this string input)
        {
            //string patternRegex = @"\d{3}-\d{8}|\d{4}-\{7,8}";
            Regex regex = new Regex(@"^1\d{10}$", RegexOptions.IgnoreCase);
            return regex.Match(input).Success;
        }

        /// <summary>
        /// 校验是否为IP
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public static bool IsIPSect(this string ip)
        {
            return Regex.IsMatch(ip, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){2}((2[0-4]\d|25[0-5]|[01]?\d\d?|\*)\.)(2[0-4]\d|25[0-5]|[01]?\d\d?|\*)$");
        }

        /// <summary>
        /// 校验是否为Url
        /// </summary>
        public static bool IsUrl(this string input)
        {
            string patternRegex = @"[a-zA-z]+://[^\s]*";
            return RegexAll(input, patternRegex);
        }

        /// <summary>
        /// 校验是否为QQ号码
        /// </summary>
        public static bool QQRegex(this string input)
        {
            string patternRegex = @"[1-9][0-9]{4,}";
            return RegexAll(input, patternRegex);
        }

        /// <summary>
        /// 验证表达式
        /// </summary>
        /// <param name="express"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private static bool QuickValidate(string express, string value)
        {
            Regex regex = new Regex(express);
            if (value.Length == 0)
            {
                return false;
            }
            return regex.IsMatch(value);
        }

        /// <summary>
        /// 正则表达式验证规则
        /// </summary>
        /// <param name="input">明文</param>
        /// <param name="patternRegex">验证规则</param>
        private static bool RegexAll(string input, string patternRegex)
        {
            bool isOK = false;
            try
            {
                isOK = new Regex(patternRegex, RegexOptions.IgnoreCase).Match(input).Success;
            }
            catch (ArgumentNullException) { return false; }
            catch (ArgumentOutOfRangeException) { return false; }
            catch (ArgumentException) { return false; }
            catch (RegexMatchTimeoutException) { return false; }
            catch (Exception) { return false; }
            return isOK;
        }
    }
}
