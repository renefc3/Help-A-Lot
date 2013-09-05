using System;

namespace HAL.Exceptions
{
    public class HalException : Exception
    {
        public HalException(string message)
            : base(message)
        {
            

        }
    }
}