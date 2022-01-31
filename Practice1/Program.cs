using System;

public class Message{

    public void Print(){
            Console.WriteLine("Hello world");
    }
    
}

class Program {
    static void Main (){
        
        Message hiMessage = new Message();

        hiMessage.Print();
    }
}