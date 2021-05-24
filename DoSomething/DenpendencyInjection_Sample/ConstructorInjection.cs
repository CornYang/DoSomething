using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenpendencyInjection_Sample
{
    /// <summary>
    /// 建構值注入
    /// </summary>
    public interface IEat
    {
        void Eat();
    }

    class ConstructorInjection
    {
        private IEat eat;
        public ConstructorInjection(IEat _eat)
        {
            eat = _eat;
        }

        public void Display()
        {
            eat.Eat();
        }
    }

    public class Apple : IEat
    {
        public void Eat() => Console.WriteLine($"I Eat The Apple Today!! ^^");
    }

    public class Orange : IEat
    {
        public void Eat() => Console.WriteLine($"I Eat The Orange Today!! ^^");
    }
}
