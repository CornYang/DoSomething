using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumSample
{
    /// <summary>
    /// Enum列舉練習
    /// Enum Flag 練習
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {                       
            Gender gender = Gender.Boy;
            Console.WriteLine(gender.ToString());

            Console.WriteLine((byte)Days.Sun);
            Console.WriteLine((Days)1);

            Status status = Status.All;
            Status status1 = Status.Sleep | Status.Run; //為設定Flags(Enum)
            Console.WriteLine($"NAME: {status} , VALUE: {(int)status}");
            Console.WriteLine($"NAME: {status1} , VALUE: {(int)status1}");

            Status_NoFlag noFlag = Status_NoFlag.All;
            Status_NoFlag noFlag1 = Status_NoFlag.Sleep | Status_NoFlag.Run;
            Console.WriteLine($"NAME: {noFlag} , VALUE: {(int)noFlag}");
            Console.WriteLine($"NAME: {noFlag1} , VALUE: {(int)noFlag1}");

            Console.WriteLine("-----------------------------------------------------------------");

            //基本上運用Flags時，會根據你提供的Enum值去做運算，建議用2進位才不會被值給困擾
            var birthday = DAY.Tuesday | DAY.Thursday; // OR的概念(基本上會利用Enum給的值)
            birthday = birthday | DAY.Saturday;
            Console.WriteLine($"Your Birthday maybe on {birthday}");
            birthday = birthday ^ DAY.Saturday ^ DAY.Tuesday; //XOR
            Console.WriteLine($"Your Birthday is absolutely on {birthday}");

            bool checkdate = (birthday & DAY.Thursday) == DAY.Thursday; //AND(檢查兩個是否想等於Thursday)
            Console.WriteLine("Friday {0} Your Birthday!!", checkdate ? "is" : "isn't");

            Console.WriteLine("-----------------------------------------------------------------");

            auth authority = auth.Read | auth.Write;
            Console.WriteLine(authority.ToString());
            Console.WriteLine(Convert.ToInt32(authority));

            if ((authority & auth.Write) == auth.Write)
                Console.WriteLine("有寫入權限");
            else
                Console.WriteLine("無寫入權限");

            Console.WriteLine(authority.HasFlag(auth.Create)); //HasFlag就是判斷Enum裡是否有存在此Flag

            Console.ReadKey();
        } 
    }

    public enum Gender { Boy, Girl}

    //自訂義
    //Enum所允許的型別: byte sbyte short ushort int uint long ulong
    public enum Days : byte
    { Sat = 1, Sun, Mon, Tue, Wed, Thu, Fri }

    //Enum FlagsAttirbute
    [Flags]
    public enum Status 
    {
        None = 0,
        Stop = 1,
        Sleep = 2,
        Eat = 4,
        Run = 8,
        All = None | Stop | Sleep | Eat | Run
    }

    //測試無Enum FlagsAttirbute
    public enum Status_NoFlag
    {
        None = 0,
        Stop = 1,
        Sleep = 2,
        Eat = 4,
        Run = 8,
        All = None | Stop | Sleep | Eat | Run
    }

    [Flags]
    public enum DAY
    {
        Monday = 0, 
        Tuesday = 1, 
        Wednesday = 2, 
        Thursday = 4 , 
        Friday = 8, 
        Saturday = 16, 
        Sunday = 32
    }

    [Flags]
    public enum auth
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Create = 8
    }
}
