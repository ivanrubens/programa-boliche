using System.Collections.Generic;

namespace consoleapp.Domain
{
    public class Jogador : DomainBase
    {
        public string Nome { get; private set; }
        public Jogador(string nome)
        {
            if (nome.Trim().Length == 0)
            {
                Valido = false;
                MensagensErro.Add("É necessário informar o nome do jogador!");
                return;
            }
            
            Nome = nome;
        }

    }
}