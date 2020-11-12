using System;
//Código treino com porcentagem sobre um valor
class Quest10{
    public static float valor(float value,float dist,float impostos){
        float a=dist*value;
        float b=dist*impostos;
        return value+a+b;
    }
    static void Main(){
        Console.WriteLine("Digite o valor");
        float a=float.Parse(Console.ReadLine());
        Console.WriteLine("Porcentagem da distribuidora");
        float b=float.Parse(Console.ReadLine());
        Console.WriteLine("Impostos");
        float c=float.Parse(Console.ReadLine());
        Console.WriteLine("Preço total: {0}",valor(a,b,c));
    }
}