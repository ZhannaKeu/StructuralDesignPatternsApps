using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FlyweightPatternApp
{
    // Фабрика Легковесов
    public class CharacterFactory
    {
        private readonly Dictionary<char, ICharacter> _characters = new Dictionary<char, ICharacter>();

        public ICharacter GetCharacter(char symbol)
        {
            if (!_characters.ContainsKey(symbol))
            {
                _characters[symbol] = new Character(symbol);
                Console.WriteLine($"Создан новый объект для символа: {symbol}");
            }
            else
            {
                Console.WriteLine($"Повторное использование объекта для символа: {symbol}");
            }

            return _characters[symbol];
        }
    }
}
