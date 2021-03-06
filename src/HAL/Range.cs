﻿using HAL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HAL
{

    public struct Range<T> where T : IComparable<T>
    {
        private T _starts;
        private T _ends;


        public Range(T starts, T ends)
        {
            //if (starts == ends || starts.CompareTo(ends) == 0)
            //    throw new HalRangeException(string.Format("Range Invalid with {0}-{1}", starts, ends));

            _starts = starts;
            _ends = ends;
        }


        public T Starts
        {
            get { return _starts; }
            private set { _starts = value; }
        }

        public T Ends
        {
            get { return _ends; }
            private set { _ends = value; }
        }

    }

    public struct Range
    {
        private int _starts;
        private int _ends;

        public Range(int starts, int ends)
        {
            if (starts == ends || starts > ends)
                throw new HalRangeException(string.Format("Range Invalid with {0}-{1}", starts, ends));

            _starts = starts;
            _ends = ends;
        }

        public int Starts
        {
            get { return _starts; }
            private set { _starts = value; }
        }

        public int Ends
        {
            get { return _ends; }
            private set { _ends = value; }
        }

        public int Lenght
        {
            get { return _starts - _ends; }
        }
    }
}
