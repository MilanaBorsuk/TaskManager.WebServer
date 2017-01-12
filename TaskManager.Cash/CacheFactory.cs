using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Cache
{
    public class CacheFactory
    {
        private static Dictionary<string, ICache> FactoryDictionary = new Dictionary<string, ICache>()
        {
            {Enums.Task.ToString(), new TaskCache()}
        };

        public static ICache CacheManager(string key)
        {
            if(FactoryDictionary.ContainsKey(key))
            {
                return FactoryDictionary[key];
            }
            else
            {
                return null;
            }
        }
    }
}
