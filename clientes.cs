namespace atividade{
 
 
   class Clientes
{
    // Propriedades
     public string Nome { get; set; }
    public  string Endereco { get; set; }
     public float valor { get; protected set; }
     public float valor_imposto{get; protected set;}
     public float total{get; protected set;}

    

    // Método para pagamrnto de imposto
    public virtual void pagar_impostpo(float v)
    {
this.valor = v;
this.valor_imposto = this.valor * 10 / 100
this.total = this.valor + this.valor_imposto;
       
    }
}

  
  
}