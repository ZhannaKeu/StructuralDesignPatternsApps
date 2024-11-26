using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternApp
{
    // Листовой элемент: Файл
    public class File : IFileSystemComponent
    {
        private readonly string _name;

        public File(string name)
        {
            _name = name;
        }

        public void Display(string indent)
        {
            Console.WriteLine($"{indent}- Файл: {_name}");
        }
    }
}
