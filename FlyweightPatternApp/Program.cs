using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPatternApp
{
    //Пример: Текстовый редактор с символами

    //Представим, что мы разрабатываем текстовый редактор.Каждая буква текста может быть представлена как объект.
    //    Вместо создания отдельных объектов для каждого символа, мы можем хранить объекты букв в кэше и повторно 
    //    их использовать.

    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = new CharacterFactory();

            // Создаем текст из символов
            var text = "hello world";

            foreach (var symbol in text)
            {
                var character = factory.GetCharacter(symbol);
                character.Display(12); // Отображаем символ с размером 12
            }

            Console.WriteLine();

            // Повторно используем символы
            foreach (var symbol in "hello again")
            {
                var character = factory.GetCharacter(symbol);
                character.Display(14); // Отображаем символ с размером 14
            }
        }
    }
}
