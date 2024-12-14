using Console_Server.Context;
using Console_Server.Models.Entities.SimpleEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Console_Server.Services
{
    internal class DbService
    {
        /// <summary>
        /// _dbContext - экземпляр класса управления БД (EntityFrameWork)
        /// </summary>
        private ApplicationContext _dbContext;

        // В конструктор передаю ссылку на экземпляр БД
        public DbService(ApplicationContext DBContext)
        {
            _dbContext = DBContext;
        }

        // Получить коллекцию всех клиентов в БД
        public IEnumerable<SimpleClientAccount> GetAllClients()
        {
            return _dbContext.Clients.Select(x => x); // LINQ - выражение
        }

        // Добавление нового клиента
        public void AddNewClient()
        {
            Console.WriteLine("***** Внесите данные о клиенте *****");
            var new_client=new SimpleClientAccount();

            Console.WriteLine("Введите имя");
            var client_name = Console.ReadLine();
            new_client.Name = client_name;

            Console.WriteLine("Введите фамилию");
            var client_surname = Console.ReadLine();
            new_client.Surname = client_surname;

            Console.WriteLine("Введите ИНН");
            var client_INN = Console.ReadLine();
            new_client.INN = client_INN;

            Console.WriteLine("Введите номер счета");
            var client_account = Console.ReadLine();
            new_client.Account = client_account;

            Console.WriteLine("Введите баланс (Десятичный разделитель - запятая )");
            var client_balance = Console.ReadLine();
            new_client.Balance = decimal.Parse(client_balance);

            Console.WriteLine("************************");
            Console.WriteLine("**Сохрание данных в БД**");

            // добавляю поля, которые не заполнены, чтобы не выбрасывало исключение :)
            // Потому что по умолчанию значения этих полей установлены в значение null
            new_client.Description = "";
            new_client.Birthday = DateTime.Now;
            new_client.City = "Новгород";
            new_client.Passport = "";
            // Вызываю метод Add - добавить, для добавления строки (пареметр new_client) в БД. 
            _dbContext.Clients.Add(new_client);
            // Сохранить изменения в БД
            _dbContext.SaveChanges();
        }

        // Этот метод использовался в качестве автоматического добавления
        //public void AddRandomClient()
        //{
        //    var client = new SimpleClientAccount()
        //    {
        //        Name = "Bill",
        //        Surname = "Gates",
        //        INN = "2235588474498764",
        //        City = "Спб",
        //        Passport = "9879444688243123",
        //        Birthday = DateTime.Now,
        //        Account = "2204 2256 5331 3576",
        //        Balance = 702.16M,
        //        Description = "No any description"
        //    };
        //    _dbContext.Clients.Add(client);
        //    _dbContext.SaveChanges();
        //}

        /// <summary>
        /// Получить баланс клиента по номеру счёта
        /// </summary>
        /// <param name="account"> Номер счёта</param>
        /// <returns> 
        /// Возвращает тип decimal - баланс клиента
        /// </returns>
        public decimal GetBalanceByAccount(string account)
        {
            // перебрать все записи в БД, при этом сравнивая номер счёта с параметром метода - "номер счёта (string account)"
            // И если совпадают, то добавить в коллекцию. (Where (x=> x.Account.Equals(account)) 
            // FirstOrDefault - выбирает только первую запись в коллекции, а также возвращает null, если коллекция пуста.
            var client = _dbContext.Clients.Where(x => x.Account.Equals(account)).FirstOrDefault();
            //Если коллекция пуста, т.е. нет клиента с таким томером счёта, то 
            //выводим ошибку
            if (client == null)
            {
                Console.WriteLine("Клиент не найден");
                return -1;
                // и возвращаем отрицательный баланс, для обработчика 
            }
            // возвращаем тип decimal  - баланс счёта
            return client.Balance;
        }


        /// <summary>
        /// Редактирование записи по Id. То есть ищем клиента по Id и делаем изменения,
        /// внося значения второго параметра этого метода
        /// </summary>
        /// <param name="Id">Номер Записи, которую надо изменить. Первичный ключ</param>
        /// <param name="client">Экземпляр класса "клиент", т.е. данные которые надо изменить в найденой записи</param>
        public void EditClientById(int Id, SimpleClientAccount client)
        {
            // Находим запись в БД, используя Id - Это первичный ключ.
            var tmp_client = _dbContext.Clients.Find(Id);

            // Если нет клиента с таким Id
            // Выводим ошибку в консоль
            if (tmp_client == null)
            {
                Console.WriteLine("Клиент не найден");
                return;
            }

            // В тестовом варианте изменяются только имя и номер счёта клиента,
            // а остальные данные остаются без изменений
            tmp_client.Name = client.Name;
            tmp_client.Account = client.Account;

            // Созраняем изменения в БД
            _dbContext.SaveChanges();
        }
        /// <summary>
        /// Редактирование данных клиента.
        /// В качестве параметра для поиска записи о клиенте в БД используется Имя клиента
        /// </summary>
        /// <param name="Name"> Имя клиента  </param>
        /// <param name="client"> Экзепляр класса "клиент". Эти данные мы внесём (я внесу) в БД, в найденную строку.
        /// </param>
        
        
        public void EditClientByName(string Name, SimpleClientAccount client)
        {
            // перебрать все записи в БД, при этом сравнивая номер счёта с параметром метода - "номер счёта (string account)"
            // И если совпадают, то добавить в коллекцию. (Where (x=> x.Account.Equals(account)) 
            // FirstOrDefault - выбирает только первую запись в коллекции, а также возвращает null, если коллекция пуста.
            var tmp_client = _dbContext.Clients.Where(x => x.Name.Equals(Name)).FirstOrDefault();

            // Если коллекция пуста, т.е.нет клиента с таким томером счёта, то
            //выводим ошибку
            if (tmp_client == null)
            {
                Console.WriteLine("Клиент не найден");
                return;
            }

            // В тестовом варианте изменяются только имя и баланс клиента,
            // а остальные данные остаются без изменений
            tmp_client.Name = client.Name;
            tmp_client.Balance = client.Balance;

            // Созраняем изменения в БД
            _dbContext.SaveChanges();
        }


       /// <summary>
       /// Изменения баланся клиента
       /// </summary>
       /// <param name="Account"> Номер счета, баланс которого нужно изменить</param>
       /// <param name="new_balance"> Новая сумма денег</param>
        public void EditClientBalance(string Account, decimal new_balance)
        {
            // перебрать все записи в БД, при этом сравнивая номер счёта с параметром метода - "номер счёта (string account)"
            // И если совпадают, то добавить в коллекцию. (Where (x=> x.Account.Equals(account)) 
            // FirstOrDefault - выбирает только первую запись в коллекции, а также возвращает null, если коллекция пуста.
            var tmp_client = _dbContext.Clients.Where(x => x.Account.Equals(Account)).FirstOrDefault();

            // Если коллекция пуста, т.е.нет клиента с таким томером счёта, то
            //выводим ошибку
            if (tmp_client == null)
            {
                Console.WriteLine("Клиент не найден");
                return;
            }
            // Вносим (вношу) изменения в поле "баланс" найденной записи
            tmp_client.Balance = new_balance;
            //Сохраняем изменения в БД
            _dbContext.SaveChanges();
        }


        /// <summary>
        /// Удаляем запись из БД. В качестве параметра используется поле Id
        /// </summary>
        /// <param name="id">Id клиента, которого нужно покилять из БД</param>
        public void DeleteClientById(int id)
        {
            //находим клиента, используя "Первичный ключ", т.е. поле Id
            var tmp_client = _dbContext.Clients.Find(id);

            // null - если не найден, то выбрасываем ошибку
            if (tmp_client == null)
            {
                Console.WriteLine("Клиент не найден");
                return;
            }

            //Удаляем из БД
            _dbContext.Clients.Remove(tmp_client);


            // Созраняем изменения в БД
            _dbContext.SaveChanges();
        }


        /// <summary>
        /// Удаляем клиента из БД, к качестве параметра используем номер счета.
        /// То есть - удаляем запись, у которой номер счёта - параметр (string account). :)
        /// </summary>
        /// <param name="account">Номёр счёта</param>
        public void DeleteClientByAccount(string account)
        {
            // перебрать все записи в БД, при этом сравнивая номер счёта с параметром метода - "номер счёта (string account)"
            // И если совпадают, то добавить в коллекцию. (Where (x=> x.Account.Equals(account)) 
            // FirstOrDefault - выбирает только первую запись в коллекции, а также возвращает null, если коллекция пуста.
            var tmp_client = _dbContext.Clients.Where(x => x.Account.Equals(account)).FirstOrDefault();

            // Если коллекция пуста, т.е.нет клиента с таким томером счёта, то
            //выводим ошибку
            if (tmp_client == null)
            {
                Console.WriteLine("Клиент не найден");
                return;
            }
            //Удаляем из БД
            _dbContext.Clients.Remove(tmp_client);

            // Созраняем изменения в БД
            _dbContext.SaveChanges();
        }


        //  **** Покупка ****
        // Просто переводим (на одном счёте уменьшаем баланс , т.е balance = balance - price (сумма), а на другом увеличиваем 
        // Проверяем, если на счету необходимая сумма денег, если да , то делаем изменения, иначе
        // "выбрасываем" ошибку

        // from_account - номер счёта, баланс которого будем (буду) уменьшать на price
        // to_account - номер счёта, баланс которого будет увеличиваться на price
        // price - это и есть та сумма, которая вводится в терминале Arduino
        public void MakePurchase(string from_account, string to_account, decimal price)
        {
            // Получаем баланс по номеру счёта. Метод описан выше 
            var client_balance = GetBalanceByAccount(from_account);
            if (client_balance == -1) // то есть нет клиента с таким номером счёта
                return; // выходим

            decimal new_client_balance; // новая сумма денег

            // делаем проверку, что полученный баланс клиента "from_account" больше или равен сумме покупки
            if (client_balance >= price)
                // уменьшаем баланс
                new_client_balance = client_balance - price;
            else
            {
                // иначе - выбрасываем ошибку 
                Console.WriteLine("Недостаточно средств... Устройся на работу....");
                return;
            }

            //Вносим изменения в поле - баланс на счету -  "from_account"
            EditClientBalance(from_account, new_client_balance);

            // PS: На второй счёт есчо не сделать добавления :)
            // то есть просто вносим изменения на счёту клинта, который покупает товар
        }
    }
}
