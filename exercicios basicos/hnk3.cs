using System;
using System.Collections.Generic;
//code with nested lists in c# and some of 2 diagonal values
class Result
{
    public static int diagonalDifference(List<List<int>> arr)
    {   
        int sublists=0;
        int some1=0;
        int some2=0;
        foreach (var sublist in arr)
        {
            sublists+=1;
        }
        int j=0;
        foreach (var sublist in arr)
        { 
            for(int i=0;i<=sublists;i++){
               if(i==j){
                   some1=sublist[i]+some1;
               }
            }
            j++;
        }
        int j1=0;
        foreach (var sublist in arr)
        { 
            for(int i=0;i<=sublists-1;i++){
                
               if(i+j1==sublists-1){
                   
                   some2=sublist[i]+some2;
                   
               }
               
            }
           j1+=1;  
        }
        return Math.Abs(some1-some2);
    }

}
class hnk3{
    static void Main(){
        Result a1=new Result();
        List<List<int>> asd=new List<List<int>>();
        asd.Add(new List<int> { 11, 2, 4 });
        asd.Add(new List<int> { 4, 5, 6 });
        asd.Add(new List<int> { 10, 8, -12 });
        Console.WriteLine(Result.diagonalDifference(asd));
        //Result.diagonalDifference(asd);
    }
}