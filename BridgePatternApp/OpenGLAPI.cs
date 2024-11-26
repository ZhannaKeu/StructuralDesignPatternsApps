using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternApp
{
    // Конкретная реализация: OpenGL
    public class OpenGLAPI : IDrawingAPI
    {
        public void DrawCircle(double x, double y, double radius)
        {
            Console.WriteLine($"OpenGL рисует круг с центром ({x}, {y}) и радиусом {radius}");
        }
    }
}
