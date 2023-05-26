using byBank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace byBank.Conta
{
    public class ContaCorrente
    {   //Atributos e Propriedades
        
        public static float TaxaOperacao { get; private set; }
        public static int TotalDeContasCriadas { get; private set; }

        private int numeroAgencia;
        public int NumeroAgencia
        {
            get { return this.numeroAgencia; }
            private set
            {
                if (value > 0)
                {
                    this.numeroAgencia = value;
                }
            }
        }

        public string Conta { get; set; }

        private double saldo;
        public Cliente titular { get; set; }

        //Metodo Construtor
        public ContaCorrente(int agencia, string conta, Cliente titular)
        {
            this.NumeroAgencia = agencia;
            this.Conta = conta;
            this.titular = titular;
            //ArgumentException para que a agencia não seja menor ou igual a zero
            if(numeroAgencia <= 0)
            {
                throw new ArgumentException("Número de agência menor ou igual a zero!", nameof(NumeroAgencia));
            }
            //DivideByZeroException para que a taxa de operação não seja divida por zero
            //Essa exceção vai ficar comentada pois até o momento não se faz necessaria.
            /*try
            {
                TaxaOperacao = 30 / TotalDeContasCriadas;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ocorreu um erro, não é possível fazer a divisão por zero!");
                throw;
            }*/
            
            ContaCorrente.TotalDeContasCriadas++;
        }

        //Metodo para Depositar
        public bool Depositar(double valor)
        {
            if (valor > 0.0)
            {
                saldo += valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Metodo para Sacar
        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                if (valor >= 100.0)
                {
                    saldo -= valor;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //Metodo para Transferir
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        //Metodo para Definir o Saldo
        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;

            }
        }

        //Metodo para Obter o Saldo
        public double GetSaldo()
        {
            return this.saldo;
        }
    }
}
