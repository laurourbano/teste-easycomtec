using System;

public class Solution
{
    public bool DetectCapitalUse(string word)
    {
        // Primeira situação: Todas as letras são maiúsculas
        if (word == word.ToUpper()) return true;
        // Segunda situação: Todas as letras são minúsculas
        if (word == word.ToLower()) return true;
        // Terceira situação: Apenas a primeira letra é maiúscula
        if (char.IsUpper(word[0]) && word.Substring(1) == word.Substring(1).ToLower()) return true;

        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // faz a classe Solution
        Solution solution = new Solution();

        // digita uma palavra
        Console.Write("Digite uma palavra para verificar o uso de maiúsculas: ");
        string? input = Console.ReadLine();
        if (input == null)
        {
            Console.WriteLine("Entrada nula não é permitida.");
            return;
        }

        // vê se a palavra tá nas regras de maiúsculas
        bool result = solution.DetectCapitalUse(input);

        // mostra o resultado
        Console.WriteLine(result ? "A palavra está no formato correto." : "A palavra NÃO está no formato correto.");
    }
}
