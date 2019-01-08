using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ISTC.Codingschool.OOP.WorkWithFiles2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку для записи в файл:");
            string text = Console.ReadLine();

            // запись в файл
            using (FileStream fstream = new FileStream(@"C:\Users\pqoal\Documents\note.txt", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
                Console.WriteLine("Текст записан в файл");
            }

            // чтение из файла
            using (FileStream fstream = File.OpenRead(@"C:\Users\pqoal\Documents\note.txt"))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine("Текст из файла: {0}", textFromFile);
            }

            Console.ReadLine();
        }
    }
}
