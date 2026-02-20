using System;
namespace InterfaceAndPolymorphism_CSharp
{
    public class FileLogger : ILogger
    {
        public void LogMessage(string message)
        {
            // The @ sign in C# is used to create a verbatim string literal, which allows us to include backslashes without needing to escape them.
            string directoryPath = @"C:\Users";

            // We can combine the directory path with the file name to create a full file path using the Path.Combine method, 
            // which ensures that the correct directory separator is used.
            string filePath = System.IO.Path.Combine(directoryPath, "log.txt");

            // If the directory specified in the directoryPath variable does not exist, we can create it using the Directory.CreateDirectory method.
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            // Using the File class, we can write a long message to a log file called "log.txt".
            // The AppendAllText method will create the file if it doesn't exist, or append to it if it does.
            // The first argument is the file name or file path, and the second argument is the message we want to write, followed by a newline character for better readability.
            File.AppendAllText(filePath, message + "\n");
        }
    }
}