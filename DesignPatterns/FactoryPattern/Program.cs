using FactoryPattern.Models;
using FactoryPattern.Application;
using FactoryPattern.Factory;

var student1 = new Student() { Id = 1, Name = "A", Age = 21};
var student2 = new Student() { Id = 2, Name = "B", Age = 19 };
var student3 = new Student() { Id = 3, Name = "C", Age = 22 };
var student4 = new Student() { Id = 4, Name = "D", Age = 20 };

var students = new List<Student>(){student1, student2, student3, student4};

var csvFactory = new CsvFactory();
var jsonFactory = new JsonFactory();

var csvApplication = new Application(csvFactory);
csvApplication.CreateSerializer();
csvApplication.SerializeAndDeserializeStudents(students, "csvStudents");

var jsonApplication = new Application(jsonFactory);
jsonApplication.CreateSerializer();
jsonApplication.SerializeAndDeserializeStudents(students, "jsonStudents");