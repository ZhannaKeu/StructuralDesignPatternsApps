using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatterApp
{
    //Пример: Умный дом

    //Представим, что у нас есть система умного дома с различными устройствами, такими как освещение, 
    //    кондиционер, музыкальная система и т.д.Клиенту нужен простой способ управления этими устройствами, 
    //    например, с помощью команды "Подготовь дом для вечера".
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем подсистемы
            var light = new Light();
            var airConditioner = new AirConditioner();
            var musicSystem = new MusicSystem();

            // Создаем фасад
            var smartHome = new SmartHomeFacade(light, airConditioner, musicSystem);

            // Используем фасад
            smartHome.PrepareEvening(); // Подготовка дома для вечера
            Console.WriteLine();

            smartHome.Shutdown(); // Выключение всех устройств
        }
    }
}
