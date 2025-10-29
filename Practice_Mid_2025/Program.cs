// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Enter Your Name: ");
string? userName = Console.ReadLine();

Console.WriteLine("Enter marks for the following Subjects: ");
Console.WriteLine("Maths: ");
int maths = int.Parse(Console.ReadLine());

Console.WriteLine("Physics: ");
int physics = int.Parse(Console.ReadLine());

Console.WriteLine("Computer: ");
int computer = int.Parse(Console.ReadLine());

int total = maths + physics + computer;
float avg =  total / 3;
char grade;

if (avg >= 80)
{
    grade = 'A';
}
else if (avg >= 60)
{
    grade = 'B';
}
else if (avg >= 40)
{
    grade = 'C';
}
else
{
    grade = 'F';
}

Console.WriteLine($"Your Avg marks are {avg} and your grade is {grade}.");