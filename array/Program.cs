using System;

namespace array
{ 

    class values
    {
        public void val()
        {
         int[] value =new int[5];// declaring array 
        
        for (int i=0;i<5;i++)
        {
            value[i]=Convert.ToInt32(Console.ReadLine());// getting array value
        }

          int min=value[1]; // finding minimum value

          for(int i=0;i<5;i++)
          {
              if(min > value[i])
              {
                  min=value[i];
              }
          }

          Console.WriteLine("The minimum number is"+min);

          for(int i=0;i<5;i++)// Code for arranging the value in accesding order
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
          Console.WriteLine("The values arranged in assending order are" ); // printing the values in accending order
          for(int i=0;i<5;i++)
          {
              Console.Write(value[i]);
          }
          
        }

        public void maxe(int[] num)// function called using parameters to find the max value

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
           Console.WriteLine("\nThe maximum number is"+max);

        }
        
    }

    class Program:values
    {
        static void Main(string[] args)
        {
            int[] value2={1,2,3,4,5};
            values obj=new values();// creating object for the class values
            obj.val();                  // calling function val  to get array values and fing the minimum values and arranging the array in accending order.
            obj.maxe(value2);          // call the function with parameters to find max value
        }
    }
}
