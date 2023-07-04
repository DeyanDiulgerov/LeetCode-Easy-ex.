using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueEmailAddresses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UniqueEmailAddresses(
                new string[] { "linqmafia@leet+code.com", "linqmafia@code.com" }));

            Console.WriteLine(UniqueEmailAddresses(
                new string[] { "test.email+alex@leetcode.com",
                    "test.e.mail+bob.cathy@leetcode.com",
                    "testemail+david@lee.tcode.com" }));

            Console.WriteLine(UniqueEmailAddresses(
                new string[] { "a@leetcode.com", "b@leetcode.com", "c@leetcode.com" }));

            Console.WriteLine(UniqueEmailAddresses(
                new string[] { "fg.r.u.uzj+o.pw@kziczvh.com", "r.cyo.g+d.h+b.ja@tgsg.z.com", "fg.r.u.uzj+o.f.d@kziczvh.com", "r.cyo.g+ng.r.iq@tgsg.z.com", "fg.r.u.uzj+lp.k@kziczvh.com", "r.cyo.g+n.h.e+n.g@tgsg.z.com", "fg.r.u.uzj+k+p.j@kziczvh.com", "fg.r.u.uzj+w.y+b@kziczvh.com", "r.cyo.g+x+d.c+f.t@tgsg.z.com", "r.cyo.g+x+t.y.l.i@tgsg.z.com", "r.cyo.g+brxxi@tgsg.z.com", "r.cyo.g+z+dr.k.u@tgsg.z.com", "r.cyo.g+d+l.c.n+g@tgsg.z.com", "fg.r.u.uzj+vq.o@kziczvh.com", "fg.r.u.uzj+uzq@kziczvh.com", "fg.r.u.uzj+mvz@kziczvh.com", "fg.r.u.uzj+taj@kziczvh.com", "fg.r.u.uzj+fek@kziczvh.com" }));

        }

        public static int UniqueEmailAddresses(string[] emails)
        {
            int counter = 0;
            var allEmails = new List<string>();

            foreach (var email in emails)
            {
                var newEmail = email;
                var atIndex = email.IndexOf("@");

                if (email.Contains('+'))
                {
                    var plusIndex = email.IndexOf('+');
                    if (plusIndex < atIndex)
                        newEmail = newEmail.Remove(plusIndex, atIndex - plusIndex);
                }

                atIndex = newEmail.IndexOf("@");
                var comIndex = newEmail.IndexOf(".com");

                for (int j = 0; j < atIndex; j++)
                {
                    if (newEmail[j] == '.')
                    {
                        newEmail = newEmail.Remove(j, 1);
                        j--;
                    }
                }

                if (!allEmails.Contains(newEmail))
                {
                    allEmails.Add(newEmail);
                    counter++;
                }
            }

            return counter;
        }
    }
}
