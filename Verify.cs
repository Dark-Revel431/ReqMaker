using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ReqMaker
{
    class Verify
    {
        public string VerFileToRead(String[] args)
        {
            try
            {
                string FileToRead = args[0];
                return FileToRead;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool VerExistFile(string FileToRead)
        {
            if (File.Exists(FileToRead))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerReadFile(string FileToRead)
        {
            try
            {
                string line;
                string text = "";
                System.IO.StreamReader file = new System.IO.StreamReader(FileToRead);
                while ((line = file.ReadLine()) != null)
                {
                    text = text + line + "\n";
                }
                file.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
