using BankingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Interfaces.Repository
{
    public interface IAccountRepository
    {
        public bool VerifyLogin(AccountLogin accountLogin);
    }
}
