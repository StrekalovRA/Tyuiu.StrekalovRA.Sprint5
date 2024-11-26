using Tyuiu.StrekalovRA.Sprint5.Task0.V9.Lib;
using System.IO;

namespace Tyuiu.StrekalovRA.Sprint5.Task0.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #5
                Тема: Класс File. Запись данных в текстовый файл
                Задание #0
                Вариант #9
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Дано выражение вычислить его значение при x = 3, результат сохранить в
                текстовый файл OutPutFileTask0.txt и вывести на консоль.
                Округлить до трёх знаков после запятой.
                y = (x^3)/(x^2 - 1)
             */

            int X = 3;
            DataService DS = new DataService();
            var Res = DS.SaveToFileTextData(X);

            string T = File.ReadAllText(Res);
            Console.WriteLine("РЕЗУЛЬТАТ: " + T);
            Console.WriteLine(Res);

            Console.ReadKey();
        }
    }
}