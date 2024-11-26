using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternApp
{
    // Абстракция: Фигура
    public abstract class Shape
    {
        protected IDrawingAPI drawingAPI;

        protected Shape(IDrawingAPI drawingAPI)
        {
            this.drawingAPI = drawingAPI;
        }

        public abstract void Draw(); // Делегируем реализацию библиотеке
        public abstract void ResizeByPercentage(double percentage);
    }
}
