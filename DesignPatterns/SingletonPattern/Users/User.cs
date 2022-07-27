using SingletonPattern.Singleton;

namespace SingletonPattern.Users
{
    public class User
    {
        public int Id { get; }
        private readonly MoneyVault _vault; 

        public User(int id, MoneyVault vault)
        {
            Id = id;
            _vault = vault;
        }

        public void EarnMoney(int amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException($"The amount needs to be greater than 0. Amount: '{amount}'");
            _vault.Deposit(amount);
            Console.WriteLine($"User '{Id}' deposited '{amount}' to the vault");
        }

        public void SpendMoney(int amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException($"The amount needs to be greater than 0. Amount: '{amount}'");
            _vault.Withdraw(amount);
            Console.WriteLine($"User '{Id}' spent '{amount}' from the vault");
        }
    }
}
