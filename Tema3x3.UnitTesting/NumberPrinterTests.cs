using NUnit.Framework;
using Tema3x3.BaseComponents;
using Tema3x3.PrinterService;

namespace Tema3x3.UnitTesting
{
    public class NumberPrinterTests
    {
        private IDisplayable _printer = null;

        [SetUp]
        public void Setup()
        {
            _printer = new NumberPrinter();
        }

        #region Private Test Methods

        private bool Given_A_Bad_User_Input_Return_False_Or_True(string input)
        {
            return _printer.VerifyInput(input);
        }

        private string Given_A_User_Input_Assert_Resulted_Representation(string input)
        {
            return _printer.GetRepresentation(input);
        }

        #endregion


        #region Tests

        [Test]
        public void Printer_Verify_Bad_Input_12s()
        {
            var methodResult = Given_A_Bad_User_Input_Return_False_Or_True("12s");
            Assert.IsFalse(methodResult);
        }

        [Test]
        public void Printer_Verify_Bad_Input_12__x()
        {
            var methodResult = Given_A_Bad_User_Input_Return_False_Or_True("12  x");
            Assert.IsFalse(methodResult);
        }

        [Test]
        public void Printer_Verify_Good_Input_123()
        {
            var methodResult = Given_A_Bad_User_Input_Return_False_Or_True("123");
            Assert.IsTrue(methodResult);
        }

        [Test]
        public void Printer_Verify_Good_Input_5()
        {
            var methodResult = Given_A_Bad_User_Input_Return_False_Or_True("5");
            Assert.IsTrue(methodResult);
        }

        [Test]
        public void Printer_Get_Representation_For_Input_1()
        {
            string expected = "... \n" +
                              "..| \n" +
                              "..| \n";

            var res = Given_A_User_Input_Assert_Resulted_Representation("1");
            Assert.AreEqual(expected, res);
        }

        [Test]
        public void Printer_Get_Representation_For_Input_19251()
        {
            string expected = "... ._. ._. ._. ... \n" +
                              "..| |_| ._| |_. ..| \n" +
                              "..| ..| |_. ._| ..| \n";

            var res = Given_A_User_Input_Assert_Resulted_Representation("19251");
            Assert.AreEqual(expected, res);
        }

        #endregion

    }
}