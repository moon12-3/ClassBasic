using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        class Math
        {
            public static int abs(int i) { return 0; }
        }

        static void Main(string[] args)
        {
            Math.abs(-3);

            OtherClass oc = new OtherClass();

            Console.WriteLine("Hello World!");

            List<Student> list = new List<Student>()
            {
                new Student(){ name = "문채영", grade = 1 },
                new Student(){ name = "김태연", grade = 2 },
                new Student(){ name = "김하늘", grade = 3 },
                new Student(){ name = "박나경", grade = 4 },
                new Student(){ name = "장시우", grade = 1 },
                new Student(){ name = "이연우", grade = 2 },
            };

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------");
            /*
            foreach (var item in list)
            {
                if(item.grade > 1)
                {
                    list.Remove(item);
                }
            }*/
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i].grade > 1)
                {
                    list.RemoveAt(i);
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


        }

        class ThirdClass
        {

        }
    }

    class SecondClass
    {

    }
}