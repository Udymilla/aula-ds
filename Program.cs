using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Saladeaula
{
    public class Program : ProgramBase
    {
        private const ConsoleColor darkBlue1 = ConsoleColor.DarkBlue;
        private const ConsoleColor darkBlue = darkBlue1;

        static void Main(string[] args)
        {
            
            bool voltar_menu_inicial = false;

            int opcao_menu;

            Aluno dados_alunos = new Aluno();

            do
            {
                Console.Clear();


                Console.BackgroundColor = darkBlue2;



 Console.WriteLine("Deseja voltar ao menu? Sim ou não")
 voltar_menu = (Console.ReadLine().ToUpper() == "sim") ? true : false;
            } while (voltar_menu);
 Console.WriteLine("FIM (:");
Console.ReadKey();


            switch (opcao_menu)
            {

                case 1:
                    dados_alunos.listar();
                    break;

                case 2:
                    dados_alunos.excluir_aluno();
                    break;

                case 3:
                    dados_alunos.incluir_aluno();
                    break;

                case 4:
                    dados_alunos.editar_notas();
                    break;
                case 5:
                    dados_alunos.editar_faltas();
                    break;
                case 6:
                    Console.WriteLine("Fechar programa");
                    break;
            }




                    Console.WriteLine("Nossa aulinha");

Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("Selecione a opção desejada");
Console.WriteLine("1- Lista de alunos");
Console.WriteLine("2-Excluir aluno");
Console.WriteLine("3-Incluir aluno");
Console.WriteLine("4- Editar notas");
Console.WriteLine("5-Editar faltas");
Console.WriteLine("6- sair");


     boll escreve_certo = false;
       do
                {
                    escreve_certo = int.TryParse(Console.ReadLine(), out opcao_menu);
                    if (opcao_menu < 1 || opcao_menu > 6 || escreve_certo = = false)
                {

                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Por favor digite uma opção válida!");
                        Console.BackgroundColor = ConsoleColor.Black;

                        escreve_certo = false;
                    }
                } while (!escreve_certo);

