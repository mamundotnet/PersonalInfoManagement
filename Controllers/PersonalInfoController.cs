using Microsoft.AspNetCore.Mvc;
using PersonalInfoManagement.Models.DbModels;
using PersonalInfoManagement.Services.Interfaces;

namespace PersonalInfoManagement.Controllers
{
    public class PersonalInfoController : Controller
    {
        private readonly IPersonalInfoService _service;

        public PersonalInfoController(IPersonalInfoService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var data = _service.GetAll();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PersonalInfo model)
        {
            if (ModelState.IsValid)
            {
                _service.Add(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var data = _service.GetById(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(PersonalInfo model)
        {
            _service.Update(model);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var data = _service.GetById(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
