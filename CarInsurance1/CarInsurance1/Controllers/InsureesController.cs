using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance1.Models;

namespace CarInsurance1.Controllers
{
    public class InsureesController : Controller
    {
        private QuoteEntities db = new QuoteEntities();

        // GET: Insurees
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insurees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insurees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insurees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                int total = 50;
                //int birthdate = Convert.ToInt32(insuree.DateOfBirth);
                //int currentAge = DateTime.Now.Year - birthdate;

                if ((DateTime.Now).Year - (Convert.ToDateTime(insuree.DateOfBirth)).Year < 18)
                    {
                    total = +25;
                }

                if ((DateTime.Now).Year - (Convert.ToDateTime(insuree.DateOfBirth)).Year < 25)
                {
                    total = +100;
                }

                if ((DateTime.Now).Year - (Convert.ToDateTime(insuree.DateOfBirth)).Year > 100)
                {
                    total = +25;
                }

                

                int vehicleYear = Convert.ToInt32(insuree.CarYear);

                if (vehicleYear < 2000)
                {
                    total = +25;
                }
                else
                {
                    total = +0;
                }

                if (vehicleYear > 2015)
                {
                    total = +25;
                }

                if (insuree.CarMake == "Porsche")
                {
                    total = +25;
                }

                if (insuree.CarMake == "Carrera")
                {
                    total = +25;
                }

                int ticket = Convert.ToInt32(insuree.SpeedingTickets);
                if (ticket >= 1)
                {
                    total = +25;
                }

                //bool drinker = Convert.ToBoolean(DUI);

                if (insuree.DUI == true)
                {
                    total = total + Convert.ToInt32(.25m);
                }

                //bool type = Convert.ToBoolean(coverageType);
                if (insuree.CoverageType == true)
                {
                    total = total + Convert.ToInt32(.50m);
                }
                else
                {
                    total = +0;
                }

                if (insuree.Quote > 0)
                {
                    Console.WriteLine("Your Quote is: {0} ", total);
                    Console.ReadLine();
                }
                

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insurees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insurees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insurees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insurees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
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
