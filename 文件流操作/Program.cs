using System;
using System.IO;

namespace 文件流操作
{
    class Program
    {

        static void Main(string[] args)
        {

            ////非托管资源是指.NET不知道如何回收的资源，是CLR不能控制或者管理的部分。例如文件，数据库连接，网络连接，窗口，画刷，图标等
            ////非托管资源的释放可以通过实现IDisposable接口来实现,using语句可以自动释放实现IDisposable接口的对象


            #region 路径

            ////    .代表当前目录     ..代表上层目录
            Console.WriteLine(System.Environment.CurrentDirectory);
            Console.WriteLine(File.Exists(@".\文件流操作.dll"));
            Console.WriteLine(File.Exists(@"..\..\..\Program.cs"));

            #endregion

            #region 文件基本操作

            #region File类


            //var file = File.ReadAllText(@"C:\Develop\文件流测试文本.txt");
            //Console.WriteLine(file);

            //FileStream file = File.OpenWrite(@"C:\Develop\文件流测试文本.txt");
            //Console.WriteLine(file.Name + " - " + file.Length);

            //FileStream file = File.Open(@"C:\Develop\文件流测试文本.txt", FileMode.OpenOrCreate);
            //Console.WriteLine(file.Name + " - " + file.Length);

            //FileStream file = File.OpenRead(@"C:\Develop\学习资料.txt");
            //Console.WriteLine(file.Name + " - " + file.Length);

            ////将字符串数组添加到每行末尾
            //string[] lines = { "First line", "Second line", "Third line" };
            //File.AppendAllLines(@"C:\Develop\文件流测试文本.txt", lines);

            //File.WriteAllText(@"C:\Develop\文件流测试文本1.txt", "2223245");
            //File.AppendAllText(@"C:\Develop\文件流测试文本1.txt", "Hello");

            //Console.WriteLine(File.ReadAllText(@"C:\Develop\文件流测试文本1.txt"));

            //var bytes = File.ReadAllBytes(@"C:\Develop\文件流测试文本1.txt");
            //foreach (var item in bytes) Console.WriteLine(item);

            //File.AppendText(@"C:\Develop\文件流测试文本1.txt");
            //File.AppendAllText(@"C:\Develop\文件流测试文本.txt", "Hello");

            #endregion

            #region FileInfo类

            FileInfo file = new FileInfo(@"C:\Develop\学习资料.txt");
            //Console.WriteLine("Name：" + file.Name + " - FullName：" + file.FullName);

            #endregion

            #endregion

            #region 目录基本操作
            //Console.WriteLine(Directory.Exists(@"C:\Develop"));

            //DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Develop");
            //Console.WriteLine(directoryInfo.Name);


            #endregion


            #region FileStream//MemoryStream

            //FileStream fileStream = new FileStream(@"C:\Develop\文件流测试文本.txt", FileMode.Open);
            //Console.WriteLine(fileStream.ReadByte());

            //MemoryStream memoryStream = new MemoryStream();

            #endregion
            Console.Read();
        }
    }
}
