using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebStoreMVC.Areas.Admin.Models;

namespace WebStoreMVC.Areas.Admin.Controllers;

[Area("Admin")]

public class IconsController : Controller
{
  public IActionResult RiIcons() => View();
}
