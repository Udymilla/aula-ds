using System;
using System.Collections.Generic;
using System.Text;

namespace adm_Saladeaula
{
    public class Aluno
    {
        List<base_aluno> lista_chamada = new List<base_aluno>();
    }
}
 public void listar()
{
    if(lista_chamada.Count > = 0)
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Nome Número Notas Faltas");
        Console.BackgroundColor = ConsoleColor.Black;

        for (int i = 0; i < lista_chamada.Count; i++)
        {
            Console.WriteLine(
            "{0}    {1}   {2}   {3}"
            i,
            lista_chamada[i].Nome,
            lista_chamada[i].Notas.ToString(),
            lista_chamada[i].Faltas.ToString()
            ) ;
        }
    }





   else
    {
      Console.BackgroundColor = ConsoleColor.Red;
       Console.WriteLine("Não há alunos fora do sistema");
       Console.BackgroundColor = ConsoleColor.Black;
    }
}

public void excluir_aluno()
{
    if(lista_chamada.Count > 0)
    {
        Console.WriteLine("Informe o numero do aluno que deseja excluir");
        int i=Convert.ToInt32(Console.ReadLine());
        lista_chamada RemoveAt(i);

        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("Aluno excluído!");
        Console.BackgroundColor = ConsoleColor.Black;
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("Nenhum aluno foi excluído do sistema");
        Console.BackgroundColor = ConsoleColor.Black;
    }
}

public void editar_nota()
{
    if (lista_chamada.Count > 0)
    {


        Console.WriteLine("Qual o número do aluno que deseja editar a nota?");
        int i = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(
            "Qual a nota de {0}? a nota atual é {1}"


             lista_chamada[i].Nome,
             lista_chamada[i].Notas
             );
        lista_chamada[i].Notas Convert.ToDouble(Console.ReadLine());

        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.WriteLine("A nota do aluno foi editada!");
        Console.BackgroundColor = ConsoleColor.Black;
    }


    else
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("A nota não foi alterada");
        Console.BackgroundColor = ConsoleColor.Black;
    }
}

public void editar_falta()
{

    if (lista_chamada.Count > 0)
    {
        Console.WriteLine("Qual o número do aluno que deseja editar as faltas?");
        int i = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(
        "Quantas faltas {0} tem? Total de faltas: {1} ",
        lista_chamada[i].Faltas,
        lista_chamada[i].Nome
        );

        lista_chamada[i].Faltas = Convert.ToDouble(Console.ReadLine());

        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("As faltas foram editadas com sucesso!");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Red;

        Console.WriteLine("Nenhuma falta foi alterada");
        Console.BackgroundColor = ConsoleColor.Black;
    }
}
