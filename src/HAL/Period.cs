using HAL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HAL
{

    public struct Period
    {
        private DateTime? _starts;
        private DateTime? _ends;

        public Period(DateTime? starts, DateTime? ends)
        {
            if (starts > ends)
                throw new HalRangeException(string.Format("Period Invalid with {0}-{1}", starts, ends));

            _starts = starts;
            _ends = ends;
        }

        public DateTime? Starts
        {
            get { return _starts; }
            private set { _starts = value; }
        }

        public DateTime? Ends
        {
            get { return _ends; }
            private set { _ends = value; }
        }

    }
}
