using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternApp
{
    // Новый интерфейс для работы с принтерами
    public interface INewPrinter
    {
        void Print(string document);
    }

}
