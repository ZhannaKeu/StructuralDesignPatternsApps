using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternApp
{
    // Старый интерфейс принтера
    public interface IOldPrinter
    {
        void PrintDocument(string text);
    }
}
