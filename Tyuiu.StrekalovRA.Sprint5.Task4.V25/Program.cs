using Tyuiu.StrekalovRA.Sprint5.Task4.V25.Lib;
using System.IO;

namespace Tyuiu.StrekalovRA.Sprint5.Task4.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #5
                Тема: Потоковый метод записи данных в бинарный файл
                Задание #4
                Вариант #25
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Файл -> X -> рез. в консоль
                F(x) = (x^4 + cos(x))sin(x)
             */

            //string A_Path = $@"{Directory.GetCurrentDirectory()}\InPutFileTask4.txt";
            //A_Path = @"T:\Big ProgramZ\VS_ProjectZ\Sprint5\DataSprint5\InPutDataFileTask4V25.txt";
            string A_Path = Console.ReadLine();

            DataService DS = new DataService();
            var T = DS.LoadFromDataFile(A_Path);

            Console.WriteLine("РЕЗУЛЬТАТ: " + T);
            Console.ReadKey();
        }
    }
}