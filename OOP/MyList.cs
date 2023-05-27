using System;
using System.Collections.Generic;

namespace OOP
{
    class MyList
    {
        private int length;
        private int[] data;

        public MyList()
        {
        }
        public MyList(params int[] nums)
        {
            this.data = nums;
            this.length = nums.Length;
        }
        public int Count()
        {
            return this.data.Length;
        }
        public void Add(int a)
        {
            int[] temp = new int[this.data.Length + 1];

            for (int i = 0; i < this.data.Length; i++) temp[i] = this.data[i];
            temp[this.data.Length] = a;

            this.data = temp;
            this.length = temp.Length;
        }

        public void Remove(int a)
        {
            bool isDeleted = false;
            int[] temp = new int[this.data.Length - 1];
            for (int i = 0; i < this.data.Length - 1; i++)
            {
                if (this.data[i] == a)
                {
                    temp[i] = this.data[i + 1];
                    isDeleted = true;
                }
                else if (isDeleted)
                {
                    temp[i] = this.data[i + 1];
                }
                else
                {
                    temp[i] = this.data[i];
                }
            }
            this.data = temp;
            this.length = temp.Length;
        }
    }
}
