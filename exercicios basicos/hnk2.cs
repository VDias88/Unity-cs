using System;
using System.Collections.Generic;
//hackerhank2 code to some list valors
class hnk1{
    static long aVeryBigSum(long[] ar) {
        long result=0;
        for(int i=0;i<=ar.Length-1;i++){
            result+=ar[i];
        }
        return result;
    }
    static void Main(){
        long[] lis={12314,345112,124543543,7657663};
        Console.WriteLine(aVeryBigSum(lis));
    }
}