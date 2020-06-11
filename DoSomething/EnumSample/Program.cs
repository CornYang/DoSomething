using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumSample
{
    /// <summary>
    /// Enum列舉練習
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Gender gender = Gender.Boy;
            Console.WriteLine(gender.ToString());

            Console.WriteLine(Days.Sun);

            Console.ReadKey();
        }
    }

    public enum Gender { Boy, Girl}
    public enum Days : byte //自訂義
    { Sat = 1, Sun, Mon, Tue, Wed, Thu, Fri }
}
