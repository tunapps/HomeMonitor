using HomeMonitor.DAL.Models;
using HomeMonitor.DAL.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeMonitor.Web2.Pages
{
  public class IndexModel : PageModel
  {
    private readonly ILogger<IndexModel> _logger;
    private readonly BasicInfoService _basicInfoService;

    public IndexModel(ILogger<IndexModel> logger, BasicInfoService basicInfoService)
    {
      _logger = logger;
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
