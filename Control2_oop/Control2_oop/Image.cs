using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control2_oop
{
    class Image
    {
        public void split_text(string s) {
            string[] split = s.Split(new char[] { '\n' });

            foreach (string t in split)
            {

                if (t.Trim() != "")

                    if (t.Contains("("))
                    {
                        string nameImage = t;
                        Console.WriteLine(nameImage);
                    }


            }

        }
    }
}
