using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main_part_of_second_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //часть 2 -----------------------------------------------------------------------------------------------
            //int i = 0, j = 1, k = 2;
            
            //2.1
            //++(++i);                  //Подобного рода операции не являются корректными ввиду того, что компилятор в данном случае не
            //--(i++);                  //распознаёт операции инкрементирования и декрементирования

            //2.2
            //!(-i))                    //Операция логического отрицания не ожет быть применена к числовым типам       

            //2.3
            //i = -4;                   //252 получается потому,что тип данных byte служит для работы с беззнаковыми числами
            //byte x = (byte)i;
            //Console.WriteLine(x);

            //2.4
            //Console.WriteLine(1.0/0); //бесконечность. 1.0 - тип Double
            //Console.WriteLine(1/0);   //ошибка. попытка деления 32-разрядного типа int на 0
            
            //2.5
            //i<j<k                     //ошибка записи выражения. правильно: i<j && j<k
            //true<false                //операции сравнения не могут применяться к типу bool

            //2.6
            //int a = 10, b = 3;
            //bool t = (a >= b && a != 2 * b || a < 0);
            //Console.WriteLine(t);     //t -> true

            //2.7
            //int x = 22;
            //string str = (x > 9 && x < 100) ? "Да" : "Нет";
            //Console.WriteLine(str);

            //2.8
            //int a=10, b=3;
            //int t=(a++)-b;
            //b += t*a;
            //Console.WriteLine(t);     //7
            //Console.WriteLine(b);     //80

            //Console.WriteLine(i);

            //часть 3 -----------------------------------------------------------------------------------------------------

            /*  3.1
            Console.Write("x = ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("y = ");
            float y = float.Parse(Console.ReadLine());
            if (x > y )
                Console.WriteLine("ax = "+x);
            else
                Console.WriteLine("max = "+y);
            */

            /*  3.2
            int Ball=0;
            Console.Write("x = ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("y = ");
            float y = float.Parse(Console.ReadLine());
            if (x * x + y * y <=1)
                Ball = 10;	            //окружность с радиусом 1
            else
                if (x * x + y * y <= 4)
                    Ball = 5;	        //окружность с радиусом 2
                else
                    if (x * x + y * y <= 9)
                        Ball = 1;       //окружность с радиусом 3
            Console.WriteLine("Ball= "+ Ball);
            */

            /*  3.3
            Console.Write("OPER = ");
            char oper = char.Parse(Console.ReadLine());
            bool ok = true;
            Console.Write("A = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("B = ");            
            int b = int.Parse(Console.ReadLine());
            float res = 0;
            switch (oper)
            {
                case '+': res = a + b; goto case '-';// break;	//1
                case '-': res = a - b; break;
                case '*': res = a * b; break;
                case ':': case'/':
                if(b != 0)
                //{
                    res = (float)a / b; break;
                //}
            //else
            //        goto default;
            default: ok = false; break;        
            }
            if(ok)
                Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, res);
            else
                Console.WriteLine("error");
            */

            /*  3.4
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            int i = n;
            while (i >= 1)                 
            {
                if(i%2 != 0)
                    Console.Write(" " + i);
                --i;
            }
            Console.Write("\n");
            */

            /*  3.5
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            int i = n;
            do
            {
                if (i % 2 == 0)
                    Console.Write(" " + i);
                --i;
            } while (i >= 1);
            Console.Write("\n");
            */

            /*  3.6
           Console.Write("N = ");
           int n = int.Parse(Console.ReadLine());
           for(int i=n; i>=1; i--)
           {
            Console.Write(" " + i*i);
           }
           Console.Write("\n");
           */

             /*  3.7
            Console.Write("M = ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= m; ++i, Console.WriteLine())     //1
                for (int j=1; j<=n; ++j)
                    Console.Write("\t" + i*j); 
            */


        }
    }
}
