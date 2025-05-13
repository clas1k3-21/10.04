using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\Игорь\\source\\repos\\ConsoleApp7\\bin\\Debug\\text.txt";
            SaveUserInputToFile(filePath);
            AnalyzeFile(filePath);
        }
        static void SaveUserInputToFile(string path)
        {
            using (StreamWriter wr = new StreamWriter(path))
            {
                while (true)
                {
                    Console.Write("Введите строку (exit - завершить): ");
                    string input = Console.ReadLine();

                    if (input == "exit")
                    {
                        break;
                    }    
                    wr.WriteLine(input);
                }
            }
        }
        static void AnalyzeFile(string path)
        {
            int lines = 0;
            int words = 0;
            int chars = 0;

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lines++; 
                    chars += line.Length; 
                    string[] lineWords = line.Split(' ');
                    words += lineWords.Length; 
                }
            }   
            Console.WriteLine($"Строк: {lines}");
            Console.WriteLine($"Слов: {words}");
            Console.WriteLine($"Символов: {chars}");
        }

    }
}
