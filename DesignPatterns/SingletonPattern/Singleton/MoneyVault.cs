namespace SingletonPattern.Singleton
{
    public class MoneyVault
    {
        private static readonly MoneyVault Instance = new();
        private static int _reserve = 500000000;
        private static readonly Semaphore Pool = new(1, 1);
        private static int _padding = 1000;

        private MoneyVault()
        {
        }

        public static MoneyVault GetInstance()
        {
            return Instance;
        }

        public void Withdraw(int amount)
        {
            Pool.WaitOne();
            Console.WriteLine("Success withdraw");
            if (amount < 0)
                throw new ArgumentOutOfRangeException($"The amount needs to be greater than 0. Amount: '{amount}'");
            if (amount > _reserve)
                throw new ArgumentException($"The amount to withdraw '{amount}' is over the reserve '{_reserve}'");
            _reserve -= amount;
            Thread.Sleep(_padding);
            Pool.Release();
        }

        public void Deposit(int amount)
        {
            Pool.WaitOne();
            Console.WriteLine("Success deposit");
            if (amount < 0)
                throw new ArgumentOutOfRangeException($"The amount needs to be greater than 0. Amount: '{amount}'");
            _reserve += amount;
            Thread.Sleep(_padding);
            Pool.Release();
        }

    }
}
