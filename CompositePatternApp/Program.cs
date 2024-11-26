using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем файлы
            var file1 = new File("file1.txt");
            var file2 = new File("file2.txt");
            var file3 = new File("file3.txt");

            // Создаем папки
            var folder1 = new Folder("Documents");
            var folder2 = new Folder("Images");
            var rootFolder = new Folder("Root");

            // Строим структуру
            folder1.Add(file1);
            folder1.Add(file2);
            folder2.Add(file3);
            rootFolder.Add(folder1);
            rootFolder.Add(folder2);

            // Отображаем структуру
            rootFolder.Display("");
        }
    }
}
