using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSample
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass generic = new GenericClass();
            generic.Show<string>("泛型練習"); //可寫成generic.Show("泛型練習");
            generic.Show<double>(29.0); // 可寫成generic.Show(29.0);
            Console.WriteLine($"Hello {generic.Show2("Corn")}!! Your Age is {generic.Show2(29)}");
            generic.Show3("泛型練習", 29.0);

            NewClass<string> newClass = new NewClass<string>(); //若執行泛型類別個體的話，要先提供類型給泛型知道
            newClass.Display("Corn"); //執行個體裡面的方法，因為上面有先提供類型給個體知道，所以必須按照給的規定去執行方法，不能隨意改類型
            Console.WriteLine($"{newClass.GetValue("Helloword!!")}");
            Console.WriteLine($"{newClass.GetValueByFunc("Helloword Func!!")}");

            Console.ReadKey();
        }
    }
}
