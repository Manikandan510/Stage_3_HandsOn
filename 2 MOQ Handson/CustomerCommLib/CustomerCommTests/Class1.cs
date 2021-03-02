using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using CustomerCommLib;

namespace CustomerCommTests
{

    public class Class1
    {
        Mock<IMailSender> mock;
        CustomeComm cust;
        [OneTimeSetUp]
        public void init() 
        {
            mock = new Mock<IMailSender>();
            cust = new CustomeComm(mock.Object);
        }
        [Test]
        [TestCase("cust123@abc.com", "some message", true)]
        //[TestCase("abc@abc.com", "some message", false)]
        [TestCase("cust123@abc.com", "some message", true)]
        public void testfun(string toAddress, string message, bool e)
        {
            mock.Setup(p => p.SendMail(toAddress, message)).Returns(e);
            bool res = cust.SendMailToCustomer();
            Assert.AreEqual(e, res);
        }
    }
}
