using PetshopDoLeo.ConsoleApp.Compartilhado;
using PetshopDoLeo.ConsoleApp.ModuloDono;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetshopDoLeo.ConsoleApp.ModuloPet;

public class Pet : EntidadeBase
{
    public string Nome { get; set; }

    public Dono Dono { get; set; }

    public override void AtualizarRegistro(EntidadeBase registroEditado)
    {
        Pet petEditado = (Pet)registroEditado;

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
        return "O nome do pet é: " + Nome + " e o seu dono é " + Dono.Nome;
    }
}
