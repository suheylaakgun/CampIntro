// See https://aka.ms/new-console-template for more information

//system.collection.generic
using Dictionary;

MyDictionary<int, string> users = new MyDictionary<int, string>();
users.Add(1, "Süheyla");
//users.Add(1, "Xüheyla");
users.Add(2, "Ebru");
users.Add(3, "Hatice");
foreach (var user in users.Keys)
    Console.WriteLine(user);