using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    interface IWorker
    {   
        void work(); 
    }
    interface IEat
    {
        void eat();
    }
    interface IGetSalary
    {
        void getSalary();
    }

    class Manager : IWorker, IGetSalary, IEat
    {
        public void eat()
        {
            throw new NotImplementedException();
        }

        public void getSalary()
        {
            throw new NotImplementedException();
        }

        public void work()
        {
            throw new NotImplementedException();
        }
    }
    class Worker : IWorker,IEat, IGetSalary
    {
        public void eat()
        {
            throw new NotImplementedException();
        }

        public void getSalary()
        {
            throw new NotImplementedException();
        }

        public void work()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : IWorker
    {
        public void work()
        {
            throw new NotImplementedException();
        }
    }
}
