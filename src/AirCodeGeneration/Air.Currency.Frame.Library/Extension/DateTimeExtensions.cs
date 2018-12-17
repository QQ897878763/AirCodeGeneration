using System;
using System.Collections.Generic;
using System.Text;

namespace Air.Currency.Frame.Library.Extension
{
    /// <summary>
    /// 日期时间扩展函数类
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Unix起始时间
        /// </summary>
        public static DateTime BaseTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);

        /// <summary>
        /// 获取Unix时间戳
        /// 微信支付接口会用到
        /// </summary>
        /// <returns></returns>
        public static string GetTimestamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }


        /// <summary>
        /// 将Unix时间戳转换为当前时间
        /// </summary>
        /// <param name="timeStamp">Unix时间戳</param>
        /// <returns></returns>
        public static DateTime TransferDateTime(this int timeStamp)
        {
            return TimeZone.CurrentTimeZone.ToLocalTime(BaseTime).Add(TimeSpan.FromSeconds(timeStamp));
        }

        /// <summary>
        /// 将时间转换为Unix时间戳
        /// </summary>
        /// <param name="time">需要转换的时间</param>
        /// <returns></returns>
        public static int TransferDateTime(this DateTime time)
        {
            return (int)TimeSpan.FromTicks(time.ToUniversalTime().Ticks - BaseTime.Ticks).TotalSeconds;
        }

        /// <summary>
        ///返回周几的中文名称
        /// </summary>
        /// <param name="week"></param>
        /// <returns></returns>
        public static string ConvertWeekDay(this DayOfWeek week)
        {
            string result = string.Empty;

            switch (week)
            {
                case DayOfWeek.Monday:
                    result = "周一";
                    break;
                case DayOfWeek.Tuesday:
                    result = "周二";
                    break;
                case DayOfWeek.Wednesday:
                    result = "周三";
                    break;
                case DayOfWeek.Thursday:
                    result = "周四";
                    break;
                case DayOfWeek.Friday:
                    result = "周五";
                    break;
                case DayOfWeek.Saturday:
                    result = "周六";
                    break;
                default:
                    result = "周日";
                    break;
            }
            return result;
        }


        /// <summary>
        ///返回周几的数值
        /// </summary>
        /// <param name="week"></param>
        /// <returns></returns>
        public static int ConvertWeekDayNum(this DayOfWeek week)
        {

            switch (week)
            {
                case DayOfWeek.Monday:
                    return 1;
                case DayOfWeek.Tuesday:
                    return 2;
                case DayOfWeek.Wednesday:
                    return 3;
                case DayOfWeek.Thursday:
                    return 4;
                case DayOfWeek.Friday:
                    return 5;
                case DayOfWeek.Saturday:
                    return 6;
                default:
                    return 7;
            }
        }
    }
}
