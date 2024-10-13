using Tyuiu.StrekalovRA.Sprint5.Task3.V25.Lib;
using System.IO;

namespace Tyuiu.StrekalovRA.Sprint5.Task3.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #5
                Тема: Потоковый метод записи данных в бинарный файл
                Задание #3
                Вариант #25
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Дано выражение вычислить его значение при x = 3, результат сохранить в
                бинарный файл OutPutFileTask3.bin и вывести на консоль. Округлить до трёх знаков после запятой.
                F(x) = (3x^4+1)/x^3
             */

            DataService DS = new DataService();
            var T = DS.SaveToFileTextData(3);
            Console.WriteLine("РЕЗУЛЬТАТ: " + T);

            var Res = File.ReadAllText(T);
            Console.WriteLine(Res);
        }
    }
}