using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPatternApp
{
    // Интерфейс Легковеса
    public interface ICharacter
    {
        void Display(int size); // Метод отображения символа с заданным размером
    }
}
