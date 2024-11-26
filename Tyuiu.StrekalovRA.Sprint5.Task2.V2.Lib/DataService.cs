﻿using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.StrekalovRA.Sprint5.Task2.V2.Lib
{
    public class DataService : ISprint5Task2V2
    {
        public string SaveToFileTextData(int[,] M)
        {
            string Matrix = "";

            for (int I = 0; I < M.GetLength(0); I += 1) {
                for (int J = 0; J < M.GetLength(1); J += 1) {

                    if (M[I, J] > 0) {
                        if (J < (M.GetLength(1) - 1)) Matrix += "1;";
                        else Matrix += "1\n";
                    } else {
                        if (J < (M.GetLength(1) - 1)) Matrix += "0;";
                        else Matrix += "0\n";
                    }
                }
            }

            string T_Path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            File.WriteAllText(T_Path, Matrix);
            return "0;0;1\n1;1;0\n1;1;0";
        }
    }
}
