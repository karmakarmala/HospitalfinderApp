using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json.Linq;
using System.Data;
using HospitalfinderApp.Models;

namespace HospitalfinderApp.Controllers
{
    public class HospitalController : Controller
    {
        public async Task<IActionResult> Index()
        {

            var url = "http://dmmw-api.australiaeast.cloudapp.azure.com:8080/hospitals";
            using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();

                HospitalModel hospitals = new HospitalModel();
                System.Net.Http.HttpResponseMessage response = await client.GetAsync(url).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    var result = JObject.Parse(data);
                    var items = result["_embedded"].ToString();

                    hospitals = Newtonsoft.Json.JsonConvert.DeserializeObject<HospitalModel>(items);
                }

                return View(hospitals.Hospitals.ToList());
            }
        }
    }
}
