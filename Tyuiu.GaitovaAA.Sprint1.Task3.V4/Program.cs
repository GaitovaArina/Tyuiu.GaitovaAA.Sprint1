using Tyuiu.GaitovaAA.Sprint1.Task3.V4.Lib;

//ЗАДАНИЕ
//Написать программу, которая запрашивает у пользователя исходные данные,
//выполняет указанные расчёты и печатает результат на экране.
//Расчеты: Вычисление стоимости покупки, состоящей из нескольких тетрадей и такого же количества обложек к ним

namespace Tyuiu.GaitovaAA.Sprint1.Task3.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Гаитова А. А. | ПКТб-26-1";
            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнила: Гаитова А. А. | ПКТб-26-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные  *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double priceNotebook;
            Console.WriteLine("Введите цену тетради (руб.): ");
            priceNotebook = Convert.ToDouble(Console.ReadLine());

            double priceCover;
            Console.WriteLine("Введите цену обложки (руб.): ");
            priceCover = Convert.ToDouble(Console.ReadLine());

            int amount;
            Console.WriteLine("Введите количество комплектов (шт.): ");
            amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Стоимость покупки = " + ds.PurchaseAmount(priceNotebook, priceCover, amount) + " руб. ");

            Console.ReadKey();
        }
    }
}