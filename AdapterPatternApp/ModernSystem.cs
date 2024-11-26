using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternApp
{
    // Новая система, работающая только с INewPrinter
    public class ModernSystem
    {
        private readonly INewPrinter _printer;

        public ModernSystem(INewPrinter printer)
        {
            _printer = printer;
        }

        public void PrintDocument(string document)
        {
            Console.WriteLine("Подготовка документа в новой системе...");
            _printer.Print(document);
        }
    }
}
