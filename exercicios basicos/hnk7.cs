using System;
using System.Collections.Generic;
using System.Linq;
//tallest candles in the array
class hnk7{
    public static int birthdayCakeCandles(List<int> candles){
        candles.Sort();
        int tal=candles[candles.Count-1];
        var l=candles.Max();
        int total=0;
        for(int i=candles.Count-1;i>0;i--){
            if(candles[i]==l){
                total+=1;
            }
        }
        return total;
    }
    static void Main(){
        List<int> arr=new List<int>();
        for(int i=0;i<=100000;i++){
            arr.Add(9999999);
        }
        Console.WriteLine(birthdayCakeCandles(arr));
    }
}