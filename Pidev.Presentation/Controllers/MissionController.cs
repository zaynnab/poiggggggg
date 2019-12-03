using MongoDB.Driver.Core.WireProtocol.Messages;
using Pidev.data;
using Presentation.Models;
using Renci.SshNet.Messages.Authentication;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Pidev.Presentation.Controllers
{
    public class MissionController : Controller
    {
        IMissionService mes = null;


        public MissionController()
        {
            mes = new MissionService();
        }
        // GET: Mission
        public ActionResult Index()
        {
            HttpClient Clientt = new HttpClient();
            Clientt.BaseAddress = new Uri("http://localhost:9080");
            Clientt.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage rep = Clientt.GetAsync("/pidev-web/rest/projet").Result;
            if (rep.IsSuccessStatusCode)
            {
                ViewBag.TikTok = rep.Content.ReadAsAsync<IEnumerable<Miss>>().Result;
            }
            else
            {
                ViewBag.TikTok = "error";
            }



            return View();
        }

        // GET: Mission/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mission/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mission/Create
        [HttpPost]
        public ActionResult Create(Miss mis)
        {

            HttpClient client = new HttpClient();
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, "http://localhost:9080/pidev-web/rest/projet/new");

            string json = new JavaScriptSerializer().Serialize(new
            {
                dateDu = mis.dateDu,
                dateFin = mis.dateFin,
                libelle = mis.libelle,
                montantAlloue = mis.montantAlloue,
                motifMission = mis.motifMission,
                lieuMission = mis.lieuMission,
                etat = mis.etat
            });
            //  var data = new StringContent(Json, Encoding.UTF8, "application/json");

            requestMessage.Content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage rep = client.SendAsync(requestMessage).GetAwaiter().GetResult();


            return RedirectToAction("Index");


        }

        // GET: Mission/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Mission/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Miss mis)
        {
            HttpClient client = new HttpClient();
             
               mission p=new mission() {
                    dateDu = mis.dateDu,
                dateFin = mis.dateFin,
                libelle = mis.libelle,
                montantAlloue = mis.montantAlloue,
                motifMission = mis.motifMission,
                lieuMission = mis.lieuMission,
                etat = mis.etat
            };
                client.BaseAddress = new Uri("http://localhost:9080");
                 var response = client.PutAsJsonAsync("/pidev-web/rest/projet", p).Result;
                 if (response.IsSuccessStatusCode)
                 {
                     Console.Write("Success");
                 }
                 else
                     Console.Write("Error");


            return RedirectToAction("Index");
        }


        // GET: Mission/Delete/5
        public ActionResult Delete(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:9080");
            var response = client.DeleteAsync($"/pidev-web/rest/projet/{id}").Result;
            if (response.IsSuccessStatusCode)
            {
                Console.Write("Success");
            }
            else
                Console.Write("Error");

        

            return RedirectToAction("Index");
    }


        // POST: Mission/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, mission mis)
        {
         /*   string request = "/pidev-web/rest/projet/" + id;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:9080");
            var response = client.DeleteAsync(request).Result;
            if (response.IsSuccessStatusCode)
            {
                Console.Write("Success");
            }
            else
                Console.Write("Error");
*/
            return RedirectToAction("Index");
        }
    }
}
