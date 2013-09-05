using HAL.Extension;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HALUnitTests
{
    [TestClass]
    public class StringExtensionTest
    {

        [TestMethod]
        public void Insensitive_Contains_Using_Value_Lower_And_Validate_In_Uper()
        {
            string testInHal = "this is a real test in HAL";


            Assert.IsTrue(testInHal.InsensitiveContains("REAL"));
            Assert.IsTrue(testInHal.InsensitiveContains("Real"));
            Assert.IsTrue(testInHal.InsensitiveContains("real"));
            Assert.IsTrue(testInHal.InsensitiveContains("ReAl"));
            Assert.IsTrue(testInHal.InsensitiveContains("REAl"));
            Assert.IsTrue(testInHal.InsensitiveContains("REaL"));

            Assert.IsFalse(testInHal.InsensitiveContains("not Find"));
            Assert.IsFalse(testInHal.InsensitiveContains("not find"));
        }


        [TestMethod]
        public void Validate_String_IsNumeric_With_Value_Invalid()
        {
            string inValidValue = "ABC";
            string inValidValueWithNumeric = "11ABC22";

            Assert.IsFalse(inValidValue.IsNumeric());
            Assert.IsFalse(inValidValueWithNumeric.IsNumeric());
        }

        [TestMethod]
        public void Validate_String_IsNumeric_With_Value_Valid()
        {
            string validValue = "332";

            Assert.IsTrue(validValue.IsNumeric());
        }


        [TestMethod]
        public void Validate_String_1345_And_Insert_Before_3_the_value_2_And_Validate_String_12345()
        {
            string realValue = "1345";

            Assert.AreEqual(realValue.InsertBeforeAll("3", "2"), "12345");
        }



        [TestMethod]
        public void Validate_String_13435_And_Insert_Before_First_3_the_value_2_And_Validate_String_123435()
        {
            string realValue = "13435";

            Assert.AreEqual(realValue.InsertBeforeFirst("3", "2"), "123435");
        }

        [TestMethod]
        public void Validate_String_1234235_And_Insert_Before_First_23_the_value_555_And_Validate_String_155523435()
        {
            string realValue = "1234235";

            Assert.AreEqual(realValue.InsertBeforeFirst("23", "555"), "1555234235");
        }

        [TestMethod]
        public void Validate_String_1234235_And_Insert_Before_First_9_Return_Same_String()
        {
            string realValue = "1234235";

            Assert.AreEqual(realValue.InsertBeforeFirst("9", "555"), realValue);
        }


        [TestMethod]
        public void Validate_String_123457564_And_Insert_After_First_5_the_value_6_And_Validate_String_1234567564()
        {
            string realValue = "123457564";
            string expected = "1234567564";

            string resultAction = realValue.InsertAfterFirst("5", "6");

            Assert.AreEqual(resultAction, expected);
        }

        [TestMethod]
        public void Validate_String_1234_And_Insert_After_First_4_the_value_5_And_Validate_String_12345()
        {
            string realValue = "1234";
            string expected = "12345";

            string resultAction = realValue.InsertAfterFirst("4", "5");

            Assert.AreEqual(resultAction, expected);
        }


        [TestMethod]
        public void Validate_String_12312341234123_And_Insert_After_First_234_the_value_56_And_Validate_String_1231234561234123()
        {
            string realValue = "12312341234123";
            string expected = "1231234561234123";

            string resultAction = realValue.InsertAfterFirst("234", "56");

            Assert.AreEqual(resultAction, expected);
        }


    }
}