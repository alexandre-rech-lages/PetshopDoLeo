using PetshopDoLeo.ConsoleApp.Compartilhado;

namespace PetshopDoLeo.ConsoleApp.ModuloDono;

public class TelaDono : TelaBase
{
    public TelaDono(string nomeEntidade, RepositorioBase repositorio) : base(nomeEntidade, repositorio)
    {
    }

    public override EntidadeBase ObterDados()
    {
        Console.Write( "Digite o nome: " );
        string nome = Console.ReadLine();

        Dono novoDono = new Dono();
        novoDono.Nome = nome;

        return novoDono;
    }

    public override void VisualizarRegistros(bool exibirTitulo)
    {
        Console.WriteLine("Visualizando os Donos de Pets");

        EntidadeBase[] donos = repositorio.SelecionarRegistros();

        foreach (Dono d in donos)
        {
            if (d != null) 
                Console.WriteLine(d);
        }
        
        Console.ReadLine();
    }
}
