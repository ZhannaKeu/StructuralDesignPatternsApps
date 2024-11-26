using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatternApp
{
    // Заместитель (Proxy), откладывающий создание реального объекта
    public class DataProxy : IData
    {
        private RealData _realData;

        public void DisplayData()
        {
            // Создаем реальный объект только при первом обращении
            if (_realData == null)
            {
                Console.WriteLine("Инициализация реальных данных...");
                _realData = new RealData();
            }
            _realData.DisplayData();
        }
    }
}
