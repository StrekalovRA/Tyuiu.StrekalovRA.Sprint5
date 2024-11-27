using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;

namespace Tyuiu.StrekalovRA.Sprint5.Task5.V11.Lib
{
    public class DataService : ISprint5Task6V11
    {
        public int LoadFromDataFile(string path)
        {
            string Text = File.ReadAllText(path);
            int res = 1;
            Text = Text.Replace("\n", " ");
            Console.WriteLine(Text);

            foreach (var I in Text.Split(" ")) { 
                if (I.Length == 6)
                {
                    res += 1;
                }
            }
            return res;
        }
    }
}

