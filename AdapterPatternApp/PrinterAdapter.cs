using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternApp
{
    // Адаптер, который делает старый принтер совместимым с новой системой
    public class PrinterAdapter : INewPrinter
    {
        private readonly IOldPrinter _oldPrinter;

        public PrinterAdapter(IOldPrinter oldPrinter)
        {
            _oldPrinter = oldPrinter;
        }

        public void Print(string document)
        {
            // Адаптируем вызов метода
            _oldPrinter.PrintDocument(document);
        }
    }
}
