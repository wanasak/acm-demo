using System;
using ACM.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTest()
        {
            // Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            // Act
            var actual = source.InsertSpaces();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesTestExistSpace()
        {
            // Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            // Act
            var actual = source.InsertSpaces();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
