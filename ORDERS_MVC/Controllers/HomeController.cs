using ORDERS_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ORDERS_MVC.Controllers
{
    public class HomeController : Controller
    {
        // создаем контекст данных
        OrderContext db = new OrderContext();

        public ActionResult Index()
        {
            // получаем из бд все объекты 
            IEnumerable<Autor> Autor = db.Autors;
            IEnumerable<Order> Order = db.Orders;
            IEnumerable<Status> Status = db.Statuses;
            IEnumerable<Order_hist> Order_hist = db.Order_hists;
            // передаем все объекты в динамическое свойство Orders в ViewBag
            ViewBag.Orders = Order;
            // возвращаем представление
            return View();
        }
    }
}