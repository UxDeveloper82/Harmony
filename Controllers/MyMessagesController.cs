using Microsoft.AspNetCore.Mvc;
using mysiteR.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysiteR.Controllers
{
    public class MyMessagesController: Controller
    {
        public ActionResult Index() 
        {
            return View();        
        }

        public ActionResult New() 
        {
            var viewModel = new MyMessagesViewModel();

            return View(viewModel);
        }
    }
}
