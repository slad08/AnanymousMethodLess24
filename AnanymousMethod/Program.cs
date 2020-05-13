using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnanymousMethod
{
    class Program
    {
        public delegate int MyHandler(int a);
        static void Main(string[] args)
        {
            var lesson = new Lesson("Программирование C#");

            lesson.Started += (sender, date) =>
            {
                Console.WriteLine(sender);
                Console.WriteLine(date);
            };

            lesson.Start();

            var list = new List<int>();

          
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }

            var res = list.Aggregate((x, y) => x + y);

            Console.WriteLine(res);

            var result1 = Agr(list, delegate (int i)
            {
                var r = i * i;
                Console.WriteLine(r);
                return r;
            });

            var result2 = Agr(list, Method);

            var result3 = Agr(list, x => x * x * x * x);
            
            
            
            if (int.TryParse(Console.ReadLine(),out int result));
            {
                MyHandler handler = delegate (int i)
                {
                    var r = i * i;
                    Console.WriteLine(r); ;
                    return r;
                    //Реализаци анонимного метода
                };
                //handler += Method;
                handler(result);
                handler(88);


                MyHandler lambdaHandler = (i) => {
                    //return i * i
                    var r = i * i * i;
                    Console.WriteLine(r); ;
                    return r;
                };



                lambdaHandler(99);

            }

            Console.ReadLine();

        }

        public static int Agr(List<int> list, MyHandler myHandler)
        {
            int result = 0;
            foreach (var item in list)
            {
                result += myHandler(item);
            }
            return result;
        }

        public static int  Method(int i)
        {
            var r = i * i * i; 
            Console.WriteLine(r); ;
            return r;
        }
    
    }
}
