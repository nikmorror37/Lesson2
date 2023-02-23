using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class AccountTransact : AccountInfo, ITransaction
    {
        public void CreateAccount()
        {
            Console.WriteLine("Введите информацию об аккаунте...");
            Console.Write("Введите Account ID: ");
            AccountId = int.Parse(Console.ReadLine());
            Console.Write("Введите имя аккаунта: ");
            AccountName = Console.ReadLine();
            Console.Write("Введите тип аккаунта [Коммерческий/Персональный] - C/P: ");
            AccountType = char.Parse(Console.ReadLine());
            Console.Write("Введите депозит: ");
            Deposit = decimal.Parse(Console.ReadLine());


        }

        public void ModifyAccount(int accountId)
        {
            if (accountId == AccountId)
            {
                Console.WriteLine("Редактирование аккаунта");
                Console.WriteLine($"Текущий аккаунт ID {AccountId}");
                Console.Write("Обновить имя аккаунта: ");
                AccountName = Console.ReadLine();
                Console.Write("Обновить тип аккаунта [Коммерческий/Персональный] - C/P: ");
                AccountType = char.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Неверный ID аккаунта");
            }
        }

        public void MoneyDeposit()
        {
            decimal amount;
            Console.Write("Введите сумму внесенных средств: ");
            amount = decimal.Parse(Console.ReadLine());
            if (amount >= 0) 
                Deposit += amount;
            else
                Console.WriteLine("Введите положительную сумму");
        }

        public void MoneyWithDraw()
        {
            decimal amount;
            Console.Write("Введите сумму внесенных средств: ");
            amount = decimal.Parse(Console.ReadLine());
            Deposit -= amount;
        }

        public void ShowAccount()
        {
            Console.WriteLine("Информация об аккаунте");
            Console.WriteLine($"Аккаунт ID - {AccountId}");
            Console.WriteLine($"Имя аккаунта - {AccountName}");
            Console.WriteLine($"Тип аккаунта - {AccountType}");
            Console.WriteLine($"Баланс аккаунта - {Deposit}");
            Console.WriteLine($"Время создания аккаунта - {OpenedDate.ToString("dd-MM-yyyy HH:mm")}");
        }

        public void BalanceShow()
        {
            Console.WriteLine("Информация об текущем балансе аккаунте");
            Console.WriteLine($"Аккаунт ID - {AccountId}");
            Console.WriteLine($"Баланс счета - {Deposit}");
        }



    }


}
