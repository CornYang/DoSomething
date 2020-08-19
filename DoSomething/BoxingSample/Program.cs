using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingSample
{
    /// <summary>
    /// 練習Boxing & Unboxing
    /// Box 和 Unbox 處理是會耗費大量運算資源的處理序
    /// 在 .NET 中將型別區分為 Value Type (實質型別) 與 Reference Type (參考型別) ，當產生了一個 Value Type 的變數時，會將此 Value Type 變數值存放於 Stack (堆疊) 中，而如產生的是一個 Reference Type 物件時會將此物件值存放於 Heap (堆積) 中，在發生 Boxing 處理時是因為將實質型別轉換成 object 型別。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //先宣告一個Value Type的變數 i
            int i = 20;

            // 產生一個 object o 物件，將 i 轉換為 o 物件
            // 此時 i 轉換 o 物件時是將 i 變數的值複製一份到 o 物件 Heap 裡的空間，在 i 轉換成 o 時則是進行了隱含式的 Boxing 作業。
            object o = i;

            // UnBoxing 處理則為將 object 型別明確轉換成實質型別時發生
            // 將 o 物件使用明確轉型式轉換成 j 變數後，則會將 o 物件的值複製一份到 j 變數的 Stack 中。
            int j = (int) o;
        }
    }
}
