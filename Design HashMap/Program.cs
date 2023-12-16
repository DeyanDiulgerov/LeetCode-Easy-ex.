using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_HashMap
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static Dictionary<int, int> map = null;
        public  MyHashMap()
        {
            map = new Dictionary<int, int>();
        }

        public void Put(int key, int value)
        {
            if (!map.ContainsKey(key))
                map.Add(key, value);
            else
                map[key] = value;
        }

        public int Get(int key)
        {
            if (!map.ContainsKey(key))
                return -1;
            else
                return map[key];
        }

        public void Remove(int key)
        {
            if (map.ContainsKey(key))
                map.Remove(key);
        }
    }
}
