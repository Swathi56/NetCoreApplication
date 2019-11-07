using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreApplication.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;

namespace CoreApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IHostingEnvironment _hostingEnvironment;

        public HomeController(ILogger<HomeController> logger, IHostingEnvironment hostingEnvironment)
        {
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }

        /// <summary>
        /// Home Page
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            RootObject model = ReadJsonFile();
            var pages = model.pages.Where(x => x.pageTitle == "Home Page").Select(x => x).ToList();            
            return View(pages);
        }

        /// <summary>
        /// Inner Page One 
        /// </summary>
        /// <returns></returns>

        [Route("inner-page-1")]
        public IActionResult InnerPageOne()
        {
            RootObject model = ReadJsonFile();
            var pages = model.pages.Where(x => x.pageTitle == "Inner Page 1").Select(x => x).ToList();
            return View("index", pages);
        }

        /// <summary>
        /// Inner Page Two
        /// </summary>
        /// <returns></returns>

        [Route("inner-page-2")]
        public IActionResult InnerPageTwo()
        {
            RootObject model = ReadJsonFile();
            var pages = model.pages.Where(x => x.pageTitle == "Inner Page 2").Select(x => x).ToList();
            return View("index", pages);
        }

        /// <summary>
        /// To get JSON data for header and footer
        /// </summary>
        /// <returns></returns>
        public JsonResult GetJSONDetails()
        {
            var data= ReadJsonFile();
            return Json(new { data=data});
        }

        /// <summary>
        /// To read JSON data from JSON file.
        /// </summary>
        /// <returns></returns>
        RootObject ReadJsonFile()
        {
            string jsonPath = _hostingEnvironment.ContentRootPath;
            jsonPath = jsonPath + "\\cmsdata.json";
            RootObject items;

            using (StreamReader r = new StreamReader(jsonPath))
            {
                string json = r.ReadToEnd();
                 items = JsonConvert.DeserializeObject<RootObject>(json);
            }

            return items;
        }


        /// <summary>
        /// Contact Page
        /// </summary>
        /// <returns></returns>
        [Route("Contact")]
        public IActionResult Contact()
        {
            return View();
        }

        /// <summary>
        /// Error Page
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /// <summary>
        /// To Write JSON data to JSON file. 
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public JsonResult writejson(string firstname,string lastname,string email,string phone)
        {
            ContactModel model = new ContactModel();
            model.FirstName = firstname;
            model.LastName = lastname;
            model.Email = email;
            model.Phone = phone;

            // Pass the "personlist" object for conversion object to JSON string  
            string jsondata = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            string path = _hostingEnvironment.ContentRootPath + "\\Contact.json";
            System.IO.File.WriteAllText(path, jsondata);           
           
            return Json(new { data = "Success" });
        }
    }
   
}
