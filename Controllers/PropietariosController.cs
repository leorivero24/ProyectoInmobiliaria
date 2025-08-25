using Microsoft.AspNetCore.Mvc;
using ProyectoInmobiliaria.Data;
using ProyectoInmobiliaria.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ProyectoInmobiliaria.Controllers
{
    public class PropietariosController : Controller
    {
        private readonly InmobiliariaContext _context;

        public PropietariosController(InmobiliariaContext context)
        {
            _context = context;
        }

        // GET: Propietarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Propietarios.ToListAsync());
        }

        // GET: Propietarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Propietarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Propietario propietario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(propietario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(propietario);
        }

        // GET: Propietarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var propietario = await _context.Propietarios.FindAsync(id);
            if (propietario == null) return NotFound();

            return View(propietario);
        }

        // POST: Propietarios/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Propietario propietario)
        {
            if (id != propietario.Id) return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(propietario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(propietario);
        }

        // GET: Propietarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var propietario = await _context.Propietarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (propietario == null) return NotFound();

            return View(propietario);
        }

        // POST: Propietarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var propietario = await _context.Propietarios.FindAsync(id);
            _context.Propietarios.Remove(propietario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
