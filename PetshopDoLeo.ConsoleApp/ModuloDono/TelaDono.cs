using PetshopDoLeo.ConsoleApp.Compartilhado;

namespace PetshopDoLeo.ConsoleApp.ModuloDono;

public class TelaDono : TelaBase<Dono>, ITelaCrud
{    
    public TelaDono(string nomeEntidade, RepositorioDono repositorio) : base(nomeEntidade, repositorio)
    {        
    }

    protected override void ExibirCabecalhoTabela()
    {
        Console.WriteLine("{0, -10} | {1, -20}", "Id", "Nome");
    }

    protected override void ExibirLinhaTabela(Dono dono)
    {        
        Console.WriteLine("{0, -10} | {1, -20}", dono.Id, dono.Nome);
    }

    protected override Dono ObterDados()
    {
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();

        Dono novoDono = new Dono(nome);

        return novoDono;
    }

    
}
