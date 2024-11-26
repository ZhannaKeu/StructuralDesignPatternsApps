using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternApp
{
    // Интерфейс для реализации (графические библиотеки)
    public interface IDrawingAPI
    {
        void DrawCircle(double x, double y, double radius);
    }
}
