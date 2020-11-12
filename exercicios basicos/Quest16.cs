using System;
//Questão usando condições
class Quest16{
    public static double value(int quantidade){
        if(quantidade>12){
            return quantidade*1.0;
        }
        else {
            return quantidade*1.3;
        }
    }


    static void Main(){
        Console.WriteLine(value(11));
    }
}