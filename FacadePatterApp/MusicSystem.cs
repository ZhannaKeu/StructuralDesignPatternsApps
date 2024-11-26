using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatterApp
{
    // Подсистема: Музыкальная система
    public class MusicSystem
    {
        public void TurnOn()
        {
            Console.WriteLine("Музыкальная система включена.");
        }

        public void PlayMusic(string song)
        {
            Console.WriteLine($"Играет музыка: {song}");
        }

        public void TurnOff()
        {
            Console.WriteLine("Музыкальная система выключена.");
        }
    }
}
