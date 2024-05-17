using System.Collections;

ArrayList a = new ArrayList();
a.Add("Hello");
a.Add("Bye");
a.Add("Apple");

Console.WriteLine(a[1]);

foreach (String item in a)
{
    Console.WriteLine(item);
}

Console.WriteLine(a.Contains("Hello"));

Console.WriteLine("List after sorting");
a.Sort();

foreach (String item in a)
{
    Console.WriteLine(item);
}