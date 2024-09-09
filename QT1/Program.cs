/*-------------------------------------------------------------------
Questão 1: Sistema de Cura de Personagem
Contextualização: Em um jogo de RPG, o jogador pode usar poções de cura para recuperar a vida do seu personagem durante a batalha. A quantidade de vida recuperada depende do tipo de poção, do nível do personagem e da quantidade de poções usadas.
•
Comando: Crie um programa que receba o tipo de poção (Pequena, Média, Grande), o nível do personagem e a quantidade de poções usadas. Crie uma função que calcule a quantidade de vida recuperada com base nos seguintes critérios:
•
Poção Pequena: 10 pontos de vida por poção.
•
Poção Média: 20 pontos de vida por poção.
•
Poção Grande: 30 pontos de vida por poção.
•
Adicione 5 pontos adicionais para cada nível do personagem acima de 5.
•
Exiba o total de vida recuperada.


@Lista: 04 - Funções
@Autor: João Lucas 
@Data: 02/09/2024
---------------------------------------------------------------------*/


using System;





     class Program
  {
        static void Main()
     {
        
        int nivel, quant;

        Console.WriteLine("Informe o tipo de porção:");
       string?  tipo = Console.ReadLine();

        Console.WriteLine("Informe seu nível: ");
        int.TryParse(Console.ReadLine(), out nivel);

        Console.WriteLine(" informe a quantidade de porção você deseja: ");
        int.TryParse(Console.ReadLine(), out quant);

         double total = Soma(nivel, quant, tipo);
        Console.WriteLine($"saída{total}");
         
        Console.ReadLine();
    }
    static double Soma(int nivel, int quant, string? tipo)
    {
       
        double total = 0;

        if (tipo == "pequena"){
        
            total = (10 + nivel) * quant;
            return total;
        }
        

        if(tipo == "media"){
        
            total = (20 + nivel) * quant;
            return total;
        }
        

        if(tipo == "grande"){
        
            total = (30 + nivel) * quant;
            return total;
        }
        
        return total;
    }

}   
