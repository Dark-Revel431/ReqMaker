using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ReqMaker
{
    class Writer
    {
        public void WriteFile(List<string> pips)
        {
            try
            {
                StreamWriter writer = new StreamWriter("requirements.txt");

                foreach (var pip in pips)
                {
                    writer.WriteLine(pip);
                    Console.WriteLine("pip :: [" + pip + "] inserted in requirements.txt!");
                }
                writer.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot create the file [requirements.txt]!");
            }
        }
    }
}
