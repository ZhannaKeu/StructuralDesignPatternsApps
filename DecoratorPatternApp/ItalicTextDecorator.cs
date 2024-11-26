using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternApp
{
    // Конкретный декоратор: курсивный текст
    public class ItalicTextDecorator : TextDecorator
    {
        public ItalicTextDecorator(IText text) : base(text)
        {
        }

        public override string GetContent()
        {
            return $"<i>{_text.GetContent()}</i>";
        }
    }
}
