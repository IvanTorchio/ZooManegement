using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorchioZoo
{
    class Animale
    {
        public string Nome { get; set; }
        public string Specie { get; set; }
        public int Eta { get; set; }
        public int Peso { get; set; }
        public string StatoDiSalute { get; set; }
        public DateOnly DataDiArrivo { get; set; }
        public int AnniAlloZoo { get; set; }

        private double _pesoIniziale;
        private int _numeroControlliVeterinari;

        public virtual double CalcolaCiboDiarioKg()
        {
            return 0;
        }
        public virtual double CalcolaCostoGestioneMensile()
        {
            return 0;
        }
        public virtual string EmettiVerso()
        {
            return "";
        }
        public void AggiornaPeso(double nuovoPeso)
        {
            
        }
        public void EffettuaControlloVeterinario()
        {
            _numeroControlliVeterinari++;
        }
        public virtual string MostraInformazioni()
        {
            return "";
        }
        private void CalcolaVariazionePesoPercentuale()
        {
            
        }
        private void DetermnaStatoSaluteAutomatico()
        {

        }
    }
}
