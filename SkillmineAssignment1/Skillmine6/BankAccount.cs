using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine6
{
    class BankAccount
    {
        int Accountno;
        string  Account_type;
        int Balance;
        string Costumer_name;

        public int AccountNo
        {
            set
            {
                Accountno   = value;
            }
            get
            {
                return Accountno ;
            }
        }
        public string Acount_Type
        { 
            set
            {
                Account_type = value;
            }
            get
            {
                return Account_type;
            }
        }
        public string Name
        {
            set
            {
                Costumer_name   = value;
            }
            get
            {
                return Costumer_name ;
            }
        }
        public int Balance1
        {
            set
            {
                Balance  = value;
            }
            get
            {
                return Balance ;
            }
        }


    }
    class BankAccountinfo
    {
        static void Main(string []args)
        {
            BankAccount a = new BankAccount();
            a.AccountNo  = 123;
            a.Acount_Type = "Saving";
            a.Balance1 = 4561;
            a.Name = "Raj";

            Console.WriteLine(" Name of of Account Holder="+a.Name +  " Account No=" + a.AccountNo + " Account Type=" + a.Acount_Type + " Bank Balance=" + a.Balance1);

        }
    }
}
