using System.Collections.Generic;

namespace OOP
{
    //集合类List，动态数组
    class ListClass
    {
        public void ListFunction()
        {
            ////定义一个空的List，它内部是一个长度为0的数组
            //List<int> list = new List<int>();
            //int capacity = list.Capacity;


            ////当往List添加数据时，容量会扩大成4，当输入第五个数据时，容量扩大成8，当输入第九个数据，容量扩大为16，以此类推
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

            int capacity = list.Capacity;
            list.Add(20);                   //添加数据
            list.Insert(3, 20);              //插入索引为3的位置，值为20
            list.Remove(20);                //移除匹配到的第一个数据
            list.Clear();                   //清空所有数据

        }
    }
}
