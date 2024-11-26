using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPatternApp
{
    // Конкретный Легковес: Буква
    public class Character : ICharacter
    {
        private readonly char _symbol; // Инвариантная часть (неизменяемая)

        public Character(char symbol)
        {
            _symbol = symbol;
        }

        public void Display(int size)
        {
            Console.WriteLine($"Символ: {_symbol}, размер: {size}");
        }
    }
}
