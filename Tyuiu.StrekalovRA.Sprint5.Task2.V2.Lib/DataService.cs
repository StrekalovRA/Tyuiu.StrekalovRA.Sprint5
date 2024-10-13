using tyuiu.cources.programming.interfaces.Sprint5;
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

            string Path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask2.csv";
            File.WriteAllText(Path, Matrix);
            return Path;
        }
    }
}
