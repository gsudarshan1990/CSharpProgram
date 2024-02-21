using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDirectoryExample
{
     class FileStreamWriter
    {
        static void Main(string[] args)
        {
            FileInfo fi = new FileInfo("C:\\Users\\admin\\source\\repos\\FileDirectoryExample\\FileDirectoryExample\\FileReadWrite.txt");

            FileStream fs = fi.Open(FileMode.Append, FileAccess.Write, FileShare.Write);

            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("\nThis line is written using the stream writer");

            sw.Close();
            fs.Close();
        }
    }
}
