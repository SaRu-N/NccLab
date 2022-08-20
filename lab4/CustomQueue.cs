using System;
namespace NccLab{
       public class CustomQueue<T>{
            public T[] t1= new T[5];
            
            public int rear=-1;
            public int front=-1;

            public void enqueue(T item){
            if(front==-1 && rear==-1){
                
                rear++;
                t1[rear]=item ;
                System.Console.WriteLine($"Item added is:{item}");

            
            }
            else if(front !=rear){
                
                if(rear <5 ){
                rear++;
                t1[rear]=item;
                System.Console.WriteLine($"Item added is:{item}");
                    }
                 }
             else{
                    Console.WriteLine("queue overflow");
                }
            }
            public void dequeue()
        {
            if(front!=rear)
            {
                front++;
                Console.WriteLine($"Deqeued item is : {t1[front]}");
                t1[front] = default(T);
                // front++;
            }
            else{
                Console.WriteLine("Queue Underflow");
            }
        }
        public void display(){
                

                for(int a=0;a<=rear;a++){
                    Console.WriteLine("Queue Items are:");

                    Console.WriteLine(t1[a]);
                    

                }
            }
}
}