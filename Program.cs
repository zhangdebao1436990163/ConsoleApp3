using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;
namespace calculator
{
    //枚举 常用来约束 或者 规定一个统一的写法 针对共性问题
    //枚举值 = int类型 一版情况是是这样的写法
    public enum Sex { man = 0,woman = 1};
    class Program
    {
        const double error = 1e-6; //精度 用于比较
        static void Main(string[] args)
        {


            string str;

            // 枚举默认能与int转换，这里第一个枚举值默认为0
            int numb1 = Convert.ToInt32(Sex.man);
            Sex sex = (Sex)1;
            str = sex.ToString();
            str = string.Format("这是一个{0}", sex);
            Console.WriteLine("hello word\n");
            Console.WriteLine("请输入数字");
            double numA, numB = 0.0;
            bool transA = double.TryParse(Console.ReadLine(), out numA);
            bool transB = double.TryParse(Console.ReadLine(), out numB);
            double result = GetSum(numA, numB);
            Console.WriteLine("和为{0}",result);
            while (true)
            {
                double num = GetRandom();
                Console.WriteLine(num);
                Console.ReadKey();
                // 休眠2秒钟
                System.Threading.Thread.Sleep(2000);
            }
            Console.ReadKey();
        }

        #region 求和公式
        public static double GetSum(double numA, double numB)
        {
            return numA + numB;
        }
        #endregion
        #region 比较是否大于
        public static bool IsMoreThan(double num, double target)
        {
            return (num - error > target ? true : false);
        }
        #endregion
        #region 比较是否小于
        public static bool IsLessThan(double num, double target)
        {
            return (num  < target - error ? true : false);
        }
        #endregion
        #region 随机数
        public static double  GetRandom( )
        {
            Random random = new Random();
            // 返回数值在1-10
            double num = random.Next(1, 11);
            return num;
        }
        #endregion

    }
}
