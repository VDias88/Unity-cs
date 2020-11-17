using System;
//simple code using formating strings
class hnk4{
    
    static void plusMinus(int[] arr) {
        int tot=arr.Length;
        int pos=0;
        int neg=0;
        int zeros=0;
        for(int i=0;i<=arr.Length-1;i++){
            if(arr[i]<0){
                neg++;
            }
            else if(arr[i]>0){
                pos++;
            }
            else if(arr[i]==0){
                zeros++;
            }
        }
        Console.WriteLine(((float)pos/tot).ToString("F6"));
        Console.WriteLine(((float)neg/tot).ToString("F6"));
        Console.WriteLine(((float)zeros/tot).ToString("F6"));
    }
    static void Main(){
        int[] arr={-4,3,-9,0,4,1};
        plusMinus(arr);
    }
}