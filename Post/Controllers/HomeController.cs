using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public FileResult DownloadMessage()
        {
            String text = "Hola mundo" + Environment.NewLine + "Hoy es Martes";
            byte[] result = Encoding.ASCII.GetBytes(text);
            return File(result, "text/plain", "mensaje.txt");
        }

        public FileResult DownloadStream()
        {
            String text = "Hola mundo" + Environment.NewLine + "Hoy es Martes";
            byte[] result = Encoding.ASCII.GetBytes(text);
            var stream = new MemoryStream(result);
            return File(stream, "text/plain", "stream.txt");
        }

        [HttpPost]
        public FileResult DownloadPersonalizado(String mensaje)
        {
            String text = mensaje;
            byte[] result = Encoding.ASCII.GetBytes(text);
            return File(result, "text/html", "personalizado.html");
            //return File(result, "text/html");
        }

    }
}
