using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;

namespace Lemonadeunit_t3st
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testgetlemons()
        {
            //Arrange
            Recipe recipe = new Recipe();
            double actualResult;
            double expectedResult = 8;
            //Act
            recipe.getNumLemForRecipe();
            actualResult = recipe.numbLemons;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TesthowMuchLeftAfterPurchaseLemons(Player playerOne)
        {
            //Arrange
            Store store = new Store(playerOne);
            public int actualResult;
            //Act
            actualResult = store.balanceAfterIce;
            //Assert

        }

    }
}