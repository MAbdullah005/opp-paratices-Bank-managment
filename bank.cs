using System;
using System.ComponentModel.DataAnnotations;
public class Bank
{
    public string name;
    public string location;
    public Bank(string name, string location)
    {
        this.name = name;
        this.location = location;
    }
}
public class Bank_account
{
    string account_name;
    string account_id;
    int balance;
    bool status;
    DateTime created;
    public Bank Bank;
    public Bank_account(string name, string id, int balance, bool status, DateTime dateTime)
    {
        this.account_name = name;
        this.account_id = id;
        this.balance = balance;
        this.status = status;
        this.created = dateTime;
    }
}
public class Customer_account
{
    string customer_name;
    string cinc;
    string adress;
    string phone_num;
    public Bank_account bank_account;
    public Customer_account(string name, string cinc, string adress, string phone)
    {
        this.customer_name = name;
        this.cinc = cinc;
        this.adress = adress;
        this.phone_num = phone;
    }

}
public class Class1
{
    static void Main()
    {
        Customer_account customer_Account = new Customer_account("ali", "321", "adress1121", "0321-1232133");
        customer_Account.bank_account = new Bank_account("ali khan ", "212", 13213, true, DateTime.Now); 
        customer_Account.bank_account.Bank= new Bank("ubl,", "gt road lahore");
    }
