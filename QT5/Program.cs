/*-------------------------------------------------------------------
@Lista: 04 - Funções
Questão 5: Escolha de Habilidade Especial
* Contextualização: No jogo, o jogador pode usar habilidades especiais durante a batalha. A escolha da habilidade depende da quantidade de mana disponível, do tipo de inimigo e da distância do alvo.
* Comando: Crie um programa que receba a quantidade de mana, o tipo de inimigo (Normal, Forte, Boss) e a distância do alvo (em metros). Crie uma função que sugira qual habilidade usar com base nos seguintes critérios:
* Mana maior que 50: Use Habilidade Poderosa.
* Inimigo Forte ou Boss: +10 mana necessária.
* Distância menor que 10 metros: Reduz a mana necessária em 5.
* Exiba a habilidade sugerida.
@Lista: 04 - Função
@Autor: João Lucas Saraiva
@Data: 09/09/2024
---------------------------------------------------------------------*/

using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Clear();
        string? tipo;
        double mana, distancia;

        Console.WriteLine("Informe a sua quantidade de mana? ");
        double.TryParse(Console.ReadLine(), out mana);

        Console.WriteLine("Informe a sua distância até ao alvo?");
        double.TryParse(Console.ReadLine(), out distancia);

        Console.WriteLine("Qual o tipo de inimigo ");
        tipo = Console.ReadLine();


        double total = Some( mana, distancia, tipo);
        Console.ReadLine();

        Console.WriteLine("o seu ataque foi de: " + total);
    }
    static double Some(double mana, double distancia, string? tipo)
    {

        double total = 0;
        
        if (tipo == "forte" || tipo == "boss")
        {
            if(distancia < 10)
            {
                if(mana > 55)
                {
                Console.WriteLine("Use Habilidade Poderosa");
                }
                else
                {
                    Console.WriteLine("Use Habilidade Básica");
                }
            }

        
        else if(mana > 60)
        {
                    Console.WriteLine("Use Habilidade Poderosa");
                }
                else
                {
                    Console.WriteLine("Use Habilidade Básica");
                }
            
        }
    
        else if(mana > 0)
        {
            if(distancia < 10)
            {
                if(mana >45)
                {
                    Console.WriteLine("Use Habilidade Poderosa");
                }
                else
                {
                      Console.WriteLine("Use Habilidade Básica");
                }
            }
        }
            else 
            {
            if(mana>50)
                {
                     Console.WriteLine("Use Habilidade Poderosa");
                }
                 else
                {
                      Console.WriteLine("Use Habilidade Básica");
                }
            }
            return total;
        }
    }
