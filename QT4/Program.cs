
/*-------------------------------------------------------------------
Questão 4: Sistema de Resgate em Labirinto
• Contextualização: Em um jogo de exploração, o jogador precisa resgatar aliados
perdidos em um labirinto. O sucesso do resgate depende da quantidade de energia, da
distância até o aliado e do nível de ameaça no caminho.
• Comando: Crie um programa que receba a energia do jogador, a distância até o aliado
(em metros) e o nível de ameaça (baixo, médio, alto). Crie uma função que determine
se o resgate é possível com base nas seguintes condições:
• Energia maior que 50: Resgate bem-sucedido.
• Distância menor que 20 metros: +10 de energia.
• Nível de ameaça:
o Baixo: Sem penalidade.
o Médio: -10 de energia.
o Alto: -20 de energia.
• Exiba se o resgate foi bem-sucedido ou falhou.

@Lista: 04 - funções
@Autor: ALICE ROCHA
@Data: 09/09/2024
---------------------------------------------------------------------*/

using System;
class Program
{
    static void Resgate()
    {
        int energia, distancia, nivelameaca;

        System.Console.WriteLine("Energia:");
        int.TryParse(System.Console.ReadLine(), out energia);
        System.Console.WriteLine("Distância (metros):");
        int.TryParse(System.Console.ReadLine(), out distancia);
        System.Console.WriteLine("Nível de ameaça 1 - Baixo 2 - Médio 3 - Alto:");
        int.TryParse(System.Console.ReadLine(), out nivelameaca);
        if (nivelameaca == 1)
        {
            if (energia > 50)
            {
                System.Console.WriteLine("Resgate bem-sucedido!");
            }
            else if (distancia < 20)
            {
                energia = +10;
                if (energia > 50)
                {
                    System.Console.WriteLine("Resgate bem-sucedido!");
                }
                else
                {
                    System.Console.WriteLine("Resgate falhou");
                }
            }
        }
        if (nivelameaca == 2)
        {
            energia = -10;
            if (energia > 50)
            {
                System.Console.WriteLine("Resgate bem-sucedido!");
            }
            else if (distancia < 20)
            {
                energia = +10;
                if (energia > 50)
                {
                    System.Console.WriteLine("Resgate bem-sucedido!");
                }
                else
                {
                    System.Console.WriteLine("Resgate falhou");
                }
            }

            else if (energia < 50)
            {
                System.Console.WriteLine("Resgate falhou");
            }
        }
        if (nivelameaca == 3)
        {
            energia -= 20;
            if (energia > 50)
            {
                System.Console.WriteLine("Resgate bem-sucedido!");
            }
            else if (energia < 50)
            {
                System.Console.WriteLine("Resgate falhou");
            }
            else if (distancia < 20)
            {
                energia += 10;
                if (energia > 50)
                {
                    System.Console.WriteLine("Resgate bem-sucedido!");
                }
                else if (energia < 50)
                {
                    System.Console.WriteLine("Resgate falhou");
                }
            }
        }
    }
    public static void Main(string[] args)
    {
        Resgate();
    }
}