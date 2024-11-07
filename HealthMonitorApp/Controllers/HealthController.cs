using HealthMonitorApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

public class HealthController : Controller
{
    private readonly HealthService _healthService;

    // Constructor to inject HealthService
    public HealthController(HealthService healthService)
    {
        _healthService = healthService;
    }

    public IActionResult Dashboard(string userId)
    {
        return View();
    }
    public IActionResult AddHealthRecord(string userId)
    {
        return View();
    }
    public async Task<IActionResult> ViewRecord(int id)
    {

        return View();

       
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
