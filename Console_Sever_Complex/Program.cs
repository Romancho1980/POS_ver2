using Console_Sever_Complex.Context;
using Console_Sever_Complex.Models;
using Microsoft.EntityFrameworkCore;

namespace Console_Sever_Complex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ApplicationContext _dbContext= new ApplicationContext();
            CardAccount account = new CardAccount()
            {
                Account = "2214 2566 5488 6778",
                TypeAccount = "Debet",
                Balance = 10233.84M,
                CreateDate = DateTime.Now,
                Description = "No any description",
//                ClientId = "21"
            };

            CardAccount account2 = new CardAccount()
            {
                Account = "6547 3232 6574 4881",
                TypeAccount = "Debet",
                Balance = 4056.13M,
                CreateDate = DateTime.Now,
                Description = "No any description",
  //              ClientId = "ClientId",
            };
            List<CardAccount> cardAccounts = new List<CardAccount>();
            cardAccounts.Add(account);
            cardAccounts.Add(account2);
            Client client = new Client()
            {
                INN = "21",
                Name = "Roman",
                Surname = "Shcherbakow",
                Passport = "1",
                BirthDay = DateTime.Now,
                Address = "Novgorod",
                Account = cardAccounts
            };

            _dbContext.cardAccount.AddRange(cardAccounts);
            _dbContext.client.Add(client);
            try
            {
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
                //                Console.WriteLine(ex.ToString()); 
                return;
            }


        }
    }
}
