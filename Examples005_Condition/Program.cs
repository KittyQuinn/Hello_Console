﻿Console.Write("Write username: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Yeah, this is Masha!");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}