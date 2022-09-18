int a=0, b=0, c=0;
double p=0, area = 0, a1=0, b1 = 0, c1 = 0;
bool rightone = false, isNumber = false, triangleisok = false; ;
while (!triangleisok)
{
    Console.WriteLine("Write down three numbers: a, b, c");
    while (!rightone)
    {
        Console.WriteLine("Write a:");
        string? line = Console.ReadLine();
        isNumber = int.TryParse(line, out a);
        if (!isNumber)
        {
            Console.WriteLine("Wrong input... Try again)");
        }
        else if (a <= 0)
        { Console.WriteLine("Wrong input... Try again)"); }
        else
        {
            rightone = true;
        }
    }
    rightone = false;
    while (!rightone)
    {
        Console.WriteLine("Write b:");
        string? line = Console.ReadLine();
        isNumber = int.TryParse(line, out b);
        if (!isNumber)
        {
            Console.WriteLine("Wrong input... Try again)");
        }
        else if (b <= 0)
        { Console.WriteLine("Wrong input... Try again)"); }
        else
        {
            rightone = true;
        }
    }
    rightone = false;
    while (!rightone)
    {
        Console.WriteLine("Write c:");
        string? line = Console.ReadLine();
        isNumber = int.TryParse(line, out c);
        if (!isNumber)
        {
            Console.WriteLine("Wrong input... Try again)");
        }
        else if (c <= 0)
        { Console.WriteLine("Wrong input... Try again)"); }
        else
        {
            rightone = true;
        }
    }
    rightone = false;
    if (a + b > c && a + c > b && b + c > a)
        triangleisok = true;
    else
        Console.WriteLine("Triangle with such parties does not exist. Try again)");
}
a1 = a; b1 = b; c1 = c;
p = (a1 + b1 + c1) / 2;
area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
Console.WriteLine(area);