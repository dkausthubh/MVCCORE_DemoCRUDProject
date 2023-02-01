
using CoreApp.DataAccessLayer;
using CoreApp.DataAccessLayer.Infrastructure.IRepository;
using CoreApp.DataAccessLayer.Infrastructure.Repository;
using coreAppModels;
using Microsoft.AspNetCore.Mvc;

namespace coreMVCDemo.Controllers
{
    public class CategoryController : Controller
    {
        public IUnitOfWork _unitofwork;
        
        public CategoryController(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> categories = _unitofwork.Category.GetAll();
            return View(categories);
           
        }

        [HttpGet]
        public IActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _unitofwork.Category.Add(category);
                _unitofwork.Save();
                TempData["success"] = "Category created done";
                return RedirectToAction("Index");
            }
            return View(category);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            { return NotFound(); }
            var category = _unitofwork.Category.GetT(x => x.Id==id); ;
            if (category == null)
            { return NotFound(); }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _unitofwork.Category.Update(category);
                _unitofwork.Save();
                TempData["success"] = "Category Edit done";
                return RedirectToAction("Index");
            }
            return View("Index");
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            { return NotFound(); }
            var category = _unitofwork.Category.GetT(x => x.Id == id);
            if (category == null)
            { return NotFound(); }
            return View(category);
        }
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteData(int? id)
        {
            var category = _unitofwork.Category.GetT(x => x.Id == id);
            if (category == null)
            { return NotFound(); }
            _unitofwork.Category.Delete(category);
            _unitofwork.Save();
            TempData["success"] = "Category Deleted";
            return RedirectToAction("Index");
            
            
        }
    }
}
