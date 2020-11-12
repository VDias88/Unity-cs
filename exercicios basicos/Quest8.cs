using System;
//Simples codigo para mostrar porcentagem de numeros float, formatação de saidas
class Municipio{
    private int eleitores;

	public int getEleitores() {
		return this.eleitores;
	}

	public void setEleitores(int eleitores) {
		this.eleitores = eleitores;
	}

    private float brancos;
    private float nulos;
    private float validos;

    public string porcent(){
        if(this.eleitores<0){
            Console.WriteLine("Sem eleitores presentes");
            return null;
        }
        else {
            string b=(this.brancos/this.eleitores).ToString("P");
            string n=(this.nulos/this.eleitores).ToString("P");
            string v=(this.validos/this.eleitores).ToString("P");
            return b+" "+n+""+v;
        }
    }
    public Municipio(int eleitores,float brancos,float nulos,float validos){
        this.eleitores=eleitores;
        this.brancos=brancos;
        this.nulos=nulos;
        this.validos=validos;
    }
}

class Quest8{
    static void Main(){
        Municipio m1=new Municipio(1000,100,200,700);
        Console.WriteLine(m1.getEleitores()+" ao todo.");
        Console.WriteLine(m1.porcent());
    }
}