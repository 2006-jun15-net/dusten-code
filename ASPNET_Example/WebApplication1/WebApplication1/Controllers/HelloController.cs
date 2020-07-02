using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace WebApplication1.Controllers {

    public class HelloController : Controller {

        public ViewResult Hello1 () {
            return View ("hello", "this string is the model");
        }
    }
}
