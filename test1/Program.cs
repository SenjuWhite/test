int height = int.Parse(Console.ReadLine());
for (int i = 1; i <= height; i++)
{
	for (int j = 1; j <= i; j++)
	{
		Console.Write("#");
	}
	Console.WriteLine();
}
Console.WriteLine();
for (int i = height; i > 0; i--)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}
for (int i = 1; i <= height; i++)
{
	for (int j = 1; j <=height-i; j++)
	{
		Console.Write(" ");
	}
	for (int k = 0; k<i; k++)
	{
		Console.Write("#");
	}
	Console.WriteLine();
}
Console.WriteLine( );
for (int i = height; i > 0; i--)
{
    for (int j = 1; j <= height - i; j++)
    {
        Console.Write(" ");
    }
    for (int k = 0; k < i; k++)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}

