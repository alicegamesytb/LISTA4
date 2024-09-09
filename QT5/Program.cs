/*-------------------------------------------------------------------
Questão 5: Escolha de Habilidade Especial
• Contextualização: No jogo, o jogador pode usar habilidades especiais durante a
batalha. A escolha da habilidade depende da quantidade de mana disponível, do tipo de
inimigo e da distância do alvo.
• Comando: Crie um programa que receba a quantidade de mana, o tipo de inimigo
(Normal, Forte, Boss) e a distância do alvo (em metros). Crie uma função que sugira
qual habilidade usar com base nos seguintes critérios:
• Mana maior que 50: Use Habilidade Poderosa.
• Inimigo Forte ou Boss: +10 mana necessária.
• Distância menor que 10 metros: Reduz a mana necessária em 5.
• Exiba a habilidade sugerida.

@Lista: 04 - funções
@Autor: ALICE ROCHA 
@Data: 09/09/2024
---------------------------------------------------------------------*/

using System;
class Program
{
    static void HabilidadeEspecial()
    {
        int mana, tipoinimigo, distancia;

        System.Console.WriteLine("Mana:");
        int.TryParse(System.Console.ReadLine(), out mana);
        System.Console.WriteLine("Tipo de inimigo 1 - Normal 2 - Forte 3 - Boss:");
        int.TryParse(System.Console.ReadLine(), out tipoinimigo);
        System.Console.WriteLine("Distância (em metros)");
        int.TryParse(System.Console.ReadLine(), out distancia);
        if (tipoinimigo == 1)
        {
            if (distancia < 10)
            {
                if (mana > 45)
                {
                    System.Console.WriteLine("Use habilidade poderosa");
                }
                else
                {
                    {
                        System.Console.WriteLine("Use habilidade básica");
                    }   
                }
            }
            else if (distancia > 10)
            {
                if (mana > 50)
                {
                    System.Console.WriteLine("Use habilidade poderosa");
                }
                else
                {
                    {
                        System.Console.WriteLine("Use habilidade básica");
                    }   
                }
            }
        }
        if (tipoinimigo == 2)
        {
            if (distancia < 10)
            {
                if (mana > 55)
                {
                    System.Console.WriteLine("Use habilidade poderosa");
                }
                else
                {
                    {
                        System.Console.WriteLine("Use habilidade básica");
                    }   
                }
            }
            else if (distancia > 10)
            {
                if (mana > 60)
                {
                    System.Console.WriteLine("Use habilidade poderosa");
                }
                else
                {
                    {
                        System.Console.WriteLine("Use habilidade básica");
                    }   
                }
            }
        }
        if (tipoinimigo == 3)
        {
            if (distancia < 10)
            {
                if (mana > 55)
                {
                    System.Console.WriteLine("Use habilidade poderosa");
                }
                else
                {
                    {
                        System.Console.WriteLine("Use habilidade básica");
                    }   
                }
            }
            else if (distancia > 10)
            {
                if (mana > 60)
                {
                    System.Console.WriteLine("Use habilidade poderosa");
                }
                else
                {
                    {
                        System.Console.WriteLine("Use habilidade básica");
                    }   
                }
            }
        }
    }
    public static void Main(string[] args)
    {
        HabilidadeEspecial();
    }
}
