using System;
using System.IO;

class Program
{
    static void Main()
    {
        //replace the path with the one to the Clippings.txt on your kindle
        string filePath = "F:\\documents\\My Clippings.txt";

        // Check if the file exists
        if (!File.Exists(filePath))
        {
            throw new Exception("FileNotFoundError");
            return;
        }

        // Open the text file in read mode
        using (StreamReader reader = new StreamReader(filePath))
        {
            // Read the file line by line
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                line.Trim('\n');
                if(line!="=========="){
                    Console.WriteLine(line);
                }
            }
        }
    }
}