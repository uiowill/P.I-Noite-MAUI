class Prato{
    public int id {get;set;}

    public string Nome {get ; set;}
    
    public string Categoria {get;set;}

    public double Valor {get ; set;}

    public List<string> Produtos {get; set;}

    public Prato(int id, string Nome, string Categoria, double Valor, List<string> Produtos){
        this.id = id;
        this.Nome = Nome;
        this.Categoria = Categoria;
        this.Valor = Valor;
        this.Produtos = Produtos;
    }

}