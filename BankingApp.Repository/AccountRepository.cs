using BankingApp.DAL;
using BankingApp.Interfaces.Repository;
using BankingApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public bool VerifyLogin(AccountLogin login)
        {
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@can", login.AccountNo);
            sqlParameters[1] = new SqlParameter("@frmDate", login.UserName);
            sqlParameters[2] = new SqlParameter("@toDate", login.Password);
            sqlParameters[3] = new SqlParameter("@toDate", login.IsUserName);
            SqlHelper.ExecuteDataset(_conString, CommandType.StoredProcedure, "BankApp_VerifyLogin", sqlParameters);
            return true;
        }

    }
}
