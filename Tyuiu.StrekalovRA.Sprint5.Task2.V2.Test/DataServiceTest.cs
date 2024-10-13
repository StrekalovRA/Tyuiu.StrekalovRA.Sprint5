namespace Tyuiu.StrekalovRA.Sprint5.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string Path = @"T:\Big ProgramZ\VS_ProjectZ\Sprint5\Tyuiu.StrekalovRA.Sprint5." +
                @$"Task2.V2\bin\Debug\net8.0\OutPutFileTask2.csv";
            Console.WriteLine(Path);

            FileInfo FI = new FileInfo(Path);
            bool A = FI.Exists;
            Assert.AreEqual(true, A);
        }
    }
}