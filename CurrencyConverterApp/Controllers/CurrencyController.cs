using CurrencyConverterApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CurrencyConverterApp.Controllers
{
    public class CurrencyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> GetGurrencies(API_Obj model)
        //{
        //    string UrlString = $"https://v6.exchangerate-api.com/v6/bd6f1088fdf3f96a63537a80/pair/{model.base_code}/{model.target_code}/{model.Amount}";

        //    API_Obj Test = new API_Obj();
        //    using (var webClient = new System.Net.WebClient())
        //    {
        //        var json = webClient.DownloadString(UrlString);
        //         Test = JsonConvert.DeserializeObject<API_Obj>(json);
                
        //    }


        //    return View(Test);

        //}


        [HttpPost]
        public async Task<JsonResult> Result(API_Obj model)
        {
            string UrlString = $"https://v6.exchangerate-api.com/v6/bd6f1088fdf3f96a63537a80/pair/{model.base_code}/{model.target_code}/{model.Amount}";

            var test = new API_Obj();
            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString(UrlString);
                test = JsonConvert.DeserializeObject<API_Obj>(json);

            }

            return Json(test);

        }

    }
}
