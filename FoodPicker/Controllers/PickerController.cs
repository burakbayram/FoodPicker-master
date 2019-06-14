using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodPicker.Controllers
{
    public class PickerController : Controller
    {
        private readonly UnitOfWork _uw;
        public PickerController()
        {
            _uw = new UnitOfWork();
        }

        // GET: Picker
        public ActionResult Index()
        {
            List<Food> foodList = _uw.foodRep.GetAll();
            //ViewBag.RandomFood = _uw.foodRep.RandomFood();
            //ViewBag.HealthyRandomFood = _uw.foodRep.HealtyRandomFood();
            return View(foodList);
        }

        public ActionResult AllRandom()
        {
            ViewBag.RandomFood = _uw.foodRep.RandomFood();
            return View();
        }

        public ActionResult HealthyRandom()
        {
            ViewBag.RandomFood = _uw.foodRep.HealtyRandomFood();
            return View();
        }
        //[HttpPost]
        //public ActionResult SelectedRandom(List<Food> selectedFoodList)
        //{
        //    ViewBag.SelectedRandomFood = _uw.foodRep.SelectedRandomFood(selectedFoodList);
        //    return View();
        //}
    }
}