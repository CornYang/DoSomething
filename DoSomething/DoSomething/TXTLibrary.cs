using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static System.Console;

namespace DoSomething
{
    class TXTLibrary
    {
        public ValueTuple<bool, string> ReadTXT(string path) // path or filename
        {
            try
            {
                // .NET CORE 編碼請參考: https://marcus116.blogspot.com/2019/03/netcore-aspnet-core-using-encoding-big5.html
                using (StreamReader reader = new StreamReader(path))
                {
                    string content = string.Empty;
                    while ((content = reader.ReadLine()) != null)
                    {
                        WriteLine(content);
                    }

                    return (true, "讀取成功");
                }
            }
            catch (Exception ex)
            {
                return (false, $"讀取失敗 : {ex.ToString()}");
            }
        }

        public ValueTuple<bool, string> WriteTXT(string path, string content) // path or filename
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(content);
                }

                return (true, "寫入成功");
            }
            catch (Exception ex)
            {
                return (false, $"寫入失敗 : {ex.ToString()}");
            }
        }
    }
}
