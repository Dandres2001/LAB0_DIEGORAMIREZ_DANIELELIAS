using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LAB0_DIEGORAMIREZ_DANIELELIAS.Models.Data;

namespace LAB0_DIEGORAMIREZ_DANIELELIAS.Controllers
{
    public class ClientController : Controller
    {
        // GET: ClientController
        public ActionResult Index()
        {
            return View(Singleton.Instance.ClientsList);
        }

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var newClient = new Models.Client
                {
                    Name = collection["Name"],
                    LastName = collection["LastName"],
                    PhoneNumber = Convert.ToInt32(collection["PhoneNumber"]),
                    Description = collection["Description"]
                };
                Singleton.Instance.ClientsList.Add(newClient);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult SortName()
        {
            //algoritmo de dijkstra
            return View(Singleton.Instance.ClientsList);
        }

        public ActionResult SortLastName()
        {
            //algoritmo de dijkstra
            return View(Singleton.Instance.ClientsList);
        }


        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                Singleton.Instance.ClientsList.Remove(Singleton.Instance.ClientsList[id]);

            return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
