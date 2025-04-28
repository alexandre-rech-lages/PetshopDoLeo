using PetshopDoLeo.ConsoleApp.Compartilhado;
using PetshopDoLeo.ConsoleApp.ModuloDono;

namespace PetshopDoLeo.ConsoleApp.ModuloPet;

public class TelaPet : TelaBase<Pet>, ITelaCrud
{
    private TelaDono telaDono;
    private RepositorioDono repositorioDono;

    public TelaPet(string nomeEntidade, RepositorioPet repositorio, TelaDono telaDono, RepositorioDono repositorioDono) 
        : base(nomeEntidade, repositorio)
    {
        this.telaDono = telaDono;
        this.repositorioDono = repositorioDono;
    }

    protected override void ExibirCabecalhoTabela()
    {
        Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "Id", "Nome", "Dono");
    }

    protected override void ExibirLinhaTabela(Pet pet)
    {        
        Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", pet.Id, pet.Nome, pet.Dono.Nome);
    }

    protected override Pet ObterDados()
    {
        Console.Write("Digite o nome do pet: ");
        string nome = Console.ReadLine();

        telaDono.VisualizarRegistros(false);

        Console.WriteLine();
        Console.Write("Informe o id do Dono: ");

        int id = Convert.ToInt32(Console.ReadLine());

        Dono donoSelecionado = repositorioDono.SelecionarRegistroPorId(id);

        Pet novoPet = new Pet(nome, donoSelecionado);

        return novoPet;
    }

   
}
