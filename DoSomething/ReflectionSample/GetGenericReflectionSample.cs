using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionSample
{
    class GetGenericReflectionSample
    {
        public void GenericReflection()
        {
            Assembly assembly01 = Assembly.Load("GenericLibrary");
            Type type01 = assembly01.GetType("GenericLibrary.GernericType`1"); //加入" ` "是因為前面有一個或多個代表型別參數，位於泛型型別名稱結尾的數字的數字。
            Type type02 = type01.MakeGenericType(new Type[] { typeof(String)});
            Console.WriteLine(type02.FullName);
            Console.WriteLine("=======================");
            Console.WriteLine();

            Object obj01 = Activator.CreateInstance(type02);
            foreach(var item in obj01.GetType().GetGenericArguments())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("=======================");
            Console.WriteLine();

            Type type11 = assembly01.GetType("GenericLibrary.DualGenericType`2");
            Type type12 = type11.MakeGenericType(new Type[] { typeof(Object), typeof(String)});
            Console.WriteLine(type12.FullName);
            Console.WriteLine("=======================");
            Console.WriteLine();

            obj01 = Activator.CreateInstance(type12);
            foreach(var item in obj01.GetType().GetGenericArguments())
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
