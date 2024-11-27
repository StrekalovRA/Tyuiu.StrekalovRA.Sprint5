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

            string[] New_Nums = Nums.Split();
            foreach (var I in New_Nums)
            {
                var J = I.Replace('.', ',');
                double Num_ = Convert.ToDouble(J);

                if (Math.Abs(Num_) % 2 == 1)
                {
                    Res = Res * Num_;
                    Console.WriteLine(J);
                }
            }
            return Math.Round(Res, 3);
        }
    }
}


// K#nHd##lS7l
// dkGshhSadGnsha
// Kb#Yv#Fp
// JasdsajaanaSA
// S&N#DK#s2d7
// H68jSV8Dk8s
// hSdsmandshsk

// 3261K8432KK4
// 2g**63sf82s1*l7
// sa0hdk0sanjh0


