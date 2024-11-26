using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternApp
{
    // Составной элемент: Папка
    public class Folder : IFileSystemComponent
    {
        private readonly string _name;
        private readonly List<IFileSystemComponent> _children = new();

        public Folder(string name)
        {
            _name = name;
        }

        // Добавление компонента в папку
        public void Add(IFileSystemComponent component)
        {
            _children.Add(component);
        }

        // Удаление компонента из папки
        public void Remove(IFileSystemComponent component)
        {
            _children.Remove(component);
        }

        public void Display(string indent)
        {
            Console.WriteLine($"{indent}+ Папка: {_name}");
            foreach (var child in _children)
            {
                child.Display(indent + "  ");
            }
        }
    }
}
