// See https://aka.ms/new-console-template for more information

using StatePattern.Models;

var machine = new Machine();

for (var i = 0; i < 10; i++)
{
    machine.Work();
}