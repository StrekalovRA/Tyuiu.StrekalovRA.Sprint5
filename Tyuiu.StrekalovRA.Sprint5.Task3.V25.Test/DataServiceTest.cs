namespace Tyuiu.StrekalovRA.Sprint5.Task3.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string Path = @"T:\Big ProgramZ\VS_ProjectZ\Sprint5\Tyuiu.StrekalovRA.Sprint5." +
                @$"Task3.V25\bin\Debug\net8.0\OutPutFileTask3.bin";
            Console.WriteLine(Path);

            FileInfo FI = new FileInfo(Path);
            bool A = FI.Exists;
            Assert.AreEqual(true, A);
        }
    }
}