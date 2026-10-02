using Tyuiu.GaitovaAA.Sprint1.Task7.V27.Lib;

//Написать программу, которая вычисляет математическое выражение
//по исходным значениям данных, вводимых пользователем.
//    cosx^2 + siny^2          xy - 12
//z = ---------------   --  ---------------
//     siny + 1               15 + cosx

namespace Tyuiu.GaitovaAA.Sprint1.Task7.V27
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
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #27                                                              *");
            Console.WriteLine("* Выполнила: Гаитова А. А. | ПКТб-26-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст.Напечатать все слова,     *");
            Console.WriteLine("* удалив из них последнюю букву.                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("     cosx^2 + siny^2          xy - 12");
            Console.WriteLine("z = ---------------   --  ---------------");
            Console.WriteLine("     siny + 1               15 + cosx");

            double x, y;
            Console.WriteLine("Введите значение X: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.Calculate(x, y);

            Console.WriteLine($"Значение выражения равно: {res}");

            Console.ReadKey();
        }
    }
}
