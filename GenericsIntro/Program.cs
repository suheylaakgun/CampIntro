﻿// See https://aka.ms/new-console-template for more information

using GenericsIntro;

MyList<string> myList = new MyList<string>();
myList.Add("Engin");
myList.Add("İlker");

foreach (var item in myList.Items) 
{
    Console.WriteLine(item);

}


