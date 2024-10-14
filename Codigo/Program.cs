<<<<<<< HEAD
﻿using Microsoft.VisualBasic;

Console.Clear();
bool retorno = false;
List<int> id = [1, 2, 3];

List<string> titulo = ["Aventuras do Horizonte", "O Enigma do Vale Oculto", "Além da Fronteira"];

List<string> autor = ["Lara Mendes", "Rafael Gomes", "Sofia Costa"];

List<string> genero = ["Narrativa", "Poesia", "Teatro"];

List<int> unidades = [1, 2, 4];

return1:
return2:
Console.WriteLine("-".PadLeft(30, '-'));
Console.WriteLine("Biblioteca");
Console.WriteLine("-".PadLeft(30, '-'));
Console.WriteLine("Login");
Console.WriteLine("Nome de Usuário");
string nomeDeUsuario = Console.ReadLine();

Console.WriteLine("Você é administrador? ");
string admin1 = Console.ReadLine();
while (!retorno)
{
    if (admin1 == "s")
    {
        Console.WriteLine("1 Exibir Catálogo");
        Console.WriteLine("2 Cadastrar Livros");
        Console.WriteLine("4 Voltar");
        Console.WriteLine(" ");
        int escolhaAdmin = int.Parse(Console.ReadLine());
        switch (escolhaAdmin)
        {
            case 1:
                for (int cont = 0; cont < titulo.Count(); cont++)
                {
                    Console.WriteLine("-".PadLeft(30, '-'));
                    Console.WriteLine($"{cont + 1})Livro: {titulo[cont]}");
                    Console.WriteLine($"  ID: {id[cont]}");
                    Console.WriteLine($"  Autor: {autor[cont]}");
                    Console.WriteLine($"  Gênero: {genero[cont]}");
                    if (unidades[cont] > 0)
                    {
                        Console.WriteLine($"Unidades disponíveis {unidades[cont]}");
                    }
                    else
                    {
                        Console.WriteLine($"Unidades disponíveis {unidades[cont]}");
                    }
                }
                break;

            case 2:
                Console.WriteLine("ID:");
                id.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine("Nome Do Livro: ");
                titulo.Add(Console.ReadLine());
                Console.WriteLine("Autor: ");
                autor.Add(Console.ReadLine());
                Console.WriteLine("Gênero: ");
                genero.Add(Console.ReadLine());
                Console.WriteLine("Quantidade:");
                unidades.Add(int.Parse(Console.ReadLine()));
                break;

            case 4:
                Console.WriteLine("Voltando ao Login...");
                goto return1;
                break;
            default:
                break;
        }
    }
    else
    {
        while (!retorno)
        {
            Console.WriteLine("1 Exibir Catálogo");
            Console.WriteLine("2 Emprestar Livros");
            Console.WriteLine("3 Verificar Aluguel");
            Console.WriteLine("4 Devolver Livros");
            Console.WriteLine("5 Voltar");

            int usuario1 = int.Parse(Console.ReadLine());

            switch (usuario1)
            {
                case 1:
                    for (int cont = 0; cont < titulo.Count(); cont++)
                    {
                        Console.WriteLine("-".PadLeft(30, '-'));
                        Console.WriteLine($"{cont + 1})Livro: {titulo[cont]}");
                        Console.WriteLine($"  Autor: {autor[cont]}");
                        Console.WriteLine($"  Gênero: {genero[cont]}");
                        if (unidades[cont] > 0)
                        {
                            Console.WriteLine($"Unidades disponíveis {unidades[cont]}");
                        }
                        else
                        {
                            Console.WriteLine($"Unidades disponíveis {unidades[cont]}");
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Qual ID do livro que deseja alugar: ");
                    int livroAlugado = int.Parse(Console.ReadLine());
                    int i = 0;
                    foreach (var idt in id)
                    {
                        if (idt == livroAlugado)
                        {
                            if (unidades[i] <= 0)
                            {
                                Console.WriteLine("Livro Indisponível");
                            }
                            else
                            {
                                unidades[i]--;
                            }
                        }
                        else
                        {
                            i++;
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine($"{livroAlugado[cont]}");
                    break;
                case 5:
                    Console.WriteLine("Voltando ao Menu...");
                    goto return2;
                    break;
            }
            break;
        }
=======
﻿
// bool repetir = false;
// string[] biblioteca = { "Aventuras do Horizonte", "O Enigma do Vale Oculto", "Além da Fronteira", "Na Rota do Desafio", "O Legado do Explorador", "Rumo ao Desconhecido", "Exploradores da Terra Proibida", "O Mistério das Ruínas Antigas" };

// Console.WriteLine("-".PadLeft(30, '-'));
// Console.WriteLine("Biblioteca");
// Console.WriteLine("-".PadLeft(30, '-'));
// Console.WriteLine("Login");
// Console.WriteLine("Nome de Usuário");
// string nomeDeUsuario = Console.ReadLine().ToLower();

// if (nomeDeUsuario == "admin")
// {
//     Console.WriteLine("");
// }
// else
// {
//     Console.WriteLine($"Bem vindo {nomeDeUsuario}");

//     Console.WriteLine($"Livros disponíveis na biblioteca");
//     Console.WriteLine($"{biblioteca[0]}");
//     Console.WriteLine($"{biblioteca[1]}");
//     Console.WriteLine($"{biblioteca[2]}");
//     Console.WriteLine($"{biblioteca[3]}");
//     Console.WriteLine($"{biblioteca[4]}");
//     Console.WriteLine($"{biblioteca[5]}");
//     Console.WriteLine($"{biblioteca[6]}");
//     Console.WriteLine($"{biblioteca[7]}");

//     List<string> lista = new List<string>(biblioteca);
//     while (!repetir)
//     {
//         Console.WriteLine("Deseja alugar algum? (Limite por usuário 3 Livros):");
//         string escolhaLivroUsuario = Console.ReadLine().ToLower();

//         if (escolhaLivroUsuario == "s" || escolhaLivroUsuario == "Sim")
//         {
//             Console.WriteLine("Qual: ");
//             string alugarLivroUsuario = Console.ReadLine();
//             if (lista.Remove(alugarLivroUsuario))

//             {
//                 Console.WriteLine("Livro alugado");
//             }
//             else
//             {
//                 Console.WriteLine("Livro não encontrado");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Não");
//             break;
//         }
//     }
// }
using Microsoft.VisualBasic;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o login");
            classesParaBiblioteca novoLogin = new classesParaBiblioteca();
>>>>>>> c5c7386137eaf5c7371669f18da55a680f738c01

            Console.WriteLine(novoLogin.login);
            argClassesParaBiblioteca obj = new argClassesParaBiblioteca(3);

            obj.meusString[0] = "Aventuras do Horizonte";
            obj.meusString[1] = "O Enigma do Vale Oculto";
            obj.meusString[2] = "Além da Fronteira";
            Console.WriteLine(obj.meusString[0]);
            Console.WriteLine(obj.meusString[1]);
            Console.WriteLine(obj.meusString[2]);

            Console.WriteLine("Digite qualquer tecla para alugar um livro || Digite não para sair");
            string alugarLivroUsuario = Console.ReadLine().ToLower();
            if(alugarLivroUsuario == "s" || alugarLivroUsuario == "sim")
            {
                Console.WriteLine("Digite o nome do livro: ");
            }
        }
    }

}




