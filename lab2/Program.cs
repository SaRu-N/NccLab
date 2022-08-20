using System;
namespace NccLab
{
    class program{
       
        public static void Main(String[] args){
             string choice="N";
        do{

        classandobjectexample(); 
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
    }

}