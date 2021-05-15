using System;
namespace task2
{
   abstract class class3
    {

        public abstract void animal();

        public void name()
        {
            Console.WriteLine("Deepak");
        }
        
    }
    class class4:class3
    {
        public override void animal()
        {
            Console.WriteLine("Lion");
        }
        
    }

    public class class5
    {
         private int method_1()
         {
             int value1=10;
             value1 *=value1;
             return value1;

         }
         public int method_2()
         {
             int value2=20;
             int value3= value2+method_1();
             return value3;
         }
        
    }
        
}

