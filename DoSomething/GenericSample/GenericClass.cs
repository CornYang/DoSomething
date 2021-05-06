using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSample
{
    class GenericClass
    {
        public  void Show<T>(T value)
        {
            Console.WriteLine(value);
        }

        public T Show2<T>(T value)
        {
            return value;
        }

        public void Show3<T,R>(T val, R val2)
        {
            Console.WriteLine($"val1 = {val}, val2 = {val2}");
        }
    }

    interface GenericInterface<T,R>
    {
        T GetValue(T val);
    }

    //如果要時做介面，必須先確認該介面有幾個類型，看要提供幾個類型
    class NewClass<R> : GenericInterface<R,double>
    {
        public void Display(R val)
        {
            Console.WriteLine(val);
        }

        public R GetValue(R val) => val;

        public R GetValueByFunc(R val) => GenericFunc(val);

        Func<R, R> GenericFunc = (x) =>
        {
            return x;
        };
    }
}
