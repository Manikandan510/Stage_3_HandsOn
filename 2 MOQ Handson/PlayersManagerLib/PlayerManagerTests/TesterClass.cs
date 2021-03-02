using System;
using Moq;
using NUnit.Framework;
using PlayersManagerLib;


namespace PlayerManagerTests
{
    [TestFixture]
    public class TesterClass
    {
        Mock<IPlayerMapper> mock;
        [OneTimeSetUp]
        public void init() 
        {
            mock = new Mock<IPlayerMapper>();
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        [TestCase("Mani")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void AlreadyInDb(string name)
        {   
            mock.Setup(x => x.IsPlayerNameExistsInDb(name)).Returns(true);
            Player player = Player.RegisterNewPlayer(name, mock.Object);
        }
        [Test]
        [TestCase("Test","India")]
        public void NotInDb(string name,string country)
        {   
            mock.Setup(x => x.IsPlayerNameExistsInDb(name)).Returns(false);
            Player player = Player.RegisterNewPlayer(name, mock.Object);
            Assert.AreEqual(name, player.Name);
            Assert.AreEqual(23, player.Age);
            Assert.AreEqual(country, player.Country);
            Assert.AreEqual(30, player.NoOfMatches);
        }
    }
}