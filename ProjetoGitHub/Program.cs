using System;

namespace ProjetoGitHub;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var produto = new Produto();
        produto.Descricao = "Teclado";
        produto.Id = 1;

        Console.WriteLine($"Produto: {produto.Descricao}");
    }
}