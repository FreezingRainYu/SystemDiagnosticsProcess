using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q6
{
    public class Chair : IComparable
    {
        public double myPrice;
        public string myVendor, myID;

        public Chair() { }
        public Chair(double price, string vendor, string sku)
        {
            myPrice = price;
            myVendor = vendor;
            myID = sku;
        }
        int IComparable.CompareTo(object obj)
        {
            Chair castObj = (Chair)obj;
            return myID.CompareTo(castObj.myID);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Chair[] chairs = new Chair[4];
            chairs[0] = new Chair(150.0, "Lane", "99-88");
            chairs[1] = new Chair(250.0, "Lane", "99-00");
            chairs[2] = new Chair(100.0, "Lane", "98-88");
            chairs[3] = new Chair(120.0, "Harris", "93-9");
            Array.Sort(chairs);
            foreach (Chair c in chairs)
            {
                Console.WriteLine(c.myPrice + " " + c.myVendor + " " + c.myID);
            }
        }
    }
}
