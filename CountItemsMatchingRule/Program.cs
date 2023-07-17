using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountItemsMatchingRule
{
    class Program
    {
        static void Main(string[] args)
        {
            var items1 = new List<IList<string>>()
            {
                new List<string>() {"phone","blue","pixel"},
                new List<string>() {"computer","silver","lenovo"},
                new List<string>() {"phone","gold","iphone"},
            };

            var items2 = new List<IList<string>>()
            {
                new List<string>() {"phone","blue","pixel"},
                new List<string>() {"computer","silver","phone"},
                new List<string>() {"phone","gold","iphone"},
            };

            Console.WriteLine(String.Join(",",
                CountItemsMatchingRule(items1, "color", "silver")));

            Console.WriteLine(String.Join(",",
                CountItemsMatchingRule(items2, "type", "phone")));
        }

        public static int CountItemsMatchingRule(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            int matchItems = 0;

            for (int i = 0; i < items.Count(); i++)
            {
                if (ruleKey == "type" && ruleValue == items[i][0])
                {
                    matchItems++;
                }
                else if (ruleKey == "color" && ruleValue == items[i][1])
                {
                    matchItems++;
                }
                else if (ruleKey == "name" && ruleValue == items[i][2])
                {
                    matchItems++;
                }
            }

            return matchItems;
        }
    }
}
