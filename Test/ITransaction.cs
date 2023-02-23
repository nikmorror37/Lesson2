using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public interface ITransaction
    {
        public void CreateAccount();
        public void ShowAccount();
        public void ModifyAccount(int accountId);
        public void MoneyDeposit();
        public void MoneyWithDraw();
        public void BalanceShow();

    }

}
