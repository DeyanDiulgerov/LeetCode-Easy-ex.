using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignHashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public class MyHashSet
        {
            HashSet<int> set = null;
            public MyHashSet()
            {
                set = new HashSet<int>();
            }

            public void Add(int key)
            {
                if (!set.Contains(key))
                    set.Add(key);
            }

            public void Remove(int key)
            {
                if (set.Contains(key))
                    set.Remove(key);
            }

            public bool Contains(int key)
            {
                return set.Contains(key);
            }
        }
    }
}
