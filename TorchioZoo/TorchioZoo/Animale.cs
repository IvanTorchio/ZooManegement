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
            return Peso / 20;
        }
        public virtual double CalcolaCostoGestioneMensile()
        {
            return 100;
        }
        public virtual string EmettiVerso()
        {
            return "L'animale emette un verso";
        }
        public void AggiornaPeso(int nuovoPeso)
        {
            if (Peso >= 0)
            {
                Peso = nuovoPeso;
                CalcolaVariazionePesoPercentuale();
                DetermnaStatoSaluteAutomatico();
            }
            else
            {
                Console.WriteLine("Il peso non può essere negativo.");
            }
        }
        public void EffettuaControlloVeterinario()
        {
            _numeroControlliVeterinari++;
        }
        public virtual string MostraInformazioni()
        {
            return $"Nome: {Nome}, " +
                   $"\nSpecie: {Specie}, " +
                   $"\nEtà: {Eta}, Peso: {Peso}, " +
                   $"\nStato di Salute: {StatoDiSalute}, " +
                   $"\nControlli Veterinari: {_numeroControlliVeterinari}";
        }
        private void CalcolaVariazionePesoPercentuale()
        {
            if (_pesoIniziale > 0)
            {
                double variazione = ((Peso - _pesoIniziale) / _pesoIniziale) * 100;
                Console.WriteLine($"Variazione peso: {variazione}%");
            }
        }
        private void DetermnaStatoSaluteAutomatico()
        {
            if (_numeroControlliVeterinari > 3 && Peso > 0.9 * _pesoIniziale)
            {
                StatoDiSalute = "Ottimo";
            }
            else if (_numeroControlliVeterinari > 2)
            {
                StatoDiSalute = "Buono";
            }
            else if (_numeroControlliVeterinari > 1)
            {
                StatoDiSalute = "Discreto";
            }
            else
            {
                StatoDiSalute = "Critico";
            }
        }
    }
}