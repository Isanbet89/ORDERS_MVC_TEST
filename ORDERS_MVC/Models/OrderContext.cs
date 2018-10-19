using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ORDERS_MVC.Models 
{
    public class OrderContext : DbContext
    {
    public DbSet<Autor> Autors { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Order_hist> Order_hists { get; set; }
    public DbSet<Status> Statuses { get; set; }
}
}