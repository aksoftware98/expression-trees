// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");

// Test Delegates
var writeMessage = WriteMessageToConsole;

// basic expressoin 
var parameterExpression = Expression.Parameter(typeof(int), "a");
var constantExpression = Expression.Constant(12);
var operatorExpression = Expression.GreaterThanOrEqual(parameterExpression, constantExpression);
var functionExpression = Expression.Lambda<Func<int, bool>>(operatorExpression, parameterExpression);

var combiledFunction = functionExpression.Compile();

Console.WriteLine(combiledFunction(4));

static void WriteMessageToConsole(string message)
{
    Console.WriteLine(message);
}

public delegate void WriteMessage(string message); 


