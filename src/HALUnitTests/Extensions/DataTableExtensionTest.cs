using System.Data;
using HAL.Extension;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HALUnitTests
{
    [TestClass]
    public class DataTableExtensionTest
    {

        [TestMethod]
        public void Copy_Only_Schema_From_A_DataTable_And_Validate_Dont_Have_Rows_And_Have_Same_Columns()
        {
            DataTable dtWithData = BuildDataTableWithData();
            DataTable dtWithoutData = dtWithData.CopyOnlySchema();

            Assert.AreEqual(dtWithoutData.Rows.Count, 0);
            Assert.AreEqual(dtWithoutData.Columns.Count, dtWithData.Columns.Count);
        }


        [TestMethod]
        public void Remove_Columns_1_2_ByIndex_Confirm_The_Count_Of_Columns()
        {
            DataTable dtWithData = BuildDataTableWithData();
            DataTable dtWithoutData = dtWithData.CleanColumns(1, 2);

            foreach (DataRow row in dtWithoutData.Rows)
            {
                Assert.IsTrue(Equals(row[1], ""));
                Assert.IsTrue(Equals(row[2], ""));
            }
        }




        //[TestMethod]
        //[ExpectedException(typeof(HALException))]
        //public void RemoveColumnsByIndexWithoutIndex()
        //{
        //    DataTable dtWithData = BuildDataTableWithData();
        //    DataTable dtWithoutData = dtWithData.CleanColumns(2,5);

        //}




        private DataTable BuildDataTableWithData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("col1");
            dt.Columns.Add("col2");
            dt.Columns.Add("col3");

            dt.Rows.Add("aaaa", "bbbb", "ccccc");
            dt.Rows.Add("aaaa", "bbbb", "ccccc");
            dt.Rows.Add("aaaa", "bbbb", "ccccc");
            dt.Rows.Add("aaaa", "bbbb", "ccccc");
            dt.Rows.Add("aaaa", "bbbb", "ccccc");

            return dt;

        }
    }
}