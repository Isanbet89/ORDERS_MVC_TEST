using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ORDERS_MVC.Models
{
    public class OrderDbInitializer : DropCreateDatabaseAlways<OrderContext>
    {
        protected override void Seed(OrderContext db)
        {


            base.Seed(db);
        }
    }
}