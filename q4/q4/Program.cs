using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    public class MyExecption : ApplicationException
    {
        public MyExecption() { }
        public MyExecption(string message) : base(message) { }
        public MyExecption(string message, Exception innerException) : base(message, innerException) { }
    }

    public interface IFun1
    {
        string ShowMe();
    }

    public interface IFun2
    {
        string ShowMe();
    }

    class Circle : IFun1
    {
        public string ShowMe()
        {
            return "Circle-IFun1";
        }
    }

    public class ObjShowMe
    {
        public static void ShowMe(object obj)
        {
            if(!(obj is IFun1 && obj is IFun2))
            {
                throw new MyExecption("Interface not implemented for " + obj.ToString());
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle myCir = new Circle();
            try
            {
                ObjShowMe.ShowMe(myCir);
            }
            catch(MyExecption e1)
            {
                Console.WriteLine(e1.Message);
            }
        }
    }
}
