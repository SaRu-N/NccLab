namespace NccLab{
        public class LivingThings{
            public void breathe(){
                Console.WriteLine("Living Things can breathe");
            }
        }
       public class Animal : LivingThings
        {  
           public void eat() { Console.WriteLine("Animal can eat"); }  
       }  
       public class Plants : LivingThings{
           public void grow(){
               Console.WriteLine("Plants can grow");
           }
       }
}