using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatterApp
{
    // Фасад: Управление умным домом
    public class SmartHomeFacade
    {
        private readonly Light _light;
        private readonly AirConditioner _airConditioner;
        private readonly MusicSystem _musicSystem;

        public SmartHomeFacade(Light light, AirConditioner airConditioner, MusicSystem musicSystem)
        {
            _light = light;
            _airConditioner = airConditioner;
            _musicSystem = musicSystem;
        }

        // Метод для настройки дома для вечеринки
        public void PrepareEvening()
        {
            Console.WriteLine("Подготовка дома для вечера...");
            _light.Dim();
            _airConditioner.TurnOn();
            _airConditioner.SetTemperature(22);
            _musicSystem.TurnOn();
            _musicSystem.PlayMusic("Relaxing Evening Playlist");
        }

        // Метод для выключения всех устройств
        public void Shutdown()
        {
            Console.WriteLine("Выключение всех устройств...");
            _light.TurnOff();
            _airConditioner.TurnOff();
            _musicSystem.TurnOff();
        }
    }
}
