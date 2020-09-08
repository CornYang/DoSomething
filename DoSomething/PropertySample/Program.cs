using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertySample
{
    class Program
    {
        static void Main(string[] args)
        {
            //CS2.0
            CS20Property cS20Property = new CS20Property();
            cS20Property.X = 5;
            var cs20 = (cS20Property.X + 5, cS20Property.Z + 10);
            Console.WriteLine($"{cs20.Item1} , {cs20.Item2}");

            CS30Property cS30Property = new CS30Property();
            //cS30Property.Y = 100;  ---> 因為該欄位只有get並無set，所以只能做讀取的動作
            //cS30Property.Z = 50; ---> 因為該欄位只有get而set為private，所以外面只能做讀取的動作(目前的值，為建構式給的初始值)
            Console.WriteLine(cS30Property.Z);

            CS60Property cS60Property = new CS60Property();
            var cs60 = (cS60Property.X, cS60Property.Y, cS60Property.Z);
            Console.WriteLine($"{cs60.X} , {cs60.Y} , {cs60.Z}");
            cS60Property.FirstName = "Yang";
            cS60Property.LastName = "Corn";
            Console.WriteLine($"{cS60Property.FullName}");

            CS70Property cS70Property = new CS70Property();
            cS70Property.Age = 3;
            cS70Property.FirstName = "Yang";
            cS70Property.LastName = "Corn";
            var cs70 = (cS70Property.FirstName, cS70Property.LastName);
            Console.WriteLine($"Your Name is {cs70.FirstName} {cs70.LastName} and Age is {cS70Property.Age}");

            Console.ReadKey();
        }
    }
    
    /// <summary>
    /// 原始狀態
    /// </summary>
    public class class1
    {
        private int _x = 0;
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
    }

    /// <summary>
    /// 實際上GET&SET的轉換樣式
    /// </summary>
    public class class2
    {
        private int _x = 0;

        public int GetX()
        {
            return _x;
        }
        public void SetX(int value)
        {
            _x = value;
        }
    }

    public class CS20Property
    {
        private int _x;
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        private int _y;
        public int Y
        {
            get { return _y; }
        }

        private int _z;
        public int Z
        {
            get { return _z; }
            private set { _z = value; }
        }
    }

    public class CS30Property
    {
        public int X { get; set; }

        private int _y;
        public int Y
        {
            get { return _y; }
        }

        public int Z
        { get; private set; }

        public CS30Property()
        {
            Z = 888;
        }
    }

    public class CS60Property
    {
        public int X { get; set; } = 10;

        public int Y { get; }

        public int Z { get; } = 1999;
        public string FirstName { get; set; }

        public string LastName { get; set; }

        //expression-bodied function member
        //利用Lambada表達式預設FullName為FirstName + LastName
        public string FullName => $"{FirstName}  {LastName}";


        // 無法自動實作唯寫屬性        
        //public int Z { set; }

        public CS60Property()
        {
            Y = 9;
        }
    }

    public class CS70Property 
    {
        private string firstName;
        public string FirstName
        {
            get => firstName;
            set => firstName = value ?? string.Empty;
            //運算子 ?? 不是 null，會傳回其左方運算元的值；否則它會評估右方運算元，並傳回其結果。 如果左側運算元評估為非 Null，則 ?? 運算子不會評估右側運算元。
        }

        public string LastName { get; set; }

        private int age;
        public int Age 
        { 
            get => age;
            //set => age = value + 5;
            set => age = value > 5 ? value + 5 : value; //使用三元不等式 : https://dotblogs.com.tw/blackie1019/2014/05/05/144968
        }
    }
}
