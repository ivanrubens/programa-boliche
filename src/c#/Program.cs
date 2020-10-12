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
                int total_pontos_frame = 0;
                int frame_strike = 0; // 1.8.
                int jogador_strike = 0; // 1.8
                int[] total_pontos_jogador = new int[qtd_jogadores + 1];

                for (int frame = 1; frame <= qtd_frames; frame++)
                {
                    for (int jogador = 1; jogador <= qtd_jogadores; jogador++) // 1.5
                    {
                        // 1.4., 1.6.
                        bool spare_segundo_frame = false;
                        int qtd_pinos_derrubados_arremesso = 0;
                        int qtd_total_pinos_derrubados_frame = 0;

                        for (int arremesso = 1; arremesso <= qtd_arremessos_por_frame; arremesso++)
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
                                frame_strike = frame;
                                jogador_strike = jogador;
                            }

                            total_pontos_frame = qtd_total_pinos_derrubados_frame;

                            // 1.8
                            if ((frame_strike > 0 && jogador_strike == jogador) && (frame == frame_strike))
                            {
                                break;
                            }
                        }

                        // 1.8.
                        if ((frame_strike > 0 && jogador_strike == jogador) && (frame != frame_strike))
                        {
                            total_pontos_frame = qtd_total_pinos_derrubados_frame * 2;
                            frame_strike = 0;
                            jogador_strike = 0;
                        }

                        total_pontos_jogador[jogador] = total_pontos_jogador[jogador] + total_pontos_frame;

                        Console.WriteLine($"Total de Pontos do Jogador {jogador} (frame {frame}): " + total_pontos_frame);

                    }

                }

                for (int i = 1; i <= qtd_jogadores; i++)
                {
                    Console.WriteLine($"Pontuação geral do Jogador {i}): " + total_pontos_jogador[i]);
                }

                fim_partida = true;
            }

        }
    }
}
