using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int choice = 1;
            List<string> list = new List<string>();
            Queue<string> queue = new Queue<string>();
            Stack<string> stack = new Stack<string>();
            Dictionary<int, string> dict = new Dictionary<int, string>();

            while (choice != 0)
            {
                Console.WriteLine("请选择要进行的操作：");
                Console.WriteLine("1->添加 2->删除最后添加的元素 3->遍历 0->退出");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("请输入要添加的内容：");
                        string str = Console.ReadLine();
                        list.Add(str);
                        queue.Enqueue(str);
                        stack.Push(str);
                        dict.Add(num, str);
                        num++;
                        Console.WriteLine("添加成功！");
                        break;

                    case 2:
                        list.RemoveAt(list.Count - 1);
                        queue.Dequeue();
                        stack.Pop();
                        num--;
                        dict.Remove(num);
                        Console.WriteLine("删除成功！");
                        break;

                    case 3:
                        {
                            Console.WriteLine("List中的内容：");
                            foreach (string key in list)
                            {
                                Console.WriteLine("{0}", key);
                            }
                            Console.WriteLine();

                            Console.WriteLine("Queue中的内容：");
                            foreach (string key in queue)
                            {
                                Console.WriteLine("{0}", key);
                            }
                            Console.WriteLine();

                            Console.WriteLine("Stack中的内容：");
                            foreach (string key in stack)
                            {
                                Console.WriteLine("{0}", key);
                            }
                            Console.WriteLine();

                            Console.WriteLine("Dictionary中的内容：");
                            foreach (int key in dict.Keys)
                            {
                                Console.WriteLine("{0}\t{1}", key,list[key]);
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("错误选项，请重新输入：");
                        break;
                }
            }
        }
    }
}
