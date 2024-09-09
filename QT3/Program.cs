/*-------------------------------------------------------------------
@Lista: 04 - Funções
Questão 3: Cálculo de Dano Crítico
* Contextualização: Em combates, o jogador pode realizar ataques críticos que causam
danos adicionais. O dano causado depende do ataque base, do multiplicador crítico e
da arma utilizada.
* Comando: Crie um programa que receba o valor do ataque base, o multiplicador crítico
(1.5x, 2x, 3x) e o tipo de arma (Espada, Arco, Cajado). Crie uma função que calcule o
dano crítico da seguinte forma:
* Espada: +10 pontos ao dano total.
* Arco: +5 pontos ao dano total.
* Cajado: +15 pontos ao dano total.
* Exiba o dano total causado pelo ataque crítico.
@Autor: João Lucas Saraiva
@Data: 03/09/2024
---------------------------------------------------------------------*/
using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Clear();
        string? tipoA;
        double ataqueB, multi;

        Console.WriteLine("informe quanto foi o ataque base: ");
        double.TryParse(Console.ReadLine(), out ataqueB);

        Console.WriteLine("informe o seu multiplicador: ");
        double.TryParse(Console.ReadLine(), out multi);

        Console.WriteLine("informe o tipo de arma usando números (espada, arco ou cajado): ");
        tipoA = Console.ReadLine();


        
       double total = Some(ataqueB, multi, tipoA);

        Console.WriteLine("o seu ataque foi de: " +total);

        
        Console.ReadLine();
    }
    static double Some(double ataqueB, double multi, string? tipoA)
    {

        double total = 0;
        if (tipoA == "arco")
        {
            total = (multi * ataqueB) + 10;
        }

        if (tipoA == "cajado")
        {
            total = (multi * ataqueB) + 5;
        }

        if (tipoA == "espada")
        {
            total = (multi * ataqueB) + 15;
        }
        return total;


    }


}
