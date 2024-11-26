using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Используем OpenGL для рисования круга
            Shape circle1 = new Circle(1, 2, 3, new OpenGLAPI());
            circle1.Draw();
            circle1.ResizeByPercentage(50); // Увеличиваем радиус на 50%
            circle1.Draw();

            Console.WriteLine();

            // Используем DirectX для рисования круга
            Shape circle2 = new Circle(5, 6, 7, new DirectXAPI());
            circle2.Draw();
            circle2.ResizeByPercentage(25); // Увеличиваем радиус на 25%
            circle2.Draw();

            Console.ReadLine();
        }
    }
}
