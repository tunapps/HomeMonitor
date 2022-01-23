using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeMonitor.DAL.Models;
using HomeMonitor.DAL.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeMonitor.Web1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BasicInfoService _basicInfoService;

        public IndexModel(BasicInfoService basicInfoService)
        {
            _basicInfoService = basicInfoService;
        }

        public BasicInfo BasicInfo { get; set; }

        public void OnGet()
        {
            BasicInfo = _basicInfoService.GetBasicInfo();
            //Response.Headers.Add("Refresh", "10");
        }
    }
}
