using System;

public class BankAccount
{
    string accountHolder;
    double balance;
    public double accountNumber;
    public string receipt;

    public string AccountHolder
    {
        get { return accountHolder; }
        set { accountHolder = value; }
    }

    public double Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    public BankAccount(string _accountHolder, double _balance, double _accountNumber, string _receipt)
    {
        this.accountHolder = _accountHolder;
        this.balance = _balance;
        this.accountNumber = _accountNumber;
        this.receipt = _receipt;
    }

    public BankAccount(BankAccount oldAccount)
    {
        this.accountHolder = oldAccount.accountHolder;
        this.balance = oldAccount.balance;
        this.accountNumber = oldAccount.accountNumber;
        this.receipt = oldAccount.receipt;
    }
}

class Program
{
    static void Main()
    {
        BankAccount b1 = new BankAccount("Antoreep", 1234, 12345678909, "XYxlJHgfdgdg");
        BankAccount b2 = new BankAccount(b1);
        BankAccount b3 = new BankAccount(b2);

        b2.Balance = 500;
        b3.Balance = 66;

        Console.WriteLine($"Acc01: {b1.Balance}");
        Console.WriteLine($"Acc02: {b2.Balance}");
        Console.WriteLine($"Acc03: {b3.Balance}");
    }
}
