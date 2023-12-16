using NUnit.Framework;

namespace TestApp.Tests
{
    [TestFixture]
    public class CsvParserTests
    {
        [Test]
        public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray()
        {
            // Arrange
            string csvData = "";

            // Act
            string[] result = CsvParser.ParseCsv(csvData);

            // Assert
            Assert.IsEmpty(result);
        }

        [Test]
        public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
        {
            // Arrange
            string csvData = "value1";

            // Act
            string[] result = CsvParser.ParseCsv(csvData);

            // Assert
            Assert.AreEqual(1, result.Length);
            Assert.AreEqual("value1", result[0]);
        }

        [Test]
        public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
        {
            // Arrange
            string csvData = "value1,value2,value3";

            // Act
            string[] result = CsvParser.ParseCsv(csvData);

            // Assert
            Assert.AreEqual(3, result.Length);
            Assert.AreEqual("value1", result[0]);
            Assert.AreEqual("value2", result[1]);
            Assert.AreEqual("value3", result[2]);
        }

        [Test]
        public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
        {
            // Arrange
            string csvData = "  value1  ,  value2  ,  value3  ";

            // Act
            string[] result = CsvParser.ParseCsv(csvData);

            // Assert
            Assert.AreEqual(3, result.Length);
            Assert.AreEqual("value1", result[0]);
            Assert.AreEqual("value2", result[1]);
            Assert.AreEqual("value3", result[2]);
        }
    }
}
