namespace SeleniumLearning
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            TestContext.Progress.WriteLine("Setup method execution");
        }

        [Test]
        public void Test1()
        {
            TestContext.Progress.WriteLine("THis is test 1");
        }

        [Test]
        public void Test2()
        {
            TestContext.Progress.WriteLine("THis is test 2");
        }

        [TearDown] 
        public void TearDown() 
        {
            TestContext.Progress.WriteLine("Tear Down Method ");
        }
    }
}