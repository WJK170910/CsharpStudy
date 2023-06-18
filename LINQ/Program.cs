using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            var students = new List<Student>()
            {
             new Student() { Id = 1, Name = "Adam",  Sex = "Male" },
             new Student() { Id = 2, Name = "Kevin", Sex = "Male" },
             new Student() { Id = 3, Name = "Lina",  Sex = "Female" }
            };

            #region LINQ基本使用（查询、过滤）
            //var studentNames = from student in students
            //                   where student.Id > 1 && student.Name == "Lina"
            //                   select student;

            //foreach (var item in studentNames) Console.WriteLine(item.Id + " - " + item.Name + " - " + item.Sex);

            #endregion

            #region LINQ联合查询

            //var familiesInfo = new List<FamilyInfo>()
            //{
            // new FamilyInfo() { ChildName = "Adam", FatherName = "AdamFather",  MotherName = "AdamMother" },
            // new FamilyInfo() { ChildName = "Kevin", FatherName = "KevinFather",  MotherName = "KevinMother" },
            // new FamilyInfo() { ChildName = "Lina", FatherName = "LinaFather",  MotherName = "LinaMother" },
            // new FamilyInfo() { ChildName = "James", FatherName = "JamesFather",  MotherName = "JamesMother" },
            //};


            //var result = from student in students
            //             join familyInfo in familiesInfo on student.Name equals familyInfo.ChildName
            //             select new { student = student, familyInfo = familyInfo };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.student.Name + "'s father is " + item.familyInfo.FatherName);
            //}

            #endregion

            #region LINQ中的Where扩展方法使用

            ////Where方法中的参数是委托，故可以传递普通方法或匿名方法或lambda表达式作为参数
            //var result = students.Where(Filter);
            //var result = students.Where(m => m.Id > 1).OrderByDescending(m=>m.Id);
            //var result = students.Where(m => m.Id > 1 && m.Name == "Kevin");

            //foreach (var item in result) Console.WriteLine(item.Id + " - " + item.Name + " - " + item.Sex);

            #endregion

            #region 量词操作符

            bool value = students.Any(m => m.Id == 1);

            value = students.All(m => m.Id == 7);

            #endregion


            Console.Read();
        }
        static bool Filter(Student student)
        {
            if (student.Id > 1) return true;
            return false;
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }

        //public override string ToString()
        //{
        //    return string.Format(Id + " - " + Name + " - " + Sex);
        //}
    }
    public class FamilyInfo
    {
        public string ChildName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
    }
}
