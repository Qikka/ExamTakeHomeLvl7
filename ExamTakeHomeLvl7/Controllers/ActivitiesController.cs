using Microsoft.AspNetCore.Mvc;
using ExamTakeHomeLvl7.Models;

namespace ExamTakeHomeLvl7.Controllers
{
    public class ActivitiesController : Controller
    {
        readonly ApplicationDbContext _db;

        public ActivitiesController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Activities.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Name, Date")] Activity activity)
        {
            if(ModelState.IsValid)
            {
                _db.Activities.Add(activity);
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(activity);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var activity = _db.Activities.FirstOrDefault(x => x.Id == id);

            if (activity == null)
            {
                return NotFound();
            }

            return View(activity);
        }

        [HttpPost]

        public IActionResult Delete(int id)
        {
            var activity = _db.Activities.FirstOrDefault(x => x.Id == id);

            if (activity == null)
            {
                return NotFound();
            }

            _db.Activities.Remove(activity);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));

        }
    }
}
