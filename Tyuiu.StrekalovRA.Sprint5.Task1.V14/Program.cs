using Tyuiu.StrekalovRA.Sprint5.Task1.V14.Lib;
using System.IO;

namespace Tyuiu.StrekalovRA.Sprint5.Task1.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #5
                Тема: Класс File. Запись набора данных в текстовый файл
                Задание #1
                Вариант #14
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                F(x) = sin(x)/(x+1,7)-4xcos(x)-6 => [-5; -5]
                Выполнить табуляцию
             */
             
            int ST = -5;
            int END = 5;
            DataService DS = new DataService();
            var Res = DS.SaveToFileTextData(ST, END);

            Console.WriteLine("РЕЗУЛЬТАТ: ");
            Console.WriteLine(Res);

            Console.ReadKey();
        }
    }
}