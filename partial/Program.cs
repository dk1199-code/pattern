using System;
using class2;

namespace partial
{
  public partial class User
	{
        public string name;
        private int number;
        public User(string a, int b)
    	{
            this.name = a;
            this.number = b;
    	}
	}
    public partial class User
	{
        public void GetUserDetails()
    	{
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID Number: " + number);

    	}
	}
     class properties
    {
        private int number=50;
        public int x
        {
            set
            {
                number *= value ;
            }
            get
            {
                return number;
            }
        }
    }

    
    public class deepak2:deepak
    {
        int a=10;

        public deepak2():base()
        {
            Console.WriteLine("derived class");

        }
    }
    class Program
	{
        static void Main(string[] args)
    	{
            User u = new User("Deepak", 8870944);
        	u.GetUserDetails();
            properties obj = new properties();
            obj.x = 5;
            Console.WriteLine(obj.x);
            obj.x = 50;
            Console.WriteLine(obj.x);
            deepak2 ob1=new deepak2();

        
    	}
	}

}
