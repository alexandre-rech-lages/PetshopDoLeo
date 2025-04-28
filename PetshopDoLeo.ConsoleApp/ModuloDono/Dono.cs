using PetshopDoLeo.ConsoleApp.Compartilhado;

namespace PetshopDoLeo.ConsoleApp.ModuloDono;

public class Dono : EntidadeBase<Dono>
{
    public Dono(string nome)
    {
        this.Nome = nome;
    }

    public string Nome { get; set; }

    public override void AtualizarRegistro(Dono donoEditado)
    {
        Nome = donoEditado.Nome;
    }

    public override string Validar()
    {
        string erros = "";

        if (string.IsNullOrEmpty(Nome))
            erros += "O campo nome é obrigatório";

        return erros;
    }

    public override string ToString()
    {
        return $"Id: {Id}, nome: {Nome}";
    }
}
