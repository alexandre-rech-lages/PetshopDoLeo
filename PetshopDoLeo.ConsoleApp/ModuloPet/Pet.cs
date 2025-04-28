using PetshopDoLeo.ConsoleApp.Compartilhado;
using PetshopDoLeo.ConsoleApp.ModuloDono;

namespace PetshopDoLeo.ConsoleApp.ModuloPet;

public class Pet : EntidadeBase<Pet>
{   
    public Pet(string nome, Dono dono)
    {
        this.Nome = nome;
        this.Dono = dono;
    }

    public string Nome { get; set; }

    public Dono Dono { get; set; }
   
    public override void AtualizarRegistro(Pet petEditado)
    {
        Nome = petEditado.Nome;
        Dono = petEditado.Dono;
    }

    public override string Validar()
    {
        string erros = "";

        if (string.IsNullOrEmpty(Nome))
            erros += "O campo Nome é obrigatório";

        if (Dono == null)
            erros += "O campo Dono é obrigatório";

        return erros;
    }

    public override string ToString()
    {
        return "Id: {Id}, e o nome do pet é " + Nome + " e o seu dono é o " + Dono.Nome;
    }

   
}
