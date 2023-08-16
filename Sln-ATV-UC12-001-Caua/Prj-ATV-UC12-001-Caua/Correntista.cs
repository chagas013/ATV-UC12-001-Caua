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

        private string _nomeCliente;
        public string NomeCliente
        {
            get
            {
                return _nomeCliente;

            }
            set
            {
                if (value == String.Empty)
                {
                    throw new Exception("O nome precisa ser preenchido!");
                }
                else { this._nomeCliente = value; }
            }
        }

        private string _cpfCliente;
        public string CpfCliente 
        {
            get
            {
                return _cpfCliente;
            }
            set
            {
                if (value == String.Empty)
                {
                    throw new Exception("Digite um CPF válido!");
                }
                else { this._cpfCliente = value; }
            }
        }

        private DateTime _dataNasc;
        public DateTime DataNasc
        {
            get
            {
                return _dataNasc;
            }
            set
            {
                if ((value > DateTime.Now))
                {
                    throw new Exception("Data de Nascimnto não pode ser maior do que a atual!");
                }

                else if (correntistaMaior(value) == false)
                {
                    throw new Exception("Opa! Você não é maior de idade para criar uma conta, sentimos muito!");
                }
                else { this._dataNasc = value; }
               
            }
        }
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

        public bool verificarSeCorrentistaMaior()
        {
            DateTime dataAtual = DateTime.Now;
            int idade = dataAtual.Year - DataNasc.Year;

            if (dataAtual.Month < DataNasc.Month || (dataAtual.Month == DataNasc.Month && dataAtual.Day < DataNasc.Day))
            {
                idade--;
            }
            if (idade >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
            
            
        }

        public string RetornarPerfilCliente()
        {
           
            if (RendaMensal <= 3000m)
            {
                return "Cliente Silver"; 
            }
            else if (RendaMensal <= 5000m)
            {
                return " Cliente Gold";
            }
            else if (RendaMensal <= 10000m)
            {
                return "Cliente Diamond";
            }
            else
            {
                return "Cliente Black";
            }
                        
        }

        public string MensagemBoasVindas()
        {
            return $"Olá, {NomeCliente}!\n" +
                   $"Seja bem vindo ao Sifrão\n" +
                   $"{RetornarPerfilCliente()}";
        }

        public static bool correntistaMaior(DateTime data) 
        {
            DateTime dataAtual = DateTime.Now;
            int idade = dataAtual.Year - data.Year;

            if (dataAtual.Month < data.Month || (dataAtual.Month == data.Month && dataAtual.Day < data.Day))
            {
                idade--;
            }
            if (idade >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




    }
}
