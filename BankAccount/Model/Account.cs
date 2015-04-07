using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Model
{
    public class Account
    {
        public int Id { get; set; }
        public string Client { get; set; }
        public int Balance { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public int CreditLimit { get; set; }


    }
}
