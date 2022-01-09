using System;
//using patrones.AbstractFactory;
//using patrones.Builder;
//using patrones.FactoryMethod;
//using patrones.Prototype;
//using patrones.Singleton;
//using patrones.Adapter;
//using patrones.Bridge;
//using patrones.Composite;
//using patrones.Decorator;
//using patrones.Facade;
//using patrones.Flyweight;
//using patrones.Proxy;
//using patrones.ChainOfResponsability;
//using patrones.Command;
//using patrones.Interpreter;
//using patrones.Iterator;
//using patrones.Mediator;
//using patrones.Memento;
//using patrones.Observer;
//using patrones.State;
//using patrones.Strategy;
using patrones.TemplateMethod;

namespace patrones
{
    public class Program
    {
	static void Run()
	{
	    Console.Clear();
	    Start.RunPatron();
	    Finalice();
	}

	static void Finalice()
	{
	    Console.WriteLine(@"
Press R to Restart
and another key to Finalize");
	    var keyPressed = Console.ReadKey(true);
	    if(keyPressed.Key == ConsoleKey.R) Run();
	    Console.Clear();
	}

        static void Main(string[] args) => Run();
    }
}
