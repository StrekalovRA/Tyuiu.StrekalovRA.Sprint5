using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;

namespace Tyuiu.StrekalovRA.Sprint5.Task3.V25.Lib
{
    public class DataService : ISprint5Task3V25
    {
        public string SaveToFileTextData(int X)
        {
            string R_Path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            double Y = (3 * Math.Pow(X, 4) + 1) / Math.Pow(X, 3);
            Y = Math.Round(Y, 3);
            string Y_ = Convert.ToString(Y);

            using (BinaryWriter A = new BinaryWriter(File.Open(R_Path, FileMode.OpenOrCreate), Encoding.Unicode))
            {
                A.Write(BitConverter.GetBytes(Y));
            } // Что это такое... ☠☠☠

            //File.WriteAllText(Path, Y_);
            return R_Path;
        }
    }
}
