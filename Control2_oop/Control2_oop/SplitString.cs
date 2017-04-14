using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control2_oop
{
  public  class SplitString
    {
       public void Split1(string text)
        {
            string[] split = text.Split(new char[] { '\n' });
            
            foreach (string s in split)
            {

                if (s.Trim() != "")
                    
                    if(s.Contains("Text"))
                    {
                        Text text1 = new Text();
                        text1.split_text(s);
                    }
                // if (s == "Text")
                //  Console.WriteLine(s);
                if (s.Contains("Image"))
                {
                    Image image1 = new Image();
                    image1.split_text(s);
                }

            }
        }
}
}

