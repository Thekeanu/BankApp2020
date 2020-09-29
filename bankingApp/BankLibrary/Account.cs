using System;
using System.Reflection.Emit;

namespace BankLibrary
{
    public class Account
    {
        public string IBAN { get; set; }
        public decimal Balance { get; private set; }
        public DateTime CreationDate { get; set; }
        public decimal Intrest { get; set; }

        public override string ToString()
        {
            string zin = $"IBAN: {IBAN} Balance: {Balance} Date created: {CreationDate} Intrest: {Intrest}.";
            return zin;
        }

        public Account(string iban, decimal balance, DateTime creationDate, decimal intrest)
        {
            IBAN = iban;
            Balance = balance;
            CreationDate = creationDate;
            Intrest = intrest;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            else
            {
                throw new AmountException();
            }
        }

        public void Withdraw(decimal amount) {
            if (amount > 0 && amount < Balance)
            {
                Balance -= amount;
            }
            else
            {
                throw new AmountException();
                
        }
    }

    
}
