using System;

namespace ReqMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Reader read = new Reader();
            Verify ver = new Verify();

            string FileToRead = ver.VerFileToRead(args);
            if (FileToRead == null)
            {
                Console.WriteLine("No [FileToRead] param!");
                Environment.Exit(1);
            }

            bool FileExist = ver.VerExistFile(FileToRead);
            if (FileExist == false)
            {
                Console.WriteLine("The file [" + FileToRead + "] doesn't exist!");
                Environment.Exit(1);
            }

            bool CanOpenFile = ver.VerReadFile(FileToRead);
            if (CanOpenFile == false)
            {
                Console.WriteLine("Cannot read the file [" + FileToRead + "]!");
                Environment.Exit(1);
            }

            read.ReadFile(FileToRead);
        }
    }
}
