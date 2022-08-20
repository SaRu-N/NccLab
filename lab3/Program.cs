using System;
namespace NccLab
{
    class program{
       
        public static void Main(String[] args){
             string choice="N";
        do{

       MultipleInheritance();
        System.Console.WriteLine("Do you want to continue?(Y/N):");
        choice= Console.ReadLine();
        }while(choice.ToUpper()=="Y");
        return;
        }
        static void MultipleInheritance(){
             System.Console.WriteLine("Multiple Inheritance");
            
                Calculation c = new Calculation();    
                c.add(20, 10);    
                c.sub(20, 10);        
                Console.WriteLine("Addition: " + c.result1);    
                Console.WriteLine("Substraction: " + c.result2);
        }
    }
}