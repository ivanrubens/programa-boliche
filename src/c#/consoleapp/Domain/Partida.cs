using System;
using System.Collections.Generic;

namespace consoleapp.Domain
{
    public class Partida : DomainBase
    {
        public List<Jogador> Jogadores { get; private set; }
        public List<Frame> Frames { get; private set; }
        public int QuantidadeRodadas { get; private set; }
        const int PontuacaoMinimaJogo = 120;

        public void DefinirQuantRodadas(int quantidadeRodadas)
        {
            if (quantidadeRodadas != 10)
            {
                Valido = false;
                MensagensErro.Add("Quantidade de Rodadas Inválido (deve ser 10)!");
                return;
            }
            QuantidadeRodadas = quantidadeRodadas;

            for (int i = 0; i < QuantidadeRodadas; i++)
            {
                Frames.Add(new Frame());
            }
        }

        public void DefinirQuantJogadores(int quantidadeJogadores)
        {
            if (!(quantidadeJogadores > 0 && quantidadeJogadores <= 4))
            {
                Valido = false;
                MensagensErro.Add("Quantidade de Jogadores Inválido (precisa ser até no máximo 4)!");
                return;
            }

            for (int i = 0; i < quantidadeJogadores; i++)
            {
                Jogadores.Add(new Jogador($"Jogador {i + 1}"));
            }
        }

        const int pontuacaoMaximaJogo = 170;

        public Partida()
        {
            Jogadores = new List<Jogador>();
            Frames = new List<Frame>();
        }


    }
}