using BankingApp.Interfaces.BL;
using BankingApp.Interfaces.Repository;
using BankingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.BL
{
    public class BAccount : IBAccount
    {
        private readonly IAccountRepository _accountRepository = null;
        public BAccount(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public bool Register(Account account)
        {
            return _accountRepository.Register(account);
        }

        public bool VerifyLogin(AccountLogin accountLogin)
        {
            return _accountRepository.VerifyLogin(accountLogin);
        }
    }
}
