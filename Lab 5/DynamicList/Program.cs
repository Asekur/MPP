using System;
using System.Collections.Generic;
using System.Reflection;

namespace DynamicList
{
    class Program
    {
        static void Main(string[] args)
        {
            GetClasses();
            TryDynamic();
            Console.ReadKey();
        }

        private static void GetClasses()
        {
            //D:\Для вот этого мусора\github\MPP\Lab 5\DynamicList\bin\Debug\DynamicList.exe
            Type export = typeof(ExportClass);

            Console.Write("Type the way: ");
            string exePath = Console.ReadLine();
            Console.WriteLine();

            try
            {
                Assembly assembly = Assembly.LoadFrom(exePath);
                if (export.BaseType == typeof(Attribute))
                {
                    //список классов с атрибутом ExportClass
                    List<Type> types = new List<Type>();
                    foreach (Type type in assembly.GetTypes())
                    {
                        if (type.GetCustomAttributes(export, true).Length > 0)
                            types.Add(type);
                    }
                    foreach (Type t in types)
                    {
                        //вывод полных имен public - типов
                        MethodInfo[] methods = t.GetMethods();
                        Console.WriteLine("Class with attribute: " + t.FullName);
                        for (int i = 0; i < methods.Length; i++)
                        {
                            Console.WriteLine((i + 1) + ") Name of public-type: " + methods[i].Name);
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error in load file");
            }
        }

        private static void TryDynamic()
        {
            DynamicList<int> _list = new DynamicList<int>();
            for (int i = 0; i < 5; i++)
            {
                _list.Add(i);
            }
            _list.RemoveAt(9);
            _list.Remove(4);
            for (int i = 5; i < 25; i++)
            {
                _list.Add(i);
            }
            _list.Clear();
            for (int i = 0; i < 10; i++)
            {
                _list.Add(i);
            }
            _list.Remove(12);
            _list.Clear();
        }
    }
}
