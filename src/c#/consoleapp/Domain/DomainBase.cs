using System.Collections.Generic;

namespace consoleapp.Domain
{
    public abstract class DomainBase
    {
        public bool Valido { get; set; }
        public List<string> MensagensErro { get; set; }
        public DomainBase()
        {
            MensagensErro = new List<string>();
            Valido = true;
        }
    }
}