using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using GenericMedicine;
namespace GenericMedicineTests
{
    [TestFixture]
    public class Tests
    {
        Program p;
        Medicine medicine_carton;
        [OneTimeSetUp]
        public void SetUp()
        {
            p = new Program();
            medicine_carton = p.CreateMedicineDetail("Dolo 650", "Paracetamol", "Something", DateTime.Parse("2022/01/01"), 100.00);
        }

        [Test]
        [TestCase("Dolo 650", "Paracetamol", "Something","2022/01/02",100.00)]
        public void Medicine_ValidINputs_ObjectCreated(string name, string genericMedicineName, string composition, string expiryDate, double pricePerStrip)
        {
            Medicine medicine = p.CreateMedicineDetail(name, genericMedicineName, composition, DateTime.Parse(expiryDate), pricePerStrip);
            Assert.That(medicine, Is.TypeOf<Medicine>());
        }


        [Test]
        [TestCase("Dolo 650", "", "Something", "2022 /01/02", 100.00)]
        public void Medicine_EmptyGenericMedicineName_Exception(string name,string genericMedicineName, string composition, string expiryDate, double pricePerStrip)
        {
            var ex = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, DateTime.Parse(expiryDate), pricePerStrip));
            Assert.That(ex.Message, Is.EqualTo("Generic Medicine name cannot be empty. Please provide valid value"));
            
        }


        [Test]
        [TestCase("Dolo 650", "Paracetamol", "Something", "2022/01/02", 0)]
        public void Medicine_PriceInValidInputs_Exception(string name, string genericMedicineName, string composition, string expiryDate, double pricePerStrip)
        {
            var ex = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, DateTime.Parse(expiryDate), pricePerStrip));
            Assert.That(ex.Message, Is.EqualTo("Incorrect value for Medicine price per strip. Please provide valid value"));
        }


        [Test]
        [TestCase("Dolo 650", "Paracetamol", "Something", "2020/01/02", 100.00)]
        public void Medicine_DateInValidINputs_Exception(string name, string genericMedicineName, string composition, string expiryDate, double pricePerStrip)
        {
            var ex = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, DateTime.Parse(expiryDate), pricePerStrip));
            Assert.That(ex.Message, Is.EqualTo("Incorrect expiry date. Please provide valid value"));
        }



        [Test]
        [TestCase(10,"2021/10/01","Chennai")]
        public void Carton_ValidInput_ObjectCreated(int medicineStripCount, string launchDate, string retailerAddress)
        {
            CartonDetail carton = p.CreateCartonDetail(medicineStripCount, DateTime.Parse(launchDate), retailerAddress, medicine_carton);
            Assert.That(carton, Is.TypeOf<CartonDetail>());
        }



        [Test]
        [TestCase(-5, "2021/10/01", "Bangalore")]
        [TestCase(null, "2021/10/01", "Hyderabad")]
        public void Carton_StripCountInvalid_Exception(int medicineStripCount, string launchDate, string retailerAddress)
        {
            var ex = Assert.Throws<Exception>(() => p.CreateCartonDetail(medicineStripCount, DateTime.Parse(launchDate), retailerAddress, medicine_carton));
            Assert.That(ex.Message, Is.EqualTo("Incorrect strip count. Please check"));
        }



        [Test]
        [TestCase(10, "2020/10/01", "Chennai")]
        public void Carton_DateInValid_Exception(int medicineStripCount, string launchDate, string retailerAddress)
        {
       
            var ex = Assert.Throws<Exception>(() => p.CreateCartonDetail(medicineStripCount, DateTime.Parse(launchDate), retailerAddress, medicine_carton));
            Assert.That(ex.Message, Is.EqualTo("Incorrect launch date. Please provide valid value"));
        }



        [Test]
        [TestCase(10, "2022/10/01", "Chennai")]
        public void Carton_MedicineObjectNull_Test(int medicineStripCount, string launchDate, string retailerAddress)
        {
            Medicine medicine_carton = null;
            CartonDetail carton= p.CreateCartonDetail(medicineStripCount, DateTime.Parse(launchDate), retailerAddress, medicine_carton);
            Assert.That(carton, Is.EqualTo(null));
        }

   
    }
}
