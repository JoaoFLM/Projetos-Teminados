class Transacao {

    public Transacao(string t, decimal v, IContaBancaria conta){
        this.tipo = t.ToUpper();
        this.valor = v;
        this.resultado = this.FazerTransacao(conta);
    }
    public string tipo {get;set;}
    public decimal valor {get;set;}
    public string resultado {get;set;}

    public string FazerTransacao(IContaBancaria conta)
    {
        if(this.tipo == "DEPOSITO")
        {
            try 
            {
                conta.Depositar(this.valor);
            }
            catch(ArgumentException x)
            {
                return x.Message;
            }

            return "Deposito realizado com sucesso";
        }
        else if(this.tipo == "SAQUE")
        {
            try 
            {
                conta.Sacar(this.valor);
            }
            catch(ArgumentException x)
            {
                return x.Message;
            }

            return "Saque realizado com sucesso";
        }
        else
        {
            throw new ArgumentException("Operacao invalida!!!");
        }
        
    }
}