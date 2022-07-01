
using ObserverPattern.Observers;
using ObserverPattern.Subject;

var customerComplaint = new CustomerComplaint();
var manager = new Manager(customerComplaint);
var techinicalSupport = new TechinicalSupport(customerComplaint);

customerComplaint.LiveComplaint(PersonEnum.Manager);

customerComplaint.LiveComplaint(PersonEnum.TechnicalSupport);
