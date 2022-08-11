bool CheckIfEven(int a)
{
    if (a % 2 == 0)
        return true;
    else
        return false;    
}

int a = 4;
if (CheckIfEven(a))
    Console.WriteLine(a + "is an even number");
else
    Console.WriteLine(a + " is an odd number");

a = -3;
if (CheckIfEven(a))
    Console.WriteLine(a + "is an even number");
else
    Console.WriteLine(a + " is an odd number");

a = 7;
if (CheckIfEven(a))
    Console.WriteLine(a + "is an even number");
else
    Console.WriteLine(a + " is an odd number");