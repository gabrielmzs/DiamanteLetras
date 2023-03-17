using System.Globalization;

namespace DiamanteLetras {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe uma letra : ");
            char letra = Convert.ToChar(Console.ReadLine());
            int letraInt = (int)letra;                         //transformar o char informado pelo usuario no numero int da tabela ascii                         
            int numeroLetra = letraInt - 64;                   //ex: letra 'E' = 69 na tab ascii, 69-64 = 5, a letra E' é a quinta letra do alfabeto   
            char letraInicio = 'A';                            //a primeira letra do diamante sempre será 'A'
            int tamanhoLinha = (numeroLetra * 2) - 1;          //determina o tamanho da linha da maior, deixando ela sempre impar para o diamante centralizar
            int posicaoEsq = numeroLetra;                      //o diamante ira começar no meio da linha, e após isso
            int posicaoDir = numeroLetra;                      //cada letra anda uma posicão para esquerda ou direita a cada linha


            for (int i = 1; i <= numeroLetra; i++) {           //numeroLetra é a metade do diamante, o char q foi informado pelo usuario
                for (int j = 1; j <= tamanhoLinha; j++) {      //tamanho linha é o numero de caracteres que vai ter a linha
                    if (j == posicaoEsq || j == posicaoDir) {
                        Console.Write(letraInicio);
                    } else {
                        Console.Write(" ");
                    }
                }
                if (i != numeroLetra) {                         //comando para não adicionar no ultimo looping
                    Console.WriteLine();                        //pula a linha para fazer uma nova leitura
                    posicaoEsq--;                               //a cada linha pulada, o char se mexe uma unidade para esquerda
                    posicaoDir++;                               //a cada linha pulada, o outro char se mexe uma unidade para direita
                    letraInicio++;                              //escrever na proxima linha a proxima letra do alfabeto
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