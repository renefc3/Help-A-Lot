using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HAL.Extension
{
    public static class StringExtension
    {
        public static bool IsNumeric(this string value)
        {
            int numero;
            return int.TryParse(value, out numero);
        }


        public static string InsertAfterAll(this string value, string valueWhereInsert, string valueToInsert)
        {
            return value.Replace(valueWhereInsert, valueWhereInsert + valueToInsert);
        }

        public static string InsertAfterFirst(this string value, string valueWhereInsert, string valueToInsert)
        {
            return "";
        }

        public static string InsertAfterLast(this string value, string valueWhereInsert, string valueToInsert)
        {
            return "";

        }



        public static string InsertBeforeAll(this string value, string valueWhereInsert, string valueToInsert)
        {
            return value.Replace(valueWhereInsert, valueToInsert + valueWhereInsert);
        }

        public static string InsertBeforeFirst(this string value, string valueWhereInsert, string valueToInsert)
        {
            return "";

        }

        public static string InsertBeforeLast(this string value, string valueWhereInsert, string valueToInsert)
        {
            return "";

        }
    }
}
