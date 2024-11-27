using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;

namespace Tyuiu.StrekalovRA.Sprint5.Task4.V25.Lib
{
    public class DataService : ISprint5Task4V25
    {
        public double LoadFromDataFile (string path)
        {
            string Num_File = File.ReadAllText(path);
            Num_File = Num_File.Replace(".", ",");
            double Y = 0;
            var X = Convert.ToDouble(Num_File);

            Y = (Math.Pow(X, 4) + Math.Cos(X)) * Math.Sin(X);
            Y = Math.Round(Y, 3);
            return Y;
        }
    }
}
