using Boolean.CSharp.Main;
using NUnit.Framework;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        private Core _core;

        public CoreTests()
        {
            _core = new Core();

        }

        [Test]
        public void TestQuestion1()
        {
            
            Assert.IsTrue(_core.Question1().Make!=string.Empty);
            Assert.IsTrue(_core.Question1().Model != string.Empty);
        }
        [Test]
        public void TestQuestion2()
        {

            Assert.IsTrue(_core.Question2());

        }
        [Test]
        public void TestQuestion3()
        {

            Assert.IsTrue(_core.Question3().WheelCount>0);

        }
        [Test]
        public void TestQuestion4()
        {

            Assert.IsTrue(_core.Question4().NameOfUnicyclist.Length>0);

        }
        [Test]
        public void TestQuestion5()
        {

            Assert.IsTrue(_core.Question5().IsFlightCancelled);
            Assert.IsTrue(_core.Question5().FlightDetails() != "##LHR##JFK##");
        }
    }
}