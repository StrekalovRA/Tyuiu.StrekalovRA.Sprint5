using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;

namespace Tyuiu.StrekalovRA.Sprint5.Task5.V11.Lib
{
    public class DataService : ISprint5Task5V11
    {
        public double LoadFromDataFile(string path)
        {
            string Nums = File.ReadAllText(path);
            double Res = 1;

            string[] New_Nums = Nums.Split("\n");
            foreach (var I in New_Nums)
            {
                double Num_ = Convert.ToDouble(I);

                if (Math.Abs(Num_) % 2 == 1)
                {
                    Res = Res * Num_;
                    Console.WriteLine(I);
                }
            }
            return Math.Round(Res, 3);
        }
    }
}

