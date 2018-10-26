using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Air.Currency.Library.Extension
{
    public static class JsonExtensions
    {
        public static JsonSerializerSettings CreateNullValueSerializerSettings()
        {
            JsonSerializerSettings json = new JsonSerializerSettings();
            json.NullValueHandling = NullValueHandling.Ignore;
            return json;
        }

        /// <summary>
        /// 返回当前对象的json字符串值
        /// </summary>
        /// <typeparam name="T">对象</typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToJson<T>(this T obj) where T : new()
        {
            string value = JsonConvert.SerializeObject(obj);
            return value;
        }
    }
}
