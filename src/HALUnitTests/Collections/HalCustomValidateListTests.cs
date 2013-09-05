using HAL.Collections;
using HAL.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HALUnitTests.Collections
{
    [TestClass]
    public class HalCustomValidateListTests
    {
        [TestMethod]
        [ExpectedException(typeof(HalInvalidValueException), "Invalid Value")]
        public void Create_Hal_Custom_Exclusive_List_Validate_String_Lower_Lenght_2_Throw_Duplicity_Exception()
        {
            HalCustomValidateList<string> validateList = new HalCustomValidateList<string>(s => s.Length > 2);
            validateList.Add("M");
        }

        [TestMethod]
        public void Create_Hal_Custom_Exclusive_List_Validate_String_Lower_Lenght_2_Add_Value_Correct()
        {
            HalCustomValidateList<string> validateList = new HalCustomValidateList<string>(s => s.Length > 2);
            validateList.Add("MAAA");

            Assert.IsTrue(validateList.Count == 1);
        }
    }

}