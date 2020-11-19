using System;

class hnk10{
        //s and t representing the area of the house
        //a and b representing the tree location
        //apples and oranges representing the lounch range
        //output the number of apples and oranges that fall on the house
    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges) {
        int falapples=0;
        int falorang=0;
        
        for(int i=0;i<=apples.Length-1;i++){
            if(apples[i]<0){
                
            }
            else if((a+apples[i])>=s){
                falapples++;
            }
            
        }
        for(int i=0;i<=oranges.Length-1;i++){
            if(oranges[i]>0){

            }
           else if((b-(Math.Abs(oranges[i])))<=t){
                falorang++;
            }
        }
        Console.WriteLine(falapples);
        Console.WriteLine(falorang);
    }
    static void Main(){
        int[] apples={-2,2,1};
        int [] oranges={5,-6};
        countApplesAndOranges(7,11,5,15,apples,oranges);
    }
}