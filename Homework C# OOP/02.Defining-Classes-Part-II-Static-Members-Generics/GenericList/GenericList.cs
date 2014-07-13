using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListTest
{
    //Task 5.
    public class GenericList<T>
    {
        //const int DefaultCapacity = 10;

        private List<T> elements;
        private int count = 0;

        public GenericList(int capacity)
        {
            this.elements = new List<T>(capacity);
        }

        //public GenericList()
        //    : this(DefaultCapacity)
        //{
        //}

        public int Count
        {
            get { return this.count; }
        }

        //Adding elements
        public void Add(T element)
        {
            //Task 6. (auto-grow)
            if (this.count >= this.elements.Capacity)
            {
                List<T> addSpace = new List<T>(this.count);
                this.elements.AddRange(addSpace);
            }

            this.elements.Add(element);
            this.count++;
        }

        //Accessing element
        public T AccessingByIndex(int index)
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
            }

            T resul = this.elements[index];
            return resul;
        }

        //Removing element
        public void Delete(int index)
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
            }

            this.elements.Remove(elements[index]);
            this.count--;
        }

        //Inserting at given position.
        public void Insert(int index, T element)
        {
            //Task 6. (auto-grow)
            if (this.count >= this.elements.Capacity)
            {
                List<T> addSpace = new List<T>(this.count);
                this.elements.AddRange(addSpace);
            }

            List<T> newList = new List<T>(this.count);

            if (this.elements[index].Equals(default(T)) == false)
            {
                for (int i = index; i < count; i++)
                {
                    newList.Add(this.elements[i]);
                }

                this.elements.RemoveRange(index, (count - index));
                this.elements.Add(element);
                this.elements.AddRange(newList);
                count++;
            }
        }

        //Clearing the list
        public void Clear()
        {
            this.elements.Clear();
            this.count = 0;
        }

        //Finding element by it's value
        public int FindByValue(T value)
        {
            int position = 0;
            for (int i = 0; i < count; i++)
            {
                if (this.elements[i].Equals(value) == true)
                {
                    position = i;
                }
            }

            return position;
        }

        //ToString override
        public override string ToString()
        {
            StringBuilder console = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                console.Append(elements[i]);
                console.Append(" ");
            }
            return console.ToString();
        }

        //Auto-growing function (Task 6. manual use)
        private void IncreaseCapacity()
        {
            if (this.count >= this.elements.Capacity)
            {
                List<T> addSpace = new List<T>(this.count);
                this.elements.AddRange(addSpace);
            }
        }

        //Task 7.
        public T MinT()
        {
            T min =this.elements[0];

            if (this.elements[0] is IComparable<T>)
            {
                for (int i = 1; i < this.count; i++)
                {
                    if ((min as IComparable<T>).CompareTo(this.elements[i]) > 0)
                    {
                        min = this.elements[i];
                    }
                }
            }

            return min;
        }

        public T MaxT()
        {
            T max = default(T);

            if (this.elements[0] is IComparable<T>)
            {
                for (int i = 1; i < this.count; i++)
                {
                    if ((max as IComparable<T>).CompareTo(this.elements[i]) < 0)
                    {
                        max = this.elements[i];
                    }
                }
            }

            return max;
        }
    }
}
