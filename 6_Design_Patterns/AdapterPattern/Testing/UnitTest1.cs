using NUnit.Framework;
using AdapterPattern;
namespace Testing
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WHenConvertingMPHtoKMPH_Success()
        {
            Movable bugatti = new BugattiVeyron();
            MovableAdapter movableAdapter = new MovableAdapterImpl(bugatti);
            Assert.AreEqual(movableAdapter.GetSpeed(),431.30312);
        }
        [Test]
        public void WHenConvertingUSDtoEURO_Success()
        {
            BugattiVeyron bugatti = new BugattiVeyron();
            PriceAdapterImpl movableAdapter = new PriceAdapterImpl(bugatti);
            Assert.AreEqual(movableAdapter.GetPrice(), 84);
        }

    }
}