using Contact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Contact.Controllers
{
    public class HomeController : Controller
    {
        List<Person> contacts = Singleton.Instance.Contacts;

        public ActionResult Index()
        {
            //list out all the 
            return View(contacts);
        }

        public ActionResult Details(int id)
        {
            Person contact = contacts.Find(x => x.ID == id);

            return View(contact);
        }

        [HttpGet]
        public ActionResult AddContact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddContact(Person contact)
        {
            contact.ID = contacts.Count;
            contacts.Add(contact);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public ActionResult UpdateContact(int id)
        {
            var contact = contacts.Find(x => x.ID == id);


            return View(contact);
        }
        [HttpPost]
        public ActionResult UpdateContact(Person contact)
        {
            var person = contacts.Find(x => x.ID == contact.ID);
            contacts.Remove(person);

            contacts.Add(contact);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DeleteContact(int id = 0)
        {
            var person = contacts.Find(x => x.ID == id);
            contacts.Remove(person);

            //return View(contact);
            return RedirectToAction("Index");
        }

        //[HttpPost, ActionName("Delete")]
        //public ActionResult DeleteContactConfirmed(int id)
        //{
        //    var person = contacts.Find(x => x.ID == id);
        //    contacts.Remove(person);

        //    return RedirectToAction("Index");
        //}
    }
}