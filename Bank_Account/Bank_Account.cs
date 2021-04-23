using System.Globalization;

namespace Bank_Account
{
    class Bank_Account
    {
        public string Name { get; set; }
        public double Deposit { get; private set; }
        public int AccountNumber { get; private set; }

        public Bank_Account(string name, int accountNumber)
        {
            Name = name;
            AccountNumber = accountNumber;
        }

        public Bank_Account(string name, int accountNumber, double deposit) : this(name, accountNumber)
        {
            InitialDeposit(deposit);
        }

        public void InitialDeposit(double initialDeposit)
        {
            Deposit += initialDeposit;
        }

        public void Withdraw(double withdraw)
        {
            Deposit -= withdraw + 5;
        }

        public override string ToString()
        {
            return $"Conta {AccountNumber}, Titular: {Name}, Saldo: ${Deposit.ToString("F2", CultureInfo.InvariantCulture)}";
        }


    }
}
