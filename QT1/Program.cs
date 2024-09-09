/*-------------------------------------------------------------------
Questão 1: Sistema de Cura de Personagem
• Contextualização: Em um jogo de RPG, o jogador pode usar poções de cura para
recuperar a vida do seu personagem durante a batalha. A quantidade de vida
recuperada depende do tipo de poção, do nível do personagem e da quantidade de
poções usadas.
• Comando: Crie um programa que receba o tipo de poção (Pequena, Média, Grande), o
nível do personagem e a quantidade de poções usadas. Crie uma função que calcule a
quantidade de vida recuperada com base nos seguintes critérios:
• Poção Pequena: 10 pontos de vida por poção.
• Poção Média: 20 pontos de vida por poção.
• Poção Grande: 30 pontos de vida por poção.
• Adicione 5 pontos adicionais para cada nível do personagem acima de 5.
• Exiba o total de vida recuperada.
@Lista: 04 - funções
@Autor: Alice Rocha 
@Data: 03/09/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    static void main()
    {
        
        int cura = 0, quant, nivel;
        string? escolha;

        System.Console.WriteLine("Tipo de poção (P/M/G):");
        escolha = System.Console.ReadLine();
        System.Console.WriteLine("Nível do jogador:");
        int.TryParse(System.Console.ReadLine(), out nivel);
        System.Console.WriteLine("Quantidade de poções:");
        int.TryParse(System.Console.ReadLine(), out quant);
        if (escolha == "p" || escolha == "P")
        {
            cura = 10;
            if (nivel >= 5)
            {
                System.Console.WriteLine($"{(cura * quant) + ((nivel - 5) * 5)} pontos");
            }
            else
            {
                System.Console.WriteLine($"{cura * quant} pontos");
            }
        }
        if (escolha == "m" || escolha == "M")
        {
            cura = 30;
            if (nivel > 5)
            {
                System.Console.WriteLine($"{(cura * quant) + ((nivel - 5) * 5)} pontos");
            }
            else
            {
                System.Console.WriteLine($"{cura * quant} pontos");
            }
        }
        if (escolha == "g" || escolha == "G")
        {
            cura = 30;
            if (nivel > 5)
            {
                System.Console.WriteLine($"{(cura * quant) + ((nivel - 5) * 5)} pontos");
            }
            else
            {
                System.Console.WriteLine($"{cura * quant} pontos");
            }
        }

    }
    public static void Main(string[] args)
    {
        
    }
}
    