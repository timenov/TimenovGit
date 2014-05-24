using System;

namespace _03.RangeException
{
    class InvalidRangeException<T> : ApplicationException
    {
        private T min;
        private T max;

        public T Min
        {
            get { return this.min; }
            set { this.min = value; }
        }
        public T Max
        {
            get { return this.max; }
            set { this.max = value; }
        }

        # region Constructors

        public InvalidRangeException(string msg, Exception innerEx, T min, T max)
            : base(msg, innerEx)
        {
            this.Min = min;
            this.Max = max;
        }

        public InvalidRangeException(T min, T max)
            : this(null, null, min, max)
        {
        }

        public InvalidRangeException(string msg, T min, T max)
            : this(msg, null, min, max)
        {
        }

# endregion
    }
}
