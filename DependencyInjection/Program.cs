using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    //dependency injection -
    // 1, - client class - depend on service class
    //2 - service class - prvide service to client
    //3 - injector class - inject oject of service class into client class


    //service class
    interface MyService
    {
        void GetFirstName();
        void GetLastName();
    }

    //service provider class
    internal class ServiceClass : MyService
    {
       public void GetFirstName()
        {
            Console.WriteLine("First Name");
        }
        public void GetLastName()
        {
            Console.WriteLine("Last Name");
        }
    }

    //client class
    internal class Client 
    {
        private MyService obj;
        public Client(MyService obj)
        {
            this.obj = obj;
            this.obj.GetFirstName();
            this.obj.GetLastName();
        }
       
    }

    //injector class
    internal class Program
    {
        static void Main(string[] args)
        {
            Client obj = new Client(new ServiceClass()); ///inject service class into client class 
           // obj.

            Console.ReadLine();
        }

        
    } 
}

