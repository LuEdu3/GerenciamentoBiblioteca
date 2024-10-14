using Microsoft.VisualBasic;

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

    }

}







