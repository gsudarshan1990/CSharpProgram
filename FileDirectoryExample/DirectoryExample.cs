using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDirectoryExample
{
     class DirectoryExample
    {
        static void Main(string[] args)
        {
            string directory_path = "C:\\Users\\admin\\source\\repos\\FileDirectoryExample\\FileDirectoryExample\\ExampleDirectory";

            CreateDirectory(directory_path);

            Console.WriteLine("Printing the File in the Directory");

            string directory_path2 = "C:\\Users\\admin\\source\\repos\\FileDirectoryExample\\FileDirectoryExample\\Directory1\\";

            PrintFiles(directory_path2);

            Console.WriteLine();
            Console.WriteLine("Checking the Directory Exists");
            Console.WriteLine(Directory.Exists(directory_path));

            Console.WriteLine("Deleting the Directory");
            string directory_path3 = "C:\\Users\\admin\\source\\repos\\FileDirectoryExample\\FileDirectoryExample\\Directory3\\";

            DeleteDirectory(directory_path3);
        }

        static void CreateDirectory(string path)
        {
            Directory.CreateDirectory(path);
            Console.WriteLine("Directory created successfully");
        }

        static void PrintFiles(string path)
        {
            Console.WriteLine("Printing the Files");

            string[] files = Directory.GetFiles(path);

            foreach(var file in files)
            {
                Console.WriteLine("FileName:{0}", file);
            }
        }

        static void DeleteDirectory(string path)
        {
            Directory.Delete(path);
            Console.WriteLine("Directory Deleted Successfully");
        }
    }
}
