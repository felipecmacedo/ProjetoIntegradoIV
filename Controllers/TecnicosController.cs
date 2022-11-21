using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoIntegradoIV.Models;

namespace ProjetoIntegradoIV.Controllers
{
    public class TecnicosController : Controller
    {
        private readonly ProjetoIntegradoContext _context;

        public TecnicosController(ProjetoIntegradoContext context)
        {
            _context = context;
        }

        // GET: Tecnicos
        public async Task<IActionResult> Index()
        {
              return _context.Tecnicos != null ? 
                          View(await _context.Tecnicos.ToListAsync()) :
                          Problem("Entity set 'ProjetoIntegradoContext.Tecnicos'  is null.");
        }

        // GET: Tecnicos/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if(id == 0)
                return View(new Tecnico());
            else
                return View(_context.Tecnicos.Find(id));
        }

        // POST: Tecnicos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("Apelido,AnosExperiencia,tempoContrato,Id,Nome,AnoNasc,Idade,Altura,Peso,Salario")] Tecnico tecnico)
        {
            if (ModelState.IsValid)
            {
                if (tecnico.Id == 0)
                    _context.Add(tecnico);
                else
                    _context.Update(tecnico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tecnico);
        }

        // GET: Tecnicos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (_context.Tecnicos == null)
            {
                return Problem("Entity set 'ProjetoIntegradoContext.Tecnicos'  is null.");
            }
            var tecnico = await _context.Tecnicos.FindAsync(id);
            if (tecnico != null)
            {
                _context.Tecnicos.Remove(tecnico);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
