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
        }
    }
}
