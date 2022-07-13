
using ObserverPattern.Observers;
using ObserverPattern.Subject;

var customerComplaint = new CustomerComplaint();
var manager = new Manager(customerComplaint);
var technicalSupport = new TechnicalSupport(customerComplaint);

customerComplaint.LiveComplaint(PersonEnum.Manager);

customerComplaint.LiveComplaint(PersonEnum.TechnicalSupport);

foreach (var message in manager.Complaints)
{
    Console.WriteLine(message);
}

foreach (var message in technicalSupport.Complaints)
{
    Console.WriteLine(message);
}

manager.Unsubscribe();

technicalSupport.Unsubscribe();

customerComplaint.LiveComplaint(PersonEnum.Manager);

customerComplaint.LiveComplaint(PersonEnum.TechnicalSupport);

foreach (var message in manager.Complaints)
{
    Console.WriteLine(message);
}

foreach (var message in technicalSupport.Complaints)
{
    Console.WriteLine(message);
}
