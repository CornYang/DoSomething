using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionSample
{
    class GetReflectionSample
    {
        public Object obj01 = Assembly.Load("TestLibrary").CreateInstance("TestLibrary.Class1");
        public MemberInfo[] members;
        public MethodInfo[] methods;
        public PropertyInfo[] properties;

        public void DisplayReflection()
        {
            Sample01();
            Sample02();
            Sample03();
            Sample04();
        }

        public void Show(MemberInfo[] members)
        {
            foreach (var member in members)
            {
                Console.WriteLine($"{member.MemberType.ToString()} :  {member.Name}");
            }
        }

        public void Show(MethodInfo[] methods)
        {
            foreach (var method in methods)
            {
                Console.WriteLine(method.Name + ":" + method.ReflectedType.ToString());
            }
        }

        public void Show(PropertyInfo[] propertites)
        {
            foreach (var property in propertites)
            {
                Console.WriteLine(property.Name + ":" + property.ReflectedType.ToString());
            }
        }

        public void Show(Type[] types)
        {
            foreach (var type in types)
            {
                Console.WriteLine(type.Name);
            }
        }

        /// <summary>
        /// 反射找成員
        /// </summary>
        public void Sample01()
        {
            members = obj01.GetType().GetMembers();
            Console.WriteLine("=============> GetMembers()");
            Show(members);

            Console.WriteLine();
            Console.WriteLine("=============> GetMembers() BindingFlag");
            members = obj01.GetType().GetMembers(BindingFlags.Instance | BindingFlags.NonPublic);
            Show(members);

            Console.WriteLine();
            Console.WriteLine("=============> GetMember(PublicShow)");
            members = obj01.GetType().GetMember("PublicShow");
            Show(members);
            Console.WriteLine();
        }

        /// <summary>
        /// 反射找方法(封裝的練習)
        /// </summary>
        public void Sample02()
        {
            Console.WriteLine("=============> GetMethods()"); //無預設參數，所以會找出Public的方法
            methods = obj01.GetType().GetMethods(); //無參數預設為 BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static
            Show(methods);

            Console.WriteLine();
            Console.WriteLine("=============> Invoke Function");
            //執行方法
            Console.WriteLine("-------Invoke PublicShow-------");
            MethodInfo method = methods.FirstOrDefault(x => x.Name == "PublicShow");
            method.Invoke(obj01, null);
            Console.WriteLine();
            Console.WriteLine("-------Invoke PublicShow overloading-------");
            method = methods.FirstOrDefault(x => x.Name == "PublicShow" && x.GetParameters().Count() == 2);
            method.Invoke(obj01, new object[] { "ABC", 7});
            Console.WriteLine();

            Console.WriteLine("=============> GetMethods() BindingFlag"); //這邊有指定要找出Private的方法
            methods = obj01.GetType().GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            Show(methods);
            Console.WriteLine();

            //執行方法
            Console.WriteLine("=============> Invoke Function");
            Console.WriteLine("-------Invoke PrivateShow-------");
            method = methods.FirstOrDefault(x => x.Name == "PrivateShow");
            method.Invoke(obj01, null);
            Console.WriteLine();

            Console.WriteLine("=============> GetMethods() BindingFlag"); //這邊指定找出Protected方法，但只單一個要注意GetMethod沒有"s"
            method = obj01.GetType().GetMethod("ProtectedShow", BindingFlags.Instance | BindingFlags.NonPublic);
            Console.WriteLine($"{method.Name}");
            Console.WriteLine();

            //原本上面都是使用methos去物件裡面取得，然後用methods找要用的方法，這裡直接從物件取得並執行方法
            Console.WriteLine("=============> GetMethod() and Invoke");
            Type[] types = new Type[] { typeof(String), typeof(int)};
            method = obj01.GetType().GetMethod("PublicShow", types);
            method.Invoke(obj01, new object[] { "abc" , 2});
            Console.WriteLine();
        }

        /// <summary>
        /// 反射找屬性
        /// </summary>
        public void Sample03()
        {
            Console.WriteLine("=============> GetProperties()");
            properties = obj01.GetType().GetProperties();
            Show(properties);
            Console.WriteLine();

            Console.WriteLine("=============> GetProperties() BindingFlag");
            properties = obj01.GetType().GetProperties(BindingFlags.Instance | BindingFlags.NonPublic);
            Show(properties);
            Console.WriteLine();

            PropertyInfo property = obj01.GetType().GetProperty("Str", BindingFlags.Instance | BindingFlags.NonPublic);
            //PropertyInfo property = properties.FirstOrDefault(x => x.Name == "Str");  也可以用這個方法
            Console.WriteLine("屬性原來的值 :" + property.GetValue(obj01).ToString());
            property.SetValue(obj01, "用反射更改了值");
            Console.WriteLine("屬性更改後的值 :" + property.GetValue(obj01).ToString());
            Console.WriteLine();
        }

        public void Sample04()
        {
            Console.WriteLine("=============> GetInterfaces()");
            Type[] types = obj01.GetType().GetInterfaces();
            Show(types);
            Console.WriteLine();

            Console.WriteLine("=============> GetInterface()");
            Type type = obj01.GetType().GetInterface("itext", true); //後面是決定是否前面的字串不分大小寫
            type.GetMethods()[0].Invoke(obj01, null);
        }
    }
}
