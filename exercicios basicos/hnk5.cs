using System;
//simples right stair case code 
class hnk5{
    static void staircase(int n) {
       //int l=0;
        /*for(int i=1;i<=n;i++){
            Console.WriteLine(" ");
            for(int j=0;j<=l;j++){
                Console.Write("#");
            }
           l++;
        }*/
        int l=0;
        for(int i=1;i<=n;i++){
            Console.Write(new String(' ', n - i));
            for(int j=0;j<=l;j++){
                Console.Write("#");
                
            }
            Console.WriteLine("");
           l++;
        }
       
    }
    static void Main(){
        staircase(6);
    }
}