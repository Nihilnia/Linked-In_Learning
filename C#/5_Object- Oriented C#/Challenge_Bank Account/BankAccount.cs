namespace Defining
{
    public class BankAccount
    {

        public string _Name;
        public decimal _Total;
        public bool _isActive;

        public BankAccount(string Name, bool isActive, decimal Total)
        {
            _Name = Name;
            _Total = Total;
            _isActive = isActive;
        }

        public string Deposit(int val)
        {
            if (val > 0)
            {
                _Total += val;
                return $"Account has: {_Total - val}, {val} added to total, now the total is {_Total}";
            }

            return $"You cannot add zero to total, eh?";
        }

        public string Withdrawal(int val)
        {
            if (val > 0)
            {
                _Total -= val;
                return $"Account has: {_Total + val}, {val} amount withdrawed from total, now the total is {_Total}";
            }

            return $"You cannot withdraw zero to total, eh?";
        }

        public override string ToString()
        {
            return $"Acc name: {_Name}, total {_Total} and active: {_isActive}";
        }

    }
}