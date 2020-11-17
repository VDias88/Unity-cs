using System;
//minimum and max array values code
class hnk6{
    static void miniMaxSum(int[] arr) {
        Array.Sort(arr);
        int siz=arr.Length-4;
        
        long max=0;
        long min=0;
        for(int i=0;i<=arr.Length-1;i++){
            if(i<=3){
            min+=arr[i];
            }
            if(i>=siz){
                max+=arr[i];
            }
            
        }
        Console.WriteLine("{0} {1}",min,max);
        
    }
    static void Main(){
        int [] arr={1,2,3,4,5};

        miniMaxSum(arr);
    }
}