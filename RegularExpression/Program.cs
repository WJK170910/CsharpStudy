using System;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 基本使用

            //string para = "1234561";

            ////    \d是元字符，表示匹配任何一个数字，等价于[0-9], \D是\d的补集
            ////    \w表示匹配大小写字母或下划线或数字
            ////    ^表示以什么开头
            ////    $表示以什么结尾
            //Console.WriteLine(Regex.IsMatch(para, @"\d"));

            //Console.WriteLine(Regex.IsMatch(para, @"\D"));

            //Console.WriteLine(Regex.IsMatch(para, @"\w"));

            //Console.WriteLine(Regex.IsMatch(para, @"^\d"));

            //Console.WriteLine(Regex.IsMatch(para, @"\d$"));

            ////    *只作用于前一个字符，可以存在零个或多个
            ////    ^\d*$是一个正则表达式，表示匹配任何由0个或多个数字字符组成的字符串
            //Console.WriteLine(Regex.IsMatch(para, @"^\d*$"));
            //Console.WriteLine(Regex.IsMatch(para, @"^12\d*$"));


            //Console.WriteLine(Regex.IsMatch("abc123ABC", @"[A-z]"));

            ////匹配长度1-2的数字字符串
            //Console.WriteLine(Regex.IsMatch("abc123ABC", @"\d{1,2}"));

            ////匹配长度为1的数字字符串
            //Console.WriteLine(Regex.IsMatch("abc123ABC", @"\d{4}"));

            ////匹配长度至少为1的数字字符串
            //Console.WriteLine(Regex.IsMatch("abc123ABC", @"\d{1,}"));

            ////?：重复零次或多次   +：重复一次或多次
            //Console.WriteLine(Regex.IsMatch("abcdABC", @"\d?"));
            //Console.WriteLine(Regex.IsMatch("abcdABC", @"\d+"));

            #endregion


            #region 择一匹配、重复匹配
            ////字符串包含数字或字符y
            Console.WriteLine(Regex.IsMatch("abc123d", @"\d|y"));

            ////字符串包含 aa
            Console.WriteLine(Regex.IsMatch("abc123d", @"a{2}"));

            ////字符串包含 abb
            Console.WriteLine(Regex.IsMatch("abc123d", @"ab{2}"));

            ////字符串包含 abb
            Console.WriteLine(Regex.IsMatch("abc123d", @"ab{2}"));

            ////字符串包含 (
            Console.WriteLine(Regex.IsMatch("abc(123d", @"\("));


            #endregion


            Console.ReadKey();
        }
    }
}
