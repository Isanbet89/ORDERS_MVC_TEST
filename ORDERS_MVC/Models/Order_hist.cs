using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ORDERS_MVC.Models
{
    public class Order_hist
    {
        // ID заявки
        public int Order_histId { get; set; }
        // ID статуса (из таблицы статусов)
        public int StatusId { get; set; }
        // дата изменения статуса
        public DateTime dateChange { get; set; }
        // Комментарий
        public string comment { get; set; }

    }
}