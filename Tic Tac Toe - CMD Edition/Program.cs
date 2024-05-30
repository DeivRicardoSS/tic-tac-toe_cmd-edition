using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe___CMD_Edition
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine
                ($"=========Tic=Tac=Toe==========\n\n" +
                 $"1 - Player Vs Bot\n" +
                 $"2 - Player Vs Player\n" +
                 $"3 - Exit\n\n");

            int cntrl = int.Parse(Console.ReadLine());
            if (cntrl == 2)
            {
                StartPvp(1);
            }
            else if (cntrl == 1)
            {
                Console.Clear();
                Console.WriteLine
                ($"=========Game=Mode==========\n\n" +
                 $"1 - Easy\n" +
                 $"2 - Hard\n");
                cntrl = int.Parse(Console.ReadLine());
                if (cntrl == 1)
                {
                    StartPvp(2);
                }
                else
                {
                    StartPvp(3);
                }
            }


            Console.ReadKey();

        }

        public static void StartPvp(int modo)
        {

            string[,] gp =
            {
                {"7", "8", "9"},
                {"4", "5", "6"},
                {"1", "2", "3"}
            };

            int x = 0;
            int o = 0;

            int r = 1;

            string rodada = "x";

            string jogada = "";

            string codErro = "";

            string status = "andamento";

            string alert()
            {
                string msg = "";
                if (codErro == "1")
                {
                    msg = "O espao que voc  selecionou j  est  oculpado";
                }
                else if (codErro == "x")
                {
                    msg = "[x] GANHOU A PARTIDA";
                }
                else if (codErro == "o")
                {
                    msg = "[o] GANHOU A PARTIDA";
                }
                else if (codErro == "0")
                {
                    msg = "EMPATE!!";
                }
                return msg;
            }

            void exibirGame()
            {
                Console.Clear();
                Console.WriteLine("x: " + x + " || o: " + o);
                Console.WriteLine("Vez de " + rodada);
                Console.Write
               ($"[{gp[0, 0]}] [{gp[0, 1]}] [{gp[0, 2]}]\n" +
                $"[{gp[1, 0]}] [{gp[1, 1]}] [{gp[1, 2]}]\n" +
                $"[{gp[2, 0]}] [{gp[2, 1]}] [{gp[2, 2]}]\n \n");
                Console.WriteLine(alert());
            }

            void processarEntrada()
            {
                var rand = new Random();
                if (modo == 1)
                {
                    jogada = Console.ReadLine();
                }
                else if (modo == 2)
                {
                    if (rodada == "x")
                    {
                        jogada = Console.ReadLine();
                    }
                    else
                    {
                        int num = rand.Next(10);
                        jogada = num.ToString();
                    }
                }
                else
                {
                    if (rodada == "x")
                    {
                        jogada = Console.ReadLine();
                    }
                    else
                    {
                        jogada = Bot(gp, r);
                    }
                }


                switch (jogada)
                {
                    case "7":
                        if (gp[0, 0] == "7")
                        {
                            codErro = "";
                            gp[0, 0] = rodada;
                        }
                        else
                        {
                            codErro = "1";
                            Console.WriteLine("Casa selecionada j  foi usada");
                        }
                        break;
                    case "8":
                        if (gp[0, 1] == "8")
                        {
                            codErro = "";
                            gp[0, 1] = rodada;
                        }
                        else
                        {
                            codErro = "1";
                            Console.WriteLine("Casa selecionada j  foi usada");
                        }
                        break;
                    case "9":
                        if (gp[0, 2] == "9")
                        {
                            codErro = "";
                            gp[0, 2] = rodada;
                        }
                        else
                        {
                            codErro = "1";
                            Console.WriteLine("Casa selecionada j  foi usada");
                        }
                        break;
                    case "4":
                        if (gp[1, 0] == "4")
                        {
                            codErro = "";
                            gp[1, 0] = rodada;
                        }
                        else
                        {
                            codErro = "1";
                            Console.WriteLine("Casa selecionada j  foi usada");
                        }
                        break;
                    case "5":
                        if (gp[1, 1] == "5")
                        {
                            codErro = "";
                            gp[1, 1] = rodada;
                        }
                        else
                        {
                            codErro = "1";
                            Console.WriteLine("Casa selecionada j  foi usada");
                        }
                        break;
                    case "6":
                        if (gp[1, 2] == "6")
                        {
                            codErro = "";
                            gp[1, 2] = rodada;
                        }
                        else
                        {
                            codErro = "1";
                            Console.WriteLine("Casa selecionada j  foi usada");
                        }
                        break;
                    case "1":
                        if (gp[2, 0] == "1")
                        {
                            codErro = "";
                            gp[2, 0] = rodada;
                        }
                        else
                        {
                            codErro = "1";
                            Console.WriteLine("Casa selecionada j  foi usada");
                        }
                        break;
                    case "2":
                        if (gp[2, 1] == "2")
                        {
                            codErro = "";
                            gp[2, 1] = rodada;
                        }
                        else
                        {
                            codErro = "1";
                            Console.WriteLine("Casa selecionada j  foi usada");
                        }
                        break;
                    case "3":
                        if (gp[2, 2] == "3")
                        {
                            codErro = "";
                            gp[2, 2] = rodada;
                        }
                        else
                        {
                            codErro = "1";
                            Console.WriteLine("Casa selecionada j  foi usada");
                        }
                        break;




                }


            }

            void verificar()
            {
                if (gp[0, 0] == rodada && gp[0, 1] == rodada && gp[0, 2] == rodada || gp[1, 0] == rodada && gp[1, 1] == rodada && gp[1, 2] == rodada || gp[2, 0] == rodada && gp[2, 1] == rodada && gp[2, 2] == rodada)
                {

                    pontuar();
                }
                else if (gp[0, 0] == rodada && gp[1, 0] == rodada && gp[2, 0] == rodada || gp[0, 1] == rodada && gp[1, 1] == rodada && gp[2, 1] == rodada || gp[0, 2] == rodada && gp[1, 2] == rodada && gp[2, 2] == rodada)
                {

                    pontuar();
                }
                else if (gp[0, 0] == rodada && gp[1, 1] == rodada && gp[2, 2] == rodada || gp[2, 0] == rodada && gp[1, 1] == rodada && gp[0, 2] == rodada)
                {

                    pontuar();
                }
                else if (gp[0, 0] != "7" && gp[0, 1] != "8" && gp[0, 2] != "9" && gp[1, 0] != "4" && gp[1, 1] != "5" && gp[1, 2] != "6" && gp[2, 0] != "1" && gp[2, 1] != "2" && gp[2, 2] != "3")
                {
                    codErro = "0";
                    status = "fim";
                }
                else
                {

                    trocarRodada();
                }
            }

            void trocarRodada()
            {
                r++;
                if (rodada == "x" && codErro != "1")
                {
                    rodada = "o";
                }
                else if (rodada == "o" && codErro != "1")
                {
                    rodada = "x";
                }
            }

            void pontuar()
            {
                r = 1;
                codErro = rodada;
                if (rodada == "x")
                {
                    x++;
                }
                else
                {
                    o++;
                }
                status = "fim";
            }

            void restart()
            {
                gp[0, 0] = "7"; gp[0, 1] = "8"; gp[0, 2] = "9";
                gp[1, 0] = "4"; gp[1, 1] = "5"; gp[1, 2] = "6";
                gp[2, 0] = "1"; gp[2, 1] = "2"; gp[2, 2] = "3";

                status = "andamento";
            }

            int adm = 1;
            do
            {
                while (status == "andamento")
                {
                    exibirGame();
                    processarEntrada();
                    verificar();
                    exibirGame();
                }

                Console.WriteLine("Pressione: 1 => Reiniciar | 0 => Terminar");
                adm = int.Parse(Console.ReadLine());
                if (adm == 1)
                {
                    restart();
                    status = "andamento";
                }
                else
                {
                    break;
                }
            } while (adm == 1);


        }

        public static string Bot(string[,] gp, int r)
        {
            var rand = new Random();

            if (gp[1, 1] == "x" && r == 1)
            {
                int num = 0;

                bool achou = false;

                while (achou == false)
                {
                    num = rand.Next(10);

                    if (num == 7 || num == 9 || num == 1 || num == 3)
                    {
                        achou = true;
                    }

                }

                return num.ToString();
            }

            else if (gp[0, 0] == "x" && r == 1 || gp[0, 2] == "x" && r == 1 || gp[2, 0] == "x" && r == 1 || gp[2, 2] == "x" && r == 1)
            {
                int prob = rand.Next(3);
                int num = 0;

                bool achou = false;

                if (prob == 1)
                {
                    while (achou == false)
                    {
                        num = rand.Next(10);

                        if (num == 7 || num == 9 || num == 1 || num == 3)
                        {
                            achou = true;
                        }

                    }
                }
                else
                {
                    num = 5;
                }



                return num.ToString();
            }

            else if (gp[0, 1] == "x" && r == 1 || gp[1, 0] == "x" && r == 1 || gp[1, 2] == "x" && r == 1 || gp[2, 1] == "x" && r == 1)
            {

                int num = 5;
                return num.ToString();
            }

            //================================================================================================

            //oo9
            //456
            //123
            else if (gp[0, 0] == "o" && gp[0, 1] == "o" && gp[0, 2] == "9" && r != 1)
            {
                int num = 9;
                return num.ToString();
            }

            //7oo
            //456
            //123
            else if (gp[0, 0] == "7" && gp[0, 1] == "o" && gp[0, 2] == "o" && r != 1)
            {
                int num = 7;
                return num.ToString();
            }

            //o8o
            //456
            //123
            else if (gp[0, 0] == "o" && gp[0, 1] == "8" && gp[0, 2] == "o" && r != 1)
            {
                int num = 8;
                return num.ToString();
            }

            //789
            //oo6
            //123
            else if (gp[1, 0] == "o" && gp[1, 1] == "o" && gp[1, 2] == "6" && r != 1)
            {
                int num = 6;
                return num.ToString();
            }

            //789
            //4oo
            //123
            else if (gp[1, 0] == "4" && gp[1, 1] == "o" && gp[1, 2] == "o" && r != 1)
            {
                int num = 4;
                return num.ToString();
            }

            //789
            //o5o
            //123
            else if (gp[1, 0] == "o" && gp[1, 1] == "5" && gp[1, 2] == "o" && r != 1)
            {
                int num = 5;
                return num.ToString();
            }

            //789
            //456
            //oo3
            else if (gp[2, 0] == "o" && gp[2, 1] == "o" && gp[2, 2] == "3" && r != 1)
            {
                int num = 3;
                return num.ToString();
            }

            //789
            //456
            //1oo
            else if (gp[2, 0] == "1" && gp[2, 1] == "o" && gp[2, 2] == "o" && r != 1)
            {
                int num = 1;
                return num.ToString();
            }

            //789
            //456
            //o2o
            else if (gp[2, 0] == "o" && gp[2, 1] == "2" && gp[2, 2] == "o" && r != 1)
            {
                int num = 2;
                return num.ToString();
            }

            //789
            //o56
            //o23
            else if (gp[0, 0] == "7" && gp[1, 0] == "o" && gp[2, 0] == "o" && r != 1)
            {
                int num = 7;
                return num.ToString();
            }

            //o89
            //o56
            //123
            else if (gp[0, 0] == "o" && gp[1, 0] == "o" && gp[2, 0] == "1" && r != 1)
            {
                int num = 1;
                return num.ToString();
            }

            //o89
            //456
            //o23
            else if (gp[0, 0] == "o" && gp[1, 0] == "4" && gp[2, 0] == "o" && r != 1)
            {
                int num = 4;
                return num.ToString();
            }

            //========================

            //789
            //4o6
            //1o3
            else if (gp[0, 1] == "8" && gp[1, 1] == "o" && gp[2, 1] == "o" && r != 1)
            {
                int num = 8;
                return num.ToString();
            }

            //7o9
            //4o6
            //123
            else if (gp[0, 1] == "o" && gp[1, 1] == "o" && gp[2, 1] == "2" && r != 1)
            {
                int num = 2;
                return num.ToString();
            }

            //7o9
            //456
            //1o3
            else if (gp[0, 1] == "o" && gp[1, 1] == "5" && gp[2, 1] == "o" && r != 1)
            {
                int num = 5;
                return num.ToString();
            }

            //===========================

            //789
            //45o
            //12o
            else if (gp[0, 2] == "9" && gp[1, 2] == "o" && gp[2, 2] == "o" && r != 1)
            {
                int num = 9;
                return num.ToString();
            }

            //78o
            //45o
            //123
            else if (gp[0, 2] == "o" && gp[1, 2] == "o" && gp[2, 2] == "3" && r != 1)
            {
                int num = 3;
                return num.ToString();
            }

            //78o
            //456
            //12o
            else if (gp[0, 2] == "o" && gp[1, 2] == "6" && gp[2, 2] == "o" && r != 1)
            {
                int num = 6;
                return num.ToString();
            }

            //=================

            //789
            //4o6
            //12o
            else if (gp[0, 0] == "7" && gp[1, 1] == "o" && gp[2, 2] == "o" && r != 1)
            {
                int num = 7;
                return num.ToString();
            }

            //o89
            //456
            //12o
            else if (gp[0, 0] == "o" && gp[1, 1] == "5" && gp[2, 2] == "o" && r != 1)
            {
                int num = 5;
                return num.ToString();
            }

            //o89
            //4o6
            //123
            else if (gp[0, 0] == "o" && gp[1, 1] == "o" && gp[2, 2] == "3" && r != 1)
            {
                int num = 3;
                return num.ToString();
            }

            //=================

            //78o
            //4o6
            //123
            else if (gp[2, 0] == "1" && gp[1, 1] == "o" && gp[0, 2] == "o" && r != 1)
            {
                int num = 1;
                return num.ToString();
            }

            //18o
            //456
            //o23
            else if (gp[2, 0] == "o" && gp[1, 1] == "5" && gp[0, 2] == "o" && r != 1)
            {
                int num = 5;
                return num.ToString();
            }

            //189
            //4o6
            //o23
            else if (gp[2, 0] == "o" && gp[1, 1] == "o" && gp[0, 2] == "9" && r != 1)
            {
                int num = 9;
                return num.ToString();
            }
            //================================================================

            //xxo
            //456
            //123
            else if (gp[0, 0] == "x" && gp[0, 1] == "x" && gp[0, 2] == "9" && r != 1)
            {
                int num = 9;
                return num.ToString();
            }

            //oxx
            //456
            //123
            else if (gp[0, 0] == "7" && gp[0, 1] == "x" && gp[0, 2] == "x" && r != 1)
            {
                int num = 7;
                return num.ToString();
            }

            //xox
            //456
            //123
            else if (gp[0, 0] == "x" && gp[0, 1] == "8" && gp[0, 2] == "x" && r != 1)
            {
                int num = 8;
                return num.ToString();
            }

            //789
            //xxo
            //123
            else if (gp[1, 0] == "x" && gp[1, 1] == "x" && gp[1, 2] == "6" && r != 1)
            {
                int num = 6;
                return num.ToString();
            }

            //789
            //oxx
            //123
            else if (gp[1, 0] == "4" && gp[1, 1] == "x" && gp[1, 2] == "x" && r != 1)
            {
                int num = 4;
                return num.ToString();
            }

            //789
            //xox
            //123
            else if (gp[1, 0] == "x" && gp[1, 1] == "5" && gp[1, 2] == "x" && r != 1)
            {
                int num = 5;
                return num.ToString();
            }

            //789
            //456
            //xxo
            else if (gp[2, 0] == "x" && gp[2, 1] == "x" && gp[2, 2] == "3" && r != 1)
            {
                int num = 3;
                return num.ToString();
            }

            //789
            //456
            //oxx
            else if (gp[2, 0] == "1" && gp[2, 1] == "x" && gp[2, 2] == "x" && r != 1)
            {
                int num = 1;
                return num.ToString();
            }

            //789
            //456
            //xox
            else if (gp[2, 0] == "x" && gp[2, 1] == "2" && gp[2, 2] == "x" && r != 1)
            {
                int num = 2;
                return num.ToString();
            }

            //o89
            //x56
            //x23
            else if (gp[0, 0] == "7" && gp[1, 0] == "x" && gp[2, 0] == "x" && r != 1)
            {
                int num = 7;
                return num.ToString();
            }

            //x89
            //x56
            //o23
            else if (gp[0, 0] == "x" && gp[1, 0] == "x" && gp[2, 0] == "1" && r != 1)
            {
                int num = 1;
                return num.ToString();
            }

            //x89
            //o56
            //x23
            else if (gp[0, 0] == "x" && gp[1, 0] == "4" && gp[2, 0] == "x" && r != 1)
            {
                int num = 4;
                return num.ToString();
            }

            //========================

            //7o9
            //4x6
            //1x3
            else if (gp[0, 1] == "8" && gp[1, 1] == "x" && gp[2, 1] == "x" && r != 1)
            {
                int num = 8;
                return num.ToString();
            }

            //7x9
            //4x6
            //1o3
            else if (gp[0, 1] == "x" && gp[1, 1] == "x" && gp[2, 1] == "2" && r != 1)
            {
                int num = 2;
                return num.ToString();
            }

            //7x9
            //4o6
            //1x3
            else if (gp[0, 1] == "x" && gp[1, 1] == "5" && gp[2, 1] == "x" && r != 1)
            {
                int num = 5;
                return num.ToString();
            }

            //===========================

            //78o
            //45x
            //12x
            else if (gp[0, 2] == "9" && gp[1, 2] == "x" && gp[2, 2] == "x" && r != 1)
            {
                int num = 9;
                return num.ToString();
            }

            //78x
            //45x
            //12o
            else if (gp[0, 2] == "x" && gp[1, 2] == "x" && gp[2, 2] == "2" && r != 1)
            {
                int num = 2;
                return num.ToString();
            }

            //78x
            //45o
            //12x
            else if (gp[0, 2] == "x" && gp[1, 2] == "6" && gp[2, 2] == "x" && r != 1)
            {
                int num = 6;
                return num.ToString();
            }

            //=================

            //o89
            //4x6
            //12x
            else if (gp[0, 0] == "7" && gp[1, 1] == "x" && gp[2, 2] == "x" && r != 1)
            {
                int num = 7;
                return num.ToString();
            }

            //x89
            //4o6
            //12x
            else if (gp[0, 0] == "x" && gp[1, 1] == "5" && gp[2, 2] == "x" && r != 1)
            {
                int num = 5;
                return num.ToString();
            }

            //x89
            //4x6
            //12o
            else if (gp[0, 0] == "x" && gp[1, 1] == "x" && gp[2, 2] == "3" && r != 1)
            {
                int num = 3;
                return num.ToString();
            }

            //=================

            //18x
            //4x6
            //o23
            else if (gp[2, 0] == "1" && gp[1, 1] == "x" && gp[0, 2] == "x" && r != 1)
            {
                int num = 1;
                return num.ToString();
            }

            //18x
            //4o6
            //x23
            else if (gp[2, 0] == "x" && gp[1, 1] == "5" && gp[0, 2] == "x" && r != 1)
            {
                int num = 5;
                return num.ToString();
            }

            //18o
            //4x6
            //x23
            else if (gp[2, 0] == "x" && gp[1, 1] == "x" && gp[0, 2] == "9" && r != 1)
            {
                int num = 9;
                return num.ToString();
            }

            


            else
            {
                return rand.Next(10).ToString();
            }


        }
    }
}
