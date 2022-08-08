using CommandPattern.Commands;
using CommandPattern.Exceptions;
using CommandPattern.Models;

var healthWorkers = new List<HealthWorker>();
for (var i = 0; i < 5; i++)
{
    healthWorkers.Add(new HealthWorker());
}

foreach (var worker in healthWorkers)
{
    while (worker.SanitizationProgress != SanitizationProgressEnum.Clear)
    {
        try
        {
            var procedure = new List<ICommand>()
            {
                new PreSanitizationCommand(worker),
                new SanitizationCommand(worker),
                new PostSanitizationCommand(worker),
                new ClearCommand(worker)
            };

            foreach (var command in procedure)
            {
                command.Execute();
                Thread.Sleep(1000);
            }
        }
        catch (InfectedException)
        {
            Console.WriteLine("Virus detected!");
            Thread.Sleep(1000);
            worker.Restart();
            Thread.Sleep(1000);
        }
    }
}