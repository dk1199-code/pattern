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
        public int value;
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
         public int  method_5(int a)
         {
             int value=a;
             return value;

         }
           public int  method_4(int b)
         {
             int value=b;
             return value;

         }
         public static class5 operator ++(class5 c)
         {
             class5 ob50=new class5();
             ob50.value = 200+200;
             Console.WriteLine(ob50.value);
             return ob50;
         }
      
    }
        
}

