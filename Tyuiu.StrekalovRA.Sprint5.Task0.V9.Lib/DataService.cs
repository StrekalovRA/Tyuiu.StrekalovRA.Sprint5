using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.StrekalovRA.Sprint5.Task0.V9.Lib
{
    public class DataService : ISprint5Task0V9
    {
        public string SaveToFileTextData(int x)
        {
            double Y = Math.Pow(x, 3) / (Math.Pow(x, 2) - 1);
            Y = Math.Round(Y, 3);

            string Cur_Path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            File.WriteAllText(Cur_Path, Convert.ToString(Y));
            return Cur_Path;
        }
    }
}
