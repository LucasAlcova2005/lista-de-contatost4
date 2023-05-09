using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_contatost4
{
    internal class contato
    {
        //variaveis internas da classe contato.
        //a palavra-chave "private" indica que somente a classe
        //*contato* tem acesso.

        private string primeiroNome;
        private string sobrenome;
        private string telefone; 

        // PROPRIEDADES (GET e SET)
        public string PrimeiroNome
        {
            get { return primeiroNome; }
            set { primeiroNome = value; }
        }

        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set
            {
                if (value.Length == 11)
                    Telefone = value;
                else
                    Telefone = "00-00000-0000";
            }
        }

        // Metodo construtor da classe
        public contato()
        {
            PrimeiroNome = "José";
            Sobrenome = "Da Silva";
            Telefone = "11-99782-8370";
        }
        //sobrecarga do metodo construtor da classe
        public contato(string primeiroNome, string sobrenome, string telefone)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }
        public override string ToString()
        {
            string saida = String.Empty;
            saida += string.Format("{0}, {1}", PrimeiroNome, Sobrenome);
            saida += string.Format("{0}-{1}-{2}", 
                Telefone.Substring(0, 1), 
                Telefone.Substring(2, 4), 
                Telefone.Substring(7, 3));

            return saida;


        }

    }
}