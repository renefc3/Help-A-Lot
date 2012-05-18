using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace HAL.Extension
{
    public  static class DataTableExtension
    {
        public static DataTable CopyOnlySchema(this DataTable dt)
        {
           return  dt.Clone();
        }


        public static DataTable RemoveColumns(this DataTable dt, params int[] index)
        {
            foreach (var i in index)
                dt.Columns.RemoveAt(i);
            return dt;
        }

        public static DataTable RemoveColumns(this DataTable dt, params string[] columnsNames)
        {
            foreach (var cName in columnsNames)
                dt.Columns.Remove(cName);
            return dt;
        }
        
        public static DataTable SetPrimaryKey(this DataTable dt, params string[] primaryKeys)
        {
            List<DataColumn> colunas = new List<DataColumn>();
            foreach (string key in primaryKeys)
                colunas.Add(dt.Columns[key]);

            dt.PrimaryKey = colunas.ToArray();
            return dt;
        }
        public static DataTable SetPrimaryKey(this DataTable dt, params int[] primaryKeys)
        {
            List<DataColumn> colunas = new List<DataColumn>();
            foreach (int key in primaryKeys)
                colunas.Add(dt.Columns[key]);
            
            dt.PrimaryKey = colunas.ToArray();
            return dt;
        }

        
        public static DataTable CleanColumns(this DataTable dt, params int[] index)
        {
            return null;
        }

        public static DataTable CleanColumns(this DataTable dt, params string[] columnsNames)
        {
            return null;
        }
    }
}
