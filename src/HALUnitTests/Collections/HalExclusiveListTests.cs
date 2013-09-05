using HAL.Collections;
using HAL.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HALUnitTests.Collections
{
    [TestClass]
    public class HalExclusiveListTests
    {
        [TestMethod]
        [ExpectedException(typeof(HalDuplicityException), "List already have the item in the list")]
        public void Create_Hal_Exclusive_List_Try_Add_Values_Equals_Throw_Hal_Duplicity_Exception()
        {
            HalExclusiveList<string> exclusiveList = new HalExclusiveList<string>();

            exclusiveList.Add("My Name");
            exclusiveList.Add("My Name");
        }

        [TestMethod]
        [ExpectedException(typeof(HalDuplicityException), "List already have the item in the list")]
        public void Create_Hal_Exclusive_List_Try_Insert_Values_Equals_Throw_Hal_Duplicity_Exception()
        {
            HalExclusiveList<string> exclusiveList = new HalExclusiveList<string>();

            exclusiveList.Insert(0, "My Name1");
            exclusiveList.Insert(1, "My Name1");
        }

        [TestMethod]
        public void Create_Hal_Exclusive_List_Try_Add_Values_Confirm_The_Values_Added()
        {
            HalExclusiveList<string> exclusiveList = new HalExclusiveList<string>();

            exclusiveList.Add("My Name");
            exclusiveList.Add("My Name1");

            Assert.IsTrue(exclusiveList.Count == 2);
            Assert.IsTrue(exclusiveList.Contains("My Name"));
            Assert.IsTrue(exclusiveList.Contains("My Name1"));
        }

        [TestMethod]
        public void Create_Hal_Exclusive_List_Try_Insert_Values_Confirm_The_Values_Inserted()
        {
            HalExclusiveList<string> exclusiveList = new HalExclusiveList<string>();

            exclusiveList.Insert(0, "My Name2");
            exclusiveList.Insert(1, "3");

            Assert.IsTrue(exclusiveList.Count == 2);
            Assert.IsTrue(exclusiveList.Contains("My Name2"));
            Assert.IsTrue(exclusiveList.Contains("3"));
        }



    }
}