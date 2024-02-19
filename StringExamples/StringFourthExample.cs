namespace StringExamples
{
    internal class StringFourthExample
    {
        static void Main(string[] args)
        {
            string firstName = "Rahul";
            string secondName = "Bose";

            string displayName = $"Welcome!\n {firstName}\t{secondName}";
            Console.WriteLine(displayName);

            string filePath = "E:\\Folder1\\text1.txt"; //Providing the File Name using the Escaped Sequence

            Console.WriteLine("Providing the File Name using the Escaped Sequence\r\n");
            Console.WriteLine(File.Exists(filePath));

            string filePath2 = @"E:\Folder1\text1.txt";

            Console.WriteLine("Providing the File Name using the Verbatim Sequence\r\n");
            Console.WriteLine(File.Exists(filePath2));
            Console.WriteLine("Using the Double quotes");
            Console.WriteLine("We should provide \"double quotes\" in the Line");


        }
    }
}
