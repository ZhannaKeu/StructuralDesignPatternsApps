using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternApp
{
    // Класс старого принтера
    public class OldPrinter : IOldPrinter
    {
        public void PrintDocument(string text)
        {
            Console.WriteLine($"Старый принтер печатает: {text}");
        }
    }
}
