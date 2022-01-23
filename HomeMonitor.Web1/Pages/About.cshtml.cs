using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeMonitor.DAL.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeMonitor.Web1.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }
        public double IndoorTemp { get; set; }

        private readonly BasicInfoService _basicInfoService;

        public AboutModel(BasicInfoService basicInfoService)
        {
            _basicInfoService = basicInfoService;
        }

        public void OnGet()
        {
            Message = "Your application description page.";
            
        }
    }
}
