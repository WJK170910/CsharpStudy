using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace JSON操作
{
    class Program
    {
        static void Main(string[] args)
        {

            ////JSON（JavaScript Object Notation）是一种轻量级的、基于文本的、开放的数据交换格式
            ////比XML更小、更快、更易解析
            ////JSON解析组件：Newtonsoft.Json、FastJSON,用NuGet包管理器导入

            #region JSON序列化
            ////反序列化：对象   -->   JSON

            //Person[] persons = new Person[] { new Person { Name = "Adam", Sex = "Male" }, new Person { Name = "Jack", Sex = "Male" } };

            //var json = JsonConvert.SerializeObject(persons);


            #endregion

            #region JSON反序列化
            ////反序列化：JSON   -->     对象
            ////[]数组    {}对象
            //string oneJSONExample = @"{
            //                           ""Name"": ""Jack"",
            //                           ""Sex"": ""Male""
            //                          }";
            //string twoJSONExample = @"[{
            //                            ""Name"": ""Adam"",
            //                            ""Sex"": ""Male"" 
            //                           },
            //                           {
            //                 	""Name"": ""Jack"",
            //                        ""Sex"": ""Male""
            //                        }
            //                       ]";
            //string objectExample = @"{
            //                            ""Person"": 
            //                            [{
            //                            ""Name"": ""Adam"",
            //                   ""Sex"": ""Male""
            //                            },
            //                      {
            //                   ""Name"": ""Jack"",
            //                   ""Sex"": ""Male""
            //                      }]
            //                         }";
            //var jsonObject = JsonConvert.DeserializeObject(oneJSONExample);
            //jsonObject = JsonConvert.DeserializeObject(oneJSONExample, typeof(Person));
            //jsonObject = JsonConvert.DeserializeObject<Person>(oneJSONExample);
            //jsonObject = JsonConvert.DeserializeObject<PersonList>(objectExample);
            //jsonObject = JsonConvert.DeserializeObject<List<Person>>(twoJSONExample);
            #endregion
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Sex { get; set; }
    }
    public class PersonList
    {
        public List<Person> Person { get; set; }
    }
}
