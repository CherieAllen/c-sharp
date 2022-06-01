// See https://aka.ms/new-console-template for more information


using Accounts;


BankAccount account = new BankAccount();

Console.WriteLine($"This us my account number {account.AccountNumber} my bal {account.Balance}. Plus my name is {account.Owner}");