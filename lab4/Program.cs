using System;
namespace NccLab
{
    class program{
       
        public static void Main(String[] args){
             string choice="N";
        do{

    //    StackImplementation();
       CustomQueueImplementation();
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
      static void CustomQueueImplementation(){
 CustomQueue <int> Q1= new CustomQueue<int>();
        Q1.enqueue(5);
        Q1.enqueue(10);
        Q1.enqueue(20);
        Q1.display();
        Q1.dequeue();
        Q1.dequeue();
        Q1.display();


        CustomQueue<string> Q2=new CustomQueue<string>();
        Q2.enqueue("Hello");
        Q2.display();
        Q2.enqueue("There!");
        Q2.display();
        Q2.dequeue();
        Q2.display();
        }
    }
}
