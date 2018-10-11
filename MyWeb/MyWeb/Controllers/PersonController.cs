using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWeb.Models;
using Microsoft.AspNet.Identity;

namespace MyWeb.Controllers
{
    public class PersonController : Controller
    {
        PhoneBookDbEntities db;
        public PersonController()
        {
            db = new PhoneBookDbEntities();
        }
        // GET: Person
        public ActionResult Index()
        {
            List<Person> p = db.People.ToList();
            return View(p);
           
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(Person p)
        {
            string admin = User.Identity.GetUserId();
            try
            {
                // TODO: Add insert logic here
                Person obj = new Person();
                obj.FirstName = p.FirstName;
                obj.MiddleName = p.MiddleName;
                obj.LastName = p.LastName;
                obj.LinkedInId = p.LinkedInId;
                obj.FaceBookAccountId = p.FaceBookAccountId;
                obj.EmailId = p.EmailId;
                obj.AddedOn = DateTime.Now;
                obj.AddedBy = admin;
                obj.DateOfBirth = p.DateOfBirth;
                obj.TwitterId = p.TwitterId;
                obj.HomeAddress = p.HomeAddress;
                obj.HomeCity = p.HomeCity;
                db.People.Add(obj);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Person/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
       
        public ActionResult Contacts(int id)
        {
            return View();
        }
    }
}
