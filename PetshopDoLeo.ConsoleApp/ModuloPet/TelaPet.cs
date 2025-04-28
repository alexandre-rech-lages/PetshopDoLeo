using PetshopDoLeo.ConsoleApp.Compartilhado;
using PetshopDoLeo.ConsoleApp.ModuloDono;
using System.Runtime.CompilerServices;

namespace PetshopDoLeo.ConsoleApp.ModuloPet;

public class TelaPet : TelaBase
{
    private TelaDono telaDono;
    private RepositorioDono repositorioDono;
    public TelaPet(string nomeEntidade, RepositorioBase repositorio, TelaDono telaDono, RepositorioDono repositorioDono) : base(nomeEntidade, repositorio)
    {
        this.telaDono = telaDono;
        this.repositorioDono = repositorioDono;
    }

    public override EntidadeBase ObterDados()
    {
        Console.Write("Digite o nome do pet: ");
        string nome = Console.ReadLine();

        telaDono.VisualizarRegistros(false);
        Console.WriteLine();
        Console.Write("Informe o id do Dono: ");

        int id = Convert.ToInt32(Console.ReadLine());

        Dono donoSelecionado = (Dono)repositorioDono.SelecionarRegistroPorId(id);

        Pet novoPet = new Pet();
        novoPet.Nome = nome;
        novoPet.Dono = donoSelecionado;

        return novoPet; 
    }

    public override void VisualizarRegistros(bool exibirTitulo)
    {
        Console.WriteLine("Visualizando os Donos de Pets");

        EntidadeBase[] pets = repositorio.SelecionarRegistros();

        foreach (Pet p in pets)
        {
            if (p != null)
                Console.WriteLine(p);
        }

        Console.ReadLine();
    }
}
