using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BitArray64
{
    class BitArray64 : IEnumerable<int>
    {
        //Fields
        private int[] bitArray = new int[64];
        private ulong value;// { get; set; }

        //Property
        public ulong Value
        {
            get { return this.value; }
        }

        //Constructor
        public BitArray64(ulong inputValue)
        {
            this.value = inputValue;

            ulong workNum = this.value;
            for (int i = 63; i >= 0; i--)
            {
                ulong tempProd = workNum;
                workNum %= 2;
                if (workNum == 0) this.bitArray[i] = 0;
                else if (tempProd == 1) this.bitArray[i] = 1;
                else if (tempProd == 1 || tempProd == 0) break;
                else this.bitArray[i] = 1;
                tempProd /= 2;
                workNum = tempProd;
            }
        }

        //Methods
        //GetEnumerator
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 63; i >= 0; i--)
            {
                yield return this.bitArray[i];
            }
        }

        //Equals

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            BitArray64 inputValue = obj as BitArray64;

            if ((System.Object)inputValue == null)
            {
                return false;
            }

            return (this.value == inputValue.value);
        }

        //GetHashCode
        public override int GetHashCode()
        {
            return this.value.GetHashCode() ^ this.bitArray.GetHashCode();
        }

        //==
        public static bool operator ==(BitArray64 valueOne, BitArray64 valueTwo)
        {
            if (System.Object.ReferenceEquals(valueOne, valueTwo))
            {
                return true;
            }

            if (((object)valueOne == null) || ((object)valueTwo == null))
            {
                return false;
            }

            return valueOne.value == valueTwo.value;
        }

        //!=
        public static bool operator !=(BitArray64 valueOne, BitArray64 valueTwo)
        {
            return !(valueOne.value == valueTwo.value);
        }

        //[]
        public int this[int index]
        {
            get { return bitArray[index]; }
            set { bitArray[index] = value; }
        }

        //ToString
        public override string ToString()
        {
            StringBuilder decNum = new StringBuilder();

            foreach(var item in this.bitArray)
            {
                decNum.Append(item);
            }

            return decNum.ToString();
        }
    }
}
