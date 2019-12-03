using Pidev.data;
using Presentation.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Pidev.Presentation.Controllers
{
    public class FraisController : Controller
    {
        IFFraiSer a = null;
        IExpensesService b = null;
        // GET: Frai
        public FraisController()
        {
            b = new ExpensesService();
            a = new FFraiSer();
        }
        public ActionResult Index(string searchString)
        {
            var maliste = new List<fraiVM>();
            IEnumerable<frais> fDomain = a.GetMany();
            if (!String.IsNullOrEmpty(searchString))
            {
                fDomain = a.GetFraiByLib(searchString);
            }
            foreach (var vv in fDomain)
            {
                maliste.Add(new fraiVM
                {
                    //id_frais = vv.id_frais,
                    libelle = vv.libelle,
                    DTreat = (DateTime)vv.DTreat,
                    NetRemb = vv.NetRemb,
                    StatusFrais = vv.StatusFrais,
                    uneExp_id_Exp = vv.uneExp_id_Exp


                });

            }
            return View(maliste);
        }


        // GET: Frai/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Frai/Create
        public ActionResult Create()
        {
            var depenses = b.GetMany().ToList();
            ViewBag.listexp = new SelectList(depenses, "id_Exp", " id_Exp");
            ViewBag.listexp = depenses;
            return View();
        }

        // POST: Frai/Create
        [HttpPost]
        public ActionResult Create(frais vv, int abc)
        {
            var depenses = b.GetMany().ToList();

            ViewBag.listexp = new SelectList(depenses, "id_Exp", "id_Exp");
            ViewBag.listmiss = depenses;

            fraiVM d = new fraiVM()
            {
                id_frais = vv.id_frais,
                libelle = vv.libelle,
                DTreat = (DateTime)vv.DTreat,
                NetRemb = vv.NetRemb,
                StatusFrais = vv.StatusFrais,

                uneExp_id_Exp = vv.uneExp_id_Exp
            };

            vv.uneExp_id_Exp = abc;
            a.Add(vv);
            a.Commit();
            //Service.Dispose();   
            return RedirectToAction("Index");

        }
        // GET: Frais/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Frais/Edit/5
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

        // GET: Frais/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            frais p = a.GetById(id);

            fraiVM p1 = new fraiVM()
            {

                libelle = p.libelle,
                DTreat = (DateTime)p.DTreat,
                NetRemb = p.NetRemb,
                StatusFrais = p.StatusFrais,

                uneExp_id_Exp = p.uneExp_id_Exp
            };

            if (p == null)
                return HttpNotFound();
            return View();
        }


        // POST: Frais/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, fraiVM vv)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (id == null)
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                    frais p = a.GetById(id);
                    vv = new fraiVM()
                    {

                        libelle = p.libelle,
                        DTreat = (DateTime)p.DTreat,
                        NetRemb = p.NetRemb,
                        StatusFrais = p.StatusFrais,

                        uneExp_id_Exp = p.uneExp_id_Exp
                    };


                    if (p == null)
                        return HttpNotFound();
                    Console.WriteLine("Deleted");
                    a.Delete(p);
                    a.Commit();
                    // Service.Dispose();
                    return RedirectToAction("Index");
                }
                // TODO: Add delete logic here
                return View(vv);

            }
            catch
            {
                return View();
            }
        }
    }
}
