using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using GeometricLayoutTriangle.BusinessLogic;
using GeometricLayoutTriangle.BusinessLogic.Classes;
using GeometricLayoutTriangle.Controllers;
using GeometricLayoutTriangle.Domain;

namespace GeometricLayoutTriangleTests.Controllers
{
    [TestClass]
    public class TriangleCalculatorTests
    {
        private TriangleCalculator _sut;

        [TestInitialize]
        public void InitializeTest()
        {
            _sut = new TriangleCalculator();
        }

        [TestMethod]
        public void CalculateTriangleTest()
        {
            foreach (var test in TriangleTestCases.Tests)
            {
                var triangle = _sut.CalculateTriangle(test.Row, test.Column);
                var expectedJson = JsonConvert.SerializeObject(test.ExpectedResult);
                var actualJson = JsonConvert.SerializeObject(triangle);
                Assert.IsTrue(expectedJson == actualJson, $" For {test.Row}{test.Column} Expected: {expectedJson}, Actual: {actualJson}");
            }
        }
    }

    public class TestTriangle
    {
        public int Column; 
        public string Row;

        public Triangle ExpectedResult;
    }
}