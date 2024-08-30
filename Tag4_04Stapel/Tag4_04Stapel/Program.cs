// See https://aka.ms/new-console-template for more information

using System.Net.WebSockets;
using de.buba.collections;
using de.buba.tiere;
using geometrie;

try
{

    IStapel<Punkt> myStapel = new Stapel<Punkt>(-40);

    for (int i = 0; i < 10; i++)
    {
        if (!myStapel.IsFull)
        {
            //myStapel.Push(new Schwein("Schwein Nr. " + i));
            myStapel.Push(new Punkt(i, i));
            myStapel.Push(new Kreis(i, i));
        }
    }

    while (!myStapel.IsEmpty)
    {
        Punkt p = myStapel.Pop();
        Console.WriteLine(p);
    }
}
catch (StapelException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e  ){
    Console.WriteLine(e.Message);
}
