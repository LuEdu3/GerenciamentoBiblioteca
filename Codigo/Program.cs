
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




