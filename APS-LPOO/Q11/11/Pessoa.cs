using System;

public class Pessoa:IValidador{
  protected string nome;

  public void escreverNome(string nome){
    this.nome=nome;
  }

  public virtual bool validarDocumento(){
    throw new NotImplementedException();
  }

  public virtual void imprimir(){
    Console.WriteLine ("Nome: "+nome);
  }
}