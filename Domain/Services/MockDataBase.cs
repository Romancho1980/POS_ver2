using Domain.Models.SimpleModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class MockDataBase
    {
        public List<ClientAccountVer1> accounts;
        public MockDataBase()
        {
            accounts = new List<ClientAccountVer1>();   
        }

        public void InitData()
        {
            accounts.Add(new ClientAccountVer1()
            {
                Id = 1,
                Name = "Roman",
                Surname="Shcherbakow",
                INN="66546497732132",
                City="Новгород",
                Passport="54658744654",
                Birthday=DateTime.Now,
                Account="2204 2567 5444 3144",
                Balance=1550M,
                Description="RiP was Here"
            });

            accounts.Add(new ClientAccountVer1()
            {
                Id = 1,
                Name = "Nikita",
                Surname = "Shcherbakow",
                INN = "77441321446542",
                City = "Спб",
                Passport = "65647987984",
                Birthday = DateTime.Now,
                Account = "8999 3217 4773 1247",
                Balance = 15.10M,
                Description = "RiP was Here"
            });

            accounts.Add(new ClientAccountVer1()
            {
                Id = 1,
                Name = "Степан",
                Surname = "Работа",
                INN = "77987984312211",
                City = "Москва",
                Passport = "12335577989",
                Birthday = DateTime.Now,
                Account = "9512 6547 1274 6571",
                Balance = 45.51M,
                Description = "RiP was Here"
            });

            accounts.Add(new ClientAccountVer1()
            {
                Id = 1,
                Name = "Билл",
                Surname = "Gates",
                INN = "99845446541121",
                City = "Нью Йорк",
                Passport = "99844466612",
                Birthday = DateTime.Now,
                Account = "8794 5412 6598 3284",
                Balance = 15505840M,
                Description = "RiP was Here"
            });

            accounts.Add(new ClientAccountVer1()
            {
                Id = 1,
                Name = "Gold",
                Surname = "Dragon",
                INN = "78746546214473",
                City = "Омск",
                Passport = "66546547722",
                Birthday = DateTime.Now,
                Account = "2205 5848 6312 8951",
                Balance = 10551.97M,
                Description = "RiP was Here"
            });
        }


    }
}
