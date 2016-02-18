using ODataInjection.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ODataInjection.Database
{
    public class UserContextInitializer : DropCreateDatabaseIfModelChanges<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            List<User> users = new List<User>();

            User aUser = new User { FirstName = "Bedirhan", LastName = "Urgun", UserName = "bedirhan", LastLogin = DateTime.Now.Subtract(TimeSpan.FromDays(1)), Token = Guid.NewGuid() };
            aUser.Accounts = new List<Account>();
            
            Account anAccount = new Account { AccountNumber = Guid.NewGuid(), Type = Account.AccountType.MAIN, Balance = 5463.4M, CreateDate = DateTime.Now.Subtract(TimeSpan.FromDays(90)) };
            anAccount.Transfers = new List<Transfer>();
            anAccount.Transfers.Add(new Transfer { Amount = 12.5M, IsSuccess = true, ToAccountNumber = Guid.NewGuid(), TransferDate = DateTime.Now.Subtract(TimeSpan.FromDays(2))});
            anAccount.Transfers.Add(new Transfer { Amount = 42.5M, IsSuccess = true, ToAccountNumber = Guid.NewGuid(), TransferDate = DateTime.Now.Subtract(TimeSpan.FromDays(5)) });
            anAccount.Transfers.Add(new Transfer { Amount = 2.5M, IsSuccess = true, ToAccountNumber = Guid.NewGuid(), TransferDate = DateTime.Now.Subtract(TimeSpan.FromDays(7)) });
            anAccount.Transfers.Add(new Transfer { Amount = 7.5M, IsSuccess = false, ToAccountNumber = Guid.NewGuid(), TransferDate = DateTime.Now.Subtract(TimeSpan.FromDays(9)) });
            aUser.Accounts.Add(anAccount);

            anAccount = new Account { AccountNumber = Guid.NewGuid(), Type = Account.AccountType.SAVINGS, Balance = 103.3M, CreateDate = DateTime.Now.Subtract(TimeSpan.FromDays(60)) };
            anAccount.Transfers = new List<Transfer>();
            anAccount.Transfers.Add(new Transfer { Amount = 1.5M, IsSuccess = true, ToAccountNumber = Guid.NewGuid(), TransferDate = DateTime.Now.Subtract(TimeSpan.FromDays(1)) });
            anAccount.Transfers.Add(new Transfer { Amount = 62.5M, IsSuccess = true, ToAccountNumber = Guid.NewGuid(), TransferDate = DateTime.Now.Subtract(TimeSpan.FromDays(3)) });
            anAccount.Transfers.Add(new Transfer { Amount = 7.5M, IsSuccess = true, ToAccountNumber = Guid.NewGuid(), TransferDate = DateTime.Now.Subtract(TimeSpan.FromDays(5)) });
            anAccount.Transfers.Add(new Transfer { Amount = 3.5M, IsSuccess = true, ToAccountNumber = Guid.NewGuid(), TransferDate = DateTime.Now.Subtract(TimeSpan.FromDays(9)) });
            aUser.Accounts.Add(anAccount);

            anAccount = new Account { AccountNumber = Guid.NewGuid(), Type = Account.AccountType.CREDIT, Balance = 0.0M, CreateDate = DateTime.Now.Subtract(TimeSpan.FromDays(30)) };
            aUser.Accounts.Add(anAccount);

            users.Add(aUser);

            context.Users.Add(aUser);

            aUser = new User { FirstName = "Ozay", LastName = "Akdora", UserName = "ozay", LastLogin = DateTime.Now.Subtract(TimeSpan.FromDays(3)), Token = Guid.NewGuid() };
            aUser.Accounts = new List<Account>();

            anAccount = new Account { AccountNumber = Guid.NewGuid(), Type = Account.AccountType.MAIN, Balance = 7463.4M, CreateDate = DateTime.Now.Subtract(TimeSpan.FromDays(120)) };
            anAccount.Transfers = new List<Transfer>();
            anAccount.Transfers.Add(new Transfer { Amount = 12.5M, IsSuccess = true, ToAccountNumber = Guid.NewGuid(), TransferDate = DateTime.Now.Subtract(TimeSpan.FromDays(43)) });
            anAccount.Transfers.Add(new Transfer { Amount = 42.5M, IsSuccess = true, ToAccountNumber = Guid.NewGuid(), TransferDate = DateTime.Now.Subtract(TimeSpan.FromDays(23)) });
            anAccount.Transfers.Add(new Transfer { Amount = 2.5M, IsSuccess = true, ToAccountNumber = Guid.NewGuid(), TransferDate = DateTime.Now.Subtract(TimeSpan.FromDays(12)) });
            anAccount.Transfers.Add(new Transfer { Amount = 7.5M, IsSuccess = false, ToAccountNumber = Guid.NewGuid(), TransferDate = DateTime.Now.Subtract(TimeSpan.FromDays(1)) });
            aUser.Accounts.Add(anAccount);

            anAccount = new Account { AccountNumber = Guid.NewGuid(), Type = Account.AccountType.MAIN, Balance = 463.4M, CreateDate = DateTime.Now.Subtract(TimeSpan.FromDays(10)) };
            anAccount.Transfers = new List<Transfer>();
            anAccount.Transfers.Add(new Transfer { Amount = 2.5M, IsSuccess = true, ToAccountNumber = Guid.NewGuid(), TransferDate = DateTime.Now.Subtract(TimeSpan.FromDays(65)) });
            anAccount.Transfers.Add(new Transfer { Amount = 6.5M, IsSuccess = true, ToAccountNumber = Guid.NewGuid(), TransferDate = DateTime.Now.Subtract(TimeSpan.FromDays(22)) });
            anAccount.Transfers.Add(new Transfer { Amount = 65.5M, IsSuccess = false, ToAccountNumber = Guid.NewGuid(), TransferDate = DateTime.Now.Subtract(TimeSpan.FromDays(11)) });
            anAccount.Transfers.Add(new Transfer { Amount = 12.5M, IsSuccess = false, ToAccountNumber = Guid.NewGuid(), TransferDate = DateTime.Now.Subtract(TimeSpan.FromDays(12)) });
            aUser.Accounts.Add(anAccount);

            anAccount = new Account { AccountNumber = Guid.NewGuid(), Type = Account.AccountType.CREDIT, Balance = 12.1M, CreateDate = DateTime.Now.Subtract(TimeSpan.FromDays(35)) };
            aUser.Accounts.Add(anAccount);

            users.Add(aUser);

            context.Users.Add(aUser);

            aUser = new User { FirstName = "Deniz", LastName = "Cevik", UserName = "deniz", LastLogin = DateTime.Now.Subtract(TimeSpan.FromDays(32)), Token = Guid.NewGuid() };
            aUser.Accounts = new List<Account>();

            anAccount = new Account { AccountNumber = Guid.NewGuid(), Type = Account.AccountType.MAIN, Balance = 17463.4M, CreateDate = DateTime.Now.Subtract(TimeSpan.FromDays(20)) };
            anAccount.Transfers = new List<Transfer>();
            anAccount.Transfers.Add(new Transfer { Amount = 1342.5M, IsSuccess = true, ToAccountNumber = Guid.NewGuid(), TransferDate = DateTime.Now.Subtract(TimeSpan.FromDays(13)) });
            anAccount.Transfers.Add(new Transfer { Amount = 422.5M, IsSuccess = true, ToAccountNumber = Guid.NewGuid(), TransferDate = DateTime.Now.Subtract(TimeSpan.FromDays(14)) });
            anAccount.Transfers.Add(new Transfer { Amount = 122.5M, IsSuccess = true, ToAccountNumber = Guid.NewGuid(), TransferDate = DateTime.Now.Subtract(TimeSpan.FromDays(1)) });
            anAccount.Transfers.Add(new Transfer { Amount = 27.5M, IsSuccess = false, ToAccountNumber = Guid.NewGuid(), TransferDate = DateTime.Now.Subtract(TimeSpan.FromDays(21)) });
            aUser.Accounts.Add(anAccount);

            anAccount = new Account { AccountNumber = Guid.NewGuid(), Type = Account.AccountType.MAIN, Balance = 6463.4M, CreateDate = DateTime.Now.Subtract(TimeSpan.FromDays(10)) };
            anAccount.Transfers = new List<Transfer>();
            anAccount.Transfers.Add(new Transfer { Amount = 21.5M, IsSuccess = true, ToAccountNumber = Guid.NewGuid(), TransferDate = DateTime.Now.Subtract(TimeSpan.FromDays(63)) });
            anAccount.Transfers.Add(new Transfer { Amount = 61.5M, IsSuccess = true, ToAccountNumber = Guid.NewGuid(), TransferDate = DateTime.Now.Subtract(TimeSpan.FromDays(23)) });
            anAccount.Transfers.Add(new Transfer { Amount = 615.5M, IsSuccess = false, ToAccountNumber = Guid.NewGuid(), TransferDate = DateTime.Now.Subtract(TimeSpan.FromDays(11)) });
            anAccount.Transfers.Add(new Transfer { Amount = 112.5M, IsSuccess = false, ToAccountNumber = Guid.NewGuid(), TransferDate = DateTime.Now.Subtract(TimeSpan.FromDays(1)) });
            aUser.Accounts.Add(anAccount);

            anAccount = new Account { AccountNumber = Guid.NewGuid(), Type = Account.AccountType.CREDIT, Balance = 1200.1M, CreateDate = DateTime.Now.Subtract(TimeSpan.FromDays(15)) };
            aUser.Accounts.Add(anAccount);

            users.Add(aUser);

            context.Users.Add(aUser);

            context.SaveChanges();

            base.Seed(context);
        }
    }
}