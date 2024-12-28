using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UI_Serial_Port_Server.Domain.Context;
using UI_Serial_Port_Server.Domain.Models.SimpleModels;

namespace UI_Serial_Port_Server.Domain.Services
{
    public class Database
    {
        /// _dbContext - экземпляр класса управления БД (EntityFrameWork)
        private ApplicationDbContext _dbContext;

        // В конструктор передаю ссылку на экземпляр БД
        public Database(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        /// <summary>
        /// Получить всех клиентов из Базы Данных. Данные получаются в виде IEnumerable, т.е. простая коллекция(перечисление)
        /// </summary>
        public IEnumerable<ClientAccountVer1> GetAllClients()
        {
            return _dbContext.clients.Select(x => x); // LINQ - выражение
        }

        /// <summary>
        /// Получение из БД только имена и фамилии клиентов. Чтобы добавить их в ListBox
        /// </summary>
        /// <returns>
        /// Возвращается перечисление IEnumerable
        /// </returns>
        public IEnumerable<ClientAccountVer1> GetOnlyNameAndSurnameClients()
        {
            yield return (ClientAccountVer1)_dbContext.clients.Select(c => new
            {
                Name = $"{c.Name} + {c.Surname}"
            });
        }

        /// <summary>
        /// Получить информацию (кортеж) только одного клиента, Id которого совпадает с входным параметром
        /// </summary>
        public ClientAccountVer1 GetClientById(int Id)
        {
            return new ClientAccountVer1 { Id = Id };
        }


        /// <summary>
        /// Добавляет нового клиента в БД
        /// Входной параметр - экземпляр класса , в котором хранятся данные о клиенте, которые ввели с формы.
        /// </summary>
        /// <param name="client"></param>
        public void AddClient(ClientAccountVer1 client)
        {
        }

        /// <summary>
        /// Удалить Клиента из БД
        /// </summary>
        /// <param name="client"></param>
        public void DeleteClient(ClientAccountVer1 client)
        {

        }

        /// <summary>
        /// Внесение изменений в домены кортежа (т.е. внести изменения в поля клиента)
        /// </summary>
        /// <param name="client"> </param>
        public void EditClient(ClientAccountVer1 client)
        {

        }
        /// <summary>
        /// Получение остатка на счёте клиента
        /// </summary>
        /// <param name="account">Входной параметр аккаунт клиента</param>
        /// <returns></returns>
        public int GetBalanceByAccount(string account)
        {
            return 0;
        }

        /// <summary>
        /// Выполнение "главной" комманды.
        ///   Проверка корректного пин-кода.
        ///   Получение остатка на счёте клиента.
        ///   Проведение операции со счётом клиента,т.е. уменьшение баланса на стоимость товара.
        ///   Проведение операции со счётом "владельца терминала", т.е. увеличение остатка на счёте на стоимость товара, 
        ///   Взятие комиссии "интерес" банка в количестве 5% от стоимости товара. Т.е Владелец Терминала получит на 5% меньше. :)
        /// </summary>
        /// <param name="client_card_account"> Номер счёта клиента</param>
        /// <param name="value"> Сумма, на которую совершается транзакция</param>
        /// <param name="PinCode"> Пин - код </param>
        /// <returns></returns>
        public bool MakePurchase(string client_card_account,int value, string PinCode)
        {
            return true;
        }
    }
}
