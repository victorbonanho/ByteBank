using bytebank.Titular;

namespace bytebank
{
    class ContaCorrente
    {
        //public string titular;
        //private Cliente titular;
        //Propriedade auto implementada
        public Cliente Titular { get; set; }
        //public Cliente Titular
        //{
        //    get 
        //    { 
        //        return titular; 
        //    }
        //    set
        //    {
        //        titular = value;
        //    }
        //}


        //private string conta;
        private string _conta;
        public string Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                else
                {
                    _conta = value;
                }
            }
        }
        //private int numero_agencia;
        private int _numero_agencia;
        public int Numero_Agencia
        {
            get
            {
                return _numero_agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                else
                {
                    _numero_agencia = value;
                }
            }
        }
        //private string nome_agencia;
        public string Nome_Agencia { get; set; }
        private bool verificador; //Boa prática
        private double saldo;

        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            if(valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            saldo = saldo + valor;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }
        }

        //public void SetSaldo(double valor)
        //{
        //    if(valor < 0)
        //    {
        //        return; //Ele para a execução
        //    }
        //    saldo = valor;
        //}

        public double Saldo
        {
            get 
            {
                return saldo;            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    saldo = value;
                }
            }
        }

        public double GetSaldo()
        {
            return saldo;
        }

        public ContaCorrente(int numero_agencia, string conta)
        {
            Numero_Agencia = numero_agencia;
            Conta = conta;
        }
    }
}