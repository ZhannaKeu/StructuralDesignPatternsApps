using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatterApp
{
    // Подсистема: Кондиционер
    public class AirConditioner
    {
        public void TurnOn()
        {
            Console.WriteLine("Кондиционер включен.");
        }

        public void SetTemperature(int temperature)
        {
            Console.WriteLine($"Температура кондиционера установлена на {temperature}°C.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Кондиционер выключен.");
        }
    }
}
