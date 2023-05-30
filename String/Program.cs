using System;
using System.Text;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 字符串基本方法
            //string example = "  a sting for test ,thanks";

            ////去除首尾的空格
            //example = example.Trim();

            ////转为大小写
            //example = example.ToLower();
            //example = example.ToUpper();

            ////字符串可视作一个字符数组
            ////按某分隔符分割字符串
            //var part = example.Split(",");
            //Console.WriteLine(part[1]);


            ////string的拼接实际上不会直接修改原来字串的值，而是在静态存储区开辟新的空间将新旧字符串拼接并存储，故需要把新的字符串的地址引用赋给原变量
            ////而StringBuilder是可变的，允许扩充字符串中字符的数量，所以无需重新赋值
            //example = "  a sting for test ,thanks" + "!";

            //////截取字符串
            //example = example.Substring(5);
            //example = example.Substring(5,2);
            //Console.WriteLine($"{example}");

            #endregion

            #region StringBuilder基本方法


            //StringBuilder stringBuilder = new StringBuilder("Hello");

            ////Append()是不加回车的拼接，而AppendLine()是加回车的拼接
            //stringBuilder.Append(" World!");
            //stringBuilder.AppendLine(" World!");

            ////在索引的位置插入内容
            //stringBuilder.Insert(1,"Hello");


            ////从索引的位置开始删除相应长度的内容
            //stringBuilder.Remove(0,2);

            ////将字符串中的内容替换
            //stringBuilder.Replace("l","L");

            //Console.WriteLine(stringBuilder);

            #endregion

            #region 理论上Append方法比string的拼接快
            ////.NET 6:DateOnly 和 TimeOnly 
            ////.NET 6 之前使用 DateTime 类型


            //Console.WriteLine(DateTime.Now);

            //string testString = "Hello";
            //for (int i = 0; i < 50000; i++)
            //{
            //    testString = testString + i;
            //}

            //Console.WriteLine(DateTime.Now);

            //StringBuilder stringBuilder = new StringBuilder("Hello");
            //for (int i = 0; i < 50000; i++)
            //{
            //    stringBuilder.Append("Hello" + i);
            //} 
            //Console.WriteLine(DateTime.Now);

            #endregion

            #region 字符串特殊字符@、$的用法
            ////@字符：按原义解释字符串，转义字符等无效
            ////$字符：允许字符串使用变量
            //string para = "World";
            //Console.WriteLine($"Hello\n {para}!");
            //Console.WriteLine(@$"Hello\n {para}!");
            #endregion

            Console.ReadKey();
        }
    }
}
