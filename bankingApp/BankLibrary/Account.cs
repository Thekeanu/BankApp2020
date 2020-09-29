using System;
using System.Reflection.Emit;

namespace BankLibrary
{
    public class Account
    {
        public string IBAN { get; set; }
        public decimal Balance { get; set; }
        public DateTime CreationDate { get; set; }
        public decimal Intrest { get; set; }

        public override string ToString()
        {
            string zin = $"IBAN: {IBAN} Balance: {Balance} Date created: {CreationDate} Intrest: {Intrest}.";
            return zin;
        }
    }

    
}
