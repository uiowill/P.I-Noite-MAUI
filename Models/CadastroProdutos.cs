using System;
using P.I_Noite_MAUI.Models;

class CadastroProduto{
    public int Id{get;set;}
    public string Nome{ get; set;}
    public string Categoria{ get; set;}
    public double Valor{ get; set;}

    public List <Produto> Produtos { get; set;}
    public CadastroProduto(int id,string nome,string categoria,double valor,List <Produto> produtos){
        this.Id = id;
        this.Nome = nome;
        this.Categoria = categoria;
        this.Valor = valor;
        this.Produtos = produtos;
    }
}
class Produto
    { 
      public int Id{get;set;}
      public string Nome{get; set;} 
      public double Valor {get;set;} 
      public Produto(int id, string nome, double valor){
            this.Id = id;
            this.Nome = nome;
            this.Valor = valor;

      }
    }