using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Cache
{
    public class CacheBase : ICache
    {
        private Dictionary<string, object> Cache = new Dictionary<string, object>();

        public virtual void Add(string key, object value)
        {           
            if (!Cache.ContainsKey(key))
                Cache.Add(key, value);
        }

        public virtual void Clear(string key)
        {
            if (Cache.ContainsKey(key))
            {
                Cache.Remove(key);
            }
        }

        public virtual object Get(string key)
        {
            if (Cache.ContainsKey(key))
            {
                return Cache[key];
            }
            return null;
        }
    }
}
