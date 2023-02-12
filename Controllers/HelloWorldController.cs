using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    //
    // GET: /HelloWorld/
    public string Index()
    {
        return "This is my default action...";
    }

    // //
    // // GET: /HelloWorld/Welcome/
    // public string Welcome()
    // {
    //     return "This is the Welcome action method...";
    // }

    // GET: /HelloWorld/Welcome/
    // Requires using System.Text.Encodings.Web;
    // public string Welcome(string name, int numTimes = 1)
    // {
    //     return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    // }
    public string Welcome(string name, int ID = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    }
}
