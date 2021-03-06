using System.Data;
using HAL.Extension;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HALUnitTests
{
    [TestClass]
    public class DataTableExtensionTest
    {

        [TestMethod]
        public void CopyOnlySchemaFromADataTable()
        {
            DataTable dtWithData = BuildDataTableComDados();
            DataTable dtWithoutData = dtWithData.CopyOnlySchema();

            Assert.AreEqual(dtWithoutData.Rows.Count, 0);
            Assert.AreEqual(dtWithoutData.Columns.Count, dtWithData.Columns.Count);

        }

        private DataTable BuildDataTableComDados()
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