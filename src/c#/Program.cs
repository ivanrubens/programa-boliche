using System;

namespace programa_boliche
{
    class Program
    {
        static void Main(string[] args)
        {

            // PROGRAMA BOLICHE 

            const int qtd_frames = 2; //10  // 1.1.
            const int qtd_pinos_por_frame = 10; // 1.1.
            const int qtd_arremessos_por_frame = 2; // 1.4.
            const int qtd_maxima_jogadores = 4; //1.5 
            const int pontuacao_minima_jogo = 120;
            const int pontuacao_maxima_jogo = 170;

            //  variaveis 
            bool fim_partida = false;

            // 1.5.
            string val;
            int qtd_jogadores = 0;
            //int[] total_pontos_jogador;

            do
            {
                Console.Write("Quantidade de Jogadores: ");
                val = Console.ReadLine();
                qtd_jogadores = Convert.ToInt32(val);
            }
            while (qtd_jogadores <= 0 || qtd_jogadores > qtd_maxima_jogadores);

            while (!fim_partida)
            {
                // 1.1
                int frame = 1;
                int jogador = 1;
                int total_pontos_frame = 0;

                while (frame <= qtd_frames)
                {

                    jogador = 1; // 1.5
                    bool strike_primeiro_frame = false; // 1.8.
                    while (jogador <= qtd_jogadores)
                    {

                        // 1.4., 1.6.
                        bool spare_segundo_frame = false;
                        int arremesso = 1;
                        int qtd_pinos_derrubados_arremesso = 0;
                        int qtd_total_pinos_derrubados_frame = 0;

                        while (arremesso <= qtd_arremessos_por_frame)
                        {
                            // 1.6.
                            do
                            {
                                Console.Write("Quantidade de Pinos Derrubados (Frame " + frame + " | Jogador " + jogador + " | Arremesso " + arremesso + "): ");
                                val = Console.ReadLine();
                                qtd_pinos_derrubados_arremesso = Convert.ToInt32(val);
                            }
                            while (qtd_pinos_derrubados_arremesso < 0 || qtd_pinos_derrubados_arremesso > (qtd_pinos_por_frame - qtd_total_pinos_derrubados_frame));

                            qtd_total_pinos_derrubados_frame = qtd_total_pinos_derrubados_frame + qtd_pinos_derrubados_arremesso;

                            // 1.8.
                            if (arremesso == 1 && (qtd_pinos_derrubados_arremesso == qtd_pinos_por_frame))
                            {
                                total_pontos_frame = qtd_total_pinos_derrubados_frame;
                                strike_primeiro_frame = true;
                                arremesso += 1;
                            }

                            arremesso += 1;
                        }

                        // 1.7
                        if (!(qtd_total_pinos_derrubados_frame == qtd_pinos_por_frame))
                        {
                            total_pontos_frame = qtd_total_pinos_derrubados_frame;
                        }

                        // 1.8.
                        if (frame > 1 && strike_primeiro_frame)
                        {
                            total_pontos_frame = qtd_total_pinos_derrubados_frame * 2;
                            strike_primeiro_frame = false;
                        }

                        //total_pontos_jogador[jogador] = total_pontos_jogador[jogador] + total_pontos_frame;
                        Console.WriteLine($"Total de Pontos do Jogador/frame {jogador - 1} (frame {frame}): " + total_pontos_frame);

                        jogador += 1;

                    }

                    //Console.WriteLine($"Total de Pontos do Jogador {jogador - 1} (frame {frame}): " + total_pontos_jogador[jogador - 1]);
                    frame += 1;
                }

                fim_partida = true;
            }

        }
    }
}
