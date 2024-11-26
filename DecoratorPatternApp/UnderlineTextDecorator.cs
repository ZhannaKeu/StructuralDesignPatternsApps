using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternApp
{
    // Конкретный декоратор: подчеркнутый текст
    public class UnderlineTextDecorator : TextDecorator
    {
        public UnderlineTextDecorator(IText text) : base(text)
        {
        }

        public override string GetContent()
        {
            return $"<u>{_text.GetContent()}</u>";
        }
    }
}
