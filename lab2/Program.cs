using System;
namespace NccLab
{
    class program{
       
        public static void Main(String[] args){
             string choice="N";
        do{

        classandobjectexample(); 
        SingleInheritance();
        MultilevelInheritance();
        HierarchicalInheritance();
        System.Console.WriteLine("Do you want to continue?(Y/N):");
        choice= Console.ReadLine();
        }while(choice.ToUpper()=="Y");
        return;
        }
        static void classandobjectexample(){
            // creating object of the class
            classandobjects student =new classandobjects();
            student.Name="Saraswati Niroula";
            student.Roll=20926;
            student.Class="Bsc CSIT 6th Sem";
            System.Console.WriteLine("Students Information");
            System.Console.WriteLine($"Name={student.Name} Roll Number={student.Roll} Class={student.Class}");
}
static void SingleInheritance(){  
          System.Console.WriteLine("Single Inheritance");
                Dog d1 = new Dog();  
                d1.eat();  
                d1.bark();  
}
        
       static  void MultilevelInheritance(){  
          System.Console.WriteLine("Multilevel Inheritance");
            
                _Dog d1 = new _Dog();  
                 d1._breathe();
                d1._eat();  
                d1._bark();  
        }  
          static void HierarchicalInheritance()
          {  
          System.Console.WriteLine("Hierarchical Inheritance");

            Animal a1 =new Animal();
               a1.breathe();
               a1.eat();
               Plants p1 = new Plants();
               p1.breathe();
               p1.grow();    
          }
             
    }

}