using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFoodSupply;
using NUnit.Framework;
namespace MyFoodSupplyTests
{
    [TestFixture]
    public class Tests
    {
        Program p;
        FoodDetail fooditem;
        [SetUp]
        public void SetUp()
        {
            p = new Program();
            fooditem = p.CreateFoodDetail("Curd Rice", 10, DateTime.Parse("2022/01/02"), 100.00);
        }

        [Test]
        [TestCase("Curd Rice", 10, "2022/01/02", 100.00)]
        public void FoodDetail_ValidInputs_ObjectCreated(string name, int dishType, string expiryDate, double price)
        {
            var food = p.CreateFoodDetail(name, dishType, DateTime.Parse(expiryDate), price);
            Assert.That(food, Is.TypeOf<FoodDetail>());
        }


        [Test]
        [TestCase("", 10, "2022/01/02", 100.00)]
        [TestCase(null, 30, "2023/01/02", 80.00)]
        public void FoodDetail_EmptyName_Exception(string name, int dishType, string expiryDate, double price)
        {
            var ex = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, DateTime.Parse(expiryDate), price));
            Assert.AreEqual("Dish name cannot be empty. Please provide valid value", ex.Message);
        }


        [Test]

        [TestCase("Curd Rice", 30, "2023/01/02", -120.00)]
        public void FoodDetail_PriceInvalidInput_Exception(string name, int dishType, string expiryDate, double price)
        {
            var ex = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, DateTime.Parse(expiryDate), price));
            Assert.AreEqual("Incorrect value for dish price. Please provide valid value", ex.Message);
        }



        [Test]
        [TestCase("Curd Rice", 10, "2020/01/02", 100.00)]
        public void FoodDetail_DateInvalidInput_Exception(string name, int dishType, string expiryDate, double price)
        {
            var ex = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, DateTime.Parse(expiryDate), price));
            Assert.AreEqual("Incorrect expiry date. Please provide valid value", ex.Message);
        }


        [Test]
        [TestCase(3, "2021/10/01", "FoodQuest", 100.00)]
        public void SupplyDetail_ValidInput_ObjectCreated(int foodItemCount, String requestDate, string sellerName, double packingCharge)
        {
            var supplyDetail = p.CreateSupplyDetail(foodItemCount, DateTime.Parse(requestDate), sellerName, packingCharge, fooditem);
            Assert.That(supplyDetail, Is.TypeOf<SupplyDetail>());
        }


        [Test]
        [TestCase(-1, "2021/10/01", "FoodQuest", 100.00)]
        public void SupplyDetail_CountInvalid_Exception(int foodItemCount, String requestDate, string sellerName, double packingCharge)
        {
            var ex = Assert.Throws<Exception>(() => p.CreateSupplyDetail(foodItemCount, DateTime.Parse(requestDate), sellerName, packingCharge, fooditem));
            Assert.AreEqual("Incorrect food item count. Please check", ex.Message);
        }


        [Test]
        [TestCase(5, "2018/10/01", "FoodQuest", 140.00)]
        public void SupplyDetail_DateInvalid_Exception(int foodItemCount, String requestDate, string sellerName, double packingCharge)
        {
            var ex = Assert.Throws<Exception>(() => p.CreateSupplyDetail(foodItemCount, DateTime.Parse(requestDate), sellerName, packingCharge, fooditem));
            Assert.AreEqual("Incorrect food request date. Please provide valid value", ex.Message);
        }


        [Test]
        [TestCase(3, "2022/10/01", "FoodQuest", 100.00)]
        public void SupplyDetail_ObjectNull_Null(int foodItemCount, String requestDate, string sellerName, double packingCharge)
        {
            fooditem = null;
            var supply = p.CreateSupplyDetail(foodItemCount, DateTime.Parse(requestDate), sellerName, packingCharge, fooditem);
            Assert.AreEqual(null, supply);
        }

        [TearDown]
        public void CleanUp()
        {
            fooditem = null;
        }

    }
}
