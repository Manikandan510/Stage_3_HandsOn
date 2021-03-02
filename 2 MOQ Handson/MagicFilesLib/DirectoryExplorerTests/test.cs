using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using MagicFilesLib;
using NUnit.Framework;
namespace DirectoryExplorerTests
{
    [TestFixture]
    public class test
    {

        Mock<IDirectoryExplorer> mock;
        
        private readonly string _file1 ="file.txt";
        private readonly string _file2 ="file2.txt";

        [OneTimeSetUp]
        public void init() 
        {
            mock = new Mock<IDirectoryExplorer>();
        }
        
        [Test]
        [TestCase("/Desktop/CTS")]
        public void tester(string path) 
        {
            List<string> files = new List<string>() { _file1,_file2};
            mock.Setup(p=>p.GetFiles(path)).Returns(files);
            var result = mock.Object.GetFiles(path);
            Assert.IsNotNull(result);
            Assert.AreEqual(2,result.Count);
            Assert.IsTrue(result.Contains(_file2));
            
        }
        
        
 
    }
}
