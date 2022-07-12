using DecoratorPattern.Models.Base;
using DecoratorPattern.Models.Decorators;

var testString = "TEST STRING";
var baseTransform = new BaseTransform();
Console.WriteLine(baseTransform.Transform(testString));

var stringLeft = new StringLeft(baseTransform, 10);
Console.WriteLine(stringLeft.Transform(testString));

var stringRight = new StringRight(stringLeft, 9);
Console.WriteLine(stringRight.Transform(testString));

var newString = "CONCAT";
var concat = new StringConcat(stringRight, newString);
Console.WriteLine(concat.Transform(testString));