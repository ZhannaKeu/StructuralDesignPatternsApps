using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternApp
{
    // Конкретный декоратор: жирный текст
    public class BoldTextDecorator : TextDecorator
    {
        public BoldTextDecorator(IText text) : base(text)
        {
        }

        public override string GetContent()
        {
            return $"<b>{_text.GetContent()}</b>";
        }
    }
}
