using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TorchioZoo
{
    class Leone : Animale
    {
        public bool IsMaschio { get; set; }
        public int LunghezzaCriniera { get; set; }

        private double _temperaturaCorporeaC = 38.5;
        private DateTime _ultimaPredazione;

        public override double CalcolaCiboDiarioKg()
        {
            return 10;
        }
        
    }
}
