using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class NewBaseClass
    {
        public void ShowSomething()
        {
            Console.WriteLine($"Run By NewBaseClass Class");
        }

        public virtual void ShowThing()
        {
            Console.WriteLine($"Run By NewBaseClass Class");
        }
    }

    class NewBaseClass02 : NewBaseClass
    {
        new public void ShowSomething()
        {
            Console.WriteLine($"Run By NewBaseClass02 Class");
        }

        public override void ShowThing()
        {
            Console.WriteLine($"Run By NewBaseClass02 Class");
        }
    }

    class NewBaseClass03 : NewBaseClass02
    {
        new public void ShowThing()
        {
            Console.WriteLine($"Run By NewBaseClass03 Class");
        }
    }
}
