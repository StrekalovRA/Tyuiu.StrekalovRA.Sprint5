namespace Tyuiu.StrekalovRA.Sprint5.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string Path = @"T:\Big ProgramZ\VS_ProjectZ\Sprint5\Tyuiu.StrekalovRA.Sprint5.Task0.V9\bin\Debug\net8.0\OutPutFileTask0.txt";

            FileInfo FI = new FileInfo(Path);
            bool A = FI.Exists;
            Assert.AreEqual (true, A);
        }
    }
}