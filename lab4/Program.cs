using System;
namespace NccLab
{
    class program{
       
        public static void Main(String[] args){
             string choice="N";
        do{

       StackImplementation();
        System.Console.WriteLine("Do you want to continue?(Y/N):");
        choice= Console.ReadLine();
        }while(choice.ToUpper()=="Y");
        return;
        }
        private static void StackImplementation()
        {
            var cs = new CustomStack();
          
            cs.Push(10);
            cs.Push(3);
            cs.Pop();
            cs.Push(4);
            cs.Push(7);
            // cs.Push(6);
            // cs.Push(9);
            // cs.Push(10);

            cs.Pop();
            cs.Pop();
            cs.Pop();
            // cs.Pop();
            // cs.Pop();
            // cs.Pop();
            // cs.Pop();
            // cs.Pop();
            var css = new CustomStackString();
            css.Push("Hello");
            css.Push("I am Saraswati");
            css.Push("Niroula");
            css.Pop();
            css.Pop();
            css.Push("I am Saraswati Niroula");
           
           var tcs = new CustomStackTemplated<int>();
           var tcs1= new CustomStackTemplated<string>();
           tcs.Push(10);
           tcs.Push(20);
           tcs.Pop();
           tcs.Pop();
           tcs.Pop();
           tcs1.Push("hello");
           tcs1.Push("From Templated Stack");
           
        }
    }
}
