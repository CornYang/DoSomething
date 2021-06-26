using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionSample
{
    /// <summary>
    /// 本專案有參考老師提供的TestLibrary(如果想看詳情在去專案內容找老師提供的)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("-------------------------AppDomainSample----------------------------");
            //GetAppDomain getAppDomain = new GetAppDomain();
            //getAppDomain.AppDisplay();
            //Console.WriteLine("-------------------------------------------------------------------------");

            //getAppDomain.AppDisplay(getAppDomain.OtherApp());
            //Console.WriteLine("-------------------------------------------------------------------------");

            //getAppDomain.GetOtherAppInstancse();
            //Console.WriteLine("-------------------------------------------------------------------------");

            //Console.WriteLine("-------------------------AssemblySample----------------------------");
            //GetAssemblySample getAssemblySample = new GetAssemblySample();
            //getAssemblySample.AssemblySample();
            //getAssemblySample.GetAssemblyInfo();
            //getAssemblySample.GetAssemblyInstance();
            //Console.WriteLine("-------------------------------------------------------------------------");

            //Console.WriteLine("-------------------------ActivatorSample----------------------------");
            //GetActivatorSample getActivatorSample = new GetActivatorSample();
            //getActivatorSample.ActivatorSample();
            //Console.WriteLine("-------------------------------------------------------------------------");

            //Console.WriteLine("-------------------------GenericReflectionSample----------------------------");
            //GetGenericReflectionSample getGenericReflectionSample = new GetGenericReflectionSample();
            //getGenericReflectionSample.GenericReflection();
            //Console.WriteLine("-------------------------------------------------------------------------");

            Console.WriteLine("-------------------------NormalReflectionSample----------------------------");
            GetReflectionSample getReflectionSample = new GetReflectionSample();
            getReflectionSample.DisplayReflection();

            Console.ReadKey();
        }
    }
}
