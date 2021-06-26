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
    /// 使用 AppDomain 動態載入組件
    /// </summary>
    public class GetAppDomain
    {
        public static Assembly[] assemblies;
        public GetAppDomain()
        {
            assemblies = AppDomain.CurrentDomain.GetAssemblies();
        }

        public  void AppDisplay()
        {
            foreach (var item in assemblies)
            {
                Console.WriteLine($"組件名稱 : {item.FullName}");
                Console.WriteLine($"組件位置 : {item.Location}");
                Console.WriteLine("========================================");
            }
        }

        public Assembly OtherApp()
        {
            //// Load 多載1 : 使用 組件名稱字串
            //// 這邊指定要載入的元件dll的名稱就好，它會去專案裡面收尋
            //Assembly assembly1 = AppDomain.CurrentDomain.Load("TestLibrary");
            //return assembly1;

            // Load 多載 2: 使用 AssembllyName Class
            // 這邊指定要載入的元件dll的名稱就好，它會去專案裡面收尋
            AssemblyName assemblyName = new AssemblyName("TestLibrary");
            Assembly assembly2 = AppDomain.CurrentDomain.Load(assemblyName);
            return assembly2;

            ////Load 多載 3: 使用 byte[], 這個方式沒有 Location 資訊
            //var path = "TestLibrary.dll";
            //if (File.Exists(path))
            //{
            //    var bytes = File.ReadAllBytes(path);
            //    Assembly assembly3 = AppDomain.CurrentDomain.Load(bytes);
            //    return assembly3;
            //}
        }

        public void AppDisplay(Assembly assemblies)
        {
            Console.WriteLine($"組件名稱 : {assemblies.FullName}");
            Console.WriteLine($"組件位置 : {assemblies.Location}");
        }


        /// <summary>
        /// 使用反射建立執行個體(CreateInstanceFrom & CreateInstance & CreateInstanceAndUnwrap)
        /// 使用反射建立執行個體要留意其回傳值型別是 ObjectHandle 或Object
        /// </summary>
        public void GetOtherAppInstancse()
        {
            //CreateInstanceFrom為指定組件檔案
            var Handle01 = AppDomain.CurrentDomain.CreateInstanceFrom("TestLibrary.dll", "TestLibrary.Class1"); //Handle01型別為ObjectHandle
            var o1 = Handle01.Unwrap(); //o1型別為Object
            Console.WriteLine($"{o1.GetType().Name}");

            //CreateInstance為指定組件名稱，它會去專案收尋
            var Handle02 = AppDomain.CurrentDomain.CreateInstance("TestLibrary", "TestLibrary.Class1");
            var o2 = Handle02.Unwrap(); 
            Console.WriteLine($"{o2.GetType().Name}");

            //反射去執行個體，並且直接回傳物件
            var o3 = AppDomain.CurrentDomain.CreateInstanceAndUnwrap("TestLibrary", "TestLibrary.Class1");
            Console.WriteLine($"{o3.GetType().Name}");

        }
    }
}
