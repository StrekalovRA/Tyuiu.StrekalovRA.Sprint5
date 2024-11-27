using Tyuiu.StrekalovRA.Sprint5.Task7.V2.Lib;

namespace Tyuiu.StrekalovRA.Sprint5.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //string P = @"C:\Users\TiSorrow\AppData\Local\Temp\OutPutFileTask7.txt";
            string P = Path.Combine(Path.GetTempPath(), "OutPutFileTask7.txt");

            FileInfo FF = new FileInfo(P);
            bool R_ = FF.Exists;
            Assert.AreEqual(R_, true);
        }
    }
}