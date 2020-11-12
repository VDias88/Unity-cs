using System;
//while, codigo simples de operadores relacionais em c#
class Quest17{
    static double media(double n1,double n2){
        double m=n1+n2/2;
        if(m<6){
            Console.WriteLine("Você foi aprovado");
        }
        else{
            Console.WriteLine("Você foi reprovado");
        }
        return m;
    }
    static void Main(){
        int op=0;
        
        while(op==0){
            double n1;
            double n2;
            Console.WriteLine("Digite as duas notas para calculo");
            n1=float.Parse(Console.ReadLine());
            n2=float.Parse(Console.ReadLine());
            Console.WriteLine(media(n1,n2));

            Console.WriteLine("Deseja Continuar?\n0=sim\n1=nao");
            op=int.Parse(Console.ReadLine());

        }
    }
}