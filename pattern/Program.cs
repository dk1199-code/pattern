using System;
namespace pattern
{

    class pattern
    {
        public void star()
        {
        int i,j;
        int n= Convert.ToInt32 (Console.ReadLine()); //type conversion is done
        for(i=n;i>0;i--)
          {
            for(j=1;j<=i;j++)
            {
                if(j==2)
                {
                    continue;
                }
                Console.Write(j);
            }
            Console.WriteLine();

          }
          Console.WriteLine();

          if(n<5) // TO check weather is number is greate than 5 or lesser than 5
          {
              Console.WriteLine("N is less than 5");
          }
          else
          {
              Console.WriteLine("N is greater than 5");
          }
          Console.WriteLine();

          switch(n)
          {
              case 1:
              Console.WriteLine("The entered number is one");
              break;
              case 2:
              Console.WriteLine("The entered number is Two");
              break;
               case 3:
              Console.WriteLine("The entered number is Three");
              break;
               case 4:
              Console.WriteLine("The entered number is Four");
              break;
               case 5:
              Console.WriteLine("The entered number is Five");
              break;
          }
        }

    }

    class parent
    {
    
         protected int  value1= Convert.ToInt32 (Console.ReadLine());
         protected int  value2= Convert.ToInt32 (Console.ReadLine());
        
    }
    class child : parent
    {
        public void run()
        {
        int value3;
        value3 = value1+value2;
        Console.WriteLine(value3);
        }
      
    }
    class Program
    {
        static void Main(string[] args)
        {
            pattern obj= new pattern();
            obj.star();
            child obj2=new child();
            obj2.run();
        }
    }
}
