using System;

Console.Write("Enter amount in USD: ");
double amount = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter exchange rate from USD to EUR: ");
double exchangeRate = Convert.ToDouble(Console.ReadLine());
double amountInEUR = amount * exchangeRate;
Console.Write("Amount in EUR: {0:F2} ",amountInEUR);