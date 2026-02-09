using System;

Console.Write("Enter the principal amount: ");
double principal = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter rate of interest: ");
double annualInterestRate = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter time in years: ");
double timeInYears = Convert.ToDouble(Console.ReadLine());
double interest = (principal * annualInterestRate * timeInYears) / 100;
Console.Write($"Simple Interest: {interest}");