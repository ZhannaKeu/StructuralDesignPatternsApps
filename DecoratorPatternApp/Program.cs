using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Базовый текст
            IText simpleText = new PlainText("Привет, мир!");

            // Применяем декораторы
            IText boldText = new BoldTextDecorator(simpleText);
            IText italicBoldText = new ItalicTextDecorator(boldText);
            IText decoratedText = new UnderlineTextDecorator(italicBoldText);

            // Выводим результат
            Console.WriteLine("Обычный текст: " + simpleText.GetContent());
            Console.WriteLine("Жирный текст: " + boldText.GetContent());
            Console.WriteLine("Жирный и курсивный текст: " + italicBoldText.GetContent());
            Console.WriteLine("Жирный, курсивный и подчеркнутый текст: " + decoratedText.GetContent());

        }
    }
}
