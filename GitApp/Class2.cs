using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDI
{
    public class Units
    {
        public long KmToM(int Km)
        {
            return Km * 1000;
        }
    }
    interface IWorker
    {
        void DoWork();
    }
    class Worker : IWorker  //Low Level Class
    {
        public void DoWork()
        {
            Console.WriteLine("Worker doing work.");
        }
    }
    class SuperWorker : IWorker
    {
        public void DoWork()
        {
            Console.WriteLine("Worker doing more work in less time.");
        }
    }
    class Component   //Hi Level Class
    {
        IWorker work;         //Dependency
        public Component(IWorker dependency)
        {
            work = dependency;
        }
        public Component() { }
        public void Start()
        {
            work.DoWork();
        }

        public void InjectDependency(IWorker dependency)// DI through Method
        {
            work = dependency;
        }
        public IWorker SetDependency   //DI using Property
        {
            set { work = value; }
        }
    }
    class Program
    {
        //static void Main(string[] args)
        //{
        //    IWorker work = new Worker();
        //    Component component = new Component(work); // dependency injection through constructor
        //    component.Start();

        //    work = new SuperWorker();
        //    component = new Component(work);  // dependency injection through constructor
        //    component.Start();

        //    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        //    Component NewComponent = new Component();
        //    work = new Worker();
        //    NewComponent.InjectDependency(work);  //Method DI
        //    NewComponent.Start();

        //    NewComponent.SetDependency = new SuperWorker();  //property DI
        //    NewComponent.Start();
        //}
    }

}
