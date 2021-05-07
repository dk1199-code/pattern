using System;

namespace array
{ 

    class values
    {
        public void val()
        {
         int[] value =new int[5];
        
        for (int i=0;i<5;i++)
        {
            value[i]=Convert.ToInt32(Console.ReadLine());
        }

          int min=value[1];

          for(int i=0;i<5;i++)
          {
              if(min > value[i])
              {
                  min=value[i];
              }
          }

          Console.WriteLine("The minimum number is"+min);

          for(int i=0;i<5;i++)
          {
              for(int j=i+1;j<5;j++)
              {
                  if(value[j]<value[i])
                  {
                      int value3=value[j];
                      value[j]=value[i];
                      value[i]=value3;
                  }
              }
          }
          Console.WriteLine("The values arranged in assending order are" );
          for(int i=0;i<5;i++)
          {
              Console.Write( +value[i] );
          }
          
        }

        public void maxe(int[] num)
        {
            int max;
            max=num[0];
            for(int i=0;i<5;i++)
          {
              if(max < num[i])
              {
                  max=num[i];
              }
          }
           Console.WriteLine("The maximum number is"+max);

        }
        

    }

    class Program:values
    {
        static void Main(string[] args)
        {
            int[] value2={1,2,3,4,5};
            values obj=new values();
            obj.val();
            obj.maxe(value2);
        }
    }
}
