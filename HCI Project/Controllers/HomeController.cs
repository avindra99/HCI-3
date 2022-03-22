using HCI_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCI_Project.Controllers
{
    public class HomeController : Controller
    {
        public readonly ISignLanguageInputViewRepository  _repository;

        public HomeController(ISignLanguageInputViewRepository _irepository)
        {
            _repository = _irepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            SignLanguageinputViewModel model = new SignLanguageinputViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(SignLanguageinputViewModel model)
        {
            if(model.SignInput!=null)
            {
               model.SignInput = _repository.Getdata(model.SignInput);

            }
            return View(model);
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(SignLanguageinputViewModel model)
        {
            return View(model);
        }
    }
}
