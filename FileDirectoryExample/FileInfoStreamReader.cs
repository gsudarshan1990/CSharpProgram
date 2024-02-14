using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDirectoryExample
{
    
    class FileInfoStreamReader
    {
        static void Main(string[] args)
        {
            FileInfo fi = new FileInfo("C:\\Users\\admin\\source\\repos\\FileDirectoryExample\\FileDirectoryExample\\FileReadWrite.txt");

            FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);

            StreamReader sr = new StreamReader(fs);

            string content = sr.ReadToEnd();

            Console.WriteLine(content);

            sr.Close();
            fs.Close();
        }
    }
}
