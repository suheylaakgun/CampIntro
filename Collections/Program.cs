// See https://aka.ms/new-console-template for more information
//string[] names = new string[] { "Engin", "Murat", "Kerem", "Halil"};
//Console.WriteLine(names[0]);
//Console.WriteLine(names[1]);
//Console.WriteLine(names[2]);
//Console.WriteLine(names[3]);

////Diziler genişletilemez. 5 elemanlı "yeni dizi" oluşunca 5. indexte ilker olur atandığı için ama diğerleri nulldur.
//names = new string[5]; 
//names[4] = "İlker";
//Console.WriteLine(names[4]);
//Console.WriteLine(names[0]);

List<string> names2 = new List<string>() { "Engin", "Murat", "Kerem", "Halil" };
Console.WriteLine(names2[0]);
Console.WriteLine(names2[1]);
Console.WriteLine(names2[2]);
Console.WriteLine(names2[3]);
names2.Add("İlker");
Console.WriteLine(names2[4]);
Console.WriteLine(names2[0]);

