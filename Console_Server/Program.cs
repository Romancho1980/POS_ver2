using Console_Server.Context;
using Console_Server.Models.Entities.SimpleEntities;
using Console_Server.Services;

namespace Console_Server
{
    internal class Program
    {
        const decimal price = 200M; // Сумма на которую будем совершать покупку
        static void ShowMenu()
        {
            Console.WriteLine("**** Simple Client ***");
            Console.WriteLine("**********************");
            Console.WriteLine(" 1 - Добавить клиента");
            Console.WriteLine(" 2 - Показать всех клиентов");
            Console.WriteLine(" 3 - Редактирование записи по Id");
            Console.WriteLine(" 4 - Редактирование записи по Имени");
            Console.WriteLine(" 5 - Показать баланс клиента по номеру счёта");
            Console.WriteLine(" 6 - Удалить клиента по Номеру счёта");
            Console.WriteLine(" 7 - Удалить клиента по Id");
            Console.WriteLine(" 8 - Обновить меню (очистить и заново нарисовать)");
            Console.WriteLine($" 9 - Совершить покупку на {price} рублей");

            Console.WriteLine("**********************");
        }
        static void Main(string[] args)
        {
            ShowMenu();
            ApplicationContext db = new ApplicationContext(); // EntityFrameWork - окрываем БД
            DbService dbService = new DbService(db); // Наши сервисы, для работы с БД

            while (true)
            {
                string client_account;
                int id;
                var key = Console.ReadKey();
                decimal balance;
                string name;

                Console.WriteLine();
                switch (key.Key)
                {
                    case ConsoleKey.D1: // нажата 1 Добавить клиента
                        Console.WriteLine("выбран 1 пункт");
                        //dbService.AddRandomClient();
                        dbService.AddNewClient();
                        break;

                    case ConsoleKey.D2:// нажата 2 Показать всех клиентов"
                        Console.WriteLine("Pressed 2");
                        var clients = dbService.GetAllClients();
                        Console.WriteLine("**************");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Id\t Name\t Surname\t Account \t\t Balance\t");
                        Console.ForegroundColor = ConsoleColor.White;
                        foreach (var user in clients)
                        {
                            Console.WriteLine($"{user.Id}\t {user.Name}\t {user.Surname}\t {user.Account} \t {user.Balance}");
                        }
                        Console.WriteLine("**************");
                        
                        break;

                    case ConsoleKey.D3:// нажата 3 Редактирование записи по Id
                        // Буду менять только имя и номер счёта клиента
                        Console.WriteLine("Pressed 3 :Редактирование записи по Id");
                        Console.WriteLine("Введите Id клиента, значения которого нужно изменить");

                        // проверку на правильность ввода не делаю
                        id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Введите Новое Имя");
                        name = Console.ReadLine();

                        Console.WriteLine("Введите новый номер счёта");
                        var account = Console.ReadLine();

                        //создаём экземпляр класса "клиент" и вносим изменения
                        var client = new SimpleClientAccount()
                        {
                            Name = name,
                            Account = account
                        };

                        // вызывает метод нашей (моей) службы
                        dbService.EditClientById(id, client);
                        Console.WriteLine("OK");
                        break;

                    case ConsoleKey.D4:// нажата 4 Редактирование записи по Имени
                                       // Буду менять только баланс клиента
                        Console.WriteLine("Pressed 4 :Редактирование записи по Имени");
                        Console.WriteLine("**************************");
                        Console.WriteLine("Введите Имя клиента, значения которого нужно изменить");

                        // проверку на правильность ввода не делаю
                        name = Console.ReadLine();
                        Console.WriteLine("Введите новый баланс клиента");
                        balance = decimal.Parse(Console.ReadLine());

                        client = new SimpleClientAccount()
                        {
                            Name= name,
                            Balance = balance
                        };
                        dbService.EditClientByName(name, client);
                        Console.WriteLine("OK");
                        break;

                    case ConsoleKey.D5:// нажата 5 Показать баланс клиента по номеру счёта
                        Console.WriteLine("Pressed 5: Показать баланс клиента");

                        Console.WriteLine("Введите номер счёта");

                        // проверку на правильность ввода не делаю
                        client_account = Console.ReadLine();

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Account {client_account}");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Balance = {dbService.GetBalanceByAccount(client_account)}");
                        Console.WriteLine("OK");
                        break;

                    case ConsoleKey.D6:// нажата 6 Удалить клиента по Номеру счёта
                        Console.WriteLine("Pressed 6: Удалить клиента по Номеру счёта");

                        Console.WriteLine("Введите номер счёта");

                        // проверку на правильность ввода не делаю
                        client_account = Console.ReadLine();
                        // вызываем сервис БД 
                        dbService.DeleteClientByAccount(client_account);
                        Console.WriteLine("OK");
                        break;

                    case ConsoleKey.D7:// нажата 7 Удалить клиента по Id
                        Console.WriteLine("Pressed 7: Удалить клиента по Id");
                        Console.WriteLine("Введите Id клиента, значения которого нужно изменить");

                        // проверку на правильность ввода не делаю
                        id = int.Parse(Console.ReadLine());
                        // вызываем сервис БД
                        dbService.DeleteClientById(id);
                        Console.WriteLine("OK");
                        break;

                    case ConsoleKey.D8:// нажата 8 Обновить меню (очистить и заново нарисовать)
                        Console.WriteLine("Pressed 8");
                        Console.Clear();// Очистить экран
                        ShowMenu(); // Вывод меню 
                        break;

                    case ConsoleKey.D9:// нажата 9 Совершить покупку на {price} рублей
                        string from_account; //= "2204 2256 5331 3576"; // с какого счёта будем(буду) снимать деньги
                        string to_account = ""; // номер счёта, получатель денег. Не реализован пока

                        Console.WriteLine("Нажата 9");

                        Console.WriteLine("*********");
                        Console.WriteLine("Введите номер счёта с которого делаем перевод");
                        from_account = Console.ReadLine();
                        Console.WriteLine("*********");

                        Console.WriteLine("Совершаем покупку");

                        dbService.MakePurchase(from_account, to_account, price); 
                        break;

                    case 0: // не работает...
                        Console.WriteLine("Default");
                        break;

                }
            }
        }
    }
}
