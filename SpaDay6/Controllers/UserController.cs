using Microsoft.AspNetCore.Mvc;
namespace SpaDay6;

public class UserController : Controller
{

[HttpGet("/user/add")]
public IActionResult Add()
{
    return View("Add");
}



[HttpPost("/user/add")]
public IActionResult SubmitAddUserForm(User newUser, string verify) 
{
    if(verify == newUser.Password)
    {
        ViewBag.name = newUser.Username;
        return View("Index");
    }
    else
    {
        ViewBag.user = newUser.Username;
        ViewBag.email =newUser.Email;
        ViewBag.error = "Error. Form needs to be submitted properly. Please Check Password";
        return View("Add");
    }




      // add form submission handling code here

}
}

