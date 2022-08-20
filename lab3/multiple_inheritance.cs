namespace NccLab{
    public interface Icalc1{
        
        int add(int a, int b);    
    }
    public interface Icalc2{
        int sub (int x, int y);
    }
    //multiple inheritance using interface
class Calculation : Icalc1, Icalc2 
    {    
        public int result1;    
        public int add(int a, int b)    
        {    
            return result1 = a + b;    
        }    
        public int result2;    
        public int sub(int x, int y)    
        {    
            return result2 = x - y;    
        }    
      
    }  
    }
