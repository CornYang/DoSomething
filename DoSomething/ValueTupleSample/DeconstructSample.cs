using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTupleSample
{
    /// <summary>
    /// 「分解式」（deconstructor）的方法
    /// ▪ Method name 一定是 Deconstruct
    /// ▪ 回傳宣告一定是 void
    /// ▪ 參數必定為 out 宣告
    /// </summary>
    class DeconstructSample
    {
        public static void GetFunc()
        {
            BMI bmi = new BMI()
            {
                Height = 175,
                Weight = 70
            };
            (double x, double y) = bmi;
            Console.WriteLine($"身高 : {bmi.Height}, 體重 : {bmi.Weight}");

            (new BMI() { Height = 175, Weight = 70 }).Deconstruct2(out double h, out double w);
            Console.WriteLine($"身高 : {h}, 體重 : {w}");

            (new BMI() { Height = 1.75, Weight = 70 }).Deconstruct2(out double h2, out double w2, out double b);
            Console.WriteLine($"身高 : {h2}, 體重 : {w2} 且BMI計算為 {b}");
        }
    }

    public class BMI
    {
        public string Name { get; set; }
        public double CalBMI { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public void Deconstruct(out double h, out double w)
        {
            h = this.Height;
            w = this.Weight;
        }
    }

    /// <summary>
    /// Extension Method
    /// 必須放在一個 static 類別中
    /// 必須是 static method
    /// </summary>
    public static class DeconstructExtension
    {
        /// <summary>
        /// </summary>
        /// <param name="bmi"></param>
        /// <param name="h"></param>
        /// <param name="w"></param>
        public static void Deconstruct2(this BMI bmi, out double h, out double w)
        {
            h = bmi.Height;
            w = bmi.Weight;
        }

        /// <summary>
        /// Extension多載
        /// </summary>
        /// <param name="bmi"></param>
        /// <param name="h"></param>
        /// <param name="w"></param>
        /// <param name="b"></param>
        public static void Deconstruct2(this BMI bmi, out double h, out double w, out double b)
        {
            h = bmi.Height;
            w = bmi.Weight;
            b = (bmi.Height * bmi.Height) / bmi.Weight;
        }
    }
}
