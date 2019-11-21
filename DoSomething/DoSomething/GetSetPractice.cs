using System;
using System.Collections.Generic;
using System.Text;

namespace DoSomething
{
    class GetSetPractice
    {
        private int num = 100;
        public int TEST01 
        {
            get { return num; }
            set { num = value; } 
        }

        public int TEST02 
        {
            get { return num; }
        }

        public int TEST03
        {
            set { num = value; }
        }
    }
}
