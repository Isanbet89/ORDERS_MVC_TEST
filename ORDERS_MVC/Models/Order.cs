using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ORDERS_MVC.Models
{
    public class Order
    {
        // ID заявки
        public int OrderId { get; set; }
        // заголовок заявки
        public string nameOrder { get; set; }
        // дата создания
        public DateTime dateCreate { get; set; }
        //Автор (из таблицы авторов)
        public int AutorId { get; set; }
    }
}