using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgendaContato
{
    class cl_Contato
    {
        private int codcontato;
        private string nome;
        private string telefone;
        private string celular;
        private string email;

        public int Codcontato { 
            get { return codcontato; } 
            set => codcontato = value;
        }
        public string Nome { 
            get { return nome; } 
            set => nome = value; 
        }
        public string Telefone {
            get { return telefone; } 
            set => telefone = value; 
        }
        public string Celular {
            get { return celular; }
            set => celular = value; 
        }
        public string Email {
            get { return email; }
            set => email = value;
        }
    }
}
