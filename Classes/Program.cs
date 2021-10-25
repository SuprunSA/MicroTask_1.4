using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    abstract class A
    {
        public string Prop1 { get; set; } = "aaa";
        public uint Prop2 {get => uint.Parse(Console.ReadLine()); 
            set 
            {
                if (value > 100)
                {
                    Math.Truncate((float) value / (10 * (value.ToString().Length - 2)));
                }
            } 
        }
        public int Foo()
        {
            return 1;
        }

        public abstract void Foo(DateTime time);
    }

    class B : A
    {
        private float PropB1 { get; set; }
        public override void Foo(DateTime time)
        {
            
        }
    }

    abstract class C : A
    {
        protected Guid PropC1 { get; set; }
    }

    class D : C
    {
        public E PropD1 { get; set; }
        public override void Foo(DateTime time)
        {

        }
    }

    class E
    {
        public E PropE1 { get; set; }
        public void Bar()
        {

        }

        private void Bar(int size)
        {

        }
    }
}
