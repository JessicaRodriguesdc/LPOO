
 using System;

class Moto {
  
  private string marca;
  private string modelo;
  private string cor;
  private int macha;
  private int menorMarcha;
  private int maiorMarcha;
  private bool ligada;

//construtor
  public Moto(string marca, string modelo, string cor, int macha,int menorMarcha, int maiorMarcha, bool ligada){

    this.marca = marca;
    this.modelo = modelo;
    this.cor = cor;
    this.macha = macha;
    this.menorMarcha = menorMarcha;
    this.maiorMarcha = maiorMarcha;
    this.ligada = ligada;
  }
  //metodos
  public void imprimir(){
    Console.WriteLine("A marca e "+marca);
    Console.WriteLine("A modelo e "+modelo);
    Console.WriteLine("A cor e "+cor);
    Console.WriteLine("A macha e "+macha);
    Console.WriteLine("A menor Marcha e "+menorMarcha);
    Console.WriteLine("A maior Marcha e "+maiorMarcha);
    Console.WriteLine("Esta ligada "+ligada);
  }
  public void subirMacha(){
    if (macha<maiorMarcha){
       macha++;  
    }
  }
  public void descerMacha(){
    if(macha>menorMarcha){
      macha--;
    }
  }
  public void ligar(){
        ligada=true;
  }
  public void desligar(){
        ligada=false;
  }
  
}