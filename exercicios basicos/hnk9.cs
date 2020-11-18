using System;
using System.Collections.Generic;
class hnk9{
     //se a diferença entre a nota e o proximo multiplicador de 5 é menor que 3-arredondar para o proximo multiplicadorde 5
     //se a nota for menor que 38 , sem arredondar , resultado sera de uma nota baixa

     public static List<int> gradingStudents(List<int> grades){
         List<int> result=new List<int>();
         
         for(int i=0;i<=grades.Count-1;i++){
            int number=grades[i];
            int rest=number%5;
            int mult=((number-rest)/5)+1;
            if(grades[i]<38){
                 result.Add(grades[i]);
             }
             
             else if(Math.Abs(((mult*5)-number))<3){
                 result.Add(mult*5);
             }
             else if(Math.Abs(((mult*5)-number))>=3){
                 result.Add(grades[i]);
             }
         }
         return result;
    }

    static void Main(string[] args){
        List<int> grades=new List<int>();
        grades.Add(73);
        grades.Add(67);
        grades.Add(38);
        grades.Add(33);
        for(int i=0;i<=gradingStudents(grades).Count-1;i++){
            Console.WriteLine(gradingStudents(grades)[i]);
        }
        //gradingStudents(grades);
    }
}