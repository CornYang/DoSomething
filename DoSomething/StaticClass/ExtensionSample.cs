using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    //擴充方法條件
    // 1. 必須為靜態類別 2. 方法必須為靜態方法 3.參數必須要this去指定帶進來的為原本給的參數
    //擴充方法可以多載，但只有第一個能this前面給的東西(Ex. 下面的第二個AddFive)
    //如果是像第二個多載的方法，第一個變數為前面給的變數呼叫擴充方法;第二個變數為呼叫擴充方法時帶入的變數
    public static class ExtensionSample
    {
        public static int AddFive(this int num) => num + 5;
        public static int AddFive(this int num01, int num02) => num01 + num02 + 5;
    }
}
