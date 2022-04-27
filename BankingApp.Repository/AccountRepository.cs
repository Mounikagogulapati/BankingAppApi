using BankingApp.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly string _conString = string.Empty;
        public AccountRepository(string conString)
        {
            _conString = conString;
        }
        public bool VerifyLogin()
        {
            throw new NotImplementedException();
        }
    }
}
