using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternApp
{
    // Общий интерфейс для компонентов (файлы и папки)
    public interface IFileSystemComponent
    {
        void Display(string indent); // Метод для отображения структуры
    }
}
