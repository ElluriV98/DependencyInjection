using System;

namespace DependencyInjection
{
    // Constructor Injection 
    /*  public interface ILog
      {
          void print();
      }
      class A : ILog
      {
          public void print()
          {
              Console.WriteLine(" Dependency Injection");
          }
      }
      public class constructorinjection
      {
          private ILog _ilog;
          public constructorinjection(ILog t1)
          {
              this._ilog = t1;
          }
          public void print()
          {
              _ilog.print();
          }
      }

      class Program
      {
          static void Main(string[] args)
          {
              constructorinjection cs = new constructorinjection(new A());
              cs.print();
              Console.ReadKey();
              Console.WriteLine("Hello World!");
          }
      }*/

    public interface ILog
    {
        void print();
    }
    public class servic : ILog
    {
        public void print()
        {
            Console.WriteLine("print........");
        }
    }
    public class client
    {
        private ILog _log;
        public void run(ILog serv)
        {
            this._log = serv;
            Console.WriteLine("start");
            this._log.print();
        }
    }
    class Program
    {
        public static void Main()
        {
            client cn = new client();
            cn.run(new servic());
            Console.ReadKey();
        }
    }
}
