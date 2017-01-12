using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Cache
{
    //public class Cache: Dictionary<string, object>
    //{
    //    private static Cache cacheDictionary { get; set; }
    //    private Cache()
    //    { }

    //    public static Cache CacheDictionary
    //    {
    //        get
    //        {
    //            if (cacheDictionary == null)
    //            {
    //                cacheDictionary = new Cache();
    //            }
    //            return cacheDictionary;
    //        }
    //    }
    //}

    public class Cache
    {
        private static object lockobj = new object();
        private static Dictionary<string, object> cacheDictionary { get; set; }
        private Cache()
        { }

        public static Dictionary<string, object> CacheDictionary
        {
            get
            {
                lock (lockobj)
                {
                    if (cacheDictionary == null)
                    {
                        cacheDictionary = new Dictionary<string, object>();
                    }
                }
                return cacheDictionary;
            }
        }
    }
}
