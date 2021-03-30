using Complain_System.Models.Auth;
using Complain_System.Models.Regular;
using Complain_System.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Complain_System.Controllers
{
    public class ComplainController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ComplainController(AppDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var complains = _context.Complains.Include(s => s.ComplainCategory).ToList();

            return View(complains);
        }

        public IActionResult Complain()
        {
            var complains = _context.Complains.Include(s => s.ComplainCategory).ToList();

            return View(complains);
        }

        public IActionResult MyComplain()
        {
            var userId = _userManager.GetUserId(User);

            var complains = _context.Complains.Where(_ => _.ApplicationUser.Id == userId).Include(s => s.ComplainCategory).ToList();

            return View(complains);
        }

        public IActionResult ComplainDetails(int? id)
        {
            var complain = _context.Complains.Where(_ => _.Id == id).Include(s => s.ComplainCategory).ToList();

            return View(complain);
        }

        public IActionResult Create()
        {
            var cat = _context.ComplainCategories.ToList();
            ViewData["bId"] = new SelectList(cat, "Id", "Category");
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Create(Complain model)
        {
            if (ModelState.IsValid)
            {
                //var semesterExist = _context.Complains.FirstOrDefault(s => s.Id == model.Id);
                //if (semesterExist != null)
                //{
                //    ViewBag.message = "Already Exist";
                //}

                var userId = _userManager.GetUserId(User);

                var userdet = _context.Users.Where(_ => _.Id == userId).FirstOrDefault();

                var batch = _context.ComplainCategories.FirstOrDefault();

                if (batch != null)
                {
                    var com = new Complain
                    {
                        Area = model.Area,
                        Details = model.Details,
                        FirstName = userdet.FirstName,
                        LastName = userdet.LastName,
                        Email = userdet.Email,
                        ContactNo = userdet.ContactNo,
                        UserId = userId,
                        ApplicationUser = userdet,
                        ComplainCategory = batch
                    };
                    _context.Complains.Add(com);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Complain));
                }
            }
            return View(model);
        }

        public IActionResult Update(int? id)
        {
            var cat = _context.ComplainCategories.ToList();
            ViewData["bId"] = new SelectList(cat, "Id", "Category");

            if (id == null)
            {
                return NotFound();
            }
            var semester = _context.Complains.Find(id);

            if (semester == null)
            {
                return NotFound();
            }

            return View(semester);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Complain complain)
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

            var complain = _context.Complains.Find(id);

            if (complain == null)
            {
                return NotFound();
            }

            return View(complain);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id, Complain complain)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (id != complain.Id)
            {
                return NotFound();
            }
            var comp = _context.Complains.Find(id);
            if (comp == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _context.Remove(comp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(comp);
        }
    }
}
