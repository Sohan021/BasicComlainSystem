using Complain_System.Models.Regular;
using Complain_System.Persistence;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Complain_System.Controllers
{
    public class ComplainCategoryController : Controller
    {
        private readonly AppDbContext _context;

        public ComplainCategoryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var batches = _context.ComplainCategories.ToList();
            return View(batches);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ComplainCategory complain)
        {
            if (ModelState.IsValid)
            {
                var batchexist = _context.ComplainCategories.FirstOrDefault(_ => _.Category == complain.Category);
                if (batchexist != null)
                {
                    ViewBag.message = "Already Exist";
                }

                _context.Add(complain);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(complain);
        }

        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var complain = _context.ComplainCategories.Find(id);
            if (complain == null)
            {
                return NotFound();
            }
            return View(complain);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ComplainCategory complain)
        {
            if (ModelState.IsValid)
            {
                _context.Update(complain);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(complain);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var complain = _context.ComplainCategories.Find(id);
            if (complain == null)
            {
                return NotFound();
            }
            return View(complain);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id, ComplainCategory complain)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (id != complain.Id)
            {
                return NotFound();
            }

            var B = _context.ComplainCategories.Find(id);

            if (B == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Remove(B);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(complain);
        }

    }
}
