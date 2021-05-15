using System;
using task2;

namespace Task
{
    public class  class1
    {
       protected int val1=10,calc;
        public virtual void base_method()
        {
           
           calc =val1+5;
           Console.WriteLine(calc);

        
        }
        public void base_method(int x)
        {
            x=val1*x;
            Console.WriteLine(x);
        }
    }

     public class class2:class1
    {
        public int value;
        public override void base_method()
        {
            calc=val1-5;
            Console.WriteLine(calc);
        }
         public static class2 operator ++(class2 c)
         {
             class2 ob50=new class2();
             ob50.value = 200+200;
             Console.WriteLine(ob50.value);
             return (ob50);
         }
    }
    class Program
    {
        static void Main(string[] args)
        {
            class2 ob1= new class2();
            ob1.base_method();
            ob1.base_method(20);
            class4 ob2=new class4();
            ob2.animal();
            class5 ob3=new class5();
            int n=ob3.method_2();
            Console.WriteLine(n);
            class2 ob20=new class2();
            ob20++;
        }
    }
}
