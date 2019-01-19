using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a file name like \"*.txt\":");
            string filename = Console.ReadLine();
            filename = filename.Substring(0, filename.LastIndexOf('.')).Trim();
            string[] splitFilename = filename.Split(' ');
            filename = string.Join("_", splitFilename) + ".dat";
            Console.WriteLine("The wanted file name like \"*.dat\"is:\n{0}", filename);
        }
    }
}
