using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDo5 toDo = new ToDo5();
            Console.WriteLine($"Helloword!! {toDo.Show("Corn")}");

            ToDo2 toDo2 = new ToDo2();
            Console.WriteLine($"Helloword {toDo2.Show("Corn")}!! You Have {toDo2.Add(2, 3)} Apples And You Lost 2 Apples, Then You Have {toDo2.Sub(5,2)} Apples");

            //明確實作介面的成員必須在變數型別為此介面型別時才能呼叫
            InterfaceTest1 toDo5 = new ToDo5(); //明確實作InterfaceTest1的ToDo3 Object
            Console.WriteLine($"Helloword {toDo5.Show("Corn")}!! You Have {toDo5.Add(2, 3)} Apples, Right");
            InterfaceTest2 toDo6 = new ToDo5(); //明確實作InterfaceTest1的ToDo3 Object
            Console.WriteLine($"Helloword {toDo6.Show("Corn")}!! You Have {toDo6.Sub(5, 3)} Apples, Right");

            Console.ReadKey();
        }
    }
}
