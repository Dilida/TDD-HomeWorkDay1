using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass()]
    public class MyCalculatorTests
    {

        [TestMethod()]
        public void AddTest_arrayList()
        {
            //arrange
            var target = new MyCalculator(); //傳進欄位名稱及筆數
            var columValue1 = "Cost";
            var numberValue1 = 3;
            var columValue2 = "Revenue";
            var numberValue2 = 4;
            List<Products> Shop = GetProductsList();

            var expected1 = new int[] { 6, 15, 24, 21 };
            var expected2 = new int[] { 50, 66, 60 };

            //act
            var actual1 = target.HomeWorkSum(columValue1, numberValue1, Shop);
            var actual2 = target.HomeWorkSum(columValue2, numberValue2, Shop);

            //assert
            CollectionAssert.AreEqual(expected1, actual1);
            CollectionAssert.AreEqual(expected2, actual2);
        }

        private static List<Products> GetProductsList()
        {
            return new List<Products>
                {
                    new Products { ID = "1", Cost = 1, Revenue = 11, SellPrice = 21 },
                    new Products { ID = "2", Cost = 2, Revenue = 12, SellPrice = 22 },
                    new Products { ID = "3", Cost = 3, Revenue = 13, SellPrice = 23 },
                    new Products { ID = "4", Cost = 4, Revenue = 14, SellPrice = 24 },
                    new Products { ID = "5", Cost = 5, Revenue = 15, SellPrice = 25 },
                    new Products { ID = "6", Cost = 6, Revenue = 16, SellPrice = 26 },
                    new Products { ID = "7", Cost = 7, Revenue = 17, SellPrice = 27 },
                    new Products { ID = "8", Cost = 8, Revenue = 18, SellPrice = 28 },
                    new Products { ID = "9", Cost = 9, Revenue = 19, SellPrice = 29 },
                    new Products { ID = "10", Cost = 10, Revenue = 20, SellPrice = 30 },
                    new Products { ID = "11", Cost = 11, Revenue = 21, SellPrice = 31 }
                };
        }

        internal class Products
        {
            public string ID { get; set; }

            public int Cost { get; set; }

            public int Revenue { get; set; }

            public int SellPrice { get; set; }
        }
    }
}