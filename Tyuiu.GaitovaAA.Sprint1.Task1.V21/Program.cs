using Tyuiu.GaitovaAA.Sprint1.Task1.V21.Lib;
//ЗАДАНИЕ
// Написать программу, которая запрашивает у пользователя исходные данные,
// вычисляет результат по формуле (x*y)/(3+y) и печатает его на экране.

namespace Tyuiu.GaitovaAA.Sprint1.Task1.V21
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
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнила: Гаитова А. А. | ПКТб-26-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные  *");
            Console.WriteLine("* вычисляет результат по формуле (x * y) / (3 + y) и печатает его на экра *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x, y;
            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            //Метод Calculate находится в библиотеке Tyuiu.GaitovaAA.Sprint1.Task1.V21.Lib
            //в классе DataService
            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadLine();
        }
    }
}