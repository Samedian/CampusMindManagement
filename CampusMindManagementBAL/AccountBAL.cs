using CampusMindManagementDAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace CampusMindManagementBAL
{
    public class AccountBAL : IAccountBAL
    {
        private readonly IAccountDAL _accountDAL;
        public AccountBAL(IAccountDAL accountDAL)
        {
            _accountDAL = accountDAL;
        }
        public string Access(string UserName, string Password)
        {
            string role = _accountDAL.Access(UserName, Password);
            return role;
        }
    }
}
