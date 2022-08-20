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
        
           
           var tcs = new CustomStack<int>();
           var tcs1= new CustomStack<string>();
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
