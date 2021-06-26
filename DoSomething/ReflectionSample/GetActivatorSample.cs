using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionSample
{
    class GetActivatorSample
    {
        public void ActivatorSample()
        {
            Object obj;

            // Activator.CreateInstance (String, String) , 這個回傳是 ObjectHandle
            obj = Activator.CreateInstance("TestLibrary", "TestLibrary.Class1").Unwrap(); //原回傳ObjectHandle透過Unwrap轉成Object
            Console.WriteLine(obj.GetType().GetProperty("Text").GetValue(obj).ToString());
            Console.WriteLine("=================================");

            // Activator.CreateInstance(Type), 這個回傳是 Object
            Assembly assembly = Assembly.Load("TestLibrary");
            Type type = assembly.GetType("TestLibrary.Class1");
            obj = Activator.CreateInstance(type);
            Console.WriteLine(obj.GetType().GetProperty("Text").GetValue(obj).ToString());
            Console.WriteLine("=================================");

            //  Activator.CreateInstance(Type, Object[]), 這個回傳是 Object，並且建立個體時，會指派你提供的物件
            obj = Activator.CreateInstance(type, new Object[] { "ABC" });
            Console.WriteLine(obj.GetType().GetProperty("Text").GetValue(obj).ToString());
            Console.WriteLine("=================================");

            Type type2 = assembly.GetType("TestLibrary.Class2");
            Object obj2 = Activator.CreateInstance(type2,true); //建立執行個體，並且執行建構值
            Console.WriteLine(obj2.GetType().GetProperty("Text").GetValue(obj2).ToString());
            Console.WriteLine("=================================");
        }
    }
}
