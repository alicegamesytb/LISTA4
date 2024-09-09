/*-------------------------------------------------------------------
Questão 3: Cálculo de Dano Crítico
• Contextualização: Em combates, o jogador pode realizar ataques críticos que causam
danos adicionais. O dano causado depende do ataque base, do multiplicador crítico e
da arma utilizada.
• Comando: Crie um programa que receba o valor do ataque base, o multiplicador crítico
(1.5x, 2x, 3x) e o tipo de arma (Espada, Arco, Cajado). Crie uma função que calcule o
dano crítico da seguinte forma:
• Espada: +10 pontos ao dano total.
• Arco: +5 pontos ao dano total.
• Cajado: +15 pontos ao dano total.
• Exiba o dano total causado pelo ataque crítico.

@Lista: 04 - funções
@Autor: Alice rocha 
@Data: 09/09/2024
---------------------------------------------------------------------*/

using System;
class Program
{
    static void Calculodano()
    {
        double atkbase, multiplicador, bonusarma;
        string? tipoarma;

        System.Console.WriteLine("Ataque base:");
        double.TryParse(System.Console.ReadLine(), out atkbase);
        System.Console.WriteLine("Multiplicador crítico:");
        double.TryParse(System.Console.ReadLine(), out multiplicador);
        System.Console.WriteLine("Tipo de arma (espada/arco/cajado):");
        tipoarma = Console.ReadLine();
        if (tipoarma == "espada")
        {
            bonusarma = 10;
            System.Console.WriteLine($"{(atkbase * multiplicador) + bonusarma} pontos");
        }
        if (tipoarma == "arco")
        {
            bonusarma = 5;
            System.Console.WriteLine($"{(atkbase * multiplicador) + bonusarma} pontos");
        }
        if (tipoarma == "cajado")
        {
            bonusarma = 15;
            System.Console.WriteLine($"{(atkbase * multiplicador) + bonusarma} pontos");
        }

    }
    public static void Main(string[] args)
    {
        Calculodano();
    }
}
