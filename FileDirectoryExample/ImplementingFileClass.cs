using System.Globalization;

namespace FileDirectoryExample
{
    class ImplementingFileClass
    {
        static void Main(string[] args)
        {
            string filepath = "C:\\Users\\admin\\source\\repos\\FileDirectoryExample\\FileDirectoryExample\\FileReadWrite.txt";

            Console.WriteLine("Date Written to the File");
            string writeContent = "Hello File";

            WriteToFile(filepath, writeContent);

            Console.WriteLine();

            Console.WriteLine("Data Read From the File");

            string content = ReadToFile(filepath);

            Console.WriteLine("Check the File Exists");

            Console.WriteLine(File.Exists(filepath));

            Console.WriteLine("Append the File ");

            string newcontent = " This line is used for the Appending Purpose";

            AppendToFile(filepath, newcontent);

            DateTime dt = File.GetLastAccessTime(filepath);

            Console.WriteLine(dt.ToString());

            DateTime dt2 = File.GetLastWriteTime(filepath);

            Console.WriteLine(dt2.ToString());

            String fileDelete = "C:\\Users\\admin\\source\\repos\\FileDirectoryExample\\FileDirectoryExample\\FileDelete.txt";

            Console.WriteLine("Check File Exists " + File.Exists(fileDelete));

            DeleteFile(fileDelete);

            Console.WriteLine();

            Console.WriteLine("Check File Exists " + File.Exists(fileDelete));

        }

        static void WriteToFile(string path, string content)
        {
            File.WriteAllText(path, content);
            Console.WriteLine("Written to File Successfully");
        }

        static string ReadToFile(string path)
        {
            return File.ReadAllText(path);
        }

        static void AppendToFile(string path, string content)
        {
            File.AppendAllText(path, content);
        }

        static void DeleteFile(string path)
        {
            File.Delete(path);
            Console.WriteLine("File Deleted Successfully");
        }
    }
    
}
