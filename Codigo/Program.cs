Console.Clear();

string[] biblioteca = { "Aventuras do Horizonte", "O Enigma do Vale Oculto", "Além da Fronteira", "Na Rota do Desafio", "O Legado do Explorador", "Rumo ao Desconhecido", "Exploradores da Terra Proibida", "O Mistério das Ruínas Antigas" };

Console.WriteLine("-".PadLeft(30, '-'));
Console.WriteLine("Biblioteca");
Console.WriteLine("-".PadLeft(30, '-'));
Console.WriteLine("Login");
Console.WriteLine("Nome de Usuário");
string nomeDeUsuario = Console.ReadLine().ToLower();

if (nomeDeUsuario == "admin")
{
    Console.WriteLine("");
}
else
{
    Console.WriteLine($"Bem vindo {nomeDeUsuario}");

    Console.WriteLine($"Livros disponíveis na biblioteca");
    Console.WriteLine($"{biblioteca[0]}");
    Console.WriteLine($"{biblioteca[1]}");
    Console.WriteLine($"{biblioteca[2]}");
    Console.WriteLine($"{biblioteca[3]}");
    Console.WriteLine($"{biblioteca[4]}");
    Console.WriteLine($"{biblioteca[5]}");
    Console.WriteLine($"{biblioteca[6]}");
    Console.WriteLine($"{biblioteca[7]}");

    List<string> lista = new List<string>(biblioteca);
    Console.WriteLine("Deseja alugar algum? (Limite por usuário 3 Livros):");
    string escolhaLivroUsuario = Console.ReadLine().ToLower();

    if (escolhaLivroUsuario == "s" || escolhaLivroUsuario == "Sim")
    {
        Console.WriteLine("Qual: ");
        string alugarLivroUsuario = Console.ReadLine();
        if (lista.Remove(alugarLivroUsuario))
        {
            Console.WriteLine("Livro alugado");
        }
        else
        {
            Console.WriteLine("Livro não encontrado");
        }

    }
}







