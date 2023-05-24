using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace byBank.Titular
{   
    //Classe associada a conta corrente para melhor definir os atributos e propriedades dos clientes
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        //Metodo construtor
        public Cliente(string nome, string cpf, string profissao) 
        {
            this.Nome = nome;
            this.Cpf = cpf; 
            this.Profissao = profissao;
        }
    }
}
