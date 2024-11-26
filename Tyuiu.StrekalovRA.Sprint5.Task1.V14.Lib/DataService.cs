using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.StrekalovRA.Sprint5.Task1.V14.Lib
{
    public class DataService : ISprint5Task1V14
    {
        public string SaveToFileTextData(int ST, int END)
        {
            string T_Path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt" );
            FileInfo F = new FileInfo(T_Path);
            if (F.Exists) { File.Delete(T_Path); }

            double Y = 0;
            string Str_Y = "";

            for (int X = ST; X <= END; X += 1)
            {
                Y = (Math.Sin(X) / (X + 1.7)) - (Math.Cos(X) * 4 * X) - 6;
                Y = Math.Round(Y, 2);
                Str_Y += Y;

                if (X != END) {  Str_Y += "\n"; }
            }

            File.WriteAllText(T_Path, Str_Y);
            return Str_Y;

        }
    }
}
