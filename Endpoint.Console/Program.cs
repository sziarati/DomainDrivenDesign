// See https://aka.ms/new-console-template for more information
using DDD.Domain.Aggregates;
using DDD.Domain.Elements;
using System.Reflection.Metadata;

Console.WriteLine("Hello, World!");
EventDispatcher dispatcher = new EventDispatcher();
User x = new User(dispatcher)
{
    UserName = "s.ziarati",
    Password = "!QAZ2wsx",
    IsActive = true
};

x.PasswordChange();
Console.ReadLine();