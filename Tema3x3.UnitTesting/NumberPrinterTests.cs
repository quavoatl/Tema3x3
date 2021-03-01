using Moq;
using NUnit.Framework;
using Tema3x3.BaseComponents;
using Tema3x3.PrinterService;

namespace Tema3x3.UnitTesting
{
    public class NumberPrinterTests
    {

        #region Tests
        
        [Test]
        public void Verify_Bad_Input_12s()
        {
            var printer = new Mock<IDisplayable>();
            printer.Setup(i => i.VerifyInput("12s")).Returns(false);
            Assert.IsFalse(printer.Object.VerifyInput("12s"));
        }

        [Test]
        public void Verify_Bad_Input_12__x()
        {
            var printer = new Mock<IDisplayable>();
            printer.Setup(i => i.VerifyInput("12  x")).Returns(false);
            Assert.IsFalse(printer.Object.VerifyInput("12  x"));
        }

        [Test]
        public void Verify_Good_Input_123()
        {
            var printer = new Mock<IDisplayable>();
            printer.Setup(i => i.VerifyInput("123")).Returns(true);
            Assert.IsTrue(printer.Object.VerifyInput("123"));
        }

        [Test]
        public void Verify_Good_Input_5()
        {
            var printer = new Mock<IDisplayable>();
            printer.Setup(i => i.VerifyInput("5")).Returns(true);
            Assert.IsTrue(printer.Object.VerifyInput("5"));
        }

        [Test]
        public void Get_Representation_For_Input_1()
        {
            string expected = "... \n" +
                              "..| \n" +
                              "..| \n";

            var printer = new Mock<IDisplayable>();
            printer.Setup(s => s.GetRepresentation("1")).Returns(expected);
            Assert.AreEqual(expected, printer.Object.GetRepresentation("1"));
        }

        [Test]
        public void Get_Representation_For_Input_19251()
        {
            string expected = "... ._. ._. ._. ... \n" +
                              "..| |_| ._| |_. ..| \n" +
                              "..| ..| |_. ._| ..| \n";


            var printer = new Mock<IDisplayable>();
            printer.Setup(s => s.GetRepresentation("19251")).Returns(expected);
            Assert.AreEqual(expected, printer.Object.GetRepresentation("19251"));
        }

        #endregion

    }
}