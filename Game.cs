using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{

    class Game
    {
        const int NUM = 4;
        Dictionary<int, string> BibCores = new Dictionary<int, string>();
        int[] DesafioCores;//= new int[NUM];
        int[] Jogada;// = new int[NUM];
        Random random;


        public Game()
        {
            random = new Random();

            AddCores();
            //SorteioCores();
            //PedirEscolha();
            //VerificarGanhou(VerificarJogada(Jogada, DesafioCores));

            //testes
            DesafioCores = new int[] { 5, 3, 5, 3 };
            Jogada = new int[] { 3, 4, 5, 5 };
            //VerificarGanhou(VerificarJogada(Jogada, DesafioCores));
            if(!VerificarGanhou(VerificarJogada(Jogada, DesafioCores)))
            {
                OutputSolucaoJogador(VerificarJogada(Jogada, DesafioCores));
            }
            
            //    foreach (int i in DesafioCores)
            //    { 
            //        Console.WriteLine(i); }

        }

        int RandomNumber(int min, int max)
        {
            return this.random.Next(min, max);
        }

        void AddCores()
        {
            BibCores.Add(1, "Azul");
            BibCores.Add(2, "Verde");
            BibCores.Add(3, "Amarelo");
            BibCores.Add(4, "Vermelho");
            BibCores.Add(5, "Castanho");
            BibCores.Add(6, "Rosa");
            BibCores.Add(7, "Roxo");
            BibCores.Add(8, "Laranaja");
            BibCores.Add(9, "Ameixa");
            BibCores.Add(10, "Preto");
            
        }

        void SorteioCores()
        {
            for(int i = 0; i < DesafioCores.Length; i++)
            {
                DesafioCores[i] = BibCores.Keys.ElementAt(RandomNumber(0,BibCores.Count));
            }

        }

        void Info()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma cor pelo Digito correspondente\n" +
            "[1 - Azul] [2 - Verde] [3 - Amarelo]\n" +
            "[4 - Vermelho] [5 - Castanho] [6 - Rosa]\n" +
            "[7 - Roxo] [8 - Laranja] [9 - Ameixa] [10 - Preto] ");
        }

        void PedirEscolha()
        {
     
            for (int i = 0; i < Jogada.Length; i++)
            { 
                Info();
                Console.Write(i + 1 + "º Cor: ");
                Jogada[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int[] VerificarJogada(int[] Jogada, int[] DesafioCores)
        {
            int[] solucao = new int[DesafioCores.Length];
            for(int i = 0; i < Jogada.Length; i++)
            {
               for(int j = 0; j < DesafioCores.Length; j++)
                {
                    if (Jogada[i] == DesafioCores[j])
                    {
                        if (i == j)
                        {
                            solucao[i] = 2;
                            break;
                        }
                            
                        else
                            solucao[i] = 1;
                    }
                    else
                    {
                        if ( solucao[i]==1 )
                            continue;
                        solucao[i] = 0;
                    }
                }
            }
            return solucao;
        }

        bool VerificarGanhou(int[] solucao)
        {
            for(int i = 0; i < solucao.Length; i++)
            {
                if(solucao[i] != 2)
                {
                    return false;
                }
            }
            return true;
        }

        int[] OutputSolucaoJogador(int[] solucao)
        {
            int[] cloneArray = new int[4];
            int[] randArray = new int[] { RandomNumber(0, 4), -1,-1,-1};
            bool flag = false, flag1 = false;
            int randNum;
            int aux = 0;

            //solucao.ToList().Sort();
            
            while (!flag) { 
                randNum = RandomNumber(0, 4);
                
                for (int j = 0; j < randArray.Length; j++)
                {
                    if (randNum == randArray[j])
                    {
                        flag1 = true;
                        break;
                    }
                           
                }
                if (!flag1)
                {
                    randArray[++aux] = randNum;
                }
                flag1 = false;
                if (randArray[randArray.Length - 1] != -1)
                    flag = true;

            }

            for (int i = 0; i < solucao.Length; i++)
            {
                cloneArray[i] = solucao[randArray[i]];
            }

            return cloneArray;
        }
    
    }
}
