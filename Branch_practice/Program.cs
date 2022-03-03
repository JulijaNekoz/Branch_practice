
short digit1 = 60;
short digit2 = 7;

if (digit1 > digit2)
{
    Console.WriteLine("Digit one is bigger than Digit two");
}
else
{
    Console.WriteLine("Digit two is bigger than Digit one");
}



if (digit1 == digit2)
{
    Console.WriteLine("Digit one equals Digit two");
}
else
{
    Console.WriteLine("Digit one does not equal Digit two");
}



if ((digit1 % 2) == 0)
{
    Console.WriteLine("Digit one is even");
}
else
{ 
    Console.WriteLine("Digit one is odd");
}


if ((digit2 % 2) == 0)
{
    Console.WriteLine("Digit two is even");
}
else
{
    Console.WriteLine("Digit two is odd");
}



if (digit1 < 0)
{ 
    Console.WriteLine("Digit one is negative");
}
else
{
    Console.WriteLine("Digit one is positive");
}

if (digit2 < 0)
{
    Console.WriteLine("Digit two is negative");
}
else
{
    Console.WriteLine("Digit two is positive");
}


if (digit1 < 100)
{
    Console.WriteLine("Digit one is smaller than 100");
}
else
{
    Console.WriteLine("Digit one is bigger than 100");
}

if (digit2 < 100)
{
    Console.WriteLine("Digit two is smaller than 100");
}
else
{
    Console.WriteLine("Digit two is bigger than 100");
}

var digit3 = 35.8;
var digit4 = 5.5;

var digitSum = Math.Round(digit3 + digit4);
Console.WriteLine(digitSum);