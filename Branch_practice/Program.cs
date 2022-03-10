
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


double digit3 = 35.8234;
double digit4 = 5.5567;

var digitSum = Math.Round(digit3 + digit4);
Console.WriteLine(digitSum);

double differenceNumber = digit3 - digit4;
if(differenceNumber < 0)
{
    differenceNumber *= -1;
}
differenceNumber = Math.Round(differenceNumber, 2);
Console.WriteLine(differenceNumber);


int time = 8;
int day = 7;
int month = 3;
int year = 2022;

if(time > 0 && time < 12)
{
    Console.WriteLine("Good morning sunshine");
}
else if(time >= 13 && time <= 19)
{
    Console.WriteLine("Good Afternoon. Work hard");
}
else if(time >= 20 && time <= 24)
{
    Console.WriteLine("Good evening. Get some rest");
}
else
{
    Console.WriteLine("Please enter a valid time variable");
} 

if (day <= 0 || day >= 32)
{
    Console.WriteLine("Please enter a valid day variable");
}
else if (month <= 0 || month >= 12)
{
    Console.WriteLine("Please enter a valid month variable");
}
else if (year <= 0)
{
    Console.WriteLine("Please enter a valid year variable");
}
else
{
    Console.WriteLine(year.ToString() + "/" + month.ToString("d2") + "/" + day.ToString("d2"));
}


/*
/// BONUS 

Console.WriteLine("Please write the day:");
string day1 = Console.ReadLine();

Console.WriteLine("Please write the month:");
string month1 = Console.ReadLine();

Console.WriteLine("Please write the year:");
string year1 = Console.ReadLine();

Console.WriteLine("Please select the date formatting. 1 - YYYY/MM/DD, 2- YYYY.MM.DD");
var answer = Console.ReadLine();

/*
if (answer = "1")
{ Console.WriteLine(year1 + "/" + month1 + "/" + day1);
}

if (answer = "2")
{
    Console.WriteLine(day1 + "/" + month1 + "/" + year1);
}
else
{
    Console.WriteLine("Please select from given options: 1 - YYYY/MM/DD, 2- YYYY.MM.DD");
}
*/
