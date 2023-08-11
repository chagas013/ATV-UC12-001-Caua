using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_ATV_UC12_001_Caua
{
    public class Correntista
    {

        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string CpfCliente { get; set; }
        public DateTime DataNasc { get; set; }
        public decimal RendaMensal { get; set; }
        public static int TotalCliente { get; set; }
        public int? TipoConta { get; set; }

        public Correntista()
        {

        }

        public Correntista(string nomeCliente, string cpfCliente, DateTime dataNasc, decimal rendaMensal)
        {
            TotalCliente = TotalCliente + 1;
            IdCliente = TotalCliente;
            NomeCliente = nomeCliente;
            CpfCliente = cpfCliente;
            DataNasc = dataNasc;
            RendaMensal = rendaMensal;
            TipoConta = TipoConta;

        }

        public int verificarSeCorrentistaMaior()
        {
            DateTime dataAtual = DateTime.Now;
            int idade = dataAtual.Year - DataNasc.Year;

            if (dataAtual.Month < DataNasc.Month || (dataAtual.Month == DataNasc.Month && dataAtual.Day < DataNasc.Day))
            {
                idade--;
            }
            if (idade >= 18)
            {
                return idade;
            }
            else
            {
                return idade;
            }
            
            
        }




    }
}
