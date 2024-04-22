class ContaCorrente : IContaBancaria {

    public int numero_conta{get;set;}
    public decimal saldo{get;set;} 

    public ContaCorrente(int nc)
    {   
        this.numero_conta = nc;
        this.saldo = 0;
    }

    public void Depositar(decimal x)
    {
        if(x <= 0)
        {
            throw new ArgumentException("O deposito deve ser maior que 0");
        }
        else 
        {
            this.saldo += x;
        }
    }

    public void Sacar(decimal x)
    {
     if(x > this.saldo)
     {
        throw new ArgumentException("Valor do saque excede o saldo da conta");
     }
     else if(x <= 0)
     {
        throw new ArgumentException("O valor do saque deve ser maior que 0");
     }
     else 
     {
        this.saldo -= x;
     }
    }
}