using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace DoSomething.Interface
{
    public interface IOCTest
    {
        void Content();
    }

    public class TEST : IOCTest
    {
        public void Content()
        {
            WriteLine("HI, TEST");
        }
    }

    public class TEST2 : IOCTest
    {
        public void Content()
        {
            WriteLine("HI, TEST2");
        }
    }

    public class GetTEST
    {
        public static IOCTest GetContent(string name)
        {
            switch (name)
            {
                case "TEST":
                    return new TEST();
                case "TEST2":
                    return new TEST2();
                default:
                    return null;
            }
        }
    }
}
