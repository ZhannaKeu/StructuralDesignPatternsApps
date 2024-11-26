using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternApp
{
    // Конкретная абстракция: Круг
    public class Circle : Shape
    {
        private double x, y, radius;

        public Circle(double x, double y, double radius, IDrawingAPI drawingAPI)
            : base(drawingAPI)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void Draw()
        {
            drawingAPI.DrawCircle(x, y, radius);
        }

        public override void ResizeByPercentage(double percentage)
        {
            radius *= (1 + percentage / 100.0);
        }
    }
}
