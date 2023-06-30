
using system;
namespace atividade
{
    class program
    {
        public static void Main(string[] args)
             float val_pag;
             console.WriteLine("INFORME SEU NOME");
             string var_nome = console.ReadLine();
             console.WriteLine("INFORME SEU ENDEREÇO");
             string var_endereco = console.ReadLine();
            console.WriteLine("PESSOA FISICA (F) OU PESSOA JURIDICA(J)");
             string var_tipo = console.ReadLine();

             if(var_tipo == "F")
             {
               // ---- pessoa fisica -----

              pessoa_fisica pf = new pessoa_fisica();
               pf.nome = var_nome;
               pf.endereco = var_endereco;
               console.WriteLine("informe seu Cpf");
               pf.Cpf = console.ReadLine();
               console.WriteLine("informe seu Rg");
               pf.Rg= console.ReadLine();
               console.WriteLine("informe so valor de compra");
               val_pag =float.Parse (console.ReadLine());
               pf.pagar_impostpo(val_pag)
               console.WriteLine("-------Pessoa Fisica------------");
               console.WriteLine("Nome............: "+ pf.nome);
               console.WriteLine("Endereço............: "+ pf.endereco);
               console.WriteLine("Cpf............: "+ pf.Cpf);
               console.WriteLine("Rg............:"+ pf.Rg);
               console.WriteLine("Valor de compra............: "+ pf.valor.ToString("C"));
               console.WriteLine("Imposto...........:" + pf.valor_imposto.ToString("C"));
               console.WriteLine("Total a pagar............: "+ pf.total.ToString("C"));
            

             }
             if(var_tipo == "J")
             {
              //pessoa juridica
               pessoa_juridica pj = new pessoa_juridica();
               pf.nome = var_nome;
               pf.endereco = var_endereco;
               console.WriteLine("informe seu CNPJ");
               pf.cnpj = console.ReadLine();
               console.WriteLine("informe seu IE");
               pf.ie = console.ReadLine();
               console.WriteLine("informe so valor de compra");
               val_pag =float.Parse (console.ReadLine());
               pf.pagar_impostpo(val_pag)
               console.WriteLine("-------Pessoa Juridica------------");
               console.WriteLine("Nome............: "+ pf.nome);
               console.WriteLine("Endereço............: "+ pf.endereco);
               console.WriteLine("Cnpj............: "+ pf.cnpj);
               console.WriteLine("IE............:"+ pf.ie);
               console.WriteLine("Valor de compra............: "+ pf.valor.ToString("C"));
               console.WriteLine("Imposto...........:" + pf.valor_imposto.ToString("C"));
               console.WriteLine("Total a pagar............: "+ pf.total.ToString("C"));

             }

             {
                
             }

        }

    }
}
