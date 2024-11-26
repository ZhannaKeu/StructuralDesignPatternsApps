using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternApp
{
    // Конкретная реализация: DirectX
    public class DirectXAPI : IDrawingAPI
    {
        public void DrawCircle(double x, double y, double radius)
        {
            Console.WriteLine($"DirectX рисует круг с центром ({x}, {y}) и радиусом {radius}");
        }
    }
}
