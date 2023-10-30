// Média 1

/*
Cálculo da Média Ponderada de Notas

Você deve ler dois valores decimais, representando as notas de um aluno, chamados A e B. 
As notas variam de 0 a 10, com uma casa decimal. A nota A tem um peso de 3.5, enquanto a 
nota B tem um peso de 7.5, totalizando um peso combinado de 11. Você deve calcular a média 
ponderada do aluno com base nessas notas e pesos.

Entrada:

O programa deve receber dois valores decimais, cada um com uma casa decimal.

Saída:

Calcule e imprima a média ponderada com 5 dígitos após o ponto decimal. Inclua um espaço 
antes e depois do sinal de igual. Certifique-se de adicionar uma nova linha após a saída do resultado.

Se as notas de entrada não estiverem no intervalo de 0 a 10, você deve exibir a mensagem 
"Nota deve ser maior que 0 e menor que 10!" e encerrar o programa.
*/

using System;

namespace Start { 
    class Program {
        static void Main() {
            Console.WriteLine("Digite a primeira nota com uma casa decimal: ");
            double A = Convert.ToDouble(Console.ReadLine());

            if (A >= 0 && A <= 10)
            {
                string A_Formatado = A.ToString("F1");// "F1" significa uma casa decimal
            }
            else
            {
                Console.WriteLine("Nota deve ser maior que 0 e menor que 10!");
                return; // código será interrompido
            }

            Console.WriteLine("Digite a segunda nota com uma casa decimal: ");
            double B = Convert.ToDouble(Console.ReadLine());

            if (B >= 0 && B <= 10)
            {
                string B_Formatado = B.ToString("F1");
            }
            else
            {
                Console.WriteLine("Nota deve ser maior que 0 e menor que 10!");
                return; // código será interrompido
            }

            double MEDIA = (3.5 * A + 7.5 * B) / (3.5 + 7.5);

            string MEDIA_Formatado = MEDIA.ToString("F5");

            Console.WriteLine("A média ponderada é: " + MEDIA_Formatado);
            Console.WriteLine(); // Adicione uma nova linha após o resultado
        }
    }
}