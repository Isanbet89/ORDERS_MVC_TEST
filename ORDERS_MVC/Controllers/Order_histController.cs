using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ORDERS_MVC.Models;

namespace ORDERS_MVC.Controllers
{
    public class Order_histController : Controller
    {
        private OrderContext db = new OrderContext();

        // GET: Order_hist
        public async Task<ActionResult> Index()
        {
            return View(await db.Order_hists.ToListAsync());
        }

        // GET: Order_hist/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order_hist order_hist = await db.Order_hists.FindAsync(id);
            if (order_hist == null)
            {
                return HttpNotFound();
            }
            return View(order_hist);
        }

        // GET: Order_hist/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Order_hist/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Order_histId,StatusId,dateChange,comment")] Order_hist order_hist)
        {
            if (ModelState.IsValid)
            {
                db.Order_hists.Add(order_hist);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(order_hist);
        }

        // GET: Order_hist/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order_hist order_hist = await db.Order_hists.FindAsync(id);
            if (order_hist == null)
            {
                return HttpNotFound();
            }
            return View(order_hist);
        }

        // POST: Order_hist/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Order_histId,StatusId,dateChange,comment")] Order_hist order_hist)
        {
            if (ModelState.IsValid)
            {
                db.Entry(order_hist).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(order_hist);
        }

        // GET: Order_hist/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order_hist order_hist = await db.Order_hists.FindAsync(id);
            if (order_hist == null)
            {
                return HttpNotFound();
            }
            return View(order_hist);
        }

        // POST: Order_hist/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Order_hist order_hist = await db.Order_hists.FindAsync(id);
            db.Order_hists.Remove(order_hist);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
