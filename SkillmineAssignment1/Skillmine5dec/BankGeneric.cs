using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    public class costumer
    {
        public int AcountNo { get; set; }
        public string Name { get; set; }
        
        public List<Loan> List1 = new List<Loan>();
    }
    public class Account
    {
        public string AccountType { get; set; }
        public List<costumer> Colist = new List<costumer>();
        
    }
    public class Loan
    {
        public string Loantype  { get; set; }


    }

    class BankGeneric
    {
        static void Main(string []args)
        {
            List<Account> list = new List<Account>()

            {
                new Account { AccountType="Saving Accoount", 
                    Colist={new costumer { AcountNo=1234,Name ="Costumer1",List1 ={ new Loan { Loantype="car loan"}, new Loan { Loantype = "gold loan" } } },
                    new costumer { AcountNo=1235,Name ="Costumer2",List1 ={ new Loan { Loantype ="car loan"} } }
                    }

                },
                new Account { AccountType="Current Accoount",
                    Colist={new costumer { AcountNo=1236,Name ="Costumer3",List1 ={ new Loan { Loantype ="buisness loan"} } },
                    new costumer { AcountNo=1237,Name ="Costumer4",List1 ={ new Loan { Loantype ="Gold loan"} } }
                    }
                }


            };
            foreach (Account c in list)
            {
                Console.WriteLine($"AccountType={c.AccountType}" );
                foreach (costumer  d in c.Colist )
                {
                    Console.WriteLine($"\tAccount num={d.AcountNo },Account Holder Name={d.Name }");
                    foreach (Loan  e in d.List1 )
                    {
                        Console.WriteLine($"\tType of Loan={e.Loantype}");
                    }
                }
            }
        }
    }
}
