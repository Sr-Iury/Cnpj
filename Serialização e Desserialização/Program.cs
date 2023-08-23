using Validacao;

namespace Serialização_e_Desserialização
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Digite o seu CNPJ: ");
            string cnpj = Console.ReadLine();
            string cn = ValidaCNPJ.IsCnpj(cnpj).ToString();
            Console.WriteLine(cn);
        }
    }
}