using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternApp
{
    // Конкретный компонент: обычный текст
    public class PlainText : IText
    {
        private readonly string _content;

        public PlainText(string content)
        {
            _content = content;
        }

        public string GetContent()
        {
            return _content;
        }
    }
}
