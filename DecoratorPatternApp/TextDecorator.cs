using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternApp
{
    // Абстрактный декоратор
    public abstract class TextDecorator : IText
    {
        protected readonly IText _text;

        protected TextDecorator(IText text)
        {
            _text = text;
        }

        public abstract string GetContent();
    }
}
