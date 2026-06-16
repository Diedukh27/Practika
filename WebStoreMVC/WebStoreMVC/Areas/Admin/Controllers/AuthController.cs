using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace WebStoreMVC.Areas.Admin.Controllers;

[Area("Admin")]

public class AuthController : Controller
{
  public IActionResult ForgotPasswordBasic() => View();
  public IActionResult LoginBasic() => View();
  public IActionResult RegisterBasic() => View();
}
