using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3
{
    namespace ByInheritance //继承
    {
        class Circle
        {
            public static double pi = Math.PI;
            public double Radius { set; get; }

            public double Circumference()
            {
                return 2 * pi * Radius;
            }
            public double Square()
            {
                return pi * Radius * Radius;
            }
            public double Volume()
            {
                return 0;
            }
        }

        class Stereo : Circle
        {
            public double Height { set; get; }
        }

        class Ball : Circle
        {
            public new double Square()
            {
                return 4 * base.Square();
            }
            public new double Volume()
            {
                return 4 * Radius * base.Square() / 3;
            }
        }

        class Cylinder : Stereo
        {
            public new double Square()
            {
                return Circumference() * (Radius + Height);
            }
            public new double Volume()
            {
                return base.Square() * Height;
            }
        }

        class Cone : Stereo
        {
            public new double Square()
            {
                return base.Square() + pi * Radius * Math.Sqrt(Radius * Radius + Height * Height);
            }
            public new double Volume()
            {
                return base.Square() * Height / 3;
            }
        }
    }

    namespace ByVirtual //虚函数
    {
        class Circle
        {
            public static double pi = Math.PI;
            public double Radius { set; get; }

            public virtual double Circumference()
            {
                return 2 * pi * Radius;
            }
            public virtual double Square()
            {
                return pi * Radius * Radius;
            }
            public virtual double Volume()
            {
                return 0;
            }
        }

        class Stereo : Circle
        {
            public double Height { set; get; }
        }

        class Ball : Circle
        {
            public override double Square()
            {
                return 4 * base.Square();
            }
            public override double Volume()
            {
                return 4 * Radius * base.Square() / 3;
            }
        }

        class Cylinder : Stereo
        {
            public override double Square()
            {
                return base.Circumference() * (Radius + Height);
            }
            public override double Volume()
            {
                return base.Square() * Height;
            }
        }

        class Cone : Stereo
        {
            public override double Square()
            {
                return base.Square() + pi * Radius * Math.Sqrt(Radius * Radius + Height * Height);
            }
            public override double Volume()
            {
                return base.Square() * Height / 3;
            }
        }
    }

    namespace ByAbstract //抽象类
    {
        abstract class Circle
        {
            public static double pi = Math.PI;
            public double Radius { set; get; }

            public abstract double Square();
            public abstract double Volume();
        }

        abstract class Stereo : Circle
        {
            public double Height { set; get; }
        }

        class Ball : Circle
        {
            public override double Square()
            {
                return 4 * pi * Radius * Radius;
            }
            public override double Volume()
            {
                return 4 * pi * Radius * Radius * Radius / 3;
            }
        }

        class Cylinder : Stereo
        {
            public override double Square()
            {
                return 2 * pi * Radius * (Radius + Height);
            }
            public override double Volume()
            {
                return pi * Radius * Radius * Height;
            }
        }

        class Cone : Stereo
        {
            public override double Square()
            {
                return pi * Radius * Radius + pi * Radius * Math.Sqrt(Radius * Radius + Height * Height);
            }
            public override double Volume()
            {
                return pi * Radius * Radius * Height / 3;
            }
        }
    }

    namespace ByInterface //接口
    {
        interface ICalculation
        {
            double Square();
            double Volume();
        }

        class Ball : ICalculation
        {
            public static double pi = Math.PI;
            public double Radius { set; get; }

            public double Square()
            {
                return 4 * pi * Radius * Radius;
            }
            public double Volume()
            {
                return 4 * pi * Radius * Radius * Radius / 3;
            }
        }

        class Cylinder : ICalculation
        {
            public static double pi = Math.PI;
            public double Radius { set; get; }
            public double Height { set; get; }

            public double Square()
            {
                return 2 * pi * Radius * (Radius + Height);
            }
            public double Volume()
            {
                return pi * Radius * Radius * Height;
            }
        }

        class Cone : ICalculation
        {
            public static double pi = Math.PI;
            public double Radius { set; get; }
            public double Height { set; get; }

            public double Square()
            {
                return pi * Radius * Radius + pi * Radius * Math.Sqrt(Radius * Radius + Height * Height);
            }
            public double Volume()
            {
                return pi * Radius * Radius * Height / 3;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double r = 3;
            double h = 7;

            Console.WriteLine("继承：");
            ByInheritance.Ball b1 = new ByInheritance.Ball { Radius = r };
            ByInheritance.Cylinder cy1 = new ByInheritance.Cylinder { Radius = r, Height = h };
            ByInheritance.Cone c1 = new ByInheritance.Cone { Radius = r, Height = h };
            Console.WriteLine("球的表面积：{0:F2} 球的体积：{1:F2}", b1.Square(), b1.Volume());
            Console.WriteLine("圆柱表面积：{0:F2} 圆柱体积：{1:F2}", cy1.Square(), cy1.Volume());
            Console.WriteLine("圆锥表面积：{0:F2} 圆锥体积：{1:F2}", c1.Square(), c1.Volume());

            Console.WriteLine();

            Console.WriteLine("虚函数：");
            ByVirtual.Ball b2 = new ByVirtual.Ball { Radius = r };
            ByVirtual.Cylinder cy2 = new ByVirtual.Cylinder { Radius = r, Height = h };
            ByVirtual.Cone c2 = new ByVirtual.Cone { Radius = r, Height = h };
            Console.WriteLine("球的表面积：{0:F2} 球的体积：{1:F2}", b2.Square(), b2.Volume());
            Console.WriteLine("圆柱表面积：{0:F2} 圆柱体积：{1:F2}", cy2.Square(), cy2.Volume());
            Console.WriteLine("圆锥表面积：{0:F2} 圆锥体积：{1:F2}", c2.Square(), c2.Volume());

            Console.WriteLine();

            Console.WriteLine("抽象类：");
            ByAbstract.Ball b3 = new ByAbstract.Ball { Radius = r };
            ByAbstract.Cylinder cy3 = new ByAbstract.Cylinder { Radius = r, Height = h };
            ByAbstract.Cone c3 = new ByAbstract.Cone { Radius = r, Height = h };
            Console.WriteLine("球的表面积：{0:F2} 球的体积：{1:F2}", b3.Square(), b3.Volume());
            Console.WriteLine("圆柱表面积：{0:F2} 圆柱体积：{1:F2}", cy3.Square(), cy3.Volume());
            Console.WriteLine("圆锥表面积：{0:F2} 圆锥体积：{1:F2}", c3.Square(), c3.Volume());

            Console.WriteLine();

            Console.WriteLine("接口：");
            ByInterface.Ball b4 = new ByInterface.Ball { Radius = r };
            ByInterface.Cylinder cy4 = new ByInterface.Cylinder { Radius = r, Height = h };
            ByInterface.Cone c4 = new ByInterface.Cone { Radius = r, Height = h };
            Console.WriteLine("球的表面积：{0:F2} 球的体积：{1:F2}", b4.Square(), b4.Volume());
            Console.WriteLine("圆柱表面积：{0:F2} 圆柱体积：{1:F2}", cy4.Square(), cy4.Volume());
            Console.WriteLine("圆锥表面积：{0:F2} 圆锥体积：{1:F2}", c4.Square(), c4.Volume());
        }
    }
}
