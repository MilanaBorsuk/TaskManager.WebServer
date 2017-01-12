using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Cache
{
    public interface ICache
    {
        void Add(string key, object value);
        void Clear(string key);
        object Get(string key);
    }
}
