// See https://aka.ms/new-console-template for more information

using System.Net.WebSockets;
using de.buba.collections;

Stapel myStapel = new Stapel();

for (int i = 0; i < 10; i++)
{
    if (!myStapel.IsFull)
    {
        myStapel.Push(i);
    }
}

while (!myStapel.IsEmpty)
{
    Console.WriteLine(myStapel.Pop());
}
