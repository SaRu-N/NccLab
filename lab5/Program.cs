
using System;
namespace NccLab
{
    class program{
       
        public static void Main(String[] args){
             string choice="N";
        do{

    
       MultithreadingExample();
        System.Console.WriteLine("Do you want to continue?(Y/N):");
        choice= Console.ReadLine();
        }while(choice.ToUpper()=="Y");
        return;
        }
        private static void MultithreadingExample()
        {
            ParallelProgramming pp = new ParallelProgramming();
            pp.Run();
        }
    }
}