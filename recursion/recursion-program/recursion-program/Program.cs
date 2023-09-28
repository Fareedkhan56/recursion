using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion_program
{
    internal class Program
    {
        int num = 15;
        int result = 1;
        int recursion()
        {
            if (num == 0)
            {
                return 1;
            }
            result = result*num;
            num--;
            recursion();
            return result;
        }
        //int num = 5;
        //int result = 1;
        //int factorial()
        //{
        //    if(num == 0)
        //    {
        //        return 1;
        //    }

        //    result = result*num;
        //    num--;
        //    factorial();
        //    return result;
        //}
        
        //void recursion()
        //{
        //    int num = 1;

        //    if (num == 100)
        //    {
        //        return;
        //    }
        //    Console.WriteLine( num);
        //    num++;
        //    recursion();
        //}
        static void Main(string[] args)
        {
            //double userNum = Convert.ToInt64(Console.ReadLine());

            //if (userNum >= 1 && userNum <= 100000 ) 
            //{
                Program obj = new Program();
                //obj.recursion();
                //int factorial = obj.factorial();
                //Console.WriteLine(factorial);
                int mainResult = obj.recursion();
                Console.WriteLine(mainResult);

               Console.ReadLine();
            //}
        }
    }
}
