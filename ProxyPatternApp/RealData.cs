using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatternApp
{
    // Реальный объект, выполняющий тяжелую операцию
    public class RealData : IData
    {
        private string _data;

        public RealData()
        {
            Console.WriteLine("Загрузка больших данных...");
            _data = "Очень большие данные, загруженные из ресурсоёмкой операции.";
        }

        public void DisplayData()
        {
            Console.WriteLine($"Данные: {_data}");
        }
    }
}
