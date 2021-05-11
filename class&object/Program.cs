using System;

namespace class_object
{
     public class object1
    {
        
        public  object1()
        {
            Console.WriteLine("Default constructor");
            int numbers=25;
            Console.WriteLine(numbers);
        }
        public  void deepak()
        {
            Console.WriteLine("Default constructor");
            int numbers=25;
            Console.WriteLine(numbers);
        }
    }
   public class Program
    {

         public enum Season { sunday, monday, Tuesday, wednesday }    

        static void Main(string[] args)
        {
           object1 object1=new object1();
           object1 object3=new object1();
           object1.deepak();
          Program object2=new Program( 2,'D');
           int x = (int)Season.monday;  
        int y = (int)Season.wednesday;  
        Console.WriteLine("Weekday = "+ x);  
        Console.WriteLine("weekday = "+ y);

        }
        public Program( int a, char b)
        {
            Console.WriteLine(a+"  "+b);
        }

    }
}
