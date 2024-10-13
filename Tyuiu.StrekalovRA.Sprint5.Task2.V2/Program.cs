using Tyuiu.StrekalovRA.Sprint5.Task2.V2.Lib;
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
                Тема: Класс File. Запись структурированных данных в текстовый файл
                Задание #2
                Вариант #2
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Дан двумерный целочисленный массив 3 на 3 элементов, заполненный значениями
                с клавиатуры. Заменить положительные элементы массива на 1, отрицательные на 0.
                Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.
                -7; 7; 5
                4; 2; -7
                2; 6; -4
             */

            DataService DS = new DataService();
            var T = DS.SaveToFileTextData(new int[3, 3] { { -7, 7, 5 }, { 4, 2, -7 }, { 2, 6, -4 } });
            Console.WriteLine("РЕЗУЛЬТАТ: ");
            Console.WriteLine(T);
        }
    }
}