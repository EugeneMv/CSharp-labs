using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Cone
    {
        // Fields
        public readonly int ID;
        public static int quantity;
        const float Pi = (float)Math.PI;

        float rad;
        public float radius {
            get { return rad; }
            set { rad = value; }
        }
        public float height { get; set; }

        // Constructors/Destructors
        public Cone(float f1, float f2) { radius = f1; height = f2; quantity++; ID = GetHashCode(); }
        public Cone() { quantity++; ID = GetHashCode(); }
        static Cone() { quantity = 0;}
        ~Cone() { quantity--; }

        static Cone obj = new Cone();
        // Methods
        public static void ShowClass()
        {
            Console.WriteLine(obj.GetType());
            Console.WriteLine("количество объектов " + quantity);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return (int)(rad*height + rad*rad);
        }

        public void GetRadiusFromArea(ref float val)
        {
            radius = (float)Math.Sqrt(val / Pi);
        }

        public void SetAreaGround(out double val)
        {
            val = Math.Pow(radius, 2d) * Pi;
        }

    }

    static class MathObject
    {
        public static float GetFullArea(Cone obj)
        {
            return (float)(Math.PI * obj.radius * (obj.radius + GetL(obj)));
        }

        public static float GetL(Cone obj)
        {
            return (float)(Math.Sqrt( Math.Pow(obj.radius, 2) + Math.Pow(obj.height, 2) ));
        }

        public static float GetSize(Cone obj)
        {
            return (float)((Math.PI * obj.height * Math.Pow(obj.radius, 2))/3);
        }

        public static float AngleTop(this Cone obj)
        {
            return (float)(Math.Atan(obj.radius / obj.height)*180/Math.PI*2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var E = new Cone(2,4);
            Console.WriteLine("ID E " +E.ID);
            Console.WriteLine("Площадь поверхности " + MathObject.GetFullArea(E));
            Console.WriteLine("Объем конуса " + MathObject.GetSize(E));
            Console.WriteLine("Угол при вершине "+E.AngleTop());

            double D;
            E.SetAreaGround(out D);
            Console.WriteLine("площадь основания " + D);
            float F = (float)D;
            E.GetRadiusFromArea(ref F);
            Console.WriteLine("Радиус " + E.radius);
            Cone.ShowClass();
            Cone E2 = new Cone(2,4);
            Console.WriteLine("ID E2 " + E2.ID);

            var Ref1 = E2;
            var Ref2 = E2;
            if(Ref1.Equals(Ref2)) Console.WriteLine("ссылки эквивалентны") ;
        }
    }
}
