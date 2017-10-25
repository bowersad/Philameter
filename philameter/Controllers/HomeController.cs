using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using philameter.DAL;
using philameter.DAL.Entities;
using philameter.DAL.Repositories;
using RestSharp;


namespace philameter.Controllers
{
    public class HomeController : Controller
    {
        private PhilaModelService  service;

        public HomeController()
        {
            service = new PhilaModelService();
        }
        

        public ActionResult Dashboard()
        {
            var StatsModel = service.Stats.Get();

            return View(StatsModel);
        }

        [Route("/Home/NewDash")]
        public  ActionResult NewDash()
        {
            var client = new RestClient("http://api.philameter.com");
            // client.Authenticator = new HttpBasicAuthenticator(username, password);

            var request = new RestRequest("/Stats", Method.GET);
            //request.AddParameter("name", "value"); // adds to POST or URL querystring based on Method
            //request.AddUrlSegment("id", "123"); // replaces matching token in request.Resource

            // easily add HTTP Headers
            //request.AddHeader("header", "value");

            // add files to upload (works with compatible verbs)
            ///request.AddFile(path);

            // execute the request
            //IRestResponse response = client.Execute(request);
            //var content = response.Content; // raw content as string

            // or automatically deserialize result
            // return content type is sniffed but can be explicitly set via RestClient.AddHandler();
            //List<Stats> StatsModel;
            var response2 = client.Execute<List<Stats>>(request);
            var StatsModel = response2.Data;

            // easy async support
            //client.ExecuteAsync(request, response => {
            //    Console.WriteLine(response.Content);
            //});

            //var StatsModel = service.Stats.Get();
            //StatsModel = response2;

            return View(StatsModel);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}