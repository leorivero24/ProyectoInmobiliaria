using Microsoft.AspNetCore.Mvc;
using ProyectoInmobiliaria.Data;
using ProyectoInmobiliaria.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ProyectoInmobiliaria.Controllers
{
    public class InquilinosController : Controller
    {
        private readonly InmobiliariaContext _context;

        public InquilinosController(InmobiliariaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Inquilinos.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Inquilino inquilino)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inquilino);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(inquilino);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var inquilino = await _context.Inquilinos.FindAsync(id);
            if (inquilino == null) return NotFound();

            return View(inquilino);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Inquilino inquilino)
        {
            if (id != inquilino.Id) return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(inquilino);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(inquilino);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var inquilino = await _context.Inquilinos.FirstOrDefaultAsync(m => m.Id == id);
            if (inquilino == null) return NotFound();

            return View(inquilino);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inquilino = await _context.Inquilinos.FindAsync(id);
            _context.Inquilinos.Remove(inquilino);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
