﻿using Tyuiu.StrekalovRA.Sprint5.Task7.V2.Lib;
using System.IO;

namespace Tyuiu.StrekalovRA.Sprint5.Task5.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #5
                Тема: Потоковый метод записи данных в бинарный файл
                Задание #7
                Вариант #11
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Произвдение всех нечет чисел
             */

            //string A_Path = $@"{Directory.GetCurrentDirectory()}\InPutFileTask4.txt";
            // T:\Big ProgramZ\VS_ProjectZ\Sprint5\DataSprint5\InPutDataFileTask7V2.txt
            string A_Path = Console.ReadLine();
            //string A_Path = "r";

            DataService DS = new DataService();
            var T = DS.LoadDataAndSave(A_Path);

            Console.WriteLine("РЕЗУЛЬТАТ: " + T);
            Console.ReadKey();
        }
    }
}