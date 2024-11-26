using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatternApp
{
    //Пример: Виртуальный Proxy для загрузки больших данных

    //Представим, что у нас есть класс, который загружает и обрабатывает большие данные.
    //    Для оптимизации работы мы используем заместителя, который откладывает фактическую загрузку данных до момента, 
    //    когда это действительно необходимо.

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создаем прокси объект...");
            IData data = new DataProxy();

            Console.WriteLine("\nВызываем DisplayData() в первый раз:");
            data.DisplayData();

            Console.WriteLine("\nВызываем DisplayData() во второй раз:");
            data.DisplayData();
        }
    }
}
