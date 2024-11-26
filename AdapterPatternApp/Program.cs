using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем старый принтер
            IOldPrinter oldPrinter = new OldPrinter();

            // Адаптируем старый принтер под новую систему
            INewPrinter adapter = new PrinterAdapter(oldPrinter);

            // Используем адаптированный принтер в новой системе
            ModernSystem system = new ModernSystem(adapter);
            system.PrintDocument("Документ для печати");

            Console.ReadLine();
        }
    }
}
