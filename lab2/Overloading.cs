namespace NccLab{
    //base keyword is used to overload the constructor
    //virtual and override keyword is used to override function
    public class Living_Things{
         public int PublicVariable = 10;
        private int _privateVariable = 15;
        protected int protectedVariable = 20;

        public Living_Things()
        {
            System.Console.WriteLine("Default Constructor of Living_Things");
        }

        public Living_Things(int i)
        {
            System.Console.WriteLine("Parameterized Constructor of Living_Things");

        }

        public virtual void Eat()
        {
            Console.WriteLine("Living things can eat");
        }

        public static void TemplatedFunction<T, U, V>(T a, U b, V c)
        {
            //do something here
        }
    }
        public class Animal1 : Living_Things
    {
        public Animal1() : base(15)
        {
            System.Console.WriteLine("Default Constructor of Animal1");

        }

        public Animal1(int i) : base(i)
        {
            System.Console.WriteLine("Parameterized Constructor of Animal1");

        }

        public void FunctionOne()
        {
            PublicVariable = 20;
            protectedVariable = 25;
        }

        public override void Eat()
        {
            Console.WriteLine("Animal can eat");
        }
    }

    public class Plant : Living_Things
    {
        public Plant() : base()
        {
            System.Console.WriteLine("Default Constructor of Plant");

        }

        public Plant(int i) : base(i)
        {
            System.Console.WriteLine("Parameterized Constructor of Plant");

        }

        public override void Eat()
        {
            Console.WriteLine("Plants can eat");
        }
    }

    public class Vertibrates : Animal1
    {
        public Vertibrates() : base()
        {
            System.Console.WriteLine("Default Constructor of Vertibates");

        }

        public override void Eat()
        {
            Console.WriteLine("Vertibrates can eat");
        }
    }

    public sealed class Human : Vertibrates
    {
    }
}

