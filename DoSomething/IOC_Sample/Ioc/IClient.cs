using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC_Sample.Ioc
{
    public interface IClient
    {
        void Do();
    }

    internal class ClientClass : IClient
    {
        public void Do()
        {
            Console.WriteLine("Do");
        }
    }

    internal class ClientClass2 : IClient
    {
        public void Do()
        {
            Console.WriteLine("Do by Factory");
        }
    }

    internal class ClientFactory
    {
        public IClient DobyFactory() => new ClientClass2();
    }
}
