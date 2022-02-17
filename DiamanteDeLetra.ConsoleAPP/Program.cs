using System;

namespace DiamanteDeLetra.ConsoleAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {


                Console.WriteLine("Diamante de Letras\n");

                #region array de char letras
                char[] letras = new char[26];
                letras[0] = 'A';
                letras[1] = 'B';
                letras[2] = 'C';
                letras[3] = 'D';
                letras[4] = 'E';
                letras[5] = 'F';
                letras[6] = 'G';
                letras[7] = 'H';
                letras[8] = 'I';
                letras[9] = 'J';
                letras[10] = 'K';
                letras[11] = 'L';
                letras[12] = 'M';
                letras[13] = 'N';
                letras[14] = 'O';
                letras[15] = 'P';
                letras[16] = 'Q';
                letras[17] = 'R';
                letras[18] = 'S';
                letras[19] = 'T';
                letras[20] = 'U';
                letras[21] = 'V';
                letras[22] = 'W';
                letras[23] = 'X';
                letras[24] = 'Y';
                letras[25] = 'Z';
                #endregion

                #region recebe variavel n 
                Console.Write("*Digite um número impar entre 3 e 25. Altura do Diamante: ");
                int n = int.Parse(Console.ReadLine());
                #endregion

                #region verifica n 
                while (n < 3 || n > 25 || n % 2 == 0)
                {
                    Console.Write("*Digite um número impar entre 3 e 25. Altura do Diamante: ");
                    n = int.Parse(Console.ReadLine());

                }
                #endregion


                Console.WriteLine(" ");

                #region variaveis de controle 

                int meioDiamante = (n - 1) / 2;
                string espacoDentro = " ";
                int indiceLetra = 1;
                int controlaLinhas = 1;
                int meio = (n - 1) / 2;
                char[] emBranco = new char[1];
                emBranco[0] = ' ';
                #endregion

                #region imprime primeira linha A
                for (int i = 0; i < meioDiamante; i++)
                {
                    Console.Write(emBranco[0]);
                }
                Console.WriteLine(letras[0]);
                #endregion

                #region [parte superior] for segunda linha até meio do diamante 
                for (int i = 0; i < meioDiamante; i++)
                {
                    //espaco antes letra
                    for (int j = controlaLinhas; j < meioDiamante; j++)
                    {
                        Console.Write(emBranco[0]);
                    }
                    //letra + espacoDentro + letra
                    Console.Write(letras[indiceLetra] + espacoDentro + letras[indiceLetra]);
                    espacoDentro = espacoDentro + "  ";

                    //espaco depois letra
                    for (int k = controlaLinhas; k < meioDiamante; k++)
                    {
                        Console.Write(emBranco[0]);
                    }

                    Console.WriteLine();
                    controlaLinhas++;
                    indiceLetra++;
                }
                #endregion

                #region [parte inferior] for começa meio até penúltima linha 
                controlaLinhas = meioDiamante;
                indiceLetra = meioDiamante - 1;
                int controladorEspaco = espacoDentro.Length - 4;

                for (int i = 1; i < meioDiamante; i++)
                {
                    //espaco antes letra
                    for (int j = controlaLinhas; j <= meioDiamante; j++)
                    {
                        Console.Write(emBranco[0]);
                    }

                    //letra + espacoDentro + letra
                    espacoDentro = espacoDentro.Substring(0, controladorEspaco);
                    Console.Write(letras[indiceLetra] + espacoDentro + letras[indiceLetra]);
                    controladorEspaco = controladorEspaco - 2;

                    // espaco não pode ser menor do que 1
                    if (controladorEspaco <= 1)
                    {
                        controladorEspaco = 1;
                    }

                    //espaco depois letra
                    for (int k = controlaLinhas; k < meioDiamante; k++)
                    {
                        Console.Write(emBranco[0]);
                    }

                    Console.WriteLine();
                    controlaLinhas--;
                    indiceLetra--;
                }
                #endregion

                #region imprime última linha A
                for (int i = 0; i < meioDiamante; i++)
                {
                    Console.Write(emBranco[0]);
                }
                Console.WriteLine(letras[0]);
                #endregion


                #region menu continuar 
                Console.WriteLine("\n\nDigite 1 para continuar ou 0 para sair");
                string strContinuar = Console.ReadLine();
                if (strContinuar != "1" && strContinuar != "0")
                {

                    Console.WriteLine("Digite 1 para continuar ou 0 para sair");
                    strContinuar = Console.ReadLine();
                }
                if (strContinuar == "1")
                {
                    Console.Clear();
                    continuar = true;
                }
                else if (strContinuar == "0")
                {
                    continuar = false;
                }
                #endregion



            }
        }
    }
}