using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebStoreMVC.Areas.Admin.Models;

namespace WebStoreMVC.Areas.Admin.Controllers;

[Area("Admin")]

public class ExtendedUiController : Controller
{
  public IActionResult PerfectScrollbar() => View();
  public IActionResult TextDivider() => View();
}
