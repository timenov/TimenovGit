using System;
using System.Collections;
using System.Collections.Generic;

namespace _05.BitArray64
{
    class BitArray : IEnumerable<int>
    {
        private ulong value;
        private int[] bits;

        public ulong Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
        private int[] Bits
        {
            get
            {
                return this.bits;
            }
            set
            {
                this.bits = value;
            }
        }
        public int this[int i]
        {
            get
            {
                return this.Bits[i];
            }
        }

        public BitArray(ulong value)
        {
            this.Value = value;
            this.bits = ConvertToBinaryArray(this.Value);
        }

        public override int GetHashCode()
        {
            return (int)(this.Value % int.MaxValue);
        }

        public override bool Equals(object obj)
        {
            BitArray number = obj as BitArray;
            return this.GetHashCode() == obj.GetHashCode();
        }

        public static bool operator ==(BitArray first, BitArray second)
        {
            return BitArray.Equals(first, second);
        }

        public static bool operator !=(BitArray first, BitArray second)
        {
            return !BitArray.Equals(first, second);
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var bit in this.bits)
            {
                yield return bit;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private static int[] ConvertToBinaryArray(ulong number)
        {
            int[] arrayOfBits = new int[64];

            int indexOfBit = arrayOfBits.Length - 1;
            while (number > 0)
            {
                arrayOfBits[indexOfBit] = (int)(number % 2);
                indexOfBit--;
                number /= 2;
            }

            return arrayOfBits;
        }
    }
}
