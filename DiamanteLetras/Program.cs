using System.Globalization;

namespace DiamanteLetras {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe uma letra : ");
            char letra = Convert.ToChar(Console.ReadLine());
            int letraInt = (int)letra;
            int numeroLetra = letraInt - 64;
            char letraInicio = 'A';
            int tamanhoLinha = (numeroLetra * 2) - 1;
            int posicaoEsq = numeroLetra;
            int posicaoDir = numeroLetra;


            for (int i = 1; i <= numeroLetra; i++) {           //numeroLetra é a metade do diamente, o char q foi informado pelo usuario
                for (int j = 1; j <= tamanhoLinha; j++) {      //tamanho linha é o numero de caracteres que vai ter a linha
                    if (j == posicaoEsq || j == posicaoDir) {
                        Console.Write(letraInicio);
                    } else {
                        Console.Write(" ");
                    }
                }
                if (i != numeroLetra) {                       //comando para não adicionar no ultimo looping
                    Console.WriteLine();
                    posicaoEsq--;
                    posicaoDir++;
                    letraInicio++;
                }
            }

                Console.WriteLine();
                posicaoEsq++;
                posicaoDir--;
                letraInicio--;

            for (int i = 1; i < numeroLetra; i++) {

                for (int j = 1; j <= tamanhoLinha; j++) {
                    if (j == posicaoEsq || j == posicaoDir) {
                        Console.Write(letraInicio);
                    } else {
                        Console.Write(" ");
                    }
                }

                if (i != numeroLetra) {  
                    Console.WriteLine();
                    posicaoEsq++;
                    posicaoDir--;
                    letraInicio--;
                }


            }
        }
        }
}