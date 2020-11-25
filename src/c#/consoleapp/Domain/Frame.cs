using System;

namespace consoleapp.Domain
{
    public class Frame : DomainBase
    {
        const int QuantArremessos = 2;
        const int QuantPinosPorFrame = 10;
        public int PinosDerrubados { get; private set; }
        public int Arremessos { get; private set; }
        public int QuantidadeFrames { get; private set; }


        public Frame()
        {
            PinosDerrubados = 0;
            Arremessos = 2;
        }

        public void DefinirQuantFrames(int quantFrames)
        {
            if (quantFrames <= 0 || quantFrames > QuantArremessos)
            {
                Valido = false;
                MensagensErro.Add($"Quantidade de partida (frame) é inválido (máximo permitido {QuantArremessos}");
                return;
            }
            QuantidadeFrames = quantFrames;
        }

        public void DefinirQuantArremessos(int quantArremessos)
        {
            if (quantArremessos != QuantArremessos)
            {
                Valido = false;
                MensagensErro.Add($"Quantidade de Arremessosé inválido (máximo permitido {QuantArremessos}");
                return;
            }
        }

        public void DefinirQuantPinosPorFrame(int quantPinos)
        {
            if (quantPinos != QuantPinosPorFrame)
            {
                Valido = false;
                MensagensErro.Add($"Quantidade de Arremessosé inválido (máximo permitido {QuantPinosPorFrame}");
                return;
            }
        }

    }
}