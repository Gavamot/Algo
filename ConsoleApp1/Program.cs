var a = new int[] { 1, 2, 3, 4}.Combinations().ToArray();
foreach (var c in a)
{
    foreach (var d in c)
    {
        Console.Write(d);
    }
    Console.Write("\n");
}