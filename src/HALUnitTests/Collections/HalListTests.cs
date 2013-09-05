using System;
using HAL;
using HAL.Collections;
using HAL.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HALUnitTests.Collections
{
    
    [TestClass]
    public class HalListTests
    {
        [TestMethod]
        public void Create_Hal_List_Without_Event_Add_Two_Number_Should_Contains_Two_Numbers()
        {
            HalList<int> inteiros = new HalList<int>();

            inteiros.Add(2);
            inteiros.Add(3);

            Assert.IsTrue(inteiros.Count == 2);
        }

        [TestMethod]
        public void Create_Hal_List_Confirm_The_Value_Before_Add_Sould_Be_2()
        {
            HalList<int> inteiros = new HalList<int>();
            inteiros.BeforeAddItem += (int i) => Assert.IsTrue(i == 2);

            inteiros.Add(2);

            Assert.IsTrue(inteiros.Count == 1);
        }


        [TestMethod]
        public void Create_Hal_List_Confirm_The_Value_After_Add_Sould_Be_1()
        {
            HalList<int> inteiros = new HalList<int>();
            inteiros.AfterAddItem += (int i) => Assert.IsTrue(i == 1);

            inteiros.Add(1);

            Assert.IsTrue(inteiros.Count == 1);
        }


        [TestMethod]
        public void Create_Hal_List_Confirm_The_Value_Before_Insert_Sould_Be_3_And_Index_0()
        {
            HalList<int> inteiros = new HalList<int>();
            inteiros.BeforeInsertItem += (int index, int item) =>
                                             {
                                                 Assert.IsTrue(item == 3);
                                                 Assert.IsTrue(index == 0);
                                             };

            inteiros.Insert(0, 3);

            Assert.IsTrue(inteiros.Count == 1);
        }

        [TestMethod]
        public void Create_Hal_List_Confirm_The_Value_Before_Insert_Sould_Be_5_And_Index_0()
        {
            HalList<int> inteiros = new HalList<int>();
            inteiros.AfterInsertItem += (int index, int item) =>
            {
                Assert.IsTrue(item == 5);
                Assert.IsTrue(index == 0);
            };

            inteiros.Insert(0, 5);

            Assert.IsTrue(inteiros.Count == 1);
        }



        [TestMethod]
        public void Create_Hal_List_Confirm_The_Value_After_Remove_Should_be_Removed()
        {
            HalList<int> inteiros = new HalList<int>();
            inteiros.AfterRemoveItem += (int i) => Assert.IsTrue(i == 2);

            inteiros.Add(2);
            inteiros.Remove(2);

            Assert.IsTrue(inteiros.Count == 0);
        }


        [TestMethod]
        public void Create_Hal_List_Confirm_The_Value_Before_Remove_Should_be_Removed()
        {
            HalList<int> inteiros = new HalList<int>();
            inteiros.BeforeRemoveItem += (int i) => Assert.IsTrue(i == 1);

            inteiros.Add(1);
            inteiros.Remove(1);

            Assert.IsTrue(inteiros.Count == 0);
        }


        [TestMethod]
        public void Create_Hal_List_Confirm_The_Value_After_RemoveAt_Should_be_Removed()
        {
            HalList<int> inteiros = new HalList<int>();
            inteiros.AfterRemoveAtItem += (int index, int item) =>
                                              {
                                                  Assert.IsTrue(index == 0);
                                                  Assert.IsTrue(item == 4);
                                              };

            inteiros.Add(4);
            inteiros.RemoveAt(0);


            Assert.IsTrue(inteiros.Count == 0);
        }


        [TestMethod]
        public void Create_Hal_List_Confirm_The_Value_Before_RemoveAt_Should_be_Removed()
        {
            HalList<int> inteiros = new HalList<int>();
            inteiros.BeforeRemoveAtItem += (int index, int item) =>
                                                                    {
                                                                        Assert.IsTrue(index == 0);
                                                                        Assert.IsTrue(item == 5);
                                                                    };

            inteiros.Add(5);
            inteiros.RemoveAt(0);

            Assert.IsTrue(inteiros.Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(HalException), "Index out of range on the List!")]
        public void Create_Hal_List_Try_RemoveAt_Index_Does_Not_Exist_Throws_HAL_Exception()
        {
            HalList<int> inteiros = new HalList<int>();
          
            inteiros.RemoveAt(0);
        }

    }
}
