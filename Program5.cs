String[] a = { "Hello", "Bye", "Yogesh ", "Khanse" };
int[] b = {1,2,3,4,5};

String[] a1 = new String[4];
a1[0] = "Hello";
a1[1] = "Bye";

Console.WriteLine(a[1]);

for  (int i = 0; i < a.Length; i++)
{
    Console.WriteLine(a[i]);
    if (a[i] == "Hello")
    {
        Console.WriteLine("Match Found");
        break;
    }
    else
    {
        Console.WriteLine("Not Found");
    }
}