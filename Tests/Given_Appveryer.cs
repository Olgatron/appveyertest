using NUnit.Framework;

namespace Tests
{
	[TestFixture]
    public class Given_Appveryer
    {
		[Test]
		public void HelloWorldTest()
		{
			Assert.AreEqual("Hello World","Hello World");
		}

		[Test]
		public void HelloWorldTest2()
		{
			Assert.AreEqual("Hello World", "Hello World");
		}
    }
}
