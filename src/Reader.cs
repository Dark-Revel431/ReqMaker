using System;
using System.Collections.Generic;
using System.Text;

namespace ReqMaker
{
    class Reader
    {
        public void ReadFile(string FileToRead)
        {
            List<string> pip = new List<string>();
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(FileToRead);
            while ((line = file.ReadLine()) != null)
            {
                String[] lineS = line.Split(',', ' ', '\t');
                for (int x = 0; x < lineS.Length; x++)
                {
                    if (lineS[x].Equals("import"))
                    {
                        pip.Add(lineS[x + 1]);
                        for (int y = x + 2; y < lineS.Length; y++)
                        {
                            if (lineS[y].Equals(""))
                            {
                                continue;
                            }
                            else
                            {
                                pip.Add(lineS[y]);
                            }
                        }
                    }
                    else if (lineS[x].Equals("from"))
                    {
                        pip.Add(lineS[x + 1]);
                        x += 2;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            file.Close();

            List<string> newPip = new List<string>();
            foreach (var pi in pip)
            {
                if (pi.Contains('.'))
                {
                    String[] piS = pi.Split('.');
                    newPip.Add(piS[0]);
                }
                else
                {
                    newPip.Add(pi);
                }
            }

            Writer write = new Writer();
            write.WriteFile(newPip);
        }
    }
}
