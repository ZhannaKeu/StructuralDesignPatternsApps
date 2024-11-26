using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatterApp
{
    // Подсистема: Освещение
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Освещение включено.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Освещение выключено.");
        }

        public void Dim()
        {
            Console.WriteLine("Освещение приглушено.");
        }
    }
}
