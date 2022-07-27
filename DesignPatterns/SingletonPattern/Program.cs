using SingletonPattern.Singleton;
using SingletonPattern.Users;

for (int i = 1; i < 6; i++)
{
    var user = new User(i, MoneyVault.GetInstance());
    Console.WriteLine("Entering");
    var thread = i % 2 == 0 ? new Thread(() => user.SpendMoney(500)) : new Thread(() => user.EarnMoney(1000));
    thread.Start();
}