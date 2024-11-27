using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;

namespace Tyuiu.StrekalovRA.Sprint5.Task7.V2.Lib
{
    public class DataService : ISprint5Task7V2
    {
        public string LoadDataAndSave(string path)
        {
            string Text = File.ReadAllText(path);
            string New_ = "";

            foreach ( char I in Text)
            {
                if (char.IsDigit(I))
                {
                    New_ += "#";
                }
                else
                {
                    New_ += I;
                }
            }

            string R_Path = Path.Combine(Path.GetTempPath(), New_);
            File.WriteAllText(R_Path, New_);
            return R_Path;
        }
    }
}

