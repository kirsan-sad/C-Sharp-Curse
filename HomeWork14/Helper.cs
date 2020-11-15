using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;


namespace dz14
{
    public static class Helper
    {
        public static List<T> GetObjectsFromFile<T>(string fileName)
        {
            List<T> obj = null;

            using (var sr = new StreamReader(fileName))
            {
                obj = sr.GetObject<T>();
            }

            return obj;
        }

        public static List<T> GetObject<T>(this StreamReader sr)
        {
            var json = sr.ReadToEnd();
            return JsonConvert.DeserializeObject<List<T>>(json);
        }
    }
}
