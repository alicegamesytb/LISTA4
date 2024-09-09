/*-------------------------------------------------------------------
Questão 2: Sistema de Pontuação de Missões
• Contextualização: Em um jogo de aventuras, o jogador ganha pontos ao completar
missões. A pontuação é calculada com base na dificuldade da missão, na quantidade
de inimigos derrotados e no tempo gasto para completar.
• Comando: Crie um programa que receba a dificuldade da missão (Fácil, Média, Difícil),
o número de inimigos derrotados e o tempo gasto (em minutos). Crie uma função para
calcular a pontuação da missão usando os seguintes critérios:
• Fácil: 5 pontos por inimigo, sem penalidade de tempo.
• Média: 10 pontos por inimigo, -2 pontos por minuto acima de 10 minutos.
• Difícil: 15 pontos por inimigo, -5 pontos por minuto acima de 15 minutos.
• Exiba a pontuação final do jogador.

@Lista: 04 - funções
@Autor: Alice Rocha
@Data: 09/09/2024
---------------------------------------------------------------------*/

using System;
class Program
{
    static void Pontuacao()
    {
        int inimigos, tempo, ppi;
        string? dificuldade;

        System.Console.WriteLine("Dificuldade (fácil/médio/difícil):");
        dificuldade = System.Console.ReadLine();
        System.Console.WriteLine("Inimigos derrotados:");
        int.TryParse(System.Console.ReadLine(), out inimigos);
        System.Console.WriteLine("Tempo (min):");
        int.TryParse(System.Console.ReadLine(), out tempo);
        if (dificuldade == "fácil")
        {
            ppi = 5;
            System.Console.WriteLine($"{ppi * inimigos} pontos");
        }
        if (dificuldade == "médio")
        {
            ppi = 10;
            if (tempo > 10)
            {
                System.Console.WriteLine($"{inimigos * ppi - ((tempo - 10) * 2)} pontos");
            }
            else
            {
                System.Console.WriteLine($"{ppi * inimigos} pontos");
            }
        }
        if (dificuldade == "difícil")
        {
             ppi = 15;
            if (tempo > 15)
            {
                System.Console.WriteLine($"{inimigos * ppi - ((tempo - 15) * 5)} pontos");
            }
            else
            {
                System.Console.WriteLine($"{ppi * inimigos} pontos");
            }
        }

    }
    public static void Main(string[] args)
    {
        Pontuacao();
    }
}
