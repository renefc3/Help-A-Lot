using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;
using HAL.Exceptions;

namespace HAL.Extension
{
    public static class StringExtension
    {

        public static bool InsensitiveContains(this string valor, string comparacao)
        {
            if (string.IsNullOrEmpty(valor) && string.IsNullOrEmpty(comparacao))
                return true;

            if (string.IsNullOrEmpty(valor) || string.IsNullOrEmpty(comparacao))
                return false;

            return valor.ToUpper().Contains(comparacao.ToUpper());
        }

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
            int indexValor = value.IndexOf(valueWhereInsert);
            if (indexValor == -1)
                return value;

            string initialPart = value.Substring(0, indexValor + valueWhereInsert.Length);
            initialPart = initialPart.Replace(valueWhereInsert, valueWhereInsert + valueToInsert);
            return initialPart +
                   value.Substring(indexValor + valueWhereInsert.Length,
                                   value.Length - (indexValor + valueWhereInsert.Length));
        }




        public static string InsertBeforeAll(this string value, string valueWhereInsert, string valueToInsert)
        {
            return value.Replace(valueWhereInsert, valueToInsert + valueWhereInsert);
        }

        public static string InsertBeforeFirst(this string value, string valueWhereInsert, string valueToInsert)
        {
            int indexValor = value.IndexOf(valueWhereInsert);
            if (indexValor == -1)
                return value;

            string initialPart = value.Substring(0, indexValor + valueWhereInsert.Length);
            initialPart = initialPart.Replace(valueWhereInsert, valueToInsert + valueWhereInsert);
            return initialPart +
                   value.Substring(indexValor + valueWhereInsert.Length,
                                   value.Length - (indexValor + valueWhereInsert.Length));


        }


        public static string FirstLetterUpper(this string value)
        {
            if (string.IsNullOrEmpty(value) || value.Length == 0)
                return value;
            if (value.Length == 1)
                return value.ToUpper();

            return value.Substring(0, 1).ToUpper() + value.Substring(1, value.Length - 1);
        }

        public static string FirstLetterLower(this string value)
        {
            if (string.IsNullOrEmpty(value) || value.Length == 0)
                return value;
            if (value.Length == 1)
                return value.ToLower();

            return value.Substring(0, 1).ToLower() + value.Substring(1, value.Length - 1);
        }

        public static T ConvertToEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value);
        }

        //public static string ToUpper(this string value, params Range[] ranges)
        //{

        //    if (string.IsNullOrEmpty(value) || value.Length == 0)
        //        return value;
        //    string valueAux = "";
        //    foreach (Range range in ranges.OrderBy(x => x.Starts))
        //    {
        //        //if (b)
        //        //{

        //        //}
        //        //value = value.Substring(0, range.Starts) + value.Substring(range.Starts, range.Lenght).ToUpper() + value.Substring(range.Starts+ range.Lenght, value.Length - (range.Starts+ range.Lenght)) ;
        //    }

        //    return value;
        //}





        //public static string InsertBeforeLast(this string value, string valueWhereInsert, string valueToInsert)
        //{

        //    return value;
        //}

        //public static string InsertAfterLast(this string value, string valueWhereInsert, string valueToInsert)
        //{
        //    return value;
        //}

        //-

        //Definir Ranges para Transformar em Lower

        //- Definir Ranges para Transformar em Upper

        //- Aplicar Padrao de Primeira Letra Upper apos "Espaço"( definir caracter para depois dele deixar Upper)

        //- Aplicar Padrao de Primeira Letra Lower apos "Espaço"( definir caracter para depois dele deixar Lower)

        //- Aplicar Padrao de Primeira Letra Upper antes"Espaço"( definir caracter para antes dele deixar Upper)

        //- Aplicar Padrao de Primeira Letra Lower antes "Espaço"( definir caracter para antes dele deixar Lower)



        //Fazer metodo Enum.TryParse ou pensar em algo para resolver problema assim, usando int ou string


     
    }


    

    public static class CollectionExtension
    {

        public static IList<T> Clone<T>(this IList<T> lista) where T : ICloneable
        {
            IList<T> listaClone = new List<T>();

            foreach (T valor in lista)
            {
                listaClone.Add((T)valor.Clone());
            }

            return listaClone;
        }


        public static IEnumerable<T> Distinct<T>(this IEnumerable<T> lista, Expression<Func<T, object>> lambdaExpression)
        {



            return null;

        }

        public static bool Exists<T>(this IQueryable<T> lista, Expression<Func<T, bool>> lambdaExpression)
        {
            return lista.Any(lambdaExpression);
            //Teste t = new Teste();
            //IEnumerable<Teste> a = t.FazerIsso<Teste>(x => x.nome);

            //a.Distinct().Distinct(x => x.nome);

            //return lista.Count(lambdaExpression) == 0;
        }

    }

}
