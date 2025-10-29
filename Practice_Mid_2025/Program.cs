// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Enter Your Name: ");
//string? userName = Console.ReadLine();

//Console.WriteLine("Enter marks for the following Subjects: ");
//Console.WriteLine("Maths: ");
//int maths = int.Parse(Console.ReadLine());

//Console.WriteLine("Physics: ");
//int physics = int.Parse(Console.ReadLine());

//Console.WriteLine("Computer: ");
//int computer = int.Parse(Console.ReadLine());

//int total = maths + physics + computer;
//float avg =  total / 3f;
//char grade;

//if (avg >= 80)
//{
//    grade = 'A';
//}
//else if (avg >= 60)
//{
//    grade = 'B';
//}
//else if (avg >= 40)
//{
//    grade = 'C';
//}
//else
//{
//    grade = 'F';
//}

//Console.WriteLine($"Your Avg marks are {avg} and your grade is {grade}.");


//Jagged Arrays Employee Sales Store

Console.Write("Enter Number of employees in your store: ");
int totalEmployees = int.Parse(Console.ReadLine()!);

double[][] salesData = new double[totalEmployees][];

for (int i = 0; i < totalEmployees; i++)
{
    Console.WriteLine($"Enter Total Number of Sales for {i + 1} employee:");
    int totalSalesEachEmp = int.Parse(Console.ReadLine()!);
    salesData[i] = new double[totalSalesEachEmp];
    for (int j = 0; j < totalSalesEachEmp; j++)
    {
        Console.Write($"Employee {i+1} - Sale {j + 1} : ");
        salesData[i][j] = double.Parse(Console.ReadLine()!);
    }
}



double Average(double[] data)
{
    double sum = 0;
    for (int i = 0;i < data.Length; i++)
    {
        sum += data[i];
    }
    return sum / data.Length;
}
