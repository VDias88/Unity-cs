using System;
using System.Collections.Generic;

class q1{
    //codigo simples psoposto pelo site hacker hank
    //comparação de listas
    static List<int> compareTriplets(List<int> a, List<int> b) {
        List<int> result=new List<int>();
        int al=0;
        int bob=0;
        for(int i=0;i<=a.Count-1;i++){
            if(a[i]<b[i]){
                bob=bob+1;
            }
            else if(a[i]>b[i]){
                al=al+1;
            } 
        }
            result.Add(al);
            result.Add(bob);
        return result;

    }
    static void Main(){
        List<int> a=new List<int>();
        List<int> b=new List<int>();
        a.Add(5);
        a.Add(6);
        a.Add(7);

        b.Add(3);
        b.Add(6);
        b.Add(10);
        for(int i=0;i<=compareTriplets(a,b).Count-1;i++){
            Console.Write(compareTriplets(a,b)[i]);
        }
        
        
    }
}