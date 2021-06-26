using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionSample
{
    class UseReflectionSample
    {
        static T MappingModel<T>(Object model)
        {

        }
    }


    public class Model
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
    }

    public class ViewModel
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
