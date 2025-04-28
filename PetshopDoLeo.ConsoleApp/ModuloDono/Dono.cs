using PetshopDoLeo.ConsoleApp.Compartilhado;

namespace PetshopDoLeo.ConsoleApp.ModuloDono;

public class Dono : EntidadeBase
{
    public string Nome { get; set; }

    public override void AtualizarRegistro(EntidadeBase registroEditado)
    {
        Dono donoEditado = (Dono)registroEditado;  

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
        return "Dono do Pet: " + Nome;
    }
}
