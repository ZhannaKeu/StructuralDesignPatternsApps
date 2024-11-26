using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternApp
{
    // Интерфейс, который будет реализован как базовым объектом, так и декораторами
    public interface IText
    {
        string GetContent();
    }
}
