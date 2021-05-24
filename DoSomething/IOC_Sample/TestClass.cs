using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC_Sample
{
    /// <summary>
    /// 從下列第一個程式呼叫可發現，一直在重複Ioc.ClientClass client = new Ioc.ClientClass(); 這段程式，那如果今天要替換實作，這下不就要改一堆程式
    /// 那第二個程式呼叫，就差在如果今天要異動實作方法，我只需要去改ClientFactory就好，不用每個Function都去修改到
    /// </summary>
    class TestClass
    {
        public void Display01()
        {
            Ioc.ClientClass client = new Ioc.ClientClass();
            client.Do();

            Ioc.ClientFactory clientFactory = new Ioc.ClientFactory();
            clientFactory.DobyFactory();
        }

        public void Display02()
        {
            Ioc.ClientClass client = new Ioc.ClientClass();
            client.Do();

            Ioc.ClientFactory clientFactory = new Ioc.ClientFactory();
            clientFactory.DobyFactory();
        }

        public void Display03()
        {
            Ioc.ClientClass client = new Ioc.ClientClass();
            client.Do();

            Ioc.ClientFactory clientFactory = new Ioc.ClientFactory();
            clientFactory.DobyFactory();
        }

        public void Display04()
        {
            Ioc.ClientClass client = new Ioc.ClientClass();
            client.Do();

            Ioc.ClientFactory clientFactory = new Ioc.ClientFactory();
            clientFactory.DobyFactory();
        }

        public void Display05()
        {
            Ioc.ClientClass client = new Ioc.ClientClass();
            client.Do();

            Ioc.ClientFactory clientFactory = new Ioc.ClientFactory();
            clientFactory.DobyFactory();
        }
    }
}
