using System;
namespace NccLab
{
    class program{
       
        public static void Main(String[] args){
             string choice="N";
        do{

       MultipleInheritance();
       DelegateExample();
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
        private static void DelegateExample()
        {
            Delegates ds = new Delegates();
            ds.MathHandler += Ds_MathHandler;
            ds.Run(2, 3);
            Delegates ds1 = new Delegates();
            ds1.MathHandler += Ds1_MathHandler;
            ds1.Run(4, 5);
        }
 private static void Ds1_MathHandler(int a, int b)
        {
            throw new NotImplementedException();
           
        }

private static void Ds_MathHandler(int a, int b)
        {
            Console.WriteLine($"Function running from program.cs with parameters a={a} and b={b} ");
        }
    }
}