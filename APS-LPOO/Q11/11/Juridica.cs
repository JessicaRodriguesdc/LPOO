using System;

class Juridica:Pessoa{
private string cnpj;

  public void escreverCnpj(string cnpj){
    this.cnpj=cnpj;
  }

  public override bool validarDocumento(){
    if (this.cnpj !=""){
        return true;
    }else{
        return false;
    }
  }

  public override void imprimir(){
    Console.WriteLine ("Nome: "+nome);
    Console.WriteLine ("cnpj: "+cnpj);
    Console.WriteLine ("Documento Validado: "+validarDocumento());
  }
  
}