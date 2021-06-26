using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionSample
{
    /// <summary>
    /// 取得已載入的組件
    /// 使用 Assembly 動態載入組件
    /// </summary>
    class GetAssemblySample
    {
        private Assembly[] assemblies;
        public GetAssemblySample()
        {
            assemblies = AppDomain.CurrentDomain.GetAssemblies();
        }

        private  void AssemblyDisplay(Assembly[] assemblies)
        {
            foreach (var assembly in assemblies)
            {
                Console.WriteLine($"組件名稱 : {assembly.FullName}");
                Console.WriteLine($"組件位置 : {assembly.Location}");
                Console.WriteLine("=================");
            }
        }

        /// <summary>
        /// 使用 Assembly 動態載入組件
        /// </summary>
        public void AssemblySample()
        {
            Assembly assembly01 = Assembly.Load("TestLibrary");

            AssemblyName assemblyName = AssemblyName.GetAssemblyName("TestLibrary.dll");
            Assembly assembly02 = Assembly.Load(assemblyName);

            var path = "TestLibrary.dll";
            if (File.Exists(path))
            {
                var bytes = File.ReadAllBytes(path);
                Assembly assembly03 = Assembly.Load(bytes);
            }

            //使用 LoadFile, 必須是絕對路徑
            var allpath = $@"{Environment.CurrentDirectory}\TestLibrary.dll";
            Assembly assembly04 = Assembly.LoadFile(allpath);

            Assembly assembly05 = Assembly.LoadFrom("TestLibrary.dll");

            assemblies = AppDomain.CurrentDomain.GetAssemblies();
            AssemblyDisplay(assemblies);


            ////這邊因為前面GetAppDomain有新增靜態的Assembly[] 可直接使用
            //GetAppDomain getAppDomain = new GetAppDomain(); //可直接呼叫建構值
            //getAppDomain.AppDisplay();
        }

        /// <summary>
        /// 使用 Assembly 建立執行個體
        /// TypeName String 要使用全名
        /// </summary>
        public void GetAssemblyInstance()
        {
            Assembly assembly01 = Assembly.Load("TestLibrary");
            var Instance = assembly01.CreateInstance("TestLibrary.Class1");
            Console.WriteLine(Instance.GetType().Name);
        }

        /// <summary>
        /// 取得現有組件資訊
        /// </summary>
        public void GetAssemblyInfo()
        {
            Assembly assembly01 = Assembly.GetAssembly(typeof(string)); //透過 typeof 關鍵字來取得 Type 類型
            Console.WriteLine($"System.String 名稱 {assembly01.FullName} ");
            //Console.WriteLine($"System.String 位在 {assembly01.Location} ");

            //因為 Object 包含 GetType 方法，所以所有類型都包含這個方法。
            //var types = assembly01.GetTypes(); 
            //foreach(var item in types)
            //{
            //    Console.WriteLine($"Type Name : {item.Name}");
            //}
        }
    }
}
