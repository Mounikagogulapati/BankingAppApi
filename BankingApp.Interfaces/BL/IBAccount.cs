using BankingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Interfaces.BL
{
    public interface IBAccount
    {
        public bool VerifyLogin(AccountLogin accountLogin);
        public bool Register(Account account);
    }
}
