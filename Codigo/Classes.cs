using System.Reflection.Metadata.Ecma335;


namespace Biblioteca
{
    class classesParaBiblioteca
    {
        public string login = Console.ReadLine();
        public int senha;
    }
    public class argClassesParaBiblioteca
    {
        public string[] meusString;

        public argClassesParaBiblioteca(int tamanho)
        {
            meusString = new string[tamanho];
        }

        public void ExibirStrings()
        {
            foreach (var str in meusString)
            {
                Console.WriteLine(str);
            }
        }
    }
}
